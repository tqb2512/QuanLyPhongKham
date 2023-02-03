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
using QuanLyPhongKham.Function.ServiceManagement;

namespace QuanLyPhongKham.GUI.ServiceManagement
{
    public partial class SM_MainForm : Form
    {
        public SM_MainForm()
        {
            InitializeComponent();
        }

        Service currentService = new Service();

        float idColumnWidth = 0.1f;
        float nameColumnWidth = 0.2f;
        float unitColumnWidth = 0.2f;
        float priceColumnWidth = 0.2f;
        float descriptionColumnWidth = 0.3f;
        public void dataLoad()
        {
            DataTable data = SM_Functions.getSqlData("SELECT * FROM SERVICE");
            servicesDataGridView.DataSource = data;
            servicesDataGridView.Columns["SERVICE_ID"].HeaderText = "ID";
            servicesDataGridView.Columns["SERVICE_NAME"].HeaderText = "Tên dịch vụ";
            servicesDataGridView.Columns["SERVICE_UNIT"].HeaderText = "Đơn vị";
            servicesDataGridView.Columns["SERVICE_PRICE"].HeaderText = "Giá";
            servicesDataGridView.Columns["SERVICE_DESCRIPTION"].HeaderText = "Mô tả";
            servicesDataGridView.Columns["SERVICE_ID"].Width = (int)(servicesDataGridView.Width * idColumnWidth);
            servicesDataGridView.Columns["SERVICE_NAME"].Width = (int)(servicesDataGridView.Width * nameColumnWidth);
            servicesDataGridView.Columns["SERVICE_UNIT"].Width = (int)(servicesDataGridView.Width * unitColumnWidth);
            servicesDataGridView.Columns["SERVICE_PRICE"].Width = (int)(servicesDataGridView.Width * priceColumnWidth);
            servicesDataGridView.Columns["SERVICE_DESCRIPTION"].Width = (int)(servicesDataGridView.Width * descriptionColumnWidth);
            servicesDataGridView.Columns["SERVICE_PRICE"].DefaultCellStyle.Format = "N0";
            search_TableLayout.ColumnStyles[0].Width = (int)(search_TableLayout.Width * idColumnWidth);
            search_TableLayout.ColumnStyles[1].Width = (int)(search_TableLayout.Width * nameColumnWidth);
            search_TableLayout.ColumnStyles[2].Width = (int)(search_TableLayout.Width * unitColumnWidth);
            search_TableLayout.ColumnStyles[3].Width = (int)(search_TableLayout.Width * priceColumnWidth);
            search_TableLayout.ColumnStyles[4].Width = (int)(search_TableLayout.Width * descriptionColumnWidth);
        }

        private void SM_MainForm_SizeChanged(object sender, EventArgs e)
        {
            servicesDataGridView.Columns["SERVICE_ID"].Width = (int)(servicesDataGridView.Width * idColumnWidth);
            servicesDataGridView.Columns["SERVICE_NAME"].Width = (int)(servicesDataGridView.Width * nameColumnWidth);
            servicesDataGridView.Columns["SERVICE_UNIT"].Width = (int)(servicesDataGridView.Width * unitColumnWidth);
            servicesDataGridView.Columns["SERVICE_PRICE"].Width = (int)(servicesDataGridView.Width * priceColumnWidth);
            servicesDataGridView.Columns["SERVICE_DESCRIPTION"].Width = (int)(servicesDataGridView.Width * descriptionColumnWidth);
            search_TableLayout.ColumnStyles[0].Width = (int)(search_TableLayout.Width * idColumnWidth);
            search_TableLayout.ColumnStyles[1].Width = (int)(search_TableLayout.Width * nameColumnWidth);
            search_TableLayout.ColumnStyles[2].Width = (int)(search_TableLayout.Width * unitColumnWidth);
            search_TableLayout.ColumnStyles[3].Width = (int)(search_TableLayout.Width * priceColumnWidth);
            search_TableLayout.ColumnStyles[4].Width = (int)(search_TableLayout.Width * descriptionColumnWidth);
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
                                filter += "CONVERT(SERVICE_ID, System.String) LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "nameSearch_textBox":
                                filter += "CONVERT(SERVICE_NAME, System.String) LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "unitSearch_textBox":
                                filter += "CONVERT(SERVICE_UNIT, System.String) LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "priceSearch_textBox":
                                filter += "CONVERT(SERVICE_PRICE, System.String) LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "descriptionSearch_textBox":
                                filter += "CONVERT(SERVICE_DESCRIPTION, System.String) LIKE '%" + control.Text + "%' AND ";
                                break;
                        }
                    }
                }
            }
            if (filter != "")
            {
                filter = filter.Substring(0, filter.Length - 4);
                (servicesDataGridView.DataSource as DataTable).DefaultView.RowFilter = filter;
            }
            else
            {
                (servicesDataGridView.DataSource as DataTable).DefaultView.RowFilter = null;
            }
        }

        private void SM_TestForm_Load(object sender, EventArgs e)
        {
            dataLoad();
            this.SizeChanged += new System.EventHandler(this.SM_MainForm_SizeChanged);
        }

        private void servicesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                edit_button.Text = "Sửa";
                currentService = SM_Functions.getDetailService(Convert.ToInt32(servicesDataGridView.Rows[e.RowIndex].Cells["SERVICE_ID"].Value.ToString()));
                S_ID_textBox.Text = currentService.ID.ToString();
                S_name_textBox.Text = currentService.Name;
                S_price_textBox.Text = currentService.Price.ToString("N0");
                S_description_richTextBox.Text = currentService.Description;
                S_unit_textBox.Text = currentService.Unit;
                S_name_textBox.ReadOnly = true;
                S_price_textBox.ReadOnly = true;
                S_unit_textBox.ReadOnly = true;
                S_description_richTextBox.ReadOnly = true;
                S_name_textBox.Enabled = false;
                S_price_textBox.Enabled = false;
                S_description_richTextBox.Enabled = false;
                S_unit_textBox.Enabled = false;
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (SM_Functions.checkPermission(Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["currentUserId"].ToString()), "EDIT_SERVICE") == true)
            {
                S_ID_textBox.Text = Convert.ToString(SM_Functions.getMaxID() + 1);
                S_name_textBox.Text = "";
                S_price_textBox.Text = "";
                S_description_richTextBox.Text = "";
                S_unit_textBox.Text = "";
                S_name_textBox.ReadOnly = false;
                S_price_textBox.ReadOnly = false;
                S_description_richTextBox.ReadOnly = false;
                S_unit_textBox.ReadOnly = false;
                S_name_textBox.Enabled = true;
                S_price_textBox.Enabled = true;
                S_description_richTextBox.Enabled = true;
                S_unit_textBox.Enabled = true;
                edit_button.Text = "Thêm";
            }
            else
            {
                MessageBox.Show("Bạn không có quyền thực hiện chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            if (SM_Functions.checkPermission(Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["currentUserId"].ToString()), "EDIT_SERVICE") == true)
            {
                if (S_ID_textBox.Text != "")
                    currentService.ID = Convert.ToInt32(S_ID_textBox.Text);
                currentService.Name = S_name_textBox.Text;
                if (S_price_textBox.Text != "")
                    currentService.Price = Convert.ToDecimal(S_price_textBox.Text);
                currentService.Unit = S_unit_textBox.Text;
                currentService.Description = S_description_richTextBox.Text;
                if (edit_button.Text == "Thêm")
                {
                    if (SM_Functions.addService(currentService))
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        edit_button.Text = "Sửa";
                        S_name_textBox.ReadOnly = true;
                        S_price_textBox.ReadOnly = true;
                        S_unit_textBox.ReadOnly = true;
                        S_description_richTextBox.ReadOnly = true;
                        S_name_textBox.Enabled = false;
                        S_price_textBox.Enabled = false;
                        S_description_richTextBox.Enabled = false;
                        S_unit_textBox.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (edit_button.Text == "Lưu")
                {
                    if (SM_Functions.updateService(currentService))
                    {
                        MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        edit_button.Text = "Sửa";
                        S_name_textBox.ReadOnly = true;
                        S_price_textBox.ReadOnly = true;
                        S_unit_textBox.ReadOnly = true;
                        S_description_richTextBox.ReadOnly = true;
                        S_name_textBox.Enabled = false;
                        S_price_textBox.Enabled = false;
                        S_description_richTextBox.Enabled = false;
                        S_unit_textBox.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (S_ID_textBox.Text != "")
                {
                    edit_button.Text = "Lưu";
                    S_name_textBox.ReadOnly = false;
                    S_price_textBox.ReadOnly = false;
                    S_unit_textBox.ReadOnly = false;
                    S_description_richTextBox.ReadOnly = false;
                    S_name_textBox.Enabled = true;
                    S_price_textBox.Enabled = true;
                    S_description_richTextBox.Enabled = true;
                    S_unit_textBox.Enabled = true;
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
            if (SM_Functions.checkPermission(Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["currentUserId"].ToString()), "EDIT_SERVICE") == true)
            {
                if (S_ID_textBox.Text != "" || S_ID_textBox.Text != Convert.ToString(SM_Functions.getMaxID()))
                {
                    if (SM_Functions.deleteService(Convert.ToInt32(S_ID_textBox.Text)) == true)
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        S_ID_textBox.Text = "";
                        S_name_textBox.Text = "";
                        S_price_textBox.Text = "";
                        S_description_richTextBox.Text = "";
                        S_unit_textBox.Text = "";
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

        private void refresh_button_Click(object sender, EventArgs e)
        {
            dataLoad();
        }

        private void S_price_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(Char.IsNumber((char)e.KeyCode) || e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Enter))
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
