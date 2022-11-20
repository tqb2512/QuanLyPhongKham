using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyPhongKham.Classes;
using QuanLyPhongKham.GUI.PatientManagement;
using System.Data.SqlClient;

namespace QuanLyPhongKham.Function.PatientManagement
{
    internal class PM_DeletePatientFunction
    {
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
