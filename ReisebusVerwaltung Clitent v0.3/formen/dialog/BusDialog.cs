using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReisebusVerwaltung_Clitent_v0._3
{
    public partial class BusDialog : Form
    {
        MySqlConnection cs = Database.GetConnectionString;
        DataSet ds = new DataSet();
        MySqlDataAdapter da = new MySqlDataAdapter();

        BindingSource tblBusAusstattungBS = new BindingSource();
        //
        string server = Properties.Settings.Default.Server;
        string database = Properties.Settings.Default.Datenbank;
        string uid = Properties.Settings.Default.Benutzername;
        string pwd = Properties.Settings.Default.Passwort;

        private int busID;
        private int ausstattungsID;
        private int sitzplanID;
        private bool hasWlan;
        private bool hasToilet;
        private bool hasDrinks;
        private int countSeats;
        private int countReclin;
        private int countSleep;

        int RanBusID;
        int RanAusstattungsID;
        int RanSitzplanID;

        Mode mode;

        public enum Mode
        {
            New = 0,
            Edit = 1,
            Show = 2
        }
        /// <summary>
        /// Ersätzt den Wert 'true' oder 'false' mit '1' oder '0'.
        /// </summary>
        /// <param name="boolean">Der umzuwandeln Boolesche Wert.</param>
        /// <returns>Bei true:1; Bei false:0</returns>
        private int BoolToBinary(bool boolean)
        {
            if (boolean)
            {
                return 1;
            }
            return 0;
        }

        public BusDialog(int busID)
        {
            InitializeComponent();
            //
            da.SelectCommand = new MySqlCommand($"SELECT b.BusID, b.AusstattungsID, b.SitzplanID, Wlan, Toilette, Getraenke, s.Sitzplaetze, s.Liegesitze, s.Schlafsitze FROM bus b LEFT JOIN busausstattung a ON(b.AusstattungsID = a.AusstattungsID) LEFT JOIN sitzplan s  ON(s.SitzplanID = b.SitzplanID) WHERE b.BusID = {busID};", cs);
            ds.Clear();
            da.Fill(ds);

            tblBusAusstattungBS.DataSource = ds.Tables[0];
            //
            DataRowView dr = (DataRowView)tblBusAusstattungBS.Current;
            //
            if (dr != null)
            {
                textBoxBusID.Text = (string)dr.Row.ItemArray[0].ToString();
                textBoxAusstatungsID.Text = (string)dr.Row.ItemArray[1].ToString();
                textBoxSitzplanID.Text = (string)dr.Row.ItemArray[2].ToString();
                checkBoxHasWlan.Checked = (bool)dr.Row.ItemArray[3];
                checkBoxHasToilete.Checked = (bool)dr.Row.ItemArray[4];
                checkBoxHasDrinks.Checked = (bool)dr.Row.ItemArray[5];
                numericUpDownCountSeats.Value = (int)dr.Row.ItemArray[6];
                numericUpDownCountReclining.Value = (int)dr.Row.ItemArray[7];
                numericUpDownCountSleep.Value = (int)dr.Row.ItemArray[8];
            }
            //
            buttonSave.Visible = false;
            buttonAbort.Text = "Ok";
            buttonAbort.Location = buttonSave.Location;
            textBoxBusID.Enabled = false;
            textBoxAusstatungsID.Enabled = false;
            textBoxSitzplanID.Enabled = false;
            numericUpDownCountSeats.Enabled = false;
            numericUpDownCountReclining.Enabled = false;
            numericUpDownCountSleep.Enabled = false;
            checkBoxHasWlan.Enabled = false;
            checkBoxHasToilete.Enabled = false;
            checkBoxHasDrinks.Enabled = false;
        }

        public BusDialog(Bus bus, Mode mode)
        {
            InitializeComponent();
            //
            this.mode = mode;
            //
            this.busID = bus.BusID;
            this.ausstattungsID = bus.AusstattungsID;
            this.sitzplanID = bus.SitzplanID;
            this.hasWlan = bus.HasWlan;
            this.hasToilet = bus.HasToilet;
            this.hasDrinks = bus.HasDrinks;
            this.countSeats = bus.CountSeats;
            this.countReclin = bus.CountReclining;
            this.countSleep = bus.CountSleeping;
            
            cs = new MySqlConnection($"Server={server};Database={database};Uid={uid};Pwd={pwd};");

            da.SelectCommand = new MySqlCommand("SELECT b.BusID, b.AusstattungsID, b.SitzplanID, Wlan, Toilette, Getraenke, s.Sitzplaetze, s.Liegesitze, s.Schlafsitze FROM bus b LEFT JOIN busausstattung a ON(b.AusstattungsID = a.AusstattungsID) LEFT JOIN sitzplan s  ON(s.SitzplanID = b.SitzplanID);", cs);
            ds.Clear();
            da.Fill(ds);

            tblBusAusstattungBS.DataSource = ds.Tables[0];
            // Bearbeiten
            if (mode == Mode.New)
            {
                Random random = new Random();
                //
                RanBusID = random.Next();
                RanAusstattungsID = random.Next();
                RanSitzplanID = random.Next();
                //
                textBoxBusID.Text = RanBusID.ToString();
                textBoxAusstatungsID.Text = RanAusstattungsID.ToString();
                textBoxSitzplanID.Text = RanSitzplanID.ToString();
                //
                buttonSave.Text = "Anlegen";
                tabControl1.TabPages[0].Text = "Bus anlegen";
            }
            else if (mode == Mode.Show || mode == Mode.Edit)
            {
                if (mode == Mode.Show)
                {
                    tabControl1.TabPages[0].Text = "Bus anzeigen";
                    buttonSave.Visible = false;
                    buttonAbort.Text = "Ok";
                    buttonAbort.Location = buttonSave.Location;
                    //
                    textBoxBusID.Enabled = false;
                    textBoxAusstatungsID.Enabled = false;
                    textBoxSitzplanID.Enabled = false;
                    numericUpDownCountSeats.Enabled = false;
                    numericUpDownCountReclining.Enabled = false;
                    numericUpDownCountSleep.Enabled = false;
                    checkBoxHasWlan.Enabled = false;
                    checkBoxHasToilete.Enabled = false;
                    checkBoxHasDrinks.Enabled = false;
                }
                else if (mode == Mode.Edit)
                {
                    buttonAbort.Text = "Schließen";
                }
                //
                textBoxBusID.Text = busID.ToString();
                textBoxAusstatungsID.Text = ausstattungsID.ToString();
                textBoxSitzplanID.Text = sitzplanID.ToString();
                checkBoxHasWlan.Checked = hasWlan;
                checkBoxHasToilete.Checked = hasToilet;
                checkBoxHasDrinks.Checked = hasDrinks;
                numericUpDownCountSeats.Value = countSeats;
                numericUpDownCountReclining.Value = countReclin;
                numericUpDownCountSleep.Value = countSleep;
            }
        }

        private void EditBusDialog_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (mode == Mode.New)
            {
                da.InsertCommand = new MySqlCommand(
                    $"INSERT INTO `bus`(`BusID`, `AusstattungsID`, `SitzplanID`) VALUES ('{RanBusID}', '{RanAusstattungsID}', '{RanSitzplanID}');" +
                    $"INSERT INTO `busausstattung`(`AusstattungsID`, `Wlan`, `Toilette`, `Getraenke`) VALUES('{RanAusstattungsID}', '{BoolToBinary(checkBoxHasWlan.Checked)}', '{BoolToBinary(checkBoxHasToilete.Checked)}', '{BoolToBinary(checkBoxHasDrinks.Checked)}');" +
                    $"INSERT INTO `sitzplan`(`SitzplanID`, `Schlafsitze`, `Liegesitze`, `Sitzplaetze`) VALUES('{RanSitzplanID}', '{numericUpDownCountSleep.Value}', '{numericUpDownCountReclining.Value}', '{numericUpDownCountSeats.Value}'); ", cs);
                cs.Open();
                try
                {
                    da.InsertCommand.ExecuteNonQuery();
                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                cs.Close();
            }
            else if (mode == Mode.Edit)
            {
                da.UpdateCommand = new MySqlCommand(
                    $"UPDATE `busausstattung` SET `Wlan`= '{BoolToBinary(checkBoxHasWlan.Checked)}',`Toilette`= '{BoolToBinary(checkBoxHasToilete.Checked)}',`Getraenke`= '{BoolToBinary(checkBoxHasDrinks.Checked)}' WHERE AusstattungsID = '{textBoxAusstatungsID.Text}';" +
                    $"UPDATE `sitzplan` SET `Schlafsitze`= '{numericUpDownCountSleep.Value}', `Liegesitze`= '{numericUpDownCountReclining.Value}', `Sitzplaetze`= '{numericUpDownCountSeats.Value}' WHERE SitzplanID = '{textBoxSitzplanID.Text}';", cs);

                cs.Open();
                int x = da.UpdateCommand.ExecuteNonQuery();
                cs.Close();

                if (x > 0)
                {
                    MessageBox.Show($"Änderung Erfolgreich.");
                }
            }
            Close();            
        }

        private void numericUpDownCountReclining_ValueChanged(object sender, EventArgs e)
        {
            if (!(numericUpDownCountReclining.Value + numericUpDownCountSleep.Value <= numericUpDownCountSeats.Value))
            {
                numericUpDownCountReclining.Value = numericUpDownCountSeats.Value - numericUpDownCountSleep.Value;
            }
        }

        private void numericUpDownCountSleep_ValueChanged(object sender, EventArgs e)
        {
            if (!(numericUpDownCountReclining.Value + numericUpDownCountSleep.Value <= numericUpDownCountSeats.Value))
            {
                numericUpDownCountSleep.Value = numericUpDownCountSeats.Value - numericUpDownCountReclining.Value;
            }
        }
    }
}
