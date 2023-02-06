namespace QuanLyPhongKham.GUI.CreateMedicalRecord
{
    partial class CMR_SelectPatientForm
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Confirm_Button = new Krypton.Toolkit.KryptonButton();
            this.Patient_DataGridView = new Krypton.Toolkit.KryptonDataGridView();
            this.search_tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.idSearch_textBox = new System.Windows.Forms.TextBox();
            this.nameSearch_textBox = new System.Windows.Forms.TextBox();
            this.sexSearch_textBox = new System.Windows.Forms.TextBox();
            this.addressSearch_textBox = new System.Windows.Forms.TextBox();
            this.phoneSearch_textBox = new System.Windows.Forms.TextBox();
            this.dobSearch_textBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Patient_DataGridView)).BeginInit();
            this.search_tableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Patient_DataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.search_tableLayout, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 7);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(544, 407);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.68288F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.31712F));
            this.tableLayoutPanel2.Controls.Add(this.Confirm_Button, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 363);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(540, 42);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // Confirm_Button
            // 
            this.Confirm_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Confirm_Button.CornerRoundingRadius = -1F;
            this.Confirm_Button.Location = new System.Drawing.Point(433, 2);
            this.Confirm_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Confirm_Button.Name = "Confirm_Button";
            this.Confirm_Button.Size = new System.Drawing.Size(105, 38);
            this.Confirm_Button.TabIndex = 1;
            this.Confirm_Button.Values.Text = "Xác nhận";
            this.Confirm_Button.Click += new System.EventHandler(this.Confirm_Button_Click);
            // 
            // Patient_DataGridView
            // 
            this.Patient_DataGridView.AllowUserToAddRows = false;
            this.Patient_DataGridView.AllowUserToDeleteRows = false;
            this.Patient_DataGridView.AllowUserToResizeColumns = false;
            this.Patient_DataGridView.AllowUserToResizeRows = false;
            this.Patient_DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Patient_DataGridView.ColumnHeadersHeight = 70;
            this.Patient_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Patient_DataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Patient_DataGridView.Location = new System.Drawing.Point(2, 27);
            this.Patient_DataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.Patient_DataGridView.Name = "Patient_DataGridView";
            this.Patient_DataGridView.RowHeadersVisible = false;
            this.Patient_DataGridView.RowHeadersWidth = 72;
            this.Patient_DataGridView.RowTemplate.Height = 37;
            this.Patient_DataGridView.Size = new System.Drawing.Size(540, 332);
            this.Patient_DataGridView.TabIndex = 2;
            // 
            // search_tableLayout
            // 
            this.search_tableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.search_tableLayout.ColumnCount = 6;
            this.search_tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.search_tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.search_tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.search_tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.search_tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.search_tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.search_tableLayout.Controls.Add(this.idSearch_textBox, 0, 0);
            this.search_tableLayout.Controls.Add(this.nameSearch_textBox, 1, 0);
            this.search_tableLayout.Controls.Add(this.sexSearch_textBox, 2, 0);
            this.search_tableLayout.Controls.Add(this.addressSearch_textBox, 3, 0);
            this.search_tableLayout.Controls.Add(this.phoneSearch_textBox, 4, 0);
            this.search_tableLayout.Controls.Add(this.dobSearch_textBox, 5, 0);
            this.search_tableLayout.Location = new System.Drawing.Point(2, 2);
            this.search_tableLayout.Margin = new System.Windows.Forms.Padding(2);
            this.search_tableLayout.Name = "search_tableLayout";
            this.search_tableLayout.RowCount = 1;
            this.search_tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.search_tableLayout.Size = new System.Drawing.Size(540, 21);
            this.search_tableLayout.TabIndex = 3;
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
            // sexSearch_textBox
            // 
            this.sexSearch_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sexSearch_textBox.Location = new System.Drawing.Point(182, 2);
            this.sexSearch_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.sexSearch_textBox.Name = "sexSearch_textBox";
            this.sexSearch_textBox.Size = new System.Drawing.Size(86, 23);
            this.sexSearch_textBox.TabIndex = 2;
            this.sexSearch_textBox.TextChanged += new System.EventHandler(this.Search_textBox_TextChanged);
            // 
            // addressSearch_textBox
            // 
            this.addressSearch_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressSearch_textBox.Location = new System.Drawing.Point(272, 2);
            this.addressSearch_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.addressSearch_textBox.Name = "addressSearch_textBox";
            this.addressSearch_textBox.Size = new System.Drawing.Size(86, 23);
            this.addressSearch_textBox.TabIndex = 3;
            this.addressSearch_textBox.TextChanged += new System.EventHandler(this.Search_textBox_TextChanged);
            // 
            // phoneSearch_textBox
            // 
            this.phoneSearch_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneSearch_textBox.Location = new System.Drawing.Point(362, 2);
            this.phoneSearch_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.phoneSearch_textBox.Name = "phoneSearch_textBox";
            this.phoneSearch_textBox.Size = new System.Drawing.Size(86, 23);
            this.phoneSearch_textBox.TabIndex = 4;
            this.phoneSearch_textBox.TextChanged += new System.EventHandler(this.Search_textBox_TextChanged);
            // 
            // dobSearch_textBox
            // 
            this.dobSearch_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dobSearch_textBox.Location = new System.Drawing.Point(452, 2);
            this.dobSearch_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.dobSearch_textBox.Name = "dobSearch_textBox";
            this.dobSearch_textBox.Size = new System.Drawing.Size(86, 23);
            this.dobSearch_textBox.TabIndex = 5;
            this.dobSearch_textBox.TextChanged += new System.EventHandler(this.Search_textBox_TextChanged);
            // 
            // CMR_SelectPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(558, 421);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CMR_SelectPatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn bệnh nhân";
            this.Load += new System.EventHandler(this.CMR_SelectPatientForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Patient_DataGridView)).EndInit();
            this.search_tableLayout.ResumeLayout(false);
            this.search_tableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Krypton.Toolkit.KryptonDataGridView Patient_DataGridView;
        private TableLayoutPanel search_tableLayout;
        private TextBox idSearch_textBox;
        private TextBox nameSearch_textBox;
        private TextBox sexSearch_textBox;
        private TextBox addressSearch_textBox;
        private TextBox phoneSearch_textBox;
        private TextBox dobSearch_textBox;
        private Krypton.Toolkit.KryptonButton Confirm_Button;
    }
}