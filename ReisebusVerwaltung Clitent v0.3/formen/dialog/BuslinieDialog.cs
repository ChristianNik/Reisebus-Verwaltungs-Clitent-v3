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
    public partial class BuslinieDialog : Form
    {
        MySqlConnection cs = Database.GetConnectionString;
        DataSet ds = new DataSet();
        MySqlDataAdapter da = new MySqlDataAdapter();

        BindingSource tblFahrplanBS = new BindingSource();

        private int linienID;
        private int fahrplanID;
        private int busID;
        private string start;
        private string ende;

        int RanLinienID;
        int RanFahrplanID;
        int RanBusID;

        Mode mode;

        public enum Mode
        {
            New = 0,
            Edit = 1,
            Show = 2
        }

        public BuslinieDialog(int linienID, Mode mode)
        {
            InitializeComponent();
            //
            da.SelectCommand = new MySqlCommand($"SELECT * FROM buslinie WHERE linienID= {linienID};", cs);
            ds.Clear();
            da.Fill(ds);

            tblFahrplanBS.DataSource = ds.Tables[0];
            //
            DataRowView dr = (DataRowView)tblFahrplanBS.Current;
            //
            textBoxLinienID.Text = (string)dr.Row.ItemArray[0].ToString();
            comboBoxBusID.Items.Add(dr.Row.ItemArray[1]);
            comboBoxBusID.SelectedIndex = 0;
            comboBoxFahrplanID.Items.Add(dr.Row.ItemArray[2]);
            comboBoxFahrplanID.SelectedIndex = 0;
            textBoxStartHaltestelle.Text = (string)dr.Row.ItemArray[3].ToString();
            textBoxEndHaltestelle.Text = (string)dr.Row.ItemArray[4].ToString();
        }

        public BuslinieDialog(Buslinie buslinie, Mode mode)
        {
            Random random;

            InitializeComponent();
            //
            this.mode = mode;
            //
            linienID = buslinie.LinienID;
            fahrplanID = buslinie.FahrplanID;
            busID = buslinie.BusID;
            start = buslinie.Start;
            ende = buslinie.Ende;

            if (mode == Mode.New)
            {
                buttonSave.Text = "Anlegen";

                random = new Random();
                //
                RanLinienID = random.Next();
                //
                RanLinienID = random.Next();
                RanFahrplanID = random.Next();
                RanBusID = random.Next();
                // 
                textBoxLinienID.Text = RanLinienID.ToString();
                comboBoxFahrplanID.Text = RanFahrplanID.ToString();
                comboBoxBusID.Text = RanBusID.ToString();

                
                tabControl1.TabPages[0].Text = "Bus anlegen";
            }
            else if (mode == Mode.Show || mode == Mode.Edit)
            {
                textBoxLinienID.Text = linienID.ToString();
                textBoxStartHaltestelle.Text = start;
                textBoxEndHaltestelle.Text = ende;
                if (mode == Mode.Show)
                {
                    tabControl1.TabPages[0].Text = "Buslinie anzeigen";
                    buttonSave.Visible = false;
                    buttonAbort.Text = "Ok";
                    buttonAbort.Location = buttonSave.Location;
                    random = new Random();
                    //
                    textBoxLinienID.Enabled = false;
                    comboBoxBusID.Enabled = false;
                    comboBoxFahrplanID.Enabled = false;
                    textBoxStartHaltestelle.Enabled = false;
                    textBoxEndHaltestelle.Enabled = false;
                    buttonNewBus.Enabled = false;
                    buttonNewFahrplan.Enabled = false;

                }
                else if (mode == Mode.Edit)
                {
                    buttonAbort.Text = "Schließen";
                }
            }

            GetDataFromDatabase();
        }

        private void GetDataFromDatabase()
        {
            comboBoxBusID.Items.Clear();
            comboBoxFahrplanID.Items.Clear();
            // Einträge für haltestellen
            da = new MySqlDataAdapter($"SELECT `StartHaltestelle`, `EndHaltestelle` FROM `buslinie` WHERE `LinienID` = {textBoxLinienID.Text}", cs);
            DataTable dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                textBoxStartHaltestelle.Text = dt.Rows[i][0].ToString();
                textBoxEndHaltestelle.Text = dt.Rows[i][1].ToString();
            }
            // Eingrage von Tabelle Bus
            da = new MySqlDataAdapter("SELECT * FROM bus", cs);
            dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBoxBusID.Items.Add(dt.Rows[i][0]);
            }
            // Eingrage von Tabelle Fahrplan
            da = new MySqlDataAdapter("SELECT * FROM fahrplan", cs);
            dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBoxFahrplanID.Items.Add(dt.Rows[i][0]);
            }
            // Bus ID
            for (int i = 0; i < comboBoxBusID.Items.Count; i++)
            {
                if ((int)comboBoxBusID.Items[i] == busID)
                {
                    comboBoxBusID.SelectedIndex = i;
                    break;
                }
            }
            // Fahrplan ID
            for (int i = 0; i < comboBoxFahrplanID.Items.Count; i++)
            {
                if ((int)comboBoxFahrplanID.Items[i] == fahrplanID)
                {
                    comboBoxFahrplanID.SelectedIndex = i;
                    break;
                }
            }
        }

        private void EditBuslinieDialog_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (mode == Mode.New)
            {
                da.InsertCommand = new MySqlCommand(
                    $"INSERT INTO `buslinie`(`LinienID`, `FahrplanID`, `BusID`, `Starthaltestelle`, `Endhaltestelle`) VALUES ('{textBoxLinienID.Text}', '{comboBoxFahrplanID.SelectedItem}', '{comboBoxBusID.SelectedItem}', '{textBoxStartHaltestelle.Text}', '{textBoxEndHaltestelle.Text}');", cs);
                cs.Open();
                try
                {
                    da.InsertCommand.ExecuteNonQuery();
                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                cs.Close();
            }
            else if (mode == Mode.Edit)
            {
                da.UpdateCommand = new MySqlCommand($"UPDATE `buslinie` SET `FahrplanID`='{comboBoxFahrplanID.Text}',`BusID`='{comboBoxBusID.Text}',`Starthaltestelle`='{textBoxStartHaltestelle.Text}',`Endhaltestelle`='{textBoxEndHaltestelle.Text}' WHERE `LinienID` = {textBoxLinienID.Text};", cs);
                cs.Open();
                int x = da.UpdateCommand.ExecuteNonQuery();
                cs.Close();

                if (x > 0)
                {
                    MessageBox.Show($"Eintrag erfolgreich geändert.");
                }
                Close();
            }
        }

        private void buttonShowBus_Click(object sender, EventArgs e)
        {
            if (comboBoxBusID.SelectedIndex != -1)
            {
                BusDialog editBus = new BusDialog((int)comboBoxBusID.SelectedItem);
                editBus.ShowDialog();
            }
        }

        private void buttonNewBus_Click(object sender, EventArgs e)
        {
            BusDialog editBus = new BusDialog(new Bus(), BusDialog.Mode.New);
            editBus.ShowDialog();

            GetDataFromDatabase();
        }

        private void buttonNewFahrplan_Click(object sender, EventArgs e)
        {
            FahrplanDialog fahrplanDialog = new FahrplanDialog(new Fahrplan(), FahrplanDialog.Mode.New);
            fahrplanDialog.ShowDialog();

            GetDataFromDatabase();
        }

        private void buttonShowFahrplan_Click(object sender, EventArgs e)
        {
            if (comboBoxFahrplanID.SelectedIndex != -1)
            {
                FahrplanDialog fahrplanDialog = new FahrplanDialog((int)comboBoxFahrplanID.SelectedItem);
                fahrplanDialog.ShowDialog();
            }
            
        }
    }
}
