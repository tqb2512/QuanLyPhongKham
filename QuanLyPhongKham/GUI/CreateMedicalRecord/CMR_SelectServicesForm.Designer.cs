namespace QuanLyPhongKham.GUI.CreateMedicalRecord
{
    partial class CMR_SelectServicesForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.servicesDataGridView = new Krypton.Toolkit.KryptonDataGridView();
            this.search_TableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.idSearch_textBox = new System.Windows.Forms.TextBox();
            this.nameSearch_textBox = new System.Windows.Forms.TextBox();
            this.unitSearch_textBox = new System.Windows.Forms.TextBox();
            this.priceSearch_textBox = new System.Windows.Forms.TextBox();
            this.descriptionSearch_textBox = new System.Windows.Forms.TextBox();
            this.quantitySearch_textBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.confirm_button = new Krypton.Toolkit.KryptonButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicesDataGridView)).BeginInit();
            this.search_TableLayout.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 7);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(544, 407);
            this.tableLayoutPanel1.TabIndex = 2;
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
            this.servicesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.servicesDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.servicesDataGridView.Location = new System.Drawing.Point(2, 27);
            this.servicesDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.servicesDataGridView.Name = "servicesDataGridView";
            this.servicesDataGridView.RowHeadersVisible = false;
            this.servicesDataGridView.RowHeadersWidth = 72;
            this.servicesDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.servicesDataGridView.RowTemplate.Height = 37;
            this.servicesDataGridView.Size = new System.Drawing.Size(540, 332);
            this.servicesDataGridView.TabIndex = 0;
            this.servicesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.servicesDataGridView_CellClick);
            this.servicesDataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.servicesDataGridView_EditingControlShowing);
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
            this.search_TableLayout.Controls.Add(this.nameSearch_textBox, 1, 0);
            this.search_TableLayout.Controls.Add(this.unitSearch_textBox, 2, 0);
            this.search_TableLayout.Controls.Add(this.priceSearch_textBox, 3, 0);
            this.search_TableLayout.Controls.Add(this.descriptionSearch_textBox, 4, 0);
            this.search_TableLayout.Controls.Add(this.quantitySearch_textBox, 5, 0);
            this.search_TableLayout.Location = new System.Drawing.Point(2, 2);
            this.search_TableLayout.Margin = new System.Windows.Forms.Padding(2);
            this.search_TableLayout.Name = "search_TableLayout";
            this.search_TableLayout.RowCount = 1;
            this.search_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.search_TableLayout.Size = new System.Drawing.Size(540, 21);
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
            this.idSearch_textBox.Size = new System.Drawing.Size(86, 23);
            this.idSearch_textBox.TabIndex = 0;
            this.idSearch_textBox.TextChanged += new System.EventHandler(this.Search_textBox_TextChanged);
            // 
            // nameSearch_textBox
            // 
            this.nameSearch_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameSearch_textBox.Location = new System.Drawing.Point(92, 2);
            this.nameSearch_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameSearch_textBox.Name = "nameSearch_textBox";
            this.nameSearch_textBox.Size = new System.Drawing.Size(86, 23);
            this.nameSearch_textBox.TabIndex = 1;
            this.nameSearch_textBox.TextChanged += new System.EventHandler(this.Search_textBox_TextChanged);
            // 
            // unitSearch_textBox
            // 
            this.unitSearch_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unitSearch_textBox.Location = new System.Drawing.Point(182, 2);
            this.unitSearch_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.unitSearch_textBox.Name = "unitSearch_textBox";
            this.unitSearch_textBox.Size = new System.Drawing.Size(86, 23);
            this.unitSearch_textBox.TabIndex = 2;
            this.unitSearch_textBox.TextChanged += new System.EventHandler(this.Search_textBox_TextChanged);
            // 
            // priceSearch_textBox
            // 
            this.priceSearch_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceSearch_textBox.Location = new System.Drawing.Point(272, 2);
            this.priceSearch_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.priceSearch_textBox.Name = "priceSearch_textBox";
            this.priceSearch_textBox.Size = new System.Drawing.Size(86, 23);
            this.priceSearch_textBox.TabIndex = 3;
            this.priceSearch_textBox.TextChanged += new System.EventHandler(this.Search_textBox_TextChanged);
            // 
            // descriptionSearch_textBox
            // 
            this.descriptionSearch_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionSearch_textBox.Location = new System.Drawing.Point(362, 2);
            this.descriptionSearch_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.descriptionSearch_textBox.Name = "descriptionSearch_textBox";
            this.descriptionSearch_textBox.Size = new System.Drawing.Size(86, 23);
            this.descriptionSearch_textBox.TabIndex = 4;
            this.descriptionSearch_textBox.TextChanged += new System.EventHandler(this.Search_textBox_TextChanged);
            // 
            // quantitySearch_textBox
            // 
            this.quantitySearch_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quantitySearch_textBox.Location = new System.Drawing.Point(452, 2);
            this.quantitySearch_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.quantitySearch_textBox.Name = "quantitySearch_textBox";
            this.quantitySearch_textBox.Size = new System.Drawing.Size(86, 23);
            this.quantitySearch_textBox.TabIndex = 5;
            this.quantitySearch_textBox.TextChanged += new System.EventHandler(this.Search_textBox_TextChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.confirm_button, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 363);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(540, 42);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // confirm_button
            // 
            this.confirm_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.confirm_button.CornerRoundingRadius = -1F;
            this.confirm_button.Location = new System.Drawing.Point(433, 2);
            this.confirm_button.Margin = new System.Windows.Forms.Padding(2);
            this.confirm_button.Name = "confirm_button";
            this.confirm_button.Size = new System.Drawing.Size(105, 38);
            this.confirm_button.TabIndex = 0;
            this.confirm_button.Values.Text = "Xác nhận";
            this.confirm_button.Click += new System.EventHandler(this.confirm_button_Click);
            // 
            // CMR_SelectServicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(558, 421);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CMR_SelectServicesForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn dịch vụ";
            this.Load += new System.EventHandler(this.CMR_SelectServicesForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.servicesDataGridView)).EndInit();
            this.search_TableLayout.ResumeLayout(false);
            this.search_TableLayout.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        public Krypton.Toolkit.KryptonDataGridView servicesDataGridView;
        private TableLayoutPanel search_TableLayout;
        private TextBox idSearch_textBox;
        private TextBox nameSearch_textBox;
        private TextBox unitSearch_textBox;
        private TextBox priceSearch_textBox;
        private TextBox descriptionSearch_textBox;
        public Krypton.Toolkit.KryptonButton confirm_button;
        private TextBox quantitySearch_textBox;
        private TableLayoutPanel tableLayoutPanel2;
    }
}