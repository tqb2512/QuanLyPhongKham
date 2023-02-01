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
using QuanLyPhongKham.Classes;

namespace QuanLyPhongKham.GUI.PatientManagement
{
    public partial class PM_PanelForm : Form
    {
        public PM_PanelForm()
        {
            InitializeComponent();
        }

        PM_MainForm pm_MainForm = new PM_MainForm();
        PM_DetailPatientForm pm_DetailPatientForm;

        private void PM_PanelForm_Load(object sender, EventArgs e)
        {
            pm_MainForm.TopLevel = false;
            pm_MainForm.AutoScroll = true;
            // pm_MainForm.FormBorderStyle = FormBorderStyle.None;
            mainPanel.Panel1.Controls.Add(pm_MainForm);
            pm_MainForm.Dock = DockStyle.Fill;
            pm_MainForm.Visible = true;
            pm_MainForm.Show();
            pm_MainForm.patientDataGridView.CellDoubleClick += new DataGridViewCellEventHandler(patientDataGridView_CellDoubleClick);
            pm_MainForm.add_button.Click += new EventHandler(add_button_Click);
        }

        private void patientDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                mainPanel.Panel2.Controls.Clear();
                int patientID = Convert.ToInt32(pm_MainForm.patientDataGridView.Rows[e.RowIndex].Cells[0].Value);
                pm_DetailPatientForm = new PM_DetailPatientForm(patientID, "view");
                pm_DetailPatientForm.TopLevel = false;
                pm_DetailPatientForm.AutoScroll = true;
                pm_DetailPatientForm.FormBorderStyle = FormBorderStyle.None;
                mainPanel.Panel2.Controls.Add(pm_DetailPatientForm);
                pm_DetailPatientForm.Dock = DockStyle.Fill;
                pm_DetailPatientForm.Visible = true;
                pm_DetailPatientForm.Show();
                pm_DetailPatientForm.edit_button.Click += new EventHandler(edit_button_Click);
                pm_DetailPatientForm.delete_button.Click += new EventHandler(delete_button_Click);
            }
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            string formState = pm_DetailPatientForm.formState;
            switch (formState)
            {
                case "view":
                    pm_DetailPatientForm.formState = "edit";
                    pm_DetailPatientForm.edit_button.Text = "Lưu";
                    pm_DetailPatientForm.P_name_textBox.ReadOnly = false;
                    pm_DetailPatientForm.P_sex_textBox.ReadOnly = false;
                    pm_DetailPatientForm.P_address_textBox.ReadOnly = false;
                    pm_DetailPatientForm.P_phonenumber_textBox.ReadOnly = false;
                    pm_DetailPatientForm.P_dateofbirth_textBox.ReadOnly = false;
                    pm_DetailPatientForm.P_name_textBox.Enabled = true;
                    pm_DetailPatientForm.P_sex_textBox.Enabled = true;
                    pm_DetailPatientForm.P_address_textBox.Enabled = true;
                    pm_DetailPatientForm.P_phonenumber_textBox.Enabled = true;
                    pm_DetailPatientForm.P_dateofbirth_textBox.Enabled = true;
                    break;
                case "edit":
                    patient.ID = pm_DetailPatientForm.patient_ID;
                    patient.Name = pm_DetailPatientForm.P_name_textBox.Text;
                    patient.Sex = pm_DetailPatientForm.P_sex_textBox.Text;
                    patient.Address = pm_DetailPatientForm.P_address_textBox.Text;
                    patient.PhoneNumber = pm_DetailPatientForm.P_phonenumber_textBox.Text;
                    patient.DateOfBirth = Convert.ToDateTime(pm_DetailPatientForm.P_dateofbirth_textBox.Text);
                    if (PM_Functions.updatePatient(patient))
                    {
                        MessageBox.Show("Cập nhật thành công");
                        pm_DetailPatientForm.formState = "view";
                        pm_DetailPatientForm.edit_button.Text = "Sửa";
                        pm_DetailPatientForm.P_name_textBox.ReadOnly = true;
                        pm_DetailPatientForm.P_sex_textBox.ReadOnly = true;
                        pm_DetailPatientForm.P_address_textBox.ReadOnly = true;
                        pm_DetailPatientForm.P_phonenumber_textBox.ReadOnly = true;
                        pm_DetailPatientForm.P_dateofbirth_textBox.ReadOnly = true;
                        pm_DetailPatientForm.P_name_textBox.Enabled = false;
                        pm_DetailPatientForm.P_sex_textBox.Enabled = false;
                        pm_DetailPatientForm.P_address_textBox.Enabled = false;
                        pm_DetailPatientForm.P_phonenumber_textBox.Enabled = false;
                        pm_DetailPatientForm.P_dateofbirth_textBox.Enabled = false;                    
                    }
                    else 
                    {
                        MessageBox.Show("Cập nhật thất bại");
                    }
                    break;
                case "add":
                    patient.ID = pm_DetailPatientForm.patient_ID;
                    patient.Name = pm_DetailPatientForm.P_name_textBox.Text;
                    patient.Sex = pm_DetailPatientForm.P_sex_textBox.Text;
                    patient.Address = pm_DetailPatientForm.P_address_textBox.Text;
                    patient.PhoneNumber = pm_DetailPatientForm.P_phonenumber_textBox.Text;
                    patient.DateOfBirth = Convert.ToDateTime(pm_DetailPatientForm.P_dateofbirth_textBox.Text);
                    if (PM_Functions.addPatient(patient))
                    {
                        MessageBox.Show("Thêm thành công");
                        pm_DetailPatientForm.formState = "view";
                        pm_DetailPatientForm.edit_button.Text = "Sửa";
                        pm_DetailPatientForm.P_name_textBox.ReadOnly = true;
                        pm_DetailPatientForm.P_sex_textBox.ReadOnly = true;
                        pm_DetailPatientForm.P_address_textBox.ReadOnly = true;
                        pm_DetailPatientForm.P_phonenumber_textBox.ReadOnly = true;
                        pm_DetailPatientForm.P_dateofbirth_textBox.ReadOnly = true;
                        pm_DetailPatientForm.P_name_textBox.Enabled = false;
                        pm_DetailPatientForm.P_sex_textBox.Enabled = false;
                        pm_DetailPatientForm.P_address_textBox.Enabled = false;
                        pm_DetailPatientForm.P_phonenumber_textBox.Enabled = false;
                        pm_DetailPatientForm.P_dateofbirth_textBox.Enabled = false;     
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }
                    break;
            }
            pm_MainForm.dataLoad();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            mainPanel.Panel2.Controls.Clear();
            int currentMaxID = PM_Functions.getMaxID();
            pm_DetailPatientForm = new PM_DetailPatientForm(currentMaxID + 1, "add");
            pm_DetailPatientForm.TopLevel = false;
            pm_DetailPatientForm.AutoScroll = true;
            pm_DetailPatientForm.FormBorderStyle = FormBorderStyle.None;
            pm_DetailPatientForm.Dock = DockStyle.Fill;
            mainPanel.Panel2.Controls.Add(pm_DetailPatientForm);
            pm_DetailPatientForm.Visible = true;
            pm_DetailPatientForm.Show();
            pm_DetailPatientForm.edit_button.Click += new EventHandler(edit_button_Click);
            pm_DetailPatientForm.delete_button.Click += new EventHandler(delete_button_Click);
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (pm_DetailPatientForm.formState != "add")
            {
                if (PM_Functions.deletePatient(pm_DetailPatientForm.patient_ID))
                {
                    MessageBox.Show("Xóa thành công");
                    pm_DetailPatientForm.Close();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
                pm_MainForm.dataLoad();
            }
        }

        private void mainPanel_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }

    

}
