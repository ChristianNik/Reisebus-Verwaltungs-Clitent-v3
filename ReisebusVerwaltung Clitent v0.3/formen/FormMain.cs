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
    public partial class FormMain : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        public void AktiveButton(object sender)
        {
            for (int i = 0; i < panelSlider.Controls.Count; i++)
            {
                if (panelSlider.Controls[i].AccessibilityObject.Role == AccessibleRole.PushButton)
                {
                    panelSlider.Controls[i].BackColor = Color.CornflowerBlue;
                }
            }
            Button bt = (Button)sender;
            bt.BackColor = Color.RoyalBlue;
        }
        /// <summary>
        /// 
        /// </summary>
        private void buttonEinstellungen_Click(object sender, EventArgs e)
        {
            AktiveButton(sender);

            if (panelMain.Controls.Count > 0)
            {
                panelMain.Controls.RemoveAt(0);
            }
            FormEinstellungen einstellungen = new FormEinstellungen();
            panelMain.Controls.Add(einstellungen);
        }
        /// <summary>
        /// 
        /// </summary>
        private void button5_Click(object sender, EventArgs e)
        {
            if (panelSlider.Size.Width == 251)
            {
                button5.Text = ">";
                panelSlider.Size = new Size(60, panelSlider.Height);
            }
            else
            {
                button5.Text = "<";
                panelSlider.Size = new Size(251, panelSlider.Height);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private void buttonBusflotte_Click(object sender, EventArgs e)
        {
            TryShowForm(sender, FormTableView.Type.Busflotte);
        }
        /// <summary>
        /// 
        /// </summary>
        private void buttonBuchungen_Click(object sender, EventArgs e)
        {
            TryShowForm(sender, FormTableView.Type.Buchungen);
        }
        /// <summary>
        /// 
        /// </summary>
        private void buttonBuslinien_Click(object sender, EventArgs e)
        {
            TryShowForm(sender, FormTableView.Type.Buslinie);
        }
        /// <summary>
        /// 
        /// </summary>
        private void buttonFahrplan_Click(object sender, EventArgs e)
        {
            TryShowForm(sender, FormTableView.Type.Fahrplan);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="type"></param>
        private void TryShowForm(object sender, FormTableView.Type type)
        {
            // Setzt den Hintergrund des geklickten Buttons fest
            AktiveButton(sender);
            // Überprüft ob eine Verbindung zur Datenbank möglich ist
            if (Database.ConnectionAvailable())
            {
                if (panelMain.Controls.Count > 0)
                {
                    panelMain.Controls.RemoveAt(0);
                }
                FormTableView tableView = new FormTableView(type);
                panelMain.Controls.Add(tableView);
            }
            else
            {
                if (panelMain.Controls.Count > 0)
                {
                    Type t = panelMain.Controls[0].GetType();
                    if (!(t.Equals(typeof(FormError))))
                    {
                        FormError error = new FormError();
                        panelMain.Controls.Add(error);
                    }
                }
                else
                {
                    FormError error = new FormError();
                    panelMain.Controls.Add(error);
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
        }

    }
}
