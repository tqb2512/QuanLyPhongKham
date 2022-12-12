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
            //Kiểm tra nếu textbox trống và ID nhập đã tồn tại trong CSDL
            TextBox[] textBox = { textBoxPatientID, textBoxPatientName, textBoxPatientAddress, textBoxPatientPhone };
            for (int i = 0; i < textBox.Length; i++)
            {
                if (textBox[i].Text == "")
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ thông tin!");
                    return;
                }
            }

            //Them thong tin
            string patientID = textBoxPatientID.Text;
            string patientName = textBoxPatientName.Text;
            string patientAddress = textBoxPatientAddress.Text;
            string patientPhone = textBoxPatientPhone.Text;
            string patientBirthday = dateTimePickerPatientDOB.Value.ToString("yyyy-MM-dd");

            PM_Functions importPatient = new PM_Functions();
            importPatient.ImportPatient(patientID, patientName, patientAddress, patientPhone, patientBirthday);
            MessageBox.Show("Thêm bệnh nhân thành công!");

            textBoxPatientID.Text = "";
            textBoxPatientName.Text = "";
            textBoxPatientAddress.Text = "";
            textBoxPatientPhone.Text = "";
            dateTimePickerPatientDOB.Value = DateTime.Now;
        }
    }
}
