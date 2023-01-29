namespace QuanLyPhongKham.GUI.CreateMedicalRecord
{
    partial class CMR_MainForm
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
            this.MainLayout_TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Prescription_GroupBox = new System.Windows.Forms.GroupBox();
            this.Prescription_TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Prescription_DataGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.D_AddDrugToList_Button = new System.Windows.Forms.Button();
            this.Service_GroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ServiceBill_DataGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.S_AddServiceToList_Button = new System.Windows.Forms.Button();
            this.Patient_GroupBox = new System.Windows.Forms.GroupBox();
            this.Patient_TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.P_DateOfBirth_Label = new System.Windows.Forms.Label();
            this.P_DateOfBirth_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.P_PhoneNumber_Label = new System.Windows.Forms.Label();
            this.P_PhoneNumber_TextBox = new System.Windows.Forms.TextBox();
            this.P_Address_Label = new System.Windows.Forms.Label();
            this.P_Address_TextBox = new System.Windows.Forms.TextBox();
            this.P_Name_Label = new System.Windows.Forms.Label();
            this.P_Name_TextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.SelectPatient_Button = new System.Windows.Forms.Button();
            this.AddPantient_Button = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.MainLayout_TableLayoutPanel.SuspendLayout();
            this.Prescription_GroupBox.SuspendLayout();
            this.Prescription_TableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Prescription_DataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.Service_GroupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceBill_DataGridView)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.Patient_GroupBox.SuspendLayout();
            this.Patient_TableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLayout_TableLayoutPanel
            // 
            this.MainLayout_TableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainLayout_TableLayoutPanel.ColumnCount = 2;
            this.MainLayout_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainLayout_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainLayout_TableLayoutPanel.Controls.Add(this.Prescription_GroupBox, 0, 1);
            this.MainLayout_TableLayoutPanel.Controls.Add(this.Service_GroupBox, 1, 1);
            this.MainLayout_TableLayoutPanel.Controls.Add(this.Patient_GroupBox, 0, 0);
            this.MainLayout_TableLayoutPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MainLayout_TableLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.MainLayout_TableLayoutPanel.Name = "MainLayout_TableLayoutPanel";
            this.MainLayout_TableLayoutPanel.RowCount = 2;
            this.MainLayout_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainLayout_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainLayout_TableLayoutPanel.Size = new System.Drawing.Size(1324, 851);
            this.MainLayout_TableLayoutPanel.TabIndex = 0;
            // 
            // Prescription_GroupBox
            // 
            this.Prescription_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Prescription_GroupBox.Controls.Add(this.Prescription_TableLayoutPanel);
            this.Prescription_GroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Prescription_GroupBox.Location = new System.Drawing.Point(3, 428);
            this.Prescription_GroupBox.Name = "Prescription_GroupBox";
            this.Prescription_GroupBox.Size = new System.Drawing.Size(656, 420);
            this.Prescription_GroupBox.TabIndex = 1;
            this.Prescription_GroupBox.TabStop = false;
            this.Prescription_GroupBox.Text = "Toa thuốc";
            // 
            // Prescription_TableLayoutPanel
            // 
            this.Prescription_TableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Prescription_TableLayoutPanel.ColumnCount = 1;
            this.Prescription_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Prescription_TableLayoutPanel.Controls.Add(this.Prescription_DataGridView, 0, 1);
            this.Prescription_TableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.Prescription_TableLayoutPanel.Location = new System.Drawing.Point(6, 34);
            this.Prescription_TableLayoutPanel.Name = "Prescription_TableLayoutPanel";
            this.Prescription_TableLayoutPanel.RowCount = 2;
            this.Prescription_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Prescription_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Prescription_TableLayoutPanel.Size = new System.Drawing.Size(644, 380);
            this.Prescription_TableLayoutPanel.TabIndex = 0;
            // 
            // Prescription_DataGridView
            // 
            this.Prescription_DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Prescription_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Prescription_DataGridView.Location = new System.Drawing.Point(3, 53);
            this.Prescription_DataGridView.Name = "Prescription_DataGridView";
            this.Prescription_DataGridView.RowHeadersWidth = 72;
            this.Prescription_DataGridView.RowTemplate.Height = 37;
            this.Prescription_DataGridView.Size = new System.Drawing.Size(638, 324);
            this.Prescription_DataGridView.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel1.Controls.Add(this.D_AddDrugToList_Button, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(638, 44);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // D_AddDrugToList_Button
            // 
            this.D_AddDrugToList_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.D_AddDrugToList_Button.Location = new System.Drawing.Point(465, 3);
            this.D_AddDrugToList_Button.Name = "D_AddDrugToList_Button";
            this.D_AddDrugToList_Button.Size = new System.Drawing.Size(170, 38);
            this.D_AddDrugToList_Button.TabIndex = 0;
            this.D_AddDrugToList_Button.Text = "Thêm thuốc";
            this.D_AddDrugToList_Button.UseVisualStyleBackColor = true;
            // 
            // Service_GroupBox
            // 
            this.Service_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Service_GroupBox.Controls.Add(this.tableLayoutPanel2);
            this.Service_GroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Service_GroupBox.Location = new System.Drawing.Point(665, 428);
            this.Service_GroupBox.Name = "Service_GroupBox";
            this.Service_GroupBox.Size = new System.Drawing.Size(656, 420);
            this.Service_GroupBox.TabIndex = 2;
            this.Service_GroupBox.TabStop = false;
            this.Service_GroupBox.Text = "Dịch vụ";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.ServiceBill_DataGridView, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 34);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(644, 380);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // ServiceBill_DataGridView
            // 
            this.ServiceBill_DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServiceBill_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServiceBill_DataGridView.Location = new System.Drawing.Point(3, 53);
            this.ServiceBill_DataGridView.Name = "ServiceBill_DataGridView";
            this.ServiceBill_DataGridView.RowHeadersWidth = 72;
            this.ServiceBill_DataGridView.RowTemplate.Height = 37;
            this.ServiceBill_DataGridView.Size = new System.Drawing.Size(638, 324);
            this.ServiceBill_DataGridView.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel3.Controls.Add(this.S_AddServiceToList_Button, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(638, 44);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // S_AddServiceToList_Button
            // 
            this.S_AddServiceToList_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.S_AddServiceToList_Button.Location = new System.Drawing.Point(465, 3);
            this.S_AddServiceToList_Button.Name = "S_AddServiceToList_Button";
            this.S_AddServiceToList_Button.Size = new System.Drawing.Size(170, 38);
            this.S_AddServiceToList_Button.TabIndex = 0;
            this.S_AddServiceToList_Button.Text = "Thêm dịch vụ";
            this.S_AddServiceToList_Button.UseVisualStyleBackColor = true;
            // 
            // Patient_GroupBox
            // 
            this.Patient_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Patient_GroupBox.Controls.Add(this.Patient_TableLayoutPanel);
            this.Patient_GroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Patient_GroupBox.Location = new System.Drawing.Point(3, 3);
            this.Patient_GroupBox.Name = "Patient_GroupBox";
            this.Patient_GroupBox.Size = new System.Drawing.Size(656, 419);
            this.Patient_GroupBox.TabIndex = 0;
            this.Patient_GroupBox.TabStop = false;
            this.Patient_GroupBox.Text = "Thông tin bệnh nhân";
            // 
            // Patient_TableLayoutPanel
            // 
            this.Patient_TableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Patient_TableLayoutPanel.ColumnCount = 2;
            this.Patient_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.31056F));
            this.Patient_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.68944F));
            this.Patient_TableLayoutPanel.Controls.Add(this.P_DateOfBirth_Label, 0, 4);
            this.Patient_TableLayoutPanel.Controls.Add(this.P_DateOfBirth_DateTimePicker, 1, 4);
            this.Patient_TableLayoutPanel.Controls.Add(this.P_PhoneNumber_Label, 0, 3);
            this.Patient_TableLayoutPanel.Controls.Add(this.P_PhoneNumber_TextBox, 1, 3);
            this.Patient_TableLayoutPanel.Controls.Add(this.P_Address_Label, 0, 2);
            this.Patient_TableLayoutPanel.Controls.Add(this.P_Address_TextBox, 1, 2);
            this.Patient_TableLayoutPanel.Controls.Add(this.P_Name_Label, 0, 1);
            this.Patient_TableLayoutPanel.Controls.Add(this.P_Name_TextBox, 1, 1);
            this.Patient_TableLayoutPanel.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.Patient_TableLayoutPanel.Location = new System.Drawing.Point(6, 34);
            this.Patient_TableLayoutPanel.Name = "Patient_TableLayoutPanel";
            this.Patient_TableLayoutPanel.RowCount = 5;
            this.Patient_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Patient_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Patient_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Patient_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Patient_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Patient_TableLayoutPanel.Size = new System.Drawing.Size(644, 379);
            this.Patient_TableLayoutPanel.TabIndex = 0;
            // 
            // P_DateOfBirth_Label
            // 
            this.P_DateOfBirth_Label.AutoSize = true;
            this.P_DateOfBirth_Label.Location = new System.Drawing.Point(3, 300);
            this.P_DateOfBirth_Label.Name = "P_DateOfBirth_Label";
            this.P_DateOfBirth_Label.Size = new System.Drawing.Size(108, 30);
            this.P_DateOfBirth_Label.TabIndex = 3;
            this.P_DateOfBirth_Label.Text = "Ngày sinh";
            // 
            // P_DateOfBirth_DateTimePicker
            // 
            this.P_DateOfBirth_DateTimePicker.Enabled = false;
            this.P_DateOfBirth_DateTimePicker.Location = new System.Drawing.Point(166, 303);
            this.P_DateOfBirth_DateTimePicker.Name = "P_DateOfBirth_DateTimePicker";
            this.P_DateOfBirth_DateTimePicker.Size = new System.Drawing.Size(475, 35);
            this.P_DateOfBirth_DateTimePicker.TabIndex = 7;
            // 
            // P_PhoneNumber_Label
            // 
            this.P_PhoneNumber_Label.AutoSize = true;
            this.P_PhoneNumber_Label.Location = new System.Drawing.Point(3, 225);
            this.P_PhoneNumber_Label.Name = "P_PhoneNumber_Label";
            this.P_PhoneNumber_Label.Size = new System.Drawing.Size(139, 30);
            this.P_PhoneNumber_Label.TabIndex = 2;
            this.P_PhoneNumber_Label.Text = "Số điện thoại";
            // 
            // P_PhoneNumber_TextBox
            // 
            this.P_PhoneNumber_TextBox.Enabled = false;
            this.P_PhoneNumber_TextBox.Location = new System.Drawing.Point(166, 228);
            this.P_PhoneNumber_TextBox.Name = "P_PhoneNumber_TextBox";
            this.P_PhoneNumber_TextBox.ReadOnly = true;
            this.P_PhoneNumber_TextBox.Size = new System.Drawing.Size(475, 35);
            this.P_PhoneNumber_TextBox.TabIndex = 6;
            // 
            // P_Address_Label
            // 
            this.P_Address_Label.AutoSize = true;
            this.P_Address_Label.Location = new System.Drawing.Point(3, 150);
            this.P_Address_Label.Name = "P_Address_Label";
            this.P_Address_Label.Size = new System.Drawing.Size(77, 30);
            this.P_Address_Label.TabIndex = 1;
            this.P_Address_Label.Text = "Địa chỉ";
            // 
            // P_Address_TextBox
            // 
            this.P_Address_TextBox.Enabled = false;
            this.P_Address_TextBox.Location = new System.Drawing.Point(166, 153);
            this.P_Address_TextBox.Name = "P_Address_TextBox";
            this.P_Address_TextBox.ReadOnly = true;
            this.P_Address_TextBox.Size = new System.Drawing.Size(475, 35);
            this.P_Address_TextBox.TabIndex = 5;
            // 
            // P_Name_Label
            // 
            this.P_Name_Label.AutoSize = true;
            this.P_Name_Label.Location = new System.Drawing.Point(3, 75);
            this.P_Name_Label.Name = "P_Name_Label";
            this.P_Name_Label.Size = new System.Drawing.Size(106, 30);
            this.P_Name_Label.TabIndex = 0;
            this.P_Name_Label.Text = "Họ và tên";
            // 
            // P_Name_TextBox
            // 
            this.P_Name_TextBox.Enabled = false;
            this.P_Name_TextBox.Location = new System.Drawing.Point(166, 78);
            this.P_Name_TextBox.Name = "P_Name_TextBox";
            this.P_Name_TextBox.ReadOnly = true;
            this.P_Name_TextBox.Size = new System.Drawing.Size(475, 35);
            this.P_Name_TextBox.TabIndex = 4;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.SelectPatient_Button, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.AddPantient_Button, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(166, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(475, 69);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // SelectPatient_Button
            // 
            this.SelectPatient_Button.Location = new System.Drawing.Point(3, 3);
            this.SelectPatient_Button.Name = "SelectPatient_Button";
            this.SelectPatient_Button.Size = new System.Drawing.Size(231, 40);
            this.SelectPatient_Button.TabIndex = 8;
            this.SelectPatient_Button.Text = "Chọn bệnh nhân";
            this.SelectPatient_Button.UseVisualStyleBackColor = true;
            this.SelectPatient_Button.Click += new System.EventHandler(this.SelectPatient_Button_Click);
            // 
            // AddPantient_Button
            // 
            this.AddPantient_Button.Location = new System.Drawing.Point(240, 3);
            this.AddPantient_Button.Name = "AddPantient_Button";
            this.AddPantient_Button.Size = new System.Drawing.Size(232, 40);
            this.AddPantient_Button.TabIndex = 9;
            this.AddPantient_Button.Text = "Thêm bệnh nhân";
            this.AddPantient_Button.UseVisualStyleBackColor = true;
            this.AddPantient_Button.Click += new System.EventHandler(this.AddPantient_Button_Click);
            // 
            // CMR_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1348, 875);
            this.Controls.Add(this.MainLayout_TableLayoutPanel);
            this.Name = "CMR_MainForm";
            this.Text = "CMR_MainForm";
            this.MainLayout_TableLayoutPanel.ResumeLayout(false);
            this.Prescription_GroupBox.ResumeLayout(false);
            this.Prescription_TableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Prescription_DataGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.Service_GroupBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ServiceBill_DataGridView)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.Patient_GroupBox.ResumeLayout(false);
            this.Patient_TableLayoutPanel.ResumeLayout(false);
            this.Patient_TableLayoutPanel.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel MainLayout_TableLayoutPanel;
        private GroupBox Patient_GroupBox;
        private TableLayoutPanel Patient_TableLayoutPanel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label P_Name_Label;
        private Label P_Address_Label;
        private Label P_PhoneNumber_Label;
        private Label P_DateOfBirth_Label;
        private TextBox P_Name_TextBox;
        private TextBox P_Address_TextBox;
        private TextBox P_PhoneNumber_TextBox;
        private DateTimePicker P_DateOfBirth_DateTimePicker;
        private GroupBox Prescription_GroupBox;
        private TableLayoutPanel Prescription_TableLayoutPanel;
        private Button D_AddDrugToList_Button;
        private DataGridView Prescription_DataGridView;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox Service_GroupBox;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView ServiceBill_DataGridView;
        private TableLayoutPanel tableLayoutPanel3;
        private Button S_AddServiceToList_Button;
        private TableLayoutPanel tableLayoutPanel4;
        private Button SelectPatient_Button;
        private Button AddPantient_Button;
    }
}