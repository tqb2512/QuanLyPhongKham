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
using QuanLyPhongKham.Function;

namespace QuanLyPhongKham.GUI.Statistical
{
    public partial class S_MainForm : Form
    {
        public S_MainForm()
        {
            InitializeComponent();
        }

        private void S_MainForm_Load(object sender, EventArgs e)
        {
            DataTable medicalRecord1Month = MRM_Functions.getSqlData("SELECT TOP 31 COUNT(MEDICALRECORD_ID) AS TOTAL, CONCAT(YEAR(DATE), '/', MONTH(DATE), '/', day(DATE)) AS DATE FROM MEDICALRECORD GROUP BY year(DATE), month(DATE), day(DATE) ORDER BY DATE ASC");
            medicalRecord1Month.Columns.Add("DATETIME", typeof(DateTime));
            foreach (DataRow row in medicalRecord1Month.Rows)
            {
                row["DATE"] = Convert.ToDateTime(row["DATE"]).ToString("dd/MM/yyyy");
            }
            colChart.DataSource = medicalRecord1Month;
            colChart.Series["Số lượng bệnh án"].XValueMember = "DATE";
            colChart.Series["Số lượng bệnh án"].YValueMembers = "TOTAL";

            DataTable allMRService = MRM_Functions.getSqlData("SELECT SERVICE.SERVICE_ID, SERVICE.SERVICE_PRICE, A.MEDICALRECORD_ID FROM SERVICE INNER JOIN (SELECT SERVICE_ID, MEDICALRECORD.MEDICALRECORD_ID FROM SERVICEBILL INNER JOIN MEDICALRECORD ON MEDICALRECORD.MEDICALRECORD_ID = SERVICEBILL.MEDICALRECORD_ID) AS A ON SERVICE.SERVICE_ID = A.SERVICE_ID");
            decimal serviceSum = 0;
            decimal drugSum = 0;
            foreach (DataRow row in allMRService.Rows)
            {
                serviceSum += Convert.ToDecimal(row["SERVICE_PRICE"]);
            }
            DataTable allMRDrug = MRM_Functions.getSqlData("SELECT DRUG.DRUG_ID, DRUG.DRUG_PRICE, QUANTITY, A.MEDICALRECORD_ID FROM DRUG INNER JOIN (SELECT DRUG_ID, QUANTITY, MEDICALRECORD.MEDICALRECORD_ID FROM PRESCRIPTION INNER JOIN MEDICALRECORD ON MEDICALRECORD.MEDICALRECORD_ID = PRESCRIPTION.DRUG_ID) AS A ON DRUG.DRUG_ID = A.DRUG_ID");
            foreach (DataRow row in allMRDrug.Rows)
            {
                drugSum += Convert.ToDecimal(row["DRUG_PRICE"]) * Convert.ToDecimal(row["QUANTITY"]);
            }
            pieChart.Series["Series1"].Points.AddXY("Tổng tiền dịch vụ", serviceSum);
            pieChart.Series["Series1"].Points.AddXY("Tổng tiền thuốc", drugSum);
            dataLoad();
        }
    

        private void dataLoad()
        {
            DataTable medicalRecord = MRM_Functions.getSqlData("SELECT * FROM MEDICALRECORD");
            DataTable patient = MRM_Functions.getSqlData("SELECT * FROM PATIENT");
            DataTable service = MRM_Functions.getSqlData("SELECT * FROM SERVICE");
            DataTable drug = MRM_Functions.getSqlData("SELECT * FROM DRUG");
            DataTable employee = MRM_Functions.getSqlData("SELECT * FROM EMPLOYEE");
            totalMR_textBox.Text = medicalRecord.Rows.Count.ToString();
            totalPatient_textBox.Text = patient.Rows.Count.ToString();
            totalService_textBox.Text = service.Rows.Count.ToString();
            totalDrug_textBox.Text = drug.Rows.Count.ToString();
            totalEmployee_textBox.Text = employee.Rows.Count.ToString();
            DataTable paidDrugMR = MRM_Functions.getSqlData("SELECT DRUG_PRICE, QUANTITY FROM DRUG INNER JOIN(SELECT A.MEDICALRECORD_ID, DRUG_ID, QUANTITY FROM PRESCRIPTION INNER JOIN(SELECT MEDICALRECORD_ID FROM MEDICALRECORD WHERE PAYMENT_STATUS = 1) AS A ON A.MEDICALRECORD_ID = PRESCRIPTION.MEDICALRECORD_ID) AS B ON DRUG.DRUG_ID = B.DRUG_ID");
            DataTable paidServiceMR = MRM_Functions.getSqlData("SELECT SERVICE_PRICE, B.QUANTITY FROM SERVICE INNER JOIN(SELECT A.MEDICALRECORD_ID, SERVICE_ID, QUANTITY FROM SERVICEBILL INNER JOIN (SELECT MEDICALRECORD_ID FROM MEDICALRECORD WHERE PAYMENT_STATUS = 1) AS A ON A.MEDICALRECORD_ID = SERVICEBILL.MEDICALRECORD_ID) AS B ON SERVICE.SERVICE_ID = B.SERVICE_ID");
            decimal paidSum = 0;
            foreach (DataRow row in paidDrugMR.Rows)
            {
                paidSum += Convert.ToDecimal(row["DRUG_PRICE"]) * Convert.ToDecimal(row["QUANTITY"]);
            }
            foreach (DataRow row in paidServiceMR.Rows)
            {
                paidSum += Convert.ToDecimal(row["SERVICE_PRICE"]) * Convert.ToDecimal(row["QUANTITY"]);
            }
            totalPaid_textBox.Text = paidSum.ToString();
            totalPaid_textBox.Text = String.Format("{0:0,0}", Convert.ToDecimal(totalPaid_textBox.Text));
        }

        private void toDate_ValueChanged(object sender, EventArgs e)
        {
            DataTable medicalRecord = MRM_Functions.getSqlData("SELECT COUNT(MEDICALRECORD_ID) AS TOTAL, CONCAT(YEAR(DATE), '-', MONTH(DATE), '-', day(DATE)) AS DATE FROM MEDICALRECORD WHERE DATE BETWEEN '" +
                fromDate.Value.Date.ToString("yyyy/MM/dd") +
                "' AND '" + toDate.Value.Date.ToString("yyyy/MM/dd") +
                "' GROUP BY year(DATE), month(DATE), day(DATE) ORDER BY DATE ASC");
            medicalRecord.Columns.Add("DATETIME", typeof(DateTime));
            foreach (DataRow row in medicalRecord.Rows)
            {
                row["DATE"] = Convert.ToDateTime(row["DATE"]).ToString("dd/MM/yyyy");
            }
            colChart.Series["Số lượng bệnh án"].Points.Clear();
            colChart.DataSource = medicalRecord;
            colChart.Series["Số lượng bệnh án"].XValueMember = "DATE";
            colChart.Series["Số lượng bệnh án"].YValueMembers = "TOTAL";

            pieChart.Series["Series1"].Points.Clear();
            DataTable allMRService = MRM_Functions.getSqlData("SELECT SERVICE.SERVICE_ID, SERVICE.SERVICE_PRICE, QUANTITY, A.MEDICALRECORD_ID FROM SERVICE INNER JOIN (SELECT SERVICE_ID, QUANTITY, MEDICALRECORD.MEDICALRECORD_ID FROM SERVICEBILL INNER JOIN MEDICALRECORD ON MEDICALRECORD.MEDICALRECORD_ID = SERVICEBILL.MEDICALRECORD_ID WHERE DATE BETWEEN '" + fromDate.Value.Date.ToString("yyyy/MM/dd") + "' AND '" + toDate.Value.Date.ToString("yyyy/MM/dd") + "') AS A ON SERVICE.SERVICE_ID = A.SERVICE_ID");
            decimal serviceSum = 0;
            decimal drugSum = 0;
            foreach (DataRow row in allMRService.Rows)
            {
                serviceSum += Convert.ToDecimal(row["SERVICE_PRICE"]) * Convert.ToDecimal(row["QUANTITY"]);
            }
            DataTable allMRDrug = MRM_Functions.getSqlData("SELECT DRUG.DRUG_ID, DRUG.DRUG_PRICE, QUANTITY, A.MEDICALRECORD_ID FROM DRUG INNER JOIN (SELECT DRUG_ID, QUANTITY, MEDICALRECORD.MEDICALRECORD_ID FROM PRESCRIPTION INNER JOIN MEDICALRECORD ON MEDICALRECORD.MEDICALRECORD_ID = PRESCRIPTION.DRUG_ID WHERE DATE BETWEEN '" + fromDate.Value.Date.ToString("yyyy/MM/dd") + "' AND '" + toDate.Value.Date.ToString("yyyy/MM/dd") + "') AS A ON DRUG.DRUG_ID = A.DRUG_ID");
            foreach (DataRow row in allMRDrug.Rows)
            {
                drugSum += Convert.ToDecimal(row["DRUG_PRICE"]) * Convert.ToDecimal(row["QUANTITY"]);
            }
            pieChart.Series["Series1"].Points.AddXY("Tổng tiền dịch vụ", serviceSum);
            pieChart.Series["Series1"].Points.AddXY("Tổng tiền thuốc", drugSum);

            DataTable totalMR = MRM_Functions.getSqlData("SELECT COUNT(MEDICALRECORD_ID) AS TOTAL FROM MEDICALRECORD WHERE DATE BETWEEN '" + fromDate.Value.Date.ToString("yyyy/MM/dd") + "' AND '" + toDate.Value.Date.ToString("yyyy/MM/dd") + "'");
            DataTable totalPatient = MRM_Functions.getSqlData("SELECT COUNT(DISTINCT(PATIENT_ID)) FROM EXAMINE INNER JOIN " +
            "(SELECT EXAMINE_ID FROM MEDICALRECORD WHERE DATE BETWEEN '" +
            fromDate.Value.Date.ToString("yyyy/MM/dd") +
            "' AND '" + toDate.Value.Date.ToString("yyyy/MM/dd") + "') AS A ON EXAMINE.EXAMINE_ID = A.EXAMINE_ID");
            detail_totalMR_textBox.Text = totalMR.Rows[0]["TOTAL"].ToString();
            detail_totalPatient_textBox.Text = totalPatient.Rows[0][0].ToString();
            
            detail_totalPaid_textBox.Text = String.Format("{0:0,0}", serviceSum + drugSum);
            
            DataTable paymentStatus = MRM_Functions.getSqlData("SELECT COUNT(MEDICALRECORD_ID) AS TOTAL, PAYMENT_STATUS FROM MEDICALRECORD WHERE DATE BETWEEN '" +
                fromDate.Value.Date.ToString("yyyy/MM/dd") +
                "' AND '" + toDate.Value.Date.ToString("yyyy/MM/dd") +
                "' GROUP BY PAYMENT_STATUS");
            int paid = 0;
            int unpaid = 0;
            foreach (DataRow row in paymentStatus.Rows)
            {
                if (row["PAYMENT_STATUS"].ToString() == "0")
                {
                    unpaid += Convert.ToInt32(row["TOTAL"]);
                }
                else
                {
                    paid += Convert.ToInt32(row["TOTAL"]);
                }
            }
            detail_percentPaid_textBox.Text = String.Format("{0:0.00}", (double)paid / (double)(paid + unpaid) * 100) + "%";
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            dataLoad();
        }
    }
}
