namespace CREntry_OFF
{
    partial class frmEntResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntResult));
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.pnlEntry = new System.Windows.Forms.Panel();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mtConclusionDate = new System.Windows.Forms.MaskedTextBox();
            this.dtConclusionDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.mtProdDate = new System.Windows.Forms.MaskedTextBox();
            this.dtProdDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEntryNo = new System.Windows.Forms.TextBox();
            this.txtJobNo = new System.Windows.Forms.TextBox();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTestCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTestMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTestQuestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFlagValidate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlButton.SuspendLayout();
            this.pnlEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.BackColor = System.Drawing.Color.BurlyWood;
            this.pnlButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlButton.Controls.Add(this.btnSave);
            this.pnlButton.Controls.Add(this.btnNew);
            this.pnlButton.Location = new System.Drawing.Point(6, 7);
            this.pnlButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(1201, 72);
            this.pnlButton.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(131, 8);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 52);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Yellow;
            this.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNew.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(8, 6);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(111, 54);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // pnlEntry
            // 
            this.pnlEntry.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEntry.Controls.Add(this.txtRemark);
            this.pnlEntry.Controls.Add(this.label4);
            this.pnlEntry.Controls.Add(this.mtConclusionDate);
            this.pnlEntry.Controls.Add(this.dtConclusionDate);
            this.pnlEntry.Controls.Add(this.label3);
            this.pnlEntry.Controls.Add(this.mtProdDate);
            this.pnlEntry.Controls.Add(this.dtProdDate);
            this.pnlEntry.Controls.Add(this.label5);
            this.pnlEntry.Controls.Add(this.txtEntryNo);
            this.pnlEntry.Controls.Add(this.txtJobNo);
            this.pnlEntry.Controls.Add(this.dgvResult);
            this.pnlEntry.Controls.Add(this.label2);
            this.pnlEntry.Controls.Add(this.label1);
            this.pnlEntry.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlEntry.Location = new System.Drawing.Point(6, 85);
            this.pnlEntry.Name = "pnlEntry";
            this.pnlEntry.Size = new System.Drawing.Size(1201, 538);
            this.pnlEntry.TabIndex = 11;
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(830, 16);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(337, 91);
            this.txtRemark.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(751, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "Remark :";
            // 
            // mtConclusionDate
            // 
            this.mtConclusionDate.Location = new System.Drawing.Point(510, 74);
            this.mtConclusionDate.Mask = "##/##/####";
            this.mtConclusionDate.Name = "mtConclusionDate";
            this.mtConclusionDate.Size = new System.Drawing.Size(119, 26);
            this.mtConclusionDate.TabIndex = 20;
            // 
            // dtConclusionDate
            // 
            this.dtConclusionDate.CalendarFont = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtConclusionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtConclusionDate.Location = new System.Drawing.Point(631, 74);
            this.dtConclusionDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtConclusionDate.Name = "dtConclusionDate";
            this.dtConclusionDate.Size = new System.Drawing.Size(20, 26);
            this.dtConclusionDate.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(371, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Conclusion Date :";
            // 
            // mtProdDate
            // 
            this.mtProdDate.Location = new System.Drawing.Point(510, 22);
            this.mtProdDate.Mask = "##/##/####";
            this.mtProdDate.Name = "mtProdDate";
            this.mtProdDate.Size = new System.Drawing.Size(119, 26);
            this.mtProdDate.TabIndex = 17;
            this.mtProdDate.TextChanged += new System.EventHandler(this.mtProdDate_TextChanged);
            // 
            // dtProdDate
            // 
            this.dtProdDate.CalendarFont = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtProdDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtProdDate.Location = new System.Drawing.Point(631, 22);
            this.dtProdDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtProdDate.Name = "dtProdDate";
            this.dtProdDate.Size = new System.Drawing.Size(20, 26);
            this.dtProdDate.TabIndex = 15;
            this.dtProdDate.CloseUp += new System.EventHandler(this.dtProdDate_CloseUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(371, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Prod. Date :";
            // 
            // txtEntryNo
            // 
            this.txtEntryNo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtEntryNo.Location = new System.Drawing.Point(131, 29);
            this.txtEntryNo.Name = "txtEntryNo";
            this.txtEntryNo.ReadOnly = true;
            this.txtEntryNo.Size = new System.Drawing.Size(70, 26);
            this.txtEntryNo.TabIndex = 11;
            // 
            // txtJobNo
            // 
            this.txtJobNo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtJobNo.Location = new System.Drawing.Point(131, 79);
            this.txtJobNo.Name = "txtJobNo";
            this.txtJobNo.ReadOnly = true;
            this.txtJobNo.Size = new System.Drawing.Size(131, 26);
            this.txtJobNo.TabIndex = 8;
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.AllowUserToDeleteRows = false;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNo,
            this.colTestCode,
            this.colTestMethod,
            this.colTestQuestion,
            this.colStd,
            this.colMin,
            this.colMax,
            this.colResult,
            this.colFlagValidate});
            this.dgvResult.Location = new System.Drawing.Point(3, 121);
            this.dgvResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.Size = new System.Drawing.Size(1193, 411);
            this.dgvResult.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Job No :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Entry No :";
            // 
            // colNo
            // 
            this.colNo.HeaderText = "No";
            this.colNo.Name = "colNo";
            this.colNo.Width = 65;
            // 
            // colTestCode
            // 
            this.colTestCode.HeaderText = "Test Code";
            this.colTestCode.Name = "colTestCode";
            this.colTestCode.Width = 120;
            // 
            // colTestMethod
            // 
            this.colTestMethod.HeaderText = "Test Method";
            this.colTestMethod.Name = "colTestMethod";
            this.colTestMethod.Width = 250;
            // 
            // colTestQuestion
            // 
            this.colTestQuestion.HeaderText = "Test Question";
            this.colTestQuestion.Name = "colTestQuestion";
            this.colTestQuestion.Width = 250;
            // 
            // colStd
            // 
            this.colStd.HeaderText = "Std";
            this.colStd.Name = "colStd";
            this.colStd.Width = 85;
            // 
            // colMin
            // 
            this.colMin.HeaderText = "Min";
            this.colMin.Name = "colMin";
            // 
            // colMax
            // 
            this.colMax.HeaderText = "Max";
            this.colMax.Name = "colMax";
            // 
            // colResult
            // 
            this.colResult.HeaderText = "Result";
            this.colResult.Name = "colResult";
            // 
            // colFlagValidate
            // 
            this.colFlagValidate.HeaderText = "Flag Validate";
            this.colFlagValidate.Name = "colFlagValidate";
            // 
            // frmEntResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1212, 629);
            this.Controls.Add(this.pnlEntry);
            this.Controls.Add(this.pnlButton);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEntResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entry Result";
            this.Load += new System.EventHandler(this.frmEntResult_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlEntry.ResumeLayout(false);
            this.pnlEntry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel pnlEntry;
        private System.Windows.Forms.TextBox txtEntryNo;
        private System.Windows.Forms.TextBox txtJobNo;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtProdDate;
        private System.Windows.Forms.MaskedTextBox mtProdDate;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtConclusionDate;
        private System.Windows.Forms.DateTimePicker dtConclusionDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTestCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTestMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTestQuestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFlagValidate;
    }
}