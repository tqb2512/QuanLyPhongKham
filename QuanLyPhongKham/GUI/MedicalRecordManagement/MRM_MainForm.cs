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

        float idColumnWidth = 0.1f;
        float dateColumnWidth = 0.15f;
        float patientNameColumnWidth = 0.15f;
        float employeeColumnWidth = 0.15f;
        float diagnosisColumnWidth = 0.15f;
        float noteColumnWidth = 0.15f;
        float paymentStatusColumnWidth = 0.15f;
        
        public void dataLoad()
        {
            string query = "SELECT MEDICALRECORD_ID, DATE, PATIENT.PATIENT_NAME, EMPLOYEE.EMPLOYEE_NAME, DIAGNOSIS, NOTE, PAYMENT_STATUS FROM MEDICALRECORD INNER JOIN EXAMINE ON MEDICALRECORD.EXAMINE_ID = EXAMINE.EXAMINE_ID INNER JOIN PATIENT ON EXAMINE.PATIENT_ID = PATIENT.PATIENT_ID INNER JOIN EMPLOYEE ON EXAMINE.EMPLOYEE_ID = EMPLOYEE.EMPLOYEE_ID";
            DataTable table = MRM_Functions.getSqlData(query);
            table.Columns.Add("PAYMENT_STATUS_STRING", typeof(string));
            medicalRecordDataGrid.DataSource = table;
            medicalRecordDataGrid.Columns["PAYMENT_STATUS_STRING"].DisplayIndex = 6;
            medicalRecordDataGrid.Columns["PAYMENT_STATUS"].Visible = false;
            foreach (DataGridViewRow row in medicalRecordDataGrid.Rows)
            {
                if (row.Cells["PAYMENT_STATUS"].Value.ToString() == "0")
                {
                    row.Cells["PAYMENT_STATUS_STRING"].Value = "Chưa thanh toán";
                }
                else
                {
                    row.Cells["PAYMENT_STATUS_STRING"].Value = "Đã thanh toán";
                }
            }
            medicalRecordDataGrid.Columns["MEDICALRECORD_ID"].HeaderText = "ID bệnh án";
            medicalRecordDataGrid.Columns["DATE"].HeaderText = "Ngày khám";
            medicalRecordDataGrid.Columns["PATIENT_NAME"].HeaderText = "Tên bệnh nhân";
            medicalRecordDataGrid.Columns["EMPLOYEE_NAME"].HeaderText = "Tên bác sĩ";
            medicalRecordDataGrid.Columns["DIAGNOSIS"].HeaderText = "Chẩn đoán";
            medicalRecordDataGrid.Columns["NOTE"].HeaderText = "Ghi chú";
            medicalRecordDataGrid.Columns["PAYMENT_STATUS_STRING"].HeaderText = "Trạng thái";
            medicalRecordDataGrid.Columns["MEDICALRECORD_ID"].Width = (int)(medicalRecordDataGrid.Width * idColumnWidth);
            medicalRecordDataGrid.Columns["DATE"].Width = (int)(medicalRecordDataGrid.Width * dateColumnWidth);
            medicalRecordDataGrid.Columns["PATIENT_NAME"].Width = (int)(medicalRecordDataGrid.Width * patientNameColumnWidth);
            medicalRecordDataGrid.Columns["EMPLOYEE_NAME"].Width = (int)(medicalRecordDataGrid.Width * employeeColumnWidth);
            medicalRecordDataGrid.Columns["DIAGNOSIS"].Width = (int)(medicalRecordDataGrid.Width * diagnosisColumnWidth);
            medicalRecordDataGrid.Columns["NOTE"].Width = (int)(medicalRecordDataGrid.Width * noteColumnWidth);
            medicalRecordDataGrid.Columns["PAYMENT_STATUS_STRING"].Width = (int)(medicalRecordDataGrid.Width * paymentStatusColumnWidth);
        }

        private void MRM_MainForm_Load(object sender, EventArgs e)
        {
            dataLoad();
            this.SizeChanged += new EventHandler(MRM_MainForm_SizeChanged);
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

        private void MRM_MainForm_SizeChanged(object sender, EventArgs e)
        {
            medicalRecordDataGrid.Columns["MEDICALRECORD_ID"].Width = (int)(medicalRecordDataGrid.Width * idColumnWidth);
            medicalRecordDataGrid.Columns["DATE"].Width = (int)(medicalRecordDataGrid.Width * dateColumnWidth);
            medicalRecordDataGrid.Columns["PATIENT_NAME"].Width = (int)(medicalRecordDataGrid.Width * patientNameColumnWidth);
            medicalRecordDataGrid.Columns["EMPLOYEE_NAME"].Width = (int)(medicalRecordDataGrid.Width * employeeColumnWidth);
            medicalRecordDataGrid.Columns["DIAGNOSIS"].Width = (int)(medicalRecordDataGrid.Width * diagnosisColumnWidth);
            medicalRecordDataGrid.Columns["NOTE"].Width = (int)(medicalRecordDataGrid.Width * noteColumnWidth);
            medicalRecordDataGrid.Columns["PAYMENT_STATUS_STRING"].Width = (int)(medicalRecordDataGrid.Width * paymentStatusColumnWidth);
            search_TableLayout.ColumnStyles[0].Width = (int)(medicalRecordDataGrid.Width * idColumnWidth);
            search_TableLayout.ColumnStyles[1].Width = (int)(medicalRecordDataGrid.Width * dateColumnWidth);
            search_TableLayout.ColumnStyles[2].Width = (int)(medicalRecordDataGrid.Width * patientNameColumnWidth);
            search_TableLayout.ColumnStyles[3].Width = (int)(medicalRecordDataGrid.Width * employeeColumnWidth);
            search_TableLayout.ColumnStyles[4].Width = (int)(medicalRecordDataGrid.Width * diagnosisColumnWidth);
            search_TableLayout.ColumnStyles[5].Width = (int)(medicalRecordDataGrid.Width * noteColumnWidth);
            search_TableLayout.ColumnStyles[6].Width = (int)(medicalRecordDataGrid.Width * paymentStatusColumnWidth);
        }

        private void Search_textBox_TextChanged(object sender, EventArgs e)
        {
            string filter = "";
            foreach (Control control in search_TableLayout.Controls)
            {
                if (control is TextBox)
                {
                    if (control.Text != "")
                    {
                        switch (control.Name)
                        {
                            case "idSearch_textBox":
                                filter += "CONVERT(MEDICALRECORD_ID, System.String) LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "dateSearch_textBox":
                                filter += "CONVERT(DATE, System.String) LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "pNameSearch_textBox":
                                filter += "CONVERT(PATIENT_NAME, System.String) LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "eNameSearch_textBox":
                                filter += "CONVERT(EMPLOYEE_NAME, System.String) LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "diagnosisSearch_textBox":
                                filter += "CONVERT(DIAGNOSIS, System.String) LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "noteSearch_textBox":
                                filter += "CONVERT(NOTE, System.String) LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "paymentStatusSearch_textBox":
                                filter += "CONVERT(PAYMENT_STATUS, System.String) LIKE '%" + control.Text + "%' AND ";
                                break;
                        }
                    }
                }
            }
            if (filter != "")
            {
                filter = filter.Substring(0, filter.Length - 4);
                (medicalRecordDataGrid.DataSource as DataTable).DefaultView.RowFilter = filter;
            }
            else
            {
                (medicalRecordDataGrid.DataSource as DataTable).DefaultView.RowFilter = null;
            }
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            dataLoad();
        }
    }
}
