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

namespace ReisebusVerwaltung_Clitent_v0._3.formen.dialog
{
    public partial class BuchungDialog : Form
    {
        MySqlConnection cs = Database.GetConnectionString;
        MySqlDataAdapter da = new MySqlDataAdapter();

        BindingSource tblBuslinieBS = new BindingSource();
        BindingSource tblBenutzerdatenBS = new BindingSource();

        private int buchungsID;
        private int benutzerdatenID;
        private int linienID;
        private DateTime datum;
        private int sitzplaetze;
        private int liegesitze;
        private int schlafsitze;

        int RanBuchungsID;
        int RanBenutzerdatenID;

        Mode mode;

        public enum Mode
        {
            New = 0,
            Edit = 1,
            Show = 2
        }


        public BuchungDialog(Buchung buchung, Mode mode)
        {
            InitializeComponent();
            //
            this.mode = mode;
            //
            this.buchungsID = buchung.BuchungsID;
            this.benutzerdatenID = buchung.BenutzerdatenID;
            this.linienID = buchung.LinienID;
            this.datum = buchung.Datum;
            this.sitzplaetze = buchung.Sitzplaetze;
            this.liegesitze = buchung.Liegesitze;
            this.schlafsitze = buchung.Schlafsitze;        

            // Bearbeiten
            if (mode == Mode.New)
            {
                buttonSave.Text = "Anlegen";
                tabControl1.TabPages[0].Text = "Buchung anlegen";
                //
                Random random = new Random();
                //
                RanBuchungsID = random.Next();
                RanBenutzerdatenID = random.Next();

                textBoxBuchungsID.Text = RanBuchungsID.ToString();
                // Einträge für benutzerdaten
                da = new MySqlDataAdapter("SELECT * FROM benutzerdaten;", cs);
                DataTable dt = new DataTable();
                da.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    comboBoxBenutzerdatenID.Items.Add(dt.Rows[i][0]);
                }

                // Einträge für buslinie
                da = new MySqlDataAdapter("SELECT * FROM buslinie;", cs);
                dt = new DataTable();
                da.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    comboBoxLinienID.Items.Add(dt.Rows[i][0]);
                }
            }
            else if (mode == Mode.Show || mode == Mode.Edit)
            {
                if (mode == Mode.Show)
                {
                    tabControl1.TabPages[0].Text = "Buchung anzeigen";
                    buttonSave.Visible = false;
                    buttonAbort.Text = "Ok";
                    buttonAbort.Location = buttonSave.Location;
                    //

                    textBoxBuchungsID.Text = buchungsID.ToString();


                    numericUpDownCountSeats.Value = sitzplaetze;
                    numericUpDownCountReclining.Value = liegesitze;
                    numericUpDownCountSleep.Value = schlafsitze;
                }
                else if (mode == Mode.Edit)
                {
                    buttonAbort.Text = "Schließen";
                }

                textBoxBuchungsID.Text = buchungsID.ToString();

                // // Einträge für benutzerdaten
                da = new MySqlDataAdapter("SELECT * FROM benutzerdaten;", cs);
                DataTable dt = new DataTable();
                da.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    comboBoxBenutzerdatenID.Items.Add(dt.Rows[i][0]);
                }

                for (int i = 0; i < comboBoxBenutzerdatenID.Items.Count; i++)
                {
                    if (comboBoxBenutzerdatenID.Items[i].ToString() == benutzerdatenID.ToString())
                    {
                        comboBoxBenutzerdatenID.SelectedIndex = i;
                    }
                }

                // Einträge für buslinie
                da = new MySqlDataAdapter("SELECT * FROM buslinie;", cs);
                dt = new DataTable();
                da.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    comboBoxLinienID.Items.Add(dt.Rows[i][0]);
                }

                for (int i = 0; i < comboBoxLinienID.Items.Count; i++)
                {
                    if ((int)comboBoxLinienID.Items[i] == linienID)
                    {
                        comboBoxLinienID.SelectedIndex = i;
                    }
                }

                numericUpDownCountSeats.Value = sitzplaetze;
                numericUpDownCountReclining.Value = liegesitze;
                numericUpDownCountSleep.Value = schlafsitze;
            }
            
        }

        public BuchungDialog(int buchungsID)
        {
            this.buchungsID = buchungsID;
        }

        private void BuchungDialog_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (mode == Mode.New)
            {
                da.InsertCommand = new MySqlCommand(
                    $"INSERT INTO `buchungen`(`BuchungsID`, `BenutzerdatenID`, `LinienID`, `Buchungsdatum`, `AnzahlSitzplaetze`,`Sitzplaetze_Geb`, `Liegesitze_Geb`, `Schlafsitze_Geb`) VALUES ('{textBoxBuchungsID.Text}','{comboBoxBenutzerdatenID.Text}','{comboBoxLinienID.SelectedItem}','{DateTime.Now.ToShortDateString()}',{numericUpDownCountSeats.Value + numericUpDownCountSeats.Value + numericUpDownCountReclining.Value},'{numericUpDownCountSeats.Value}','{numericUpDownCountReclining.Value}','{numericUpDownCountSleep.Value}');", cs);
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
                da.UpdateCommand = new MySqlCommand(
                    $"UPDATE `buchungen` SET `BenutzerdatenID`='{comboBoxBenutzerdatenID.SelectedItem}',`LinienID`='{comboBoxLinienID.Text}',`Buchungsdatum`='{datum.ToShortDateString()}',`AnzahlSitzplaetze`={numericUpDownCountSeats.Value + numericUpDownCountSeats.Value + numericUpDownCountReclining.Value},`Sitzplaetze_Geb`='{numericUpDownCountSeats.Value}',`Liegesitze_Geb`='{numericUpDownCountReclining.Value}',`Schlafsitze_Geb`='{numericUpDownCountSleep.Value}' WHERE `BuchungsID` = '{textBoxBuchungsID.Text}';" +
                    $"UPDATE `benutzerdaten` SET `Email`='{textBoxEmail.Text}',`KontoNr`='{textBoxKontonummer.Text}',`HandyNr`='{textBoxHandynummer.Text}',`Nachname`='{textBoxLastName.Text}',`Vorname`='{textBoxFirstname.Text}' WHERE `BenutzerdatenID`='{comboBoxBenutzerdatenID.SelectedItem}'", cs);
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

        private void comboBoxBenutzerdatenID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBoxFirstname.DataBindings.Count < 1)
            {
                DataSet ds = new DataSet();
                // MySqlDataAdapter mit DataSet füllen
                da.SelectCommand = new MySqlCommand("SELECT * FROM benutzerdaten;", cs);
                ds.Clear();
                da.Fill(ds);
                // DataSource vergeben
                tblBenutzerdatenBS.DataSource = ds.Tables[0];
                //
                textBoxFirstname.DataBindings.Add(new Binding("Text", tblBenutzerdatenBS, "Vorname"));
                textBoxLastName.DataBindings.Add(new Binding("Text", tblBenutzerdatenBS, "Nachname"));
                textBoxEmail.DataBindings.Add(new Binding("Text", tblBenutzerdatenBS, "Email"));
                textBoxKontonummer.DataBindings.Add(new Binding("Text", tblBenutzerdatenBS, "KontoNr"));
                textBoxHandynummer.DataBindings.Add(new Binding("Text", tblBenutzerdatenBS, "HandyNr"));
            }
            tblBenutzerdatenBS.Position = comboBoxBenutzerdatenID.SelectedIndex;
        }

        private void comboBoxLinienID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBoxStartHaltestelle.DataBindings.Count < 1)
            {
                DataSet ds = new DataSet();
                // MySqlDataAdapter mit DataSet füllen
                da.SelectCommand = new MySqlCommand("SELECT * FROM buslinie;", cs);
                ds.Clear();
                da.Fill(ds);
                // DataSource vergeben
                tblBuslinieBS.DataSource = ds.Tables[0];
                //
                textBoxStartHaltestelle.DataBindings.Add(new Binding("Text", tblBuslinieBS, "Starthaltestelle"));
                textBoxEndHaltestelle.DataBindings.Add(new Binding("Text", tblBuslinieBS, "Endhaltestelle"));
            }
            tblBuslinieBS.Position = comboBoxLinienID.SelectedIndex;
        }

        private void buttonNewBuslinie_Click(object sender, EventArgs e)
        {
            BuslinieDialog buslinieDialog = new BuslinieDialog(new Buslinie(), BuslinieDialog.Mode.New);
            buslinieDialog.ShowDialog();

            // Einträge für buslinie
            da = new MySqlDataAdapter("SELECT * FROM buslinie;", cs);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBoxLinienID.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBoxLinienID.Items.Add(dt.Rows[i][0]);
            }

            for (int i = 0; i < comboBoxLinienID.Items.Count; i++)
            {
                if ((int)comboBoxLinienID.Items[i] == linienID)
                {
                    comboBoxLinienID.SelectedIndex = i;
                }
            }

        }

        private void buttonShowBuslinie_Click(object sender, EventArgs e)
        {
            if (comboBoxLinienID.SelectedIndex != -1)
            {
                BuslinieDialog buslinieDialog = new BuslinieDialog((int)comboBoxLinienID.SelectedItem, BuslinieDialog.Mode.Show);
                buslinieDialog.ShowDialog();
            }
        }
    }
}
