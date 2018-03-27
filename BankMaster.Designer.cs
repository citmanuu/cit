namespace MANUUFinance
{
    partial class frmBank
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBankShortName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBankID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBankName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DGVBanks = new System.Windows.Forms.DataGridView();
            this.bankIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BankShortName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.financeDataSet = new MANUUFinance.FinanceDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnUpdateAccount = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtBankShortNameRO = new System.Windows.Forms.TextBox();
            this.txtBankNameForAcc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboAcType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.DGVBankAccounts = new System.Windows.Forms.DataGridView();
            this.bankAccountDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPKBANKACC = new System.Windows.Forms.TextBox();
            this.bankMasterTableAdapter = new MANUUFinance.FinanceDataSetTableAdapters.BankMasterTableAdapter();
            this.bankAccountDetailsTableAdapter = new MANUUFinance.FinanceDataSetTableAdapters.BankAccountDetailsTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.bankNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKBankIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PKBANKACC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FKAccountType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBanks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBankAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankAccountDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Location = new System.Drawing.Point(85, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(709, 74);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(566, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cl&ose Form";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(427, 21);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(133, 38);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "&Clear Controls";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(288, 21);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(133, 38);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "&Delete Record";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(149, 21);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(133, 38);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "&Update Record";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(10, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 38);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "&Add Record";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBankShortName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtBankID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtBankName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(33, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(853, 136);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bank Master";
            // 
            // txtBankShortName
            // 
            this.txtBankShortName.Location = new System.Drawing.Point(446, 82);
            this.txtBankShortName.Name = "txtBankShortName";
            this.txtBankShortName.Size = new System.Drawing.Size(100, 26);
            this.txtBankShortName.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(308, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "Bank Short Name";
            // 
            // txtBankID
            // 
            this.txtBankID.Enabled = false;
            this.txtBankID.Location = new System.Drawing.Point(143, 45);
            this.txtBankID.Name = "txtBankID";
            this.txtBankID.Size = new System.Drawing.Size(100, 26);
            this.txtBankID.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Bank ID";
            // 
            // txtBankName
            // 
            this.txtBankName.Location = new System.Drawing.Point(446, 45);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Size = new System.Drawing.Size(381, 26);
            this.txtBankName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Bank Name";
            // 
            // DGVBanks
            // 
            this.DGVBanks.AllowUserToAddRows = false;
            this.DGVBanks.AllowUserToDeleteRows = false;
            this.DGVBanks.AllowUserToResizeColumns = false;
            this.DGVBanks.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.DGVBanks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVBanks.AutoGenerateColumns = false;
            this.DGVBanks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVBanks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBanks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bankIDDataGridViewTextBoxColumn,
            this.BankShortName,
            this.bankNameDataGridViewTextBoxColumn});
            this.DGVBanks.DataSource = this.bankMasterBindingSource;
            this.DGVBanks.Location = new System.Drawing.Point(912, 35);
            this.DGVBanks.MultiSelect = false;
            this.DGVBanks.Name = "DGVBanks";
            this.DGVBanks.ReadOnly = true;
            this.DGVBanks.RowTemplate.Height = 28;
            this.DGVBanks.Size = new System.Drawing.Size(462, 223);
            this.DGVBanks.TabIndex = 23;
            this.DGVBanks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVBanks_CellClick);
            // 
            // bankIDDataGridViewTextBoxColumn
            // 
            this.bankIDDataGridViewTextBoxColumn.DataPropertyName = "BankID";
            this.bankIDDataGridViewTextBoxColumn.HeaderText = "BankID";
            this.bankIDDataGridViewTextBoxColumn.MinimumWidth = 60;
            this.bankIDDataGridViewTextBoxColumn.Name = "bankIDDataGridViewTextBoxColumn";
            this.bankIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bankIDDataGridViewTextBoxColumn.Width = 60;
            // 
            // BankShortName
            // 
            this.BankShortName.DataPropertyName = "BankShortName";
            this.BankShortName.HeaderText = "BankShortName";
            this.BankShortName.MinimumWidth = 60;
            this.BankShortName.Name = "BankShortName";
            this.BankShortName.ReadOnly = true;
            this.BankShortName.Width = 60;
            // 
            // bankNameDataGridViewTextBoxColumn
            // 
            this.bankNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.bankNameDataGridViewTextBoxColumn.DataPropertyName = "BankName";
            this.bankNameDataGridViewTextBoxColumn.HeaderText = "BankName";
            this.bankNameDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.bankNameDataGridViewTextBoxColumn.Name = "bankNameDataGridViewTextBoxColumn";
            this.bankNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.bankNameDataGridViewTextBoxColumn.Width = 492;
            // 
            // bankMasterBindingSource
            // 
            this.bankMasterBindingSource.DataMember = "BankMaster";
            this.bankMasterBindingSource.DataSource = this.financeDataSet;
            // 
            // financeDataSet
            // 
            this.financeDataSet.DataSetName = "FinanceDataSet";
            this.financeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1068, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Registered Banks";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.btnDeleteAccount);
            this.groupBox3.Controls.Add(this.btnUpdateAccount);
            this.groupBox3.Controls.Add(this.btnAddAccount);
            this.groupBox3.Location = new System.Drawing.Point(73, 532);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(711, 74);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(566, 21);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 38);
            this.button4.TabIndex = 4;
            this.button4.Text = "Cl&ose Form";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(427, 21);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 38);
            this.button5.TabIndex = 3;
            this.button5.Text = "&Clear Controls";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Location = new System.Drawing.Point(288, 21);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(133, 38);
            this.btnDeleteAccount.TabIndex = 2;
            this.btnDeleteAccount.Text = "&Delete Record";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnUpdateAccount
            // 
            this.btnUpdateAccount.Location = new System.Drawing.Point(149, 21);
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            this.btnUpdateAccount.Size = new System.Drawing.Size(133, 38);
            this.btnUpdateAccount.TabIndex = 1;
            this.btnUpdateAccount.Text = "&Update Record";
            this.btnUpdateAccount.UseVisualStyleBackColor = true;
            this.btnUpdateAccount.Click += new System.EventHandler(this.btnUpdateAccount_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(10, 21);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(133, 38);
            this.btnAddAccount.TabIndex = 0;
            this.btnAddAccount.Text = "&Add Record";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtBankShortNameRO);
            this.groupBox4.Controls.Add(this.txtBankNameForAcc);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.comboAcType);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtAccountNo);
            this.groupBox4.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox4.Location = new System.Drawing.Point(43, 364);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(843, 150);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bank Accounts";
            // 
            // txtBankShortNameRO
            // 
            this.txtBankShortNameRO.Enabled = false;
            this.txtBankShortNameRO.Location = new System.Drawing.Point(508, 46);
            this.txtBankShortNameRO.Name = "txtBankShortNameRO";
            this.txtBankShortNameRO.Size = new System.Drawing.Size(100, 26);
            this.txtBankShortNameRO.TabIndex = 37;
            // 
            // txtBankNameForAcc
            // 
            this.txtBankNameForAcc.Enabled = false;
            this.txtBankNameForAcc.Location = new System.Drawing.Point(148, 46);
            this.txtBankNameForAcc.Name = "txtBankNameForAcc";
            this.txtBankNameForAcc.Size = new System.Drawing.Size(325, 26);
            this.txtBankNameForAcc.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Bank Name";
            // 
            // comboAcType
            // 
            this.comboAcType.FormattingEnabled = true;
            this.comboAcType.Location = new System.Drawing.Point(145, 89);
            this.comboAcType.Name = "comboAcType";
            this.comboAcType.Size = new System.Drawing.Size(211, 28);
            this.comboAcType.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(381, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Account No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Account Type";
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Enabled = false;
            this.txtAccountNo.Location = new System.Drawing.Point(503, 89);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(314, 26);
            this.txtAccountNo.TabIndex = 29;
            // 
            // DGVBankAccounts
            // 
            this.DGVBankAccounts.AllowUserToAddRows = false;
            this.DGVBankAccounts.AllowUserToDeleteRows = false;
            this.DGVBankAccounts.AllowUserToResizeColumns = false;
            this.DGVBankAccounts.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.DGVBankAccounts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVBankAccounts.AutoGenerateColumns = false;
            this.DGVBankAccounts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVBankAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBankAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bankNameDataGridViewTextBoxColumn1,
            this.AccountType,
            this.accountNumberDataGridViewTextBoxColumn,
            this.fKBankIDDataGridViewTextBoxColumn,
            this.PKBANKACC,
            this.FKAccountType});
            this.DGVBankAccounts.DataSource = this.bankAccountDetailsBindingSource;
            this.DGVBankAccounts.Location = new System.Drawing.Point(912, 364);
            this.DGVBankAccounts.MultiSelect = false;
            this.DGVBankAccounts.Name = "DGVBankAccounts";
            this.DGVBankAccounts.ReadOnly = true;
            this.DGVBankAccounts.RowTemplate.Height = 28;
            this.DGVBankAccounts.Size = new System.Drawing.Size(472, 242);
            this.DGVBankAccounts.TabIndex = 27;
            this.DGVBankAccounts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVBankAccounts_CellClick);
            // 
            // bankAccountDetailsBindingSource
            // 
            this.bankAccountDetailsBindingSource.DataMember = "BankAccountDetails";
            this.bankAccountDetailsBindingSource.DataSource = this.financeDataSet;
            // 
            // txtPKBANKACC
            // 
            this.txtPKBANKACC.Enabled = false;
            this.txtPKBANKACC.Location = new System.Drawing.Point(191, 612);
            this.txtPKBANKACC.Name = "txtPKBANKACC";
            this.txtPKBANKACC.Size = new System.Drawing.Size(48, 26);
            this.txtPKBANKACC.TabIndex = 31;
            this.txtPKBANKACC.Visible = false;
            // 
            // bankMasterTableAdapter
            // 
            this.bankMasterTableAdapter.ClearBeforeFill = true;
            // 
            // bankAccountDetailsTableAdapter
            // 
            this.bankAccountDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1081, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Bank Accounts";
            // 
            // bankNameDataGridViewTextBoxColumn1
            // 
            this.bankNameDataGridViewTextBoxColumn1.DataPropertyName = "BankName";
            this.bankNameDataGridViewTextBoxColumn1.HeaderText = "Bank Name";
            this.bankNameDataGridViewTextBoxColumn1.Name = "bankNameDataGridViewTextBoxColumn1";
            this.bankNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // AccountType
            // 
            this.AccountType.DataPropertyName = "AccountType";
            this.AccountType.HeaderText = "AccountType";
            this.AccountType.Name = "AccountType";
            this.AccountType.ReadOnly = true;
            // 
            // accountNumberDataGridViewTextBoxColumn
            // 
            this.accountNumberDataGridViewTextBoxColumn.DataPropertyName = "AccountNumber";
            this.accountNumberDataGridViewTextBoxColumn.HeaderText = "A/c Number";
            this.accountNumberDataGridViewTextBoxColumn.Name = "accountNumberDataGridViewTextBoxColumn";
            this.accountNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fKBankIDDataGridViewTextBoxColumn
            // 
            this.fKBankIDDataGridViewTextBoxColumn.DataPropertyName = "FKBankID";
            this.fKBankIDDataGridViewTextBoxColumn.HeaderText = "FKBankID";
            this.fKBankIDDataGridViewTextBoxColumn.Name = "fKBankIDDataGridViewTextBoxColumn";
            this.fKBankIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.fKBankIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // PKBANKACC
            // 
            this.PKBANKACC.DataPropertyName = "PKBANKACC";
            this.PKBANKACC.HeaderText = "PKBANKACC";
            this.PKBANKACC.Name = "PKBANKACC";
            this.PKBANKACC.ReadOnly = true;
            this.PKBANKACC.Visible = false;
            // 
            // FKAccountType
            // 
            this.FKAccountType.DataPropertyName = "FKAccountType";
            this.FKAccountType.HeaderText = "FKAccountType";
            this.FKAccountType.Name = "FKAccountType";
            this.FKAccountType.ReadOnly = true;
            this.FKAccountType.Visible = false;
            // 
            // frmBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 702);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPKBANKACC);
            this.Controls.Add(this.DGVBankAccounts);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVBanks);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank Master";
            this.Load += new System.EventHandler(this.frmBank_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBanks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBankAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankAccountDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBankName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DGVBanks;
        private System.Windows.Forms.Label label1;
        private FinanceDataSet financeDataSet;
        private System.Windows.Forms.BindingSource bankMasterBindingSource;
        private FinanceDataSetTableAdapters.BankMasterTableAdapter bankMasterTableAdapter;
        private System.Windows.Forms.TextBox txtBankID;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnUpdateAccount;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboAcType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.TextBox txtBankNameForAcc;
        private System.Windows.Forms.Label label2;
        private FinanceDataSetTableAdapters.BankAccountDetailsTableAdapter bankAccountDetailsTableAdapter;
        //private System.Windows.Forms.DataGridViewTextBoxColumn gEmDescDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn bankIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView DGVBankAccounts;
        private System.Windows.Forms.BindingSource bankAccountDetailsBindingSource;
        private System.Windows.Forms.TextBox txtPKBANKACC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBankShortName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBankShortNameRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankShortName;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountType;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKBankIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PKBANKACC;
        private System.Windows.Forms.DataGridViewTextBoxColumn FKAccountType;
    }
}