﻿namespace QuanLyPhongKham.GUI.PatientManagement
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.delete_button = new Krypton.Toolkit.KryptonButton();
            this.PatientID = new System.Windows.Forms.Label();
            this.labelPatientName = new System.Windows.Forms.Label();
            this.labelPatientGender = new System.Windows.Forms.Label();
            this.P_ID_textBox = new System.Windows.Forms.TextBox();
            this.P_name_textBox = new System.Windows.Forms.TextBox();
            this.P_address_textBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.P_sex_ComboBox = new System.Windows.Forms.ComboBox();
            this.labelPatientBirthday = new System.Windows.Forms.Label();
            this.P_phonenumber_textBox = new System.Windows.Forms.TextBox();
            this.edit_button = new Krypton.Toolkit.KryptonButton();
            this.P_dateofbirth_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
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
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel3.Controls.Add(this.delete_button, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.PatientID, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelPatientName, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelPatientGender, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.P_ID_textBox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.P_name_textBox, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.P_address_textBox, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.P_sex_ComboBox, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.labelPatientBirthday, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.P_phonenumber_textBox, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.edit_button, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.P_dateofbirth_dateTimePicker, 1, 5);
            this.tableLayoutPanel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(9, 12);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 7;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(991, 567);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // delete_button
            // 
            this.delete_button.CornerRoundingRadius = -1F;
            this.delete_button.Location = new System.Drawing.Point(3, 343);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(90, 45);
            this.delete_button.TabIndex = 0;
            this.delete_button.Values.Text = "Xóa";
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
            // labelPatientName
            // 
            this.labelPatientName.AutoSize = true;
            this.labelPatientName.Location = new System.Drawing.Point(3, 85);
            this.labelPatientName.Name = "labelPatientName";
            this.labelPatientName.Size = new System.Drawing.Size(88, 15);
            this.labelPatientName.TabIndex = 1;
            this.labelPatientName.Text = "Tên bệnh nhân";
            // 
            // labelPatientGender
            // 
            this.labelPatientGender.AutoSize = true;
            this.labelPatientGender.Location = new System.Drawing.Point(3, 170);
            this.labelPatientGender.Name = "labelPatientGender";
            this.labelPatientGender.Size = new System.Drawing.Size(55, 15);
            this.labelPatientGender.TabIndex = 2;
            this.labelPatientGender.Text = "Giới tính";
            // 
            // P_ID_textBox
            // 
            this.P_ID_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.P_ID_textBox.Enabled = false;
            this.P_ID_textBox.Location = new System.Drawing.Point(201, 3);
            this.P_ID_textBox.Name = "P_ID_textBox";
            this.P_ID_textBox.Size = new System.Drawing.Size(787, 23);
            this.P_ID_textBox.TabIndex = 4;
            // 
            // P_name_textBox
            // 
            this.P_name_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.P_name_textBox.Enabled = false;
            this.P_name_textBox.Location = new System.Drawing.Point(201, 88);
            this.P_name_textBox.Name = "P_name_textBox";
            this.P_name_textBox.Size = new System.Drawing.Size(787, 23);
            this.P_name_textBox.TabIndex = 5;
            // 
            // P_address_textBox
            // 
            this.P_address_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.P_address_textBox.Enabled = false;
            this.P_address_textBox.Location = new System.Drawing.Point(201, 258);
            this.P_address_textBox.Name = "P_address_textBox";
            this.P_address_textBox.Size = new System.Drawing.Size(787, 23);
            this.P_address_textBox.TabIndex = 7;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel5.Location = new System.Drawing.Point(201, 513);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(787, 51);
            this.tableLayoutPanel5.TabIndex = 11;
            // 
            // P_sex_ComboBox
            // 
            this.P_sex_ComboBox.BackColor = System.Drawing.SystemColors.Control;
            this.P_sex_ComboBox.FormattingEnabled = true;
            this.P_sex_ComboBox.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.P_sex_ComboBox.Location = new System.Drawing.Point(201, 173);
            this.P_sex_ComboBox.Name = "P_sex_ComboBox";
            this.P_sex_ComboBox.Size = new System.Drawing.Size(71, 23);
            this.P_sex_ComboBox.TabIndex = 12;
            // 
            // labelPatientBirthday
            // 
            this.labelPatientBirthday.AutoSize = true;
            this.labelPatientBirthday.Location = new System.Drawing.Point(3, 425);
            this.labelPatientBirthday.Name = "labelPatientBirthday";
            this.labelPatientBirthday.Size = new System.Drawing.Size(60, 15);
            this.labelPatientBirthday.TabIndex = 2;
            this.labelPatientBirthday.Text = "Ngày sinh";
            // 
            // P_phonenumber_textBox
            // 
            this.P_phonenumber_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.P_phonenumber_textBox.Enabled = false;
            this.P_phonenumber_textBox.Location = new System.Drawing.Point(201, 343);
            this.P_phonenumber_textBox.Name = "P_phonenumber_textBox";
            this.P_phonenumber_textBox.Size = new System.Drawing.Size(787, 23);
            this.P_phonenumber_textBox.TabIndex = 8;
            // 
            // edit_button
            // 
            this.edit_button.CornerRoundingRadius = -1F;
            this.edit_button.Location = new System.Drawing.Point(3, 258);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(89, 45);
            this.edit_button.TabIndex = 1;
            this.edit_button.Values.Text = "Chỉnh sửa";
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // P_dateofbirth_dateTimePicker
            // 
            this.P_dateofbirth_dateTimePicker.CustomFormat = "MM/dd/yyyy";
            this.P_dateofbirth_dateTimePicker.Location = new System.Drawing.Point(201, 428);
            this.P_dateofbirth_dateTimePicker.Name = "P_dateofbirth_dateTimePicker";
            this.P_dateofbirth_dateTimePicker.Size = new System.Drawing.Size(270, 23);
            this.P_dateofbirth_dateTimePicker.TabIndex = 13;
            // 
            // PM_DetailPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 590);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "PM_DetailPatientForm";
            this.Text = "PM_DetailPatientForm";
            this.Load += new System.EventHandler(this.PM_DetailPatientForm_Load);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private TableLayoutPanel tableLayoutPanel7;
        public Krypton.Toolkit.KryptonButton kryptonButton1;
        public Krypton.Toolkit.KryptonButton kryptonButton2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label PatientID;
        private Label labelPatientName;
        private Label labelPatientGender;
        public TextBox P_ID_textBox;
        public TextBox P_name_textBox;
        public TextBox P_address_textBox;
        public TextBox P_phonenumber_textBox;
        private Label labelPatientBirthday;
        private TableLayoutPanel tableLayoutPanel5;
        public Krypton.Toolkit.KryptonButton edit_button;
        public Krypton.Toolkit.KryptonButton delete_button;
        public ComboBox P_sex_ComboBox;
        public DateTimePicker P_dateofbirth_dateTimePicker;
    }
}