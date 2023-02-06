namespace QuanLyPhongKham.GUI.MainForm
{
    partial class MF_ChangePasswordForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.confirm_button = new Krypton.Toolkit.KryptonButton();
            this.reEnter_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.reEnter_textBox = new System.Windows.Forms.TextBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.80933F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.16005F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.22129F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.80933F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.reEnter_label, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.password_label, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.reEnter_textBox, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.password_textBox, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(488, 159);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.confirm_button, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(187, 120);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(243, 36);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // confirm_button
            // 
            this.confirm_button.CornerRoundingRadius = -1F;
            this.confirm_button.Location = new System.Drawing.Point(124, 3);
            this.confirm_button.Name = "confirm_button";
            this.confirm_button.Size = new System.Drawing.Size(116, 30);
            this.confirm_button.TabIndex = 0;
            this.confirm_button.Values.Text = "Xác nhận";
            this.confirm_button.Click += new System.EventHandler(this.confirm_button_Click);
            // 
            // reEnter_label
            // 
            this.reEnter_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reEnter_label.AutoSize = true;
            this.reEnter_label.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reEnter_label.Location = new System.Drawing.Point(55, 78);
            this.reEnter_label.Name = "reEnter_label";
            this.reEnter_label.Size = new System.Drawing.Size(126, 39);
            this.reEnter_label.TabIndex = 2;
            this.reEnter_label.Text = "Nhập lại mật khẩu";
            this.reEnter_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // password_label
            // 
            this.password_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.password_label.Location = new System.Drawing.Point(55, 39);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(126, 39);
            this.password_label.TabIndex = 3;
            this.password_label.Text = "Mật khẩu";
            this.password_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // reEnter_textBox
            // 
            this.reEnter_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reEnter_textBox.Location = new System.Drawing.Point(187, 81);
            this.reEnter_textBox.Name = "reEnter_textBox";
            this.reEnter_textBox.PasswordChar = '*';
            this.reEnter_textBox.Size = new System.Drawing.Size(243, 23);
            this.reEnter_textBox.TabIndex = 1;
            // 
            // password_textBox
            // 
            this.password_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.password_textBox.Location = new System.Drawing.Point(187, 42);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.PasswordChar = '*';
            this.password_textBox.Size = new System.Drawing.Size(243, 23);
            this.password_textBox.TabIndex = 0;
            // 
            // MF_ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(514, 184);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "MF_ChangePasswordForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox reEnter_textBox;
        private TextBox password_textBox;
        private Label reEnter_label;
        private Label password_label;
        private TableLayoutPanel tableLayoutPanel2;
        private Krypton.Toolkit.KryptonButton confirm_button;
    }
}