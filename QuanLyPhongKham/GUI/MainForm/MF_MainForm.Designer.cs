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
            this.bệnhÁnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bệnhNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thuốcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dịchVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MF_CreateMR_StripButton = new System.Windows.Forms.ToolStripButton();
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
            this.MF_CreateMR_StripButton});
            this.MF_ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.MF_ToolStrip.Name = "MF_ToolStrip";
            this.MF_ToolStrip.Size = new System.Drawing.Size(1776, 42);
            this.MF_ToolStrip.TabIndex = 2;
            this.MF_ToolStrip.Text = "kryptonToolStrip1";
            // 
            // MF_Management_StripButton
            // 
            this.MF_Management_StripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.MF_Management_StripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bệnhÁnToolStripMenuItem,
            this.bệnhNhânToolStripMenuItem,
            this.thuốcToolStripMenuItem,
            this.dịchVụToolStripMenuItem});
            this.MF_Management_StripButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MF_Management_StripButton.Image = ((System.Drawing.Image)(resources.GetObject("MF_Management_StripButton.Image")));
            this.MF_Management_StripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MF_Management_StripButton.Name = "MF_Management_StripButton";
            this.MF_Management_StripButton.Size = new System.Drawing.Size(119, 36);
            this.MF_Management_StripButton.Text = "Quản lý";
            // 
            // bệnhÁnToolStripMenuItem
            // 
            this.bệnhÁnToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bệnhÁnToolStripMenuItem.Name = "bệnhÁnToolStripMenuItem";
            this.bệnhÁnToolStripMenuItem.Size = new System.Drawing.Size(249, 40);
            this.bệnhÁnToolStripMenuItem.Text = "Bệnh án";
            this.bệnhÁnToolStripMenuItem.Click += new System.EventHandler(this.MedicalRecord_MenuItem_Click);
            // 
            // bệnhNhânToolStripMenuItem
            // 
            this.bệnhNhânToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bệnhNhânToolStripMenuItem.Name = "bệnhNhânToolStripMenuItem";
            this.bệnhNhânToolStripMenuItem.Size = new System.Drawing.Size(249, 40);
            this.bệnhNhânToolStripMenuItem.Text = "Bệnh nhân";
            // 
            // thuốcToolStripMenuItem
            // 
            this.thuốcToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.thuốcToolStripMenuItem.Name = "thuốcToolStripMenuItem";
            this.thuốcToolStripMenuItem.Size = new System.Drawing.Size(249, 40);
            this.thuốcToolStripMenuItem.Text = "Thuốc";
            // 
            // dịchVụToolStripMenuItem
            // 
            this.dịchVụToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dịchVụToolStripMenuItem.Name = "dịchVụToolStripMenuItem";
            this.dịchVụToolStripMenuItem.Size = new System.Drawing.Size(249, 40);
            this.dịchVụToolStripMenuItem.Text = "Dịch vụ";
            this.dịchVụToolStripMenuItem.Click += new System.EventHandler(this.Service_MenuItem_Click);
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
            this.Main_TabControl.Size = new System.Drawing.Size(1776, 849);
            this.Main_TabControl.TabIndex = 1;
            this.Main_TabControl.Text = "kryptonDockableNavigator1";
            // 
            // kryptonStatusStrip1
            // 
            this.kryptonStatusStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonStatusStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.kryptonStatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.E_Name_Label});
            this.kryptonStatusStrip1.Location = new System.Drawing.Point(0, 895);
            this.kryptonStatusStrip1.Name = "kryptonStatusStrip1";
            this.kryptonStatusStrip1.ProgressBars = null;
            this.kryptonStatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.kryptonStatusStrip1.Size = new System.Drawing.Size(1776, 41);
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
            this.ClientSize = new System.Drawing.Size(1776, 936);
            this.Controls.Add(this.kryptonStatusStrip1);
            this.Controls.Add(this.Main_TabControl);
            this.Controls.Add(this.MF_ToolStrip);
            this.Name = "MF_MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MF_MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MF_MainForm_FormClosed);
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
        private ToolStripMenuItem bệnhÁnToolStripMenuItem;
        private ToolStripMenuItem bệnhNhânToolStripMenuItem;
        private ToolStripMenuItem thuốcToolStripMenuItem;
        private ToolStripMenuItem dịchVụToolStripMenuItem;
        private ToolStripButton MF_CreateMR_StripButton;
        private Krypton.Docking.KryptonDockableNavigator Main_TabControl;
        private Krypton.Toolkit.KryptonStatusStrip kryptonStatusStrip1;
        private ToolStripStatusLabel E_Name_Label;
    }
}