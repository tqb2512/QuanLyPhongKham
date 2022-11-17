using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyPhongKham.Function.PatientManagement;
using QuanLyPhongKham.Classes;
using System.Data.SqlClient;

namespace QuanLyPhongKham.GUI.PatientManagement
{
    public partial class PM_ImportPatientForm : Form
    {
        public PM_ImportPatientForm()
        {
            InitializeComponent();
        }

        private void ImportPatientForm_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonConfirmImportPatient_Click(object sender, EventArgs e)
        {
            TextBox[] textBox = { textBoxPatientID, textBoxPatientName, textBoxPatientAddress, textBoxPatientPhone };
            for (int i = 0; i < textBox.Length; i++)
            {
                if (textBox[i].Text == "")
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ thông tin!");
                    return;
                }
            }

            //Check if patient has the same ID
            SqlConnection conn = new SqlConnection(@"Data Source=WIN-30FJQ771AK3;Initial Catalog=QUANLYPHONGKHAM;Integrated Security=True");
            string sql = "SELECT * FROM PATIENT WHERE PATIENT_ID = '" + textBoxPatientID.Text + "'";
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, conn);
            DataSet dataSet = new DataSet();
            conn.Open();
            dataadapter.Fill(dataSet, "PATIENT");
            conn.Close();
            if (dataSet.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("Mã bệnh nhân đã tồn tại!");
            }
            else
            {
                int patientID = Convert.ToInt32(textBoxPatientID.Text);
                string patientName = textBoxPatientName.Text;
                string patientPhone = textBoxPatientPhone.Text;
                string patientAddress = textBoxPatientAddress.Text;
                string patientDOB = dateTimePickerPatientDOB.Value.ToString("yyyy-MM-dd");
                PM_ImportPatientFunction importPatient_Function = new PM_ImportPatientFunction();
                importPatient_Function.ImportPatient(patientID, patientName, patientPhone, patientAddress, patientDOB);
                MessageBox.Show("Thêm bệnh nhân thành công!");
            }

            //UPdate data grid view
        }
    }
}
