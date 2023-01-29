using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongKham.GUI.ServiceManagement
{
    public partial class SM_PanelForm : Form
    {
        public SM_PanelForm()
        {
            InitializeComponent();
        }

        private void SM_PanelForm_Load(object sender, EventArgs e)
        {
            SM_MainForm sm_MainForm = new SM_MainForm();
            sm_MainForm.TopLevel = false;
            sm_MainForm.AutoScroll = true;
            sm_MainForm.FormBorderStyle = FormBorderStyle.None;
            mainPanel.Panel1.Controls.Add(sm_MainForm);
            sm_MainForm.Dock = DockStyle.Fill;
            sm_MainForm.Visible = true;
            sm_MainForm.Show();
        }
    }
}
