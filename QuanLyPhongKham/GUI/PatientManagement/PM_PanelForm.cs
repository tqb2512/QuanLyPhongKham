using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace QuanLyPhongKham.GUI.PatientManagement
{
    public partial class PM_PatientForm : Form
    {
        public PM_PatientForm()
        {
            InitializeComponent();
        }
        public void Load_Data()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=WIN-30FJQ771AK3;Initial Catalog=QUANLYPHONGKHAM;Integrated Security=True");
            string sql = "SELECT * FROM PATIENT";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            SqlCommand cmd = new SqlCommand(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            adapter.Fill(ds);
            cmd.ExecuteNonQuery();
            connection.Close();           
        }
    }
}
