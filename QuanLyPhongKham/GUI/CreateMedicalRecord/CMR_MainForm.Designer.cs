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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.D_AddDrugToList_Button = new System.Windows.Forms.Button();
            this.Prescription_DataGridView = new Krypton.Toolkit.KryptonDataGridView();
            this.Service_GroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.S_AddServiceToList_Button = new System.Windows.Forms.Button();
            this.ServiceBill_DataGridView = new Krypton.Toolkit.KryptonDataGridView();
            this.Patient_GroupBox = new System.Windows.Forms.GroupBox();
            this.Patient_TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.P_DateOfBirth_Label = new System.Windows.Forms.Label();
            this.P_DateOfBirth_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.P_PhoneNumber_Label = new System.Windows.Forms.Label();
            this.P_Address_Label = new System.Windows.Forms.Label();
            this.P_Name_Label = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.SelectPatient_Button = new System.Windows.Forms.Button();
            this.AddPantient_Button = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.MR_pTemp_TextBox = new System.Windows.Forms.TextBox();
            this.MR_pWeight_TextBox = new System.Windows.Forms.TextBox();
            this.MR_pWeight_label = new System.Windows.Forms.Label();
            this.MR_pTemp_Label = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.P_PhoneNumber_TextBox = new System.Windows.Forms.TextBox();
            this.P_Sex_Label = new System.Windows.Forms.Label();
            this.P_Sex_TextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.P_Address_TextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.P_Name_TextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.MR_diagnosis_groupBox = new System.Windows.Forms.GroupBox();
            this.MR_diagnosis_richTextBox = new System.Windows.Forms.RichTextBox();
            this.MR_note_groupBox = new System.Windows.Forms.GroupBox();
            this.MR_note_richTextBox = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.confirm_Button = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.MainLayout_TableLayoutPanel.SuspendLayout();
            this.Prescription_GroupBox.SuspendLayout();
            this.Prescription_TableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Prescription_DataGridView)).BeginInit();
            this.Service_GroupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceBill_DataGridView)).BeginInit();
            this.Patient_GroupBox.SuspendLayout();
            this.Patient_TableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.MR_diagnosis_groupBox.SuspendLayout();
            this.MR_note_groupBox.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
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
            this.MainLayout_TableLayoutPanel.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.MainLayout_TableLayoutPanel.Controls.Add(this.tableLayoutPanel10, 1, 2);
            this.MainLayout_TableLayoutPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MainLayout_TableLayoutPanel.Location = new System.Drawing.Point(13, 12);
            this.MainLayout_TableLayoutPanel.Name = "MainLayout_TableLayoutPanel";
            this.MainLayout_TableLayoutPanel.RowCount = 3;
            this.MainLayout_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainLayout_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainLayout_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.MainLayout_TableLayoutPanel.Size = new System.Drawing.Size(1434, 879);
            this.MainLayout_TableLayoutPanel.TabIndex = 0;
            // 
            // Prescription_GroupBox
            // 
            this.Prescription_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Prescription_GroupBox.Controls.Add(this.Prescription_TableLayoutPanel);
            this.Prescription_GroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Prescription_GroupBox.Location = new System.Drawing.Point(3, 412);
            this.Prescription_GroupBox.Name = "Prescription_GroupBox";
            this.Prescription_GroupBox.Size = new System.Drawing.Size(711, 403);
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
            this.Prescription_TableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.Prescription_TableLayoutPanel.Controls.Add(this.Prescription_DataGridView, 0, 1);
            this.Prescription_TableLayoutPanel.Location = new System.Drawing.Point(6, 35);
            this.Prescription_TableLayoutPanel.Name = "Prescription_TableLayoutPanel";
            this.Prescription_TableLayoutPanel.RowCount = 2;
            this.Prescription_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.Prescription_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Prescription_TableLayoutPanel.Size = new System.Drawing.Size(698, 362);
            this.Prescription_TableLayoutPanel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tableLayoutPanel1.Controls.Add(this.D_AddDrugToList_Button, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(692, 54);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // D_AddDrugToList_Button
            // 
            this.D_AddDrugToList_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.D_AddDrugToList_Button.Location = new System.Drawing.Point(505, 3);
            this.D_AddDrugToList_Button.Name = "D_AddDrugToList_Button";
            this.D_AddDrugToList_Button.Size = new System.Drawing.Size(184, 48);
            this.D_AddDrugToList_Button.TabIndex = 0;
            this.D_AddDrugToList_Button.Text = "Thêm thuốc";
            this.D_AddDrugToList_Button.UseVisualStyleBackColor = true;
            // 
            // Prescription_DataGridView
            // 
            this.Prescription_DataGridView.AllowUserToAddRows = false;
            this.Prescription_DataGridView.AllowUserToDeleteRows = false;
            this.Prescription_DataGridView.AllowUserToResizeColumns = false;
            this.Prescription_DataGridView.AllowUserToResizeRows = false;
            this.Prescription_DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Prescription_DataGridView.ColumnHeadersHeight = 70;
            this.Prescription_DataGridView.Location = new System.Drawing.Point(3, 63);
            this.Prescription_DataGridView.Name = "Prescription_DataGridView";
            this.Prescription_DataGridView.RowHeadersVisible = false;
            this.Prescription_DataGridView.RowHeadersWidth = 72;
            this.Prescription_DataGridView.RowTemplate.Height = 37;
            this.Prescription_DataGridView.Size = new System.Drawing.Size(692, 296);
            this.Prescription_DataGridView.TabIndex = 3;
            // 
            // Service_GroupBox
            // 
            this.Service_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Service_GroupBox.Controls.Add(this.tableLayoutPanel2);
            this.Service_GroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Service_GroupBox.Location = new System.Drawing.Point(720, 412);
            this.Service_GroupBox.Name = "Service_GroupBox";
            this.Service_GroupBox.Size = new System.Drawing.Size(711, 403);
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
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ServiceBill_DataGridView, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 35);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(698, 362);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tableLayoutPanel3.Controls.Add(this.S_AddServiceToList_Button, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(692, 54);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // S_AddServiceToList_Button
            // 
            this.S_AddServiceToList_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.S_AddServiceToList_Button.Location = new System.Drawing.Point(505, 3);
            this.S_AddServiceToList_Button.Name = "S_AddServiceToList_Button";
            this.S_AddServiceToList_Button.Size = new System.Drawing.Size(184, 48);
            this.S_AddServiceToList_Button.TabIndex = 0;
            this.S_AddServiceToList_Button.Text = "Thêm dịch vụ";
            this.S_AddServiceToList_Button.UseVisualStyleBackColor = true;
            // 
            // ServiceBill_DataGridView
            // 
            this.ServiceBill_DataGridView.AllowUserToAddRows = false;
            this.ServiceBill_DataGridView.AllowUserToDeleteRows = false;
            this.ServiceBill_DataGridView.AllowUserToResizeColumns = false;
            this.ServiceBill_DataGridView.AllowUserToResizeRows = false;
            this.ServiceBill_DataGridView.ColumnHeadersHeight = 70;
            this.ServiceBill_DataGridView.Location = new System.Drawing.Point(3, 63);
            this.ServiceBill_DataGridView.Name = "ServiceBill_DataGridView";
            this.ServiceBill_DataGridView.RowHeadersVisible = false;
            this.ServiceBill_DataGridView.RowHeadersWidth = 72;
            this.ServiceBill_DataGridView.RowTemplate.Height = 37;
            this.ServiceBill_DataGridView.Size = new System.Drawing.Size(692, 296);
            this.ServiceBill_DataGridView.TabIndex = 3;
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
            this.Patient_GroupBox.Size = new System.Drawing.Size(711, 403);
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
            this.Patient_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Patient_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.Patient_TableLayoutPanel.Controls.Add(this.P_DateOfBirth_Label, 0, 4);
            this.Patient_TableLayoutPanel.Controls.Add(this.P_DateOfBirth_DateTimePicker, 1, 4);
            this.Patient_TableLayoutPanel.Controls.Add(this.P_PhoneNumber_Label, 0, 3);
            this.Patient_TableLayoutPanel.Controls.Add(this.P_Address_Label, 0, 2);
            this.Patient_TableLayoutPanel.Controls.Add(this.P_Name_Label, 0, 1);
            this.Patient_TableLayoutPanel.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.Patient_TableLayoutPanel.Controls.Add(this.tableLayoutPanel5, 1, 5);
            this.Patient_TableLayoutPanel.Controls.Add(this.MR_pTemp_Label, 0, 5);
            this.Patient_TableLayoutPanel.Controls.Add(this.tableLayoutPanel7, 1, 3);
            this.Patient_TableLayoutPanel.Controls.Add(this.tableLayoutPanel8, 1, 2);
            this.Patient_TableLayoutPanel.Controls.Add(this.tableLayoutPanel9, 1, 1);
            this.Patient_TableLayoutPanel.Location = new System.Drawing.Point(6, 35);
            this.Patient_TableLayoutPanel.Name = "Patient_TableLayoutPanel";
            this.Patient_TableLayoutPanel.RowCount = 6;
            this.Patient_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.Patient_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.Patient_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.Patient_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.Patient_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.Patient_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.Patient_TableLayoutPanel.Size = new System.Drawing.Size(698, 362);
            this.Patient_TableLayoutPanel.TabIndex = 0;
            // 
            // P_DateOfBirth_Label
            // 
            this.P_DateOfBirth_Label.AutoSize = true;
            this.P_DateOfBirth_Label.Location = new System.Drawing.Point(3, 240);
            this.P_DateOfBirth_Label.Name = "P_DateOfBirth_Label";
            this.P_DateOfBirth_Label.Size = new System.Drawing.Size(108, 30);
            this.P_DateOfBirth_Label.TabIndex = 3;
            this.P_DateOfBirth_Label.Text = "Ngày sinh";
            // 
            // P_DateOfBirth_DateTimePicker
            // 
            this.P_DateOfBirth_DateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.P_DateOfBirth_DateTimePicker.Enabled = false;
            this.P_DateOfBirth_DateTimePicker.Location = new System.Drawing.Point(177, 243);
            this.P_DateOfBirth_DateTimePicker.Name = "P_DateOfBirth_DateTimePicker";
            this.P_DateOfBirth_DateTimePicker.Size = new System.Drawing.Size(518, 35);
            this.P_DateOfBirth_DateTimePicker.TabIndex = 7;
            // 
            // P_PhoneNumber_Label
            // 
            this.P_PhoneNumber_Label.AutoSize = true;
            this.P_PhoneNumber_Label.Location = new System.Drawing.Point(3, 180);
            this.P_PhoneNumber_Label.Name = "P_PhoneNumber_Label";
            this.P_PhoneNumber_Label.Size = new System.Drawing.Size(139, 30);
            this.P_PhoneNumber_Label.TabIndex = 2;
            this.P_PhoneNumber_Label.Text = "Số điện thoại";
            // 
            // P_Address_Label
            // 
            this.P_Address_Label.AutoSize = true;
            this.P_Address_Label.Location = new System.Drawing.Point(3, 120);
            this.P_Address_Label.Name = "P_Address_Label";
            this.P_Address_Label.Size = new System.Drawing.Size(77, 30);
            this.P_Address_Label.TabIndex = 1;
            this.P_Address_Label.Text = "Địa chỉ";
            // 
            // P_Name_Label
            // 
            this.P_Name_Label.AutoSize = true;
            this.P_Name_Label.Location = new System.Drawing.Point(3, 60);
            this.P_Name_Label.Name = "P_Name_Label";
            this.P_Name_Label.Size = new System.Drawing.Size(106, 30);
            this.P_Name_Label.TabIndex = 0;
            this.P_Name_Label.Text = "Họ và tên";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.SelectPatient_Button, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.AddPantient_Button, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(177, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(518, 54);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // SelectPatient_Button
            // 
            this.SelectPatient_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectPatient_Button.Location = new System.Drawing.Point(3, 3);
            this.SelectPatient_Button.Name = "SelectPatient_Button";
            this.SelectPatient_Button.Size = new System.Drawing.Size(253, 48);
            this.SelectPatient_Button.TabIndex = 8;
            this.SelectPatient_Button.Text = "Chọn bệnh nhân";
            this.SelectPatient_Button.UseVisualStyleBackColor = true;
            this.SelectPatient_Button.Click += new System.EventHandler(this.SelectPatient_Button_Click);
            // 
            // AddPantient_Button
            // 
            this.AddPantient_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddPantient_Button.Location = new System.Drawing.Point(262, 3);
            this.AddPantient_Button.Name = "AddPantient_Button";
            this.AddPantient_Button.Size = new System.Drawing.Size(253, 48);
            this.AddPantient_Button.TabIndex = 9;
            this.AddPantient_Button.Text = "Thêm bệnh nhân";
            this.AddPantient_Button.UseVisualStyleBackColor = true;
            this.AddPantient_Button.Click += new System.EventHandler(this.AddPantient_Button_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Controls.Add(this.MR_pTemp_TextBox, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.MR_pWeight_TextBox, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.MR_pWeight_label, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(177, 303);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(518, 56);
            this.tableLayoutPanel5.TabIndex = 10;
            // 
            // MR_pTemp_TextBox
            // 
            this.MR_pTemp_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MR_pTemp_TextBox.Location = new System.Drawing.Point(3, 3);
            this.MR_pTemp_TextBox.Name = "MR_pTemp_TextBox";
            this.MR_pTemp_TextBox.Size = new System.Drawing.Size(166, 35);
            this.MR_pTemp_TextBox.TabIndex = 0;
            // 
            // MR_pWeight_TextBox
            // 
            this.MR_pWeight_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MR_pWeight_TextBox.Location = new System.Drawing.Point(347, 3);
            this.MR_pWeight_TextBox.Name = "MR_pWeight_TextBox";
            this.MR_pWeight_TextBox.Size = new System.Drawing.Size(168, 35);
            this.MR_pWeight_TextBox.TabIndex = 1;
            // 
            // MR_pWeight_label
            // 
            this.MR_pWeight_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MR_pWeight_label.AutoSize = true;
            this.MR_pWeight_label.Location = new System.Drawing.Point(238, 0);
            this.MR_pWeight_label.Name = "MR_pWeight_label";
            this.MR_pWeight_label.Size = new System.Drawing.Size(103, 30);
            this.MR_pWeight_label.TabIndex = 2;
            this.MR_pWeight_label.Text = "Cân nặng";
            // 
            // MR_pTemp_Label
            // 
            this.MR_pTemp_Label.AutoSize = true;
            this.MR_pTemp_Label.Location = new System.Drawing.Point(3, 300);
            this.MR_pTemp_Label.Name = "MR_pTemp_Label";
            this.MR_pTemp_Label.Size = new System.Drawing.Size(97, 30);
            this.MR_pTemp_Label.TabIndex = 11;
            this.MR_pTemp_Label.Text = "Nhiệt độ";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33223F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33223F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33555F));
            this.tableLayoutPanel7.Controls.Add(this.P_PhoneNumber_TextBox, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.P_Sex_Label, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.P_Sex_TextBox, 2, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(177, 183);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(518, 54);
            this.tableLayoutPanel7.TabIndex = 12;
            // 
            // P_PhoneNumber_TextBox
            // 
            this.P_PhoneNumber_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.P_PhoneNumber_TextBox.Enabled = false;
            this.P_PhoneNumber_TextBox.Location = new System.Drawing.Point(3, 3);
            this.P_PhoneNumber_TextBox.Name = "P_PhoneNumber_TextBox";
            this.P_PhoneNumber_TextBox.ReadOnly = true;
            this.P_PhoneNumber_TextBox.Size = new System.Drawing.Size(166, 35);
            this.P_PhoneNumber_TextBox.TabIndex = 6;
            // 
            // P_Sex_Label
            // 
            this.P_Sex_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.P_Sex_Label.AutoSize = true;
            this.P_Sex_Label.Location = new System.Drawing.Point(247, 0);
            this.P_Sex_Label.Name = "P_Sex_Label";
            this.P_Sex_Label.Size = new System.Drawing.Size(94, 30);
            this.P_Sex_Label.TabIndex = 7;
            this.P_Sex_Label.Text = "Giới tính";
            // 
            // P_Sex_TextBox
            // 
            this.P_Sex_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.P_Sex_TextBox.Enabled = false;
            this.P_Sex_TextBox.Location = new System.Drawing.Point(347, 3);
            this.P_Sex_TextBox.Name = "P_Sex_TextBox";
            this.P_Sex_TextBox.ReadOnly = true;
            this.P_Sex_TextBox.Size = new System.Drawing.Size(168, 35);
            this.P_Sex_TextBox.TabIndex = 8;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.P_Address_TextBox, 0, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(177, 123);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(518, 54);
            this.tableLayoutPanel8.TabIndex = 13;
            // 
            // P_Address_TextBox
            // 
            this.P_Address_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.P_Address_TextBox.Enabled = false;
            this.P_Address_TextBox.Location = new System.Drawing.Point(3, 3);
            this.P_Address_TextBox.Name = "P_Address_TextBox";
            this.P_Address_TextBox.ReadOnly = true;
            this.P_Address_TextBox.Size = new System.Drawing.Size(512, 35);
            this.P_Address_TextBox.TabIndex = 5;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Controls.Add(this.P_Name_TextBox, 0, 0);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(177, 63);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(518, 54);
            this.tableLayoutPanel9.TabIndex = 14;
            // 
            // P_Name_TextBox
            // 
            this.P_Name_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.P_Name_TextBox.Enabled = false;
            this.P_Name_TextBox.Location = new System.Drawing.Point(3, 3);
            this.P_Name_TextBox.Name = "P_Name_TextBox";
            this.P_Name_TextBox.ReadOnly = true;
            this.P_Name_TextBox.Size = new System.Drawing.Size(512, 35);
            this.P_Name_TextBox.TabIndex = 4;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.MR_diagnosis_groupBox, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.MR_note_groupBox, 0, 1);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(720, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(711, 403);
            this.tableLayoutPanel6.TabIndex = 3;
            // 
            // MR_diagnosis_groupBox
            // 
            this.MR_diagnosis_groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MR_diagnosis_groupBox.Controls.Add(this.MR_diagnosis_richTextBox);
            this.MR_diagnosis_groupBox.Location = new System.Drawing.Point(3, 3);
            this.MR_diagnosis_groupBox.Name = "MR_diagnosis_groupBox";
            this.MR_diagnosis_groupBox.Size = new System.Drawing.Size(705, 195);
            this.MR_diagnosis_groupBox.TabIndex = 0;
            this.MR_diagnosis_groupBox.TabStop = false;
            this.MR_diagnosis_groupBox.Text = "Chuẩn đoán";
            // 
            // MR_diagnosis_richTextBox
            // 
            this.MR_diagnosis_richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MR_diagnosis_richTextBox.Location = new System.Drawing.Point(3, 32);
            this.MR_diagnosis_richTextBox.Name = "MR_diagnosis_richTextBox";
            this.MR_diagnosis_richTextBox.Size = new System.Drawing.Size(698, 157);
            this.MR_diagnosis_richTextBox.TabIndex = 0;
            this.MR_diagnosis_richTextBox.Text = "";
            // 
            // MR_note_groupBox
            // 
            this.MR_note_groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MR_note_groupBox.Controls.Add(this.MR_note_richTextBox);
            this.MR_note_groupBox.Location = new System.Drawing.Point(3, 204);
            this.MR_note_groupBox.Name = "MR_note_groupBox";
            this.MR_note_groupBox.Size = new System.Drawing.Size(705, 196);
            this.MR_note_groupBox.TabIndex = 1;
            this.MR_note_groupBox.TabStop = false;
            this.MR_note_groupBox.Text = "Ghi chú";
            // 
            // MR_note_richTextBox
            // 
            this.MR_note_richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MR_note_richTextBox.Location = new System.Drawing.Point(3, 31);
            this.MR_note_richTextBox.Name = "MR_note_richTextBox";
            this.MR_note_richTextBox.Size = new System.Drawing.Size(698, 159);
            this.MR_note_richTextBox.TabIndex = 0;
            this.MR_note_richTextBox.Text = "";
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Controls.Add(this.confirm_Button, 1, 0);
            this.tableLayoutPanel10.Location = new System.Drawing.Point(720, 821);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(711, 55);
            this.tableLayoutPanel10.TabIndex = 5;
            // 
            // confirm_Button
            // 
            this.confirm_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.confirm_Button.Location = new System.Drawing.Point(524, 3);
            this.confirm_Button.Name = "confirm_Button";
            this.confirm_Button.Size = new System.Drawing.Size(184, 48);
            this.confirm_Button.TabIndex = 4;
            this.confirm_Button.Text = "Xác nhận";
            this.confirm_Button.UseVisualStyleBackColor = true;
            this.confirm_Button.Click += new System.EventHandler(this.confirm_Button_Click);
            // 
            // CMR_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1460, 904);
            this.Controls.Add(this.MainLayout_TableLayoutPanel);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "CMR_MainForm";
            this.Text = "CMR_MainForm";
            this.MainLayout_TableLayoutPanel.ResumeLayout(false);
            this.Prescription_GroupBox.ResumeLayout(false);
            this.Prescription_TableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Prescription_DataGridView)).EndInit();
            this.Service_GroupBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ServiceBill_DataGridView)).EndInit();
            this.Patient_GroupBox.ResumeLayout(false);
            this.Patient_TableLayoutPanel.ResumeLayout(false);
            this.Patient_TableLayoutPanel.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.MR_diagnosis_groupBox.ResumeLayout(false);
            this.MR_note_groupBox.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
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
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox Service_GroupBox;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button S_AddServiceToList_Button;
        private TableLayoutPanel tableLayoutPanel4;
        private Button SelectPatient_Button;
        private Button AddPantient_Button;
        private TableLayoutPanel tableLayoutPanel5;
        private Label MR_pTemp_Label;
        private TextBox MR_pTemp_TextBox;
        private TextBox MR_pWeight_TextBox;
        private Label MR_pWeight_label;
        private TableLayoutPanel tableLayoutPanel6;
        private GroupBox MR_diagnosis_groupBox;
        private RichTextBox MR_diagnosis_richTextBox;
        private GroupBox MR_note_groupBox;
        private RichTextBox MR_note_richTextBox;
        private TableLayoutPanel tableLayoutPanel7;
        private Label P_Sex_Label;
        private TextBox P_Sex_TextBox;
        private TableLayoutPanel tableLayoutPanel8;
        private TableLayoutPanel tableLayoutPanel9;
        private TableLayoutPanel tableLayoutPanel10;
        private Button confirm_Button;
        private Krypton.Toolkit.KryptonDataGridView Prescription_DataGridView;
        private Krypton.Toolkit.KryptonDataGridView ServiceBill_DataGridView;
    }
}