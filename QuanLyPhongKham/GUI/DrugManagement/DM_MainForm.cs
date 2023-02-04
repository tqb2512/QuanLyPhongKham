using QuanLyPhongKham.Classes;
using QuanLyPhongKham.Function;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongKham.GUI.DrugManagement
{
    public partial class DM_MainForm : Form
    {
        public DM_MainForm()
        {
            InitializeComponent();
        }

        float idColumnWidth = 0.1f;
        float nameColumnWidth = 0.26f;
        float unitColumnWidth = 0.08f;
        float manufacturerColumnWidth = 0.26f;
        float priceColumnWidth = 0.1f;
        float typenameColumnWidth = 0.2f;

        Drug currentDrug = new Drug();

        public void dataLoad()
        {
            Drug_DataGridView.DataSource = DM_Functions.getSqlData("SELECT DRUG_ID, DRUG_NAME, DRUG_TYPE_NAME, DRUG_UNIT, DRUG_MANUFACTURER, DRUG_PRICE FROM DRUG FULL OUTER JOIN DRUG_TYPE ON DRUG_TYPE.DRUG_TYPE_ID = DRUG.DRUG_TYPE_ID ");
            Drug_DataGridView.Columns["DRUG_ID"].HeaderText = "ID Thuốc";
            Drug_DataGridView.Columns["DRUG_NAME"].HeaderText = "Tên thuốc";
            Drug_DataGridView.Columns["DRUG_TYPE_NAME"].HeaderText = "Tên loại thuốc";
            Drug_DataGridView.Columns["DRUG_UNIT"].HeaderText = "Đơn vị";
            Drug_DataGridView.Columns["DRUG_MANUFACTURER"].HeaderText = "Nơi sản xuất";
            Drug_DataGridView.Columns["DRUG_PRICE"].HeaderText = "Giá";
            Drug_DataGridView.Columns["DRUG_PRICE"].DefaultCellStyle.Format = "N0";


            Drug_DataGridView.Columns["DRUG_ID"].Width = (int)(Drug_DataGridView.Width * idColumnWidth);
            Drug_DataGridView.Columns["DRUG_NAME"].Width = (int)(Drug_DataGridView.Width * nameColumnWidth);
            Drug_DataGridView.Columns["DRUG_TYPE_NAME"].Width = (int)(Drug_DataGridView.Width * typenameColumnWidth);
            Drug_DataGridView.Columns["DRUG_UNIT"].Width = (int)(Drug_DataGridView.Width * unitColumnWidth);
            Drug_DataGridView.Columns["DRUG_MANUFACTURER"].Width = (int)(Drug_DataGridView.Width * manufacturerColumnWidth);
            Drug_DataGridView.Columns["DRUG_PRICE"].Width = (int)(Drug_DataGridView.Width * priceColumnWidth);

            Search_TableLayout.ColumnStyles[0].Width = (int)(Search_TableLayout.Width * idColumnWidth);
            Search_TableLayout.ColumnStyles[1].Width = (int)(Search_TableLayout.Width * nameColumnWidth);
            Search_TableLayout.ColumnStyles[2].Width = (int)(Search_TableLayout.Width * typenameColumnWidth);
            Search_TableLayout.ColumnStyles[3].Width = (int)(Search_TableLayout.Width * unitColumnWidth);
            Search_TableLayout.ColumnStyles[4].Width = (int)(Search_TableLayout.Width * manufacturerColumnWidth);
            Search_TableLayout.ColumnStyles[5].Width = (int)(Search_TableLayout.Width * priceColumnWidth);
        }

        private void DM_TestForm2_Load(object sender, EventArgs e)
        {
            dataLoad();

            DM_DrugID_TextBox.ReadOnly = true;
            DM_DrugName_TextBox.ReadOnly = true;
            DM_DrugTypeID_TextBox.ReadOnly = true;
            DM_DrugTypeName_ComboBox.Enabled = false;
            DM_DrugUnit_TextBox.ReadOnly = true;
            DM_DrugManufacturer_TextBox.ReadOnly = true;
            DM_DrugPrice_TextBox.ReadOnly = true;
            DM_DrugDescription_TextBox.ReadOnly = true;

            DM_DrugID_TextBox.Enabled = false;
            DM_DrugName_TextBox.Enabled = false;
            DM_DrugTypeID_TextBox.Enabled = false;
            DM_DrugUnit_TextBox.Enabled = false;
            DM_DrugManufacturer_TextBox.Enabled = false;
            DM_DrugPrice_TextBox.Enabled = false;
            DM_DrugDescription_TextBox.Enabled = false;

            this.SizeChanged += new System.EventHandler(this.DM_MainForm_SizeChanged);
        }

        private void DM_MainForm_SizeChanged(object sender, EventArgs e)
        {
            Drug_DataGridView.Columns["DRUG_ID"].Width = (int)(Drug_DataGridView.Width * idColumnWidth);
            Drug_DataGridView.Columns["DRUG_NAME"].Width = (int)(Drug_DataGridView.Width * nameColumnWidth);
            Drug_DataGridView.Columns["DRUG_TYPE_NAME"].Width = (int)(Drug_DataGridView.Width * typenameColumnWidth);
            Drug_DataGridView.Columns["DRUG_UNIT"].Width = (int)(Drug_DataGridView.Width * unitColumnWidth);
            Drug_DataGridView.Columns["DRUG_MANUFACTURER"].Width = (int)(Drug_DataGridView.Width * manufacturerColumnWidth);
            Drug_DataGridView.Columns["DRUG_PRICE"].Width = (int)(Drug_DataGridView.Width * priceColumnWidth);


            Search_TableLayout.ColumnStyles[0].Width = (int)(Search_TableLayout.Width * idColumnWidth);
            Search_TableLayout.ColumnStyles[1].Width = (int)(Search_TableLayout.Width * nameColumnWidth);
            Search_TableLayout.ColumnStyles[2].Width = (int)(Search_TableLayout.Width * typenameColumnWidth);
            Search_TableLayout.ColumnStyles[3].Width = (int)(Search_TableLayout.Width * unitColumnWidth);
            Search_TableLayout.ColumnStyles[4].Width = (int)(Search_TableLayout.Width * manufacturerColumnWidth);
            Search_TableLayout.ColumnStyles[5].Width = (int)(Search_TableLayout.Width * priceColumnWidth);
        }

        private void Drug_DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DM_editButton.Text = "Sửa";
                currentDrug = DM_Functions.getDetailDrug(Convert.ToInt32(Drug_DataGridView.Rows[e.RowIndex].Cells["DRUG_ID"].Value.ToString()));
                DM_DrugID_TextBox.Text = currentDrug.ID.ToString();
                DM_DrugName_TextBox.Text = currentDrug.Name.ToString();
                DM_DrugTypeID_TextBox.Text = currentDrug.TypeID.ToString();
                DM_DrugTypeName_ComboBox.Text = currentDrug.TypeName.ToString();
                DM_DrugUnit_TextBox.Text = currentDrug.Unit.ToString();
                DM_DrugManufacturer_TextBox.Text = currentDrug.Manufacturer;
                DM_DrugPrice_TextBox.Text = currentDrug.Price.ToString("N0");
                DM_DrugDescription_TextBox.Text = currentDrug.Description.ToString();

                DM_DrugID_TextBox.ReadOnly = true;
                DM_DrugName_TextBox.ReadOnly = true;
                DM_DrugTypeID_TextBox.ReadOnly = true;
                DM_DrugTypeName_ComboBox.Enabled = false;
                DM_DrugUnit_TextBox.ReadOnly = true;
                DM_DrugManufacturer_TextBox.ReadOnly = true;
                DM_DrugPrice_TextBox.ReadOnly = true;
                DM_DrugDescription_TextBox.ReadOnly = true;

                DM_DrugID_TextBox.Enabled = false;
                DM_DrugName_TextBox.Enabled = false;
                DM_DrugTypeID_TextBox.Enabled = false;
                DM_DrugUnit_TextBox.Enabled = false;
                DM_DrugManufacturer_TextBox.Enabled = false;
                DM_DrugPrice_TextBox.Enabled = false;
                DM_DrugDescription_TextBox.Enabled = false;
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (DM_Functions.checkPermission(Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["currentUserId"].ToString()), "EDIT_DRUG") == true)
            {
                DM_DrugID_TextBox.Text = Convert.ToString(DM_Functions.getMaxID() + 1);
                DM_DrugName_TextBox.Text = "";
                DM_DrugTypeName_ComboBox.Enabled = true;
                DM_DrugUnit_TextBox.Text = "";
                DM_DrugManufacturer_TextBox.Text = "";
                DM_DrugPrice_TextBox.Text = "";
                DM_DrugDescription_TextBox.Text = "";

                DM_DrugID_TextBox.Enabled = true;
                DM_DrugName_TextBox.Enabled = true;
                DM_DrugTypeID_TextBox.Enabled = false;
                DM_DrugUnit_TextBox.Enabled = true;
                DM_DrugManufacturer_TextBox.Enabled = true;
                DM_DrugPrice_TextBox.Enabled = true;
                DM_DrugDescription_TextBox.Enabled = true;

                DM_DrugID_TextBox.ReadOnly = false;
                DM_DrugName_TextBox.ReadOnly = false;
                DM_DrugTypeID_TextBox.ReadOnly = true;
                DM_DrugUnit_TextBox.ReadOnly = false;
                DM_DrugManufacturer_TextBox.ReadOnly = false;
                DM_DrugPrice_TextBox.ReadOnly = false;
                DM_DrugDescription_TextBox.ReadOnly = false;

                DM_editButton.Text = "Thêm";
            }
            else
            {
                MessageBox.Show("Bạn không có quyền thực hiện chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            dataLoad();
        }

        private void Search_textBox_TextChanged(object sender, EventArgs e)
        {
            string filter = "";
            foreach (Control control in Search_TableLayout.Controls)
            {
                if (control is TextBox)
                {
                    if (control.Text != "")
                    {
                        switch (control.Name)
                        {
                            case "idSearch_textBox":
                                filter += "CONVERT(DRUG_ID, System.String) LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "nameSearch_textBox":
                                filter += "CONVERT(DRUG_NAME, System.String) LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "typenameSearch_textBox":
                                filter += "CONVERT(DRUG_TYPE_NAME, System.String) LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "unitSearch_textBox":
                                filter += "CONVERT(DRUG_UNIT, System.String) LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "manufacturerSearch_textBox":
                                filter += "CONVERT(DRUG_MANUFACTURER, System.String) LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "priceSearch_textBox":
                                filter += "CONVERT(DRUG_PRICE, System.String) LIKE '%" + control.Text + "%' AND ";
                                break;
                        }
                    }
                }
            }
            if (filter != "")
            {
                filter = filter.Substring(0, filter.Length - 4);
                (Drug_DataGridView.DataSource as DataTable).DefaultView.RowFilter = filter;
            }
            else
            {
                (Drug_DataGridView.DataSource as DataTable).DefaultView.RowFilter = null;
            }
        }

        private void DM_DrugTypeName_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DM_DrugTypeID_TextBox.Text = (DM_DrugTypeName_ComboBox.FindStringExact(DM_DrugTypeName_ComboBox.Text) + 1).ToString();
        }

        private void DM_editButton_Click(object sender, EventArgs e)
        {
            if (DM_Functions.checkPermission(Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["currentUserId"].ToString()), "EDIT_DRUG") == true)
            {
                if (String.IsNullOrEmpty(DM_DrugID_TextBox.Text) || String.IsNullOrEmpty(DM_DrugName_TextBox.Text) || String.IsNullOrEmpty(DM_DrugTypeName_ComboBox.Text) || String.IsNullOrEmpty(DM_DrugUnit_TextBox.Text) || String.IsNullOrEmpty(DM_DrugManufacturer_TextBox.Text) || String.IsNullOrEmpty(DM_DrugPrice_TextBox.Text) || String.IsNullOrEmpty(DM_DrugDescription_TextBox.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (DM_DrugID_TextBox.Text != "")
                {
                    currentDrug.ID = Convert.ToInt32(DM_DrugID_TextBox.Text);
                }
                currentDrug.Name = DM_DrugName_TextBox.Text;
                if (DM_DrugTypeID_TextBox.Text != "")
                {
                    currentDrug.TypeID = Convert.ToInt32(DM_DrugTypeID_TextBox.Text);
                }
                currentDrug.TypeName = DM_DrugTypeName_ComboBox.Text;
                currentDrug.Unit = DM_DrugUnit_TextBox.Text;
                currentDrug.Manufacturer = DM_DrugManufacturer_TextBox.Text;
                if (DM_DrugPrice_TextBox.Text != "")
                {
                    currentDrug.Price = Convert.ToDecimal(DM_DrugPrice_TextBox.Text);
                }
                currentDrug.Description = DM_DrugDescription_TextBox.Text;

                if (DM_editButton.Text == "Thêm")
                {
                    if (DM_Functions.addDrug(currentDrug))
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DM_editButton.Text = "Sửa";

                        DM_DrugID_TextBox.ReadOnly = true;
                        DM_DrugName_TextBox.ReadOnly = true;
                        DM_DrugTypeID_TextBox.ReadOnly = true;
                        DM_DrugTypeName_ComboBox.Enabled = false;
                        DM_DrugUnit_TextBox.ReadOnly = true;
                        DM_DrugManufacturer_TextBox.ReadOnly = true;
                        DM_DrugPrice_TextBox.ReadOnly = true;
                        DM_DrugDescription_TextBox.ReadOnly = true;

                        DM_DrugID_TextBox.Enabled = false;
                        DM_DrugName_TextBox.Enabled = false;
                        DM_DrugTypeID_TextBox.Enabled = false;
                        DM_DrugUnit_TextBox.Enabled = false;
                        DM_DrugManufacturer_TextBox.Enabled = false;
                        DM_DrugPrice_TextBox.Enabled = false;
                        DM_DrugDescription_TextBox.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (DM_editButton.Text == "Lưu")
                {
                    if (DM_Functions.updateDrug(currentDrug))
                    {
                        MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        DM_editButton.Text = "Sửa";
                        DM_DrugID_TextBox.ReadOnly = true;
                        DM_DrugName_TextBox.ReadOnly = true;
                        DM_DrugTypeID_TextBox.ReadOnly = true;
                        DM_DrugTypeName_ComboBox.Enabled = false;
                        DM_DrugUnit_TextBox.ReadOnly = true;
                        DM_DrugManufacturer_TextBox.ReadOnly = true;
                        DM_DrugPrice_TextBox.ReadOnly = true;
                        DM_DrugDescription_TextBox.ReadOnly = true;

                        DM_DrugID_TextBox.Enabled = false;
                        DM_DrugName_TextBox.Enabled = false;
                        DM_DrugTypeID_TextBox.Enabled = false;
                        DM_DrugUnit_TextBox.Enabled = false;
                        DM_DrugManufacturer_TextBox.Enabled = false;
                        DM_DrugPrice_TextBox.Enabled = false;
                        DM_DrugDescription_TextBox.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (DM_DrugID_TextBox.Text != "")
                {
                    DM_editButton.Text = "Lưu";
                    DM_DrugName_TextBox.Enabled = true;
                    DM_DrugTypeID_TextBox.Enabled = false;
                    DM_DrugTypeName_ComboBox.Enabled = true;
                    DM_DrugUnit_TextBox.Enabled = true;
                    DM_DrugManufacturer_TextBox.Enabled = true;
                    DM_DrugPrice_TextBox.Enabled = true;
                    DM_DrugDescription_TextBox.Enabled = true;

                    DM_DrugName_TextBox.ReadOnly = false;
                    DM_DrugTypeID_TextBox.ReadOnly = true;
                    DM_DrugUnit_TextBox.ReadOnly = false;
                    DM_DrugManufacturer_TextBox.ReadOnly = false;
                    DM_DrugPrice_TextBox.ReadOnly = false;
                    DM_DrugDescription_TextBox.ReadOnly = false;
                }
                dataLoad();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền thực hiện chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DM_deleteButton_Click(object sender, EventArgs e)
        {
            if (DM_Functions.checkPermission(Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["currentUserId"].ToString()), "EDIT_DRUG") == true)
            {
                if (DM_DrugID_TextBox.Text != "" || DM_DrugID_TextBox.Text != Convert.ToString(DM_Functions.getMaxID()))
                {
                    if (DM_Functions.deleteDrug(Convert.ToInt32(DM_DrugID_TextBox.Text)) == true)
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DM_DrugID_TextBox.Text = "";
                        DM_DrugName_TextBox.Text = "";
                        DM_DrugTypeID_TextBox.Text = "";
                        DM_DrugTypeName_ComboBox.Text = "";
                        DM_DrugUnit_TextBox.Text = "";
                        DM_DrugManufacturer_TextBox.Text = "";
                        DM_DrugPrice_TextBox.Text = "";
                        DM_DrugDescription_TextBox.Text = "";
                        dataLoad();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }       
            }
            else
            {
                MessageBox.Show("Bạn không có quyền thực hiện chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DM_DrugTypeName_ComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
    }
}
