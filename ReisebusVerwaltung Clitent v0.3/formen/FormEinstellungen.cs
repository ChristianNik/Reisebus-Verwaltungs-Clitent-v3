using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ReisebusVerwaltung_Clitent_v0._3
{
    public partial class FormEinstellungen : UserControl
    {
        MySqlConnection connection;
        string server = Properties.Settings.Default.Server;
        string database = Properties.Settings.Default.Datenbank;
        string uid = Properties.Settings.Default.Benutzername;
        string pwd = Properties.Settings.Default.Passwort;

        public void Init()
        {
            AutoSize = true;
            Dock = DockStyle.Fill;
            BorderStyle = BorderStyle.None;
        }

        public FormEinstellungen()
        {
            InitializeComponent();
            Init();
        }

        private void FormEinstellungen_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection($"Server={server};Database={database};Uid={uid};Pwd={pwd};");

            // TAB: DATENBANK Daten laden
            textBoxPassword.Text = Properties.Settings.Default.Passwort;
            textBoxUsername.Text = Properties.Settings.Default.Benutzername;
            comboBoxDatabase.Text = Properties.Settings.Default.Datenbank;
            textBoxServer.Text = Properties.Settings.Default.Server;

            TestConnection();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // TAB: DATENBANK Daten speichern
            Properties.Settings.Default.Server = textBoxServer.Text;
            Properties.Settings.Default.Datenbank = comboBoxDatabase.Text;
            Properties.Settings.Default.Benutzername = textBoxUsername.Text;
            Properties.Settings.Default.Passwort = textBoxPassword.Text;
            Properties.Settings.Default.Save();
        }

        private void TestConnection()
        {
            try
            {
                connection = new MySqlConnection($"Server={textBoxServer.Text};Database={comboBoxDatabase.Text};Uid={textBoxUsername.Text};Pwd={textBoxPassword.Text};");
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SHOW DATABASES;";
                connection.Open();
                MySqlDataReader Reader = command.ExecuteReader();
                int i = 0;
                comboBoxDatabase.Items.Clear();
                while (Reader.Read())
                {
                    comboBoxDatabase.Items.Add(Reader.GetValue(0).ToString());
                    i++;
                }
                connection.Close();

                labelConnection.Text = "Mit Datenbank verbunden!";
                labelConnection.BackColor = Color.Green;
                labelConnection.ForeColor = Color.White;
                comboBoxDatabase.Enabled = true;
            }
            catch (Exception)
            {
                comboBoxDatabase.Items.Clear();
                labelConnection.Text = "Keine Verbindung!";
                labelConnection.BackColor = Color.Red;
                labelConnection.ForeColor = Color.White;
                comboBoxDatabase.Enabled = false;
            }
        }

        private void buttonConnectionState_Click(object sender, EventArgs e)
        {
            TestConnection();
        }
    }
}
