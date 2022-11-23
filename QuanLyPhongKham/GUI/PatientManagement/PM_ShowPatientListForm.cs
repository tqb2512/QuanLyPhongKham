using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
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

        //Biến toàn cục lưu thông tin bệnh nhân đang được chọn
        string patientID = "none";
        string patientName = "none";
        string patientAddress = "none";
        string patientPhoneNumber = "none";
        string patientDOB = "none";

        private void buttonEditPatient_Click(object sender, EventArgs e)
        {
            patientID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            patientName = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            patientAddress = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            patientPhoneNumber = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            patientDOB = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            PM_EditPatientForm editPatientForm = new PM_EditPatientForm();
            editPatientForm.Show();          
        }


        //Kiểm tra button nếu user đã click button xóa 
        private bool buttonDeletePatientWasClicked = false;
        private void buttonDeletePatient_Click(object sender, EventArgs e)
        {
            buttonDeletePatientWasClicked = true;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (buttonDeletePatientWasClicked == true)
            {
                //Lấy mã bệnh nhân
                string patientID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                //Xóa bệnh nhân
                PM_DeletePatientFunction deletePatientFunction = new PM_DeletePatientFunction();
                deletePatientFunction.DeletePatient(patientID);
                //Load lại dữ liệu
                Load_Data();
                //Đặt lại giá trị cho biến nút xóa
                buttonDeletePatientWasClicked = false;
            }                   
        }
    }
}
