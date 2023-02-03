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
using static Microsoft.WindowsAPICodePack.Shell.PropertySystem.SystemProperties.System;
using System.Text.RegularExpressions;

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
        int currentMedicalRecordID = CMR_Functions.getMaxID("SELECT MAX(MEDICALRECORD_ID) AS MAX FROM MEDICALRECORD") + 1;

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

        private void fillPatientInfoTextBox(Patient patient = null)
        {
            if (patient != null)
            {
                P_Name_TextBox.Text = patient.Name;
                P_PhoneNumber_TextBox.Text = patient.PhoneNumber;
                P_Address_TextBox.Text = patient.Address;
                P_Sex_ComboBox.SelectedIndex = P_Sex_ComboBox.FindStringExact(patient.Sex);
                P_DateOfBirth_DateTimePicker.Value = patient.DateOfBirth;
            }
            else
            {
                P_Name_TextBox.Text = "";
                P_PhoneNumber_TextBox.Text = "";
                P_Address_TextBox.Text = "";
                P_Sex_ComboBox.SelectedIndex = 0;
            }
        }

        private void patientInfoLock(bool state)
        {
            if (state == true)
            {
                P_Name_TextBox.Enabled = false;
                P_PhoneNumber_TextBox.Enabled = false;
                P_Address_TextBox.Enabled = false;
                P_Name_TextBox.ReadOnly = true;
                P_PhoneNumber_TextBox.ReadOnly = true;
                P_Address_TextBox.ReadOnly = true;
                P_DateOfBirth_DateTimePicker.Enabled = false;
                P_Sex_ComboBox.Enabled = false;
            }
            else
            {
                P_Name_TextBox.Enabled = true;
                P_PhoneNumber_TextBox.Enabled = true;
                P_Address_TextBox.Enabled = true;
                P_Name_TextBox.ReadOnly = false;
                P_PhoneNumber_TextBox.ReadOnly = false;
                P_Address_TextBox.ReadOnly = false;
                P_DateOfBirth_DateTimePicker.Enabled = true;
                P_Sex_ComboBox.Enabled = true;
            }
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
                currentPatientID = patient.ID;
                fillPatientInfoTextBox(patient);
                patientInfoLock(true);
            }
        }

        private void AddPantient_Button_Click(object sender, EventArgs e)
        {
            currentPatientID = CMR_Functions.getMaxID("SELECT MAX(PATIENT_ID) AS MAX FROM PATIENT") + 1;
            fillPatientInfoTextBox();
            patientInfoLock(false);
        }

        private void confirm_Button_Click(object sender, EventArgs e)
        {
            if (CMR_Functions.checkPermission(currentEmployeeID, "CREATE_MEDICALRECORD") == false)
            {
                MessageBox.Show("Bạn không có quyền tạo bệnh án", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MedicalRecord medicalRecord = new MedicalRecord();

            if (P_Name_TextBox.Text == "")
            {
                MessageBox.Show("Vui lòng thông tin bệnh nhân", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            medicalRecord.ID = currentMedicalRecordID;
            medicalRecord.Patient = new Patient();
            medicalRecord.Patient.ID = currentPatientID;
            medicalRecord.Patient.Name = P_Name_TextBox.Text;
            medicalRecord.Patient.PhoneNumber = P_PhoneNumber_TextBox.Text;
            medicalRecord.Patient.Address = P_Address_TextBox.Text;
            medicalRecord.Patient.DateOfBirth = P_DateOfBirth_DateTimePicker.Value.Date;
            medicalRecord.Patient.Sex = P_Sex_ComboBox.Text;
            if (MR_pWeight_TextBox.Text != "")
                medicalRecord.Patient_Weight = float.Parse(MR_pWeight_TextBox.Text);
            if (MR_pTemp_TextBox.Text != "")
                medicalRecord.Patient_Temp = float.Parse(MR_pTemp_TextBox.Text);
            medicalRecord.Employee = new Employee();
            medicalRecord.Employee.ID = currentEmployeeID;
            medicalRecord.Date = DateTime.Now;
            medicalRecord.Drugs = Drugs;
            medicalRecord.Services = Services;
            medicalRecord.Note = MR_note_richTextBox.Text;
            medicalRecord.Diagnosis = MR_diagnosis_richTextBox.Text;

            if (CMR_Functions.createMedicalRecord(medicalRecord) == true)
            {
                MessageBox.Show("Tạo bệnh án thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                patientInfoLock(true);
                fillPatientInfoTextBox();
                MR_diagnosis_richTextBox.Text = "";
                MR_note_richTextBox.Text = "";
                MR_pTemp_TextBox.Text = "";
                MR_pWeight_TextBox.Text = "";
                Drugs = new List<Drug>();
                Services = new List<Service>();
                Drugs_DataGridView.DataSource = null;
                Services_DataGridView.DataSource = null;
                currentMedicalRecordID = CMR_Functions.getMaxID("SELECT MAX(MEDICALRECORD_ID) AS MAX FROM MEDICALRECORD") + 1;
            }
            else
            {
                MessageBox.Show("Tạo bệnh án thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                Drugs_DataGridView.Columns["Price"].DisplayIndex = 3;
                Drugs_DataGridView.Columns["Manufacturer"].Visible = false;
                Drugs_DataGridView.Columns["Description"].Visible = false;
                this.SizeChanged += new System.EventHandler(this.CMR_MainForm_SizeChanged);
                total_textBox.Text = "0";
                foreach (DataGridViewRow row in Services_DataGridView.Rows)
                {
                    total_textBox.Text = (decimal.Parse(total_textBox.Text) + decimal.Parse(row.Cells["Price"].Value.ToString()) * decimal.Parse(row.Cells["Quantity"].Value.ToString())).ToString();
                }
                foreach (DataGridViewRow row in Drugs_DataGridView.Rows)
                {
                    total_textBox.Text = (decimal.Parse(total_textBox.Text) + decimal.Parse(row.Cells["Price"].Value.ToString()) * decimal.Parse(row.Cells["Quantity"].Value.ToString())).ToString();
                }
                total_textBox.Text = string.Format("{0:#,##}", decimal.Parse(total_textBox.Text));
            }
        }

        private void S_AddServiceToList_Button_Click(object sender, EventArgs e)
        {
            using (CMR_SelectServicesForm selectServicesForm = new CMR_SelectServicesForm(services))
            {
                selectServicesForm.ShowDialog();
                services = selectServicesForm.services;
            }
            if (services != null)
            {
                Services = services;
                Services_DataGridView.DataSource = Services;
                Services_DataGridView.Columns["ID"].Width = (int)(Services_DataGridView.Width * S_ID_Width);
                Services_DataGridView.Columns["Name"].Width = (int)(Services_DataGridView.Width * S_Name_Width);
                Services_DataGridView.Columns["Price"].Width = (int)(Services_DataGridView.Width * S_Price_Width);
                Services_DataGridView.Columns["Unit"].Width = (int)(Services_DataGridView.Width * S_Unit_Width);
                Services_DataGridView.Columns["Quantity"].Width = (int)(Services_DataGridView.Width * S_Quantity_Width);
                Services_DataGridView.Columns["Price"].DefaultCellStyle.Format = "N0";
                Services_DataGridView.Columns["ID"].HeaderText = "ID";
                Services_DataGridView.Columns["Name"].HeaderText = "Tên dịch vụ";
                Services_DataGridView.Columns["Price"].HeaderText = "Đơn giá";
                Services_DataGridView.Columns["Unit"].HeaderText = "Đơn vị";
                Services_DataGridView.Columns["Quantity"].HeaderText = "SL";
                Services_DataGridView.Columns["Price"].DisplayIndex = 3;
                Services_DataGridView.Columns["Description"].Visible = false;
                this.SizeChanged += new System.EventHandler(this.CMR_MainForm_SizeChanged);
                total_textBox.Text = "0";
                foreach (DataGridViewRow row in Services_DataGridView.Rows)
                {
                    total_textBox.Text = (decimal.Parse(total_textBox.Text) + decimal.Parse(row.Cells["Price"].Value.ToString()) * decimal.Parse(row.Cells["Quantity"].Value.ToString())).ToString();
                }
                foreach (DataGridViewRow row in Drugs_DataGridView.Rows)
                {
                    total_textBox.Text = (decimal.Parse(total_textBox.Text) + decimal.Parse(row.Cells["Price"].Value.ToString()) * decimal.Parse(row.Cells["Quantity"].Value.ToString())).ToString();
                }
                total_textBox.Text = string.Format("{0:#,##}", decimal.Parse(total_textBox.Text));
            }
        }

        private void P_PhoneNumber_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(Char.IsNumber((char)e.KeyCode) || e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Enter || P_PhoneNumber_TextBox.TextLength >= 11))
            {
                e.SuppressKeyPress = true;
            }
        }

        private void CMR_MainForm_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void MR_pTemp_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(Char.IsNumber((char)e.KeyCode) || e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Enter))
            {
                e.SuppressKeyPress = true;
            }
        }
        
        private void MR_pWeight_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(Char.IsNumber((char)e.KeyCode) || e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Enter))
            {
                e.SuppressKeyPress = true;
            }
        }

        private void P_Sex_ComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void CMR_MainForm_SizeChanged(object sender, EventArgs e)
        {
            if (drugs != null)
            {
                Drugs_DataGridView.Columns["ID"].Width = (int)(Drugs_DataGridView.Width * D_ID_Width);
                Drugs_DataGridView.Columns["Name"].Width = (int)(Drugs_DataGridView.Width * D_Name_Width);
                Drugs_DataGridView.Columns["Price"].Width = (int)(Drugs_DataGridView.Width * D_Price_Width);
                Drugs_DataGridView.Columns["Unit"].Width = (int)(Drugs_DataGridView.Width * D_Unit_Width);
                Drugs_DataGridView.Columns["Quantity"].Width = (int)(Drugs_DataGridView.Width * D_Quantity_Width);
            }
            if (services != null)
            {
                Services_DataGridView.Columns["ID"].Width = (int)(Services_DataGridView.Width * S_ID_Width);
                Services_DataGridView.Columns["Name"].Width = (int)(Services_DataGridView.Width * S_Name_Width);
                Services_DataGridView.Columns["Price"].Width = (int)(Services_DataGridView.Width * S_Price_Width);
                Services_DataGridView.Columns["Unit"].Width = (int)(Services_DataGridView.Width * S_Unit_Width);
                Services_DataGridView.Columns["Quantity"].Width = (int)(Services_DataGridView.Width * S_Quantity_Width);
            }
        }

        private void CMR_MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}


