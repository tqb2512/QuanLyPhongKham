namespace QuanLyPhongKham.GUI.MedicalRecordManagement
{
    partial class MRM_MainForm
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
            this.medicalRecordDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.medicalRecordDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // medicalRecordDataGrid
            // 
            this.medicalRecordDataGrid.AllowUserToAddRows = false;
            this.medicalRecordDataGrid.AllowUserToDeleteRows = false;
            this.medicalRecordDataGrid.AllowUserToResizeColumns = false;
            this.medicalRecordDataGrid.AllowUserToResizeRows = false;
            this.medicalRecordDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.medicalRecordDataGrid.ColumnHeadersHeight = 40;
            this.medicalRecordDataGrid.Location = new System.Drawing.Point(12, 12);
            this.medicalRecordDataGrid.Name = "medicalRecordDataGrid";
            this.medicalRecordDataGrid.ReadOnly = true;
            this.medicalRecordDataGrid.RowHeadersVisible = false;
            this.medicalRecordDataGrid.RowHeadersWidth = 72;
            this.medicalRecordDataGrid.RowTemplate.Height = 37;
            this.medicalRecordDataGrid.Size = new System.Drawing.Size(1499, 760);
            this.medicalRecordDataGrid.TabIndex = 0;
            // 
            // MRM_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1523, 784);
            this.Controls.Add(this.medicalRecordDataGrid);
            this.Name = "MRM_MainForm";
            this.Text = "MRM_MainForm";
            this.Load += new System.EventHandler(this.MRM_MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medicalRecordDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DataGridView medicalRecordDataGrid;
    }
}