namespace QuanLyPhongKham.GUI.ServiceManagement
{
    partial class SM_MainForm
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
            this.servicesDataGridView = new Krypton.Toolkit.KryptonDataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.search_TableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.idSearch_textBox = new System.Windows.Forms.TextBox();
            this.nameSearch_textBox = new System.Windows.Forms.TextBox();
            this.unitSearch_textBox = new System.Windows.Forms.TextBox();
            this.priceSearch_textBox = new System.Windows.Forms.TextBox();
            this.descriptionSearch_textBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.add_button = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.servicesDataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.search_TableLayout.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // servicesDataGridView
            // 
            this.servicesDataGridView.AllowUserToAddRows = false;
            this.servicesDataGridView.AllowUserToDeleteRows = false;
            this.servicesDataGridView.AllowUserToResizeColumns = false;
            this.servicesDataGridView.AllowUserToResizeRows = false;
            this.servicesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.servicesDataGridView.ColumnHeadersHeight = 70;
            this.servicesDataGridView.Location = new System.Drawing.Point(2, 24);
            this.servicesDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.servicesDataGridView.Name = "servicesDataGridView";
            this.servicesDataGridView.ReadOnly = true;
            this.servicesDataGridView.RowHeadersVisible = false;
            this.servicesDataGridView.RowHeadersWidth = 72;
            this.servicesDataGridView.RowTemplate.Height = 37;
            this.servicesDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.servicesDataGridView.Size = new System.Drawing.Size(946, 783);
            this.servicesDataGridView.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.servicesDataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.search_TableLayout, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 6);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
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
            this.search_TableLayout.ColumnCount = 5;
            this.search_TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.search_TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.search_TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.search_TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.search_TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.search_TableLayout.Controls.Add(this.idSearch_textBox, 0, 0);
            this.search_TableLayout.Controls.Add(this.nameSearch_textBox, 1, 0);
            this.search_TableLayout.Controls.Add(this.unitSearch_textBox, 2, 0);
            this.search_TableLayout.Controls.Add(this.priceSearch_textBox, 3, 0);
            this.search_TableLayout.Controls.Add(this.descriptionSearch_textBox, 4, 0);
            this.search_TableLayout.Location = new System.Drawing.Point(2, 2);
            this.search_TableLayout.Margin = new System.Windows.Forms.Padding(2);
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
            this.idSearch_textBox.Location = new System.Drawing.Point(2, 2);
            this.idSearch_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.idSearch_textBox.Name = "idSearch_textBox";
            this.idSearch_textBox.Size = new System.Drawing.Size(183, 35);
            this.idSearch_textBox.TabIndex = 0;
            this.idSearch_textBox.TextChanged += new System.EventHandler(this.Search_textBox_TextChanged);
            // 
            // nameSearch_textBox
            // 
            this.nameSearch_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameSearch_textBox.Location = new System.Drawing.Point(192, 3);
            this.nameSearch_textBox.Name = "nameSearch_textBox";
            this.nameSearch_textBox.Size = new System.Drawing.Size(183, 35);
            this.nameSearch_textBox.TabIndex = 1;
            this.nameSearch_textBox.TextChanged += new System.EventHandler(this.Search_textBox_TextChanged);
            // 
            // unitSearch_textBox
            // 
            this.unitSearch_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unitSearch_textBox.Location = new System.Drawing.Point(381, 3);
            this.unitSearch_textBox.Name = "unitSearch_textBox";
            this.unitSearch_textBox.Size = new System.Drawing.Size(183, 35);
            this.unitSearch_textBox.TabIndex = 2;
            this.unitSearch_textBox.TextChanged += new System.EventHandler(this.Search_textBox_TextChanged);
            // 
            // priceSearch_textBox
            // 
            this.priceSearch_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceSearch_textBox.Location = new System.Drawing.Point(570, 3);
            this.priceSearch_textBox.Name = "priceSearch_textBox";
            this.priceSearch_textBox.Size = new System.Drawing.Size(183, 35);
            this.priceSearch_textBox.TabIndex = 3;
            this.priceSearch_textBox.TextChanged += new System.EventHandler(this.Search_textBox_TextChanged);
            // 
            // descriptionSearch_textBox
            // 
            this.descriptionSearch_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionSearch_textBox.Location = new System.Drawing.Point(759, 3);
            this.descriptionSearch_textBox.Name = "descriptionSearch_textBox";
            this.descriptionSearch_textBox.Size = new System.Drawing.Size(184, 35);
            this.descriptionSearch_textBox.TabIndex = 4;
            this.descriptionSearch_textBox.TextChanged += new System.EventHandler(this.Search_textBox_TextChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tableLayoutPanel2.Controls.Add(this.add_button, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 835);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(946, 74);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // add_button
            // 
            this.add_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add_button.CornerRoundingRadius = -1F;
            this.add_button.Location = new System.Drawing.Point(759, 3);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(184, 68);
            this.add_button.TabIndex = 0;
            this.add_button.Values.Text = "Thêm";
            // 
            // SM_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(976, 936);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "SM_MainForm";
            this.Text = "SM_MainForm";
            this.Load += new System.EventHandler(this.SM_MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.servicesDataGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.search_TableLayout.ResumeLayout(false);
            this.search_TableLayout.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel search_TableLayout;
        private TextBox idSearch_textBox;
        private TextBox nameSearch_textBox;
        private TextBox unitSearch_textBox;
        private TextBox priceSearch_textBox;
        private TextBox descriptionSearch_textBox;
        public Krypton.Toolkit.KryptonDataGridView servicesDataGridView;
        private TableLayoutPanel tableLayoutPanel2;
        public Krypton.Toolkit.KryptonButton add_button;
    }
}