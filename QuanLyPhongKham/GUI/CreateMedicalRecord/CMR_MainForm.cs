using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyPhongKham.Function.CreateMedicalRecord;
using QuanLyPhongKham.Classes;

namespace QuanLyPhongKham.GUI.CreateMedicalRecord
{
    public partial class CMR_MainForm : Form
    {
        Patient patient;
        List<Drug> drugs;
        List<Service> services;
        public CMR_MainForm()
        {
            InitializeComponent();
        }

        private void SelectPatient_Button_Click(object sender, EventArgs e)
        {
            using (CMR_SelectPatientForm selectPatientForm = new CMR_SelectPatientForm())
            {
                selectPatientForm.ShowDialog();
                patient = selectPatientForm.patient;
            }
            if (patient != null)
            {
                P_Name_TextBox.Text = patient.Name;
                P_PhoneNumber_TextBox.Text = patient.PhoneNumber;
                P_Address_TextBox.Text = patient.Address;
                P_DateOfBirth_DateTimePicker.Value = patient.DateOfBirth;
            }
        }

        private void AddPantient_Button_Click(object sender, EventArgs e)
        {
            P_Name_TextBox.Enabled = true;
            P_PhoneNumber_TextBox.Enabled = true;
            P_Address_TextBox.Enabled = true;
            P_Name_TextBox.ReadOnly = false;
            P_PhoneNumber_TextBox.ReadOnly = false;
            P_Address_TextBox.ReadOnly = false;
            P_DateOfBirth_DateTimePicker.Enabled = true;
        }
    }
}
