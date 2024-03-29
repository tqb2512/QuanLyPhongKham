﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyPhongKham.GUI.MainForm;
using QuanLyPhongKham.Function;
using Krypton.Toolkit.Suite.Extended.Common;

namespace QuanLyPhongKham.GUI.LoginForm
{
    public partial class LF_MainForm : Form
    {
        public LF_MainForm()
        {
            InitializeComponent();
        }

        private void confirm_button_Click(object sender, EventArgs e)
        {
            int userId = LF_Functions.loginAndGetID(userName_textBox.Text, password_textBox.Text);
            if (userId != -1)
            {
                System.Configuration.ConfigurationManager.AppSettings["currentUserId"] = userId.ToString();
                this.Hide();
                MF_MainForm form = new MF_MainForm(userId);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    this.Show();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void password_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                confirm_button.PerformClick();
            }
        }
    }
}
