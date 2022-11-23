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
        public void EditPatient(string patientID)
        {
            connection.Open();
            
        }
    }
}
