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
            SqlConnection conn = new SqlConnection(@"Data Source=WIN-30FJQ771AK3;Initial Catalog=QUANLYPHONGKHAM;Integrated Security=True");
            string sql = "SELECT * FROM PATIENT";
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, conn);
            DataSet dataSet = new DataSet();
            conn.Open();
            dataadapter.Fill(dataSet, "PATIENT");
            conn.Close();
            dataGridView1.DataSource = dataSet;
            dataGridView1.DataMember = "PATIENT";
            dataGridView1.ReadOnly = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PM_DetailsPatientForm form = new PM_DetailsPatientForm();
            form.textBoxIDPatient.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            form.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            form.textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            form.textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            form.textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            form.Data_Load();
            form.ShowDialog();
            
        }

        private void PM_PatientForm_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
