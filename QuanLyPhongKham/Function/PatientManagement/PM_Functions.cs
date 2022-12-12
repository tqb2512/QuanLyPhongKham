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

        public void DeletePatient(string patientID)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=WIN-30FJQ771AK3;Initial Catalog=QUANLYPHONGKHAM;Integrated Security=True");
            conn.Open();
            string sql = "DELETE FROM PATIENT WHERE PATIENT_ID = '" + patientID + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
