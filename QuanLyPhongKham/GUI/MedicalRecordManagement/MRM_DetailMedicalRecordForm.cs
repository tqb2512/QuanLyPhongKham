using QuanLyPhongKham.Classes;
using QuanLyPhongKham.Function.MedicalRecordManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongKham.GUI.MedicalRecordManagement
{
    public partial class MRM_DetailMedicalRecordForm : Form
    {
        MedicalRecord medicalRecord = new MedicalRecord();
        public MRM_DetailMedicalRecordForm()
        {
            InitializeComponent();
        }

        public MRM_DetailMedicalRecordForm(int medicalRecordID)
        {
            
            InitializeComponent();
            medicalRecord.ID = medicalRecordID;
            dataLoad();
            this.SizeChanged += new EventHandler(MRM_DetailMedicalRecordForm_SizeChanged);
        }

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

        public void dataLoad()
        {
            medicalRecord = MRM_Functions.getDetailMedicalRecord(medicalRecord.ID);
            MR_ID_textBox.Text = medicalRecord.ID.ToString();
            MR_Date_textBox.Text = medicalRecord.Date.ToString();
            P_ID_textBox.Text = medicalRecord.Patient.ID.ToString();
            P_Name_textBox.Text = medicalRecord.Patient.Name;
            E_ID_textBox.Text = medicalRecord.Employee.ID.ToString();
            E_Name_textBox.Text = medicalRecord.Employee.Name;
            MR_PateintTemp_textBox.Text = medicalRecord.Patient_Temp.ToString() + " °C";
            MR_PatientWeight_textBox.Text = medicalRecord.Patient_Weight.ToString() + " kg";
            MR_Diagnosis_textBox.Text = medicalRecord.Diagnosis;
            MR_Note_textBox.Text = medicalRecord.Note;
            D_List_GridView.DataSource = medicalRecord.Drugs;
            S_List_GridView.DataSource = medicalRecord.Services;
            D_List_GridView.Columns["ID"].HeaderText = "ID";
            D_List_GridView.Columns["Name"].HeaderText = "Tên thuốc";
            D_List_GridView.Columns["Quantity"].HeaderText = "SL";
            D_List_GridView.Columns["Unit"].HeaderText = "Đơn vị";
            D_List_GridView.Columns["Price"].HeaderText = "Giá";
            D_List_GridView.Columns["ID"].Width = (int)(D_List_GridView.Width * D_ID_Width) - 2;
            D_List_GridView.Columns["Name"].Width = (int)(D_List_GridView.Width * D_Name_Width);
            D_List_GridView.Columns["Quantity"].Width = (int)(D_List_GridView.Width * D_Quantity_Width);
            D_List_GridView.Columns["Unit"].Width = (int)(D_List_GridView.Width * D_Unit_Width);
            D_List_GridView.Columns["Price"].Width = (int)(D_List_GridView.Width * D_Price_Width);
            D_List_GridView.Columns["Manufacturer"].Visible = false;
            D_List_GridView.Columns["Description"].Visible = false;
            D_List_GridView.Columns["Price"].DefaultCellStyle.Format = "N0";
            S_List_GridView.Columns["ID"].HeaderText = "ID";
            S_List_GridView.Columns["Name"].HeaderText = "Tên dịch vụ";
            S_List_GridView.Columns["Quantity"].HeaderText = "SL";
            S_List_GridView.Columns["Unit"].HeaderText = "Đơn vị";
            S_List_GridView.Columns["Price"].HeaderText = "Giá";
            S_List_GridView.Columns["ID"].Width = (int)(S_List_GridView.Width * S_ID_Width) - 2;
            S_List_GridView.Columns["Name"].Width = (int)(S_List_GridView.Width * S_Name_Width);
            S_List_GridView.Columns["Quantity"].Width = (int)(S_List_GridView.Width * S_Quantity_Width);
            S_List_GridView.Columns["Unit"].Width = (int)(S_List_GridView.Width * S_Unit_Width);
            S_List_GridView.Columns["Price"].Width = (int)(S_List_GridView.Width * S_Price_Width);
            S_List_GridView.Columns["Price"].DefaultCellStyle.Format = "N0";
            S_List_GridView.Columns["Description"].Visible = false;
            S_List_GridView.Columns["Price"].DisplayIndex = 4;
        }
        private void MRM_DetailMedicalRecordForm_SizeChanged(object sender, EventArgs e)
        {
            D_List_GridView.Columns["ID"].Width = (int)(D_List_GridView.Width * D_ID_Width) - 2;
            D_List_GridView.Columns["Name"].Width = (int)(D_List_GridView.Width * D_Name_Width);
            D_List_GridView.Columns["Quantity"].Width = (int)(D_List_GridView.Width * D_Quantity_Width);
            D_List_GridView.Columns["Unit"].Width = (int)(D_List_GridView.Width * D_Unit_Width);
            D_List_GridView.Columns["Price"].Width = (int)(D_List_GridView.Width * D_Price_Width);
            S_List_GridView.Columns["ID"].Width = (int)(S_List_GridView.Width * S_ID_Width) - 2;
            S_List_GridView.Columns["Name"].Width = (int)(S_List_GridView.Width * S_Name_Width);
            S_List_GridView.Columns["Quantity"].Width = (int)(S_List_GridView.Width * S_Quantity_Width);
            S_List_GridView.Columns["Unit"].Width = (int)(S_List_GridView.Width * S_Unit_Width);
            S_List_GridView.Columns["Price"].Width = (int)(S_List_GridView.Width * S_Price_Width);
        }
    }
}
