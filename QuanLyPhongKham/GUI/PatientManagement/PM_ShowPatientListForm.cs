using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using QuanLyPhongKham.Function.PatientManagement;

namespace QuanLyPhongKham.GUI.PatientManagement
{
    public partial class PM_ShowPatientListForm : Form
    {
        public PM_ShowPatientListForm()
        {
            InitializeComponent();
        }

        private void PM_ShowPatientList_Load(object sender, EventArgs e)
        {
            
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
        }
        
        private void buttonDetailPatient_Click(object sender, EventArgs e)
        {
            Load_Data();
        }


        private void buttonImportPatient_Click(object sender, EventArgs e)
        {
            PM_ImportPatientForm importPatientForm = new PM_ImportPatientForm();
            importPatientForm.Show();
        }        

        private void buttonEditPatient_Click(object sender, EventArgs e)
        {

                string patientID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string patientName = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                string patientAddress = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                string patientPhone = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                string patientDOB = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                PM_EditPatientForm editPatientForm = new PM_EditPatientForm();
                editPatientForm.Show();
                editPatientForm.LoadDataToEditForm(patientID, patientName, patientAddress, patientPhone, patientDOB);
        }


        //Kiểm tra button nếu user đã click button xóa 
        private void buttonDeletePatient_Click(object sender, EventArgs e)
        {
            string patientID = textBox1.Text;
            PM_Functions func = new PM_Functions();
            func.DeletePatient(patientID);
            Load_Data();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void PM_ShowPatientListForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string find_patientID = textBox5.Text;
            SqlConnection connection = new SqlConnection(@"Data Source=WIN-30FJQ771AK3;Initial Catalog=QUANLYPHONGKHAM;Integrated Security=True");            
        }
    }
}
