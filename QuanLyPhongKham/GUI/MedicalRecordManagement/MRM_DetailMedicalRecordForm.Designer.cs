﻿namespace QuanLyPhongKham.GUI.MedicalRecordManagement
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.diagnosis_GroupBox = new System.Windows.Forms.GroupBox();
            this.MR_Diagnosis_textBox = new System.Windows.Forms.TextBox();
            this.Note_GroupBox = new System.Windows.Forms.GroupBox();
            this.MR_Note_textBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.exportButton = new System.Windows.Forms.Button();
            this.drug_GroupBox = new System.Windows.Forms.GroupBox();
            this.D_List_GridView = new Krypton.Toolkit.KryptonDataGridView();
            this.serviceBill_GroupBox = new System.Windows.Forms.GroupBox();
            this.S_List_GridView = new Krypton.Toolkit.KryptonDataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.diagnosis_GroupBox.SuspendLayout();
            this.Note_GroupBox.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.drug_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.D_List_GridView)).BeginInit();
            this.serviceBill_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.S_List_GridView)).BeginInit();
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
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.drug_GroupBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.serviceBill_GroupBox, 1, 1);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(470, 410);
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
            this.MR_Date_Label.Location = new System.Drawing.Point(3, 51);
            this.MR_Date_Label.Name = "MR_Date_Label";
            this.MR_Date_Label.Size = new System.Drawing.Size(108, 51);
            this.MR_Date_Label.TabIndex = 1;
            this.MR_Date_Label.Text = "Ngày tạo bệnh án";
            // 
            // E_ID_Label
            // 
            this.E_ID_Label.AutoSize = true;
            this.E_ID_Label.Location = new System.Drawing.Point(3, 102);
            this.E_ID_Label.Name = "E_ID_Label";
            this.E_ID_Label.Size = new System.Drawing.Size(134, 30);
            this.E_ID_Label.TabIndex = 2;
            this.E_ID_Label.Text = "ID người tạo";
            // 
            // E_Name_Label
            // 
            this.E_Name_Label.AutoSize = true;
            this.E_Name_Label.Location = new System.Drawing.Point(3, 153);
            this.E_Name_Label.Name = "E_Name_Label";
            this.E_Name_Label.Size = new System.Drawing.Size(114, 51);
            this.E_Name_Label.TabIndex = 3;
            this.E_Name_Label.Text = "Tên người tạo";
            // 
            // P_ID_Label
            // 
            this.P_ID_Label.AutoSize = true;
            this.P_ID_Label.Location = new System.Drawing.Point(3, 204);
            this.P_ID_Label.Name = "P_ID_Label";
            this.P_ID_Label.Size = new System.Drawing.Size(94, 51);
            this.P_ID_Label.TabIndex = 4;
            this.P_ID_Label.Text = "ID bệnh nhân";
            // 
            // P_Name_Label
            // 
            this.P_Name_Label.AutoSize = true;
            this.P_Name_Label.Location = new System.Drawing.Point(3, 255);
            this.P_Name_Label.Name = "P_Name_Label";
            this.P_Name_Label.Size = new System.Drawing.Size(106, 51);
            this.P_Name_Label.TabIndex = 5;
            this.P_Name_Label.Text = "Tên bệnh nhân";
            // 
            // MR_ID_textBox
            // 
            this.MR_ID_textBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.MR_ID_textBox.Enabled = false;
            this.MR_ID_textBox.Location = new System.Drawing.Point(144, 3);
            this.MR_ID_textBox.Name = "MR_ID_textBox";
            this.MR_ID_textBox.ReadOnly = true;
            this.MR_ID_textBox.Size = new System.Drawing.Size(323, 35);
            this.MR_ID_textBox.TabIndex = 6;
            // 
            // MR_Date_textBox
            // 
            this.MR_Date_textBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.MR_Date_textBox.Enabled = false;
            this.MR_Date_textBox.Location = new System.Drawing.Point(144, 54);
            this.MR_Date_textBox.Name = "MR_Date_textBox";
            this.MR_Date_textBox.ReadOnly = true;
            this.MR_Date_textBox.Size = new System.Drawing.Size(323, 35);
            this.MR_Date_textBox.TabIndex = 7;
            // 
            // E_ID_textBox
            // 
            this.E_ID_textBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.E_ID_textBox.Enabled = false;
            this.E_ID_textBox.Location = new System.Drawing.Point(144, 105);
            this.E_ID_textBox.Name = "E_ID_textBox";
            this.E_ID_textBox.ReadOnly = true;
            this.E_ID_textBox.Size = new System.Drawing.Size(323, 35);
            this.E_ID_textBox.TabIndex = 8;
            // 
            // E_Name_textBox
            // 
            this.E_Name_textBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.E_Name_textBox.Enabled = false;
            this.E_Name_textBox.Location = new System.Drawing.Point(144, 156);
            this.E_Name_textBox.Name = "E_Name_textBox";
            this.E_Name_textBox.ReadOnly = true;
            this.E_Name_textBox.Size = new System.Drawing.Size(323, 35);
            this.E_Name_textBox.TabIndex = 9;
            // 
            // P_ID_textBox
            // 
            this.P_ID_textBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.P_ID_textBox.Enabled = false;
            this.P_ID_textBox.Location = new System.Drawing.Point(144, 207);
            this.P_ID_textBox.Name = "P_ID_textBox";
            this.P_ID_textBox.ReadOnly = true;
            this.P_ID_textBox.Size = new System.Drawing.Size(323, 35);
            this.P_ID_textBox.TabIndex = 10;
            // 
            // P_Name_textBox
            // 
            this.P_Name_textBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.P_Name_textBox.Enabled = false;
            this.P_Name_textBox.Location = new System.Drawing.Point(144, 258);
            this.P_Name_textBox.Name = "P_Name_textBox";
            this.P_Name_textBox.ReadOnly = true;
            this.P_Name_textBox.Size = new System.Drawing.Size(323, 35);
            this.P_Name_textBox.TabIndex = 11;
            // 
            // MR_PatientTemp_Label
            // 
            this.MR_PatientTemp_Label.AutoSize = true;
            this.MR_PatientTemp_Label.Location = new System.Drawing.Point(3, 306);
            this.MR_PatientTemp_Label.Name = "MR_PatientTemp_Label";
            this.MR_PatientTemp_Label.Size = new System.Drawing.Size(97, 30);
            this.MR_PatientTemp_Label.TabIndex = 12;
            this.MR_PatientTemp_Label.Text = "Nhiệt độ";
            // 
            // MR_PatientWeight_Label
            // 
            this.MR_PatientWeight_Label.AutoSize = true;
            this.MR_PatientWeight_Label.Location = new System.Drawing.Point(3, 357);
            this.MR_PatientWeight_Label.Name = "MR_PatientWeight_Label";
            this.MR_PatientWeight_Label.Size = new System.Drawing.Size(103, 30);
            this.MR_PatientWeight_Label.TabIndex = 13;
            this.MR_PatientWeight_Label.Text = "Cân nặng";
            // 
            // MR_PateintTemp_textBox
            // 
            this.MR_PateintTemp_textBox.Enabled = false;
            this.MR_PateintTemp_textBox.Location = new System.Drawing.Point(144, 309);
            this.MR_PateintTemp_textBox.Name = "MR_PateintTemp_textBox";
            this.MR_PateintTemp_textBox.ReadOnly = true;
            this.MR_PateintTemp_textBox.Size = new System.Drawing.Size(323, 35);
            this.MR_PateintTemp_textBox.TabIndex = 14;
            // 
            // MR_PatientWeight_textBox
            // 
            this.MR_PatientWeight_textBox.Enabled = false;
            this.MR_PatientWeight_textBox.Location = new System.Drawing.Point(144, 360);
            this.MR_PatientWeight_textBox.Name = "MR_PatientWeight_textBox";
            this.MR_PatientWeight_textBox.ReadOnly = true;
            this.MR_PatientWeight_textBox.Size = new System.Drawing.Size(323, 35);
            this.MR_PatientWeight_textBox.TabIndex = 15;
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
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.60429F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.39571F));
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 1, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(479, 835);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(470, 74);
            this.tableLayoutPanel6.TabIndex = 4;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.exportButton, 1, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(146, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(321, 68);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(163, 3);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(155, 62);
            this.exportButton.TabIndex = 1;
            this.exportButton.Text = "Xuất bệnh án";
            this.exportButton.UseVisualStyleBackColor = true;
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
            this.S_List_GridView.Location = new System.Drawing.Point(0, 34);
            this.S_List_GridView.Name = "S_List_GridView";
            this.S_List_GridView.ReadOnly = true;
            this.S_List_GridView.RowHeadersVisible = false;
            this.S_List_GridView.RowHeadersWidth = 72;
            this.S_List_GridView.RowTemplate.Height = 37;
            this.S_List_GridView.Size = new System.Drawing.Size(467, 370);
            this.S_List_GridView.TabIndex = 0;
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
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.diagnosis_GroupBox.ResumeLayout(false);
            this.diagnosis_GroupBox.PerformLayout();
            this.Note_GroupBox.ResumeLayout(false);
            this.Note_GroupBox.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.drug_GroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.D_List_GridView)).EndInit();
            this.serviceBill_GroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.S_List_GridView)).EndInit();
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
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel7;
        private Button exportButton;
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
    }
}