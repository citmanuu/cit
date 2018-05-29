namespace MANUUFinance
{
    partial class frmSL2
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSL2Code = new System.Windows.Forms.TextBox();
            this.comboSL1 = new System.Windows.Forms.ComboBox();
            this.txtSL2Order = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioBtnSL2InActive = new System.Windows.Forms.RadioButton();
            this.radioBtnSL2Active = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSL2Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSL2ID = new System.Windows.Forms.TextBox();
            this.DGVSL2SL1 = new System.Windows.Forms.DataGridView();
            this.sL2SL1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.financeDataSet = new MANUUFinance.FinanceDataSet();
            this.financeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sL2SL1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sL2SL1TableAdapter = new MANUUFinance.FinanceDataSetTableAdapters.SL2SL1TableAdapter();
            this.txtPKSL2 = new System.Windows.Forms.TextBox();
            this.financeDataSet13 = new MANUUFinance.FinanceDataSet13();
            this.sL2SL1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sL2SL1TableAdapter1 = new MANUUFinance.FinanceDataSet13TableAdapters.SL2SL1TableAdapter();
            this.SL2ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pKSL2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sL1IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sL2IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sL1NameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sl2NameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sL2OrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sL2ActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sL2CodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSL2SL1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sL2SL1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sL2SL1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sL2SL1BindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPrint);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Location = new System.Drawing.Point(58, 189);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(582, 45);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(286, 12);
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
            this.button1.Location = new System.Drawing.Point(472, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "Close Form";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(379, 12);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(89, 25);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear Controls";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(193, 12);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 25);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete Record";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(101, 12);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(89, 25);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update Record";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(8, 12);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 25);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Record";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSL2Code);
            this.groupBox1.Controls.Add(this.comboSL1);
            this.groupBox1.Controls.Add(this.txtSL2Order);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtSL2Name);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSL2ID);
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(58, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(723, 153);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Schedule Level - 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(510, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "SL2 Code";
            // 
            // txtSL2Code
            // 
            this.txtSL2Code.Enabled = false;
            this.txtSL2Code.Location = new System.Drawing.Point(590, 26);
            this.txtSL2Code.Margin = new System.Windows.Forms.Padding(2);
            this.txtSL2Code.Name = "txtSL2Code";
            this.txtSL2Code.Size = new System.Drawing.Size(68, 20);
            this.txtSL2Code.TabIndex = 21;
            // 
            // comboSL1
            // 
            this.comboSL1.FormattingEnabled = true;
            this.comboSL1.Location = new System.Drawing.Point(143, 24);
            this.comboSL1.Margin = new System.Windows.Forms.Padding(2);
            this.comboSL1.Name = "comboSL1";
            this.comboSL1.Size = new System.Drawing.Size(316, 21);
            this.comboSL1.TabIndex = 0;
            // 
            // txtSL2Order
            // 
            this.txtSL2Order.Location = new System.Drawing.Point(590, 55);
            this.txtSL2Order.Margin = new System.Windows.Forms.Padding(2);
            this.txtSL2Order.Name = "txtSL2Order";
            this.txtSL2Order.Size = new System.Drawing.Size(68, 20);
            this.txtSL2Order.TabIndex = 2;
            this.txtSL2Order.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSL2Order_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(511, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "SL2 Order";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 105);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "SL2 Active";
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
            this.groupBox3.Controls.Add(this.radioBtnSL2InActive);
            this.groupBox3.Controls.Add(this.radioBtnSL2Active);
            this.groupBox3.Location = new System.Drawing.Point(143, 99);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(182, 31);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            // 
            // radioBtnSL2InActive
            // 
            this.radioBtnSL2InActive.AutoSize = true;
            this.radioBtnSL2InActive.Location = new System.Drawing.Point(99, 10);
            this.radioBtnSL2InActive.Margin = new System.Windows.Forms.Padding(2);
            this.radioBtnSL2InActive.Name = "radioBtnSL2InActive";
            this.radioBtnSL2InActive.Size = new System.Drawing.Size(63, 17);
            this.radioBtnSL2InActive.TabIndex = 1;
            this.radioBtnSL2InActive.TabStop = true;
            this.radioBtnSL2InActive.Text = "Inactive";
            this.radioBtnSL2InActive.UseVisualStyleBackColor = true;
            // 
            // radioBtnSL2Active
            // 
            this.radioBtnSL2Active.AutoSize = true;
            this.radioBtnSL2Active.Location = new System.Drawing.Point(27, 10);
            this.radioBtnSL2Active.Margin = new System.Windows.Forms.Padding(2);
            this.radioBtnSL2Active.Name = "radioBtnSL2Active";
            this.radioBtnSL2Active.Size = new System.Drawing.Size(55, 17);
            this.radioBtnSL2Active.TabIndex = 0;
            this.radioBtnSL2Active.TabStop = true;
            this.radioBtnSL2Active.Text = "Active";
            this.radioBtnSL2Active.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 79);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "SL2 Name";
            // 
            // txtSL2Name
            // 
            this.txtSL2Name.Location = new System.Drawing.Point(143, 79);
            this.txtSL2Name.Margin = new System.Windows.Forms.Padding(2);
            this.txtSL2Name.Name = "txtSL2Name";
            this.txtSL2Name.Size = new System.Drawing.Size(316, 20);
            this.txtSL2Name.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "SL2 ID";
            // 
            // txtSL2ID
            // 
            this.txtSL2ID.Location = new System.Drawing.Point(143, 52);
            this.txtSL2ID.Margin = new System.Windows.Forms.Padding(2);
            this.txtSL2ID.Name = "txtSL2ID";
            this.txtSL2ID.Size = new System.Drawing.Size(68, 20);
            this.txtSL2ID.TabIndex = 1;
            // 
            // DGVSL2SL1
            // 
            this.DGVSL2SL1.AllowUserToAddRows = false;
            this.DGVSL2SL1.AllowUserToDeleteRows = false;
            this.DGVSL2SL1.AllowUserToResizeColumns = false;
            this.DGVSL2SL1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.DGVSL2SL1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVSL2SL1.AutoGenerateColumns = false;
            this.DGVSL2SL1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVSL2SL1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVSL2SL1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSL2SL1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SL2ID,
            this.pKSL2DataGridViewTextBoxColumn,
            this.sL1IDDataGridViewTextBoxColumn,
            this.sL2IDDataGridViewTextBoxColumn,
            this.sL1NameDataGridViewTextBoxColumn,
            this.sl2NameDataGridViewTextBoxColumn,
            this.sL2OrderDataGridViewTextBoxColumn,
            this.sL2ActiveDataGridViewCheckBoxColumn,
            this.sL2CodeDataGridViewTextBoxColumn});
            this.DGVSL2SL1.DataSource = this.sL2SL1BindingSource2;
            this.DGVSL2SL1.Location = new System.Drawing.Point(39, 250);
            this.DGVSL2SL1.Margin = new System.Windows.Forms.Padding(2);
            this.DGVSL2SL1.MultiSelect = false;
            this.DGVSL2SL1.Name = "DGVSL2SL1";
            this.DGVSL2SL1.ReadOnly = true;
            this.DGVSL2SL1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DGVSL2SL1.RowTemplate.Height = 28;
            this.DGVSL2SL1.Size = new System.Drawing.Size(755, 263);
            this.DGVSL2SL1.TabIndex = 23;
            this.DGVSL2SL1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVSL2SL1_CellClick);
            // 
            // sL2SL1BindingSource1
            // 
            this.sL2SL1BindingSource1.DataMember = "SL2SL1";
            this.sL2SL1BindingSource1.DataSource = this.financeDataSet;
            // 
            // financeDataSet
            // 
            this.financeDataSet.DataSetName = "FinanceDataSet";
            this.financeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // financeDataSetBindingSource
            // 
            this.financeDataSetBindingSource.DataSource = this.financeDataSet;
            this.financeDataSetBindingSource.Position = 0;
            // 
            // sL2SL1BindingSource
            // 
            this.sL2SL1BindingSource.DataMember = "SL2SL1";
            this.sL2SL1BindingSource.DataSource = this.financeDataSet;
            // 
            // sL2SL1TableAdapter
            // 
            this.sL2SL1TableAdapter.ClearBeforeFill = true;
            // 
            // txtPKSL2
            // 
            this.txtPKSL2.Location = new System.Drawing.Point(727, 199);
            this.txtPKSL2.Margin = new System.Windows.Forms.Padding(2);
            this.txtPKSL2.Name = "txtPKSL2";
            this.txtPKSL2.Size = new System.Drawing.Size(68, 20);
            this.txtPKSL2.TabIndex = 24;
            // 
            // financeDataSet13
            // 
            this.financeDataSet13.DataSetName = "FinanceDataSet13";
            this.financeDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sL2SL1BindingSource2
            // 
            this.sL2SL1BindingSource2.DataMember = "SL2SL1";
            this.sL2SL1BindingSource2.DataSource = this.financeDataSet13;
            // 
            // sL2SL1TableAdapter1
            // 
            this.sL2SL1TableAdapter1.ClearBeforeFill = true;
            // 
            // SL2ID
            // 
            this.SL2ID.DataPropertyName = "SL2ID";
            this.SL2ID.HeaderText = "SL2ID";
            this.SL2ID.Name = "SL2ID";
            this.SL2ID.ReadOnly = true;
            this.SL2ID.Visible = false;
            this.SL2ID.Width = 62;
            // 
            // pKSL2DataGridViewTextBoxColumn
            // 
            this.pKSL2DataGridViewTextBoxColumn.DataPropertyName = "PKSL2";
            this.pKSL2DataGridViewTextBoxColumn.HeaderText = "PKSL2";
            this.pKSL2DataGridViewTextBoxColumn.Name = "pKSL2DataGridViewTextBoxColumn";
            this.pKSL2DataGridViewTextBoxColumn.ReadOnly = true;
            this.pKSL2DataGridViewTextBoxColumn.Width = 65;
            // 
            // sL1IDDataGridViewTextBoxColumn
            // 
            this.sL1IDDataGridViewTextBoxColumn.DataPropertyName = "SL1ID";
            this.sL1IDDataGridViewTextBoxColumn.HeaderText = "SL1ID";
            this.sL1IDDataGridViewTextBoxColumn.Name = "sL1IDDataGridViewTextBoxColumn";
            this.sL1IDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sL1IDDataGridViewTextBoxColumn.Visible = false;
            this.sL1IDDataGridViewTextBoxColumn.Width = 62;
            // 
            // sL2IDDataGridViewTextBoxColumn
            // 
            this.sL2IDDataGridViewTextBoxColumn.DataPropertyName = "SL2ID";
            this.sL2IDDataGridViewTextBoxColumn.HeaderText = "SL2ID";
            this.sL2IDDataGridViewTextBoxColumn.Name = "sL2IDDataGridViewTextBoxColumn";
            this.sL2IDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sL2IDDataGridViewTextBoxColumn.Visible = false;
            this.sL2IDDataGridViewTextBoxColumn.Width = 62;
            // 
            // sL1NameDataGridViewTextBoxColumn
            // 
            this.sL1NameDataGridViewTextBoxColumn.DataPropertyName = "SL1Name";
            this.sL1NameDataGridViewTextBoxColumn.HeaderText = "SL1Name";
            this.sL1NameDataGridViewTextBoxColumn.Name = "sL1NameDataGridViewTextBoxColumn";
            this.sL1NameDataGridViewTextBoxColumn.ReadOnly = true;
            this.sL1NameDataGridViewTextBoxColumn.Width = 79;
            // 
            // sl2NameDataGridViewTextBoxColumn
            // 
            this.sl2NameDataGridViewTextBoxColumn.DataPropertyName = "Sl2Name";
            this.sl2NameDataGridViewTextBoxColumn.HeaderText = "Sl2Name";
            this.sl2NameDataGridViewTextBoxColumn.Name = "sl2NameDataGridViewTextBoxColumn";
            this.sl2NameDataGridViewTextBoxColumn.ReadOnly = true;
            this.sl2NameDataGridViewTextBoxColumn.Width = 75;
            // 
            // sL2OrderDataGridViewTextBoxColumn
            // 
            this.sL2OrderDataGridViewTextBoxColumn.DataPropertyName = "SL2Order";
            this.sL2OrderDataGridViewTextBoxColumn.HeaderText = "SL2Order";
            this.sL2OrderDataGridViewTextBoxColumn.Name = "sL2OrderDataGridViewTextBoxColumn";
            this.sL2OrderDataGridViewTextBoxColumn.ReadOnly = true;
            this.sL2OrderDataGridViewTextBoxColumn.Width = 77;
            // 
            // sL2ActiveDataGridViewCheckBoxColumn
            // 
            this.sL2ActiveDataGridViewCheckBoxColumn.DataPropertyName = "SL2Active";
            this.sL2ActiveDataGridViewCheckBoxColumn.HeaderText = "SL2Active";
            this.sL2ActiveDataGridViewCheckBoxColumn.Name = "sL2ActiveDataGridViewCheckBoxColumn";
            this.sL2ActiveDataGridViewCheckBoxColumn.ReadOnly = true;
            this.sL2ActiveDataGridViewCheckBoxColumn.Width = 62;
            // 
            // sL2CodeDataGridViewTextBoxColumn
            // 
            this.sL2CodeDataGridViewTextBoxColumn.DataPropertyName = "SL2Code";
            this.sL2CodeDataGridViewTextBoxColumn.HeaderText = "SL2Code";
            this.sL2CodeDataGridViewTextBoxColumn.Name = "sL2CodeDataGridViewTextBoxColumn";
            this.sL2CodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.sL2CodeDataGridViewTextBoxColumn.Width = 76;
            // 
            // frmSL2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 487);
            this.Controls.Add(this.txtPKSL2);
            this.Controls.Add(this.DGVSL2SL1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmSL2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule Level - 2";
            this.Load += new System.EventHandler(this.frmSL2_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSL2SL1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sL2SL1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sL2SL1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sL2SL1BindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboSL1;
        private System.Windows.Forms.TextBox txtSL2Order;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioBtnSL2InActive;
        private System.Windows.Forms.RadioButton radioBtnSL2Active;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSL2Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSL2ID;
        private System.Windows.Forms.BindingSource financeDataSetBindingSource;
        private FinanceDataSet financeDataSet;
        private System.Windows.Forms.BindingSource sL2SL1BindingSource;
        private FinanceDataSetTableAdapters.SL2SL1TableAdapter sL2SL1TableAdapter;
        private System.Windows.Forms.DataGridView DGVSL2SL1;
        private System.Windows.Forms.BindingSource sL2SL1BindingSource1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSL2Code;
        private System.Windows.Forms.TextBox txtPKSL2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPrint;
        private FinanceDataSet13 financeDataSet13;
        private System.Windows.Forms.BindingSource sL2SL1BindingSource2;
        private FinanceDataSet13TableAdapters.SL2SL1TableAdapter sL2SL1TableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL2ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn pKSL2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sL1IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sL2IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sL1NameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sl2NameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sL2OrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sL2ActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sL2CodeDataGridViewTextBoxColumn;
    }
}