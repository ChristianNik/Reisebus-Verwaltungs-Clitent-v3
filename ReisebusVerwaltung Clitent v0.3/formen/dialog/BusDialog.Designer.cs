namespace ReisebusVerwaltung_Clitent_v0._3
{
    partial class BusDialog
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonAbort = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxHasDrinks = new System.Windows.Forms.CheckBox();
            this.checkBoxHasWlan = new System.Windows.Forms.CheckBox();
            this.checkBoxHasToilete = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.numericUpDownCountReclining = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCountSeats = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCountSleep = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxAusstatungsID = new System.Windows.Forms.TextBox();
            this.textBoxBusID = new System.Windows.Forms.TextBox();
            this.textBoxSitzplanID = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountReclining)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountSeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountSleep)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 69;
            this.label5.Text = "BusID:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 70;
            this.label8.Text = "AusstattungsID:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonAbort);
            this.panel2.Controls.Add(this.buttonSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(290, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(91, 308);
            this.panel2.TabIndex = 76;
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
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(272, 264);
            this.tabControl1.TabIndex = 75;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(264, 238);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Bus bearbeiten";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxHasDrinks);
            this.groupBox3.Controls.Add(this.checkBoxHasWlan);
            this.groupBox3.Controls.Add(this.checkBoxHasToilete);
            this.groupBox3.Location = new System.Drawing.Point(166, 128);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(87, 100);
            this.groupBox3.TabIndex = 71;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ausstattung";
            // 
            // checkBoxHasDrinks
            // 
            this.checkBoxHasDrinks.AutoSize = true;
            this.checkBoxHasDrinks.Location = new System.Drawing.Point(6, 67);
            this.checkBoxHasDrinks.Name = "checkBoxHasDrinks";
            this.checkBoxHasDrinks.Size = new System.Drawing.Size(70, 17);
            this.checkBoxHasDrinks.TabIndex = 59;
            this.checkBoxHasDrinks.Text = "Getränke";
            this.checkBoxHasDrinks.UseVisualStyleBackColor = true;
            // 
            // checkBoxHasWlan
            // 
            this.checkBoxHasWlan.AutoSize = true;
            this.checkBoxHasWlan.Location = new System.Drawing.Point(6, 21);
            this.checkBoxHasWlan.Name = "checkBoxHasWlan";
            this.checkBoxHasWlan.Size = new System.Drawing.Size(58, 17);
            this.checkBoxHasWlan.TabIndex = 56;
            this.checkBoxHasWlan.Text = "WLAN";
            this.checkBoxHasWlan.UseVisualStyleBackColor = true;
            // 
            // checkBoxHasToilete
            // 
            this.checkBoxHasToilete.AutoSize = true;
            this.checkBoxHasToilete.Location = new System.Drawing.Point(6, 44);
            this.checkBoxHasToilete.Name = "checkBoxHasToilete";
            this.checkBoxHasToilete.Size = new System.Drawing.Size(61, 17);
            this.checkBoxHasToilete.TabIndex = 58;
            this.checkBoxHasToilete.Text = "Toilette";
            this.checkBoxHasToilete.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.numericUpDownCountReclining);
            this.groupBox2.Controls.Add(this.numericUpDownCountSeats);
            this.groupBox2.Controls.Add(this.numericUpDownCountSleep);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(6, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(154, 100);
            this.groupBox2.TabIndex = 73;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sitzplätze";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 13);
            this.label13.TabIndex = 69;
            this.label13.Text = "Gesamtanzahl:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 73);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 70;
            this.label14.Text = "Schlafsitze:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numericUpDownCountReclining
            // 
            this.numericUpDownCountReclining.Location = new System.Drawing.Point(91, 45);
            this.numericUpDownCountReclining.Name = "numericUpDownCountReclining";
            this.numericUpDownCountReclining.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownCountReclining.TabIndex = 49;
            this.numericUpDownCountReclining.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownCountReclining.ValueChanged += new System.EventHandler(this.numericUpDownCountReclining_ValueChanged);
            // 
            // numericUpDownCountSeats
            // 
            this.numericUpDownCountSeats.Location = new System.Drawing.Point(91, 20);
            this.numericUpDownCountSeats.Name = "numericUpDownCountSeats";
            this.numericUpDownCountSeats.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownCountSeats.TabIndex = 47;
            this.numericUpDownCountSeats.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownCountSeats.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDownCountSleep
            // 
            this.numericUpDownCountSleep.Location = new System.Drawing.Point(91, 71);
            this.numericUpDownCountSleep.Name = "numericUpDownCountSleep";
            this.numericUpDownCountSleep.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownCountSleep.TabIndex = 51;
            this.numericUpDownCountSleep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownCountSleep.ValueChanged += new System.EventHandler(this.numericUpDownCountSleep_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 70;
            this.label12.Text = "Liegesitze:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBoxAusstatungsID);
            this.groupBox1.Controls.Add(this.textBoxBusID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxSitzplanID);
            this.groupBox1.Location = new System.Drawing.Point(6, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 108);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ID Info";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 70;
            this.label10.Text = "SitzplanID:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxAusstatungsID
            // 
            this.textBoxAusstatungsID.Location = new System.Drawing.Point(91, 48);
            this.textBoxAusstatungsID.Name = "textBoxAusstatungsID";
            this.textBoxAusstatungsID.ReadOnly = true;
            this.textBoxAusstatungsID.Size = new System.Drawing.Size(145, 20);
            this.textBoxAusstatungsID.TabIndex = 71;
            this.textBoxAusstatungsID.TabStop = false;
            // 
            // textBoxBusID
            // 
            this.textBoxBusID.Location = new System.Drawing.Point(91, 22);
            this.textBoxBusID.Name = "textBoxBusID";
            this.textBoxBusID.ReadOnly = true;
            this.textBoxBusID.Size = new System.Drawing.Size(145, 20);
            this.textBoxBusID.TabIndex = 71;
            this.textBoxBusID.TabStop = false;
            // 
            // textBoxSitzplanID
            // 
            this.textBoxSitzplanID.Location = new System.Drawing.Point(91, 74);
            this.textBoxSitzplanID.Name = "textBoxSitzplanID";
            this.textBoxSitzplanID.ReadOnly = true;
            this.textBoxSitzplanID.Size = new System.Drawing.Size(145, 20);
            this.textBoxSitzplanID.TabIndex = 71;
            this.textBoxSitzplanID.TabStop = false;
            // 
            // BusDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 308);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BusDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditBusDialog";
            this.Load += new System.EventHandler(this.EditBusDialog_Load);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountReclining)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountSeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountSleep)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonAbort;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBoxAusstatungsID;
        private System.Windows.Forms.NumericUpDown numericUpDownCountReclining;
        private System.Windows.Forms.TextBox textBoxSitzplanID;
        private System.Windows.Forms.NumericUpDown numericUpDownCountSleep;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericUpDownCountSeats;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxBusID;
        private System.Windows.Forms.CheckBox checkBoxHasWlan;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox checkBoxHasToilete;
        private System.Windows.Forms.CheckBox checkBoxHasDrinks;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}