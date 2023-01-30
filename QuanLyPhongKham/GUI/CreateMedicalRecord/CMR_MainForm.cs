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
        List<Drug> Drugs;
        List<Service> Services;
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

        private void D_AddDrugToList_Button_Click(object sender, EventArgs e)
        {
            using (CMR_SelectDrugsForm selectDrugsForm = new CMR_SelectDrugsForm(drugs))
            {
                selectDrugsForm.ShowDialog();
                drugs = selectDrugsForm.drugs;
            }
            if (drugs != null)
            {
                Drugs = drugs;
                Drugs_DataGridView.DataSource = Drugs;
                Drugs_DataGridView.Columns["ID"].Width = (int)(Drugs_DataGridView.Width * D_ID_Width);
                Drugs_DataGridView.Columns["Name"].Width = (int)(Drugs_DataGridView.Width * D_Name_Width);
                Drugs_DataGridView.Columns["Price"].Width = (int)(Drugs_DataGridView.Width * D_Price_Width);
                Drugs_DataGridView.Columns["Unit"].Width = (int)(Drugs_DataGridView.Width * D_Unit_Width);
                Drugs_DataGridView.Columns["Quantity"].Width = (int)(Drugs_DataGridView.Width * D_Quantity_Width);
                Drugs_DataGridView.Columns["Price"].DefaultCellStyle.Format = "N0";
                Drugs_DataGridView.Columns["ID"].HeaderText = "ID";
                Drugs_DataGridView.Columns["Name"].HeaderText = "Tên thuốc";
                Drugs_DataGridView.Columns["Price"].HeaderText = "Đơn giá";
                Drugs_DataGridView.Columns["Unit"].HeaderText = "Đơn vị";
                Drugs_DataGridView.Columns["Quantity"].HeaderText = "SL";
                Drugs_DataGridView.Columns["Manufacturer"].Visible = false;
                Drugs_DataGridView.Columns["Description"].Visible = false;
                this.SizeChanged += new System.EventHandler(this.CMR_MainForm_SizeChanged);
            }
        }

        private void CMR_MainForm_SizeChanged(object sender, EventArgs e)
        {
            Drugs_DataGridView.Columns["ID"].Width = (int)(Drugs_DataGridView.Width * D_ID_Width);
            Drugs_DataGridView.Columns["Name"].Width = (int)(Drugs_DataGridView.Width * D_Name_Width);
            Drugs_DataGridView.Columns["Price"].Width = (int)(Drugs_DataGridView.Width * D_Price_Width);
            Drugs_DataGridView.Columns["Unit"].Width = (int)(Drugs_DataGridView.Width * D_Unit_Width);
            Drugs_DataGridView.Columns["Quantity"].Width = (int)(Drugs_DataGridView.Width * D_Quantity_Width);
        }
    }
}
