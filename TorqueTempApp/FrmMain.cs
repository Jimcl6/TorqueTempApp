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

        private void LoadTorqueRecords()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM torque_records";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void LoadTempRecords()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM temp_records";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
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

            // Pass this ID to the edit form
            FrmEditTorque editForm = new FrmEditTorque(recordId);
            editForm.StartPosition = FormStartPosition.CenterScreen;
            editForm.ShowDialog();

            if (editForm.DialogResult == DialogResult.OK)
            {
                LoadTorqueRecords(); // refresh grid after editing
            }
        }

        private void btnSoldAdd_Click(object sender, EventArgs e)
        {
            // Open the Add form
            FrmAddSolder addSolder = new FrmAddSolder();
            addSolder.StartPosition = FormStartPosition.CenterScreen;

            // Show the form and check if user clicked "Add Record"
            if (addSolder.ShowDialog() == DialogResult.OK)
            {
                LoadTempRecords(); // Refresh the data grid
            }
        }

        private void btnSoldEdit_Click(object sender, EventArgs e)
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
                LoadTempRecords(); // refresh grid after editing
            }
        }
    }
}
