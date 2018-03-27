namespace MANUUFinance
{
    partial class frmBillDespatch
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
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBillNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBillNarration = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBillStatus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBillDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBeneficiery = new System.Windows.Forms.ComboBox();
            this.comboDept = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBillType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPKBillID = new System.Windows.Forms.TextBox();
            this.comboACID = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BeneficiaryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billMstViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.financeDataSet = new MANUUFinance.FinanceDataSet();
            this.billMstViewTableAdapter = new MANUUFinance.FinanceDataSetTableAdapters.BillMstViewTableAdapter();
            this.tableAdapterManager = new MANUUFinance.FinanceDataSetTableAdapters.TableAdapterManager();
            this.billDtlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.financeDataSet1 = new MANUUFinance.FinanceDataSet();
            this.billDtlTableAdapter = new MANUUFinance.FinanceDataSetTableAdapters.BillDtlTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAccountBalance = new System.Windows.Forms.TextBox();
            this.txtSL2Name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSL3Name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSL1Name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboAccountName = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBillAmount = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboACID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billMstViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billDtlBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnQuery);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Location = new System.Drawing.Point(231, 414);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(858, 70);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(568, 19);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(133, 38);
            this.btnQuery.TabIndex = 4;
            this.btnQuery.Text = "Query";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(707, 19);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 38);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close Form";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(429, 19);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(133, 38);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear Controls";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(290, 19);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(133, 38);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete Record";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(151, 19);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(133, 38);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update Record";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 38);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Record";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBillNumber);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBillNarration);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBillStatus);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtBillDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBeneficiery);
            this.groupBox1.Controls.Add(this.comboDept);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.comboBillType);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(44, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1165, 171);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bill Master";
            // 
            // txtBillNumber
            // 
            this.txtBillNumber.Enabled = false;
            this.txtBillNumber.Location = new System.Drawing.Point(392, 38);
            this.txtBillNumber.Name = "txtBillNumber";
            this.txtBillNumber.Size = new System.Drawing.Size(100, 26);
            this.txtBillNumber.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 45;
            this.label3.Text = "Bill Number";
            // 
            // txtBillNarration
            // 
            this.txtBillNarration.Location = new System.Drawing.Point(679, 123);
            this.txtBillNarration.Name = "txtBillNarration";
            this.txtBillNarration.Size = new System.Drawing.Size(455, 26);
            this.txtBillNarration.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(571, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Bill Narration";
            // 
            // comboBillStatus
            // 
            this.comboBillStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBillStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBillStatus.FormattingEnabled = true;
            this.comboBillStatus.Location = new System.Drawing.Point(127, 121);
            this.comboBillStatus.Name = "comboBillStatus";
            this.comboBillStatus.Size = new System.Drawing.Size(368, 28);
            this.comboBillStatus.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 41;
            this.label9.Text = "Bill Status";
            // 
            // txtBillDate
            // 
            this.txtBillDate.Enabled = false;
            this.txtBillDate.Location = new System.Drawing.Point(127, 38);
            this.txtBillDate.Name = "txtBillDate";
            this.txtBillDate.Size = new System.Drawing.Size(100, 26);
            this.txtBillDate.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Bill Date";
            // 
            // comboBeneficiery
            // 
            this.comboBeneficiery.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBeneficiery.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBeneficiery.FormattingEnabled = true;
            this.comboBeneficiery.Location = new System.Drawing.Point(679, 80);
            this.comboBeneficiery.Name = "comboBeneficiery";
            this.comboBeneficiery.Size = new System.Drawing.Size(455, 28);
            this.comboBeneficiery.TabIndex = 5;
            // 
            // comboDept
            // 
            this.comboDept.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboDept.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboDept.FormattingEnabled = true;
            this.comboDept.Location = new System.Drawing.Point(679, 33);
            this.comboDept.Name = "comboDept";
            this.comboDept.Size = new System.Drawing.Size(455, 28);
            this.comboDept.TabIndex = 1;
            this.comboDept.SelectedIndexChanged += new System.EventHandler(this.comboDept_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(571, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 20);
            this.label14.TabIndex = 32;
            this.label14.Text = "Department";
            // 
            // comboBillType
            // 
            this.comboBillType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBillType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBillType.FormattingEnabled = true;
            this.comboBillType.Location = new System.Drawing.Point(127, 80);
            this.comboBillType.Name = "comboBillType";
            this.comboBillType.Size = new System.Drawing.Size(368, 28);
            this.comboBillType.TabIndex = 4;
            this.comboBillType.SelectedIndexChanged += new System.EventHandler(this.comboBillType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Bill Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(571, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Beneficiery";
            // 
            // txtPKBillID
            // 
            this.txtPKBillID.Location = new System.Drawing.Point(171, 3);
            this.txtPKBillID.Name = "txtPKBillID";
            this.txtPKBillID.Size = new System.Drawing.Size(100, 26);
            this.txtPKBillID.TabIndex = 1;
            // 
            // comboACID
            // 
            this.comboACID.AllowUserToAddRows = false;
            this.comboACID.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.comboACID.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.comboACID.AutoGenerateColumns = false;
            this.comboACID.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.comboACID.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.comboACID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.comboACID.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.BeneficiaryID,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.comboACID.DataSource = this.billMstViewBindingSource;
            this.comboACID.Location = new System.Drawing.Point(1238, 35);
            this.comboACID.Name = "comboACID";
            this.comboACID.RowTemplate.Height = 28;
            this.comboACID.Size = new System.Drawing.Size(672, 457);
            this.comboACID.TabIndex = 37;
            this.comboACID.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVbillMstView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PKBillID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PKBillID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 102;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "BillNumber";
            this.dataGridViewTextBoxColumn2.HeaderText = "Bill No";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 89;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "BillNarration";
            this.dataGridViewTextBoxColumn3.HeaderText = "BillNarration";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 130;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DEPNAME";
            this.dataGridViewTextBoxColumn4.HeaderText = "Department";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 130;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "BeneficieryName";
            this.dataGridViewTextBoxColumn5.HeaderText = "Beneficiery";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 123;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "BillStatus";
            this.dataGridViewTextBoxColumn6.HeaderText = "BillStatus";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 112;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "BillType";
            this.dataGridViewTextBoxColumn7.HeaderText = "BillType";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 99;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "FKDepID";
            this.dataGridViewTextBoxColumn8.HeaderText = "FKDepID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            this.dataGridViewTextBoxColumn8.Width = 112;
            // 
            // BeneficiaryID
            // 
            this.BeneficiaryID.DataPropertyName = "BeneficiaryID";
            this.BeneficiaryID.HeaderText = "BeneficiaryID";
            this.BeneficiaryID.Name = "BeneficiaryID";
            this.BeneficiaryID.Visible = false;
            this.BeneficiaryID.Width = 140;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "FKBillStatus";
            this.dataGridViewTextBoxColumn10.HeaderText = "FKBillStatus";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Visible = false;
            this.dataGridViewTextBoxColumn10.Width = 132;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "FKBillType";
            this.dataGridViewTextBoxColumn11.HeaderText = "FKBillType";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Visible = false;
            this.dataGridViewTextBoxColumn11.Width = 119;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "BillCreatedOn";
            this.dataGridViewTextBoxColumn12.HeaderText = "BillCreatedOn";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Visible = false;
            this.dataGridViewTextBoxColumn12.Width = 143;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "BillUpdatedOn";
            this.dataGridViewTextBoxColumn13.HeaderText = "BillUpdatedOn";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Visible = false;
            this.dataGridViewTextBoxColumn13.Width = 148;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "BillUpdatedBy";
            this.dataGridViewTextBoxColumn14.HeaderText = "BillUpdatedBy";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Visible = false;
            this.dataGridViewTextBoxColumn14.Width = 145;
            // 
            // billMstViewBindingSource
            // 
            this.billMstViewBindingSource.DataMember = "BillMstView";
            this.billMstViewBindingSource.DataSource = this.financeDataSet;
            // 
            // financeDataSet
            // 
            this.financeDataSet.DataSetName = "FinanceDataSet";
            this.financeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // billMstViewTableAdapter
            // 
            this.billMstViewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AcTypesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BankMasterTableAdapter = null;
            this.tableAdapterManager.BillDtlTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.SL1TableAdapter = null;
            this.tableAdapterManager.SL2TableAdapter = null;
            this.tableAdapterManager.SL3TableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MANUUFinance.FinanceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // billDtlBindingSource
            // 
            this.billDtlBindingSource.DataMember = "BillDtl";
            this.billDtlBindingSource.DataSource = this.financeDataSet1;
            // 
            // financeDataSet1
            // 
            this.financeDataSet1.DataSetName = "FinanceDataSet";
            this.financeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // billDtlTableAdapter
            // 
            this.billDtlTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtAccountBalance);
            this.groupBox3.Controls.Add(this.txtSL2Name);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtSL3Name);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtSL1Name);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.comboAccountName);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtBillAmount);
            this.groupBox3.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox3.Location = new System.Drawing.Point(44, 222);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1165, 176);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bill Details";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(545, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 20);
            this.label10.TabIndex = 48;
            this.label10.Text = "Account Balance";
            // 
            // txtAccountBalance
            // 
            this.txtAccountBalance.Enabled = false;
            this.txtAccountBalance.Location = new System.Drawing.Point(681, 113);
            this.txtAccountBalance.Name = "txtAccountBalance";
            this.txtAccountBalance.Size = new System.Drawing.Size(100, 26);
            this.txtAccountBalance.TabIndex = 47;
            // 
            // txtSL2Name
            // 
            this.txtSL2Name.Enabled = false;
            this.txtSL2Name.Location = new System.Drawing.Point(127, 80);
            this.txtSL2Name.Name = "txtSL2Name";
            this.txtSL2Name.Size = new System.Drawing.Size(380, 26);
            this.txtSL2Name.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 20);
            this.label7.TabIndex = 45;
            this.label7.Text = "SL2";
            // 
            // txtSL3Name
            // 
            this.txtSL3Name.Enabled = false;
            this.txtSL3Name.Location = new System.Drawing.Point(683, 74);
            this.txtSL3Name.Name = "txtSL3Name";
            this.txtSL3Name.Size = new System.Drawing.Size(455, 26);
            this.txtSL3Name.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(545, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 20);
            this.label6.TabIndex = 43;
            this.label6.Text = "SL3";
            // 
            // txtSL1Name
            // 
            this.txtSL1Name.Enabled = false;
            this.txtSL1Name.Location = new System.Drawing.Point(683, 37);
            this.txtSL1Name.Name = "txtSL1Name";
            this.txtSL1Name.Size = new System.Drawing.Size(455, 26);
            this.txtSL1Name.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 41;
            this.label8.Text = "Bill Amount";
            // 
            // comboAccountName
            // 
            this.comboAccountName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboAccountName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboAccountName.FormattingEnabled = true;
            this.comboAccountName.Location = new System.Drawing.Point(127, 39);
            this.comboAccountName.Name = "comboAccountName";
            this.comboAccountName.Size = new System.Drawing.Size(380, 28);
            this.comboAccountName.TabIndex = 1;
            this.comboAccountName.SelectedIndexChanged += new System.EventHandler(this.comboAccountName_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 20);
            this.label11.TabIndex = 32;
            this.label11.Text = "Account";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(545, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 20);
            this.label12.TabIndex = 25;
            this.label12.Text = "SL1";
            // 
            // txtBillAmount
            // 
            this.txtBillAmount.Location = new System.Drawing.Point(127, 117);
            this.txtBillAmount.Name = "txtBillAmount";
            this.txtBillAmount.Size = new System.Drawing.Size(100, 26);
            this.txtBillAmount.TabIndex = 1;
            // 
            // frmBillDespatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1922, 844);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.comboACID);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPKBillID);
            this.Name = "frmBillDespatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill Despatch";
            this.Load += new System.EventHandler(this.frmBillDespatch_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboACID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billMstViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billDtlBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBillNarration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBillStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBillDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBeneficiery;
        private System.Windows.Forms.ComboBox comboDept;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBillType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPKBillID;
        private System.Windows.Forms.TextBox txtBillNumber;
        private System.Windows.Forms.Label label3;
        private FinanceDataSet financeDataSet;
        private System.Windows.Forms.BindingSource billMstViewBindingSource;
        private FinanceDataSetTableAdapters.BillMstViewTableAdapter billMstViewTableAdapter;
        private FinanceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView comboACID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn BeneficiaryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private FinanceDataSet financeDataSet1;
        private System.Windows.Forms.BindingSource billDtlBindingSource;
        private FinanceDataSetTableAdapters.BillDtlTableAdapter billDtlTableAdapter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSL2Name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSL3Name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSL1Name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboAccountName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBillAmount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAccountBalance;
    }
}