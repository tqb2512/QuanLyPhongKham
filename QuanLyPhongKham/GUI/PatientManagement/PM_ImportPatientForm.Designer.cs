namespace QuanLyPhongKham.GUI.PatientManagement
{
    partial class PM_ImportPatientForm
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
            this.buttonConfirmImportPatient = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxPatientID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxPatientName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxPatientPhone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxPatientAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dateTimePickerPatientDOB = new System.Windows.Forms.DateTimePicker();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConfirmImportPatient
            // 
            this.buttonConfirmImportPatient.Location = new System.Drawing.Point(191, 438);
            this.buttonConfirmImportPatient.Name = "buttonConfirmImportPatient";
            this.buttonConfirmImportPatient.Size = new System.Drawing.Size(146, 52);
            this.buttonConfirmImportPatient.TabIndex = 1;
            this.buttonConfirmImportPatient.Text = "Thêm thông tin";
            this.buttonConfirmImportPatient.UseVisualStyleBackColor = true;
            this.buttonConfirmImportPatient.Click += new System.EventHandler(this.buttonConfirmImportPatient_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxPatientID);
            this.panel1.Controls.Add(this.labelID);
            this.panel1.Location = new System.Drawing.Point(147, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 74);
            this.panel1.TabIndex = 2;
            // 
            // textBoxPatientID
            // 
            this.textBoxPatientID.Location = new System.Drawing.Point(15, 38);
            this.textBoxPatientID.Name = "textBoxPatientID";
            this.textBoxPatientID.Size = new System.Drawing.Size(282, 23);
            this.textBoxPatientID.TabIndex = 1;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(15, 9);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(78, 15);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID bệnh nhân";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxPatientName);
            this.panel2.Controls.Add(this.labelName);
            this.panel2.Location = new System.Drawing.Point(147, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 74);
            this.panel2.TabIndex = 3;
            // 
            // textBoxPatientName
            // 
            this.textBoxPatientName.Location = new System.Drawing.Point(15, 38);
            this.textBoxPatientName.Name = "textBoxPatientName";
            this.textBoxPatientName.Size = new System.Drawing.Size(282, 23);
            this.textBoxPatientName.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(15, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(58, 15);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Họ và tên";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBoxPatientPhone);
            this.panel3.Controls.Add(this.labelPhone);
            this.panel3.Location = new System.Drawing.Point(147, 172);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(314, 74);
            this.panel3.TabIndex = 3;
            // 
            // textBoxPatientPhone
            // 
            this.textBoxPatientPhone.Location = new System.Drawing.Point(15, 38);
            this.textBoxPatientPhone.Name = "textBoxPatientPhone";
            this.textBoxPatientPhone.Size = new System.Drawing.Size(282, 23);
            this.textBoxPatientPhone.TabIndex = 1;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(15, 9);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(61, 15);
            this.labelPhone.TabIndex = 0;
            this.labelPhone.Text = "Điện thoại";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textBoxPatientAddress);
            this.panel4.Controls.Add(this.labelAddress);
            this.panel4.Location = new System.Drawing.Point(147, 252);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(314, 74);
            this.panel4.TabIndex = 3;
            // 
            // textBoxPatientAddress
            // 
            this.textBoxPatientAddress.Location = new System.Drawing.Point(15, 38);
            this.textBoxPatientAddress.Name = "textBoxPatientAddress";
            this.textBoxPatientAddress.Size = new System.Drawing.Size(282, 23);
            this.textBoxPatientAddress.TabIndex = 1;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(15, 9);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(43, 15);
            this.labelAddress.TabIndex = 0;
            this.labelAddress.Text = "Địa chỉ";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dateTimePickerPatientDOB);
            this.panel5.Controls.Add(this.labelDateOfBirth);
            this.panel5.Location = new System.Drawing.Point(147, 332);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(314, 74);
            this.panel5.TabIndex = 3;
            // 
            // dateTimePickerPatientDOB
            // 
            this.dateTimePickerPatientDOB.Location = new System.Drawing.Point(15, 38);
            this.dateTimePickerPatientDOB.Name = "dateTimePickerPatientDOB";
            this.dateTimePickerPatientDOB.Size = new System.Drawing.Size(284, 23);
            this.dateTimePickerPatientDOB.TabIndex = 1;
            this.dateTimePickerPatientDOB.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Location = new System.Drawing.Point(15, 9);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(60, 15);
            this.labelDateOfBirth.TabIndex = 0;
            this.labelDateOfBirth.Text = "Ngày sinh";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button1);
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Location = new System.Drawing.Point(12, 53);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(108, 127);
            this.panel6.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 82);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PM_ImportPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 516);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonConfirmImportPatient);
            this.Name = "PM_ImportPatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImportPatientForm";
            this.Load += new System.EventHandler(this.ImportPatientForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button buttonConfirmImportPatient;
        private Panel panel1;
        private TextBox textBoxPatientID;
        private Label labelID;
        private Panel panel2;
        private TextBox textBoxPatientName;
        private Label labelName;
        private Panel panel3;
        private TextBox textBoxPatientPhone;
        private Label labelPhone;
        private Panel panel4;
        private TextBox textBoxPatientAddress;
        private Label labelAddress;
        private Panel panel5;
        private Label labelDateOfBirth;
        private Panel panel6;
        private Button button1;
        private PictureBox pictureBox1;
        private DateTimePicker dateTimePickerPatientDOB;
    }
}