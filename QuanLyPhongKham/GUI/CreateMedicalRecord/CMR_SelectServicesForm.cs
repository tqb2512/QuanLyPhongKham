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
    public partial class CMR_SelectServicesForm : Form
    {
        public CMR_SelectServicesForm()
        {
            InitializeComponent();
        }
        internal CMR_SelectServicesForm(List<Service> service)
        {
            InitializeComponent();
            this.services = service;
        }
        float idColumnWidth = 0.1f;
        float nameColumnWidth = 0.3f;
        float unitColumnWidth = 0.1f;
        float priceColumnWidth = 0.2f;
        float descriptionColumnWidth = 0.2f;
        float quantityColumnWidth = 0.1f;
        internal List<Service> services;

        private void CMR_SelectServicesForm_Load(object sender, EventArgs e)
        {
            dataLoad();
            this.SizeChanged += new System.EventHandler(this.CMR_SelectServicesForm_SizeChanged);
        }

        public void dataLoad()
        {
            DataTable data = SM_Functions.getSqlData("SELECT * FROM SERVICE");
            data.Columns.Add("Quantity");
            foreach (DataRow row in data.Rows)
            {
                row["Quantity"] = "";
            }
            if (services != null)
            {
                foreach (Service service in services)
                {
                    foreach (DataRow row in data.Rows)
                    {
                        if (service.ID == (int)row["SERVICE_ID"])
                        {
                            row["Quantity"] = service.Quantity;
                        }
                    }
                }
            }

            servicesDataGridView.DataSource = data;
            servicesDataGridView.Columns["SERVICE_ID"].HeaderText = "ID";
            servicesDataGridView.Columns["SERVICE_NAME"].HeaderText = "Tên dịch vụ";
            servicesDataGridView.Columns["SERVICE_UNIT"].HeaderText = "Đơn vị";
            servicesDataGridView.Columns["SERVICE_PRICE"].HeaderText = "Giá";
            servicesDataGridView.Columns["SERVICE_DESCRIPTION"].HeaderText = "Mô tả";
            servicesDataGridView.Columns["Quantity"].HeaderText = "SL";
            servicesDataGridView.Columns["SERVICE_ID"].Width = (int)(servicesDataGridView.Width * idColumnWidth);
            servicesDataGridView.Columns["SERVICE_NAME"].Width = (int)(servicesDataGridView.Width * nameColumnWidth);
            servicesDataGridView.Columns["SERVICE_UNIT"].Width = (int)(servicesDataGridView.Width * unitColumnWidth);
            servicesDataGridView.Columns["SERVICE_PRICE"].Width = (int)(servicesDataGridView.Width * priceColumnWidth);
            servicesDataGridView.Columns["SERVICE_DESCRIPTION"].Width = (int)(servicesDataGridView.Width * descriptionColumnWidth);
            servicesDataGridView.Columns["Quantity"].Width = (int)(servicesDataGridView.Width * quantityColumnWidth);
            servicesDataGridView.Columns["SERVICE_PRICE"].DefaultCellStyle.Format = "N0";
            search_TableLayout.ColumnStyles[0].Width = (int)(search_TableLayout.Width * idColumnWidth);
            search_TableLayout.ColumnStyles[1].Width = (int)(search_TableLayout.Width * nameColumnWidth);
            search_TableLayout.ColumnStyles[2].Width = (int)(search_TableLayout.Width * unitColumnWidth);
            search_TableLayout.ColumnStyles[3].Width = (int)(search_TableLayout.Width * priceColumnWidth);
            search_TableLayout.ColumnStyles[4].Width = (int)(search_TableLayout.Width * descriptionColumnWidth);
            search_TableLayout.ColumnStyles[5].Width = (int)(search_TableLayout.Width * quantityColumnWidth);

        }

        private void CMR_SelectServicesForm_SizeChanged(object sender, EventArgs e)
        {
            servicesDataGridView.Columns["SERVICE_ID"].Width = (int)(servicesDataGridView.Width * idColumnWidth);
            servicesDataGridView.Columns["SERVICE_NAME"].Width = (int)(servicesDataGridView.Width * nameColumnWidth);
            servicesDataGridView.Columns["SERVICE_UNIT"].Width = (int)(servicesDataGridView.Width * unitColumnWidth);
            servicesDataGridView.Columns["SERVICE_PRICE"].Width = (int)(servicesDataGridView.Width * priceColumnWidth);
            servicesDataGridView.Columns["SERVICE_DESCRIPTION"].Width = (int)(servicesDataGridView.Width * descriptionColumnWidth);
            servicesDataGridView.Columns["Quantity"].Width = (int)(servicesDataGridView.Width * quantityColumnWidth);
            search_TableLayout.ColumnStyles[0].Width = (int)(search_TableLayout.Width * idColumnWidth);
            search_TableLayout.ColumnStyles[1].Width = (int)(search_TableLayout.Width * nameColumnWidth);
            search_TableLayout.ColumnStyles[2].Width = (int)(search_TableLayout.Width * unitColumnWidth);
            search_TableLayout.ColumnStyles[3].Width = (int)(search_TableLayout.Width * priceColumnWidth);
            search_TableLayout.ColumnStyles[4].Width = (int)(search_TableLayout.Width * descriptionColumnWidth);
            search_TableLayout.ColumnStyles[5].Width = (int)(search_TableLayout.Width * quantityColumnWidth);
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
                            case "quantitySearch_textBox":
                                filter += "CONVERT(Quantity, System.String) LIKE '%" + control.Text + "%' AND ";
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

        private void confirm_button_Click(object sender, EventArgs e)
        {
            services = new List<Service>();
            foreach (DataGridViewRow row in servicesDataGridView.Rows)
            {
                if (row.Cells["Quantity"].Value != System.DBNull.Value && row.Cells["Quantity"].Value != "" && Convert.ToInt32(row.Cells["Quantity"].Value) * 1 != 0)
                {
                    Service service = new Service();
                    service.ID = Convert.ToInt32(row.Cells["SERVICE_ID"].Value.ToString());
                    service.Name = row.Cells["SERVICE_NAME"].Value.ToString();
                    service.Unit = row.Cells["SERVICE_UNIT"].Value.ToString();
                    service.Price = Convert.ToDecimal(row.Cells["SERVICE_PRICE"].Value.ToString());
                    service.Description = row.Cells["SERVICE_DESCRIPTION"].Value.ToString();
                    service.Quantity = Convert.ToInt32(row.Cells["Quantity"].Value.ToString());
                    services.Add(service);
                }
            }
            this.Close();
        }

        private void servicesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                servicesDataGridView.BeginEdit(true);
            }
        }
        private void servicesDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridViewTextBoxEditingControl tb = e.Control as DataGridViewTextBoxEditingControl;
            if (tb != null)
            {
                tb.KeyPress += new KeyPressEventHandler(servicesDataGridView_KeyPress);
            }
            e.Control.KeyPress += new KeyPressEventHandler(servicesDataGridView_KeyPress);

        }

        private void servicesDataGridView_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber((char)e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete || e.KeyChar == (char)Keys.Enter))
            {
                e.Handled = true;
            }
        }
    }
}
