namespace TorqueTempApp
{
    partial class FrmEditTemp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditTemp));
            this.cmbEquipmentType = new System.Windows.Forms.ComboBox();
            this.txtTempPM = new System.Windows.Forms.TextBox();
            this.txtTempAM = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTimePM = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSolderPersonInCharge = new System.Windows.Forms.TextBox();
            this.txtSolderLineAssigned = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSolderProcessAssigned = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSolderControlNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSolderModel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimeAM = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.richTxtRemarks = new System.Windows.Forms.RichTextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtCheckedBy = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cmbModelSeries = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbEquipmentType
            // 
            this.cmbEquipmentType.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEquipmentType.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbEquipmentType.FormattingEnabled = true;
            this.cmbEquipmentType.Items.AddRange(new object[] {
            "Soldering Iron",
            "Soldering Pot"});
            this.cmbEquipmentType.Location = new System.Drawing.Point(191, 82);
            this.cmbEquipmentType.Name = "cmbEquipmentType";
            this.cmbEquipmentType.Size = new System.Drawing.Size(264, 36);
            this.cmbEquipmentType.TabIndex = 2;
            this.cmbEquipmentType.Text = "Select type";
            // 
            // txtTempPM
            // 
            this.txtTempPM.Location = new System.Drawing.Point(645, 71);
            this.txtTempPM.Name = "txtTempPM";
            this.txtTempPM.Size = new System.Drawing.Size(264, 34);
            this.txtTempPM.TabIndex = 3;
            // 
            // txtTempAM
            // 
            this.txtTempAM.Location = new System.Drawing.Point(191, 71);
            this.txtTempAM.Name = "txtTempAM";
            this.txtTempAM.Size = new System.Drawing.Size(264, 34);
            this.txtTempAM.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(461, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 28);
            this.label9.TabIndex = 2;
            this.label9.Text = "Temp (PM):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 28);
            this.label7.TabIndex = 2;
            this.label7.Text = "Temp (AM):";
            // 
            // txtTimePM
            // 
            this.txtTimePM.Location = new System.Drawing.Point(645, 31);
            this.txtTimePM.Name = "txtTimePM";
            this.txtTimePM.Size = new System.Drawing.Size(264, 34);
            this.txtTimePM.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbEquipmentType);
            this.groupBox1.Controls.Add(this.txtSolderPersonInCharge);
            this.groupBox1.Controls.Add(this.txtSolderLineAssigned);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtSolderProcessAssigned);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSolderControlNo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSolderModel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 97);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(930, 178);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Soldering Equipment Details:";
            // 
            // txtSolderPersonInCharge
            // 
            this.txtSolderPersonInCharge.Location = new System.Drawing.Point(645, 129);
            this.txtSolderPersonInCharge.Margin = new System.Windows.Forms.Padding(4);
            this.txtSolderPersonInCharge.Name = "txtSolderPersonInCharge";
            this.txtSolderPersonInCharge.Size = new System.Drawing.Size(264, 34);
            this.txtSolderPersonInCharge.TabIndex = 1;
            // 
            // txtSolderLineAssigned
            // 
            this.txtSolderLineAssigned.Location = new System.Drawing.Point(191, 128);
            this.txtSolderLineAssigned.Margin = new System.Windows.Forms.Padding(4);
            this.txtSolderLineAssigned.Name = "txtSolderLineAssigned";
            this.txtSolderLineAssigned.Size = new System.Drawing.Size(264, 34);
            this.txtSolderLineAssigned.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(461, 133);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 28);
            this.label10.TabIndex = 0;
            this.label10.Text = "Person In Charge:";
            // 
            // txtSolderProcessAssigned
            // 
            this.txtSolderProcessAssigned.Location = new System.Drawing.Point(645, 81);
            this.txtSolderProcessAssigned.Margin = new System.Windows.Forms.Padding(4);
            this.txtSolderProcessAssigned.Name = "txtSolderProcessAssigned";
            this.txtSolderProcessAssigned.Size = new System.Drawing.Size(264, 34);
            this.txtSolderProcessAssigned.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 132);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Line Assigned:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(461, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Process Assigned:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Equipment Type:";
            // 
            // txtSolderControlNo
            // 
            this.txtSolderControlNo.Location = new System.Drawing.Point(645, 35);
            this.txtSolderControlNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtSolderControlNo.Name = "txtSolderControlNo";
            this.txtSolderControlNo.Size = new System.Drawing.Size(264, 34);
            this.txtSolderControlNo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(461, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Control #:";
            // 
            // txtSolderModel
            // 
            this.txtSolderModel.Location = new System.Drawing.Point(191, 35);
            this.txtSolderModel.Margin = new System.Windows.Forms.Padding(4);
            this.txtSolderModel.Name = "txtSolderModel";
            this.txtSolderModel.Size = new System.Drawing.Size(264, 34);
            this.txtSolderModel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Solder Model:";
            // 
            // txtTimeAM
            // 
            this.txtTimeAM.Location = new System.Drawing.Point(191, 31);
            this.txtTimeAM.Name = "txtTimeAM";
            this.txtTimeAM.Size = new System.Drawing.Size(264, 34);
            this.txtTimeAM.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(461, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 28);
            this.label8.TabIndex = 2;
            this.label8.Text = "Time (PM):";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dateTimePicker);
            this.groupBox6.Location = new System.Drawing.Point(473, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(469, 78);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Date:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "dd/MM/yyy";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(7, 31);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(441, 34);
            this.dateTimePicker.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.richTxtRemarks);
            this.groupBox3.Location = new System.Drawing.Point(12, 414);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(931, 196);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Remarks:";
            // 
            // richTxtRemarks
            // 
            this.richTxtRemarks.Location = new System.Drawing.Point(12, 34);
            this.richTxtRemarks.Name = "richTxtRemarks";
            this.richTxtRemarks.Size = new System.Drawing.Size(911, 156);
            this.richTxtRemarks.TabIndex = 0;
            this.richTxtRemarks.Text = "";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(768, 616);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(175, 77);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Edit Record";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTempPM);
            this.groupBox2.Controls.Add(this.txtTempAM);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtTimePM);
            this.groupBox2.Controls.Add(this.txtTimeAM);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 283);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(930, 124);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Temperature Details:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 28);
            this.label6.TabIndex = 2;
            this.label6.Text = "Time (AM):";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtCheckedBy);
            this.groupBox4.Location = new System.Drawing.Point(12, 616);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(455, 78);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Checked By:";
            // 
            // txtCheckedBy
            // 
            this.txtCheckedBy.Location = new System.Drawing.Point(12, 33);
            this.txtCheckedBy.Name = "txtCheckedBy";
            this.txtCheckedBy.Size = new System.Drawing.Size(437, 34);
            this.txtCheckedBy.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cmbModelSeries);
            this.groupBox5.Location = new System.Drawing.Point(11, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(456, 78);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Model Series:";
            // 
            // cmbModelSeries
            // 
            this.cmbModelSeries.FormattingEnabled = true;
            this.cmbModelSeries.Location = new System.Drawing.Point(6, 31);
            this.cmbModelSeries.Name = "cmbModelSeries";
            this.cmbModelSeries.Size = new System.Drawing.Size(444, 36);
            this.cmbModelSeries.TabIndex = 0;
            // 
            // FrmEditTemp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(955, 707);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEditTemp";
            this.Text = "FrmEditTemp";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEquipmentType;
        private System.Windows.Forms.TextBox txtTempPM;
        private System.Windows.Forms.TextBox txtTempAM;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTimePM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSolderPersonInCharge;
        private System.Windows.Forms.TextBox txtSolderLineAssigned;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSolderProcessAssigned;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSolderControlNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSolderModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimeAM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox richTxtRemarks;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtCheckedBy;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cmbModelSeries;
    }
}