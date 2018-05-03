namespace MANUUFinance
{
    partial class ImportHelp
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
            this.testingviewBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.financeDataSet13 = new MANUUFinance.FinanceDataSet13();
            this.testingviewBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.testingviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.financeDataSet7 = new MANUUFinance.FinanceDataSet7();
            this.testingviewTableAdapter = new MANUUFinance.FinanceDataSet7TableAdapters.testingviewTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.comboFY = new System.Windows.Forms.ComboBox();
            this.testingviewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.testingviewBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.testingviewTableAdapter1 = new MANUUFinance.FinanceDataSet13TableAdapters.testingviewTableAdapter();
            this.financeDataSet14 = new MANUUFinance.FinanceDataSet14();
            this.testingviewBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.testingviewTableAdapter2 = new MANUUFinance.FinanceDataSet14TableAdapters.testingviewTableAdapter();
            this.financeDataSet15 = new MANUUFinance.FinanceDataSet15();
            this.testingviewBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.testingviewTableAdapter3 = new MANUUFinance.FinanceDataSet15TableAdapters.testingviewTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pKACIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bECYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rBECYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testingviewBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testingviewBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testingviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testingviewBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testingviewBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testingviewBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testingviewBindingSource6)).BeginInit();
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
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.aCNoDataGridViewTextBoxColumn,
            this.pKACIDDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn4,
            this.bECYDataGridViewTextBoxColumn,
            this.rBECYDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.testingviewBindingSource6;
            this.dataGridView1.Location = new System.Drawing.Point(36, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(732, 150);
            this.dataGridView1.TabIndex = 23;
            // 
            // testingviewBindingSource4
            // 
            this.testingviewBindingSource4.DataMember = "testingview";
            this.testingviewBindingSource4.DataSource = this.financeDataSet13;
            // 
            // financeDataSet13
            // 
            this.financeDataSet13.DataSetName = "FinanceDataSet13";
            this.financeDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testingviewBindingSource3
            // 
            this.testingviewBindingSource3.DataMember = "testingview";
            // 
            // testingviewBindingSource
            // 
            this.testingviewBindingSource.DataMember = "testingview";
            this.testingviewBindingSource.DataSource = this.financeDataSet7;
            // 
            // financeDataSet7
            // 
            this.financeDataSet7.DataSetName = "FinanceDataSet7";
            this.financeDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testingviewTableAdapter
            // 
            this.testingviewTableAdapter.ClearBeforeFill = true;
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
            // testingviewTableAdapter1
            // 
            this.testingviewTableAdapter1.ClearBeforeFill = true;
            // 
            // financeDataSet14
            // 
            this.financeDataSet14.DataSetName = "FinanceDataSet14";
            this.financeDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testingviewBindingSource5
            // 
            this.testingviewBindingSource5.DataMember = "testingview";
            this.testingviewBindingSource5.DataSource = this.financeDataSet14;
            // 
            // testingviewTableAdapter2
            // 
            this.testingviewTableAdapter2.ClearBeforeFill = true;
            // 
            // financeDataSet15
            // 
            this.financeDataSet15.DataSetName = "FinanceDataSet15";
            this.financeDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testingviewBindingSource6
            // 
            this.testingviewBindingSource6.DataMember = "testingview";
            this.testingviewBindingSource6.DataSource = this.financeDataSet15;
            // 
            // testingviewTableAdapter3
            // 
            this.testingviewTableAdapter3.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SL1";
            this.dataGridViewTextBoxColumn1.HeaderText = "SL1";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SL2";
            this.dataGridViewTextBoxColumn2.HeaderText = "SL2";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SL3";
            this.dataGridViewTextBoxColumn3.HeaderText = "SL3";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // aCNoDataGridViewTextBoxColumn
            // 
            this.aCNoDataGridViewTextBoxColumn.DataPropertyName = "ACNo";
            this.aCNoDataGridViewTextBoxColumn.HeaderText = "ACNo";
            this.aCNoDataGridViewTextBoxColumn.Name = "aCNoDataGridViewTextBoxColumn";
            this.aCNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pKACIDDataGridViewTextBoxColumn
            // 
            this.pKACIDDataGridViewTextBoxColumn.DataPropertyName = "PKACID";
            this.pKACIDDataGridViewTextBoxColumn.HeaderText = "PKACID";
            this.pKACIDDataGridViewTextBoxColumn.Name = "pKACIDDataGridViewTextBoxColumn";
            this.pKACIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DName";
            this.dataGridViewTextBoxColumn4.HeaderText = "DName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.testingviewBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testingviewBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testingviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testingviewBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testingviewBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testingviewBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testingviewBindingSource6)).EndInit();
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
        private FinanceDataSet7 financeDataSet7;
        private System.Windows.Forms.BindingSource testingviewBindingSource;
        private FinanceDataSet7TableAdapters.testingviewTableAdapter testingviewTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboFY;
        private System.Windows.Forms.BindingSource testingviewBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sL1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sL2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sL3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource testingviewBindingSource3;
        private System.Windows.Forms.BindingSource testingviewBindingSource2;
        private FinanceDataSet13 financeDataSet13;
        private System.Windows.Forms.BindingSource testingviewBindingSource4;
        private FinanceDataSet13TableAdapters.testingviewTableAdapter testingviewTableAdapter1;
        private FinanceDataSet14 financeDataSet14;
        private System.Windows.Forms.BindingSource testingviewBindingSource5;
        private FinanceDataSet14TableAdapters.testingviewTableAdapter testingviewTableAdapter2;
        private FinanceDataSet15 financeDataSet15;
        private System.Windows.Forms.BindingSource testingviewBindingSource6;
        private FinanceDataSet15TableAdapters.testingviewTableAdapter testingviewTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pKACIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn bECYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rBECYDataGridViewTextBoxColumn;
    }
}