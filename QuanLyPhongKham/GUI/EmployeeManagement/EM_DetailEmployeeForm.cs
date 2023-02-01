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
using QuanLyPhongKham.Function.EmployeeManagement;

namespace QuanLyPhongKham.GUI.EmployeeManagement
{
    public partial class EM_DetailEmployeeForm : Form
    {
        public EM_DetailEmployeeForm()
        {
            InitializeComponent();
        }

        public EM_DetailEmployeeForm(int EmployeeID)
        {
            InitializeComponent();
            this.employeeID = EmployeeID;
        }
        
        internal int employeeID;

        private void EM_DetailEmployeeForm_Load(object sender, EventArgs e)
        {
            if (EM_Functions.getMaxID("SELECT MAX(EMPLOYEE_ID) AS MAX FROM EMPLOYEE") + 1 == employeeID)
            {
                E_ID_textBox.Text = employeeID.ToString();
                editButton.PerformClick();
                editButton.Text = "Thêm";
            }
            else
            {
                DataTable employeeDT = EM_Functions.getSqlData("Select * from Employee where EMPLOYEE_ID = " + employeeID);
                DataTable permission = EM_Functions.getSqlData("Select * from Permission where EMPLOYEE_ID = " + employeeID);
                if (employeeDT != null)
                {
                    E_ID_textBox.Text = employeeDT.Rows[0]["EMPLOYEE_ID"].ToString();
                    E_Name_textBox.Text = employeeDT.Rows[0]["EMPLOYEE_NAME"].ToString();
                    E_Position_textBox.Text = employeeDT.Rows[0]["EMPLOYEE_POSITION"].ToString();
                    E_UserName_textBox.Text = employeeDT.Rows[0]["USERNAME"].ToString();
                    E_Password_textBox.Text = employeeDT.Rows[0]["PASSWORD"].ToString();
                    CreateMedicalRecord.Checked = Convert.ToBoolean(permission.Rows[0]["CREATE_MEDICALRECORD"]);
                    ViewEmployee.Checked = Convert.ToBoolean(permission.Rows[0]["VIEW_EMPLOYEE"]);
                    EditPatient.Checked = Convert.ToBoolean(permission.Rows[0]["EDIT_PATIENT"]);
                    EditEmployee.Checked = Convert.ToBoolean(permission.Rows[0]["EDIT_EMPLOYEE"]);
                    EditDrug.Checked = Convert.ToBoolean(permission.Rows[0]["EDIT_DRUG"]);
                    EditService.Checked = Convert.ToBoolean(permission.Rows[0]["EDIT_SERVICE"]);
                    RemoveMedicalRecord.Checked = Convert.ToBoolean(permission.Rows[0]["REMOVE_MEDICALRECORD"]);
                }
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (editButton.Text == "Chỉnh sửa")
            {
                E_Name_textBox.Enabled = true;
                E_Position_textBox.Enabled = true;
                E_UserName_textBox.Enabled = true;
                E_Password_textBox.Enabled = true;
                E_Name_textBox.ReadOnly = false;
                E_Position_textBox.ReadOnly = false;
                E_UserName_textBox.ReadOnly = false;
                E_Password_textBox.ReadOnly = false;
                CreateMedicalRecord.Enabled = true;
                ViewEmployee.Enabled = true;
                EditPatient.Enabled = true;
                EditEmployee.Enabled = true;
                EditDrug.Enabled = true;
                EditService.Enabled = true;
                RemoveMedicalRecord.Enabled = true;
                editButton.Text = "Lưu";
            }
            else
            {
                E_Name_textBox.ReadOnly = true;
                E_Position_textBox.ReadOnly = true;
                E_UserName_textBox.ReadOnly = true;
                E_Password_textBox.ReadOnly = true;
                CreateMedicalRecord.Enabled = false;
                ViewEmployee.Enabled = false;
                EditPatient.Enabled = false;
                EditEmployee.Enabled = false;
                EditDrug.Enabled = false;
                EditService.Enabled = false;
                RemoveMedicalRecord.Enabled = false;
                if (editButton.Text == "Lưu")
                {
                    string sql = "Update Employee set EMPLOYEE_NAME = N'" + E_Name_textBox.Text + "', EMPLOYEE_POSITION = N'" + E_Position_textBox.Text + "', USERNAME = '" + E_UserName_textBox.Text + "', PASSWORD = '" + E_Password_textBox.Text + "' where EMPLOYEE_ID = " + employeeID;
                    EM_Functions.sqlQueryExcute(sql);
                    sql = "Update Permission set CREATE_MEDICALRECORD = " + Convert.ToInt32(CreateMedicalRecord.Checked) + ", VIEW_EMPLOYEE = " + Convert.ToInt32(ViewEmployee.Checked) + ", EDIT_PATIENT = " + Convert.ToInt32(EditPatient.Checked) + ", EDIT_EMPLOYEE = " + Convert.ToInt32(EditEmployee.Checked) + ", EDIT_DRUG = " + Convert.ToInt32(EditDrug.Checked) + ", EDIT_SERVICE = " + Convert.ToInt32(EditService.Checked) + ", REMOVE_MEDICALRECORD = " + Convert.ToInt32(RemoveMedicalRecord.Checked) + " where EMPLOYEE_ID = " + employeeID;
                    EM_Functions.sqlQueryExcute(sql);
                } 
                else
                {
                    string sql = "INSERT INTO EMPLOYEE VALUES(" + E_ID_textBox.Text + ", N'" + E_Name_textBox.Text + "', N'" + E_Position_textBox.Text + "', '" + E_UserName_textBox.Text + "', '" + E_Password_textBox.Text + "')";
                    EM_Functions.sqlQueryExcute(sql);
                    sql = "INSERT INTO PERMISSION VALUES (" + E_ID_textBox.Text + ", " + Convert.ToInt32(CreateMedicalRecord.Checked) + ", " + Convert.ToInt32(EditPatient.Checked) + ", " + Convert.ToInt32(ViewEmployee.Checked) + ", " + Convert.ToInt32(EditEmployee.Checked) + ", " + Convert.ToInt32(EditDrug.Checked) + ", " + Convert.ToInt32(EditService.Checked) + ", " + Convert.ToInt32(RemoveMedicalRecord.Checked) + ")";
                    EM_Functions.sqlQueryExcute(sql);
                }
                editButton.Text = "Chỉnh sửa";
            }
        }
    }
}
