using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace TorqueTempApp
{
    public partial class FrmAddTorque : Form
    {
        string connectionString = "Server=192.168.2.148;Database=fc_1_data_db;Uid=hpi.python;Pwd=hpi.python;";

        public FrmAddTorque()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO torque_records (driver_model, control_no, driver_type, process_assigned, person_in_charge, line_assigned, time_am, torque_am, time_pm, torque_pm, col_remarks, checked_by) " +
                   "VALUES (@driver_model, @control_no, @driver_type, @process_assigned, @person_in_charge, @line_assigned, @time_am, @torque_am, @time_pm, @torque_pm, @col_remarks, @checked_by)";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@driver_model", txtDriverModel.Text);
                cmd.Parameters.AddWithValue("@control_no", txtControlNo.Text);
                cmd.Parameters.AddWithValue("@driver_type", txtDriverType.Text);
                cmd.Parameters.AddWithValue("@process_assigned", txtProcessAssigned.Text);
                cmd.Parameters.AddWithValue("@person_in_charge", txtPersonInCharge.Text);
                cmd.Parameters.AddWithValue("@col_remarks", richTxtRemarks.Text);
                cmd.Parameters.AddWithValue("@checked_by", txtCheckedBy.Text);
                cmd.Parameters.AddWithValue("@line_assigned", txtLineAssigned.Text);
                cmd.Parameters.AddWithValue("@time_am", txtTimeAM.Text);
                cmd.Parameters.AddWithValue("@torque_am", txtTorqueAM.Text);
                cmd.Parameters.AddWithValue("@time_pm", txtTimePM.Text);
                cmd.Parameters.AddWithValue("@torque_pm", txtTorquePM.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

            }

            MessageBox.Show("Record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK; // closes form if opened via ShowDialog()
        }

        
    }
}
