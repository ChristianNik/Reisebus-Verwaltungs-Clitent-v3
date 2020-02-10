namespace ReisebusVerwaltung_Clitent_v0._3
{
    partial class FormError
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonReconnect = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.panelContainerLabel1 = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 343);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(774, 32);
            this.panel2.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(768, 74);
            this.label1.TabIndex = 19;
            this.label1.Text = "Es konnte keine Verbindung zur Datenbank hergestellt weden";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonReconnect
            // 
            this.buttonReconnect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonReconnect.Location = new System.Drawing.Point(268, 240);
            this.buttonReconnect.Name = "buttonReconnect";
            this.buttonReconnect.Size = new System.Drawing.Size(116, 23);
            this.buttonReconnect.TabIndex = 0;
            this.buttonReconnect.Text = "Verbindung testen";
            this.buttonReconnect.UseVisualStyleBackColor = true;
            this.buttonReconnect.Click += new System.EventHandler(this.buttonReconnect_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSettings.Location = new System.Drawing.Point(390, 240);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(116, 23);
            this.buttonSettings.TabIndex = 20;
            this.buttonSettings.Text = "Einstellungen ändern";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // panelContainerLabel1
            // 
            this.panelContainerLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelContainerLabel1.BackgroundImage = global::ReisebusVerwaltung_Clitent_v0._3.Properties.Resources.icons8_error_48;
            this.panelContainerLabel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelContainerLabel1.Location = new System.Drawing.Point(268, 79);
            this.panelContainerLabel1.Name = "panelContainerLabel1";
            this.panelContainerLabel1.Size = new System.Drawing.Size(238, 81);
            this.panelContainerLabel1.TabIndex = 21;
            // 
            // panelTop
            // 
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(774, 26);
            this.panelTop.TabIndex = 22;
            // 
            // FormError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelContainerLabel1);
            this.Controls.Add(this.buttonReconnect);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Name = "FormError";
            this.Size = new System.Drawing.Size(774, 375);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonReconnect;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Panel panelContainerLabel1;
        private System.Windows.Forms.Panel panelTop;
    }
}
