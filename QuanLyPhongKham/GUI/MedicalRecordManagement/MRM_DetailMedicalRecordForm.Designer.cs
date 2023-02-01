namespace QuanLyPhongKham.GUI.MedicalRecordManagement
{
    partial class MRM_DetailMedicalRecordForm
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.diagnosis_GroupBox = new System.Windows.Forms.GroupBox();
            this.MR_Diagnosis_textBox = new System.Windows.Forms.TextBox();
            this.Note_GroupBox = new System.Windows.Forms.GroupBox();
            this.MR_Note_textBox = new System.Windows.Forms.TextBox();
            this.drug_GroupBox = new System.Windows.Forms.GroupBox();
            this.D_List_GridView = new Krypton.Toolkit.KryptonDataGridView();
            this.serviceBill_GroupBox = new System.Windows.Forms.GroupBox();
            this.S_List_GridView = new Krypton.Toolkit.KryptonDataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.delete_button = new Krypton.Toolkit.KryptonButton();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.MR_detail = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.MR_ID_Label = new System.Windows.Forms.Label();
            this.MR_Date_Label = new System.Windows.Forms.Label();
            this.E_ID_Label = new System.Windows.Forms.Label();
            this.E_Name_Label = new System.Windows.Forms.Label();
            this.P_ID_Label = new System.Windows.Forms.Label();
            this.P_Name_Label = new System.Windows.Forms.Label();
            this.MR_ID_textBox = new System.Windows.Forms.TextBox();
            this.MR_Date_textBox = new System.Windows.Forms.TextBox();
            this.E_ID_textBox = new System.Windows.Forms.TextBox();
            this.E_Name_textBox = new System.Windows.Forms.TextBox();
            this.P_ID_textBox = new System.Windows.Forms.TextBox();
            this.P_Name_textBox = new System.Windows.Forms.TextBox();
            this.MR_PatientTemp_Label = new System.Windows.Forms.Label();
            this.MR_PatientWeight_Label = new System.Windows.Forms.Label();
            this.MR_PateintTemp_textBox = new System.Windows.Forms.TextBox();
            this.MR_PatientWeight_textBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.diagnosis_GroupBox.SuspendLayout();
            this.Note_GroupBox.SuspendLayout();
            this.drug_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.D_List_GridView)).BeginInit();
            this.serviceBill_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.S_List_GridView)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.MR_detail.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.drug_GroupBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.serviceBill_GroupBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(952, 912);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.16329F));
            this.tableLayoutPanel3.Controls.Add(this.diagnosis_GroupBox, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.Note_GroupBox, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(479, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(470, 410);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // diagnosis_GroupBox
            // 
            this.diagnosis_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.diagnosis_GroupBox.Controls.Add(this.MR_Diagnosis_textBox);
            this.diagnosis_GroupBox.Location = new System.Drawing.Point(3, 3);
            this.diagnosis_GroupBox.Name = "diagnosis_GroupBox";
            this.diagnosis_GroupBox.Size = new System.Drawing.Size(464, 199);
            this.diagnosis_GroupBox.TabIndex = 4;
            this.diagnosis_GroupBox.TabStop = false;
            this.diagnosis_GroupBox.Text = "Chuẩn đoán";
            // 
            // MR_Diagnosis_textBox
            // 
            this.MR_Diagnosis_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MR_Diagnosis_textBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.MR_Diagnosis_textBox.Enabled = false;
            this.MR_Diagnosis_textBox.Location = new System.Drawing.Point(6, 34);
            this.MR_Diagnosis_textBox.Multiline = true;
            this.MR_Diagnosis_textBox.Name = "MR_Diagnosis_textBox";
            this.MR_Diagnosis_textBox.ReadOnly = true;
            this.MR_Diagnosis_textBox.Size = new System.Drawing.Size(452, 159);
            this.MR_Diagnosis_textBox.TabIndex = 2;
            // 
            // Note_GroupBox
            // 
            this.Note_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Note_GroupBox.Controls.Add(this.MR_Note_textBox);
            this.Note_GroupBox.Location = new System.Drawing.Point(3, 208);
            this.Note_GroupBox.Name = "Note_GroupBox";
            this.Note_GroupBox.Size = new System.Drawing.Size(464, 199);
            this.Note_GroupBox.TabIndex = 5;
            this.Note_GroupBox.TabStop = false;
            this.Note_GroupBox.Text = "Ghi chú";
            // 
            // MR_Note_textBox
            // 
            this.MR_Note_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MR_Note_textBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.MR_Note_textBox.Enabled = false;
            this.MR_Note_textBox.Location = new System.Drawing.Point(6, 34);
            this.MR_Note_textBox.Multiline = true;
            this.MR_Note_textBox.Name = "MR_Note_textBox";
            this.MR_Note_textBox.ReadOnly = true;
            this.MR_Note_textBox.Size = new System.Drawing.Size(452, 159);
            this.MR_Note_textBox.TabIndex = 3;
            // 
            // drug_GroupBox
            // 
            this.drug_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drug_GroupBox.Controls.Add(this.D_List_GridView);
            this.drug_GroupBox.Location = new System.Drawing.Point(3, 419);
            this.drug_GroupBox.Name = "drug_GroupBox";
            this.drug_GroupBox.Size = new System.Drawing.Size(470, 410);
            this.drug_GroupBox.TabIndex = 5;
            this.drug_GroupBox.TabStop = false;
            this.drug_GroupBox.Text = "Toa thuốc";
            // 
            // D_List_GridView
            // 
            this.D_List_GridView.AllowUserToAddRows = false;
            this.D_List_GridView.AllowUserToDeleteRows = false;
            this.D_List_GridView.AllowUserToResizeColumns = false;
            this.D_List_GridView.AllowUserToResizeRows = false;
            this.D_List_GridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.D_List_GridView.ColumnHeadersHeight = 70;
            this.D_List_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.D_List_GridView.Location = new System.Drawing.Point(3, 34);
            this.D_List_GridView.Name = "D_List_GridView";
            this.D_List_GridView.ReadOnly = true;
            this.D_List_GridView.RowHeadersVisible = false;
            this.D_List_GridView.RowHeadersWidth = 72;
            this.D_List_GridView.RowTemplate.Height = 37;
            this.D_List_GridView.Size = new System.Drawing.Size(464, 370);
            this.D_List_GridView.TabIndex = 0;
            // 
            // serviceBill_GroupBox
            // 
            this.serviceBill_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serviceBill_GroupBox.Controls.Add(this.S_List_GridView);
            this.serviceBill_GroupBox.Location = new System.Drawing.Point(479, 419);
            this.serviceBill_GroupBox.Name = "serviceBill_GroupBox";
            this.serviceBill_GroupBox.Size = new System.Drawing.Size(470, 410);
            this.serviceBill_GroupBox.TabIndex = 6;
            this.serviceBill_GroupBox.TabStop = false;
            this.serviceBill_GroupBox.Text = "Dịch vụ";
            // 
            // S_List_GridView
            // 
            this.S_List_GridView.AllowUserToAddRows = false;
            this.S_List_GridView.AllowUserToDeleteRows = false;
            this.S_List_GridView.AllowUserToResizeColumns = false;
            this.S_List_GridView.AllowUserToResizeRows = false;
            this.S_List_GridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.S_List_GridView.ColumnHeadersHeight = 70;
            this.S_List_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.S_List_GridView.Location = new System.Drawing.Point(0, 34);
            this.S_List_GridView.Name = "S_List_GridView";
            this.S_List_GridView.ReadOnly = true;
            this.S_List_GridView.RowHeadersVisible = false;
            this.S_List_GridView.RowHeadersWidth = 72;
            this.S_List_GridView.RowTemplate.Height = 37;
            this.S_List_GridView.Size = new System.Drawing.Size(467, 370);
            this.S_List_GridView.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.48936F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.51064F));
            this.tableLayoutPanel4.Controls.Add(this.delete_button, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(479, 835);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(470, 74);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // delete_button
            // 
            this.delete_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_button.CornerRoundingRadius = -1F;
            this.delete_button.Location = new System.Drawing.Point(283, 3);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(184, 68);
            this.delete_button.TabIndex = 2;
            this.delete_button.Values.Text = "Xóa bệnh án";
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.MR_detail, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(470, 410);
            this.tableLayoutPanel5.TabIndex = 9;
            // 
            // MR_detail
            // 
            this.MR_detail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MR_detail.Controls.Add(this.tableLayoutPanel2);
            this.MR_detail.Location = new System.Drawing.Point(3, 3);
            this.MR_detail.Name = "MR_detail";
            this.MR_detail.Size = new System.Drawing.Size(464, 404);
            this.MR_detail.TabIndex = 8;
            this.MR_detail.TabStop = false;
            this.MR_detail.Text = "Thông tin bệnh án";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.01508F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.98492F));
            this.tableLayoutPanel2.Controls.Add(this.MR_ID_Label, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.MR_Date_Label, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.E_ID_Label, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.E_Name_Label, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.P_ID_Label, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.P_Name_Label, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.MR_ID_textBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.MR_Date_textBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.E_ID_textBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.E_Name_textBox, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.P_ID_textBox, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.P_Name_textBox, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.MR_PatientTemp_Label, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.MR_PatientWeight_Label, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.MR_PateintTemp_textBox, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.MR_PatientWeight_textBox, 1, 7);
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 34);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49938F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49938F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49938F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49938F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49938F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49938F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.50187F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.50187F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(455, 361);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // MR_ID_Label
            // 
            this.MR_ID_Label.AutoSize = true;
            this.MR_ID_Label.Location = new System.Drawing.Point(3, 0);
            this.MR_ID_Label.Name = "MR_ID_Label";
            this.MR_ID_Label.Size = new System.Drawing.Size(117, 30);
            this.MR_ID_Label.TabIndex = 0;
            this.MR_ID_Label.Text = "ID bệnh án";
            // 
            // MR_Date_Label
            // 
            this.MR_Date_Label.AutoSize = true;
            this.MR_Date_Label.Location = new System.Drawing.Point(3, 45);
            this.MR_Date_Label.Name = "MR_Date_Label";
            this.MR_Date_Label.Size = new System.Drawing.Size(108, 45);
            this.MR_Date_Label.TabIndex = 1;
            this.MR_Date_Label.Text = "Ngày tạo bệnh án";
            // 
            // E_ID_Label
            // 
            this.E_ID_Label.AutoSize = true;
            this.E_ID_Label.Location = new System.Drawing.Point(3, 90);
            this.E_ID_Label.Name = "E_ID_Label";
            this.E_ID_Label.Size = new System.Drawing.Size(102, 45);
            this.E_ID_Label.TabIndex = 2;
            this.E_ID_Label.Text = "ID người tạo";
            // 
            // E_Name_Label
            // 
            this.E_Name_Label.AutoSize = true;
            this.E_Name_Label.Location = new System.Drawing.Point(3, 135);
            this.E_Name_Label.Name = "E_Name_Label";
            this.E_Name_Label.Size = new System.Drawing.Size(114, 45);
            this.E_Name_Label.TabIndex = 3;
            this.E_Name_Label.Text = "Tên người tạo";
            // 
            // P_ID_Label
            // 
            this.P_ID_Label.AutoSize = true;
            this.P_ID_Label.Location = new System.Drawing.Point(3, 180);
            this.P_ID_Label.Name = "P_ID_Label";
            this.P_ID_Label.Size = new System.Drawing.Size(94, 45);
            this.P_ID_Label.TabIndex = 4;
            this.P_ID_Label.Text = "ID bệnh nhân";
            // 
            // P_Name_Label
            // 
            this.P_Name_Label.AutoSize = true;
            this.P_Name_Label.Location = new System.Drawing.Point(3, 225);
            this.P_Name_Label.Name = "P_Name_Label";
            this.P_Name_Label.Size = new System.Drawing.Size(106, 45);
            this.P_Name_Label.TabIndex = 5;
            this.P_Name_Label.Text = "Tên bệnh nhân";
            // 
            // MR_ID_textBox
            // 
            this.MR_ID_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MR_ID_textBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.MR_ID_textBox.Enabled = false;
            this.MR_ID_textBox.Location = new System.Drawing.Point(139, 3);
            this.MR_ID_textBox.Name = "MR_ID_textBox";
            this.MR_ID_textBox.ReadOnly = true;
            this.MR_ID_textBox.Size = new System.Drawing.Size(313, 35);
            this.MR_ID_textBox.TabIndex = 6;
            // 
            // MR_Date_textBox
            // 
            this.MR_Date_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MR_Date_textBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.MR_Date_textBox.Enabled = false;
            this.MR_Date_textBox.Location = new System.Drawing.Point(139, 48);
            this.MR_Date_textBox.Name = "MR_Date_textBox";
            this.MR_Date_textBox.ReadOnly = true;
            this.MR_Date_textBox.Size = new System.Drawing.Size(313, 35);
            this.MR_Date_textBox.TabIndex = 7;
            // 
            // E_ID_textBox
            // 
            this.E_ID_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.E_ID_textBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.E_ID_textBox.Enabled = false;
            this.E_ID_textBox.Location = new System.Drawing.Point(139, 93);
            this.E_ID_textBox.Name = "E_ID_textBox";
            this.E_ID_textBox.ReadOnly = true;
            this.E_ID_textBox.Size = new System.Drawing.Size(313, 35);
            this.E_ID_textBox.TabIndex = 8;
            // 
            // E_Name_textBox
            // 
            this.E_Name_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.E_Name_textBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.E_Name_textBox.Enabled = false;
            this.E_Name_textBox.Location = new System.Drawing.Point(139, 138);
            this.E_Name_textBox.Name = "E_Name_textBox";
            this.E_Name_textBox.ReadOnly = true;
            this.E_Name_textBox.Size = new System.Drawing.Size(313, 35);
            this.E_Name_textBox.TabIndex = 9;
            // 
            // P_ID_textBox
            // 
            this.P_ID_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.P_ID_textBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.P_ID_textBox.Enabled = false;
            this.P_ID_textBox.Location = new System.Drawing.Point(139, 183);
            this.P_ID_textBox.Name = "P_ID_textBox";
            this.P_ID_textBox.ReadOnly = true;
            this.P_ID_textBox.Size = new System.Drawing.Size(313, 35);
            this.P_ID_textBox.TabIndex = 10;
            // 
            // P_Name_textBox
            // 
            this.P_Name_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.P_Name_textBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.P_Name_textBox.Enabled = false;
            this.P_Name_textBox.Location = new System.Drawing.Point(139, 228);
            this.P_Name_textBox.Name = "P_Name_textBox";
            this.P_Name_textBox.ReadOnly = true;
            this.P_Name_textBox.Size = new System.Drawing.Size(313, 35);
            this.P_Name_textBox.TabIndex = 11;
            // 
            // MR_PatientTemp_Label
            // 
            this.MR_PatientTemp_Label.AutoSize = true;
            this.MR_PatientTemp_Label.Location = new System.Drawing.Point(3, 270);
            this.MR_PatientTemp_Label.Name = "MR_PatientTemp_Label";
            this.MR_PatientTemp_Label.Size = new System.Drawing.Size(97, 30);
            this.MR_PatientTemp_Label.TabIndex = 12;
            this.MR_PatientTemp_Label.Text = "Nhiệt độ";
            // 
            // MR_PatientWeight_Label
            // 
            this.MR_PatientWeight_Label.AutoSize = true;
            this.MR_PatientWeight_Label.Location = new System.Drawing.Point(3, 315);
            this.MR_PatientWeight_Label.Name = "MR_PatientWeight_Label";
            this.MR_PatientWeight_Label.Size = new System.Drawing.Size(103, 30);
            this.MR_PatientWeight_Label.TabIndex = 13;
            this.MR_PatientWeight_Label.Text = "Cân nặng";
            // 
            // MR_PateintTemp_textBox
            // 
            this.MR_PateintTemp_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MR_PateintTemp_textBox.Enabled = false;
            this.MR_PateintTemp_textBox.Location = new System.Drawing.Point(139, 273);
            this.MR_PateintTemp_textBox.Name = "MR_PateintTemp_textBox";
            this.MR_PateintTemp_textBox.ReadOnly = true;
            this.MR_PateintTemp_textBox.Size = new System.Drawing.Size(313, 35);
            this.MR_PateintTemp_textBox.TabIndex = 14;
            // 
            // MR_PatientWeight_textBox
            // 
            this.MR_PatientWeight_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MR_PatientWeight_textBox.Enabled = false;
            this.MR_PatientWeight_textBox.Location = new System.Drawing.Point(139, 318);
            this.MR_PatientWeight_textBox.Name = "MR_PatientWeight_textBox";
            this.MR_PatientWeight_textBox.ReadOnly = true;
            this.MR_PatientWeight_textBox.Size = new System.Drawing.Size(313, 35);
            this.MR_PatientWeight_textBox.TabIndex = 15;
            // 
            // MRM_DetailMedicalRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(976, 936);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MRM_DetailMedicalRecordForm";
            this.Text = "MRM_DetailMedicalRecordForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.diagnosis_GroupBox.ResumeLayout(false);
            this.diagnosis_GroupBox.PerformLayout();
            this.Note_GroupBox.ResumeLayout(false);
            this.Note_GroupBox.PerformLayout();
            this.drug_GroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.D_List_GridView)).EndInit();
            this.serviceBill_GroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.S_List_GridView)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.MR_detail.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label MR_ID_Label;
        private Label MR_Date_Label;
        private Label E_ID_Label;
        private Label E_Name_Label;
        private Label P_ID_Label;
        private Label P_Name_Label;
        private TextBox MR_ID_textBox;
        private TextBox MR_Date_textBox;
        private TextBox E_ID_textBox;
        private TextBox E_Name_textBox;
        private TextBox P_ID_textBox;
        private TextBox P_Name_textBox;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox MR_Diagnosis_textBox;
        private TextBox MR_Note_textBox;
        private GroupBox drug_GroupBox;
        private GroupBox serviceBill_GroupBox;
        private GroupBox diagnosis_GroupBox;
        private GroupBox Note_GroupBox;
        private Krypton.Toolkit.KryptonDataGridView D_List_GridView;
        private Krypton.Toolkit.KryptonDataGridView S_List_GridView;
        private Label MR_PatientTemp_Label;
        private Label MR_PatientWeight_Label;
        private TextBox MR_PateintTemp_textBox;
        private TextBox MR_PatientWeight_textBox;
        private TableLayoutPanel tableLayoutPanel4;
        private GroupBox MR_detail;
        private TableLayoutPanel tableLayoutPanel5;
        private Krypton.Toolkit.KryptonButton delete_button;
    }
}