namespace QuanLyPhongKham.GUI.PatientManagement
{
    partial class PM_ShowPatientListForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDeletePatient = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonImportPatient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEditPatient = new System.Windows.Forms.Button();
            this.buttonDetailPatient = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnPatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPatientAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPatientPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPatientDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonDeletePatient);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Location = new System.Drawing.Point(3, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 390);
            this.panel1.TabIndex = 0;
            // 
            // buttonDeletePatient
            // 
            this.buttonDeletePatient.Location = new System.Drawing.Point(101, 322);
            this.buttonDeletePatient.Name = "buttonDeletePatient";
            this.buttonDeletePatient.Size = new System.Drawing.Size(105, 42);
            this.buttonDeletePatient.TabIndex = 3;
            this.buttonDeletePatient.Text = "Xóa thông tin";
            this.buttonDeletePatient.UseVisualStyleBackColor = true;
            this.buttonDeletePatient.Click += new System.EventHandler(this.buttonDeletePatient_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Chi tiết bệnh nhân";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Chi tiết";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(76, 265);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(207, 23);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Ngày sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "ID ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Điện thoại";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 23);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Địa chỉ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(76, 142);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(193, 23);
            this.textBox2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Họ tên";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(76, 183);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(193, 23);
            this.textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(76, 224);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(193, 23);
            this.textBox4.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonImportPatient);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.buttonEditPatient);
            this.panel2.Controls.Add(this.buttonDetailPatient);
            this.panel2.Location = new System.Drawing.Point(311, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(546, 76);
            this.panel2.TabIndex = 1;
            // 
            // buttonImportPatient
            // 
            this.buttonImportPatient.Location = new System.Drawing.Point(358, 22);
            this.buttonImportPatient.Name = "buttonImportPatient";
            this.buttonImportPatient.Size = new System.Drawing.Size(102, 42);
            this.buttonImportPatient.TabIndex = 5;
            this.buttonImportPatient.Text = "Thêm thông tin";
            this.buttonImportPatient.UseVisualStyleBackColor = true;
            this.buttonImportPatient.Click += new System.EventHandler(this.buttonImportPatient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(41, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Danh sách bệnh nhân";
            // 
            // buttonEditPatient
            // 
            this.buttonEditPatient.Location = new System.Drawing.Point(466, 22);
            this.buttonEditPatient.Name = "buttonEditPatient";
            this.buttonEditPatient.Size = new System.Drawing.Size(70, 42);
            this.buttonEditPatient.TabIndex = 2;
            this.buttonEditPatient.Text = "Sửa đổi";
            this.buttonEditPatient.UseVisualStyleBackColor = true;
            this.buttonEditPatient.Click += new System.EventHandler(this.buttonEditPatient_Click);
            // 
            // buttonDetailPatient
            // 
            this.buttonDetailPatient.Location = new System.Drawing.Point(282, 22);
            this.buttonDetailPatient.Name = "buttonDetailPatient";
            this.buttonDetailPatient.Size = new System.Drawing.Size(70, 42);
            this.buttonDetailPatient.TabIndex = 1;
            this.buttonDetailPatient.Text = "Tải lại";
            this.buttonDetailPatient.UseVisualStyleBackColor = true;
            this.buttonDetailPatient.Click += new System.EventHandler(this.buttonDetailPatient_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(311, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(546, 308);
            this.panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPatientID,
            this.ColumnPatientName,
            this.ColumnPatientAddress,
            this.ColumnPatientPhone,
            this.ColumnPatientDOB});
            this.dataGridView1.Location = new System.Drawing.Point(0, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(543, 300);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // ColumnPatientID
            // 
            this.ColumnPatientID.DataPropertyName = "PATIENT_ID";
            this.ColumnPatientID.HeaderText = "ID";
            this.ColumnPatientID.Name = "ColumnPatientID";
            this.ColumnPatientID.ReadOnly = true;
            // 
            // ColumnPatientName
            // 
            this.ColumnPatientName.DataPropertyName = "PATIENT_NAME";
            this.ColumnPatientName.HeaderText = "Họ tên";
            this.ColumnPatientName.Name = "ColumnPatientName";
            this.ColumnPatientName.ReadOnly = true;
            // 
            // ColumnPatientAddress
            // 
            this.ColumnPatientAddress.DataPropertyName = "PATIENT_ADDRESS";
            this.ColumnPatientAddress.HeaderText = "Địa chỉ";
            this.ColumnPatientAddress.Name = "ColumnPatientAddress";
            this.ColumnPatientAddress.ReadOnly = true;
            // 
            // ColumnPatientPhone
            // 
            this.ColumnPatientPhone.DataPropertyName = "PATIENT_PHONENUMBER";
            this.ColumnPatientPhone.HeaderText = "Điện thoại";
            this.ColumnPatientPhone.Name = "ColumnPatientPhone";
            this.ColumnPatientPhone.ReadOnly = true;
            // 
            // ColumnPatientDOB
            // 
            this.ColumnPatientDOB.DataPropertyName = "PATIENT_DATEOFBIRTH";
            this.ColumnPatientDOB.HeaderText = "Ngày sinh";
            this.ColumnPatientDOB.Name = "ColumnPatientDOB";
            this.ColumnPatientDOB.ReadOnly = true;
            // 
            // PM_ShowPatientListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 399);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PM_ShowPatientListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowPatientListForm";
            this.Load += new System.EventHandler(this.PM_ShowPatientListForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Button buttonDeletePatient;
        private Button buttonEditPatient;
        private Button buttonDetailPatient;
        private DataGridView dataGridView1;
        private Button buttonImportPatient;
        private DataGridViewTextBoxColumn ColumnPatientID;
        private DataGridViewTextBoxColumn ColumnPatientName;
        private DataGridViewTextBoxColumn ColumnPatientAddress;
        private DataGridViewTextBoxColumn ColumnPatientPhone;
        private DataGridViewTextBoxColumn ColumnPatientDOB;
        private Label label6;
        private Label label2;
        private Label label5;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private TextBox textBox4;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Label label7;
    }
}