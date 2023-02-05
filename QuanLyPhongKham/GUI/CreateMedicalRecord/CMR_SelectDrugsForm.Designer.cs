namespace QuanLyPhongKham.GUI.CreateMedicalRecord
{
    partial class CMR_SelectDrugsForm
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
            this.search_tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.idSearch_textBox = new System.Windows.Forms.TextBox();
            this.nameSearch_textBox = new System.Windows.Forms.TextBox();
            this.priceSearch_textBox = new System.Windows.Forms.TextBox();
            this.unitSearch_textBox = new System.Windows.Forms.TextBox();
            this.quantitySearch_textBox = new System.Windows.Forms.TextBox();
            this.Drugs_DataGridView = new Krypton.Toolkit.KryptonDataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.confirm_button = new Krypton.Toolkit.KryptonButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.search_tableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Drugs_DataGridView)).BeginInit();
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel1.Controls.Add(this.search_tableLayout, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Drugs_DataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 7);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(544, 407);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // search_tableLayout
            // 
            this.search_tableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.search_tableLayout.ColumnCount = 5;
            this.search_tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.search_tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.search_tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.search_tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.search_tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.search_tableLayout.Controls.Add(this.idSearch_textBox, 0, 0);
            this.search_tableLayout.Controls.Add(this.nameSearch_textBox, 1, 0);
            this.search_tableLayout.Controls.Add(this.priceSearch_textBox, 2, 0);
            this.search_tableLayout.Controls.Add(this.unitSearch_textBox, 3, 0);
            this.search_tableLayout.Controls.Add(this.quantitySearch_textBox, 4, 0);
            this.search_tableLayout.Location = new System.Drawing.Point(2, 2);
            this.search_tableLayout.Margin = new System.Windows.Forms.Padding(2);
            this.search_tableLayout.Name = "search_tableLayout";
            this.search_tableLayout.RowCount = 1;
            this.search_tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.search_tableLayout.Size = new System.Drawing.Size(540, 21);
            this.search_tableLayout.TabIndex = 0;
            // 
            // idSearch_textBox
            // 
            this.idSearch_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.idSearch_textBox.Location = new System.Drawing.Point(2, 2);
            this.idSearch_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.idSearch_textBox.Name = "idSearch_textBox";
            this.idSearch_textBox.Size = new System.Drawing.Size(104, 23);
            this.idSearch_textBox.TabIndex = 0;
            // 
            // nameSearch_textBox
            // 
            this.nameSearch_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameSearch_textBox.Location = new System.Drawing.Point(110, 2);
            this.nameSearch_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameSearch_textBox.Name = "nameSearch_textBox";
            this.nameSearch_textBox.Size = new System.Drawing.Size(104, 23);
            this.nameSearch_textBox.TabIndex = 1;
            // 
            // priceSearch_textBox
            // 
            this.priceSearch_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceSearch_textBox.Location = new System.Drawing.Point(218, 2);
            this.priceSearch_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.priceSearch_textBox.Name = "priceSearch_textBox";
            this.priceSearch_textBox.Size = new System.Drawing.Size(104, 23);
            this.priceSearch_textBox.TabIndex = 2;
            // 
            // unitSearch_textBox
            // 
            this.unitSearch_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unitSearch_textBox.Location = new System.Drawing.Point(326, 2);
            this.unitSearch_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.unitSearch_textBox.Name = "unitSearch_textBox";
            this.unitSearch_textBox.Size = new System.Drawing.Size(104, 23);
            this.unitSearch_textBox.TabIndex = 3;
            // 
            // quantitySearch_textBox
            // 
            this.quantitySearch_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quantitySearch_textBox.Location = new System.Drawing.Point(434, 2);
            this.quantitySearch_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.quantitySearch_textBox.Name = "quantitySearch_textBox";
            this.quantitySearch_textBox.Size = new System.Drawing.Size(104, 23);
            this.quantitySearch_textBox.TabIndex = 4;
            // 
            // Drugs_DataGridView
            // 
            this.Drugs_DataGridView.AllowUserToAddRows = false;
            this.Drugs_DataGridView.AllowUserToDeleteRows = false;
            this.Drugs_DataGridView.AllowUserToResizeColumns = false;
            this.Drugs_DataGridView.AllowUserToResizeRows = false;
            this.Drugs_DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Drugs_DataGridView.ColumnHeadersHeight = 70;
            this.Drugs_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Drugs_DataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Drugs_DataGridView.Location = new System.Drawing.Point(2, 27);
            this.Drugs_DataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.Drugs_DataGridView.Name = "Drugs_DataGridView";
            this.Drugs_DataGridView.RowHeadersVisible = false;
            this.Drugs_DataGridView.RowHeadersWidth = 72;
            this.Drugs_DataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Drugs_DataGridView.RowTemplate.Height = 37;
            this.Drugs_DataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Drugs_DataGridView.Size = new System.Drawing.Size(540, 332);
            this.Drugs_DataGridView.TabIndex = 1;
            this.Drugs_DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Drugs_DataGridView_CellClick);
            this.Drugs_DataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Drugs_DataGridView_EditingControlShowing);
            this.Drugs_DataGridView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Drugs_DataGridView_KeyPress);
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
            this.confirm_button.Values.Text = "Xác Nhận";
            this.confirm_button.Click += new System.EventHandler(this.confirm_button_Click);
            // 
            // CMR_SelectDrugsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(558, 421);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CMR_SelectDrugsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn thuốc";
            this.Load += new System.EventHandler(this.CMR_SelectDrugsForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.search_tableLayout.ResumeLayout(false);
            this.search_tableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Drugs_DataGridView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel search_tableLayout;
        private TextBox idSearch_textBox;
        private TextBox nameSearch_textBox;
        private TextBox priceSearch_textBox;
        private TextBox unitSearch_textBox;
        private TextBox quantitySearch_textBox;
        private Krypton.Toolkit.KryptonDataGridView Drugs_DataGridView;
        private TableLayoutPanel tableLayoutPanel2;
        private Krypton.Toolkit.KryptonButton confirm_button;
    }
}