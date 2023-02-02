using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyPhongKham.Classes;
using QuanLyPhongKham.Function.PatientManagement;

namespace QuanLyPhongKham.GUI.PatientManagement
{
    public partial class PM_DetailPatientForm : Form
    {
        public int patient_ID;

        public string formState = "view";

        public PM_DetailPatientForm()
        {
            InitializeComponent();
        }

        public PM_DetailPatientForm(int patientID, string state)
        {
            InitializeComponent();
            formState = state;
            this.patient_ID = patientID;
        }
        private void PM_DetailPatientForm_Load(object sender, EventArgs e)
        {
            P_ID_textBox.Text = patient_ID.ToString();
            if (formState != "add")
            {
                Patient patient = new Patient();
                patient = PM_Functions.getDetailPatient(patient_ID);
                P_name_textBox.Text = patient.Name;
                P_sex_ComboBox.Text = patient.Sex;
                P_address_textBox.Text = patient.Address;
                P_phonenumber_textBox.Text = patient.PhoneNumber;
                P_dateofbirth_dateTimePicker.Text = patient.DateOfBirth.ToString("MM/dd/yyyy");
            }      
            else
            {
                P_name_textBox.ReadOnly = false;
                //P_sex_textBox.ReadOnly = false;
                P_address_textBox.ReadOnly = false;
                P_phonenumber_textBox.ReadOnly = false;
                //P_dateofbirth_textBox.ReadOnly = false;
                P_name_textBox.Enabled = true;
                //P_sex_textBox.Enabled = true;
                P_address_textBox.Enabled = true;
                P_phonenumber_textBox.Enabled = true;
                P_dateofbirth_dateTimePicker.Enabled = true;
                edit_button.Text = "Thêm";
            }      
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (PM_Functions.deletePatient(patient_ID))
            {
                MessageBox.Show("Xóa thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {

        }

        private void edit_button_Click(object sender, EventArgs e)
        {

        }
    }
}
