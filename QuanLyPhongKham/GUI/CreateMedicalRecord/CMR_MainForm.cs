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

        public CMR_MainForm(int employeeID)
        {
            InitializeComponent();
            currentEmployeeID = employeeID;
        }

        int currentPatientID;
        int currentEmployeeID;
        int currentMedicalRecordID = CMR_Functions.getMaxMedicalRecordID() + 1;
        
        float D_ID_Width = 0.1f;
        float D_Name_Width = 0.3f;
        float D_Quantity_Width = 0.1f;
        float D_Unit_Width = 0.2f;
        float D_Price_Width = 0.3f;

        float S_ID_Width = 0.1f;
        float S_Name_Width = 0.3f;
        float S_Quantity_Width = 0.1f;
        float S_Unit_Width = 0.2f;
        float S_Price_Width = 0.3f;

        private void SelectPatient_Button_Click(object sender, EventArgs e)
        {
            using (CMR_SelectPatientForm selectPatientForm = new CMR_SelectPatientForm())
            {
                selectPatientForm.ShowDialog();
                patient = selectPatientForm.patient;
            }
            if (patient != null)
            {
                currentPatientID = patient.ID;
                P_Name_TextBox.Text = patient.Name;
                P_PhoneNumber_TextBox.Text = patient.PhoneNumber;
                P_Address_TextBox.Text = patient.Address;
                P_Sex_TextBox.Text = patient.Sex;
                P_DateOfBirth_DateTimePicker.Value = patient.DateOfBirth;
            }
        }

        private void AddPantient_Button_Click(object sender, EventArgs e)
        {
            currentPatientID = CMR_Functions.getMaxPatientID() + 1;
            P_Name_TextBox.Enabled = true;
            P_PhoneNumber_TextBox.Enabled = true;
            P_Address_TextBox.Enabled = true;
            P_Name_TextBox.ReadOnly = false;
            P_PhoneNumber_TextBox.ReadOnly = false;
            P_Address_TextBox.ReadOnly = false;
            P_DateOfBirth_DateTimePicker.Enabled = true;
            P_Sex_TextBox.Enabled = true;
            P_Sex_TextBox.ReadOnly = false;
        }

        private void confirm_Button_Click(object sender, EventArgs e)
        {

        }
    }
}
