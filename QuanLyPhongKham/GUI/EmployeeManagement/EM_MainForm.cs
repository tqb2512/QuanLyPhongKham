using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyPhongKham.Function;

namespace QuanLyPhongKham.GUI.EmployeeManagement
{
    public partial class EM_MainForm : Form
    {
        public EM_MainForm()
        {
            InitializeComponent();
        }

        float idColumnWidth = 0.1f;
        float nameColumnWidth = 0.4f;
        float positionColumnWidth = 0.3f;
        float userNameColumnWidth = 0.2f;

        private void EM_MainForm_Load(object sender, EventArgs e)
        {
            dataLoad();
            this.SizeChanged += new System.EventHandler(this.EM_MainForm_SizeChanged);
        }
        public void dataLoad()
        {
            
            if (EM_Functions.checkPermission(Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["currentUserId"].ToString()), "EDIT_PATIENT") == true)
            {
                Employee_DataGridView.DataSource = EM_Functions.getSqlData("SELECT * FROM EMPLOYEE");
            }
            else
            {
                Employee_DataGridView.DataSource = EM_Functions.getSqlData("SELECT * FROM EMPLOYEE WHERE EMPLOYEE_ID = " + System.Configuration.ConfigurationManager.AppSettings["currentUserId"].ToString());
            }
            Employee_DataGridView.Columns["EMPLOYEE_ID"].HeaderText = "ID";
            Employee_DataGridView.Columns["EMPLOYEE_NAME"].HeaderText = "Tên nhân viên";
            Employee_DataGridView.Columns["EMPLOYEE_POSITION"].HeaderText = "Chức vụ";
            Employee_DataGridView.Columns["USERNAME"].HeaderText = "Tên đăng nhập";
            Employee_DataGridView.Columns["PASSWORD"].Visible = false;
            Employee_DataGridView.Columns["EMPLOYEE_ID"].Width = (int)(Employee_DataGridView.Width * idColumnWidth);
            Employee_DataGridView.Columns["EMPLOYEE_NAME"].Width = (int)(Employee_DataGridView.Width * nameColumnWidth);
            Employee_DataGridView.Columns["EMPLOYEE_POSITION"].Width = (int)(Employee_DataGridView.Width * positionColumnWidth);
            Employee_DataGridView.Columns["USERNAME"].Width = (int)(Employee_DataGridView.Width * userNameColumnWidth);
            Search_TableLayout.ColumnStyles[0].Width = (int)(Search_TableLayout.Width * idColumnWidth);
            Search_TableLayout.ColumnStyles[1].Width = (int)(Search_TableLayout.Width * nameColumnWidth);
            Search_TableLayout.ColumnStyles[2].Width = (int)(Search_TableLayout.Width * positionColumnWidth);
            Search_TableLayout.ColumnStyles[3].Width = (int)(Search_TableLayout.Width * userNameColumnWidth);
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            dataLoad();
        }

        private void EM_MainForm_SizeChanged(object sender, EventArgs e)
        {
            Employee_DataGridView.Columns["EMPLOYEE_ID"].Width = (int)(Employee_DataGridView.Width * idColumnWidth);
            Employee_DataGridView.Columns["EMPLOYEE_NAME"].Width = (int)(Employee_DataGridView.Width * nameColumnWidth);
            Employee_DataGridView.Columns["EMPLOYEE_POSITION"].Width = (int)(Employee_DataGridView.Width * positionColumnWidth);
            Employee_DataGridView.Columns["USERNAME"].Width = (int)(Employee_DataGridView.Width * userNameColumnWidth);
            Search_TableLayout.ColumnStyles[0].Width = (int)(Search_TableLayout.Width * idColumnWidth);
            Search_TableLayout.ColumnStyles[1].Width = (int)(Search_TableLayout.Width * nameColumnWidth);
            Search_TableLayout.ColumnStyles[2].Width = (int)(Search_TableLayout.Width * positionColumnWidth);
            Search_TableLayout.ColumnStyles[3].Width = (int)(Search_TableLayout.Width * userNameColumnWidth);
        }

        private void Search_textBox_TextChanged(object sender, EventArgs e)
        {
            string filter = "";
            foreach (Control control in Search_TableLayout.Controls)
            {
                if (control is TextBox)
                {
                    if (control.Text != "")
                    {
                        switch (control.Name)
                        {
                            case "idSearch_textBox":
                                filter += "CONVERT(EMPLOYEE_ID, System.String) LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "nameSearch_textBox":
                                filter += "CONVERT(EMPLOYEE_NAME, System.String) LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "positionSearch_textBox":
                                filter += "CONVERT(EMPLOYEE_POSITION, System.String) LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "userNameSearch_textBox":
                                filter += "CONVERT(USERNAME, System.String) LIKE '%" + control.Text + "%' AND ";
                                break;
                        }
                    }
                }
            }
            if (filter != "")
            {
                filter = filter.Substring(0, filter.Length - 4);
                (Employee_DataGridView.DataSource as DataTable).DefaultView.RowFilter = filter;
            }
            else
            {
                (Employee_DataGridView.DataSource as DataTable).DefaultView.RowFilter = null;
            }
        }
    }
}
