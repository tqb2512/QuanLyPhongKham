namespace QuanLyPhongKham.GUI.EmployeeManagement
{
    partial class EM_DetailEmployeeForm
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
            this.permission = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.CreateMedicalRecord = new Krypton.Toolkit.KryptonCheckBox();
            this.MakePayment = new Krypton.Toolkit.KryptonCheckBox();
            this.RemoveMedicalRecord = new Krypton.Toolkit.KryptonCheckBox();
            this.EditService = new Krypton.Toolkit.KryptonCheckBox();
            this.EditDrug = new Krypton.Toolkit.KryptonCheckBox();
            this.EditPatient = new Krypton.Toolkit.KryptonCheckBox();
            this.EditEmployee = new Krypton.Toolkit.KryptonCheckBox();
            this.userInfo = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.E_ID_Label = new System.Windows.Forms.Label();
            this.E_Name_Label = new System.Windows.Forms.Label();
            this.E_Position_Label = new System.Windows.Forms.Label();
            this.E_UserName_Label = new System.Windows.Forms.Label();
            this.E_Password_Label = new System.Windows.Forms.Label();
            this.E_ID_textBox = new System.Windows.Forms.TextBox();
            this.E_Name_textBox = new System.Windows.Forms.TextBox();
            this.E_Position_textBox = new System.Windows.Forms.TextBox();
            this.E_UserName_textBox = new System.Windows.Forms.TextBox();
            this.E_Password_textBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.editButton = new Krypton.Toolkit.KryptonButton();
            this.deleteButton = new Krypton.Toolkit.KryptonButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.permission.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.userInfo.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.permission, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.userInfo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(952, 912);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // permission
            // 
            this.permission.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.permission.Controls.Add(this.tableLayoutPanel3);
            this.permission.Location = new System.Drawing.Point(3, 419);
            this.permission.Name = "permission";
            this.permission.Size = new System.Drawing.Size(946, 410);
            this.permission.TabIndex = 2;
            this.permission.TabStop = false;
            this.permission.Text = "Quyền";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel3.Controls.Add(this.CreateMedicalRecord, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.MakePayment, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.RemoveMedicalRecord, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.EditService, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.EditDrug, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.EditPatient, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.EditEmployee, 1, 6);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 34);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 7;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(940, 370);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // CreateMedicalRecord
            // 
            this.CreateMedicalRecord.Enabled = false;
            this.CreateMedicalRecord.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.CreateMedicalRecord.Location = new System.Drawing.Point(238, 3);
            this.CreateMedicalRecord.Name = "CreateMedicalRecord";
            this.CreateMedicalRecord.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.CreateMedicalRecord.Size = new System.Drawing.Size(151, 29);
            this.CreateMedicalRecord.TabIndex = 0;
            this.CreateMedicalRecord.Values.Text = "Tạo bệnh án";
            // 
            // MakePayment
            // 
            this.MakePayment.Enabled = false;
            this.MakePayment.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.MakePayment.Location = new System.Drawing.Point(238, 55);
            this.MakePayment.Name = "MakePayment";
            this.MakePayment.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.MakePayment.Size = new System.Drawing.Size(239, 29);
            this.MakePayment.TabIndex = 1;
            this.MakePayment.Values.Text = "Thực hiện thanh toán";
            // 
            // RemoveMedicalRecord
            // 
            this.RemoveMedicalRecord.Enabled = false;
            this.RemoveMedicalRecord.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.RemoveMedicalRecord.Location = new System.Drawing.Point(238, 107);
            this.RemoveMedicalRecord.Name = "RemoveMedicalRecord";
            this.RemoveMedicalRecord.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.RemoveMedicalRecord.Size = new System.Drawing.Size(153, 29);
            this.RemoveMedicalRecord.TabIndex = 2;
            this.RemoveMedicalRecord.Values.Text = "Xóa bệnh án";
            // 
            // EditService
            // 
            this.EditService.Enabled = false;
            this.EditService.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.EditService.Location = new System.Drawing.Point(238, 263);
            this.EditService.Name = "EditService";
            this.EditService.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.EditService.Size = new System.Drawing.Size(307, 29);
            this.EditService.TabIndex = 5;
            this.EditService.Values.Text = "Chỉnh sửa danh sách dịch vụ";
            // 
            // EditDrug
            // 
            this.EditDrug.Enabled = false;
            this.EditDrug.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.EditDrug.Location = new System.Drawing.Point(238, 211);
            this.EditDrug.Name = "EditDrug";
            this.EditDrug.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.EditDrug.Size = new System.Drawing.Size(293, 29);
            this.EditDrug.TabIndex = 4;
            this.EditDrug.Values.Text = "Chỉnh sửa danh sách thuốc";
            // 
            // EditPatient
            // 
            this.EditPatient.Enabled = false;
            this.EditPatient.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.EditPatient.Location = new System.Drawing.Point(238, 159);
            this.EditPatient.Name = "EditPatient";
            this.EditPatient.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.EditPatient.Size = new System.Drawing.Size(336, 29);
            this.EditPatient.TabIndex = 3;
            this.EditPatient.Values.Text = " Chỉnh sửa thông tin bệnh nhân";
            // 
            // EditEmployee
            // 
            this.EditEmployee.Enabled = false;
            this.EditEmployee.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.EditEmployee.Location = new System.Drawing.Point(238, 315);
            this.EditEmployee.Name = "EditEmployee";
            this.EditEmployee.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.EditEmployee.Size = new System.Drawing.Size(229, 29);
            this.EditEmployee.TabIndex = 6;
            this.EditEmployee.Values.Text = "Chỉnh sửa nhân viên";
            // 
            // userInfo
            // 
            this.userInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userInfo.Controls.Add(this.tableLayoutPanel2);
            this.userInfo.Location = new System.Drawing.Point(3, 3);
            this.userInfo.Name = "userInfo";
            this.userInfo.Size = new System.Drawing.Size(946, 410);
            this.userInfo.TabIndex = 1;
            this.userInfo.TabStop = false;
            this.userInfo.Text = "Thông tin nhân viên";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.Controls.Add(this.E_ID_Label, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.E_Name_Label, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.E_Position_Label, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.E_UserName_Label, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.E_Password_Label, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.E_ID_textBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.E_Name_textBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.E_Position_textBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.E_UserName_textBox, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.E_Password_textBox, 1, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 34);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(937, 370);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // E_ID_Label
            // 
            this.E_ID_Label.AutoSize = true;
            this.E_ID_Label.Location = new System.Drawing.Point(3, 0);
            this.E_ID_Label.Name = "E_ID_Label";
            this.E_ID_Label.Size = new System.Drawing.Size(136, 30);
            this.E_ID_Label.TabIndex = 0;
            this.E_ID_Label.Text = "ID Nhân viên";
            // 
            // E_Name_Label
            // 
            this.E_Name_Label.AutoSize = true;
            this.E_Name_Label.Location = new System.Drawing.Point(3, 74);
            this.E_Name_Label.Name = "E_Name_Label";
            this.E_Name_Label.Size = new System.Drawing.Size(144, 30);
            this.E_Name_Label.TabIndex = 1;
            this.E_Name_Label.Text = "Tên nhân viên";
            // 
            // E_Position_Label
            // 
            this.E_Position_Label.AutoSize = true;
            this.E_Position_Label.Location = new System.Drawing.Point(3, 148);
            this.E_Position_Label.Name = "E_Position_Label";
            this.E_Position_Label.Size = new System.Drawing.Size(90, 30);
            this.E_Position_Label.TabIndex = 2;
            this.E_Position_Label.Text = "Chức vụ";
            // 
            // E_UserName_Label
            // 
            this.E_UserName_Label.AutoSize = true;
            this.E_UserName_Label.Location = new System.Drawing.Point(3, 222);
            this.E_UserName_Label.Name = "E_UserName_Label";
            this.E_UserName_Label.Size = new System.Drawing.Size(155, 30);
            this.E_UserName_Label.TabIndex = 3;
            this.E_UserName_Label.Text = "Tên đăng nhập";
            // 
            // E_Password_Label
            // 
            this.E_Password_Label.AutoSize = true;
            this.E_Password_Label.Location = new System.Drawing.Point(3, 296);
            this.E_Password_Label.Name = "E_Password_Label";
            this.E_Password_Label.Size = new System.Drawing.Size(103, 30);
            this.E_Password_Label.TabIndex = 4;
            this.E_Password_Label.Text = "Mật khẩu";
            // 
            // E_ID_textBox
            // 
            this.E_ID_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.E_ID_textBox.Enabled = false;
            this.E_ID_textBox.Location = new System.Drawing.Point(237, 3);
            this.E_ID_textBox.Name = "E_ID_textBox";
            this.E_ID_textBox.ReadOnly = true;
            this.E_ID_textBox.Size = new System.Drawing.Size(697, 35);
            this.E_ID_textBox.TabIndex = 5;
            // 
            // E_Name_textBox
            // 
            this.E_Name_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.E_Name_textBox.Enabled = false;
            this.E_Name_textBox.Location = new System.Drawing.Point(237, 77);
            this.E_Name_textBox.Name = "E_Name_textBox";
            this.E_Name_textBox.Size = new System.Drawing.Size(697, 35);
            this.E_Name_textBox.TabIndex = 6;
            // 
            // E_Position_textBox
            // 
            this.E_Position_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.E_Position_textBox.Enabled = false;
            this.E_Position_textBox.Location = new System.Drawing.Point(237, 151);
            this.E_Position_textBox.Name = "E_Position_textBox";
            this.E_Position_textBox.ReadOnly = true;
            this.E_Position_textBox.Size = new System.Drawing.Size(697, 35);
            this.E_Position_textBox.TabIndex = 7;
            // 
            // E_UserName_textBox
            // 
            this.E_UserName_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.E_UserName_textBox.Enabled = false;
            this.E_UserName_textBox.Location = new System.Drawing.Point(237, 225);
            this.E_UserName_textBox.Name = "E_UserName_textBox";
            this.E_UserName_textBox.ReadOnly = true;
            this.E_UserName_textBox.Size = new System.Drawing.Size(697, 35);
            this.E_UserName_textBox.TabIndex = 8;
            // 
            // E_Password_textBox
            // 
            this.E_Password_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.E_Password_textBox.Enabled = false;
            this.E_Password_textBox.Location = new System.Drawing.Point(237, 299);
            this.E_Password_textBox.Name = "E_Password_textBox";
            this.E_Password_textBox.PasswordChar = '*';
            this.E_Password_textBox.Size = new System.Drawing.Size(697, 35);
            this.E_Password_textBox.TabIndex = 9;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tableLayoutPanel4.Controls.Add(this.editButton, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.deleteButton, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 835);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(946, 74);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.CornerRoundingRadius = -1F;
            this.editButton.Location = new System.Drawing.Point(759, 3);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(184, 68);
            this.editButton.TabIndex = 0;
            this.editButton.Values.Text = "Sửa";
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.CornerRoundingRadius = -1F;
            this.deleteButton.Location = new System.Drawing.Point(569, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(184, 68);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Values.Text = "Xóa";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // EM_DetailEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(976, 936);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "EM_DetailEmployeeForm";
            this.Text = "EM_DetailEmployeeForm";
            this.Load += new System.EventHandler(this.EM_DetailEmployeeForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.permission.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.userInfo.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label E_ID_Label;
        private Label E_Name_Label;
        private Label E_Position_Label;
        private Label E_UserName_Label;
        private Label E_Password_Label;
        private TextBox E_ID_textBox;
        private TextBox E_Name_textBox;
        private TextBox E_Position_textBox;
        private TextBox E_UserName_textBox;
        private TextBox E_Password_textBox;
        private GroupBox permission;
        private TableLayoutPanel tableLayoutPanel3;
        private Krypton.Toolkit.KryptonCheckBox CreateMedicalRecord;
        private Krypton.Toolkit.KryptonCheckBox EditPatient;
        private Krypton.Toolkit.KryptonCheckBox EditDrug;
        private Krypton.Toolkit.KryptonCheckBox EditService;
        private Krypton.Toolkit.KryptonCheckBox EditEmployee;
        private Krypton.Toolkit.KryptonCheckBox RemoveMedicalRecord;
        private GroupBox userInfo;
        private TableLayoutPanel tableLayoutPanel4;
        public Krypton.Toolkit.KryptonButton editButton;
        private Krypton.Toolkit.KryptonCheckBox MakePayment;
        public Krypton.Toolkit.KryptonButton deleteButton;
    }
}