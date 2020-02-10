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
using ReisebusVerwaltung_Clitent_v0._3.formen.dialog;

namespace ReisebusVerwaltung_Clitent_v0._3
{
    public partial class FormTableView : UserControl
    {
        MySqlConnection cs = Database.GetConnectionString;
        //
        DataSet ds = new DataSet();
        MySqlDataAdapter da = new MySqlDataAdapter();

        BindingSource tblBusBS = new BindingSource();
        BindingSource tblBuslinieBS = new BindingSource();
        BindingSource tblBuchungBS = new BindingSource();
        BindingSource tblFahrplanBS = new BindingSource();

        Type type;

        public enum Type
        {
            Busflotte = 0,
            Buchungen = 1,
            Buslinie = 2,
            Fahrplan = 3                
        }

        public enum Mode
        {
            New = 0,
            Edit = 1,
            Show = 2
        }

        public void Init()
        {
            AutoSize = true;
            Dock = DockStyle.Fill;
            BorderStyle = BorderStyle.None;
        }

        public FormTableView(Type type)
        {
            InitializeComponent();
            Init();
            //
            this.type = type;
            //
            if (Database.ConnectionAvailable())
            {
                TableDesign();
                // Legt die Überschrift der Form fest
                labelTitel.Text = type.ToString();
                //
                if (type == Type.Busflotte)
                {
                    try
                    {
                        // MySqlDataAdapter mit DataSet füllen
                        da.SelectCommand = new MySqlCommand("SELECT b.BusID, b.AusstattungsID, b.SitzplanID, Wlan, Toilette, Getraenke, s.Sitzplaetze, s.Liegesitze, s.Schlafsitze FROM bus b LEFT JOIN busausstattung a ON(b.AusstattungsID = a.AusstattungsID) LEFT JOIN sitzplan s  ON(s.SitzplanID = b.SitzplanID);", cs);
                        ds.Clear();
                        da.Fill(ds);
                        // DataSource vergeben
                        tblBusBS.DataSource = ds.Tables[0];
                    }
                    catch
                    {
                        //leer
                    }
                }
                else if (type == Type.Buchungen)
                {
                    try
                    {
                        // MySqlDataAdapter mit DataSet füllen
                        da.SelectCommand = new MySqlCommand("SELECT b.BuchungsID, d.BenutzerdatenID, b.LinienID, Vorname, Nachname, b.Sitzplaetze_Geb, b.Liegesitze_Geb, b.Schlafsitze_Geb, l.Starthaltestelle, l.Endhaltestelle FROM benutzerdaten d LEFT JOIN buchungen b  ON(d.BenutzerdatenID = b.BenutzerdatenID) LEFT JOIN buslinie l  ON(l.LinienID = b.LinienID) WHERE b.BuchungsID is not null;", cs);
                        ds.Clear();
                        da.Fill(ds);
                        // DataSource vergeben
                        tblBuchungBS.DataSource = ds.Tables[0];
                    }
                    catch
                    {
                        //leer
                    }
                }
                else if (type == Type.Buslinie)
                {
                    try
                    {
                        // MySqlDataAdapter mit DataSet füllen
                        da.SelectCommand = new MySqlCommand("SELECT * FROM buslinie;", cs);
                        ds.Clear();
                        da.Fill(ds);
                        // DataSource vergeben
                        tblBuslinieBS.DataSource = ds.Tables[0];
                    }
                    catch
                    {
                        //leer
                    }
                }
                else if (type == Type.Fahrplan)
                {
                    try
                    {
                        // MySqlDataAdapter mit DataSet füllen
                        da.SelectCommand = new MySqlCommand("SELECT * FROM fahrplan;", cs);
                        ds.Clear();
                        da.Fill(ds);
                        // DataSource vergeben
                        tblFahrplanBS.DataSource = ds.Tables[0];
                    }
                    catch
                    {
                        //leer
                    }
                }
                try
                {
                    dataGridView1.DataSource = ds.Tables[0];
                }
                catch 
                {
                    
                }

            }
        }

        private void TableDesign()
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(224, 224, 224);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void ResetView()
        {
            ds.Clear();
            da.Fill(ds);
        }
        /// <summary>
        /// Schießt das Benutzersteuerelement
        /// </summary>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
        }
        // Syncroniesiert die Position im DataGrid mit der Position in der BindingSource
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tblBusBS.Position = dataGridView1.CurrentRow.Index;
            tblBuchungBS.Position = dataGridView1.CurrentRow.Index;
            tblBuslinieBS.Position = dataGridView1.CurrentRow.Index;
            tblFahrplanBS.Position = dataGridView1.CurrentRow.Index;
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            ShowDialog(Mode.New);
        }
        /// <summary>
        /// Zeigt den Jewaligen Dialog an
        /// </summary>
        /// <param name="mode"></param>
        private void ShowDialog(Mode mode)
        {
            // Testet die Verbundung zur Datenbank            
            if (Database.ConnectionAvailable())
            {
                if (type == Type.Busflotte)
                {
                    Bus bus = new Bus();
                    DataRowView dr = (DataRowView)tblBusBS.Current;
                    if (dr != null)
                    {
                        bus.BusID = (int)dr.Row.ItemArray[0];
                        bus.AusstattungsID = (int)dr.Row.ItemArray[1];
                        bus.SitzplanID = (int)dr.Row.ItemArray[2];
                        bus.HasWlan = (bool)dr.Row.ItemArray[3];
                        bus.HasToilet = (bool)dr.Row.ItemArray[4];
                        bus.HasDrinks = (bool)dr.Row.ItemArray[5];
                        bus.CountSeats = (int)dr.Row.ItemArray[6];
                        bus.CountReclining = (int)dr.Row.ItemArray[7];
                        bus.CountSleeping = (int)dr.Row.ItemArray[8];
                    }
                    BusDialog busDialog = new BusDialog(bus, (BusDialog.Mode)mode);
                    busDialog.ShowDialog();
                }
                else if (type == Type.Buchungen)
                {
                    Buchung buchung = new Buchung();
                    DataRowView dr = (DataRowView)tblBuchungBS.Current;
                    if (dr != null)
                    {
                        buchung.BuchungsID = (int)dr.Row.ItemArray[0];
                        buchung.BenutzerdatenID = (int)dr.Row.ItemArray[1];
                        buchung.LinienID = (int)dr.Row.ItemArray[2];
                        buchung.Nachname = (string)dr.Row.ItemArray[3].ToString();
                        buchung.Vorname = (string)dr.Row.ItemArray[4].ToString();
                        buchung.Sitzplaetze = (int)dr.Row.ItemArray[5];
                        buchung.Liegesitze = (int)dr.Row.ItemArray[6];
                        buchung.Schlafsitze = (int)dr.Row.ItemArray[7];
                        if (dr.Row.ItemArray[8].ToString() != "")
                            buchung.Starthaltestelle = (string)dr.Row.ItemArray[8];
                        if (dr.Row.ItemArray[9].ToString() != "")
                            buchung.Endhaltestelle = (string)dr.Row.ItemArray[9];
                    }
                    BuchungDialog buchungDialog = new BuchungDialog(buchung, (BuchungDialog.Mode)mode);
                    buchungDialog.ShowDialog();
                }
                else if (type == Type.Buslinie)
                {
                    Buslinie buslinie = new Buslinie();
                    DataRowView dr = (DataRowView)tblBuslinieBS.Current;
                    if (dr != null)
                    {
                        buslinie.LinienID = (int)dr.Row.ItemArray[0];
                        buslinie.FahrplanID = (int)dr.Row.ItemArray[1];
                        buslinie.BusID = (int)dr.Row.ItemArray[2];
                        buslinie.Start = (string)dr.Row.ItemArray[3];
                        buslinie.Ende = (string)dr.Row.ItemArray[4];
                    }
                    BuslinieDialog buslinieDialog = new BuslinieDialog(buslinie, (BuslinieDialog.Mode)mode);
                    buslinieDialog.ShowDialog();
                }
                else if (type == Type.Fahrplan)
                {
                    Fahrplan fahrplan = new Fahrplan();
                    DataRowView dr = (DataRowView)tblFahrplanBS.Current;
                    if (dr != null)
                    {                        
                        fahrplan.FahrplanID = (int)dr.Row.ItemArray[0];
                        fahrplan.AbfahrtsZeit = (string)dr.Row.ItemArray[1].ToString();
                        fahrplan.Abfahrtdatum = (DateTime)dr.Row.ItemArray[2];
                        fahrplan.Fahrtdauer = (string)dr.Row.ItemArray[3].ToString();
                        fahrplan.Fahrpreis = (double)dr.Row.ItemArray[4];
                    }
                    FahrplanDialog fahrplanDialog = new FahrplanDialog(fahrplan, (FahrplanDialog.Mode)mode);
                    fahrplanDialog.ShowDialog();
                }

                ResetView();
            }
            else
            {
                MessageBox.Show("Es konnte keine Verbindung zur Datenbank hergestellt werden.");
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                ShowDialog(Mode.Edit);
            }
        }
        private void buttonShow_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                ShowDialog(Mode.Show);
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (Database.ConnectionAvailable())
            {
                if (dataGridView1.RowCount > 0)
                {
                    if (MessageBox.Show("Sind Sie sicher?\nEs gibt kein zurück", "Löschvorgang bestätigen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        string sql = string.Empty;
                        if (type == Type.Busflotte)
                        {
                            if ("a" != "")
                            {
                                sql += $"DELETE FROM `bus` WHERE `BusID` = @BUSID;";
                            }
                            if ("a" != "")
                            {
                                sql += $"DELETE FROM `busausstattung` WHERE `AusstattungsID` = @AUSSTATTUNGSID;";
                            }
                            da.DeleteCommand = new MySqlCommand(sql, cs);
                            da.DeleteCommand.Parameters.Add("@BUSID", MySqlDbType.Int32).Value = (int)dataGridView1[0, dataGridView1.CurrentRow.Index].Value;
                            da.DeleteCommand.Parameters.Add("@AUSSTATTUNGSID", MySqlDbType.Int32).Value = (int)dataGridView1[1, dataGridView1.CurrentRow.Index].Value;
                        }
                        else if (type == Type.Buchungen)
                        {
                            sql = $"DELETE FROM `buchungen` WHERE (CASE WHEN BuchungsID IS NULL THEN BenutzerdatenID = @ID ELSE BuchungsID = @ID END);";
                            da.DeleteCommand = new MySqlCommand(sql, cs);
                        }
                        else if (type == Type.Buslinie)
                        {
                            sql = $"DELETE FROM `buslinie` WHERE `LinienID` = @ID;";
                            da.DeleteCommand = new MySqlCommand(sql, cs);
                        }
                        else if (type == Type.Fahrplan)
                        {
                            sql = $"DELETE FROM `fahrplan` WHERE `FahrplanID` = @ID;";
                            da.DeleteCommand = new MySqlCommand(sql, cs);
                        }

                        if (!(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString() == ""))
                        {
                            da.DeleteCommand.Parameters.Add("@ID", MySqlDbType.Int32).Value = (int)dataGridView1[0, dataGridView1.CurrentRow.Index].Value;

                            cs.Open();
                            da.DeleteCommand.ExecuteNonQuery();
                            cs.Close();
                        }
                        ResetView();
                    }
                    else
                    {
                        MessageBox.Show("Löschforgang abgebrochen", "Abbruch", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }        
            }
            else
            {
                MessageBox.Show("Es konnte keine Verbindung zur Datenbank hergestellt werden.");
            }
        }

    }
}
