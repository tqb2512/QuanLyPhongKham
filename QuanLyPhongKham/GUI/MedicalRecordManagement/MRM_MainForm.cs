using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyPhongKham.Classes;
using QuanLyPhongKham.Function;
using QuanLyPhongKham.Function.MedicalRecordManagement;

namespace QuanLyPhongKham.GUI.MedicalRecordManagement
{
    public partial class MRM_MainForm : Form
    {
        
        public MRM_MainForm()
        {
            InitializeComponent();
        }

        private void MRM_MainForm_Load(object sender, EventArgs e)
        {
            //DataSource dựa vào tên của server SQL trên máy
            string dataSource = "Data Source=DESKTOP-UFNGE5T;Initial Catalog=QUANLYPHONGKHAM;Integrated Security=True";
            MRM_Functions mrm = new MRM_Functions();
            DataTable table = mrm.getTableData(dataSource, "SELECT * FROM PATIENT");
            dvgPatient.DataSource = table;
        }
    }
}