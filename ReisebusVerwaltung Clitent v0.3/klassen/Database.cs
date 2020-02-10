using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ReisebusVerwaltung_Clitent_v0._3
{
    public class Database
    {
        /// <summary>
        /// Testet die Verbindung zur Datenbank. Anmeldedaten werden aus den Properties geladen.
        /// </summary>
        /// <returns>Verbindung vorhanden? Ja: 'true' oder Nein: 'false'.</returns>
        public static bool ConnectionAvailable()
        {
            // Anmeldedaten aus den Properties laden
            string server = Properties.Settings.Default.Server;
            string database = Properties.Settings.Default.Datenbank;
            string uid = Properties.Settings.Default.Benutzername;
            string pwd = Properties.Settings.Default.Passwort;
            // Versuch die Verbindung zur Datenbank zu erstellen
            try
            {
                MySqlConnection cs = new MySqlConnection($"Server={server};Database={database};Uid={uid};Pwd={pwd};");
                cs.Open();
                cs.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// Testet die Verbindung zur Datenbank. Anmeldedaten werden mit Parametern übergeben.
        /// </summary>
        /// <param name="server">Anmeldeserver: 'localhost'</param>
        /// <param name="database">Datenbank: 'db'</param>
        /// <param name="username">Anmeldename: 'root'</param>
        /// <param name="password">Passwort: 'root'</param>
        /// <returns>Verbindung vorhanden? Ja: 'true' oder Nein: 'false'.</returns>
        public static bool ConnectionAvailable(string server, string database, string username, string password)
        {
            // Versuch die Verbindung zur Datenbank zu erstellen
            try
            {
                MySqlConnection cs = new MySqlConnection($"Server={server};Database={database};Uid={username};Pwd={password};");
                cs.Open();
                MessageBox.Show(cs.State.ToString());
                cs.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// Gibt die Verbindungsdaten aus
        /// </summary>
        /// <returns>MySqlConnection</returns>
        public static MySqlConnection GetConnectionString
        {
            get
            {
                string server = Properties.Settings.Default.Server;
                string database = Properties.Settings.Default.Datenbank;
                string uid = Properties.Settings.Default.Benutzername;
                string pwd = Properties.Settings.Default.Passwort;
                return new MySqlConnection($"Server={server};Database={database};Uid={uid};Pwd={pwd};");
            }
        }
    }
}
