namespace MANUUFinance
{
    partial class frmImportHelp
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
            this.dropdown_sheet = new System.Windows.Forms.ComboBox();
            this.btload = new System.Windows.Forms.Button();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.open = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.budgetWithAccountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.financeDataSet4 = new MANUUFinance.FinanceDataSet4();
            this.testingviewBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.testingviewBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.testingviewBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.testingviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.comboFY = new System.Windows.Forms.ComboBox();
            this.testingviewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.testingviewBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.testingviewBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.budgetWithAccountsTableAdapter = new MANUUFinance.FinanceDataSet4TableAdapters.BudgetWithAccountsTableAdapter();
            this.financeDataSet16 = new MANUUFinance.FinanceDataSet16();
            this.budgetWithAccountsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.budgetWithAccountsTableAdapter1 = new MANUUFinance.FinanceDataSet16TableAdapters.BudgetWithAccountsTableAdapter();
            this.fYNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sL3CodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bECYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rBECYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bENYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sL1NameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sL2NameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sL3NameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sL1IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pKSL2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKSL3IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pKFYIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pKACIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pKBUDGETIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetWithAccountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testingviewBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testingviewBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testingviewBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testingviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testingviewBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testingviewBindingSource2)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)(this.testingviewBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetWithAccountsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dropdown_sheet
            // 
            this.dropdown_sheet.FormattingEnabled = true;
            this.dropdown_sheet.Location = new System.Drawing.Point(517, 81);
            this.dropdown_sheet.Name = "dropdown_sheet";
            this.dropdown_sheet.Size = new System.Drawing.Size(136, 21);
            this.dropdown_sheet.TabIndex = 22;
            // 
            // btload
            // 
            this.btload.Location = new System.Drawing.Point(659, 79);
            this.btload.Name = "btload";
            this.btload.Size = new System.Drawing.Size(109, 23);
            this.btload.TabIndex = 18;
            this.btload.Text = "Import";
            this.btload.UseVisualStyleBackColor = true;
            this.btload.Click += new System.EventHandler(this.Load_Click);
            // 
            // tb_path
            // 
            this.tb_path.Location = new System.Drawing.Point(153, 80);
            this.tb_path.Name = "tb_path";
            this.tb_path.Size = new System.Drawing.Size(317, 20);
            this.tb_path.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(476, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Sheet";
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(36, 79);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(109, 23);
            this.open.TabIndex = 19;
            this.open.Text = "Open";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fYNameDataGridViewTextBoxColumn,
            this.deptNameDataGridViewTextBoxColumn,
            this.sL3CodeDataGridViewTextBoxColumn,
            this.accountNameDataGridViewTextBoxColumn,
            this.bECYDataGridViewTextBoxColumn,
            this.rBECYDataGridViewTextBoxColumn,
            this.bENYDataGridViewTextBoxColumn,
            this.sL1NameDataGridViewTextBoxColumn,
            this.sL2NameDataGridViewTextBoxColumn,
            this.sL3NameDataGridViewTextBoxColumn,
            this.sL1IDDataGridViewTextBoxColumn,
            this.pKSL2DataGridViewTextBoxColumn,
            this.fKSL3IDDataGridViewTextBoxColumn,
            this.deptIdDataGridViewTextBoxColumn,
            this.pKFYIDDataGridViewTextBoxColumn,
            this.pKACIDDataGridViewTextBoxColumn,
            this.pKBUDGETIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.budgetWithAccountsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(36, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(732, 150);
            this.dataGridView1.TabIndex = 23;
            // 
            // budgetWithAccountsBindingSource
            // 
            this.budgetWithAccountsBindingSource.DataMember = "BudgetWithAccounts";
            this.budgetWithAccountsBindingSource.DataSource = this.financeDataSet4;
            // 
            // financeDataSet4
            // 
            this.financeDataSet4.DataSetName = "FinanceDataSet4";
            this.financeDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testingviewBindingSource6
            // 
            this.testingviewBindingSource6.DataMember = "testingview";
            // 
            // testingviewBindingSource4
            // 
            this.testingviewBindingSource4.DataMember = "testingview";
            // testingviewBindingSource3
            // 
            this.testingviewBindingSource3.DataMember = "testingview";
            // 
            // testingviewBindingSource
            // 
            this.testingviewBindingSource.DataMember = "testingview";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Financial Year";
            // 
            // comboFY
            // 
            this.comboFY.FormattingEnabled = true;
            this.comboFY.Location = new System.Drawing.Point(113, 42);
            this.comboFY.Name = "comboFY";
            this.comboFY.Size = new System.Drawing.Size(136, 21);
            this.comboFY.TabIndex = 22;
            // 
            // testingviewBindingSource1
            // 
            this.testingviewBindingSource1.DataMember = "testingview";
            // 
            // testingviewBindingSource2
            // 
            this.testingviewBindingSource2.DataMember = "testingview";
            // 
            // testingviewBindingSource5
            // 
            this.testingviewBindingSource5.DataMember = "testingview";
            // 
            // 
            // budgetWithAccountsTableAdapter
            // 
            this.budgetWithAccountsTableAdapter.ClearBeforeFill = true;
            // 
            // financeDataSet16
            // 
            this.financeDataSet16.DataSetName = "FinanceDataSet16";
            this.financeDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // budgetWithAccountsBindingSource1
            // 
            this.budgetWithAccountsBindingSource1.DataMember = "BudgetWithAccounts";
            this.budgetWithAccountsBindingSource1.DataSource = this.financeDataSet16;
            // 
            // budgetWithAccountsTableAdapter1
            // 
            this.budgetWithAccountsTableAdapter1.ClearBeforeFill = true;
            // 
            // fYNameDataGridViewTextBoxColumn
            // 
            this.fYNameDataGridViewTextBoxColumn.DataPropertyName = "FYName";
            this.fYNameDataGridViewTextBoxColumn.HeaderText = "FYName";
            this.fYNameDataGridViewTextBoxColumn.Name = "fYNameDataGridViewTextBoxColumn";
            this.fYNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deptNameDataGridViewTextBoxColumn
            // 
            this.deptNameDataGridViewTextBoxColumn.DataPropertyName = "DeptName";
            this.deptNameDataGridViewTextBoxColumn.HeaderText = "DeptName";
            this.deptNameDataGridViewTextBoxColumn.Name = "deptNameDataGridViewTextBoxColumn";
            this.deptNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sL3CodeDataGridViewTextBoxColumn
            // 
            this.sL3CodeDataGridViewTextBoxColumn.DataPropertyName = "SL3Code";
            this.sL3CodeDataGridViewTextBoxColumn.HeaderText = "SL3Code";
            this.sL3CodeDataGridViewTextBoxColumn.Name = "sL3CodeDataGridViewTextBoxColumn";
            this.sL3CodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountNameDataGridViewTextBoxColumn
            // 
            this.accountNameDataGridViewTextBoxColumn.DataPropertyName = "AccountName";
            this.accountNameDataGridViewTextBoxColumn.HeaderText = "AccountName";
            this.accountNameDataGridViewTextBoxColumn.Name = "accountNameDataGridViewTextBoxColumn";
            this.accountNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bECYDataGridViewTextBoxColumn
            // 
            this.bECYDataGridViewTextBoxColumn.DataPropertyName = "BECY";
            this.bECYDataGridViewTextBoxColumn.HeaderText = "BECY";
            this.bECYDataGridViewTextBoxColumn.Name = "bECYDataGridViewTextBoxColumn";
            this.bECYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rBECYDataGridViewTextBoxColumn
            // 
            this.rBECYDataGridViewTextBoxColumn.DataPropertyName = "RBECY";
            this.rBECYDataGridViewTextBoxColumn.HeaderText = "RBECY";
            this.rBECYDataGridViewTextBoxColumn.Name = "rBECYDataGridViewTextBoxColumn";
            this.rBECYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bENYDataGridViewTextBoxColumn
            // 
            this.bENYDataGridViewTextBoxColumn.DataPropertyName = "BENY";
            this.bENYDataGridViewTextBoxColumn.HeaderText = "BENY";
            this.bENYDataGridViewTextBoxColumn.Name = "bENYDataGridViewTextBoxColumn";
            this.bENYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sL1NameDataGridViewTextBoxColumn
            // 
            this.sL1NameDataGridViewTextBoxColumn.DataPropertyName = "SL1Name";
            this.sL1NameDataGridViewTextBoxColumn.HeaderText = "SL1Name";
            this.sL1NameDataGridViewTextBoxColumn.Name = "sL1NameDataGridViewTextBoxColumn";
            this.sL1NameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sL2NameDataGridViewTextBoxColumn
            // 
            this.sL2NameDataGridViewTextBoxColumn.DataPropertyName = "SL2Name";
            this.sL2NameDataGridViewTextBoxColumn.HeaderText = "SL2Name";
            this.sL2NameDataGridViewTextBoxColumn.Name = "sL2NameDataGridViewTextBoxColumn";
            this.sL2NameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sL3NameDataGridViewTextBoxColumn
            // 
            this.sL3NameDataGridViewTextBoxColumn.DataPropertyName = "SL3Name";
            this.sL3NameDataGridViewTextBoxColumn.HeaderText = "SL3Name";
            this.sL3NameDataGridViewTextBoxColumn.Name = "sL3NameDataGridViewTextBoxColumn";
            this.sL3NameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sL1IDDataGridViewTextBoxColumn
            // 
            this.sL1IDDataGridViewTextBoxColumn.DataPropertyName = "SL1ID";
            this.sL1IDDataGridViewTextBoxColumn.HeaderText = "SL1ID";
            this.sL1IDDataGridViewTextBoxColumn.Name = "sL1IDDataGridViewTextBoxColumn";
            this.sL1IDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pKSL2DataGridViewTextBoxColumn
            // 
            this.pKSL2DataGridViewTextBoxColumn.DataPropertyName = "PKSL2";
            this.pKSL2DataGridViewTextBoxColumn.HeaderText = "PKSL2";
            this.pKSL2DataGridViewTextBoxColumn.Name = "pKSL2DataGridViewTextBoxColumn";
            this.pKSL2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fKSL3IDDataGridViewTextBoxColumn
            // 
            this.fKSL3IDDataGridViewTextBoxColumn.DataPropertyName = "FKSL3ID";
            this.fKSL3IDDataGridViewTextBoxColumn.HeaderText = "FKSL3ID";
            this.fKSL3IDDataGridViewTextBoxColumn.Name = "fKSL3IDDataGridViewTextBoxColumn";
            this.fKSL3IDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deptIdDataGridViewTextBoxColumn
            // 
            this.deptIdDataGridViewTextBoxColumn.DataPropertyName = "DeptId";
            this.deptIdDataGridViewTextBoxColumn.HeaderText = "DeptId";
            this.deptIdDataGridViewTextBoxColumn.Name = "deptIdDataGridViewTextBoxColumn";
            this.deptIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pKFYIDDataGridViewTextBoxColumn
            // 
            this.pKFYIDDataGridViewTextBoxColumn.DataPropertyName = "PKFYID";
            this.pKFYIDDataGridViewTextBoxColumn.HeaderText = "PKFYID";
            this.pKFYIDDataGridViewTextBoxColumn.Name = "pKFYIDDataGridViewTextBoxColumn";
            this.pKFYIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pKACIDDataGridViewTextBoxColumn
            // 
            this.pKACIDDataGridViewTextBoxColumn.DataPropertyName = "PKACID";
            this.pKACIDDataGridViewTextBoxColumn.HeaderText = "PKACID";
            this.pKACIDDataGridViewTextBoxColumn.Name = "pKACIDDataGridViewTextBoxColumn";
            this.pKACIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pKBUDGETIDDataGridViewTextBoxColumn
            // 
            this.pKBUDGETIDDataGridViewTextBoxColumn.DataPropertyName = "PKBUDGETID";
            this.pKBUDGETIDDataGridViewTextBoxColumn.HeaderText = "PKBUDGETID";
            this.pKBUDGETIDDataGridViewTextBoxColumn.Name = "pKBUDGETIDDataGridViewTextBoxColumn";
            this.pKBUDGETIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ImportHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 328);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboFY);
            this.Controls.Add(this.dropdown_sheet);
            this.Controls.Add(this.btload);
            this.Controls.Add(this.tb_path);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.open);
            this.Name = "ImportHelp";
            this.Text = "ImportHelp";
            this.Load += new System.EventHandler(this.ImportTesting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetWithAccountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testingviewBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testingviewBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testingviewBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testingviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testingviewBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testingviewBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testingviewBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetWithAccountsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox dropdown_sheet;
        private System.Windows.Forms.Button btload;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource testingviewBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboFY;
        private System.Windows.Forms.BindingSource testingviewBindingSource1;
        private System.Windows.Forms.BindingSource testingviewBindingSource3;
        private System.Windows.Forms.BindingSource testingviewBindingSource2;
        private System.Windows.Forms.BindingSource testingviewBindingSource4;
        private System.Windows.Forms.BindingSource testingviewBindingSource5;
        private System.Windows.Forms.BindingSource testingviewBindingSource6;
        private FinanceDataSet4 financeDataSet4;
        private System.Windows.Forms.BindingSource budgetWithAccountsBindingSource;
        private FinanceDataSet4TableAdapters.BudgetWithAccountsTableAdapter budgetWithAccountsTableAdapter;
        private FinanceDataSet16 financeDataSet16;
        private System.Windows.Forms.BindingSource budgetWithAccountsBindingSource1;
        private FinanceDataSet16TableAdapters.BudgetWithAccountsTableAdapter budgetWithAccountsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fYNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sL3CodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bECYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rBECYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bENYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sL1NameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sL2NameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sL3NameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sL1IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pKSL2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKSL3IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pKFYIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pKACIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pKBUDGETIDDataGridViewTextBoxColumn;
    }
}