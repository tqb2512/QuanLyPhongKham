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
            this.medicalRecordDataGrid = new Krypton.Toolkit.KryptonDataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.search_TableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.idSearch_textBox = new System.Windows.Forms.TextBox();
            this.dateSearch_textBox = new System.Windows.Forms.TextBox();
            this.pNameSearch_textBox = new System.Windows.Forms.TextBox();
            this.eNameSearch_textBox = new System.Windows.Forms.TextBox();
            this.diagnosisSearch_textBox = new System.Windows.Forms.TextBox();
            this.noteSearch_textBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.refresh_button = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.medicalRecordDataGrid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.search_TableLayout.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.medicalRecordDataGrid.ColumnHeadersHeight = 70;
            this.medicalRecordDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.medicalRecordDataGrid.Location = new System.Drawing.Point(3, 46);
            this.medicalRecordDataGrid.Name = "medicalRecordDataGrid";
            this.medicalRecordDataGrid.ReadOnly = true;
            this.medicalRecordDataGrid.RowHeadersVisible = false;
            this.medicalRecordDataGrid.RowHeadersWidth = 72;
            this.medicalRecordDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.medicalRecordDataGrid.RowTemplate.Height = 37;
            this.medicalRecordDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.medicalRecordDataGrid.Size = new System.Drawing.Size(946, 783);
            this.medicalRecordDataGrid.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.medicalRecordDataGrid, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.search_TableLayout, 0, 0);
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
            // search_TableLayout
            // 
            this.search_TableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.search_TableLayout.ColumnCount = 6;
            this.search_TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.search_TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.search_TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.search_TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.search_TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.search_TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.search_TableLayout.Controls.Add(this.idSearch_textBox, 0, 0);
            this.search_TableLayout.Controls.Add(this.dateSearch_textBox, 1, 0);
            this.search_TableLayout.Controls.Add(this.pNameSearch_textBox, 2, 0);
            this.search_TableLayout.Controls.Add(this.eNameSearch_textBox, 3, 0);
            this.search_TableLayout.Controls.Add(this.diagnosisSearch_textBox, 4, 0);
            this.search_TableLayout.Controls.Add(this.noteSearch_textBox, 5, 0);
            this.search_TableLayout.Location = new System.Drawing.Point(3, 3);
            this.search_TableLayout.Name = "search_TableLayout";
            this.search_TableLayout.RowCount = 1;
            this.search_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.search_TableLayout.Size = new System.Drawing.Size(946, 37);
            this.search_TableLayout.TabIndex = 1;
            // 
            // idSearch_textBox
            // 
            this.idSearch_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.idSearch_textBox.Location = new System.Drawing.Point(3, 3);
            this.idSearch_textBox.Name = "idSearch_textBox";
            this.idSearch_textBox.Size = new System.Drawing.Size(151, 35);
            this.idSearch_textBox.TabIndex = 0;
            this.idSearch_textBox.TextChanged += new System.EventHandler(this.Search_textBox_TextChanged);
            // 
            // dateSearch_textBox
            // 
            this.dateSearch_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateSearch_textBox.Location = new System.Drawing.Point(160, 3);
            this.dateSearch_textBox.Name = "dateSearch_textBox";
            this.dateSearch_textBox.Size = new System.Drawing.Size(151, 35);
            this.dateSearch_textBox.TabIndex = 1;
            this.dateSearch_textBox.TextChanged += new System.EventHandler(this.Search_textBox_TextChanged);
            // 
            // pNameSearch_textBox
            // 
            this.pNameSearch_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pNameSearch_textBox.Location = new System.Drawing.Point(317, 3);
            this.pNameSearch_textBox.Name = "pNameSearch_textBox";
            this.pNameSearch_textBox.Size = new System.Drawing.Size(151, 35);
            this.pNameSearch_textBox.TabIndex = 2;
            this.pNameSearch_textBox.TextChanged += new System.EventHandler(this.Search_textBox_TextChanged);
            // 
            // eNameSearch_textBox
            // 
            this.eNameSearch_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eNameSearch_textBox.Location = new System.Drawing.Point(474, 3);
            this.eNameSearch_textBox.Name = "eNameSearch_textBox";
            this.eNameSearch_textBox.Size = new System.Drawing.Size(151, 35);
            this.eNameSearch_textBox.TabIndex = 3;
            this.eNameSearch_textBox.TextChanged += new System.EventHandler(this.Search_textBox_TextChanged);
            // 
            // diagnosisSearch_textBox
            // 
            this.diagnosisSearch_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.diagnosisSearch_textBox.Location = new System.Drawing.Point(631, 3);
            this.diagnosisSearch_textBox.Name = "diagnosisSearch_textBox";
            this.diagnosisSearch_textBox.Size = new System.Drawing.Size(151, 35);
            this.diagnosisSearch_textBox.TabIndex = 4;
            this.diagnosisSearch_textBox.TextChanged += new System.EventHandler(this.Search_textBox_TextChanged);
            // 
            // noteSearch_textBox
            // 
            this.noteSearch_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noteSearch_textBox.Location = new System.Drawing.Point(788, 3);
            this.noteSearch_textBox.Name = "noteSearch_textBox";
            this.noteSearch_textBox.Size = new System.Drawing.Size(155, 35);
            this.noteSearch_textBox.TabIndex = 5;
            this.noteSearch_textBox.TextChanged += new System.EventHandler(this.Search_textBox_TextChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.refresh_button, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 835);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
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
            // MRM_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(976, 936);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "MRM_MainForm";
            this.Text = "MRM_MainForm";
            this.Load += new System.EventHandler(this.MRM_MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medicalRecordDataGrid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.search_TableLayout.ResumeLayout(false);
            this.search_TableLayout.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Krypton.Toolkit.KryptonDataGridView medicalRecordDataGrid;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel search_TableLayout;
        private TextBox idSearch_textBox;
        private TextBox dateSearch_textBox;
        private TextBox pNameSearch_textBox;
        private TextBox eNameSearch_textBox;
        private TextBox diagnosisSearch_textBox;
        private TextBox noteSearch_textBox;
        private TableLayoutPanel tableLayoutPanel2;
        private Krypton.Toolkit.KryptonButton refresh_button;
    }
}