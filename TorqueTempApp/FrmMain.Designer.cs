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
            this.label1 = new System.Windows.Forms.Label();
            this.btnTorqueSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTorqueDelete = new System.Windows.Forms.Button();
            this.btnTorqueEdit = new System.Windows.Forms.Button();
            this.btnTorqueAdd = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnSoldDelete = new System.Windows.Forms.Button();
            this.btnSoldEdit = new System.Windows.Forms.Button();
            this.btnSoldAdd = new System.Windows.Forms.Button();
            this.buttonSoldSearch = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.torqueRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solderingTempToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMainControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMainControl
            // 
            this.tabMainControl.Controls.Add(this.tabPage1);
            this.tabMainControl.Controls.Add(this.tabPage2);
            this.tabMainControl.Location = new System.Drawing.Point(15, 48);
            this.tabMainControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabMainControl.Name = "tabMainControl";
            this.tabMainControl.SelectedIndex = 0;
            this.tabMainControl.Size = new System.Drawing.Size(1925, 1044);
            this.tabMainControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnTorqueSearch);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btnTorqueDelete);
            this.tabPage1.Controls.Add(this.btnTorqueEdit);
            this.tabPage1.Controls.Add(this.btnTorqueAdd);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1917, 1010);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Torque";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search:";
            // 
            // btnTorqueSearch
            // 
            this.btnTorqueSearch.Location = new System.Drawing.Point(792, 8);
            this.btnTorqueSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTorqueSearch.Name = "btnTorqueSearch";
            this.btnTorqueSearch.Size = new System.Drawing.Size(205, 39);
            this.btnTorqueSearch.TabIndex = 3;
            this.btnTorqueSearch.Text = "Search";
            this.btnTorqueSearch.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(444, 8);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(340, 34);
            this.textBox1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(363, 55);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1545, 936);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnTorqueDelete
            // 
            this.btnTorqueDelete.Location = new System.Drawing.Point(7, 888);
            this.btnTorqueDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTorqueDelete.Name = "btnTorqueDelete";
            this.btnTorqueDelete.Size = new System.Drawing.Size(348, 103);
            this.btnTorqueDelete.TabIndex = 4;
            this.btnTorqueDelete.Text = "Delete";
            this.btnTorqueDelete.UseVisualStyleBackColor = true;
            // 
            // btnTorqueEdit
            // 
            this.btnTorqueEdit.Location = new System.Drawing.Point(7, 119);
            this.btnTorqueEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTorqueEdit.Name = "btnTorqueEdit";
            this.btnTorqueEdit.Size = new System.Drawing.Size(348, 103);
            this.btnTorqueEdit.TabIndex = 4;
            this.btnTorqueEdit.Text = "Edit";
            this.btnTorqueEdit.UseVisualStyleBackColor = true;
            this.btnTorqueEdit.Click += new System.EventHandler(this.btnTorqueEdit_Click);
            // 
            // btnTorqueAdd
            // 
            this.btnTorqueAdd.Location = new System.Drawing.Point(7, 8);
            this.btnTorqueAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTorqueAdd.Name = "btnTorqueAdd";
            this.btnTorqueAdd.Size = new System.Drawing.Size(348, 103);
            this.btnTorqueAdd.TabIndex = 4;
            this.btnTorqueAdd.Text = "Add";
            this.btnTorqueAdd.UseVisualStyleBackColor = true;
            this.btnTorqueAdd.Click += new System.EventHandler(this.btnTorqueAdd_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.btnSoldDelete);
            this.tabPage2.Controls.Add(this.btnSoldEdit);
            this.tabPage2.Controls.Add(this.btnSoldAdd);
            this.tabPage2.Controls.Add(this.buttonSoldSearch);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 37);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1917, 1003);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Soldering Temp.";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 28);
            this.label2.TabIndex = 12;
            this.label2.Text = "Search:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(363, 55);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(1545, 936);
            this.dataGridView2.TabIndex = 11;
            // 
            // btnSoldDelete
            // 
            this.btnSoldDelete.Location = new System.Drawing.Point(7, 888);
            this.btnSoldDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSoldDelete.Name = "btnSoldDelete";
            this.btnSoldDelete.Size = new System.Drawing.Size(348, 103);
            this.btnSoldDelete.TabIndex = 8;
            this.btnSoldDelete.Text = "Delete";
            this.btnSoldDelete.UseVisualStyleBackColor = true;
            // 
            // btnSoldEdit
            // 
            this.btnSoldEdit.Location = new System.Drawing.Point(7, 119);
            this.btnSoldEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSoldEdit.Name = "btnSoldEdit";
            this.btnSoldEdit.Size = new System.Drawing.Size(348, 103);
            this.btnSoldEdit.TabIndex = 9;
            this.btnSoldEdit.Text = "Edit";
            this.btnSoldEdit.UseVisualStyleBackColor = true;
            // 
            // btnSoldAdd
            // 
            this.btnSoldAdd.Location = new System.Drawing.Point(7, 8);
            this.btnSoldAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSoldAdd.Name = "btnSoldAdd";
            this.btnSoldAdd.Size = new System.Drawing.Size(348, 103);
            this.btnSoldAdd.TabIndex = 10;
            this.btnSoldAdd.Text = "Add";
            this.btnSoldAdd.UseVisualStyleBackColor = true;
            this.btnSoldAdd.Click += new System.EventHandler(this.btnSoldAdd_Click);
            // 
            // buttonSoldSearch
            // 
            this.buttonSoldSearch.Location = new System.Drawing.Point(801, 9);
            this.buttonSoldSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSoldSearch.Name = "buttonSoldSearch";
            this.buttonSoldSearch.Size = new System.Drawing.Size(205, 39);
            this.buttonSoldSearch.TabIndex = 7;
            this.buttonSoldSearch.Text = "Search";
            this.buttonSoldSearch.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(444, 9);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(340, 34);
            this.textBox2.TabIndex = 6;
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
            this.menuStrip1.Size = new System.Drawing.Size(1954, 37);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // torqueRecordToolStripMenuItem
            // 
            this.torqueRecordToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
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
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // solderingTempToolStripMenuItem
            // 
            this.solderingTempToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.editToolStripMenuItem1,
            this.deleteToolStripMenuItem1});
            this.solderingTempToolStripMenuItem.Name = "solderingTempToolStripMenuItem";
            this.solderingTempToolStripMenuItem.Size = new System.Drawing.Size(152, 29);
            this.solderingTempToolStripMenuItem.Text = "Soldering Temp";
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.addToolStripMenuItem1.Text = "Add";
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.editToolStripMenuItem1.Text = "Edit";
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.deleteToolStripMenuItem1.Text = "Delete";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1954, 1108);
            this.Controls.Add(this.tabMainControl);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMain";
            this.Text = "HPI - Torque and Soldering Temp Records";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tabMainControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solderingTempToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnTorqueSearch;
        private System.Windows.Forms.Button btnTorqueEdit;
        private System.Windows.Forms.Button btnTorqueAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTorqueDelete;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnSoldDelete;
        private System.Windows.Forms.Button btnSoldEdit;
        private System.Windows.Forms.Button btnSoldAdd;
        private System.Windows.Forms.Button buttonSoldSearch;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

