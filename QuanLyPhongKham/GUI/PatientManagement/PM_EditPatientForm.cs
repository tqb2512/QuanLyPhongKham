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
using QuanLyPhongKham.GUI.PatientManagement;
using System.Data.SqlClient;

namespace QuanLyPhongKham.GUI.PatientManagement
{
    public partial class PM_EditPatientForm : Form
    {
        public PM_EditPatientForm()
        {
            InitializeComponent();
        }
        private void buttonUpdatePatient_Click(object sender, EventArgs e)
        {
            TextBox[] textBox = { textBoxPatientName, textBoxPatientAddress, textBoxPatientPhone };
            for (int i = 0; i < 5; i++)
            {
                if (textBox[i].Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    return;
                }
            }
            string patientID = labelPatientID.Text;
            string patientName = textBoxPatientName.Text;
            string patientAddress = textBoxPatientAddress.Text;
            string patientPhone = textBoxPatientPhone.Text;
            string patientDOB = dateTimePickerPatientDOB.Value.ToString("yyyy-MM-dd");

            PM_EditPatientFunction editPatient = new PM_EditPatientFunction();
            editPatient.EditPatient(patientID, patientName, patientAddress, patientPhone, patientDOB);
            MessageBox.Show("Bạn muốn thay đổi thông tin bệnh nhân ?");
            MessageBox.Show("Cập nhật thông tin bệnh nhân thành công!");
        }
        public void LoadDataToEditForm(string id, string name, string address, string phone, string DOB)
        {
            labelPatientID.Text = id;
            textBoxPatientName.Text = name;
            textBoxPatientAddress.Text = address;
            textBoxPatientPhone.Text = phone;
            dateTimePickerPatientDOB.Text = DOB;
        }
        private void PM_EditPatientForm_Load(object sender, EventArgs e)
        {
            PM_ShowPatientListForm showPatientListForm = new PM_ShowPatientListForm();
            showPatientListForm.Load_Data();
        }

        private void labelPatientID_Click(object sender, EventArgs e)
        {

        }
    }
}
