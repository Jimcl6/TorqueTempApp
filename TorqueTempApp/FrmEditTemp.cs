using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorqueTempApp
{
    public partial class FrmEditTemp : Form
    {
        string connectionString = "Server=192.168.2.148;Database=fc_1_data_db;Uid=hpi.python;Pwd=hpi.python;";
        int recordId;
        public FrmEditTemp(int id)
        {
            InitializeComponent();
            recordId = id;
            LoadRecordData();
        }

        private void LoadRecordData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM temp_records WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", recordId);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    dateTimePicker.Text = reader["date"].ToString();
                    cmbModelSeries.Text = reader["model_series"].ToString();
                    txtDriverModel.Text = reader["solder_model"].ToString();
                    txtControlNo.Text = reader["control_no"].ToString();
                    cmbEquipmentType.Text = reader["equipment_type"].ToString();
                    txtProcessAssigned.Text = reader["process_assigned"].ToString();
                    txtPersonInCharge.Text = reader["person_in_charge"].ToString();
                    txtLineAssigned.Text = reader["line_assigned"].ToString();
                    txtTimeAM.Text = reader["time_am"].ToString();
                    txtTempAM.Text = reader["temp_am"].ToString();
                    txtTimePM.Text = reader["time_pm"].ToString();
                    txtTempPM.Text = reader["temp_pm"].ToString();
                    richTxtRemarks.Text = reader["col_remarks"].ToString();
                    txtCheckedBy.Text = reader["checked_by"].ToString();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = @"UPDATE temp_records SET 
                                 date=@date, model_series=@model_series, driver_model=@driver_model, control_no=@control_no, driver_type=@driver_type,
                                 process_assigned=@process_assigned, person_in_charge=@person_in_charge, line_assigned=@line_assigned,
                                 time_am=@time_am, temp_am=@temp_am, time_pm=@time_pm, temp_pm=@temp_pm, col_remarks=@col_remarks, checked_by=@checked_by
                                 WHERE id=@id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@date", dateTimePicker.Value);
                cmd.Parameters.AddWithValue("@model_series", cmbModelSeries.Text);
                cmd.Parameters.AddWithValue("@driver_model", txtDriverModel.Text);
                cmd.Parameters.AddWithValue("@control_no", txtControlNo.Text);
                cmd.Parameters.AddWithValue("@driver_type", cmbEquipmentType.Text);
                cmd.Parameters.AddWithValue("@process_assigned", txtProcessAssigned.Text);
                cmd.Parameters.AddWithValue("@person_in_charge", txtPersonInCharge.Text);
                cmd.Parameters.AddWithValue("@line_assigned", txtLineAssigned.Text);
                cmd.Parameters.AddWithValue("@time_am", txtTimeAM.Text);
                cmd.Parameters.AddWithValue("@torque_am", txtTempAM.Text);
                cmd.Parameters.AddWithValue("@time_pm", txtTimePM.Text);
                cmd.Parameters.AddWithValue("@torque_pm", txtTempPM.Text);
                cmd.Parameters.AddWithValue("@col_remarks", richTxtRemarks.Text);
                cmd.Parameters.AddWithValue("@checked_by", txtCheckedBy.Text);
                cmd.Parameters.AddWithValue("@id", recordId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
