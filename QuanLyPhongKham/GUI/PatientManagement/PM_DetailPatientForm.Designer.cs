namespace QuanLyPhongKham.GUI.PatientManagement
{
    partial class PM_DetailPatientForm
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
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            this.kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.PatientID = new System.Windows.Forms.Label();
            this.edit_button = new Krypton.Toolkit.KryptonButton();
            this.labelPatientName = new System.Windows.Forms.Label();
            this.labelPatientGender = new System.Windows.Forms.Label();
            this.labelPatientAddress = new System.Windows.Forms.Label();
            this.P_ID_textBox = new System.Windows.Forms.TextBox();
            this.P_name_textBox = new System.Windows.Forms.TextBox();
            this.P_sex_textBox = new System.Windows.Forms.TextBox();
            this.P_address_textBox = new System.Windows.Forms.TextBox();
            this.P_phonenumber_textBox = new System.Windows.Forms.TextBox();
            this.delete_button = new Krypton.Toolkit.KryptonButton();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.labelPatientBirthday = new System.Windows.Forms.Label();
            this.P_dateofbirth_textBox = new System.Windows.Forms.TextBox();
            this.labelPatientPhoneNumber = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.kryptonButton1, 0, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.CornerRoundingRadius = -1F;
            this.kryptonButton1.Location = new System.Drawing.Point(3, 3);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(94, 60);
            this.kryptonButton1.TabIndex = 0;
            this.kryptonButton1.Values.Text = "Xóa";
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.CornerRoundingRadius = -1F;
            this.kryptonButton2.Location = new System.Drawing.Point(103, 3);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(94, 60);
            this.kryptonButton2.TabIndex = 1;
            this.kryptonButton2.Values.Text = "Chỉnh sửa";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.31615F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.68385F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(925, 582);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel3.Controls.Add(this.PatientID, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.P_dateofbirth_textBox, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.labelPatientName, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelPatientGender, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.labelPatientAddress, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.P_ID_textBox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.P_name_textBox, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.P_sex_textBox, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.P_address_textBox, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.P_phonenumber_textBox, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.labelPatientBirthday, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.labelPatientPhoneNumber, 0, 4);
            this.tableLayoutPanel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.77341F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.07553F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.67976F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.4713F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(919, 507);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // PatientID
            // 
            this.PatientID.AutoSize = true;
            this.PatientID.Location = new System.Drawing.Point(3, 0);
            this.PatientID.Name = "PatientID";
            this.PatientID.Size = new System.Drawing.Size(81, 15);
            this.PatientID.TabIndex = 0;
            this.PatientID.Text = "ID bệnh nhân";
            // 
            // edit_button
            // 
            this.edit_button.CornerRoundingRadius = -1F;
            this.edit_button.Location = new System.Drawing.Point(722, 3);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(92, 50);
            this.edit_button.TabIndex = 1;
            this.edit_button.Values.Text = "Chỉnh sửa";
            // 
            // labelPatientName
            // 
            this.labelPatientName.AutoSize = true;
            this.labelPatientName.Location = new System.Drawing.Point(3, 83);
            this.labelPatientName.Name = "labelPatientName";
            this.labelPatientName.Size = new System.Drawing.Size(88, 15);
            this.labelPatientName.TabIndex = 1;
            this.labelPatientName.Text = "Tên bệnh nhân";
            // 
            // labelPatientGender
            // 
            this.labelPatientGender.AutoSize = true;
            this.labelPatientGender.Location = new System.Drawing.Point(3, 167);
            this.labelPatientGender.Name = "labelPatientGender";
            this.labelPatientGender.Size = new System.Drawing.Size(55, 15);
            this.labelPatientGender.TabIndex = 2;
            this.labelPatientGender.Text = "Giới tính";
            // 
            // labelPatientAddress
            // 
            this.labelPatientAddress.AutoSize = true;
            this.labelPatientAddress.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.labelPatientAddress.Location = new System.Drawing.Point(3, 253);
            this.labelPatientAddress.Name = "labelPatientAddress";
            this.labelPatientAddress.Size = new System.Drawing.Size(44, 15);
            this.labelPatientAddress.TabIndex = 3;
            this.labelPatientAddress.Text = "Địa chỉ";
            // 
            // P_ID_textBox
            // 
            this.P_ID_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.P_ID_textBox.Enabled = false;
            this.P_ID_textBox.Location = new System.Drawing.Point(232, 3);
            this.P_ID_textBox.Name = "P_ID_textBox";
            this.P_ID_textBox.Size = new System.Drawing.Size(684, 23);
            this.P_ID_textBox.TabIndex = 4;
            // 
            // P_name_textBox
            // 
            this.P_name_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.P_name_textBox.Enabled = false;
            this.P_name_textBox.Location = new System.Drawing.Point(232, 86);
            this.P_name_textBox.Name = "P_name_textBox";
            this.P_name_textBox.Size = new System.Drawing.Size(684, 23);
            this.P_name_textBox.TabIndex = 5;
            // 
            // P_sex_textBox
            // 
            this.P_sex_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.P_sex_textBox.Enabled = false;
            this.P_sex_textBox.Location = new System.Drawing.Point(232, 170);
            this.P_sex_textBox.Name = "P_sex_textBox";
            this.P_sex_textBox.Size = new System.Drawing.Size(684, 23);
            this.P_sex_textBox.TabIndex = 6;
            // 
            // P_address_textBox
            // 
            this.P_address_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.P_address_textBox.Enabled = false;
            this.P_address_textBox.Location = new System.Drawing.Point(232, 256);
            this.P_address_textBox.Name = "P_address_textBox";
            this.P_address_textBox.Size = new System.Drawing.Size(684, 23);
            this.P_address_textBox.TabIndex = 7;
            // 
            // P_phonenumber_textBox
            // 
            this.P_phonenumber_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.P_phonenumber_textBox.Enabled = false;
            this.P_phonenumber_textBox.Location = new System.Drawing.Point(232, 426);
            this.P_phonenumber_textBox.Name = "P_phonenumber_textBox";
            this.P_phonenumber_textBox.Size = new System.Drawing.Size(684, 23);
            this.P_phonenumber_textBox.TabIndex = 8;
            // 
            // delete_button
            // 
            this.delete_button.CornerRoundingRadius = -1F;
            this.delete_button.Location = new System.Drawing.Point(820, 3);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(90, 50);
            this.delete_button.TabIndex = 0;
            this.delete_button.Values.Text = "Xóa";
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.25245F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 516);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(919, 63);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.41354F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.58647F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel5.Controls.Add(this.edit_button, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.delete_button, 3, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(913, 57);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // labelPatientBirthday
            // 
            this.labelPatientBirthday.AutoSize = true;
            this.labelPatientBirthday.Location = new System.Drawing.Point(3, 423);
            this.labelPatientBirthday.Name = "labelPatientBirthday";
            this.labelPatientBirthday.Size = new System.Drawing.Size(60, 15);
            this.labelPatientBirthday.TabIndex = 2;
            this.labelPatientBirthday.Text = "Ngày sinh";
            // 
            // P_dateofbirth_textBox
            // 
            this.P_dateofbirth_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.P_dateofbirth_textBox.Enabled = false;
            this.P_dateofbirth_textBox.Location = new System.Drawing.Point(232, 338);
            this.P_dateofbirth_textBox.Name = "P_dateofbirth_textBox";
            this.P_dateofbirth_textBox.Size = new System.Drawing.Size(684, 23);
            this.P_dateofbirth_textBox.TabIndex = 9;
            // 
            // labelPatientPhoneNumber
            // 
            this.labelPatientPhoneNumber.AutoSize = true;
            this.labelPatientPhoneNumber.Location = new System.Drawing.Point(3, 335);
            this.labelPatientPhoneNumber.Name = "labelPatientPhoneNumber";
            this.labelPatientPhoneNumber.Size = new System.Drawing.Size(80, 15);
            this.labelPatientPhoneNumber.TabIndex = 0;
            this.labelPatientPhoneNumber.Text = "Số điện thoại";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(931, 596);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // PM_DetailPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 607);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PM_DetailPatientForm";
            this.Text = "PM_DetailPatientForm";
            this.Load += new System.EventHandler(this.PM_DetailPatientForm_Load);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private TableLayoutPanel tableLayoutPanel7;
        public Krypton.Toolkit.KryptonButton kryptonButton1;
        public Krypton.Toolkit.KryptonButton kryptonButton2;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label PatientID;
        private Label labelPatientName;
        private Label labelPatientGender;
        private Label labelPatientAddress;
        public TextBox P_ID_textBox;
        public TextBox P_name_textBox;
        public TextBox P_sex_textBox;
        public TextBox P_address_textBox;
        private TableLayoutPanel tableLayoutPanel1;
        public TextBox P_dateofbirth_textBox;
        private Label labelPatientBirthday;
        public TextBox P_phonenumber_textBox;
        private Label labelPatientPhoneNumber;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        public Krypton.Toolkit.KryptonButton edit_button;
        public Krypton.Toolkit.KryptonButton delete_button;
    }
}