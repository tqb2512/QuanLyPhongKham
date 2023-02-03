namespace QuanLyPhongKham.GUI.PatientManagement
{
    partial class PM_MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.refresh_button = new Krypton.Toolkit.KryptonButton();
            this.add_button = new Krypton.Toolkit.KryptonButton();
            this.patientDataGridView = new Krypton.Toolkit.KryptonDataGridView();
            this.search_TableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.idSearch_textBox = new System.Windows.Forms.TextBox();
            this.nameSearch_textBox = new System.Windows.Forms.TextBox();
            this.phonenumberSearch_textBox = new System.Windows.Forms.TextBox();
            this.dateofbirthSearch_textBox = new System.Windows.Forms.TextBox();
            this.addressSearch_textBox = new System.Windows.Forms.TextBox();
            this.genderSearch_textBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.edit_button = new Krypton.Toolkit.KryptonButton();
            this.delete_button = new Krypton.Toolkit.KryptonButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.PatientID = new System.Windows.Forms.Label();
            this.labelPatientName = new System.Windows.Forms.Label();
            this.labelPatientGender = new System.Windows.Forms.Label();
            this.P_ID_textBox = new System.Windows.Forms.TextBox();
            this.P_name_textBox = new System.Windows.Forms.TextBox();
            this.P_address_textBox = new System.Windows.Forms.TextBox();
            this.P_sex_ComboBox = new System.Windows.Forms.ComboBox();
            this.labelPatientBirthday = new System.Windows.Forms.Label();
            this.P_phonenumber_textBox = new System.Windows.Forms.TextBox();
            this.P_dateofbirth_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGridView)).BeginInit();
            this.search_TableLayout.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(4, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1321, 706);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin bệnh nhân";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1309, 684);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel4);
            this.groupBox2.Location = new System.Drawing.Point(3, 242);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1303, 438);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách bệnh nhân";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.patientDataGridView, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.search_TableLayout, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 20);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1299, 418);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 1, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(2, 340);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1295, 76);
            this.tableLayoutPanel6.TabIndex = 7;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.refresh_button, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.add_button, 1, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(988, 2);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(305, 72);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // refresh_button
            // 
            this.refresh_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refresh_button.CornerRoundingRadius = -1F;
            this.refresh_button.Location = new System.Drawing.Point(3, 3);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(146, 66);
            this.refresh_button.TabIndex = 8;
            this.refresh_button.Values.Text = "Làm mới";
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // add_button
            // 
            this.add_button.CornerRoundingRadius = -1F;
            this.add_button.Location = new System.Drawing.Point(154, 2);
            this.add_button.Margin = new System.Windows.Forms.Padding(2);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(149, 68);
            this.add_button.TabIndex = 7;
            this.add_button.Values.Text = "Thêm";
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // patientDataGridView
            // 
            this.patientDataGridView.AllowUserToAddRows = false;
            this.patientDataGridView.AllowUserToDeleteRows = false;
            this.patientDataGridView.AllowUserToResizeColumns = false;
            this.patientDataGridView.AllowUserToResizeRows = false;
            this.patientDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.patientDataGridView.ColumnHeadersHeight = 70;
            this.patientDataGridView.Location = new System.Drawing.Point(2, 24);
            this.patientDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.patientDataGridView.Name = "patientDataGridView";
            this.patientDataGridView.ReadOnly = true;
            this.patientDataGridView.RowHeadersVisible = false;
            this.patientDataGridView.RowHeadersWidth = 72;
            this.patientDataGridView.RowTemplate.Height = 37;
            this.patientDataGridView.Size = new System.Drawing.Size(1295, 312);
            this.patientDataGridView.TabIndex = 6;
            this.patientDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientDataGridView_CellContentClick);
            // 
            // search_TableLayout
            // 
            this.search_TableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.search_TableLayout.ColumnCount = 6;
            this.search_TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.search_TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.search_TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.search_TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.search_TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.search_TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.search_TableLayout.Controls.Add(this.idSearch_textBox, 0, 0);
            this.search_TableLayout.Controls.Add(this.nameSearch_textBox, 1, 0);
            this.search_TableLayout.Controls.Add(this.phonenumberSearch_textBox, 2, 0);
            this.search_TableLayout.Controls.Add(this.dateofbirthSearch_textBox, 3, 0);
            this.search_TableLayout.Controls.Add(this.addressSearch_textBox, 2, 0);
            this.search_TableLayout.Controls.Add(this.genderSearch_textBox, 2, 0);
            this.search_TableLayout.Location = new System.Drawing.Point(2, 2);
            this.search_TableLayout.Margin = new System.Windows.Forms.Padding(2);
            this.search_TableLayout.Name = "search_TableLayout";
            this.search_TableLayout.RowCount = 1;
            this.search_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.search_TableLayout.Size = new System.Drawing.Size(1295, 18);
            this.search_TableLayout.TabIndex = 5;
            // 
            // idSearch_textBox
            // 
            this.idSearch_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.idSearch_textBox.Location = new System.Drawing.Point(2, 2);
            this.idSearch_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.idSearch_textBox.Name = "idSearch_textBox";
            this.idSearch_textBox.Size = new System.Drawing.Size(211, 23);
            this.idSearch_textBox.TabIndex = 0;
            // 
            // nameSearch_textBox
            // 
            this.nameSearch_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameSearch_textBox.Location = new System.Drawing.Point(217, 2);
            this.nameSearch_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameSearch_textBox.Name = "nameSearch_textBox";
            this.nameSearch_textBox.Size = new System.Drawing.Size(211, 23);
            this.nameSearch_textBox.TabIndex = 1;
            // 
            // phonenumberSearch_textBox
            // 
            this.phonenumberSearch_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phonenumberSearch_textBox.Location = new System.Drawing.Point(862, 2);
            this.phonenumberSearch_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.phonenumberSearch_textBox.Name = "phonenumberSearch_textBox";
            this.phonenumberSearch_textBox.Size = new System.Drawing.Size(211, 23);
            this.phonenumberSearch_textBox.TabIndex = 4;
            // 
            // dateofbirthSearch_textBox
            // 
            this.dateofbirthSearch_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateofbirthSearch_textBox.Location = new System.Drawing.Point(1077, 2);
            this.dateofbirthSearch_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.dateofbirthSearch_textBox.Name = "dateofbirthSearch_textBox";
            this.dateofbirthSearch_textBox.Size = new System.Drawing.Size(216, 23);
            this.dateofbirthSearch_textBox.TabIndex = 5;
            // 
            // addressSearch_textBox
            // 
            this.addressSearch_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressSearch_textBox.Location = new System.Drawing.Point(432, 2);
            this.addressSearch_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.addressSearch_textBox.Name = "addressSearch_textBox";
            this.addressSearch_textBox.Size = new System.Drawing.Size(211, 23);
            this.addressSearch_textBox.TabIndex = 2;
            // 
            // genderSearch_textBox
            // 
            this.genderSearch_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.genderSearch_textBox.Location = new System.Drawing.Point(647, 2);
            this.genderSearch_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.genderSearch_textBox.Name = "genderSearch_textBox";
            this.genderSearch_textBox.Size = new System.Drawing.Size(211, 23);
            this.genderSearch_textBox.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.24098F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.75902F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.53648F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.46352F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1303, 233);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 5;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel5.Controls.Add(this.edit_button, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.delete_button, 3, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 179);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(804, 51);
            this.tableLayoutPanel5.TabIndex = 12;
            // 
            // edit_button
            // 
            this.edit_button.CornerRoundingRadius = -1F;
            this.edit_button.Location = new System.Drawing.Point(712, 3);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(89, 45);
            this.edit_button.TabIndex = 5;
            this.edit_button.Values.Text = "Chỉnh sửa";
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.CornerRoundingRadius = -1F;
            this.delete_button.Location = new System.Drawing.Point(617, 3);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(89, 45);
            this.delete_button.TabIndex = 6;
            this.delete_button.Values.Text = "Xóa";
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel3.Controls.Add(this.PatientID, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelPatientName, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelPatientGender, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.P_ID_textBox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.P_name_textBox, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.P_address_textBox, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.P_sex_ComboBox, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.labelPatientBirthday, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.P_phonenumber_textBox, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.P_dateofbirth_dateTimePicker, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(804, 170);
            this.tableLayoutPanel3.TabIndex = 2;
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
            this.labelPatientName.Location = new System.Drawing.Point(3, 28);
            this.labelPatientName.Name = "labelPatientName";
            this.labelPatientName.Size = new System.Drawing.Size(88, 15);
            this.labelPatientName.TabIndex = 1;
            this.labelPatientName.Text = "Tên bệnh nhân";
            // 
            // labelPatientGender
            // 
            this.labelPatientGender.AutoSize = true;
            this.labelPatientGender.Location = new System.Drawing.Point(3, 56);
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
            this.P_ID_textBox.Location = new System.Drawing.Point(163, 3);
            this.P_ID_textBox.Name = "P_ID_textBox";
            this.P_ID_textBox.Size = new System.Drawing.Size(638, 23);
            this.P_ID_textBox.TabIndex = 0;
            // 
            // P_name_textBox
            // 
            this.P_name_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.P_name_textBox.Enabled = false;
            this.P_name_textBox.Location = new System.Drawing.Point(163, 31);
            this.P_name_textBox.Name = "P_name_textBox";
            this.P_name_textBox.Size = new System.Drawing.Size(638, 23);
            this.P_name_textBox.TabIndex = 1;
            // 
            // P_address_textBox
            // 
            this.P_address_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.P_address_textBox.Enabled = false;
            this.P_address_textBox.Location = new System.Drawing.Point(163, 87);
            this.P_address_textBox.Name = "P_address_textBox";
            this.P_address_textBox.Size = new System.Drawing.Size(638, 23);
            this.P_address_textBox.TabIndex = 3;
            // 
            // P_sex_ComboBox
            // 
            this.P_sex_ComboBox.BackColor = System.Drawing.SystemColors.Control;
            this.P_sex_ComboBox.FormattingEnabled = true;
            this.P_sex_ComboBox.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.P_sex_ComboBox.Location = new System.Drawing.Point(163, 59);
            this.P_sex_ComboBox.Name = "P_sex_ComboBox";
            this.P_sex_ComboBox.Size = new System.Drawing.Size(71, 23);
            this.P_sex_ComboBox.TabIndex = 2;
            // 
            // labelPatientBirthday
            // 
            this.labelPatientBirthday.AutoSize = true;
            this.labelPatientBirthday.Location = new System.Drawing.Point(3, 140);
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
            this.P_phonenumber_textBox.Location = new System.Drawing.Point(163, 115);
            this.P_phonenumber_textBox.Name = "P_phonenumber_textBox";
            this.P_phonenumber_textBox.Size = new System.Drawing.Size(638, 23);
            this.P_phonenumber_textBox.TabIndex = 8;
            // 
            // P_dateofbirth_dateTimePicker
            // 
            this.P_dateofbirth_dateTimePicker.CustomFormat = "MM/dd/yyyy";
            this.P_dateofbirth_dateTimePicker.Location = new System.Drawing.Point(163, 143);
            this.P_dateofbirth_dateTimePicker.Name = "P_dateofbirth_dateTimePicker";
            this.P_dateofbirth_dateTimePicker.Size = new System.Drawing.Size(270, 23);
            this.P_dateofbirth_dateTimePicker.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Điện thoại";
            // 
            // PM_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 711);
            this.Controls.Add(this.groupBox1);
            this.Name = "PM_MainForm";
            this.Text = "PM_FinalForm";
            this.Load += new System.EventHandler(this.PM_FinalForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGridView)).EndInit();
            this.search_TableLayout.ResumeLayout(false);
            this.search_TableLayout.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel5;
        public Krypton.Toolkit.KryptonButton delete_button;
        public Krypton.Toolkit.KryptonButton edit_button;
        private TableLayoutPanel tableLayoutPanel3;
        private Label PatientID;
        private Label labelPatientName;
        private Label labelPatientGender;
        public TextBox P_ID_textBox;
        public TextBox P_name_textBox;
        public TextBox P_address_textBox;
        public ComboBox P_sex_ComboBox;
        private Label labelPatientBirthday;
        public TextBox P_phonenumber_textBox;
        public DateTimePicker P_dateofbirth_dateTimePicker;
        private Label label1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel4;
        public Krypton.Toolkit.KryptonDataGridView patientDataGridView;
        private TableLayoutPanel search_TableLayout;
        private TextBox idSearch_textBox;
        private TextBox nameSearch_textBox;
        private TextBox phonenumberSearch_textBox;
        private TextBox dateofbirthSearch_textBox;
        private TextBox addressSearch_textBox;
        private TextBox genderSearch_textBox;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel7;
        public Krypton.Toolkit.KryptonButton add_button;
        private Krypton.Toolkit.KryptonButton refresh_button;
    }
}