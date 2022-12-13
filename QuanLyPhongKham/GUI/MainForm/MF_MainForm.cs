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
    }
}
