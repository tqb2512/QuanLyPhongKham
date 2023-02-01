namespace QuanLyPhongKham.GUI.PatientManagement
{
    partial class PM_MainForm
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
            this.patientDataGridView = new Krypton.Toolkit.KryptonDataGridView();
            this.search_TableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.descriptionSearch_textBox = new System.Windows.Forms.TextBox();
            this.idSearch_textBox = new System.Windows.Forms.TextBox();
            this.nameSearch_textBox = new System.Windows.Forms.TextBox();
            this.unitSearch_textBox = new System.Windows.Forms.TextBox();
            this.priceSearch_textBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.add_button = new Krypton.Toolkit.KryptonButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGridView)).BeginInit();
            this.search_TableLayout.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.patientDataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.search_TableLayout, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(511, 257);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // patientDataGridView
            // 
            this.patientDataGridView.AllowUserToAddRows = false;
            this.patientDataGridView.AllowUserToDeleteRows = false;
            this.patientDataGridView.AllowUserToResizeColumns = false;
            this.patientDataGridView.AllowUserToResizeRows = false;
            this.patientDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.patientDataGridView.ColumnHeadersHeight = 70;
            this.patientDataGridView.Location = new System.Drawing.Point(2, 37);
            this.patientDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.patientDataGridView.Name = "patientDataGridView";
            this.patientDataGridView.ReadOnly = true;
            this.patientDataGridView.RowHeadersVisible = false;
            this.patientDataGridView.RowHeadersWidth = 72;
            this.patientDataGridView.RowTemplate.Height = 37;
            this.patientDataGridView.Size = new System.Drawing.Size(507, 178);
            this.patientDataGridView.TabIndex = 0;
            this.patientDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientDataGridView_CellContentClick);
            this.patientDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientDataGridView_CellDoubleClick);
            // 
            // search_TableLayout
            // 
            this.search_TableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.search_TableLayout.ColumnCount = 6;
            this.search_TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.search_TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.search_TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.search_TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.search_TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.search_TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.search_TableLayout.Controls.Add(this.textBox1, 0, 0);
            this.search_TableLayout.Controls.Add(this.descriptionSearch_textBox, 0, 0);
            this.search_TableLayout.Controls.Add(this.idSearch_textBox, 0, 0);
            this.search_TableLayout.Controls.Add(this.nameSearch_textBox, 1, 0);
            this.search_TableLayout.Controls.Add(this.unitSearch_textBox, 2, 0);
            this.search_TableLayout.Controls.Add(this.priceSearch_textBox, 3, 0);
            this.search_TableLayout.Location = new System.Drawing.Point(2, 2);
            this.search_TableLayout.Margin = new System.Windows.Forms.Padding(2);
            this.search_TableLayout.Name = "search_TableLayout";
            this.search_TableLayout.RowCount = 1;
            this.search_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.search_TableLayout.Size = new System.Drawing.Size(507, 31);
            this.search_TableLayout.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(172, 2);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(81, 23);
            this.textBox1.TabIndex = 6;
            // 
            // descriptionSearch_textBox
            // 
            this.descriptionSearch_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionSearch_textBox.Location = new System.Drawing.Point(87, 2);
            this.descriptionSearch_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.descriptionSearch_textBox.Name = "descriptionSearch_textBox";
            this.descriptionSearch_textBox.Size = new System.Drawing.Size(81, 23);
            this.descriptionSearch_textBox.TabIndex = 5;
            // 
            // idSearch_textBox
            // 
            this.idSearch_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.idSearch_textBox.Location = new System.Drawing.Point(2, 2);
            this.idSearch_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.idSearch_textBox.Name = "idSearch_textBox";
            this.idSearch_textBox.Size = new System.Drawing.Size(81, 23);
            this.idSearch_textBox.TabIndex = 0;
            // 
            // nameSearch_textBox
            // 
            this.nameSearch_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameSearch_textBox.Location = new System.Drawing.Point(257, 2);
            this.nameSearch_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameSearch_textBox.Name = "nameSearch_textBox";
            this.nameSearch_textBox.Size = new System.Drawing.Size(81, 23);
            this.nameSearch_textBox.TabIndex = 1;
            // 
            // unitSearch_textBox
            // 
            this.unitSearch_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unitSearch_textBox.Location = new System.Drawing.Point(342, 2);
            this.unitSearch_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.unitSearch_textBox.Name = "unitSearch_textBox";
            this.unitSearch_textBox.Size = new System.Drawing.Size(81, 23);
            this.unitSearch_textBox.TabIndex = 2;
            // 
            // priceSearch_textBox
            // 
            this.priceSearch_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceSearch_textBox.Location = new System.Drawing.Point(427, 2);
            this.priceSearch_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.priceSearch_textBox.Name = "priceSearch_textBox";
            this.priceSearch_textBox.Size = new System.Drawing.Size(78, 23);
            this.priceSearch_textBox.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 219);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(507, 36);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.add_button, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(291, 2);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(214, 32);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // add_button
            // 
            this.add_button.CornerRoundingRadius = -1F;
            this.add_button.Location = new System.Drawing.Point(109, 2);
            this.add_button.Margin = new System.Windows.Forms.Padding(2);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(103, 28);
            this.add_button.TabIndex = 0;
            this.add_button.Values.Text = "Thêm";
            // 
            // PM_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PM_MainForm";
            this.Text = "PM_MainForm";
            this.Load += new System.EventHandler(this.PM_MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.PM_MainForm_SizeChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGridView)).EndInit();
            this.search_TableLayout.ResumeLayout(false);
            this.search_TableLayout.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        public Krypton.Toolkit.KryptonButton add_button;
        public Krypton.Toolkit.KryptonDataGridView patientDataGridView;
        private TableLayoutPanel search_TableLayout;
        private TextBox textBox1;
        private TextBox descriptionSearch_textBox;
        private TextBox idSearch_textBox;
        private TextBox nameSearch_textBox;
        private TextBox unitSearch_textBox;
        private TextBox priceSearch_textBox;
    }
}