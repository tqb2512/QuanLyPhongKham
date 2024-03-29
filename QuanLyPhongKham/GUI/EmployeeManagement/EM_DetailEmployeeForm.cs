﻿using System;
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
using System.Security.Cryptography;

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
            if (EM_Functions.checkPermission(Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["currentUserId"].ToString()), "EDIT_PATIENT") == false)
            {
                deleteButton.Enabled = false;
                editButton.Enabled = false;
            }
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
                    E_Password_textBox.Text = "";
                    CreateMedicalRecord.Checked = Convert.ToBoolean(permission.Rows[0]["CREATE_MEDICALRECORD"]);
                    EditPatient.Checked = Convert.ToBoolean(permission.Rows[0]["EDIT_PATIENT"]);
                    EditEmployee.Checked = Convert.ToBoolean(permission.Rows[0]["EDIT_EMPLOYEE"]);
                    EditDrug.Checked = Convert.ToBoolean(permission.Rows[0]["EDIT_DRUG"]);
                    EditService.Checked = Convert.ToBoolean(permission.Rows[0]["EDIT_SERVICE"]);
                    RemoveMedicalRecord.Checked = Convert.ToBoolean(permission.Rows[0]["REMOVE_MEDICALRECORD"]);
                    MakePayment.Checked = Convert.ToBoolean(permission.Rows[0]["MAKEPAYMENT_MEDICALRECORD"]);
                }
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (editButton.Text == "Sửa")
            {
                if (EM_Functions.checkPermission(Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["currentUserId"].ToString()), "EDIT_PATIENT") == true)
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
                    EditPatient.Enabled = true;
                    EditEmployee.Enabled = true;
                    EditDrug.Enabled = true;
                    EditService.Enabled = true;
                    RemoveMedicalRecord.Enabled = true;
                    MakePayment.Enabled = true;
                }
                editButton.Text = "Lưu";
            }
            else
            {
                if (String.IsNullOrEmpty(E_ID_textBox.Text) || String.IsNullOrEmpty(E_Name_textBox.Text) || String.IsNullOrEmpty(E_Position_textBox.Text) || String.IsNullOrEmpty(E_UserName_textBox.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (E_UserName_textBox.Text.Length < 6)
                {
                    MessageBox.Show("Tên đăng nhập phải có ít nhất 6 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (E_Password_textBox.Text.Length > 1 && E_Password_textBox.Text.Length < 6)
                {
                    MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                
                if (EM_Functions.getSqlData("Select * from Employee where USERNAME = '" + E_UserName_textBox.Text + "' and EMPLOYEE_ID <> " + E_ID_textBox.Text).Rows.Count > 0)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                
                E_Name_textBox.ReadOnly = true;
                E_Position_textBox.ReadOnly = true;
                E_UserName_textBox.ReadOnly = true;
                E_Password_textBox.ReadOnly = true;
                CreateMedicalRecord.Enabled = false;
                EditPatient.Enabled = false;
                EditEmployee.Enabled = false;
                EditDrug.Enabled = false;
                EditService.Enabled = false;
                RemoveMedicalRecord.Enabled = false;
                MakePayment.Enabled = false;
                if (editButton.Text == "Lưu")
                {
                    byte[] temp = ASCIIEncoding.ASCII.GetBytes(E_Password_textBox.Text);
                    byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
                    string hasPass = "";
                    foreach (byte item in hasData)
                    {
                        hasPass += item;
                    }
                    string sql;
                    if (String.IsNullOrEmpty(E_Password_textBox.Text) == false)
                        sql = "Update Employee set EMPLOYEE_NAME = N'" + E_Name_textBox.Text + "', EMPLOYEE_POSITION = N'" + E_Position_textBox.Text + "', USERNAME = '" + E_UserName_textBox.Text + "', PASSWORD = '" + hasPass + "' where EMPLOYEE_ID = " + employeeID;
                    else
                        sql = "Update Employee set EMPLOYEE_NAME = N'" + E_Name_textBox.Text + "', EMPLOYEE_POSITION = N'" + E_Position_textBox.Text + "', USERNAME = '" + E_UserName_textBox.Text + "' where EMPLOYEE_ID = " + employeeID;
                    EM_Functions.sqlQueryExcute(sql);
                    sql = "Update Permission set CREATE_MEDICALRECORD = " + Convert.ToInt32(CreateMedicalRecord.Checked) 
                        + ", EDIT_PATIENT = " + Convert.ToInt32(EditPatient.Checked) 
                        + ", EDIT_EMPLOYEE = " + Convert.ToInt32(EditEmployee.Checked) 
                        + ", EDIT_DRUG = " + Convert.ToInt32(EditDrug.Checked) 
                        + ", EDIT_SERVICE = " + Convert.ToInt32(EditService.Checked) 
                        + ", REMOVE_MEDICALRECORD = " + Convert.ToInt32(RemoveMedicalRecord.Checked)
                        + ", MAKEPAYMENT_MEDICALRECORD = " + Convert.ToInt32(MakePayment.Checked)
                        + " where EMPLOYEE_ID = " + employeeID;
                    EM_Functions.sqlQueryExcute(sql);
                } 
                else
                {
                    if (E_Password_textBox.Text.Length < 6)
                    {
                        MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    byte[] temp = ASCIIEncoding.ASCII.GetBytes(E_Password_textBox.Text);
                    byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
                    string hasPass = "";
                    foreach (byte item in hasData)
                    {
                        hasPass += item;
                    }
                    string sql = "INSERT INTO EMPLOYEE VALUES (" + E_ID_textBox.Text + ", N'" + E_Name_textBox.Text + "', N'" + E_Position_textBox.Text + "', '" + E_UserName_textBox.Text + "', '" + hasPass + "')";
                    EM_Functions.sqlQueryExcute(sql);
                    sql = "INSERT INTO PERMISSION (EMPLOYEE_ID, CREATE_MEDICALRECORD, REMOVE_MEDICALRECORD, MAKEPAYMENT_MEDICALRECORD, EDIT_EMPLOYEE, EDIT_PATIENT, EDIT_DRUG, EDIT_SERVICE) VALUES ("
                        + E_ID_textBox.Text + ", " + Convert.ToInt32(CreateMedicalRecord.Checked)
                        + ", " + Convert.ToInt32(RemoveMedicalRecord.Checked)
                        + ", " + Convert.ToInt32(MakePayment.Checked)
                        + ", " + Convert.ToInt32(EditEmployee.Checked)
                        + ", " + Convert.ToInt32(EditPatient.Checked)
                        + ", " + Convert.ToInt32(EditDrug.Checked)
                        + ", " + Convert.ToInt32(EditService.Checked) + ")";
                    EM_Functions.sqlQueryExcute(sql);
                }
                editButton.Text = "Sửa";
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (EM_Functions.checkPermission(Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["currentUserId"].ToString()), "EDIT_PATIENT") == true)
            {
                string sql = "DELETE FROM EMPLOYEE WHERE EMPLOYEE_ID = " + E_ID_textBox.Text;
                if (EM_Functions.sqlQueryExcute(sql) > 0)
                {
                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa nhân viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bạn không có quyền để xóa nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
