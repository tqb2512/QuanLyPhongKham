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

namespace QuanLyPhongKham.GUI.EmployeeManagement
{
    public partial class EM_PanelForm : Form
    {
        public EM_PanelForm()
        {
            InitializeComponent();
        }

        EM_MainForm em_MainForm = new EM_MainForm();

        private void EM_PanelForm_Load(object sender, EventArgs e)
        {
            em_MainForm.TopLevel = false;
            em_MainForm.AutoScroll = true;
            em_MainForm.FormBorderStyle = FormBorderStyle.None;
            mainPanel.Panel1.Controls.Add(em_MainForm);
            em_MainForm.Dock = DockStyle.Fill;
            em_MainForm.Visible = true;
            em_MainForm.Show();
            em_MainForm.Employee_DataGridView.CellDoubleClick += new DataGridViewCellEventHandler(Employee_DataGridView_CellDoubleClick);
            em_MainForm.add_button.Click += new EventHandler(add_button_Click);
        }

        private void Employee_DataGridView_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                mainPanel.Panel2.Controls.Clear();
                int employeeID = Convert.ToInt32(em_MainForm.Employee_DataGridView.Rows[e.RowIndex].Cells[0].Value);
                EM_DetailEmployeeForm em_DetailEmployeeForm = new EM_DetailEmployeeForm(employeeID);
                em_DetailEmployeeForm.TopLevel = false;
                em_DetailEmployeeForm.AutoScroll = true;
                em_DetailEmployeeForm.FormBorderStyle = FormBorderStyle.None;
                mainPanel.Panel2.Controls.Add(em_DetailEmployeeForm);
                em_DetailEmployeeForm.Dock = DockStyle.Fill;
                em_DetailEmployeeForm.Visible = true;
                em_DetailEmployeeForm.Show();
                em_DetailEmployeeForm.editButton.Click += new EventHandler(refreshOn_Click);
                em_DetailEmployeeForm.deleteButton.Click += new EventHandler(refreshOn_Click);
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            mainPanel.Panel2.Controls.Clear();
            EM_DetailEmployeeForm em_DetailEmployeeForm = new EM_DetailEmployeeForm(EM_Functions.getMaxID("SELECT MAX(EMPLOYEE_ID) AS MAX FROM EMPLOYEE") + 1);
            em_DetailEmployeeForm.TopLevel = false;
            em_DetailEmployeeForm.AutoScroll = true;
            em_DetailEmployeeForm.FormBorderStyle = FormBorderStyle.None;
            mainPanel.Panel2.Controls.Add(em_DetailEmployeeForm);
            em_DetailEmployeeForm.Dock = DockStyle.Fill;
            em_DetailEmployeeForm.Visible = true;
            em_DetailEmployeeForm.Show();
            em_DetailEmployeeForm.editButton.Click += new EventHandler(refreshOn_Click);
            em_DetailEmployeeForm.deleteButton.Click += new EventHandler(refreshOn_Click);
        }

        private void refreshOn_Click(object sender, EventArgs e)
        {
            em_MainForm.dataLoad();
        }
    }
}
