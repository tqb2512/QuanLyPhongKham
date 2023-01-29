using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongKham.GUI.MedicalRecordManagement
{
    public partial class MRM_PanelForm : Form
    {
        public MRM_PanelForm()
        {
            InitializeComponent();
        }
        MRM_MainForm mrm_MainForm = new MRM_MainForm();
        private void MRM_PanelForm_Load(object sender, EventArgs e)
        {
            mrm_MainForm.TopLevel = false;
            mrm_MainForm.AutoScroll = true;
            mrm_MainForm.FormBorderStyle = FormBorderStyle.None;
            mainPanel.Panel1.Controls.Add(mrm_MainForm);
            mrm_MainForm.Dock = DockStyle.Fill;
            mrm_MainForm.Visible = true;
            mrm_MainForm.Show();
            mrm_MainForm.medicalRecordDataGrid.CellDoubleClick += new DataGridViewCellEventHandler(medicalRecordDataGrid_CellDoubleClick);
        }

        private void medicalRecordDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                mainPanel.Panel2.Controls.Clear();
                int medicalRecordID = Convert.ToInt32(mrm_MainForm.medicalRecordDataGrid.Rows[e.RowIndex].Cells[0].Value);
                MRM_DetailMedicalRecordForm mrm_DetailMedicalRecordForm = new MRM_DetailMedicalRecordForm(medicalRecordID);
                mrm_DetailMedicalRecordForm.TopLevel = false;
                mrm_DetailMedicalRecordForm.AutoScroll = true;
                mrm_DetailMedicalRecordForm.FormBorderStyle = FormBorderStyle.None;
                mainPanel.Panel2.Controls.Add(mrm_DetailMedicalRecordForm);
                mrm_DetailMedicalRecordForm.Dock = DockStyle.Fill;
                mrm_DetailMedicalRecordForm.Visible = true;
                mrm_DetailMedicalRecordForm.Show();
            }
        }
    }
}
