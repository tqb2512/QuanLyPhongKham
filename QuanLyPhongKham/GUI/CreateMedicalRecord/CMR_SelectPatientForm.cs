using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyPhongKham.Function.CreateMedicalRecord;
using QuanLyPhongKham.Classes;

namespace QuanLyPhongKham.GUI.CreateMedicalRecord
{
    public partial class CMR_SelectPatientForm : Form
    {
        internal Patient patient;

        public CMR_SelectPatientForm()
        {
            InitializeComponent();
        }

        private void CMR_SelectPatientForm_Load(object sender, EventArgs e)
        {
            Pateint_DataGridView.DataSource = CMR_Functions.getSqlData("SELECT * FROM PATIENT");
        }

        private void Confirm_Button_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            patient.ID = Int32.Parse(Pateint_DataGridView.CurrentRow.Cells[0].Value.ToString());
            patient.Name = Pateint_DataGridView.CurrentRow.Cells[1].Value.ToString();
            patient.PhoneNumber = Pateint_DataGridView.CurrentRow.Cells[3].Value.ToString();
            patient.Address = Pateint_DataGridView.CurrentRow.Cells[2].Value.ToString();
            patient.DateOfBirth = Convert.ToDateTime(Pateint_DataGridView.CurrentRow.Cells[4].Value.ToString());
            this.patient = patient;
            this.Close();
        }
    }
}
