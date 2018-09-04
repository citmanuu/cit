namespace MANUUFinance
{
    partial class frmBudgetSchedule
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
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btClearRecord = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.closeForm = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBType = new System.Windows.Forms.ComboBox();
            this.comboFY = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.budgetScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.financeDataSet9 = new MANUUFinance.FinanceDataSet9();
            this.budgetScheduleTableAdapter = new MANUUFinance.FinanceDataSet9TableAdapters.BudgetScheduleTableAdapter();
            this.financeDataSet10 = new MANUUFinance.FinanceDataSet10();
            this.budgetScheduleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.budgetScheduleTableAdapter1 = new MANUUFinance.FinanceDataSet10TableAdapters.BudgetScheduleTableAdapter();
            this.budgetScheduleBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.financeDataSet11 = new MANUUFinance.FinanceDataSet11();
            this.budgetScheduleBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.budgetScheduleTableAdapter2 = new MANUUFinance.FinanceDataSet11TableAdapters.BudgetScheduleTableAdapter();
            this.DGVBS = new System.Windows.Forms.DataGridView();
            this.bSIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fYIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bSaddedOnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bSupdatedOnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bSupdateByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budgetScheduleBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.financeDataSet12 = new MANUUFinance.FinanceDataSet12();
            this.budgetScheduleTableAdapter3 = new MANUUFinance.FinanceDataSet12TableAdapters.BudgetScheduleTableAdapter();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.budgetScheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetScheduleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetScheduleBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetScheduleBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetScheduleBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet12)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPrint);
            this.groupBox2.Controls.Add(this.btClearRecord);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.closeForm);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox2.Location = new System.Drawing.Point(33, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(602, 40);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(302, 10);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(97, 25);
            this.btnPrint.TabIndex = 15;
            this.btnPrint.Text = "Print Record";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btClearRecord
            // 
            this.btClearRecord.Location = new System.Drawing.Point(402, 10);
            this.btClearRecord.Name = "btClearRecord";
            this.btClearRecord.Size = new System.Drawing.Size(97, 25);
            this.btClearRecord.TabIndex = 14;
            this.btClearRecord.Text = "Clear Record";
            this.btClearRecord.UseVisualStyleBackColor = true;
            this.btClearRecord.Click += new System.EventHandler(this.btClearRecord_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(2, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 25);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // closeForm
            // 
            this.closeForm.Location = new System.Drawing.Point(501, 10);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(97, 25);
            this.closeForm.TabIndex = 13;
            this.closeForm.Text = "CloseForm";
            this.closeForm.UseVisualStyleBackColor = true;
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(102, 10);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(97, 25);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(202, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 25);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpTo);
            this.groupBox1.Controls.Add(this.dtpFrom);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBType);
            this.groupBox1.Controls.Add(this.comboFY);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(33, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(644, 160);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Budget Schedule";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(510, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Day(s) : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(556, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 8;
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "dd/MM/yyyy";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(90, 107);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(109, 20);
            this.dtpTo.TabIndex = 7;
            this.dtpTo.Value = new System.DateTime(2018, 4, 26, 0, 0, 0, 0);
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged_1);
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "dd/MM/yyyy";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(90, 73);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(109, 20);
            this.dtpFrom.TabIndex = 6;
            this.dtpFrom.Value = new System.DateTime(2018, 4, 26, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "To Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "From Date";
            // 
            // comboBType
            // 
            this.comboBType.FormattingEnabled = true;
            this.comboBType.Location = new System.Drawing.Point(423, 27);
            this.comboBType.Name = "comboBType";
            this.comboBType.Size = new System.Drawing.Size(197, 21);
            this.comboBType.TabIndex = 3;
            // 
            // comboFY
            // 
            this.comboFY.FormattingEnabled = true;
            this.comboFY.Location = new System.Drawing.Point(116, 27);
            this.comboFY.Name = "comboFY";
            this.comboFY.Size = new System.Drawing.Size(200, 21);
            this.comboFY.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Budget Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Financial Year";
            // 
            // budgetScheduleBindingSource
            // 
            this.budgetScheduleBindingSource.DataMember = "BudgetSchedule";
            this.budgetScheduleBindingSource.DataSource = this.financeDataSet9;
            // 
            // financeDataSet9
            // 
            this.financeDataSet9.DataSetName = "FinanceDataSet9";
            this.financeDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // budgetScheduleTableAdapter
            // 
            this.budgetScheduleTableAdapter.ClearBeforeFill = true;
            // 
            // financeDataSet10
            // 
            this.financeDataSet10.DataSetName = "FinanceDataSet10";
            this.financeDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // budgetScheduleBindingSource1
            // 
            this.budgetScheduleBindingSource1.DataMember = "BudgetSchedule";
            this.budgetScheduleBindingSource1.DataSource = this.financeDataSet10;
            // 
            // budgetScheduleTableAdapter1
            // 
            this.budgetScheduleTableAdapter1.ClearBeforeFill = true;
            // 
            // budgetScheduleBindingSource2
            // 
            this.budgetScheduleBindingSource2.DataMember = "BudgetSchedule";
            this.budgetScheduleBindingSource2.DataSource = this.financeDataSet9;
            // 
            // financeDataSet11
            // 
            this.financeDataSet11.DataSetName = "FinanceDataSet11";
            this.financeDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // budgetScheduleBindingSource3
            // 
            this.budgetScheduleBindingSource3.DataMember = "BudgetSchedule";
            this.budgetScheduleBindingSource3.DataSource = this.financeDataSet11;
            // 
            // budgetScheduleTableAdapter2
            // 
            this.budgetScheduleTableAdapter2.ClearBeforeFill = true;
            // 
            // DGVBS
            // 
            this.DGVBS.AllowUserToAddRows = false;
            this.DGVBS.AllowUserToDeleteRows = false;
            this.DGVBS.AutoGenerateColumns = false;
            this.DGVBS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bSIDDataGridViewTextBoxColumn,
            this.fYIDDataGridViewTextBoxColumn,
            this.bTypeDataGridViewTextBoxColumn,
            this.fromDateDataGridViewTextBoxColumn,
            this.toDateDataGridViewTextBoxColumn,
            this.bSaddedOnDataGridViewTextBoxColumn,
            this.bSupdatedOnDataGridViewTextBoxColumn,
            this.bSupdateByDataGridViewTextBoxColumn});
            this.DGVBS.DataSource = this.budgetScheduleBindingSource4;
            this.DGVBS.Location = new System.Drawing.Point(105, 257);
            this.DGVBS.Name = "DGVBS";
            this.DGVBS.ReadOnly = true;
            this.DGVBS.Size = new System.Drawing.Size(445, 150);
            this.DGVBS.TabIndex = 5;
            this.DGVBS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bSIDDataGridViewTextBoxColumn
            // 
            this.bSIDDataGridViewTextBoxColumn.DataPropertyName = "BSID";
            this.bSIDDataGridViewTextBoxColumn.HeaderText = "BSID";
            this.bSIDDataGridViewTextBoxColumn.Name = "bSIDDataGridViewTextBoxColumn";
            this.bSIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bSIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // fYIDDataGridViewTextBoxColumn
            // 
            this.fYIDDataGridViewTextBoxColumn.DataPropertyName = "FYID";
            this.fYIDDataGridViewTextBoxColumn.HeaderText = "FYID";
            this.fYIDDataGridViewTextBoxColumn.Name = "fYIDDataGridViewTextBoxColumn";
            this.fYIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bTypeDataGridViewTextBoxColumn
            // 
            this.bTypeDataGridViewTextBoxColumn.DataPropertyName = "BType";
            this.bTypeDataGridViewTextBoxColumn.HeaderText = "BType";
            this.bTypeDataGridViewTextBoxColumn.Name = "bTypeDataGridViewTextBoxColumn";
            this.bTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fromDateDataGridViewTextBoxColumn
            // 
            this.fromDateDataGridViewTextBoxColumn.DataPropertyName = "FromDate";
            this.fromDateDataGridViewTextBoxColumn.HeaderText = "FromDate";
            this.fromDateDataGridViewTextBoxColumn.Name = "fromDateDataGridViewTextBoxColumn";
            this.fromDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // toDateDataGridViewTextBoxColumn
            // 
            this.toDateDataGridViewTextBoxColumn.DataPropertyName = "ToDate";
            this.toDateDataGridViewTextBoxColumn.HeaderText = "ToDate";
            this.toDateDataGridViewTextBoxColumn.Name = "toDateDataGridViewTextBoxColumn";
            this.toDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bSaddedOnDataGridViewTextBoxColumn
            // 
            this.bSaddedOnDataGridViewTextBoxColumn.DataPropertyName = "BSaddedOn";
            this.bSaddedOnDataGridViewTextBoxColumn.HeaderText = "BSaddedOn";
            this.bSaddedOnDataGridViewTextBoxColumn.Name = "bSaddedOnDataGridViewTextBoxColumn";
            this.bSaddedOnDataGridViewTextBoxColumn.ReadOnly = true;
            this.bSaddedOnDataGridViewTextBoxColumn.Visible = false;
            // 
            // bSupdatedOnDataGridViewTextBoxColumn
            // 
            this.bSupdatedOnDataGridViewTextBoxColumn.DataPropertyName = "BSupdatedOn";
            this.bSupdatedOnDataGridViewTextBoxColumn.HeaderText = "BSupdatedOn";
            this.bSupdatedOnDataGridViewTextBoxColumn.Name = "bSupdatedOnDataGridViewTextBoxColumn";
            this.bSupdatedOnDataGridViewTextBoxColumn.ReadOnly = true;
            this.bSupdatedOnDataGridViewTextBoxColumn.Visible = false;
            // 
            // bSupdateByDataGridViewTextBoxColumn
            // 
            this.bSupdateByDataGridViewTextBoxColumn.DataPropertyName = "BSupdateBy";
            this.bSupdateByDataGridViewTextBoxColumn.HeaderText = "BSupdateBy";
            this.bSupdateByDataGridViewTextBoxColumn.Name = "bSupdateByDataGridViewTextBoxColumn";
            this.bSupdateByDataGridViewTextBoxColumn.ReadOnly = true;
            this.bSupdateByDataGridViewTextBoxColumn.Visible = false;
            // 
            // budgetScheduleBindingSource4
            // 
            this.budgetScheduleBindingSource4.DataMember = "BudgetSchedule";
            this.budgetScheduleBindingSource4.DataSource = this.financeDataSet12;
            // 
            // financeDataSet12
            // 
            this.financeDataSet12.DataSetName = "FinanceDataSet12";
            this.financeDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // budgetScheduleTableAdapter3
            // 
            this.budgetScheduleTableAdapter3.ClearBeforeFill = true;
            // 
            // BudgetSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 434);
            this.Controls.Add(this.DGVBS);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "BudgetSchedule";
            this.Text = "BudgetSchedule";
            this.Load += new System.EventHandler(this.BudgetSchedule_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.budgetScheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetScheduleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetScheduleBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetScheduleBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetScheduleBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet12)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btClearRecord;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button closeForm;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBType;
        private System.Windows.Forms.ComboBox comboFY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FinanceDataSet9 financeDataSet9;
        private System.Windows.Forms.BindingSource budgetScheduleBindingSource;
        private FinanceDataSet9TableAdapters.BudgetScheduleTableAdapter budgetScheduleTableAdapter;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private FinanceDataSet10 financeDataSet10;
        private System.Windows.Forms.BindingSource budgetScheduleBindingSource1;
        private FinanceDataSet10TableAdapters.BudgetScheduleTableAdapter budgetScheduleTableAdapter1;
        private System.Windows.Forms.BindingSource budgetScheduleBindingSource2;
        private FinanceDataSet11 financeDataSet11;
        private System.Windows.Forms.BindingSource budgetScheduleBindingSource3;
        private FinanceDataSet11TableAdapters.BudgetScheduleTableAdapter budgetScheduleTableAdapter2;
        private System.Windows.Forms.DataGridView DGVBS;
        private FinanceDataSet12 financeDataSet12;
        private System.Windows.Forms.BindingSource budgetScheduleBindingSource4;
        private FinanceDataSet12TableAdapters.BudgetScheduleTableAdapter budgetScheduleTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn bSIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fYIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bSaddedOnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bSupdatedOnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bSupdateByDataGridViewTextBoxColumn;
    }
}