namespace ReisebusVerwaltung_Clitent_v0._3
{
    partial class BuslinieDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonNewBus = new System.Windows.Forms.Button();
            this.buttonNewFahrplan = new System.Windows.Forms.Button();
            this.buttonShowFahrplan = new System.Windows.Forms.Button();
            this.buttonShowBus = new System.Windows.Forms.Button();
            this.comboBoxFahrplanID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxBusID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLinienID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonAbort = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxStartHaltestelle = new System.Windows.Forms.TextBox();
            this.textBoxEndHaltestelle = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(359, 192);
            this.tabControl1.TabIndex = 77;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxEndHaltestelle);
            this.tabPage1.Controls.Add(this.textBoxStartHaltestelle);
            this.tabPage1.Controls.Add(this.buttonNewBus);
            this.tabPage1.Controls.Add(this.buttonNewFahrplan);
            this.tabPage1.Controls.Add(this.buttonShowFahrplan);
            this.tabPage1.Controls.Add(this.buttonShowBus);
            this.tabPage1.Controls.Add(this.comboBoxFahrplanID);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.comboBoxBusID);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBoxLinienID);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(351, 166);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Buslinie bearbeiten";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonNewBus
            // 
            this.buttonNewBus.Location = new System.Drawing.Point(231, 30);
            this.buttonNewBus.Name = "buttonNewBus";
            this.buttonNewBus.Size = new System.Drawing.Size(41, 23);
            this.buttonNewBus.TabIndex = 88;
            this.buttonNewBus.Text = "Neu";
            this.buttonNewBus.UseVisualStyleBackColor = true;
            this.buttonNewBus.Click += new System.EventHandler(this.buttonNewBus_Click);
            // 
            // buttonNewFahrplan
            // 
            this.buttonNewFahrplan.Location = new System.Drawing.Point(231, 56);
            this.buttonNewFahrplan.Name = "buttonNewFahrplan";
            this.buttonNewFahrplan.Size = new System.Drawing.Size(41, 23);
            this.buttonNewFahrplan.TabIndex = 88;
            this.buttonNewFahrplan.Text = "Neu";
            this.buttonNewFahrplan.UseVisualStyleBackColor = true;
            this.buttonNewFahrplan.Click += new System.EventHandler(this.buttonNewFahrplan_Click);
            // 
            // buttonShowFahrplan
            // 
            this.buttonShowFahrplan.Location = new System.Drawing.Point(278, 56);
            this.buttonShowFahrplan.Name = "buttonShowFahrplan";
            this.buttonShowFahrplan.Size = new System.Drawing.Size(59, 23);
            this.buttonShowFahrplan.TabIndex = 87;
            this.buttonShowFahrplan.Text = "Anzeigen";
            this.buttonShowFahrplan.UseVisualStyleBackColor = true;
            this.buttonShowFahrplan.Click += new System.EventHandler(this.buttonShowFahrplan_Click);
            // 
            // buttonShowBus
            // 
            this.buttonShowBus.Location = new System.Drawing.Point(278, 30);
            this.buttonShowBus.Name = "buttonShowBus";
            this.buttonShowBus.Size = new System.Drawing.Size(59, 23);
            this.buttonShowBus.TabIndex = 87;
            this.buttonShowBus.Text = "Anzeigen";
            this.buttonShowBus.UseVisualStyleBackColor = true;
            this.buttonShowBus.Click += new System.EventHandler(this.buttonShowBus_Click);
            // 
            // comboBoxFahrplanID
            // 
            this.comboBoxFahrplanID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFahrplanID.FormattingEnabled = true;
            this.comboBoxFahrplanID.Location = new System.Drawing.Point(90, 58);
            this.comboBoxFahrplanID.Name = "comboBoxFahrplanID";
            this.comboBoxFahrplanID.Size = new System.Drawing.Size(135, 21);
            this.comboBoxFahrplanID.TabIndex = 85;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 76;
            this.label3.Text = "Endhaltestelle:";
            // 
            // comboBoxBusID
            // 
            this.comboBoxBusID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBusID.FormattingEnabled = true;
            this.comboBoxBusID.Location = new System.Drawing.Point(90, 32);
            this.comboBoxBusID.Name = "comboBoxBusID";
            this.comboBoxBusID.Size = new System.Drawing.Size(135, 21);
            this.comboBoxBusID.TabIndex = 86;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 77;
            this.label1.Text = "Starthaltestelle:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 79;
            this.label5.Text = "BusID:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 78;
            this.label2.Text = "FahrplanID:";
            // 
            // textBoxLinienID
            // 
            this.textBoxLinienID.Location = new System.Drawing.Point(90, 6);
            this.textBoxLinienID.Name = "textBoxLinienID";
            this.textBoxLinienID.ReadOnly = true;
            this.textBoxLinienID.Size = new System.Drawing.Size(135, 20);
            this.textBoxLinienID.TabIndex = 81;
            this.textBoxLinienID.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 80;
            this.label8.Text = "LinienID:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonAbort
            // 
            this.buttonAbort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAbort.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.buttonAbort.Location = new System.Drawing.Point(3, 67);
            this.buttonAbort.Name = "buttonAbort";
            this.buttonAbort.Size = new System.Drawing.Size(80, 23);
            this.buttonAbort.TabIndex = 0;
            this.buttonAbort.Text = "Abbrechen";
            this.buttonAbort.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonAbort);
            this.panel2.Controls.Add(this.buttonSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(377, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(91, 216);
            this.panel2.TabIndex = 78;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(3, 38);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(80, 23);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Speichern";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxStartHaltestelle
            // 
            this.textBoxStartHaltestelle.Location = new System.Drawing.Point(90, 85);
            this.textBoxStartHaltestelle.Name = "textBoxStartHaltestelle";
            this.textBoxStartHaltestelle.Size = new System.Drawing.Size(135, 20);
            this.textBoxStartHaltestelle.TabIndex = 89;
            // 
            // textBoxEndHaltestelle
            // 
            this.textBoxEndHaltestelle.Location = new System.Drawing.Point(90, 112);
            this.textBoxEndHaltestelle.Name = "textBoxEndHaltestelle";
            this.textBoxEndHaltestelle.Size = new System.Drawing.Size(135, 20);
            this.textBoxEndHaltestelle.TabIndex = 89;
            // 
            // BuslinieDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 216);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BuslinieDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditBuslinieDialog";
            this.Load += new System.EventHandler(this.EditBuslinieDialog_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonAbort;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonNewFahrplan;
        private System.Windows.Forms.Button buttonShowBus;
        private System.Windows.Forms.ComboBox comboBoxFahrplanID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxBusID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLinienID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonNewBus;
        private System.Windows.Forms.Button buttonShowFahrplan;
        private System.Windows.Forms.TextBox textBoxEndHaltestelle;
        private System.Windows.Forms.TextBox textBoxStartHaltestelle;
    }
}