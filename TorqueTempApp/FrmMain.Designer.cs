namespace TorqueTempApp
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tabMainControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoLine = new System.Windows.Forms.RadioButton();
            this.rdoModelSeries = new System.Windows.Forms.RadioButton();
            this.rdoScrew = new System.Windows.Forms.RadioButton();
            this.rdoDate = new System.Windows.Forms.RadioButton();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnApplyFilterTorque = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTorqueEdit = new System.Windows.Forms.Button();
            this.btnTorqueAdd = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnSoldEdit = new System.Windows.Forms.Button();
            this.btnSoldAdd = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.torqueRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solderingTempToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoLineTemp = new System.Windows.Forms.RadioButton();
            this.rdoModelSeriesTemp = new System.Windows.Forms.RadioButton();
            this.rdoEquipmentType = new System.Windows.Forms.RadioButton();
            this.rdoDateTemp = new System.Windows.Forms.RadioButton();
            this.txtFilterTemp = new System.Windows.Forms.TextBox();
            this.btnApplyFilterTemp = new System.Windows.Forms.Button();
            this.tabMainControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMainControl
            // 
            this.tabMainControl.Controls.Add(this.tabPage1);
            this.tabMainControl.Controls.Add(this.tabPage2);
            this.tabMainControl.Location = new System.Drawing.Point(15, 48);
            this.tabMainControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabMainControl.Name = "tabMainControl";
            this.tabMainControl.SelectedIndex = 0;
            this.tabMainControl.Size = new System.Drawing.Size(1658, 732);
            this.tabMainControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btnTorqueEdit);
            this.tabPage1.Controls.Add(this.btnTorqueAdd);
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1650, 691);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Torque";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoLine);
            this.groupBox1.Controls.Add(this.rdoModelSeries);
            this.groupBox1.Controls.Add(this.rdoScrew);
            this.groupBox1.Controls.Add(this.rdoDate);
            this.groupBox1.Controls.Add(this.txtFilter);
            this.groupBox1.Controls.Add(this.btnApplyFilterTorque);
            this.groupBox1.Location = new System.Drawing.Point(9, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 201);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter By:";
            // 
            // rdoLine
            // 
            this.rdoLine.AutoSize = true;
            this.rdoLine.Location = new System.Drawing.Point(187, 112);
            this.rdoLine.Name = "rdoLine";
            this.rdoLine.Size = new System.Drawing.Size(72, 32);
            this.rdoLine.TabIndex = 9;
            this.rdoLine.TabStop = true;
            this.rdoLine.Text = "Line";
            this.rdoLine.UseVisualStyleBackColor = true;
            // 
            // rdoModelSeries
            // 
            this.rdoModelSeries.AutoSize = true;
            this.rdoModelSeries.Location = new System.Drawing.Point(7, 113);
            this.rdoModelSeries.Name = "rdoModelSeries";
            this.rdoModelSeries.Size = new System.Drawing.Size(150, 32);
            this.rdoModelSeries.TabIndex = 9;
            this.rdoModelSeries.TabStop = true;
            this.rdoModelSeries.Text = "Model Series";
            this.rdoModelSeries.UseVisualStyleBackColor = true;
            // 
            // rdoScrew
            // 
            this.rdoScrew.AutoSize = true;
            this.rdoScrew.Location = new System.Drawing.Point(187, 74);
            this.rdoScrew.Name = "rdoScrew";
            this.rdoScrew.Size = new System.Drawing.Size(134, 32);
            this.rdoScrew.TabIndex = 9;
            this.rdoScrew.TabStop = true;
            this.rdoScrew.Text = "Screw Type";
            this.rdoScrew.UseVisualStyleBackColor = true;
            // 
            // rdoDate
            // 
            this.rdoDate.AutoSize = true;
            this.rdoDate.Location = new System.Drawing.Point(7, 75);
            this.rdoDate.Name = "rdoDate";
            this.rdoDate.Size = new System.Drawing.Size(78, 32);
            this.rdoDate.TabIndex = 9;
            this.rdoDate.TabStop = true;
            this.rdoDate.Text = "Date";
            this.rdoDate.UseVisualStyleBackColor = true;
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(7, 34);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(333, 34);
            this.txtFilter.TabIndex = 8;
            // 
            // btnApplyFilterTorque
            // 
            this.btnApplyFilterTorque.Location = new System.Drawing.Point(7, 152);
            this.btnApplyFilterTorque.Margin = new System.Windows.Forms.Padding(4);
            this.btnApplyFilterTorque.Name = "btnApplyFilterTorque";
            this.btnApplyFilterTorque.Size = new System.Drawing.Size(333, 39);
            this.btnApplyFilterTorque.TabIndex = 7;
            this.btnApplyFilterTorque.Text = "Search";
            this.btnApplyFilterTorque.UseVisualStyleBackColor = true;
            this.btnApplyFilterTorque.Click += new System.EventHandler(this.btnApplyFilterTorque_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(363, 8);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1279, 668);
            this.dataGridView1.TabIndex = 5;
            // 
            // btnTorqueEdit
            // 
            this.btnTorqueEdit.Location = new System.Drawing.Point(7, 573);
            this.btnTorqueEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnTorqueEdit.Name = "btnTorqueEdit";
            this.btnTorqueEdit.Size = new System.Drawing.Size(348, 103);
            this.btnTorqueEdit.TabIndex = 4;
            this.btnTorqueEdit.Text = "Edit";
            this.btnTorqueEdit.UseVisualStyleBackColor = true;
            this.btnTorqueEdit.Click += new System.EventHandler(this.btnTorqueEdit_Click);
            // 
            // btnTorqueAdd
            // 
            this.btnTorqueAdd.Location = new System.Drawing.Point(7, 462);
            this.btnTorqueAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnTorqueAdd.Name = "btnTorqueAdd";
            this.btnTorqueAdd.Size = new System.Drawing.Size(348, 103);
            this.btnTorqueAdd.TabIndex = 4;
            this.btnTorqueAdd.Text = "Add";
            this.btnTorqueAdd.UseVisualStyleBackColor = true;
            this.btnTorqueAdd.Click += new System.EventHandler(this.btnTorqueAdd_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.btnSoldEdit);
            this.tabPage2.Controls.Add(this.btnSoldAdd);
            this.tabPage2.Location = new System.Drawing.Point(4, 37);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1650, 691);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Soldering Temp.";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(363, 8);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(1279, 675);
            this.dataGridView2.TabIndex = 11;
            // 
            // btnSoldEdit
            // 
            this.btnSoldEdit.Location = new System.Drawing.Point(8, 580);
            this.btnSoldEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSoldEdit.Name = "btnSoldEdit";
            this.btnSoldEdit.Size = new System.Drawing.Size(348, 103);
            this.btnSoldEdit.TabIndex = 9;
            this.btnSoldEdit.Text = "Edit";
            this.btnSoldEdit.UseVisualStyleBackColor = true;
            this.btnSoldEdit.Click += new System.EventHandler(this.btnSoldEdit_Click);
            // 
            // btnSoldAdd
            // 
            this.btnSoldAdd.Location = new System.Drawing.Point(8, 469);
            this.btnSoldAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnSoldAdd.Name = "btnSoldAdd";
            this.btnSoldAdd.Size = new System.Drawing.Size(348, 103);
            this.btnSoldAdd.TabIndex = 10;
            this.btnSoldAdd.Text = "Add";
            this.btnSoldAdd.UseVisualStyleBackColor = true;
            this.btnSoldAdd.Click += new System.EventHandler(this.btnSoldAdd_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.torqueRecordToolStripMenuItem,
            this.solderingTempToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1681, 37);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // torqueRecordToolStripMenuItem
            // 
            this.torqueRecordToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem});
            this.torqueRecordToolStripMenuItem.Name = "torqueRecordToolStripMenuItem";
            this.torqueRecordToolStripMenuItem.Size = new System.Drawing.Size(142, 29);
            this.torqueRecordToolStripMenuItem.Text = "Torque Record";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // solderingTempToolStripMenuItem
            // 
            this.solderingTempToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.editToolStripMenuItem1});
            this.solderingTempToolStripMenuItem.Name = "solderingTempToolStripMenuItem";
            this.solderingTempToolStripMenuItem.Size = new System.Drawing.Size(152, 29);
            this.solderingTempToolStripMenuItem.Text = "Soldering Temp";
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.addToolStripMenuItem1.Text = "Add";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.addToolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.editToolStripMenuItem1.Text = "Edit";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.editToolStripMenuItem1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoLineTemp);
            this.groupBox2.Controls.Add(this.rdoModelSeriesTemp);
            this.groupBox2.Controls.Add(this.rdoEquipmentType);
            this.groupBox2.Controls.Add(this.rdoDateTemp);
            this.groupBox2.Controls.Add(this.txtFilterTemp);
            this.groupBox2.Controls.Add(this.btnApplyFilterTemp);
            this.groupBox2.Location = new System.Drawing.Point(9, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 201);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter By:";
            // 
            // rdoLineTemp
            // 
            this.rdoLineTemp.AutoSize = true;
            this.rdoLineTemp.Location = new System.Drawing.Point(187, 112);
            this.rdoLineTemp.Name = "rdoLineTemp";
            this.rdoLineTemp.Size = new System.Drawing.Size(72, 32);
            this.rdoLineTemp.TabIndex = 9;
            this.rdoLineTemp.TabStop = true;
            this.rdoLineTemp.Text = "Line";
            this.rdoLineTemp.UseVisualStyleBackColor = true;
            // 
            // rdoModelSeriesTemp
            // 
            this.rdoModelSeriesTemp.AutoSize = true;
            this.rdoModelSeriesTemp.Location = new System.Drawing.Point(7, 113);
            this.rdoModelSeriesTemp.Name = "rdoModelSeriesTemp";
            this.rdoModelSeriesTemp.Size = new System.Drawing.Size(150, 32);
            this.rdoModelSeriesTemp.TabIndex = 9;
            this.rdoModelSeriesTemp.TabStop = true;
            this.rdoModelSeriesTemp.Text = "Model Series";
            this.rdoModelSeriesTemp.UseVisualStyleBackColor = true;
            // 
            // rdoEquipmentType
            // 
            this.rdoEquipmentType.AutoSize = true;
            this.rdoEquipmentType.Location = new System.Drawing.Point(187, 74);
            this.rdoEquipmentType.Name = "rdoEquipmentType";
            this.rdoEquipmentType.Size = new System.Drawing.Size(78, 32);
            this.rdoEquipmentType.TabIndex = 9;
            this.rdoEquipmentType.TabStop = true;
            this.rdoEquipmentType.Text = "Type";
            this.rdoEquipmentType.UseVisualStyleBackColor = true;
            // 
            // rdoDateTemp
            // 
            this.rdoDateTemp.AutoSize = true;
            this.rdoDateTemp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rdoDateTemp.Location = new System.Drawing.Point(7, 75);
            this.rdoDateTemp.Name = "rdoDateTemp";
            this.rdoDateTemp.Size = new System.Drawing.Size(78, 32);
            this.rdoDateTemp.TabIndex = 9;
            this.rdoDateTemp.TabStop = true;
            this.rdoDateTemp.Text = "Date";
            this.rdoDateTemp.UseVisualStyleBackColor = true;
            // 
            // txtFilterTemp
            // 
            this.txtFilterTemp.Location = new System.Drawing.Point(7, 34);
            this.txtFilterTemp.Name = "txtFilterTemp";
            this.txtFilterTemp.Size = new System.Drawing.Size(333, 34);
            this.txtFilterTemp.TabIndex = 8;
            // 
            // btnApplyFilterTemp
            // 
            this.btnApplyFilterTemp.Location = new System.Drawing.Point(7, 152);
            this.btnApplyFilterTemp.Margin = new System.Windows.Forms.Padding(4);
            this.btnApplyFilterTemp.Name = "btnApplyFilterTemp";
            this.btnApplyFilterTemp.Size = new System.Drawing.Size(333, 39);
            this.btnApplyFilterTemp.TabIndex = 7;
            this.btnApplyFilterTemp.Text = "Search";
            this.btnApplyFilterTemp.UseVisualStyleBackColor = true;
            this.btnApplyFilterTemp.Click += new System.EventHandler(this.btnApplyFilterTemp_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1681, 789);
            this.Controls.Add(this.tabMainControl);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.Text = "HPI - Torque and Soldering Temp Records";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tabMainControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabMainControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem torqueRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solderingTempToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.Button btnTorqueEdit;
        private System.Windows.Forms.Button btnTorqueAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnSoldEdit;
        private System.Windows.Forms.Button btnSoldAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoLine;
        private System.Windows.Forms.RadioButton rdoModelSeries;
        private System.Windows.Forms.RadioButton rdoScrew;
        private System.Windows.Forms.RadioButton rdoDate;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnApplyFilterTorque;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoLineTemp;
        private System.Windows.Forms.RadioButton rdoModelSeriesTemp;
        private System.Windows.Forms.RadioButton rdoEquipmentType;
        private System.Windows.Forms.RadioButton rdoDateTemp;
        private System.Windows.Forms.TextBox txtFilterTemp;
        private System.Windows.Forms.Button btnApplyFilterTemp;
    }
}

