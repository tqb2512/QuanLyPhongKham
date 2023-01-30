using QuanLyPhongKham.Classes;
using QuanLyPhongKham.Function.ServiceManagement;
using QuanLyPhongKham.GUI.MedicalRecordManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyPhongKham.Function.ServiceManagement;

namespace QuanLyPhongKham.GUI.ServiceManagement
{
    public partial class SM_PanelForm : Form
    {
        public SM_PanelForm()
        {
            InitializeComponent();
        }

        SM_MainForm sm_MainForm = new SM_MainForm();
        SM_DetailServiceForm sm_DetailServiceForm;

        private void SM_PanelForm_Load(object sender, EventArgs e)
        {
            sm_MainForm.TopLevel = false;
            sm_MainForm.AutoScroll = true;
            sm_MainForm.FormBorderStyle = FormBorderStyle.None;
            mainPanel.Panel1.Controls.Add(sm_MainForm);
            sm_MainForm.Dock = DockStyle.Fill;
            sm_MainForm.Visible = true;
            sm_MainForm.Show();
            sm_MainForm.servicesDataGridView.CellDoubleClick += new DataGridViewCellEventHandler(servicesDataGridView_CellDoubleClick);
            sm_MainForm.add_button.Click += new EventHandler(add_button_Click);
        }

        private void servicesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                mainPanel.Panel2.Controls.Clear();
                int serviceID = Convert.ToInt32(sm_MainForm.servicesDataGridView.Rows[e.RowIndex].Cells[0].Value);
                sm_DetailServiceForm = new SM_DetailServiceForm(serviceID, "view");
                sm_DetailServiceForm.TopLevel = false;
                sm_DetailServiceForm.AutoScroll = true;
                sm_DetailServiceForm.FormBorderStyle = FormBorderStyle.None;
                mainPanel.Panel2.Controls.Add(sm_DetailServiceForm);
                sm_DetailServiceForm.Dock = DockStyle.Fill;
                sm_DetailServiceForm.Visible = true;
                sm_DetailServiceForm.Show();
                sm_DetailServiceForm.edit_button.Click += new EventHandler(edit_button_Click);
                sm_DetailServiceForm.delete_button.Click += new EventHandler(delete_button_Click);
            }
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            Service service = new Service();
            string formState = sm_DetailServiceForm.formState;
            switch (formState)
            {
                case "view":
                    sm_DetailServiceForm.formState = "edit";
                    sm_DetailServiceForm.edit_button.Text = "Lưu";
                    sm_DetailServiceForm.S_name_textBox.ReadOnly = false;
                    sm_DetailServiceForm.S_price_textBox.ReadOnly = false;
                    sm_DetailServiceForm.S_unit_textBox.ReadOnly = false;
                    sm_DetailServiceForm.S_description_richTextBox.ReadOnly = false;
                    sm_DetailServiceForm.S_name_textBox.Enabled = true;
                    sm_DetailServiceForm.S_price_textBox.Enabled = true;
                    sm_DetailServiceForm.S_description_richTextBox.Enabled = true;
                    sm_DetailServiceForm.S_unit_textBox.Enabled = true;
                    break;
                case "edit":
                    service.ID = sm_DetailServiceForm.serviceID;
                    service.Name = sm_DetailServiceForm.S_name_textBox.Text;
                    service.Price = Convert.ToInt32(sm_DetailServiceForm.S_price_textBox.Text);
                    service.Unit = sm_DetailServiceForm.S_unit_textBox.Text;
                    service.Description = sm_DetailServiceForm.S_description_richTextBox.Text;
                    if (SM_Functions.updateService(service))
                    {
                        MessageBox.Show("Cập nhật thành công");
                        sm_DetailServiceForm.formState = "view";
                        sm_DetailServiceForm.edit_button.Text = "Sửa";
                        sm_DetailServiceForm.S_name_textBox.ReadOnly = true;
                        sm_DetailServiceForm.S_price_textBox.ReadOnly = true;
                        sm_DetailServiceForm.S_unit_textBox.ReadOnly = true;
                        sm_DetailServiceForm.S_description_richTextBox.ReadOnly = true;
                        sm_DetailServiceForm.S_name_textBox.Enabled = false;
                        sm_DetailServiceForm.S_price_textBox.Enabled = false;
                        sm_DetailServiceForm.S_description_richTextBox.Enabled = false;
                        sm_DetailServiceForm.S_unit_textBox.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại");
                    }
                    break;
                case "add":
                    service.ID = sm_DetailServiceForm.serviceID;
                    service.Name = sm_DetailServiceForm.S_name_textBox.Text;
                    service.Price = Convert.ToInt32(sm_DetailServiceForm.S_price_textBox.Text);
                    service.Unit = sm_DetailServiceForm.S_unit_textBox.Text;
                    service.Description = sm_DetailServiceForm.S_description_richTextBox.Text;
                    if (SM_Functions.addService(service))
                    {
                        MessageBox.Show("Thêm thành công");
                        sm_DetailServiceForm.formState = "view";
                        sm_DetailServiceForm.edit_button.Text = "Sửa";
                        sm_DetailServiceForm.S_name_textBox.ReadOnly = true;
                        sm_DetailServiceForm.S_price_textBox.ReadOnly = true;
                        sm_DetailServiceForm.S_unit_textBox.ReadOnly = true;
                        sm_DetailServiceForm.S_description_richTextBox.ReadOnly = true;
                        sm_DetailServiceForm.S_name_textBox.Enabled = false;
                        sm_DetailServiceForm.S_price_textBox.Enabled = false;
                        sm_DetailServiceForm.S_description_richTextBox.Enabled = false;
                        sm_DetailServiceForm.S_unit_textBox.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }
                    break;
            }
            sm_MainForm.dataLoad();
        }
        private void add_button_Click(object sender, EventArgs e)
        {
            mainPanel.Panel2.Controls.Clear();
            int currentMaxID = SM_Functions.getMaxID();
            sm_DetailServiceForm = new SM_DetailServiceForm(currentMaxID + 1, "add");
            sm_DetailServiceForm.TopLevel = false;
            sm_DetailServiceForm.AutoScroll = true;
            sm_DetailServiceForm.FormBorderStyle = FormBorderStyle.None;
            mainPanel.Panel2.Controls.Add(sm_DetailServiceForm);
            sm_DetailServiceForm.Dock = DockStyle.Fill;
            sm_DetailServiceForm.Visible = true;
            sm_DetailServiceForm.Show();
            sm_DetailServiceForm.edit_button.Click += new EventHandler(edit_button_Click);
            sm_DetailServiceForm.delete_button.Click += new EventHandler(delete_button_Click);
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (sm_DetailServiceForm.formState != "add")
            {
                if (SM_Functions.deleteService(sm_DetailServiceForm.serviceID))
                {
                    MessageBox.Show("Xóa thành công");
                    sm_DetailServiceForm.Close();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
                sm_MainForm.dataLoad();
            }
        }
    }
}
