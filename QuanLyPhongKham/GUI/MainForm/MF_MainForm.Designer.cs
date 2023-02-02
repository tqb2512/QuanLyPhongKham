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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MF_MainForm));
            this.MF_ToolStrip = new Krypton.Toolkit.KryptonToolStrip();
            this.MF_Management_StripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.MR_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.P_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.D_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.S_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.E_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MF_CreateMR_StripButton = new System.Windows.Forms.ToolStripButton();
            this.signOutButton = new System.Windows.Forms.ToolStripButton();
            this.Main_TabControl = new Krypton.Docking.KryptonDockableNavigator();
            this.kryptonStatusStrip1 = new Krypton.Toolkit.KryptonStatusStrip();
            this.E_Name_Label = new System.Windows.Forms.ToolStripStatusLabel();
            this.MF_ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Main_TabControl)).BeginInit();
            this.kryptonStatusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MF_ToolStrip
            // 
            this.MF_ToolStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MF_ToolStrip.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.MF_ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MF_Management_StripButton,
            this.MF_CreateMR_StripButton,
            this.signOutButton});
            this.MF_ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.MF_ToolStrip.Name = "MF_ToolStrip";
            this.MF_ToolStrip.Size = new System.Drawing.Size(1976, 42);
            this.MF_ToolStrip.TabIndex = 2;
            this.MF_ToolStrip.Text = "kryptonToolStrip1";
            // 
            // MF_Management_StripButton
            // 
            this.MF_Management_StripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.MF_Management_StripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MR_ToolStripMenuItem,
            this.P_ToolStripMenuItem,
            this.D_ToolStripMenuItem,
            this.S_ToolStripMenuItem,
            this.E_MenuItem});
            this.MF_Management_StripButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MF_Management_StripButton.Image = ((System.Drawing.Image)(resources.GetObject("MF_Management_StripButton.Image")));
            this.MF_Management_StripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MF_Management_StripButton.Name = "MF_Management_StripButton";
            this.MF_Management_StripButton.Size = new System.Drawing.Size(119, 36);
            this.MF_Management_StripButton.Text = "Quản lý";
            // 
            // MR_ToolStripMenuItem
            // 
            this.MR_ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MR_ToolStripMenuItem.Name = "MR_ToolStripMenuItem";
            this.MR_ToolStripMenuItem.Size = new System.Drawing.Size(249, 40);
            this.MR_ToolStripMenuItem.Text = "Bệnh án";
            this.MR_ToolStripMenuItem.Click += new System.EventHandler(this.MedicalRecord_MenuItem_Click);
            // 
            // P_ToolStripMenuItem
            // 
            this.P_ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.P_ToolStripMenuItem.Name = "P_ToolStripMenuItem";
            this.P_ToolStripMenuItem.Size = new System.Drawing.Size(249, 40);
            this.P_ToolStripMenuItem.Text = "Bệnh nhân";
            // 
            // D_ToolStripMenuItem
            // 
            this.D_ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.D_ToolStripMenuItem.Name = "D_ToolStripMenuItem";
            this.D_ToolStripMenuItem.Size = new System.Drawing.Size(249, 40);
            this.D_ToolStripMenuItem.Text = "Thuốc";
            // 
            // S_ToolStripMenuItem
            // 
            this.S_ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.S_ToolStripMenuItem.Name = "S_ToolStripMenuItem";
            this.S_ToolStripMenuItem.Size = new System.Drawing.Size(249, 40);
            this.S_ToolStripMenuItem.Text = "Dịch vụ";
            this.S_ToolStripMenuItem.Click += new System.EventHandler(this.Service_MenuItem_Click);
            // 
            // E_MenuItem
            // 
            this.E_MenuItem.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.E_MenuItem.Name = "E_MenuItem";
            this.E_MenuItem.Size = new System.Drawing.Size(249, 40);
            this.E_MenuItem.Text = "Nhân Viên";
            this.E_MenuItem.Click += new System.EventHandler(this.E_MenuItem_Click_1);
            // 
            // MF_CreateMR_StripButton
            // 
            this.MF_CreateMR_StripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.MF_CreateMR_StripButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MF_CreateMR_StripButton.Image = ((System.Drawing.Image)(resources.GetObject("MF_CreateMR_StripButton.Image")));
            this.MF_CreateMR_StripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MF_CreateMR_StripButton.Name = "MF_CreateMR_StripButton";
            this.MF_CreateMR_StripButton.Size = new System.Drawing.Size(143, 36);
            this.MF_CreateMR_StripButton.Text = "Khám bệnh";
            this.MF_CreateMR_StripButton.Click += new System.EventHandler(this.createMR_StripMenu_Click);
            // 
            // signOutButton
            // 
            this.signOutButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.signOutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.signOutButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.signOutButton.Image = ((System.Drawing.Image)(resources.GetObject("signOutButton.Image")));
            this.signOutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.signOutButton.Name = "signOutButton";
            this.signOutButton.Size = new System.Drawing.Size(131, 36);
            this.signOutButton.Text = "Đăng xuất";
            this.signOutButton.Click += new System.EventHandler(this.signOutButton_Click);
            // 
            // Main_TabControl
            // 
            this.Main_TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Main_TabControl.Bar.BarMapExtraText = Krypton.Navigator.MapKryptonPageText.None;
            this.Main_TabControl.Bar.BarMapImage = Krypton.Navigator.MapKryptonPageImage.Small;
            this.Main_TabControl.Bar.BarMapText = Krypton.Navigator.MapKryptonPageText.TextTitle;
            this.Main_TabControl.Bar.BarMultiline = Krypton.Navigator.BarMultiline.Singleline;
            this.Main_TabControl.Bar.BarOrientation = Krypton.Toolkit.VisualOrientation.Top;
            this.Main_TabControl.Bar.CheckButtonStyle = Krypton.Toolkit.ButtonStyle.Standalone;
            this.Main_TabControl.Bar.ItemAlignment = Krypton.Toolkit.RelativePositionAlign.Near;
            this.Main_TabControl.Bar.ItemMaximumSize = new System.Drawing.Size(300, 200);
            this.Main_TabControl.Bar.ItemMinimumSize = new System.Drawing.Size(50, 50);
            this.Main_TabControl.Bar.ItemOrientation = Krypton.Toolkit.ButtonOrientation.Auto;
            this.Main_TabControl.Bar.ItemSizing = Krypton.Navigator.BarItemSizing.SameHeight;
            this.Main_TabControl.Bar.TabBorderStyle = Krypton.Toolkit.TabBorderStyle.RoundedOutsizeMedium;
            this.Main_TabControl.Bar.TabStyle = Krypton.Toolkit.TabStyle.HighProfile;
            this.Main_TabControl.Location = new System.Drawing.Point(0, 43);
            this.Main_TabControl.Name = "Main_TabControl";
            this.Main_TabControl.NavigatorMode = Krypton.Navigator.NavigatorMode.BarTabGroup;
            this.Main_TabControl.PageBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlClient;
            this.Main_TabControl.Size = new System.Drawing.Size(1976, 1049);
            this.Main_TabControl.TabIndex = 1;
            this.Main_TabControl.Text = "kryptonDockableNavigator1";
            // 
            // kryptonStatusStrip1
            // 
            this.kryptonStatusStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonStatusStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.kryptonStatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.E_Name_Label});
            this.kryptonStatusStrip1.Location = new System.Drawing.Point(0, 1095);
            this.kryptonStatusStrip1.Name = "kryptonStatusStrip1";
            this.kryptonStatusStrip1.ProgressBars = null;
            this.kryptonStatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.kryptonStatusStrip1.Size = new System.Drawing.Size(1976, 41);
            this.kryptonStatusStrip1.TabIndex = 3;
            this.kryptonStatusStrip1.Text = "kryptonStatusStrip1";
            // 
            // E_Name_Label
            // 
            this.E_Name_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.E_Name_Label.Name = "E_Name_Label";
            this.E_Name_Label.Size = new System.Drawing.Size(128, 32);
            this.E_Name_Label.Text = "Xin chào, !";
            // 
            // MF_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1976, 1136);
            this.Controls.Add(this.kryptonStatusStrip1);
            this.Controls.Add(this.Main_TabControl);
            this.Controls.Add(this.MF_ToolStrip);
            this.DoubleBuffered = true;
            this.Name = "MF_MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MF_MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MF_MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MF_MainForm_Load);
            this.MF_ToolStrip.ResumeLayout(false);
            this.MF_ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Main_TabControl)).EndInit();
            this.kryptonStatusStrip1.ResumeLayout(false);
            this.kryptonStatusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonToolStrip MF_ToolStrip;
        private ToolStripDropDownButton MF_Management_StripButton;
        private ToolStripMenuItem MR_ToolStripMenuItem;
        private ToolStripMenuItem P_ToolStripMenuItem;
        private ToolStripMenuItem D_ToolStripMenuItem;
        private ToolStripMenuItem S_ToolStripMenuItem;
        private ToolStripButton MF_CreateMR_StripButton;
        private Krypton.Docking.KryptonDockableNavigator Main_TabControl;
        private Krypton.Toolkit.KryptonStatusStrip kryptonStatusStrip1;
        private ToolStripStatusLabel E_Name_Label;
        private ToolStripMenuItem E_MenuItem;
        private ToolStripButton signOutButton;
    }
}