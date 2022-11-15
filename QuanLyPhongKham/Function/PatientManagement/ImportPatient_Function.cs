using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyPhongKham.Function.PatientManagement
{
    internal class IMportPatient_Function
    {
        SqlConnection conn = new SqlConnection(@"Data Source=WIN-30FJQ771AK3;Initial Catalog=QUANLYPHONGKHAM;Integrated Security=True");
        public void ImportPatient(string patientID, string patientName, string patientGender, string patientDOB, string patientAddress, string patientPhone, string patientEmail, string patientJob, string patientNote)
        {
            conn.Open();
            string sql = "INSERT INTO PATIENT VALUES ('" + patientID + "', N'" + patientName + "', N'" + patientGender + "', '" + patientDOB + "', N'" + patientAddress + "', '" + patientPhone + "', '" + patientEmail + "', N'" + patientJob + "', N'" + patientNote + "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
