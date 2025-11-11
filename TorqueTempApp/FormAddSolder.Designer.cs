namespace TorqueTempApp
{
    partial class FrmAddSolder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddSolder));
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cmbModelSeries = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtCheckedBy = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.richTxtRemarks = new System.Windows.Forms.RichTextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTempPM = new System.Windows.Forms.TextBox();
            this.txtTempAM = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTimePM = new System.Windows.Forms.TextBox();
            this.txtTimeAM = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDriverModel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPersonInCharge = new System.Windows.Forms.TextBox();
            this.txtLineAssigned = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtProcessAssigned = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtControlNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEquipmentType = new System.Windows.Forms.ComboBox();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(7, 31);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(441, 34);
            this.dateTimePicker.TabIndex = 0;
            // 
            // cmbModelSeries
            // 
            this.cmbModelSeries.FormattingEnabled = true;
            this.cmbModelSeries.Location = new System.Drawing.Point(6, 31);
            this.cmbModelSeries.Name = "cmbModelSeries";
            this.cmbModelSeries.Size = new System.Drawing.Size(444, 36);
            this.cmbModelSeries.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cmbModelSeries);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(456, 78);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Model Series:";
            // 
            // txtCheckedBy
            // 
            this.txtCheckedBy.Location = new System.Drawing.Point(12, 33);
            this.txtCheckedBy.Name = "txtCheckedBy";
            this.txtCheckedBy.Size = new System.Drawing.Size(437, 34);
            this.txtCheckedBy.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtCheckedBy);
            this.groupBox4.Location = new System.Drawing.Point(13, 616);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(455, 78);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Checked By:";
            // 
            // richTxtRemarks
            // 
            this.richTxtRemarks.Location = new System.Drawing.Point(12, 34);
            this.richTxtRemarks.Name = "richTxtRemarks";
            this.richTxtRemarks.Size = new System.Drawing.Size(911, 156);
            this.richTxtRemarks.TabIndex = 0;
            this.richTxtRemarks.Text = "";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dateTimePicker);
            this.groupBox6.Location = new System.Drawing.Point(474, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(469, 78);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Date:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.richTxtRemarks);
            this.groupBox3.Location = new System.Drawing.Point(13, 414);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(931, 196);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Remarks:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(769, 616);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(175, 77);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add Record";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.groupBox2.Location = new System.Drawing.Point(13, 283);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(930, 124);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Torque Details:";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 28);
            this.label6.TabIndex = 2;
            this.label6.Text = "Time (AM):";
            // 
            // txtDriverModel
            // 
            this.txtDriverModel.Location = new System.Drawing.Point(191, 35);
            this.txtDriverModel.Margin = new System.Windows.Forms.Padding(4);
            this.txtDriverModel.Name = "txtDriverModel";
            this.txtDriverModel.Size = new System.Drawing.Size(264, 34);
            this.txtDriverModel.TabIndex = 1;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbEquipmentType);
            this.groupBox1.Controls.Add(this.txtPersonInCharge);
            this.groupBox1.Controls.Add(this.txtLineAssigned);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtProcessAssigned);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtControlNo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDriverModel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 97);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(930, 178);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driver Details:";
            // 
            // txtPersonInCharge
            // 
            this.txtPersonInCharge.Location = new System.Drawing.Point(645, 129);
            this.txtPersonInCharge.Margin = new System.Windows.Forms.Padding(4);
            this.txtPersonInCharge.Name = "txtPersonInCharge";
            this.txtPersonInCharge.Size = new System.Drawing.Size(264, 34);
            this.txtPersonInCharge.TabIndex = 1;
            // 
            // txtLineAssigned
            // 
            this.txtLineAssigned.Location = new System.Drawing.Point(191, 128);
            this.txtLineAssigned.Margin = new System.Windows.Forms.Padding(4);
            this.txtLineAssigned.Name = "txtLineAssigned";
            this.txtLineAssigned.Size = new System.Drawing.Size(264, 34);
            this.txtLineAssigned.TabIndex = 1;
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
            // txtProcessAssigned
            // 
            this.txtProcessAssigned.Location = new System.Drawing.Point(645, 81);
            this.txtProcessAssigned.Margin = new System.Windows.Forms.Padding(4);
            this.txtProcessAssigned.Name = "txtProcessAssigned";
            this.txtProcessAssigned.Size = new System.Drawing.Size(264, 34);
            this.txtProcessAssigned.TabIndex = 1;
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
            // txtControlNo
            // 
            this.txtControlNo.Location = new System.Drawing.Point(645, 35);
            this.txtControlNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtControlNo.Name = "txtControlNo";
            this.txtControlNo.Size = new System.Drawing.Size(264, 34);
            this.txtControlNo.TabIndex = 1;
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
            // cmbEquipmentType
            // 
            this.cmbEquipmentType.FormattingEnabled = true;
            this.cmbEquipmentType.Location = new System.Drawing.Point(191, 82);
            this.cmbEquipmentType.Name = "cmbEquipmentType";
            this.cmbEquipmentType.Size = new System.Drawing.Size(264, 36);
            this.cmbEquipmentType.TabIndex = 2;
            // 
            // FrmAddSolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 707);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAddSolder";
            this.Text = "Add Temperature";
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox cmbModelSeries;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtCheckedBy;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox richTxtRemarks;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTempPM;
        private System.Windows.Forms.TextBox txtTempAM;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTimePM;
        private System.Windows.Forms.TextBox txtTimeAM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDriverModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbEquipmentType;
        private System.Windows.Forms.TextBox txtPersonInCharge;
        private System.Windows.Forms.TextBox txtLineAssigned;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtProcessAssigned;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtControlNo;
        private System.Windows.Forms.Label label3;
    }
}