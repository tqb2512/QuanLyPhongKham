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

namespace QuanLyPhongKham.GUI.CreateMedicalRecord
{
    public partial class CMR_SelectDrugsForm : Form
    {
        public CMR_SelectDrugsForm()
        {
            InitializeComponent();
        }

        internal CMR_SelectDrugsForm(List<Drug> drug)
        {
            InitializeComponent();
            drugs = drug;
        }

        internal List<Drug> drugs;
        float D_ID_Width = 0.1f;
        float D_Name_Width = 0.3f;
        float D_Quantity_Width = 0.2f;
        float D_Unit_Width = 0.15f;
        float D_Price_Width = 0.25f;

        private void CMR_SelectDrugsForm_Load(object sender, EventArgs e)
        {
            DataTable drugsTable = CMR_Functions.getSqlData("SELECT DRUG_ID, DRUG_NAME, DRUG_PRICE, DRUG_UNIT FROM DRUG");
            drugsTable.Columns.Add("Quantity");
            foreach (DataRow row in drugsTable.Rows)
            {
                row["Quantity"] = "";
            }
            if (drugs != null)
            {
                foreach (Drug drug in drugs)
                {
                    foreach (DataRow row in drugsTable.Rows)
                    {
                        if (drug.ID == (int)row["DRUG_ID"])
                        {
                            row["Quantity"] = drug.Quantity;
                        }
                    }
                }
            }
            Drugs_DataGridView.DataSource = drugsTable;
            Drugs_DataGridView.Columns[0].HeaderText = "ID";
            Drugs_DataGridView.Columns[1].HeaderText = "Tên thuốc";
            Drugs_DataGridView.Columns[2].HeaderText = "Đơn giá";
            Drugs_DataGridView.Columns[3].HeaderText = "Đơn vị";
            Drugs_DataGridView.Columns[4].HeaderText = "Nhập SL";
            Drugs_DataGridView.Columns[2].DefaultCellStyle.Format = "N0";
            Drugs_DataGridView.Columns[0].Width = (int)(Drugs_DataGridView.Width * D_ID_Width);
            Drugs_DataGridView.Columns[1].Width = (int)(Drugs_DataGridView.Width * D_Name_Width);
            Drugs_DataGridView.Columns[2].Width = (int)(Drugs_DataGridView.Width * D_Price_Width);
            Drugs_DataGridView.Columns[3].Width = (int)(Drugs_DataGridView.Width * D_Unit_Width);
            Drugs_DataGridView.Columns[4].Width = (int)(Drugs_DataGridView.Width * D_Quantity_Width);
            search_tableLayout.ColumnStyles[0].Width = (int)(search_tableLayout.Width * D_ID_Width);
            search_tableLayout.ColumnStyles[1].Width = (int)(search_tableLayout.Width * D_Name_Width);
            search_tableLayout.ColumnStyles[2].Width = (int)(search_tableLayout.Width * D_Price_Width);
            search_tableLayout.ColumnStyles[3].Width = (int)(search_tableLayout.Width * D_Unit_Width);
            search_tableLayout.ColumnStyles[4].Width = (int)(search_tableLayout.Width * D_Quantity_Width);
            this.SizeChanged += new System.EventHandler(this.CMR_SelectDrugsForm_SizeChanged);
        }

        private void confirm_button_Click(object sender, EventArgs e)
        {
            drugs = new List<Drug>();
            foreach (DataGridViewRow row in Drugs_DataGridView.Rows)
            {
                if (row.Cells[4].Value != System.DBNull.Value && String.IsNullOrEmpty(row.Cells[4].Value.ToString()) == false && Convert.ToInt32(row.Cells[4].Value) * 1 != 0)
                {
                    Drug drug = new Drug();
                    drug.ID = (int)row.Cells[0].Value;
                    drug.Name = row.Cells[1].Value.ToString();
                    drug.Price = Convert.ToDecimal(row.Cells[2].Value);
                    drug.Unit = row.Cells[3].Value.ToString();
                    drug.Quantity = Convert.ToInt32(row.Cells[4].Value);
                    drugs.Add(drug);
                }
            }
            this.Close();
        }

        private void CMR_SelectDrugsForm_SizeChanged(object sender, EventArgs e)
        {
            Drugs_DataGridView.Columns[0].Width = (int)(Drugs_DataGridView.Width * D_ID_Width);
            Drugs_DataGridView.Columns[1].Width = (int)(Drugs_DataGridView.Width * D_Name_Width);
            Drugs_DataGridView.Columns[2].Width = (int)(Drugs_DataGridView.Width * D_Price_Width);
            Drugs_DataGridView.Columns[3].Width = (int)(Drugs_DataGridView.Width * D_Unit_Width);
            Drugs_DataGridView.Columns[4].Width = (int)(Drugs_DataGridView.Width * D_Quantity_Width);
            search_tableLayout.ColumnStyles[0].Width = (int)(search_tableLayout.Width * D_ID_Width);
            search_tableLayout.ColumnStyles[1].Width = (int)(search_tableLayout.Width * D_Name_Width);
            search_tableLayout.ColumnStyles[2].Width = (int)(search_tableLayout.Width * D_Price_Width);
            search_tableLayout.ColumnStyles[3].Width = (int)(search_tableLayout.Width * D_Unit_Width);
            search_tableLayout.ColumnStyles[4].Width = (int)(search_tableLayout.Width * D_Quantity_Width);
        }

        private void Drugs_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                Drugs_DataGridView.BeginEdit(true);
            }
        }

        private void Drugs_DataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridViewTextBoxEditingControl tb = e.Control as DataGridViewTextBoxEditingControl;
            if (tb != null)
            {
                tb.KeyPress += new KeyPressEventHandler(Drugs_DataGridView_KeyPress);
            }
            e.Control.KeyPress += new KeyPressEventHandler(Drugs_DataGridView_KeyPress);

        }

        private void Drugs_DataGridView_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber((char)e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete || e.KeyChar == (char)Keys.Enter))
            {
                e.Handled = true;
            }
        }
    }
}
