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

        private void dataLoad()
        {
            DataTable data = SM_Functions.getSqlData("SELECT * FROM SERVICE");
            servicesDataGridView.DataSource = data;
            servicesDataGridView.Columns["SERVICE_ID"].HeaderText = "ID";
            servicesDataGridView.Columns["SERVICE_NAME"].HeaderText = "Tên dịch vụ";
            servicesDataGridView.Columns["SERVICE_UNIT"].HeaderText = "Đơn vị";
            servicesDataGridView.Columns["SERVICE_PRICE"].HeaderText = "Giá";
            servicesDataGridView.Columns["SERVICE_DESCRIPTION"].HeaderText = "Mô tả";
            servicesDataGridView.Columns["SERVICE_ID"].Width = (int)(servicesDataGridView.Width * idColumnWidth) - 2;
            servicesDataGridView.Columns["SERVICE_NAME"].Width = (int)(servicesDataGridView.Width * nameColumnWidth);
            servicesDataGridView.Columns["SERVICE_UNIT"].Width = (int)(servicesDataGridView.Width * unitColumnWidth);
            servicesDataGridView.Columns["SERVICE_PRICE"].Width = (int)(servicesDataGridView.Width * priceColumnWidth);
            servicesDataGridView.Columns["SERVICE_DESCRIPTION"].Width = (int)(servicesDataGridView.Width * descriptionColumnWidth);
        }

        private void SM_MainForm_SizeChanged(object sender, EventArgs e)
        {
            servicesDataGridView.Columns["SERVICE_ID"].Width = (int)(servicesDataGridView.Width * idColumnWidth) - 2;
            servicesDataGridView.Columns["SERVICE_NAME"].Width = (int)(servicesDataGridView.Width * nameColumnWidth);
            servicesDataGridView.Columns["SERVICE_UNIT"].Width = (int)(servicesDataGridView.Width * unitColumnWidth);
            servicesDataGridView.Columns["SERVICE_PRICE"].Width = (int)(servicesDataGridView.Width * priceColumnWidth);
            servicesDataGridView.Columns["SERVICE_DESCRIPTION"].Width = (int)(servicesDataGridView.Width * descriptionColumnWidth);
        }
    }
}
