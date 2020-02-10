using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReisebusVerwaltung_Clitent_v0._3
{
    public partial class FormError : UserControl
    {
        public void Init()
        {
            AutoSize = true;
            Dock = DockStyle.Fill;
            BorderStyle = BorderStyle.None;
        }

        public FormError()
        {
            InitializeComponent();
            Init();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
        }

        private void buttonReconnect_Click(object sender, EventArgs e)
        {
            if(Database.ConnectionAvailable())
            {
                MessageBox.Show("Verbindung möglich. Bitte Aktualisieren", "Info", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Keine Verbindung möglich.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            Parent.Controls.Add(new FormEinstellungen());
            Parent.Controls.Remove(this);

        }
    }
}
