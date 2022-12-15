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
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonImportPatient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEditPatient = new System.Windows.Forms.Button();
            this.buttonDetailPatient = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnPatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPatientAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPatientPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPatientDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxFindingPatient = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonSearchPatient = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonImportPatient);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.buttonEditPatient);
            this.panel2.Controls.Add(this.buttonDetailPatient);
            this.panel2.Location = new System.Drawing.Point(8, 11);
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
            this.label1.Location = new System.Drawing.Point(9, 22);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(434, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 31);
            this.button1.TabIndex = 20;
            this.button1.Text = "Chi tiết";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(8, 167);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(546, 273);
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
            this.dataGridView1.Location = new System.Drawing.Point(4, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(543, 262);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
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
            // textBoxFindingPatient
            // 
            this.textBoxFindingPatient.Location = new System.Drawing.Point(164, 98);
            this.textBoxFindingPatient.Name = "textBoxFindingPatient";
            this.textBoxFindingPatient.Size = new System.Drawing.Size(318, 23);
            this.textBoxFindingPatient.TabIndex = 3;
            this.textBoxFindingPatient.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.textBoxFindingPatient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFindingPatient_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "Nhập thông tin tìm kiếm";
            // 
            // buttonSearchPatient
            // 
            this.buttonSearchPatient.Location = new System.Drawing.Point(488, 99);
            this.buttonSearchPatient.Name = "buttonSearchPatient";
            this.buttonSearchPatient.Size = new System.Drawing.Size(56, 23);
            this.buttonSearchPatient.TabIndex = 6;
            this.buttonSearchPatient.Text = "Tìm";
            this.buttonSearchPatient.UseVisualStyleBackColor = true;
            this.buttonSearchPatient.Click += new System.EventHandler(this.buttonFindPatient_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(164, 130);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(264, 31);
            this.textBox1.TabIndex = 21;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "ID đang chọn";
            // 
            // PM_ShowPatientListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 452);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonSearchPatient);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxFindingPatient);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "PM_ShowPatientListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowPatientListForm";
            this.Load += new System.EventHandler(this.PM_ShowPatientListForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Button buttonEditPatient;
        private Button buttonDetailPatient;
        private DataGridView dataGridView1;
        private Button buttonImportPatient;
        private DataGridViewTextBoxColumn ColumnPatientID;
        private DataGridViewTextBoxColumn ColumnPatientName;
        private DataGridViewTextBoxColumn ColumnPatientAddress;
        private DataGridViewTextBoxColumn ColumnPatientPhone;
        private DataGridViewTextBoxColumn ColumnPatientDOB;
        private TextBox textBoxFindingPatient;
        private Label label8;
        private Button buttonSearchPatient;
        private Button button1;
        private TextBox textBox1;
        private Label label2;
    }
}