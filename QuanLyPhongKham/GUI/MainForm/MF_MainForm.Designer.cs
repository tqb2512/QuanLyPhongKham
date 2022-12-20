namespace QuanLyPhongKham.GUI.MainForm
{
    partial class MF_MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Management_StripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MedicalRecord_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Patient_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Drug_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Service_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createMR_StripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Main_TabControl = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Management_StripMenu,
            this.createMR_StripMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1576, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Management_StripMenu
            // 
            this.Management_StripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MedicalRecord_MenuItem,
            this.Patient_MenuItem,
            this.Drug_MenuItem,
            this.Service_MenuItem});
            this.Management_StripMenu.Name = "Management_StripMenu";
            this.Management_StripMenu.Size = new System.Drawing.Size(103, 34);
            this.Management_StripMenu.Text = "Quản lý";
            // 
            // MedicalRecord_MenuItem
            // 
            this.MedicalRecord_MenuItem.Name = "MedicalRecord_MenuItem";
            this.MedicalRecord_MenuItem.Size = new System.Drawing.Size(315, 40);
            this.MedicalRecord_MenuItem.Text = "Bệnh án";
            this.MedicalRecord_MenuItem.Click += new System.EventHandler(this.MedicalRecord_MenuItem_Click);
            // 
            // Patient_MenuItem
            // 
            this.Patient_MenuItem.Name = "Patient_MenuItem";
            this.Patient_MenuItem.Size = new System.Drawing.Size(315, 40);
            this.Patient_MenuItem.Text = "Bệnh nhân";
            // 
            // Drug_MenuItem
            // 
            this.Drug_MenuItem.Name = "Drug_MenuItem";
            this.Drug_MenuItem.Size = new System.Drawing.Size(315, 40);
            this.Drug_MenuItem.Text = "Thuốc";
            // 
            // Service_MenuItem
            // 
            this.Service_MenuItem.Name = "Service_MenuItem";
            this.Service_MenuItem.Size = new System.Drawing.Size(315, 40);
            this.Service_MenuItem.Text = "Dịch vụ";
            // 
            // createMR_StripMenu
            // 
            this.createMR_StripMenu.Name = "createMR_StripMenu";
            this.createMR_StripMenu.Size = new System.Drawing.Size(137, 34);
            this.createMR_StripMenu.Text = "Khám bệnh";
            this.createMR_StripMenu.Click += new System.EventHandler(this.createMR_StripMenu_Click);
            // 
            // Main_TabControl
            // 
            this.Main_TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Main_TabControl.Location = new System.Drawing.Point(12, 41);
            this.Main_TabControl.Name = "Main_TabControl";
            this.Main_TabControl.SelectedIndex = 0;
            this.Main_TabControl.Size = new System.Drawing.Size(1552, 883);
            this.Main_TabControl.TabIndex = 1;
            // 
            // MF_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1576, 936);
            this.Controls.Add(this.Main_TabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MF_MainForm";
            this.Text = "MF_MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem Management_StripMenu;
        private ToolStripMenuItem MedicalRecord_MenuItem;
        private ToolStripMenuItem Patient_MenuItem;
        private ToolStripMenuItem Drug_MenuItem;
        private ToolStripMenuItem Service_MenuItem;
        private TabControl Main_TabControl;
        private ToolStripMenuItem createMR_StripMenu;
    }
}