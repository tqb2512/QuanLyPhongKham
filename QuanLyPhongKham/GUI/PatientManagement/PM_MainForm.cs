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

namespace QuanLyPhongKham.GUI.PatientManagement
{
    public partial class PM_MainForm : Form
    {
        public PM_MainForm()
        {
            InitializeComponent();
        }
        float idColumnWidth = 0.1f;
        float nameColumnWidth = 0.2f;
        float genderColumnWidth = 0.1f;
        float addressColumnWidth = 0.25f;
        float phoneColumnWidth = 0.2f;
        float dobColumnWidth = 0.15f;

        public void dataLoad()
        {
            DataTable data = PM_Functions.getSqlData("SELECT * FROM PATIENT");
            patientDataGridView.DataSource = data;
            patientDataGridView.Columns["PATIENT_ID"].HeaderText = "ID";
            patientDataGridView.Columns["PATIENT_NAME"].HeaderText = "Tên bệnh nhân";
            patientDataGridView.Columns["PATIENT_SEX"].HeaderText = "Giới tính";
            patientDataGridView.Columns["PATIENT_ADDRESS"].HeaderText = "Địa chỉ";
            patientDataGridView.Columns["PATIENT_PHONENUMBER"].HeaderText = "Số điện thoại";
            patientDataGridView.Columns["PATIENT_DATEOFBIRTH"].HeaderText = "Ngày sinh";
            patientDataGridView.Columns["PATIENT_ID"].Width = (int)(patientDataGridView.Width * idColumnWidth);
            patientDataGridView.Columns["PATIENT_NAME"].Width = (int)(patientDataGridView.Width * nameColumnWidth);
            patientDataGridView.Columns["PATIENT_SEX"].Width = (int)(patientDataGridView.Width * genderColumnWidth);
            patientDataGridView.Columns["PATIENT_ADDRESS"].Width = (int)(patientDataGridView.Width * addressColumnWidth);
            patientDataGridView.Columns["PATIENT_PHONENUMBER"].Width = (int)(patientDataGridView.Width * phoneColumnWidth);
            patientDataGridView.Columns["PATIENT_DATEOFBIRTH"].Width = (int)(patientDataGridView.Width * dobColumnWidth);
            
        }

        private void PM_MainForm_Load(object sender, EventArgs e)
        {
            dataLoad();
            this.SizeChanged += new System.EventHandler(this.PM_MainForm_SizeChanged);
        }

        private void PM_MainForm_SizeChanged(object sender, EventArgs e)
        {
            //responsive
            patientDataGridView.Columns["PATIENT_ID"].Width = (int)(patientDataGridView.Width * idColumnWidth);
            patientDataGridView.Columns["PATIENT_NAME"].Width = (int)(patientDataGridView.Width * nameColumnWidth);
            patientDataGridView.Columns["PATIENT_SEX"].Width = (int)(patientDataGridView.Width * genderColumnWidth);
            patientDataGridView.Columns["PATIENT_ADDRESS"].Width = (int)(patientDataGridView.Width * addressColumnWidth);
            patientDataGridView.Columns["PATIENT_PHONENUMBER"].Width = (int)(patientDataGridView.Width * phoneColumnWidth);
            patientDataGridView.Columns["PATIENT_DATEOFBIRTH"].Width = (int)(patientDataGridView.Width * dobColumnWidth);
        }
    }
}
