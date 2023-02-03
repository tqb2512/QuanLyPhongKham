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
using QuanLyPhongKham.Function.PatientManagement;

namespace QuanLyPhongKham.GUI.PatientManagement
{
    public partial class PM_MainForm : Form
    {
        public PM_MainForm()
        {
            InitializeComponent();
        }

        Patient currentPatient = new Patient();
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

        private void PM_FinalForm_Load(object sender, EventArgs e)
        {
            dataLoad();
            this.SizeChanged += new System.EventHandler(this.PM_MainForm_SizeChanged);
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

        private void patientDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                edit_button.Text = "Sửa";
                currentPatient = PM_Functions.getDetailPatient(Convert.ToInt32(patientDataGridView.Rows[e.RowIndex].Cells["PATIENT_ID"].Value.ToString()));
                P_ID_textBox.Text = currentPatient.ID.ToString();
                P_name_textBox.Text = currentPatient.Name;
                P_sex_ComboBox.Text = currentPatient.Sex;
                P_address_textBox.Text = currentPatient.Address;
                P_phonenumber_textBox.Text = currentPatient.PhoneNumber;
                P_dateofbirth_dateTimePicker.Value = currentPatient.DateOfBirth;

                P_name_textBox.ReadOnly = true;
                
                P_address_textBox.ReadOnly = true;
                P_phonenumber_textBox.ReadOnly = true;
                
                P_name_textBox.Enabled = false;
                P_sex_ComboBox.Enabled = false;
                P_address_textBox.Enabled = false;
                P_phonenumber_textBox.Enabled = false;
                P_dateofbirth_dateTimePicker.Enabled = false;
            }
        }


        private void refresh_button_Click(object sender, EventArgs e)
        {
            dataLoad();
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            if (PM_Functions.checkPermission(Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["currentUserId"].ToString()), "EDIT_SERVICE") == true)
            {
                if (P_ID_textBox.Text != "")
                    currentPatient.ID = Convert.ToInt32(P_ID_textBox.Text);
                currentPatient.Name = P_name_textBox.Text;
                if (P_sex_ComboBox.Text != "")
                    currentPatient.Sex = P_sex_ComboBox.Text;
                currentPatient.Address = P_address_textBox.Text;
                currentPatient.PhoneNumber = P_phonenumber_textBox.Text;
                currentPatient.DateOfBirth = P_dateofbirth_dateTimePicker.Value;
                if (edit_button.Text == "Thêm")
                {
                    if (PM_Functions.addPatient(currentPatient))
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        edit_button.Text = "Sửa";
                        P_name_textBox.ReadOnly = false;
                        P_address_textBox.ReadOnly = false;
                        P_phonenumber_textBox.ReadOnly = false;

                        P_name_textBox.Enabled = true;
                        P_sex_ComboBox.Enabled = true;
                        P_address_textBox.Enabled = true;
                        P_phonenumber_textBox.Enabled = true;
                        P_dateofbirth_dateTimePicker.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (edit_button.Text == "Lưu")
                {
                    if (PM_Functions.updatePatient(currentPatient))
                    {
                        MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        edit_button.Text = "Sửa";
                        P_name_textBox.ReadOnly = true;
                        P_address_textBox.ReadOnly = true;
                        P_phonenumber_textBox.ReadOnly = true;

                        P_name_textBox.Enabled = false;
                        P_sex_ComboBox.Enabled = false;
                        P_address_textBox.Enabled = false;
                        P_phonenumber_textBox.Enabled = false;
                        P_dateofbirth_dateTimePicker.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (P_ID_textBox.Text != "")
                {
                    edit_button.Text = "Lưu";
                    P_name_textBox.ReadOnly = false;
                    P_address_textBox.ReadOnly = false;
                    P_phonenumber_textBox.ReadOnly = false;

                    P_name_textBox.Enabled = true;
                    P_sex_ComboBox.Enabled = true;
                    P_address_textBox.Enabled = true;
                    P_phonenumber_textBox.Enabled = true;
                    P_dateofbirth_dateTimePicker.Enabled = true;
                }
                dataLoad();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền thực hiện chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (PM_Functions.checkPermission(Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["currentUserId"].ToString()), "EDIT_SERVICE") == true)
            {
                if (P_ID_textBox.Text != "" || P_ID_textBox.Text != Convert.ToString(PM_Functions.getMaxID()))
                {
                    if (PM_Functions.deletePatient(Convert.ToInt32(P_ID_textBox.Text)) == true)
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        P_ID_textBox.Text = "";
                        P_name_textBox.Text = "";
                        P_sex_ComboBox.Text = "";
                        P_address_textBox.Text = "";
                        P_phonenumber_textBox.Text = "";
                        P_dateofbirth_dateTimePicker.Value = DateTime.Now;
                        dataLoad();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn không có quyền thực hiện chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (PM_Functions.checkPermission(Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["currentUserId"].ToString()), "EDIT_SERVICE") == true)
            {
                P_ID_textBox.Text = Convert.ToString(PM_Functions.getMaxID() + 1);
                P_name_textBox.Text = "";
                P_sex_ComboBox.Text = "";
                P_address_textBox.Text = "";
                P_phonenumber_textBox.Text = "";
                P_dateofbirth_dateTimePicker.Value = DateTime.Now;

                P_name_textBox.ReadOnly = false;
                P_address_textBox.ReadOnly = false;
                P_phonenumber_textBox.ReadOnly = false;

                P_name_textBox.Enabled = true;
                P_sex_ComboBox.Enabled = true;
                P_address_textBox.Enabled = true;
                P_phonenumber_textBox.Enabled = true;
                P_dateofbirth_dateTimePicker.Enabled = true;
                edit_button.Text = "Thêm";
            }
            else
            {
                MessageBox.Show("Bạn không có quyền thực hiện chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void P_sex_ComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
