using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows;
using QuanLyPhongKham.Classes;
using QuanLyPhongKham.GUI.MedicalRecordManagement;
using QuanLyPhongKham.GUI.CreateMedicalRecord;
using QuanLyPhongKham.GUI.PatientManagement;
using QuanLyPhongKham.GUI.ServiceManagement;
using QuanLyPhongKham.GUI.EmployeeManagement;
using QuanLyPhongKham.GUI.DrugManagement;
using QuanLyPhongKham.Function;
using QuanLyPhongKham.GUI.Statistical;

namespace QuanLyPhongKham.GUI.MainForm
{
    public partial class MF_MainForm : Form
    {
        Employee currentUser;
        public MF_MainForm()
        {
            InitializeComponent();
        }

        public MF_MainForm(int currentUserID)
        {
            InitializeComponent();
            this.currentUser = MF_Functions.getUserInfo(currentUserID);
            E_Name_Label.Text = "Xin chào " + this.currentUser.Name + "!";
            MF_MainForm_SizeChanged(this, null);
        }
        private void addToTabControl(Form form, string tabName)
        {
            Krypton.Navigator.KryptonPage tabPage = new Krypton.Navigator.KryptonPage();
            tabPage.Text = tabName;
            form.TopLevel = false;
            form.AutoScroll = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Visible = true;
            tabPage.Controls.Add(form);
            Main_TabControl.Pages.Add(tabPage);
            form.Show();
            Main_TabControl.SelectedPage = tabPage;
        }

        private void MedicalRecord_MenuItem_Click(object sender, EventArgs e)
        {
            addToTabControl(new MRM_PanelForm(), "Quản lý hồ sơ bệnh án");
        }

        private void createMR_StripMenu_Click(object sender, EventArgs e)
        {
            addToTabControl(new CMR_MainForm(currentUser.ID), "Tạo hồ sơ bệnh án");
        }

        private void Service_MenuItem_Click(object sender, EventArgs e)
        {
            addToTabControl(new SM_MainForm(), "Quản lý dịch vụ");
        }


        
        private void MF_MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Configuration.ConfigurationManager.AppSettings["currentUserId"] = "-1";
        }

        private void E_MenuItem_Click_1(object sender, EventArgs e)
        {
            addToTabControl(new EM_PanelForm(), "Quản lý nhân viên");
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }


        private void Patient_MenuItem_Click(object sender, EventArgs e)
        {
            addToTabControl(new PM_MainForm(), "Quản lý bệnh nhân");

        }

        private void MF_MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MF_MainForm_SizeChanged(object sender, EventArgs e)
        {
            Size tabControl = new Size(this.Size.Width, this.Size.Height);
            tabControl.Width -= SystemInformation.VerticalScrollBarWidth - SystemInformation.Border3DSize.Width;
            tabControl.Height -= StatusStrip.Height + SystemInformation.Border3DSize.Height + SystemInformation.CaptionHeight + SystemInformation.MenuHeight + SystemInformation.ToolWindowCaptionHeight;
            Main_TabControl.Size = tabControl;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            addToTabControl(new S_MainForm(), "Thống kê");
        }
        
        private void D_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addToTabControl(new DM_MainForm(), "Quản lý thuốc");
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            MF_ChangePasswordForm changePasswordForm = new MF_ChangePasswordForm();
            changePasswordForm.ShowDialog();
        }
    }
}
