namespace CREntry_OFF
{
    partial class frmChkSheetInq
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChkSheetInq));
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnEntryCheckSheet = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvInquiry = new System.Windows.Forms.DataGridView();
            this.colJobNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCOINo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGINo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustItemDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mtProdDate = new System.Windows.Forms.MaskedTextBox();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.cmbItemCode = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtProdDate = new System.Windows.Forms.DateTimePicker();
            this.cmbJobCode = new System.Windows.Forms.ComboBox();
            this.pnlButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInquiry)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.BackColor = System.Drawing.Color.BurlyWood;
            this.pnlButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlButton.Controls.Add(this.btnEntryCheckSheet);
            this.pnlButton.Controls.Add(this.btnSearch);
            this.pnlButton.Location = new System.Drawing.Point(5, 7);
            this.pnlButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(1064, 72);
            this.pnlButton.TabIndex = 8;
            // 
            // btnEntryCheckSheet
            // 
            this.btnEntryCheckSheet.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEntryCheckSheet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEntryCheckSheet.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntryCheckSheet.Location = new System.Drawing.Point(131, 8);
            this.btnEntryCheckSheet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEntryCheckSheet.Name = "btnEntryCheckSheet";
            this.btnEntryCheckSheet.Size = new System.Drawing.Size(114, 52);
            this.btnEntryCheckSheet.TabIndex = 7;
            this.btnEntryCheckSheet.Text = "Entry Check Sheet";
            this.btnEntryCheckSheet.UseVisualStyleBackColor = false;
            this.btnEntryCheckSheet.Click += new System.EventHandler(this.btnEntryCheckSheet_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(8, 6);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(111, 54);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvInquiry
            // 
            this.dgvInquiry.AllowUserToAddRows = false;
            this.dgvInquiry.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvInquiry.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInquiry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInquiry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colJobNo,
            this.colProdDate,
            this.colCOINo,
            this.colCustomerName,
            this.colItemCode,
            this.colGINo,
            this.colCustItemDesc});
            this.dgvInquiry.Location = new System.Drawing.Point(3, 104);
            this.dgvInquiry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvInquiry.Name = "dgvInquiry";
            this.dgvInquiry.ReadOnly = true;
            this.dgvInquiry.Size = new System.Drawing.Size(1056, 489);
            this.dgvInquiry.TabIndex = 0;
            // 
            // colJobNo
            // 
            this.colJobNo.HeaderText = "Job No";
            this.colJobNo.Name = "colJobNo";
            this.colJobNo.ReadOnly = true;
            this.colJobNo.Width = 130;
            // 
            // colProdDate
            // 
            this.colProdDate.HeaderText = "Prod. Date";
            this.colProdDate.Name = "colProdDate";
            this.colProdDate.ReadOnly = true;
            // 
            // colCOINo
            // 
            this.colCOINo.HeaderText = "COI No";
            this.colCOINo.Name = "colCOINo";
            this.colCOINo.ReadOnly = true;
            this.colCOINo.Width = 180;
            // 
            // colCustomerName
            // 
            this.colCustomerName.HeaderText = "Customer Name";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.ReadOnly = true;
            this.colCustomerName.Width = 300;
            // 
            // colItemCode
            // 
            this.colItemCode.HeaderText = "Item Code";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.ReadOnly = true;
            this.colItemCode.Width = 250;
            // 
            // colGINo
            // 
            this.colGINo.HeaderText = "GI No";
            this.colGINo.Name = "colGINo";
            this.colGINo.ReadOnly = true;
            this.colGINo.Width = 150;
            // 
            // colCustItemDesc
            // 
            this.colCustItemDesc.HeaderText = "Cust Item Desc";
            this.colCustItemDesc.Name = "colCustItemDesc";
            this.colCustItemDesc.ReadOnly = true;
            this.colCustItemDesc.Width = 250;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.mtProdDate);
            this.panel1.Controls.Add(this.dgvInquiry);
            this.panel1.Controls.Add(this.cmbCustomer);
            this.panel1.Controls.Add(this.cmbItemCode);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtProdDate);
            this.panel1.Controls.Add(this.cmbJobCode);
            this.panel1.Location = new System.Drawing.Point(5, 86);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 598);
            this.panel1.TabIndex = 10;
            // 
            // mtProdDate
            // 
            this.mtProdDate.Location = new System.Drawing.Point(132, 51);
            this.mtProdDate.Mask = "##/##/####";
            this.mtProdDate.Name = "mtProdDate";
            this.mtProdDate.Size = new System.Drawing.Size(122, 26);
            this.mtProdDate.TabIndex = 8;
            this.mtProdDate.TextChanged += new System.EventHandler(this.mtProdDate_TextChanged);
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(518, 53);
            this.cmbCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(221, 26);
            this.cmbCustomer.TabIndex = 7;
            this.cmbCustomer.DropDown += new System.EventHandler(this.cmbCustomer_DropDown);
            // 
            // cmbItemCode
            // 
            this.cmbItemCode.FormattingEnabled = true;
            this.cmbItemCode.Location = new System.Drawing.Point(518, 14);
            this.cmbItemCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbItemCode.Name = "cmbItemCode";
            this.cmbItemCode.Size = new System.Drawing.Size(221, 26);
            this.cmbItemCode.TabIndex = 6;
            this.cmbItemCode.DropDown += new System.EventHandler(this.cmbItemCode_DropDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(426, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Customer :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(422, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Item Code :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prod. Date :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Job No :";
            // 
            // dtProdDate
            // 
            this.dtProdDate.CalendarFont = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtProdDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtProdDate.Location = new System.Drawing.Point(257, 51);
            this.dtProdDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtProdDate.Name = "dtProdDate";
            this.dtProdDate.Size = new System.Drawing.Size(21, 26);
            this.dtProdDate.TabIndex = 1;
            this.dtProdDate.CloseUp += new System.EventHandler(this.dtProdDate_CloseUp);
            // 
            // cmbJobCode
            // 
            this.cmbJobCode.FormattingEnabled = true;
            this.cmbJobCode.Location = new System.Drawing.Point(131, 14);
            this.cmbJobCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbJobCode.Name = "cmbJobCode";
            this.cmbJobCode.Size = new System.Drawing.Size(149, 26);
            this.cmbJobCode.TabIndex = 0;
            this.cmbJobCode.DropDown += new System.EventHandler(this.cmbJobCode_DropDown);
            // 
            // frmChkSheetInq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1075, 690);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlButton);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmChkSheetInq";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check Sheet Inquiry";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            this.pnlButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInquiry)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnEntryCheckSheet;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.DataGridView dgvInquiry;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.ComboBox cmbItemCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtProdDate;
        private System.Windows.Forms.ComboBox cmbJobCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJobNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCOINo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGINo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustItemDesc;
        private System.Windows.Forms.MaskedTextBox mtProdDate;
    }
}

