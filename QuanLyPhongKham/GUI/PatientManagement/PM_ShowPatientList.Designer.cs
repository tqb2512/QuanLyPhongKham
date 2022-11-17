﻿namespace QuanLyPhongKham.GUI.PatientManagement
{
    partial class PM_ShowPatientList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDeletePatient = new System.Windows.Forms.Button();
            this.buttonEditPatient = new System.Windows.Forms.Button();
            this.buttonDetailPatient = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonImportPatient = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 441);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonImportPatient);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.buttonDeletePatient);
            this.panel2.Controls.Add(this.buttonEditPatient);
            this.panel2.Controls.Add(this.buttonDetailPatient);
            this.panel2.Location = new System.Drawing.Point(189, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(607, 76);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Thông tin bệnh nhân";
            // 
            // buttonDeletePatient
            // 
            this.buttonDeletePatient.Location = new System.Drawing.Point(502, 22);
            this.buttonDeletePatient.Name = "buttonDeletePatient";
            this.buttonDeletePatient.Size = new System.Drawing.Size(92, 42);
            this.buttonDeletePatient.TabIndex = 3;
            this.buttonDeletePatient.Text = "Xóa";
            this.buttonDeletePatient.UseVisualStyleBackColor = true;
            // 
            // buttonEditPatient
            // 
            this.buttonEditPatient.Location = new System.Drawing.Point(404, 22);
            this.buttonEditPatient.Name = "buttonEditPatient";
            this.buttonEditPatient.Size = new System.Drawing.Size(92, 42);
            this.buttonEditPatient.TabIndex = 2;
            this.buttonEditPatient.Text = "Sửa đổi";
            this.buttonEditPatient.UseVisualStyleBackColor = true;
            this.buttonEditPatient.Click += new System.EventHandler(this.buttonEditPatient_Click);
            // 
            // buttonDetailPatient
            // 
            this.buttonDetailPatient.Location = new System.Drawing.Point(306, 22);
            this.buttonDetailPatient.Name = "buttonDetailPatient";
            this.buttonDetailPatient.Size = new System.Drawing.Size(92, 42);
            this.buttonDetailPatient.TabIndex = 1;
            this.buttonDetailPatient.Text = "Chi tiết";
            this.buttonDetailPatient.UseVisualStyleBackColor = true;
            this.buttonDetailPatient.Click += new System.EventHandler(this.buttonDetailPatient_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(189, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(606, 359);
            this.panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(607, 359);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonImportPatient
            // 
            this.buttonImportPatient.Location = new System.Drawing.Point(198, 22);
            this.buttonImportPatient.Name = "buttonImportPatient";
            this.buttonImportPatient.Size = new System.Drawing.Size(102, 42);
            this.buttonImportPatient.TabIndex = 5;
            this.buttonImportPatient.Text = "Thêm thông tin";
            this.buttonImportPatient.UseVisualStyleBackColor = true;
            this.buttonImportPatient.Click += new System.EventHandler(this.buttonImportPatient_Click);
            // 
            // PM_ShowPatientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PM_ShowPatientList";
            this.Text = "ShowPatientListForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Button buttonDeletePatient;
        private Button buttonEditPatient;
        private Button buttonDetailPatient;
        private DataGridView dataGridView1;
        private Button buttonImportPatient;
    }
}