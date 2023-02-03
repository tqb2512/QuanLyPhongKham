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
using QuanLyPhongKham.Function;

namespace QuanLyPhongKham.GUI.CreateMedicalRecord
{
    public partial class CMR_SelectPatientForm : Form
    {
        internal Patient patient;

        public CMR_SelectPatientForm()
        {
            InitializeComponent();
        }

        float idColumnWidth = 0.1f;
        float nameColumnWidth = 0.2f;
        float sexColumnWidth = 0.1f;
        float addressColumnWidth = 0.25f;
        float phoneNumberColumnWidth = 0.15f;
        float dateOfBirthColumnWidth = 0.2f;

        private void CMR_SelectPatientForm_Load(object sender, EventArgs e)
        {
            Patient_DataGridView.DataSource = CMR_Functions.getSqlData("SELECT * FROM PATIENT");
            Patient_DataGridView.Columns["PATIENT_ID"].HeaderText = "ID bệnh nhân";
            Patient_DataGridView.Columns["PATIENT_NAME"].HeaderText = "Tên bệnh nhân";
            Patient_DataGridView.Columns["PATIENT_SEX"].HeaderText = "Giới tính";
            Patient_DataGridView.Columns["PATIENT_ADDRESS"].HeaderText = "Địa chỉ";
            Patient_DataGridView.Columns["PATIENT_PHONENUMBER"].HeaderText = "Số điện thoại";
            Patient_DataGridView.Columns["PATIENT_DATEOFBIRTH"].HeaderText = "Ngày sinh";
            Patient_DataGridView.Columns["PATIENT_ID"].Width = (int)(Patient_DataGridView.Width * idColumnWidth);
            Patient_DataGridView.Columns["PATIENT_NAME"].Width = (int)(Patient_DataGridView.Width * nameColumnWidth);
            Patient_DataGridView.Columns["PATIENT_SEX"].Width = (int)(Patient_DataGridView.Width * sexColumnWidth);
            Patient_DataGridView.Columns["PATIENT_ADDRESS"].Width = (int)(Patient_DataGridView.Width * addressColumnWidth);
            Patient_DataGridView.Columns["PATIENT_PHONENUMBER"].Width = (int)(Patient_DataGridView.Width * phoneNumberColumnWidth);
            Patient_DataGridView.Columns["PATIENT_DATEOFBIRTH"].Width = (int)(Patient_DataGridView.Width * dateOfBirthColumnWidth);
            search_tableLayout.ColumnStyles[0].Width = (int)(search_tableLayout.Width * idColumnWidth);
            search_tableLayout.ColumnStyles[1].Width = (int)(search_tableLayout.Width * nameColumnWidth);
            search_tableLayout.ColumnStyles[2].Width = (int)(search_tableLayout.Width * sexColumnWidth);
            search_tableLayout.ColumnStyles[3].Width = (int)(search_tableLayout.Width * addressColumnWidth);
            search_tableLayout.ColumnStyles[4].Width = (int)(search_tableLayout.Width * phoneNumberColumnWidth);
            search_tableLayout.ColumnStyles[5].Width = (int)(search_tableLayout.Width * dateOfBirthColumnWidth);
            this.SizeChanged += new EventHandler(CMR_SelectPatientForm_SizeChanged);

        }
        

        private void Confirm_Button_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            patient.ID = Convert.ToInt32(Patient_DataGridView.CurrentRow.Cells["PATIENT_ID"].Value);
            patient.Name = Patient_DataGridView.CurrentRow.Cells["PATIENT_NAME"].Value.ToString();
            patient.Address = Patient_DataGridView.CurrentRow.Cells["PATIENT_ADDRESS"].Value.ToString();
            patient.Sex = Patient_DataGridView.CurrentRow.Cells["PATIENT_SEX"].Value.ToString();
            patient.PhoneNumber = Patient_DataGridView.CurrentRow.Cells["PATIENT_PHONENUMBER"].Value.ToString();
            patient.DateOfBirth = Convert.ToDateTime(Patient_DataGridView.CurrentRow.Cells["PATIENT_DATEOFBIRTH"].Value);
            this.patient = patient;
            this.Close();
        }

        private void Search_textBox_TextChanged(object sender, EventArgs e)
        {
            string filter = "";
            foreach (Control control in search_tableLayout.Controls)
            {
                if (control is TextBox)
                {
                    if (control.Text != "")
                    {
                        switch (control.Name)
                        {
                            case "idSearch_textBox":
                                filter += "CONVERT(PANTIENT_ID, System.String) LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "nameSearch_textBox":
                                filter += "CONVERT(PATIENT_NAME, System.String) LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "sexSearch_textBox":
                                filter += "CONVERT(PATIENT_SEX, System.String) LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "addressSearch_textBox":
                                filter += "CONVERT(PATIENT_ADDRESS, System.String) LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "phoneNumberSearch_textBox":
                                filter += "CONVERT(PATIENT_PHONENUMBER, System.String) LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "dateOfBirthSearch_textBox":
                                filter += "CONVERT(PATIENT_DATEOFBIRTH, System.String) LIKE '%" + control.Text + "%' AND ";
                                break;
                        }
                    }
                }
            }
            if (filter != "")
            {
                filter = filter.Substring(0, filter.Length - 4);
                (Patient_DataGridView.DataSource as DataTable).DefaultView.RowFilter = filter;
            }
            else
            {
                (Patient_DataGridView.DataSource as DataTable).DefaultView.RowFilter = null;
            }
        }

        private void CMR_SelectPatientForm_SizeChanged(object sender, EventArgs e)
        {
            Patient_DataGridView.Columns["PATIENT_ID"].Width = (int)(Patient_DataGridView.Width * idColumnWidth);
            Patient_DataGridView.Columns["PATIENT_NAME"].Width = (int)(Patient_DataGridView.Width * nameColumnWidth);
            Patient_DataGridView.Columns["PATIENT_SEX"].Width = (int)(Patient_DataGridView.Width * sexColumnWidth);
            Patient_DataGridView.Columns["PATIENT_ADDRESS"].Width = (int)(Patient_DataGridView.Width * addressColumnWidth);
            Patient_DataGridView.Columns["PATIENT_PHONENUMBER"].Width = (int)(Patient_DataGridView.Width * phoneNumberColumnWidth);
            Patient_DataGridView.Columns["PATIENT_DATEOFBIRTH"].Width = (int)(Patient_DataGridView.Width * dateOfBirthColumnWidth);
            search_tableLayout.ColumnStyles[0].Width = (int)(search_tableLayout.Width * idColumnWidth);
            search_tableLayout.ColumnStyles[1].Width = (int)(search_tableLayout.Width * nameColumnWidth);
            search_tableLayout.ColumnStyles[2].Width = (int)(search_tableLayout.Width * sexColumnWidth);
            search_tableLayout.ColumnStyles[3].Width = (int)(search_tableLayout.Width * addressColumnWidth);
            search_tableLayout.ColumnStyles[4].Width = (int)(search_tableLayout.Width * phoneNumberColumnWidth);
            search_tableLayout.ColumnStyles[5].Width = (int)(search_tableLayout.Width * dateOfBirthColumnWidth);
        }
    }
}
