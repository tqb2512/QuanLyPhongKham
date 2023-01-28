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

        private void MedicalRecord_MenuItem_Click(object sender, EventArgs e)
        {
            TabPage medicalRecordTabPage = new TabPage("Quản lý hồ sơ bệnh án");
            MRM_PanelForm medicalRecordPanelForm = new MRM_PanelForm();
            medicalRecordPanelForm.TopLevel = false;
            medicalRecordPanelForm.AutoScroll = true;
            medicalRecordPanelForm.FormBorderStyle = FormBorderStyle.None;
            medicalRecordPanelForm.Dock = DockStyle.Fill;
            medicalRecordPanelForm.Visible = true;
            medicalRecordTabPage.Controls.Add(medicalRecordPanelForm);
            Main_TabControl.TabPages.Add(medicalRecordTabPage);
            medicalRecordPanelForm.Show();
        }

        private void createMR_StripMenu_Click(object sender, EventArgs e)
        {
            TabPage createMedicalRecordTabPage = new TabPage("Tạo hồ sơ bệnh án");
            CMR_MainForm createMedicalRecordForm = new CMR_MainForm();
            createMedicalRecordForm.TopLevel = false;
            createMedicalRecordForm.AutoScroll = true;
            createMedicalRecordForm.FormBorderStyle = FormBorderStyle.None;
            createMedicalRecordForm.Dock = DockStyle.Fill;
            createMedicalRecordForm.Visible = true;
            createMedicalRecordTabPage.Controls.Add(createMedicalRecordForm);
            Main_TabControl.TabPages.Add(createMedicalRecordTabPage);
            createMedicalRecordForm.Show();
        }

        private void Service_MenuItem_Click(object sender, EventArgs e)
        {
            TabPage serviceManagementTabPage = new TabPage("Quản lý dịch vụ");
            SM_PanelForm serviceManagementPanelForm = new SM_PanelForm();
            serviceManagementPanelForm.TopLevel = false;
            serviceManagementPanelForm.AutoScroll = true;
            serviceManagementPanelForm.FormBorderStyle = FormBorderStyle.None;
            serviceManagementPanelForm.Dock = DockStyle.Fill;
            serviceManagementPanelForm.Visible = true;
            serviceManagementTabPage.Controls.Add(serviceManagementPanelForm);
            Main_TabControl.TabPages.Add(serviceManagementTabPage);
            serviceManagementPanelForm.Show();
        }
    }
}
