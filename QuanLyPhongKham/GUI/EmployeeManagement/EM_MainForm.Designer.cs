namespace QuanLyPhongKham.GUI.EmployeeManagement
{
    partial class EM_MainForm
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
            this.Employee_DataGridView = new Krypton.Toolkit.KryptonDataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Search_TableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.idSearch_textBox = new System.Windows.Forms.TextBox();
            this.nameSearch_textBox = new System.Windows.Forms.TextBox();
            this.positionSearch_textBox = new System.Windows.Forms.TextBox();
            this.userNameSearch_textBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.refresh_button = new Krypton.Toolkit.KryptonButton();
            this.add_button = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.Employee_DataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.Search_TableLayout.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Employee_DataGridView
            // 
            this.Employee_DataGridView.AllowUserToAddRows = false;
            this.Employee_DataGridView.AllowUserToDeleteRows = false;
            this.Employee_DataGridView.AllowUserToResizeColumns = false;
            this.Employee_DataGridView.AllowUserToResizeRows = false;
            this.Employee_DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Employee_DataGridView.ColumnHeadersHeight = 70;
            this.Employee_DataGridView.Location = new System.Drawing.Point(3, 46);
            this.Employee_DataGridView.Name = "Employee_DataGridView";
            this.Employee_DataGridView.RowHeadersVisible = false;
            this.Employee_DataGridView.RowHeadersWidth = 72;
            this.Employee_DataGridView.RowTemplate.Height = 37;
            this.Employee_DataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Employee_DataGridView.Size = new System.Drawing.Size(946, 783);
            this.Employee_DataGridView.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Employee_DataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Search_TableLayout, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(952, 912);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // Search_TableLayout
            // 
            this.Search_TableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Search_TableLayout.ColumnCount = 4;
            this.Search_TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Search_TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Search_TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Search_TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Search_TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Search_TableLayout.Controls.Add(this.idSearch_textBox, 0, 0);
            this.Search_TableLayout.Controls.Add(this.nameSearch_textBox, 1, 0);
            this.Search_TableLayout.Controls.Add(this.positionSearch_textBox, 2, 0);
            this.Search_TableLayout.Controls.Add(this.userNameSearch_textBox, 3, 0);
            this.Search_TableLayout.Location = new System.Drawing.Point(3, 3);
            this.Search_TableLayout.Name = "Search_TableLayout";
            this.Search_TableLayout.RowCount = 1;
            this.Search_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Search_TableLayout.Size = new System.Drawing.Size(946, 37);
            this.Search_TableLayout.TabIndex = 1;
            // 
            // idSearch_textBox
            // 
            this.idSearch_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.idSearch_textBox.Location = new System.Drawing.Point(3, 3);
            this.idSearch_textBox.Name = "idSearch_textBox";
            this.idSearch_textBox.Size = new System.Drawing.Size(230, 35);
            this.idSearch_textBox.TabIndex = 0;
            this.idSearch_textBox.TextChanged += new System.EventHandler(this.Search_textBox_TextChanged);
            // 
            // nameSearch_textBox
            // 
            this.nameSearch_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameSearch_textBox.Location = new System.Drawing.Point(239, 3);
            this.nameSearch_textBox.Name = "nameSearch_textBox";
            this.nameSearch_textBox.Size = new System.Drawing.Size(230, 35);
            this.nameSearch_textBox.TabIndex = 1;
            this.nameSearch_textBox.TextChanged += new System.EventHandler(this.Search_textBox_TextChanged);
            // 
            // positionSearch_textBox
            // 
            this.positionSearch_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.positionSearch_textBox.Location = new System.Drawing.Point(475, 3);
            this.positionSearch_textBox.Name = "positionSearch_textBox";
            this.positionSearch_textBox.Size = new System.Drawing.Size(230, 35);
            this.positionSearch_textBox.TabIndex = 2;
            this.positionSearch_textBox.TextChanged += new System.EventHandler(this.Search_textBox_TextChanged);
            // 
            // userNameSearch_textBox
            // 
            this.userNameSearch_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userNameSearch_textBox.Location = new System.Drawing.Point(711, 3);
            this.userNameSearch_textBox.Name = "userNameSearch_textBox";
            this.userNameSearch_textBox.Size = new System.Drawing.Size(232, 35);
            this.userNameSearch_textBox.TabIndex = 3;
            this.userNameSearch_textBox.TextChanged += new System.EventHandler(this.Search_textBox_TextChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tableLayoutPanel2.Controls.Add(this.refresh_button, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.add_button, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 835);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(946, 74);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // refresh_button
            // 
            this.refresh_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refresh_button.CornerRoundingRadius = -1F;
            this.refresh_button.Location = new System.Drawing.Point(759, 3);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(184, 68);
            this.refresh_button.TabIndex = 0;
            this.refresh_button.Values.Text = "Làm mới";
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // add_button
            // 
            this.add_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add_button.CornerRoundingRadius = -1F;
            this.add_button.Location = new System.Drawing.Point(569, 3);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(184, 68);
            this.add_button.TabIndex = 1;
            this.add_button.Values.Text = "Thêm";
            // 
            // EM_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(976, 936);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "EM_MainForm";
            this.Text = "EM_MainForm";
            this.Load += new System.EventHandler(this.EM_MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Employee_DataGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.Search_TableLayout.ResumeLayout(false);
            this.Search_TableLayout.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel Search_TableLayout;
        private TextBox idSearch_textBox;
        private TextBox nameSearch_textBox;
        private TextBox positionSearch_textBox;
        private TextBox userNameSearch_textBox;
        private TableLayoutPanel tableLayoutPanel2;
        private Krypton.Toolkit.KryptonButton refresh_button;
        public Krypton.Toolkit.KryptonDataGridView Employee_DataGridView;
        public Krypton.Toolkit.KryptonButton add_button;
    }
}