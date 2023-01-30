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
    public partial class SM_DetailServiceForm : Form
    {
        public int serviceID;
        public string formState = "view";
        public SM_DetailServiceForm()
        {
            InitializeComponent();
        }
        public SM_DetailServiceForm(int ServiceID, string state)
        {
            InitializeComponent();
            formState = state;
            this.serviceID = ServiceID;
        }

        private void SM_DetailServiceForm_Load(object sender, EventArgs e)
        {
            S_ID_textBox.Text = serviceID.ToString();
            if (formState != "add")
            {
                Service service = new Service();
                service = SM_Functions.getDetailService(serviceID);
                S_name_textBox.Text = service.Name;
                S_price_textBox.Text = service.Price.ToString("N0");
                S_description_richTextBox.Text = service.Description;
                S_unit_textBox.Text = service.Unit;
            }
            else
            {
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
        }

        private void delete_Button_Click(object sender, EventArgs e)
        {
            if (SM_Functions.deleteService(serviceID))
            {
                MessageBox.Show("Xóa thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }


    }
}
