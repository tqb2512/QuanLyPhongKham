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
            this.dvgPatient = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgPatient
            // 
            this.dvgPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgPatient.Location = new System.Drawing.Point(12, 12);
            this.dvgPatient.Name = "dvgPatient";
            this.dvgPatient.RowHeadersWidth = 72;
            this.dvgPatient.RowTemplate.Height = 37;
            this.dvgPatient.Size = new System.Drawing.Size(1091, 307);
            this.dvgPatient.TabIndex = 0;
            // 
            // MRM_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 463);
            this.Controls.Add(this.dvgPatient);
            this.Name = "MRM_MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MRM_MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgPatient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dvgPatient;
    }
}