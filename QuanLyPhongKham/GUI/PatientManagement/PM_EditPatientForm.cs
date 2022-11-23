using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyPhongKham.Function.PatientManagement;
using QuanLyPhongKham.GUI.PatientManagement;

namespace QuanLyPhongKham.GUI.PatientManagement
{
    public partial class PM_EditPatientForm : Form
    {
        public PM_EditPatientForm()
        {
            InitializeComponent();
        }

        private void buttonUpdatePatient_Click(object sender, EventArgs e)
        {
            textBoxPatientID.Text = "";
        }

        private void PM_EditPatientForm_Load(object sender, EventArgs e)
        {
            textBoxPatientID.Text = 
            
        }
    }
}
