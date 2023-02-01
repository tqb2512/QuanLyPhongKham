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
            search_TableLayout.ColumnStyles[0].Width = (int)(search_TableLayout.Width * idColumnWidth);
            search_TableLayout.ColumnStyles[1].Width = (int)(search_TableLayout.Width * nameColumnWidth);
            search_TableLayout.ColumnStyles[2].Width = (int)(search_TableLayout.Width * genderColumnWidth);
            search_TableLayout.ColumnStyles[3].Width = (int)(search_TableLayout.Width * addressColumnWidth);
            search_TableLayout.ColumnStyles[4].Width = (int)(search_TableLayout.Width * phoneColumnWidth);
            search_TableLayout.ColumnStyles[5].Width = (int)(search_TableLayout.Width * dobColumnWidth);

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
            search_TableLayout.ColumnStyles[0].Width = (int)(search_TableLayout.Width * idColumnWidth);
            search_TableLayout.ColumnStyles[1].Width = (int)(search_TableLayout.Width * nameColumnWidth);
            search_TableLayout.ColumnStyles[2].Width = (int)(search_TableLayout.Width * genderColumnWidth);
            search_TableLayout.ColumnStyles[3].Width = (int)(search_TableLayout.Width * addressColumnWidth);
            search_TableLayout.ColumnStyles[4].Width = (int)(search_TableLayout.Width * phoneColumnWidth);
            search_TableLayout.ColumnStyles[5].Width = (int)(search_TableLayout.Width * dobColumnWidth);
        }

        private void patientDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void patientDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Search(object sender, EventArgs e)
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
                                filter += "CONVERT(PATIENT_ID, System.String) LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "nameSearch_textBox":
                                filter += "CONVERT(PATIENT_NAME, System.String) LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "genderSearch_textBox":
                                filter += "CONVERT(PATIENT_SEX, System.String) LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "addressSearch_textBox":
                                filter += "CONVERT(PATIENT_ADDRESS, System.String) LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "phonenumberSearch_textBox":
                                filter += "CONVERT(PATIENT_PHONENUMBER, System.String) LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "dateofbirthSearch_textBox":
                                filter += "CONVERT(PATIENT_DATEOFBIRTH, System.String) LIKE '%" + control.Text + "%' AND ";
                                break;
                        }
                    }
                }
            }
            if (filter != "")
            {
                filter = filter.Substring(0, filter.Length - 4);
                (patientDataGridView.DataSource as DataTable).DefaultView.RowFilter = filter;
            }
            else
            {
                (patientDataGridView.DataSource as DataTable).DefaultView.RowFilter = null;
            }
        }
    }
}
