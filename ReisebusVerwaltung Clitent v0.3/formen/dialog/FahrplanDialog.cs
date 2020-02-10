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
    public partial class FahrplanDialog : Form
    {
        MySqlConnection cs;
        DataSet ds = new DataSet();
        MySqlDataAdapter da = new MySqlDataAdapter();

        BindingSource tblFahrplanBS = new BindingSource();
        //
        string server = Properties.Settings.Default.Server;
        string database = Properties.Settings.Default.Datenbank;
        string uid = Properties.Settings.Default.Benutzername;
        string pwd = Properties.Settings.Default.Passwort;

        private int fahrplanID;
        private string abfahrtsZeit;
        private DateTime abfahrtdatum;
        private string fahrtdauerStd;
        private string fahrtdauerMin;
        private double fahrpreis;

        int RanFahrplanID;

        Mode mode;

        public enum Mode
        {
            New = 0,
            Edit = 1,
            Show = 2
        }

        public FahrplanDialog(int fahrplanID)
        {
            InitializeComponent();
            //
            cs = new MySqlConnection($"Server={server};Database={database};Uid={uid};Pwd={pwd};");

            da.SelectCommand = new MySqlCommand($"SELECT * FROM fahrplan;", cs);
            ds.Clear();
            da.Fill(ds);

            tblFahrplanBS.DataSource = ds.Tables[0];
            //
            DataRowView dr = (DataRowView)tblFahrplanBS.Current;
            //
            textBoxFahrplanID.Text = (string)dr.Row.ItemArray[0].ToString();
            dateTimePickerTime.Text = (string)dr.Row.ItemArray[1].ToString();
            dateTimePickerDate.Value = (DateTime)dr.Row.ItemArray[2];
            textBoxDurationHour.Text = (string)dr.Row.ItemArray[3].ToString();
            textBoxPrice.Text = (string)dr.Row.ItemArray[4].ToString().Replace(',', '.');
            //
            tabControl1.TabPages[0].Text = "Fahplan anzeigen";
            buttonSave.Visible = false;
            buttonAbort.Text = "Ok";
            buttonAbort.Location = buttonSave.Location;
            //
            dateTimePickerDate.Enabled = false;
            dateTimePickerTime.Enabled = false;
            textBoxDurationHour.Enabled = false;
            textBoxDurationMin.Enabled = false;
            textBoxPrice.Enabled = false;

        }

        public FahrplanDialog(Fahrplan fahrplan, Mode mode)
        {
            Random random;
            //
            InitializeComponent();
            //
            this.mode = mode;
            //
            fahrplanID = fahrplan.FahrplanID;
            abfahrtsZeit = fahrplan.AbfahrtsZeit;
            abfahrtdatum = fahrplan.Abfahrtdatum;
            string a = fahrplan.Fahrtdauer;
            string[] b = a.Split(':','.');
            fahrtdauerStd = b[0];
            fahrtdauerMin = b[1];
            fahrpreis = fahrplan.Fahrpreis;
            //
            cs = new MySqlConnection($"Server={server};Database={database};Uid={uid};Pwd={pwd};");

            da.SelectCommand = new MySqlCommand("SELECT * FROM fahrplan;", cs);
            ds.Clear();
            da.Fill(ds);

            tblFahrplanBS.DataSource = ds.Tables[0];

            if (mode == Mode.New)
            {
                buttonSave.Text = "Anlegen";

                random = new Random();
                //
                RanFahrplanID = random.Next();
                textBoxFahrplanID.Text = RanFahrplanID.ToString();
            }
            else if (mode == Mode.Show || mode == Mode.Edit)
            {
                if (mode == Mode.Show)
                {
                    tabControl1.TabPages[0].Text = "Fahplan anzeigen";
                    buttonSave.Visible = false;
                    buttonAbort.Text = "Ok";
                    buttonAbort.Location = buttonSave.Location;
                    //
                    dateTimePickerDate.Enabled = false;
                    dateTimePickerTime.Enabled = false;
                    textBoxDurationHour.Enabled = false;
                    textBoxDurationMin.Enabled = false;
                    textBoxPrice.Enabled = false;
                }
                else if (mode == Mode.Edit)
                {
                    buttonAbort.Text = "Schließen";
                }
                textBoxFahrplanID.Text = fahrplanID.ToString();
                dateTimePickerTime.Value = Convert.ToDateTime(abfahrtsZeit);
                dateTimePickerDate.Value = abfahrtdatum;
                textBoxDurationHour.Text = fahrtdauerStd;
                textBoxDurationMin.Text = fahrtdauerMin;
                textBoxPrice.Text = fahrpreis.ToString().Replace(',', '.');
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (mode == Mode.New)
            {
                string time = textBoxDurationHour.Text + ".";
                if (Convert.ToInt32(textBoxDurationMin.Text) < 10)
                {
                    time += "0";
                }
                time += textBoxDurationMin.Text;

                da.InsertCommand = new MySqlCommand(
                    $"INSERT INTO `fahrplan`(`FahrplanID`, `Abfahrtszeit`, `Abfahrtdatum`, `Fahrtdauer`, `Fahrtpreis`) VALUES ('{textBoxFahrplanID.Text}','{dateTimePickerTime.Value.ToShortTimeString()}','{dateTimePickerDate.Value.ToShortDateString()}','{time}','{textBoxPrice.Text}')", cs);
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
                string time = textBoxDurationHour.Text;
                if (textBoxDurationHour.Text == "0.00")
                {
                    time = "0";
                }
                time += ".";
                if (Convert.ToInt32(textBoxDurationMin.Text) < 10)
                {
                    time += "0";
                }
                time += textBoxDurationMin.Text;
                da.UpdateCommand = new MySqlCommand($"UPDATE `fahrplan` SET `Abfahrtszeit`='{dateTimePickerTime.Value.ToShortTimeString()}',`Abfahrtdatum`='{dateTimePickerDate.Value.ToShortDateString()}',`Fahrtdauer`='{time}',`Fahrtpreis`='{textBoxPrice.Text.Replace(',','.')}' WHERE `FahrplanID`= {textBoxFahrplanID.Text}", cs);

                cs.Open();
                int x = da.UpdateCommand.ExecuteNonQuery();
                cs.Close();

                if (x > 0)
                {
                    MessageBox.Show($"Änderung Erfolgreich.");
                }
                Close();
            }
        }

        private void textBoxDurationMin_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBoxDurationMin.Text) > 60)
                {
                    textBoxDurationMin.Text = "59";
                }
            }
            catch 
            {
                //leer
            }
        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPrice.Text == string.Empty)
            {
                textBoxPrice.Text = "0.00";
                textBoxPrice.SelectAll();
            }
        }

        private void FahrplanDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
