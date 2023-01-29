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
using QuanLyPhongKham.Function.MainForm;
using QuanLyPhongKham.GUI.MedicalRecordManagement;
using QuanLyPhongKham.GUI.CreateMedicalRecord;
using QuanLyPhongKham.GUI.PatientManagement;
using QuanLyPhongKham.GUI.ServiceManagement;

namespace QuanLyPhongKham.GUI.MainForm
{
    public partial class MF_MainForm : Form
    {
        public MF_MainForm()
        {
            InitializeComponent();
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
        }

        private void MedicalRecord_MenuItem_Click(object sender, EventArgs e)
        {
            //TabPage medicalRecordTabPage = new TabPage("Quản lý hồ sơ bệnh án");
            //MRM_PanelForm medicalRecordPanelForm = new MRM_PanelForm();
            //medicalRecordPanelForm.TopLevel = false;
            //medicalRecordPanelForm.AutoScroll = true;
            //medicalRecordPanelForm.FormBorderStyle = FormBorderStyle.None;
            //medicalRecordPanelForm.Dock = DockStyle.Fill;
            //medicalRecordPanelForm.Visible = true;
            //medicalRecordTabPage.Controls.Add(medicalRecordPanelForm);
            //Main_TabControl.TabPages.Add(medicalRecordTabPage);
            //medicalRecordPanelForm.Show();

            addToTabControl(new MRM_PanelForm(), "Quản lý hồ sơ bệnh án");
        }

        private void createMR_StripMenu_Click(object sender, EventArgs e)
        {
            //TabPage createMedicalRecordTabPage = new TabPage("Tạo hồ sơ bệnh án");
            //CMR_MainForm createMedicalRecordForm = new CMR_MainForm();
            //createMedicalRecordForm.TopLevel = false;
            //createMedicalRecordForm.AutoScroll = true;
            //createMedicalRecordForm.FormBorderStyle = FormBorderStyle.None;
            //createMedicalRecordForm.Dock = DockStyle.Fill;
            //createMedicalRecordForm.Visible = true;
            //createMedicalRecordTabPage.Controls.Add(createMedicalRecordForm);
            //Main_TabControl.TabPages.Add(createMedicalRecordTabPage);
            //createMedicalRecordForm.Show();

            addToTabControl(new CMR_MainForm(), "Tạo hồ sơ bệnh án");
        }

        private void Service_MenuItem_Click(object sender, EventArgs e)
        {
            //TabPage serviceTabPage = new TabPage("Quản lý dịch vụ");
            //SM_MainForm serviceForm = new SM_MainForm();
            //serviceForm.TopLevel = false;
            //serviceForm.AutoScroll = true;
            //serviceForm.FormBorderStyle = FormBorderStyle.None;
            //serviceForm.Dock = DockStyle.Fill;
            //serviceForm.Visible = true;
            //serviceTabPage.Controls.Add(serviceForm);
            //Main_TabControl.TabPages.Add(serviceTabPage);
            //serviceForm.Show();

            addToTabControl(new SM_MainForm(), "Quản lý dịch vụ");
        }
    }
}
