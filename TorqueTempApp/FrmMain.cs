using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace TorqueTempApp
{
    public partial class FrmMain : Form
    {
        string connectionString = "Server=192.168.2.148;Database=fc_1_data_db;Uid=hpi.python;Pwd=hpi.python;";


        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadTorqueRecords(); // Load data when main form opens
            LoadTempRecords(); // Load data when main form opens
        }

        private DataTable originalTorqueData;
        private DataTable originalTempData;

        private void LoadTorqueRecords()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM torque_records";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                originalTorqueData = new DataTable();
                da.Fill(originalTorqueData);
                dataGridView1.DataSource = originalTorqueData;
            }
        }

        private void LoadTempRecords()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM temp_records";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                originalTempData = new DataTable();
                da.Fill(originalTempData);
                dataGridView2.DataSource = originalTempData;
            }
        }

        private void btnTorqueAdd_Click(object sender, EventArgs e)
        {
            // Open the Add form
            FrmAddTorque addForm = new FrmAddTorque();
            addForm.StartPosition = FormStartPosition.CenterScreen;

            // Show the form and check if user clicked "Add Record"
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadTorqueRecords(); // Refresh the data grid
            }
        }


        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open the Add form
            FrmAddTorque addForm = new FrmAddTorque();
            addForm.StartPosition = FormStartPosition.CenterScreen;

            // Show the form and check if user clicked "Add Record"
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadTorqueRecords(); // Refresh the data grid
            }
        }

        private void btnTorqueEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select a record to edit.", "No Record Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get selected record ID
            int recordId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);

            //MessageBox.Show($"Editing record ID: {recordId}");

            // Pass this ID to the edit form
            FrmEditTorque editForm = new FrmEditTorque(recordId);
            editForm.StartPosition = FormStartPosition.CenterScreen;
            editForm.ShowDialog();

            if (editForm.DialogResult == DialogResult.OK)
            {
                LoadTorqueRecords(); // refresh grid after editing
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select a record to edit.", "No Record Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get selected record ID
            int recordId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);

            
            FrmEditTorque editForm = new FrmEditTorque(recordId);
            editForm.StartPosition = FormStartPosition.CenterScreen;
            editForm.ShowDialog();

            if (editForm.DialogResult == DialogResult.OK)
            {
                LoadTorqueRecords(); 
            }
        }

        private void btnSoldAdd_Click(object sender, EventArgs e)
        {
            
            FrmAddSolder addSolder = new FrmAddSolder();
            addSolder.StartPosition = FormStartPosition.CenterScreen;

            
            if (addSolder.ShowDialog() == DialogResult.OK)
            {
                LoadTempRecords(); 
            }
        }

        private void btnSoldEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select a record to edit.", "No Record Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            int recordId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);

            FrmEditTorque editForm = new FrmEditTorque(recordId);
            editForm.StartPosition = FormStartPosition.CenterScreen;
            editForm.ShowDialog();

            if (editForm.DialogResult == DialogResult.OK)
            {
                LoadTempRecords(); 
            }
        }

        private void btnApplyFilterTorque_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (string.IsNullOrWhiteSpace(txtFilter.Text))
                {
                    MessageBox.Show("Please enter a value to filter.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string filterValue = txtFilter.Text.Trim();
                string filterColumn = string.Empty;

                
                if (rdoDate.Checked)
                    filterColumn = "date";
                else if (rdoScrew.Checked)
                    filterColumn = "screw_type";
                else if (rdoModelSeries.Checked)
                    filterColumn = "model_series";
                else if (rdoLine.Checked)
                    filterColumn = "line_assigned";
                else
                {
                    MessageBox.Show("Please select a filter criterion.", "No Filter Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                DataView dv = new DataView(originalTorqueData);

                
                if (rdoDate.Checked)
                {
                    
                    if (!DateTime.TryParseExact(filterValue, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dateValue))
                    {
                        MessageBox.Show("Invalid date format. Please use dd/MM/yyyy.", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    
                    dv.RowFilter = string.Format("CONVERT([{0}], 'System.String') LIKE '%{1}%'", filterColumn, dateValue.ToString("yyyy-MM-dd"));
                }
                else
                {
                    
                    dv.RowFilter = string.Format("CONVERT([{0}], 'System.String') LIKE '%{1}%'", filterColumn, filterValue.Replace("'", "''"));
                }

                
                dataGridView1.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error applying filter: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
