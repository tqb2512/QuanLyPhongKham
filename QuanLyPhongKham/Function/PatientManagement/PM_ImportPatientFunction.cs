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
    internal class PM_ImportPatientFunction
    {
        SqlConnection conn = new SqlConnection(@"Data Source=WIN-30FJQ771AK3;Initial Catalog=QUANLYPHONGKHAM;Integrated Security=True");
        public void ImportPatient(int patientID, string patientName, string patientPhone, string patientAddress, string patientDOB)
        {
            conn.Open();
            string sql = "INSERT INTO PATIENT VALUES ('" + patientID + "',N'" + patientName + "','" + patientPhone + "',N'" + patientAddress + "','" + patientDOB + "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
