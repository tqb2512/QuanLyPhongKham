using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QuanLyPhongKham.Classes;
using QuanLyPhongKham.GUI.PatientManagement;

namespace QuanLyPhongKham.Function.PatientManagement
{
    internal class PM_EditPatientFunction
    {
        SqlConnection connection = new SqlConnection(@"Data Source=WIN-30FJQ771AK3;Initial Catalog=QUANLYPHONGKHAM;Integrated Security=True");
        public void EditPatient(string patientID, string patientName, string patientPhone, string patientAddress, string patientDOB)
        {
            connection.Open();
            string sql = "UPDATE PATIENT SET PATIENT_NAME = N'" + patientName + "', PATIENT_PHONENUMBER = '" + patientPhone + "', PATIENT_ADDRESS = N'" + patientAddress + "', PATIENT_DATEOFBIRTH = '" + patientDOB + "' WHERE PATIENT_ID = '" + patientID + "'";
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
