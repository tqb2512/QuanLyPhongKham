using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyPhongKham.Classes;
using QuanLyPhongKham.GUI.PatientManagement;
using System.Windows.Forms;

namespace QuanLyPhongKham.Function.PatientManagement
{
    internal class PM_ShowPatientListFuction
    {
        public void ShowPatientList(DataGridView dataGridView1)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=WIN-30FJQ771AK3;Initial Catalog=QUANLYPHONGKHAM;Integrated Security=True");
            string sql = "SELECT * FROM PATIENT";
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, conn);
            DataSet dataSet = new DataSet();
            conn.Open();
            dataadapter.Fill(dataSet, "PATIENT");
            conn.Close();
            dataGridView1.DataSource = dataSet;
            dataGridView1.DataMember = "PATIENT";
        }

        public void UpdateDataGridView()
        {

        }
    }
}

