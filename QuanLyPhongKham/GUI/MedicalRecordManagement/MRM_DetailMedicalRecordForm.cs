using QuanLyPhongKham.Classes;
using QuanLyPhongKham.Function;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongKham.GUI.MedicalRecordManagement
{
    public partial class MRM_DetailMedicalRecordForm : Form
    {
        MedicalRecord medicalRecord = new MedicalRecord();
        public MRM_DetailMedicalRecordForm()
        {
            InitializeComponent();
        }

        public MRM_DetailMedicalRecordForm(int medicalRecordID)
        {
            InitializeComponent();
            medicalRecord.ID = medicalRecordID;
            dataLoad();
            this.SizeChanged += new EventHandler(MRM_DetailMedicalRecordForm_SizeChanged);
        }
        
        float D_ID_Width = 0.1f;
        float D_Name_Width = 0.3f;
        float D_Quantity_Width = 0.1f;
        float D_Unit_Width = 0.2f;
        float D_Price_Width = 0.3f;

        float S_ID_Width = 0.1f;
        float S_Name_Width = 0.3f;
        float S_Quantity_Width = 0.1f;
        float S_Unit_Width = 0.2f;
        float S_Price_Width = 0.3f;

        public void dataLoad()
        {
            medicalRecord = MRM_Functions.getDetailMedicalRecord(medicalRecord.ID);
            MR_ID_textBox.Text = medicalRecord.ID.ToString();
            MR_Date_textBox.Text = medicalRecord.Date.ToString();
            P_ID_textBox.Text = medicalRecord.Patient.ID.ToString();
            P_Name_textBox.Text = medicalRecord.Patient.Name;
            E_ID_textBox.Text = medicalRecord.Employee.ID.ToString();
            E_Name_textBox.Text = medicalRecord.Employee.Name;
            MR_PateintTemp_textBox.Text = medicalRecord.Patient_Temp.ToString() + " °C";
            MR_PatientWeight_textBox.Text = medicalRecord.Patient_Weight.ToString() + " kg";
            MR_Diagnosis_textBox.Text = medicalRecord.Diagnosis;
            MR_Note_textBox.Text = medicalRecord.Note;
            D_List_GridView.DataSource = medicalRecord.Drugs;
            S_List_GridView.DataSource = medicalRecord.Services;
            MR_Total_TextBox.Text = "0";
            foreach (DataGridViewRow row in S_List_GridView.Rows)
            {
                MR_Total_TextBox.Text = (decimal.Parse(MR_Total_TextBox.Text) + decimal.Parse(row.Cells["Price"].Value.ToString()) * decimal.Parse(row.Cells["Quantity"].Value.ToString())).ToString();
            }
            foreach (DataGridViewRow row in D_List_GridView.Rows)
            {
                MR_Total_TextBox.Text = (decimal.Parse(MR_Total_TextBox.Text) + decimal.Parse(row.Cells["Price"].Value.ToString()) * decimal.Parse(row.Cells["Quantity"].Value.ToString())).ToString();
            }
            MR_Total_TextBox.Text = string.Format("{0:#,##}", decimal.Parse(MR_Total_TextBox.Text));
            if (medicalRecord.Payment_Status == false)
            {
                MR_PaymentStatus_TextBox.Text = "Chưa thanh toán";
                MR_PaymentMake_Button.Enabled = true;
            }
            else
            {
                MR_PaymentStatus_TextBox.Text = "Đã thanh toán";
                MR_PaymentMake_Button.Enabled = false;
            }
            D_List_GridView.Columns["ID"].HeaderText = "ID";
            D_List_GridView.Columns["Name"].HeaderText = "Tên thuốc";
            D_List_GridView.Columns["Quantity"].HeaderText = "SL";
            D_List_GridView.Columns["Unit"].HeaderText = "Đơn vị";
            D_List_GridView.Columns["Price"].HeaderText = "Giá";
            D_List_GridView.Columns["ID"].Width = (int)(D_List_GridView.Width * D_ID_Width) - 2;
            D_List_GridView.Columns["Name"].Width = (int)(D_List_GridView.Width * D_Name_Width);
            D_List_GridView.Columns["Quantity"].Width = (int)(D_List_GridView.Width * D_Quantity_Width);
            D_List_GridView.Columns["Unit"].Width = (int)(D_List_GridView.Width * D_Unit_Width);
            D_List_GridView.Columns["Price"].Width = (int)(D_List_GridView.Width * D_Price_Width);
            D_List_GridView.Columns["Manufacturer"].Visible = false;
            D_List_GridView.Columns["Description"].Visible = false;
            D_List_GridView.Columns["TypeID"].Visible = false;
            D_List_GridView.Columns["TypeName"].Visible = false;
            D_List_GridView.Columns["Price"].DefaultCellStyle.Format = "N0";
            S_List_GridView.Columns["ID"].HeaderText = "ID";
            S_List_GridView.Columns["Name"].HeaderText = "Tên dịch vụ";
            S_List_GridView.Columns["Quantity"].HeaderText = "SL";
            S_List_GridView.Columns["Unit"].HeaderText = "Đơn vị";
            S_List_GridView.Columns["Price"].HeaderText = "Giá";
            S_List_GridView.Columns["ID"].Width = (int)(S_List_GridView.Width * S_ID_Width) - 2;
            S_List_GridView.Columns["Name"].Width = (int)(S_List_GridView.Width * S_Name_Width);
            S_List_GridView.Columns["Quantity"].Width = (int)(S_List_GridView.Width * S_Quantity_Width);
            S_List_GridView.Columns["Unit"].Width = (int)(S_List_GridView.Width * S_Unit_Width);
            S_List_GridView.Columns["Price"].Width = (int)(S_List_GridView.Width * S_Price_Width);
            S_List_GridView.Columns["Price"].DefaultCellStyle.Format = "N0";
            S_List_GridView.Columns["Description"].Visible = false;
            S_List_GridView.Columns["Price"].DisplayIndex = 4;
        }
        private void MRM_DetailMedicalRecordForm_SizeChanged(object sender, EventArgs e)
        {
            D_List_GridView.Columns["ID"].Width = (int)(D_List_GridView.Width * D_ID_Width) - 2;
            D_List_GridView.Columns["Name"].Width = (int)(D_List_GridView.Width * D_Name_Width);
            D_List_GridView.Columns["Quantity"].Width = (int)(D_List_GridView.Width * D_Quantity_Width);
            D_List_GridView.Columns["Unit"].Width = (int)(D_List_GridView.Width * D_Unit_Width);
            D_List_GridView.Columns["Price"].Width = (int)(D_List_GridView.Width * D_Price_Width);
            S_List_GridView.Columns["ID"].Width = (int)(S_List_GridView.Width * S_ID_Width) - 2;
            S_List_GridView.Columns["Name"].Width = (int)(S_List_GridView.Width * S_Name_Width);
            S_List_GridView.Columns["Quantity"].Width = (int)(S_List_GridView.Width * S_Quantity_Width);
            S_List_GridView.Columns["Unit"].Width = (int)(S_List_GridView.Width * S_Unit_Width);
            S_List_GridView.Columns["Price"].Width = (int)(S_List_GridView.Width * S_Price_Width);
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (MRM_Functions.checkPermission(Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["currentUserId"].ToString()), "REMOVE_MEDICALRECORD"))
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa hồ sơ khám bệnh này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (MRM_Functions.deleteMedicalRecord(medicalRecord.ID))
                    {
                        MessageBox.Show("Xóa hồ sơ khám bệnh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Xóa hồ sơ khám bệnh thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn không có quyền xóa hồ sơ khám bệnh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MR_PaymentMake_Button_Click(object sender, EventArgs e)
        {
            if (MRM_Functions.checkPermission(Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["currentUserId"].ToString()), "MAKEPAYMENT_MEDICALRECORD"))
            {
                MessageBox.Show("Bệnh nhân " + medicalRecord.Patient.Name + " đã thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MRM_Functions.sqlQueryExcute("UPDATE MEDICALRECORD SET PAYMENT_STATUS = 1 WHERE MEDICALRECORD_ID = " + medicalRecord.ID);
                dataLoad();
            }
            else
            {
                MessageBox.Show("Bạn không thể thực hiện thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
