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
    public partial class SM_MainForm : Form
    {
        public SM_MainForm()
        {
            InitializeComponent();
        }
        float idColumnWidth = 0.1f;
        float nameColumnWidth = 0.2f;
        float unitColumnWidth = 0.2f;
        float priceColumnWidth = 0.2f;
        float descriptionColumnWidth = 0.3f;

        private void SM_MainForm_Load(object sender, EventArgs e)
        {
            dataLoad();
            this.SizeChanged += new System.EventHandler(this.SM_MainForm_SizeChanged);
        }

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
    }
}
