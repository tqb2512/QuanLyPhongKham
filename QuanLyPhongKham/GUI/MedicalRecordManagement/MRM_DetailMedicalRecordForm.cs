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
        }

        public void dataLoad()
        {
            medicalRecord = MRM_Functions.getDetailMedicalRecord(medicalRecord.ID);
            MR_ID_textBox.Text = medicalRecord.ID.ToString();
            MR_Date_textBox.Text = medicalRecord.Date.ToString();
            P_ID_textBox.Text = medicalRecord.Patient.ID.ToString();
            P_Name_textBox.Text = medicalRecord.Patient.Name;
            E_ID_textBox.Text = medicalRecord.Employee.ID.ToString();
            E_Name_textBox.Text = medicalRecord.Employee.Name;
            MR_Diagnosis_textBox.Text = medicalRecord.Diagnosis;
            MR_Note_textBox.Text = medicalRecord.Note;
            D_List_GridView.DataSource = medicalRecord.Drugs;
            S_List_GridView.DataSource = medicalRecord.Services;
            D_List_GridView.Columns[0].HeaderText = "ID thuốc";
            D_List_GridView.Columns[1].HeaderText = "Tên thuốc";
            D_List_GridView.Columns[2].HeaderText = "Đơn vị";
            D_List_GridView.Columns[3].HeaderText = "Số lượng";
            D_List_GridView.Columns[4].Visible = false;
            D_List_GridView.Columns[5].Visible = false;
            D_List_GridView.Columns[6].HeaderText = "Đơn giá";
            D_List_GridView.Columns[6].DefaultCellStyle.Format = "N0";
            D_List_GridView.Columns[0].Width = 100;
            D_List_GridView.Columns[1].Width = 282;
            D_List_GridView.Columns[2].Width = 100;
            D_List_GridView.Columns[3].Width = 100;
            D_List_GridView.Columns[6].Width = 150;
            S_List_GridView.Columns[0].HeaderText = "ID dịch vụ";
            S_List_GridView.Columns[1].HeaderText = "Tên dịch vụ";
            S_List_GridView.Columns[2].HeaderText = "Đơn giá";
            S_List_GridView.Columns[3].HeaderText = "Đơn vị";
            S_List_GridView.Columns[4].HeaderText = "Số lượng";
            S_List_GridView.Columns[2].DefaultCellStyle.Format = "N0";
            S_List_GridView.Columns[0].Width = 120;
            S_List_GridView.Columns[1].Width = 262;
            S_List_GridView.Columns[2].Width = 150;
            S_List_GridView.Columns[3].Width = 100;
            S_List_GridView.Columns[4].Width = 100;
            

        }
    }
}
