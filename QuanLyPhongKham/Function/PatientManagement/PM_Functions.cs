using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyPhongKham.Function.PatientManagement
{
    internal class PM_Functions
    {
        public void FindPatient()
        {

        }

        SqlConnection connection = new SqlConnection(@"Data Source=WIN-30FJQ771AK3;Initial Catalog=QUANLYPHONGKHAM;Integrated Security=True");

        public void ShowPatientList(DataGridView dataGridView1)
        {
            string sql = "SELECT * FROM PATIENT";
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet dataSet = new DataSet();
            connection.Open();
            dataadapter.Fill(dataSet, "PATIENT");
            connection.Close();
            dataGridView1.DataSource = dataSet;
            dataGridView1.DataMember = "PATIENT";
        }
        public void ImportPatient(string patientID, string patientName, string patientPhone, string patientAddress, string patientDOB)
        {
            connection.Open();
            string sql = "INSERT INTO PATIENT VALUES ('" + patientID + "',N'" + patientName + "','" + patientPhone + "',N'" + patientAddress + "','" + patientDOB + "')";
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void DeletePatient(string patientID)
        {
            connection.Open();
            string sql = "DELETE FROM PATIENT WHERE PATIENT_ID = '" + patientID + "'";
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void EditPatient(string patientID, string patientName, string patientPhone, string patientAddress, string patientDOB)
        {
            connection.Open();
            string sql = "UPDATE PATIENT SET PATIENT_NAME = N'" + patientName + "', PATIENT_PHONENUMBER = '" + patientPhone + "', PATIENT_ADDRESS = N'" + patientAddress + "', PATIENT_DATEOFBIRTH = '" + patientDOB + "' WHERE PATIENT_ID = '" + patientID + "'";
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void Load_Data()
        {

        }
    }
}
