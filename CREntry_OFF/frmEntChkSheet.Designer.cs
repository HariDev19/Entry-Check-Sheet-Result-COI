namespace CREntry_OFF
{
    partial class frmEntChkSheet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntChkSheet));
            this.pnlEntry = new System.Windows.Forms.Panel();
            this.txtJobNo = new System.Windows.Forms.TextBox();
            this.txtSpec = new System.Windows.Forms.TextBox();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.dgvCheckSheet = new System.Windows.Forms.DataGridView();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTestCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTestMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStandart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnEntryResult = new System.Windows.Forms.Button();
            this.btnRetrieveData = new System.Windows.Forms.Button();
            this.pnlEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckSheet)).BeginInit();
            this.pnlButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEntry
            // 
            this.pnlEntry.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEntry.Controls.Add(this.txtJobNo);
            this.pnlEntry.Controls.Add(this.txtSpec);
            this.pnlEntry.Controls.Add(this.txtCustomer);
            this.pnlEntry.Controls.Add(this.txtItemCode);
            this.pnlEntry.Controls.Add(this.dgvCheckSheet);
            this.pnlEntry.Controls.Add(this.label4);
            this.pnlEntry.Controls.Add(this.label3);
            this.pnlEntry.Controls.Add(this.label2);
            this.pnlEntry.Controls.Add(this.label1);
            this.pnlEntry.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlEntry.Location = new System.Drawing.Point(5, 83);
            this.pnlEntry.Name = "pnlEntry";
            this.pnlEntry.Size = new System.Drawing.Size(1117, 551);
            this.pnlEntry.TabIndex = 10;
            // 
            // txtJobNo
            // 
            this.txtJobNo.Location = new System.Drawing.Point(131, 29);
            this.txtJobNo.Name = "txtJobNo";
            this.txtJobNo.Size = new System.Drawing.Size(170, 26);
            this.txtJobNo.TabIndex = 11;
            // 
            // txtSpec
            // 
            this.txtSpec.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtSpec.Location = new System.Drawing.Point(639, 78);
            this.txtSpec.Name = "txtSpec";
            this.txtSpec.ReadOnly = true;
            this.txtSpec.Size = new System.Drawing.Size(296, 26);
            this.txtSpec.TabIndex = 10;
            // 
            // txtCustomer
            // 
            this.txtCustomer.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtCustomer.Location = new System.Drawing.Point(639, 29);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.ReadOnly = true;
            this.txtCustomer.Size = new System.Drawing.Size(296, 26);
            this.txtCustomer.TabIndex = 9;
            // 
            // txtItemCode
            // 
            this.txtItemCode.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtItemCode.Location = new System.Drawing.Point(131, 79);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.ReadOnly = true;
            this.txtItemCode.Size = new System.Drawing.Size(275, 26);
            this.txtItemCode.TabIndex = 8;
            // 
            // dgvCheckSheet
            // 
            this.dgvCheckSheet.AllowUserToAddRows = false;
            this.dgvCheckSheet.AllowUserToDeleteRows = false;
            this.dgvCheckSheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckSheet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNo,
            this.colTestCode,
            this.colTestMethod,
            this.colStd,
            this.colMin,
            this.colMax,
            this.colStandart});
            this.dgvCheckSheet.Location = new System.Drawing.Point(3, 121);
            this.dgvCheckSheet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCheckSheet.Name = "dgvCheckSheet";
            this.dgvCheckSheet.ReadOnly = true;
            this.dgvCheckSheet.Size = new System.Drawing.Size(1109, 425);
            this.dgvCheckSheet.TabIndex = 7;
            // 
            // colNo
            // 
            this.colNo.HeaderText = "No";
            this.colNo.Name = "colNo";
            this.colNo.ReadOnly = true;
            this.colNo.Width = 65;
            // 
            // colTestCode
            // 
            this.colTestCode.HeaderText = "Test Code";
            this.colTestCode.Name = "colTestCode";
            this.colTestCode.ReadOnly = true;
            this.colTestCode.Width = 150;
            // 
            // colTestMethod
            // 
            this.colTestMethod.HeaderText = "Test Method";
            this.colTestMethod.Name = "colTestMethod";
            this.colTestMethod.ReadOnly = true;
            this.colTestMethod.Width = 300;
            // 
            // colStd
            // 
            this.colStd.HeaderText = "Std";
            this.colStd.Name = "colStd";
            this.colStd.ReadOnly = true;
            // 
            // colMin
            // 
            this.colMin.HeaderText = "Min";
            this.colMin.Name = "colMin";
            this.colMin.ReadOnly = true;
            // 
            // colMax
            // 
            this.colMax.HeaderText = "Max";
            this.colMax.Name = "colMax";
            this.colMax.ReadOnly = true;
            // 
            // colStandart
            // 
            this.colStandart.HeaderText = "Standart";
            this.colStandart.Name = "colStandart";
            this.colStandart.ReadOnly = true;
            this.colStandart.Width = 150;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(545, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Spec :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(545, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Customer :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Item Code :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Job No :";
            // 
            // pnlButton
            // 
            this.pnlButton.BackColor = System.Drawing.Color.BurlyWood;
            this.pnlButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlButton.Controls.Add(this.btnEntryResult);
            this.pnlButton.Controls.Add(this.btnRetrieveData);
            this.pnlButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlButton.Location = new System.Drawing.Point(5, 6);
            this.pnlButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(1117, 72);
            this.pnlButton.TabIndex = 11;
            // 
            // btnEntryResult
            // 
            this.btnEntryResult.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEntryResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEntryResult.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntryResult.Location = new System.Drawing.Point(131, 8);
            this.btnEntryResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEntryResult.Name = "btnEntryResult";
            this.btnEntryResult.Size = new System.Drawing.Size(114, 52);
            this.btnEntryResult.TabIndex = 7;
            this.btnEntryResult.Text = "Entry Result";
            this.btnEntryResult.UseVisualStyleBackColor = false;
            this.btnEntryResult.Click += new System.EventHandler(this.btnEntryResult_Click);
            // 
            // btnRetrieveData
            // 
            this.btnRetrieveData.BackColor = System.Drawing.Color.DarkOrange;
            this.btnRetrieveData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRetrieveData.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetrieveData.Location = new System.Drawing.Point(8, 6);
            this.btnRetrieveData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRetrieveData.Name = "btnRetrieveData";
            this.btnRetrieveData.Size = new System.Drawing.Size(111, 54);
            this.btnRetrieveData.TabIndex = 6;
            this.btnRetrieveData.Text = "Retrieve Data";
            this.btnRetrieveData.UseVisualStyleBackColor = false;
            this.btnRetrieveData.Click += new System.EventHandler(this.btnRetrieveData_Click);
            // 
            // frmEntChkSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1128, 640);
            this.Controls.Add(this.pnlButton);
            this.Controls.Add(this.pnlEntry);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEntChkSheet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entry Check Sheet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEntChkSheet_FormClosing);
            this.Load += new System.EventHandler(this.frmEntry_Load);
            this.pnlEntry.ResumeLayout(false);
            this.pnlEntry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckSheet)).EndInit();
            this.pnlButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlEntry;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Button btnEntryResult;
        private System.Windows.Forms.Button btnRetrieveData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtJobNo;
        private System.Windows.Forms.TextBox txtSpec;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.DataGridView dgvCheckSheet;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTestCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTestMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStandart;
    }
}