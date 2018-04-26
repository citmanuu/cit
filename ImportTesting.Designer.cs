namespace MANUUFinance
{
    partial class ImportTesting
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
            this.sL1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sL2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sL3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testingviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.financeDataSet7 = new MANUUFinance.FinanceDataSet7();
            this.testingviewTableAdapter = new MANUUFinance.FinanceDataSet7TableAdapters.testingviewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testingviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet7)).BeginInit();
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
            this.sL1DataGridViewTextBoxColumn,
            this.sL2DataGridViewTextBoxColumn,
            this.sL3DataGridViewTextBoxColumn,
            this.accNameDataGridViewTextBoxColumn,
            this.accountIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.testingviewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(36, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(732, 150);
            this.dataGridView1.TabIndex = 23;
            // 
            // sL1DataGridViewTextBoxColumn
            // 
            this.sL1DataGridViewTextBoxColumn.DataPropertyName = "SL1";
            this.sL1DataGridViewTextBoxColumn.HeaderText = "SL1";
            this.sL1DataGridViewTextBoxColumn.Name = "sL1DataGridViewTextBoxColumn";
            this.sL1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sL2DataGridViewTextBoxColumn
            // 
            this.sL2DataGridViewTextBoxColumn.DataPropertyName = "SL2";
            this.sL2DataGridViewTextBoxColumn.HeaderText = "SL2";
            this.sL2DataGridViewTextBoxColumn.Name = "sL2DataGridViewTextBoxColumn";
            this.sL2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sL3DataGridViewTextBoxColumn
            // 
            this.sL3DataGridViewTextBoxColumn.DataPropertyName = "SL3";
            this.sL3DataGridViewTextBoxColumn.HeaderText = "SL3";
            this.sL3DataGridViewTextBoxColumn.Name = "sL3DataGridViewTextBoxColumn";
            this.sL3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accNameDataGridViewTextBoxColumn
            // 
            this.accNameDataGridViewTextBoxColumn.DataPropertyName = "AccName";
            this.accNameDataGridViewTextBoxColumn.HeaderText = "AccName";
            this.accNameDataGridViewTextBoxColumn.Name = "accNameDataGridViewTextBoxColumn";
            this.accNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountIDDataGridViewTextBoxColumn
            // 
            this.accountIDDataGridViewTextBoxColumn.DataPropertyName = "AccountID";
            this.accountIDDataGridViewTextBoxColumn.HeaderText = "AccountID";
            this.accountIDDataGridViewTextBoxColumn.Name = "accountIDDataGridViewTextBoxColumn";
            this.accountIDDataGridViewTextBoxColumn.ReadOnly = true;
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
            // ImportTesting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 328);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dropdown_sheet);
            this.Controls.Add(this.btload);
            this.Controls.Add(this.tb_path);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.open);
            this.Name = "ImportTesting";
            this.Text = "ImportTesting";
            this.Load += new System.EventHandler(this.ImportTesting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testingviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet7)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn sL1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sL2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sL3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountIDDataGridViewTextBoxColumn;
    }
}