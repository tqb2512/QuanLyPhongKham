namespace QuanLyPhongKham.GUI.ServiceManagement
{
    partial class SM_PanelForm
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
            this.mainPanel = new Krypton.Toolkit.KryptonSplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel.Panel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel.Panel2)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(776, 436);
            this.mainPanel.SplitterDistance = 385;
            this.mainPanel.TabIndex = 0;
            // 
            // SM_PanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(776, 436);
            this.Controls.Add(this.mainPanel);
            this.Name = "SM_PanelForm";
            this.Text = "SM_PanelForm";
            this.Load += new System.EventHandler(this.SM_PanelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel.Panel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel.Panel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonSplitContainer mainPanel;
    }
}