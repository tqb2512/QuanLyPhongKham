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

namespace QuanLyPhongKham.GUI.PatientManagement
{
    public partial class PM_DetailsPatientForm : Form
    {
        public PM_DetailsPatientForm()
        {
            InitializeComponent();
        }

        public void Data_Load()
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=WIN-30FJQ771AK3;Initial Catalog=QUANLYPHONGKHAM;Integrated Security=True");
                string sql = "SELECT MEDICALRECORD_ID,  MEDICALRECORD.EXAMINE_ID,  DATE,  DIAGNOSIS,  NOTE FROM MEDICALRECORD INNER JOIN EXAMINE ON MEDICALRECORD.EXAMINE_ID = EXAMINE.EXAMINE_ID INNER JOIN PATIENT ON EXAMINE.PATIENT_ID = PATIENT.PATIENT_ID INNER JOIN EMPLOYEE ON EXAMINE.EMPLOYEE_ID = EMPLOYEE.EMPLOYEE_ID WHERE PATIENT.PATIENT_ID = '" + textBoxIDPatient.Text + "'";
                //string sql = "SELECT MEDICALRECORD_ID, DATE, PATIENT.PATIENT_ID, PATIENT.PATIENT_NAME, EMPLOYEE.EMPLOYEE_ID, EMPLOYEE.EMPLOYEE_NAME, DIAGNOSIS, NOTE FROM MEDICALRECORD INNER JOIN EXAMINE ON MEDICALRECORD.EXAMINE_ID = EXAMINE.EXAMINE_ID INNER JOIN PATIENT ON EXAMINE.PATIENT_ID = PATIENT.PATIENT_ID INNER JOIN EMPLOYEE ON EXAMINE.EMPLOYEE_ID = EMPLOYEE.EMPLOYEE_ID WHERE MEDICALRECORD_ID = '" + medicalRecordId + "'";
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, conn);
                DataSet dataSet = new DataSet();
                conn.Open();
                dataadapter.Fill(dataSet, "MEDICALRECORD");
                conn.Close();
                dataGridView1.DataSource = dataSet;
                dataGridView1.DataMember = "MEDICALRECORD";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PM_DetailsPatientForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data_Load();
        }
    }
}
