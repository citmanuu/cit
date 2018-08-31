namespace MANUUFinance
{
    partial class frmVAcType
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboAccountType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboSL3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVAcOrder = new System.Windows.Forms.TextBox();
            this.comboSL2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboSL1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioBtnSL3InActive = new System.Windows.Forms.RadioButton();
            this.radioBtnSL3Active = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.DGVSL3SL2SL1 = new System.Windows.Forms.DataGridView();
            this.pKVATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKSL1IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKSL2IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKSL3IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vAcNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vAcActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.vAcOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vACAddedOnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vACUpdatedOnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vACUpdateByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vATMapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.financeDataSet15 = new MANUUFinance.FinanceDataSet15();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.vATMapTableAdapter = new MANUUFinance.FinanceDataSet15TableAdapters.VATMapTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSL3SL2SL1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vATMapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet15)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboAccountType);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboSL3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtVAcOrder);
            this.groupBox1.Controls.Add(this.comboSL2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboSL1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(25, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(760, 197);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Type";
            // 
            // comboAccountType
            // 
            this.comboAccountType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboAccountType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboAccountType.FormattingEnabled = true;
            this.comboAccountType.Location = new System.Drawing.Point(143, 113);
            this.comboAccountType.Margin = new System.Windows.Forms.Padding(2);
            this.comboAccountType.Name = "comboAccountType";
            this.comboAccountType.Size = new System.Drawing.Size(182, 21);
            this.comboAccountType.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 115);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Account Type";
            // 
            // comboSL3
            // 
            this.comboSL3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboSL3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboSL3.FormattingEnabled = true;
            this.comboSL3.Location = new System.Drawing.Point(143, 78);
            this.comboSL3.Margin = new System.Windows.Forms.Padding(2);
            this.comboSL3.Name = "comboSL3";
            this.comboSL3.Size = new System.Drawing.Size(316, 21);
            this.comboSL3.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(577, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Account  Order";
            // 
            // txtVAcOrder
            // 
            this.txtVAcOrder.Location = new System.Drawing.Point(668, 26);
            this.txtVAcOrder.Margin = new System.Windows.Forms.Padding(2);
            this.txtVAcOrder.Name = "txtVAcOrder";
            this.txtVAcOrder.Size = new System.Drawing.Size(68, 20);
            this.txtVAcOrder.TabIndex = 5;
            // 
            // comboSL2
            // 
            this.comboSL2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboSL2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboSL2.FormattingEnabled = true;
            this.comboSL2.Location = new System.Drawing.Point(143, 51);
            this.comboSL2.Margin = new System.Windows.Forms.Padding(2);
            this.comboSL2.Name = "comboSL2";
            this.comboSL2.Size = new System.Drawing.Size(316, 21);
            this.comboSL2.TabIndex = 2;
            this.comboSL2.SelectedIndexChanged += new System.EventHandler(this.comboSL2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "SL2 Name";
            // 
            // comboSL1
            // 
            this.comboSL1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboSL1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboSL1.FormattingEnabled = true;
            this.comboSL1.Location = new System.Drawing.Point(143, 24);
            this.comboSL1.Margin = new System.Windows.Forms.Padding(2);
            this.comboSL1.Name = "comboSL1";
            this.comboSL1.Size = new System.Drawing.Size(316, 21);
            this.comboSL1.TabIndex = 0;
            this.comboSL1.SelectedIndexChanged += new System.EventHandler(this.comboSL1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 148);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Account Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "SL1 Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioBtnSL3InActive);
            this.groupBox3.Controls.Add(this.radioBtnSL3Active);
            this.groupBox3.Location = new System.Drawing.Point(143, 138);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(182, 31);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            // 
            // radioBtnSL3InActive
            // 
            this.radioBtnSL3InActive.AutoSize = true;
            this.radioBtnSL3InActive.Location = new System.Drawing.Point(99, 10);
            this.radioBtnSL3InActive.Margin = new System.Windows.Forms.Padding(2);
            this.radioBtnSL3InActive.Name = "radioBtnSL3InActive";
            this.radioBtnSL3InActive.Size = new System.Drawing.Size(63, 17);
            this.radioBtnSL3InActive.TabIndex = 1;
            this.radioBtnSL3InActive.Text = "Inactive";
            this.radioBtnSL3InActive.UseVisualStyleBackColor = true;
            // 
            // radioBtnSL3Active
            // 
            this.radioBtnSL3Active.AutoSize = true;
            this.radioBtnSL3Active.Checked = true;
            this.radioBtnSL3Active.Location = new System.Drawing.Point(27, 10);
            this.radioBtnSL3Active.Margin = new System.Windows.Forms.Padding(2);
            this.radioBtnSL3Active.Name = "radioBtnSL3Active";
            this.radioBtnSL3Active.Size = new System.Drawing.Size(55, 17);
            this.radioBtnSL3Active.TabIndex = 0;
            this.radioBtnSL3Active.TabStop = true;
            this.radioBtnSL3Active.Text = "Active";
            this.radioBtnSL3Active.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 80);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "SL3 Name";
            // 
            // DGVSL3SL2SL1
            // 
            this.DGVSL3SL2SL1.AllowUserToAddRows = false;
            this.DGVSL3SL2SL1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.DGVSL3SL2SL1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVSL3SL2SL1.AutoGenerateColumns = false;
            this.DGVSL3SL2SL1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSL3SL2SL1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pKVATDataGridViewTextBoxColumn,
            this.fKSL1IDDataGridViewTextBoxColumn,
            this.fKSL2IDDataGridViewTextBoxColumn,
            this.fKSL3IDDataGridViewTextBoxColumn,
            this.vAcNameDataGridViewTextBoxColumn,
            this.vAcActiveDataGridViewCheckBoxColumn,
            this.vAcOrderDataGridViewTextBoxColumn,
            this.vACAddedOnDataGridViewTextBoxColumn,
            this.vACUpdatedOnDataGridViewTextBoxColumn,
            this.vACUpdateByDataGridViewTextBoxColumn});
            this.DGVSL3SL2SL1.DataSource = this.vATMapBindingSource;
            this.DGVSL3SL2SL1.Location = new System.Drawing.Point(71, 281);
            this.DGVSL3SL2SL1.Name = "DGVSL3SL2SL1";
            this.DGVSL3SL2SL1.ReadOnly = true;
            this.DGVSL3SL2SL1.Size = new System.Drawing.Size(675, 150);
            this.DGVSL3SL2SL1.TabIndex = 27;
            this.DGVSL3SL2SL1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pKVATDataGridViewTextBoxColumn
            // 
            this.pKVATDataGridViewTextBoxColumn.DataPropertyName = "PKVAT";
            this.pKVATDataGridViewTextBoxColumn.HeaderText = "PKVAT";
            this.pKVATDataGridViewTextBoxColumn.Name = "pKVATDataGridViewTextBoxColumn";
            this.pKVATDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fKSL1IDDataGridViewTextBoxColumn
            // 
            this.fKSL1IDDataGridViewTextBoxColumn.DataPropertyName = "FKSL1ID";
            this.fKSL1IDDataGridViewTextBoxColumn.HeaderText = "FKSL1ID";
            this.fKSL1IDDataGridViewTextBoxColumn.Name = "fKSL1IDDataGridViewTextBoxColumn";
            this.fKSL1IDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fKSL2IDDataGridViewTextBoxColumn
            // 
            this.fKSL2IDDataGridViewTextBoxColumn.DataPropertyName = "FKSL2ID";
            this.fKSL2IDDataGridViewTextBoxColumn.HeaderText = "FKSL2ID";
            this.fKSL2IDDataGridViewTextBoxColumn.Name = "fKSL2IDDataGridViewTextBoxColumn";
            this.fKSL2IDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fKSL3IDDataGridViewTextBoxColumn
            // 
            this.fKSL3IDDataGridViewTextBoxColumn.DataPropertyName = "FKSL3ID";
            this.fKSL3IDDataGridViewTextBoxColumn.HeaderText = "FKSL3ID";
            this.fKSL3IDDataGridViewTextBoxColumn.Name = "fKSL3IDDataGridViewTextBoxColumn";
            this.fKSL3IDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vAcNameDataGridViewTextBoxColumn
            // 
            this.vAcNameDataGridViewTextBoxColumn.DataPropertyName = "VAcName";
            this.vAcNameDataGridViewTextBoxColumn.HeaderText = "VAcName";
            this.vAcNameDataGridViewTextBoxColumn.Name = "vAcNameDataGridViewTextBoxColumn";
            this.vAcNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vAcActiveDataGridViewCheckBoxColumn
            // 
            this.vAcActiveDataGridViewCheckBoxColumn.DataPropertyName = "VAcActive";
            this.vAcActiveDataGridViewCheckBoxColumn.HeaderText = "VAcActive";
            this.vAcActiveDataGridViewCheckBoxColumn.Name = "vAcActiveDataGridViewCheckBoxColumn";
            this.vAcActiveDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // vAcOrderDataGridViewTextBoxColumn
            // 
            this.vAcOrderDataGridViewTextBoxColumn.DataPropertyName = "VAcOrder";
            this.vAcOrderDataGridViewTextBoxColumn.HeaderText = "VAcOrder";
            this.vAcOrderDataGridViewTextBoxColumn.Name = "vAcOrderDataGridViewTextBoxColumn";
            this.vAcOrderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vACAddedOnDataGridViewTextBoxColumn
            // 
            this.vACAddedOnDataGridViewTextBoxColumn.DataPropertyName = "VACAddedOn";
            this.vACAddedOnDataGridViewTextBoxColumn.HeaderText = "VACAddedOn";
            this.vACAddedOnDataGridViewTextBoxColumn.Name = "vACAddedOnDataGridViewTextBoxColumn";
            this.vACAddedOnDataGridViewTextBoxColumn.ReadOnly = true;
            this.vACAddedOnDataGridViewTextBoxColumn.Visible = false;
            // 
            // vACUpdatedOnDataGridViewTextBoxColumn
            // 
            this.vACUpdatedOnDataGridViewTextBoxColumn.DataPropertyName = "VACUpdatedOn";
            this.vACUpdatedOnDataGridViewTextBoxColumn.HeaderText = "VACUpdatedOn";
            this.vACUpdatedOnDataGridViewTextBoxColumn.Name = "vACUpdatedOnDataGridViewTextBoxColumn";
            this.vACUpdatedOnDataGridViewTextBoxColumn.ReadOnly = true;
            this.vACUpdatedOnDataGridViewTextBoxColumn.Visible = false;
            // 
            // vACUpdateByDataGridViewTextBoxColumn
            // 
            this.vACUpdateByDataGridViewTextBoxColumn.DataPropertyName = "VACUpdateBy";
            this.vACUpdateByDataGridViewTextBoxColumn.HeaderText = "VACUpdateBy";
            this.vACUpdateByDataGridViewTextBoxColumn.Name = "vACUpdateByDataGridViewTextBoxColumn";
            this.vACUpdateByDataGridViewTextBoxColumn.ReadOnly = true;
            this.vACUpdateByDataGridViewTextBoxColumn.Visible = false;
            // 
            // vATMapBindingSource
            // 
            this.vATMapBindingSource.DataMember = "VATMap";
            this.vATMapBindingSource.DataSource = this.financeDataSet15;
            // 
            // financeDataSet15
            // 
            this.financeDataSet15.DataSetName = "FinanceDataSet15";
            this.financeDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPrint);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Location = new System.Drawing.Point(128, 232);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(567, 45);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(284, 12);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(89, 25);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Print Record";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(468, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cl&ose Form";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(376, 12);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(89, 25);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "&Clear Controls";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(192, 12);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 25);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "&Delete Record";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(99, 12);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(89, 25);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "&Update Record";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(7, 12);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 25);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "&Add Record";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // vATMapTableAdapter
            // 
            this.vATMapTableAdapter.ClearBeforeFill = true;
            // 
            // frmVAcType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 443);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DGVSL3SL2SL1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmVAcType";
            this.Text = "frmVAcType";
            this.Load += new System.EventHandler(this.frmVAcType_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSL3SL2SL1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vATMapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet15)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboSL3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVAcOrder;
        private System.Windows.Forms.ComboBox comboSL2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboSL1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioBtnSL3InActive;
        private System.Windows.Forms.RadioButton radioBtnSL3Active;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DGVSL3SL2SL1;
        private System.Windows.Forms.ComboBox comboAccountType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private FinanceDataSet15 financeDataSet15;
        private System.Windows.Forms.BindingSource vATMapBindingSource;
        private FinanceDataSet15TableAdapters.VATMapTableAdapter vATMapTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pKVATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKSL1IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKSL2IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKSL3IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vAcNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn vAcActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vAcOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vACAddedOnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vACUpdatedOnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vACUpdateByDataGridViewTextBoxColumn;
    }
}