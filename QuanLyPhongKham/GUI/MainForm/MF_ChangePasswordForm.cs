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
using System.Security.Cryptography;

namespace QuanLyPhongKham.GUI.MainForm
{
    public partial class MF_ChangePasswordForm : Form
    {
        public MF_ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void confirm_button_Click(object sender, EventArgs e)
        {
            if (password_textBox.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
            if (password_textBox.Text == reEnter_textBox.Text)
            {
                byte[] temp = ASCIIEncoding.ASCII.GetBytes(password_textBox.Text);
                byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
                string hasPass = "";
                foreach (byte item in hasData)
                {
                    hasPass += item;
                }
                string query = "UPDATE EMPLOYEE SET PASSWORD = '" + hasPass + "' WHERE EMPLOYEE_ID = " + System.Configuration.ConfigurationManager.AppSettings["currentUserId"];
                SqlConnection sqlConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                int result = (int)sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                if (result == 1)
                {
                    MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu không khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
