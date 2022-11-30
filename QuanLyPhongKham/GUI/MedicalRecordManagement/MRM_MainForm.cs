using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyPhongKham.Function.MedicalRecordManagement;

namespace QuanLyPhongKham.GUI.MedicalRecordManagement
{
    public partial class MRM_MainForm : Form
    {
        public MRM_MainForm()
        {
            InitializeComponent();
        }

        private void dataLoad()
        {
            string connectionString = "Data Source=DESKTOP-UFNGE5T;Initial Catalog=QUANLYPHONGKHAM;Integrated Security=True";
            string query = "SELECT MEDICALRECORD_ID, DATE, PATIENT.PATIENT_NAME, EMPLOYEE.EMPLOYEE_NAME, DIAGNOSIS, NOTE FROM MEDICALRECORD INNER JOIN EXAMINE ON MEDICALRECORD.EXAMINE_ID = EXAMINE.EXAMINE_ID INNER JOIN PATIENT ON EXAMINE.PATIENT_ID = PATIENT.PATIENT_ID INNER JOIN EMPLOYEE ON EXAMINE.EMPLOYEE_ID = EMPLOYEE.EMPLOYEE_ID";
            DataTable table = MRM_Functions.getSqlData(connectionString, query);
            medicalRecordDataGrid.DataSource = table;
            medicalRecordDataGrid.Columns[0].HeaderText = "ID bệnh án";
            medicalRecordDataGrid.Columns[1].HeaderText = "Ngày khám";
            medicalRecordDataGrid.Columns[2].HeaderText = "Tên bệnh nhân";
            medicalRecordDataGrid.Columns[3].HeaderText = "Tên bác sĩ";
            medicalRecordDataGrid.Columns[4].HeaderText = "Chẩn đoán";
            medicalRecordDataGrid.Columns[5].HeaderText = "Ghi chú";
            medicalRecordDataGrid.Columns[0].Width = 147;
            medicalRecordDataGrid.Columns[1].Width = 150;
            medicalRecordDataGrid.Columns[2].Width = 300;
            medicalRecordDataGrid.Columns[3].Width = 300;
            medicalRecordDataGrid.Columns[4].Width = 300;
            medicalRecordDataGrid.Columns[5].Width = 300;
            medicalRecordDataGrid.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            medicalRecordDataGrid.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            medicalRecordDataGrid.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            medicalRecordDataGrid.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            medicalRecordDataGrid.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            medicalRecordDataGrid.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void MRM_MainForm_Load(object sender, EventArgs e)
        {
            dataLoad();
        }

        private void medicalRecordDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.medicalRecordDataGrid.Rows[e.RowIndex];
                int medicalRecordID = Convert.ToInt32(row.Cells[0].Value.ToString());
                MRM_DetailMedicalRecordForm detailMedicalRecordForm = new MRM_DetailMedicalRecordForm(medicalRecordID);
                detailMedicalRecordForm.Show();
            }
        }
    }
}
