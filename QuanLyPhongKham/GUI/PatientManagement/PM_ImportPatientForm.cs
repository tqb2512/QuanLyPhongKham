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
            int patientID = Convert.ToInt32(textBoxPatientID.Text);
            string patientName = textBoxPatientName.Text;
            string patientPhone = textBoxPatientPhone.Text;
            string patientAddress = textBoxPatientAddress.Text;
            string patientDOB = dateTimePickerPatientDOB.Value.ToString("yyyy-MM-dd");
            ImportPatient_Function importPatient_Function = new ImportPatient_Function();
            importPatient_Function.ImportPatient(patientID, patientName, patientPhone, patientAddress, patientDOB);
            MessageBox.Show("Thêm bệnh nhân thành công!");
        }
    }
}
