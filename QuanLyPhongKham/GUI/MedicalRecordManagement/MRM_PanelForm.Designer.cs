namespace QuanLyPhongKham.GUI.MedicalRecordManagement
{
    partial class MRM_PanelForm
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.mainPanel = new Krypton.Toolkit.KryptonSplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel.Panel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel.Panel2)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(5, 450);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.Location = new System.Drawing.Point(5, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(795, 450);
            this.mainPanel.SplitterDistance = 398;
            this.mainPanel.TabIndex = 1;
            // 
            // MRM_PanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.splitter1);
            this.Name = "MRM_PanelForm";
            this.Text = "MRM_PanelForm";
            this.Load += new System.EventHandler(this.MRM_PanelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel.Panel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel.Panel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Splitter splitter1;
        private Krypton.Toolkit.KryptonSplitContainer mainPanel;
    }
}