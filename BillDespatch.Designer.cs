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
            this.btnPrint = new System.Windows.Forms.Button();
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
            this.comboBillTypeSub = new System.Windows.Forms.ComboBox();
            this.comboBillType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPKBillID = new System.Windows.Forms.TextBox();
            this.comboACID = new System.Windows.Forms.DataGridView();
            this.BeneficiaryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billMstViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.financeDataSet18 = new MANUUFinance.FinanceDataSet18();
            this.billMstViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.financeDataSet = new MANUUFinance.FinanceDataSet();
            this.billMstViewTableAdapter = new MANUUFinance.FinanceDataSetTableAdapters.BillMstViewTableAdapter();
            this.tableAdapterManager = new MANUUFinance.FinanceDataSetTableAdapters.TableAdapterManager();
            this.billDtlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.financeDataSet1 = new MANUUFinance.FinanceDataSet();
            this.billDtlTableAdapter = new MANUUFinance.FinanceDataSetTableAdapters.BillDtlTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBudgetACTYPE = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
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
            this.billMstViewTableAdapter1 = new MANUUFinance.FinanceDataSet18TableAdapters.BillMstViewTableAdapter();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBillNarrationSearch = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtBillNumberSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.billUpdatedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billUpdatedOnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billCreatedOnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKBillTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKBillStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beneficiaryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKDepIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beneficieryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billNarrationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pKBillIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label18 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboACID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billMstViewBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billMstViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billDtlBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPrint);
            this.groupBox2.Controls.Add(this.btnQuery);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Location = new System.Drawing.Point(47, 269);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(661, 45);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(287, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(89, 25);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "Voucher Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(473, 12);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(89, 25);
            this.btnQuery.TabIndex = 4;
            this.btnQuery.Text = "Query";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(565, 12);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 25);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close Form";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(380, 12);
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
            this.groupBox1.Controls.Add(this.comboBillTypeSub);
            this.groupBox1.Controls.Add(this.comboBillType);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(29, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(777, 111);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bill Master";
            // 
            // txtBillNumber
            // 
            this.txtBillNumber.Enabled = false;
            this.txtBillNumber.Location = new System.Drawing.Point(261, 25);
            this.txtBillNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtBillNumber.Name = "txtBillNumber";
            this.txtBillNumber.Size = new System.Drawing.Size(68, 20);
            this.txtBillNumber.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Bill Number";
            // 
            // txtBillNarration
            // 
            this.txtBillNarration.Location = new System.Drawing.Point(453, 80);
            this.txtBillNarration.Margin = new System.Windows.Forms.Padding(2);
            this.txtBillNarration.Name = "txtBillNarration";
            this.txtBillNarration.Size = new System.Drawing.Size(305, 20);
            this.txtBillNarration.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Bill Narration";
            // 
            // comboBillStatus
            // 
            this.comboBillStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBillStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBillStatus.FormattingEnabled = true;
            this.comboBillStatus.Location = new System.Drawing.Point(85, 79);
            this.comboBillStatus.Margin = new System.Windows.Forms.Padding(2);
            this.comboBillStatus.Name = "comboBillStatus";
            this.comboBillStatus.Size = new System.Drawing.Size(247, 21);
            this.comboBillStatus.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 79);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Bill Status";
            // 
            // txtBillDate
            // 
            this.txtBillDate.Enabled = false;
            this.txtBillDate.Location = new System.Drawing.Point(85, 25);
            this.txtBillDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtBillDate.Name = "txtBillDate";
            this.txtBillDate.Size = new System.Drawing.Size(68, 20);
            this.txtBillDate.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Bill Date";
            // 
            // comboBeneficiery
            // 
            this.comboBeneficiery.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBeneficiery.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBeneficiery.FormattingEnabled = true;
            this.comboBeneficiery.Location = new System.Drawing.Point(453, 52);
            this.comboBeneficiery.Margin = new System.Windows.Forms.Padding(2);
            this.comboBeneficiery.Name = "comboBeneficiery";
            this.comboBeneficiery.Size = new System.Drawing.Size(305, 21);
            this.comboBeneficiery.TabIndex = 5;
            // 
            // comboDept
            // 
            this.comboDept.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboDept.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboDept.FormattingEnabled = true;
            this.comboDept.Location = new System.Drawing.Point(453, 21);
            this.comboDept.Margin = new System.Windows.Forms.Padding(2);
            this.comboDept.Name = "comboDept";
            this.comboDept.Size = new System.Drawing.Size(305, 21);
            this.comboDept.TabIndex = 1;
            this.comboDept.SelectedIndexChanged += new System.EventHandler(this.comboDept_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(381, 23);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Department";
            // 
            // comboBillTypeSub
            // 
            this.comboBillTypeSub.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBillTypeSub.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBillTypeSub.FormattingEnabled = true;
            this.comboBillTypeSub.Location = new System.Drawing.Point(228, 51);
            this.comboBillTypeSub.Margin = new System.Windows.Forms.Padding(2);
            this.comboBillTypeSub.Name = "comboBillTypeSub";
            this.comboBillTypeSub.Size = new System.Drawing.Size(104, 21);
            this.comboBillTypeSub.TabIndex = 4;
            this.comboBillTypeSub.SelectedIndexChanged += new System.EventHandler(this.comboBillType_SelectedIndexChanged_1);
            // 
            // comboBillType
            // 
            this.comboBillType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBillType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBillType.FormattingEnabled = true;
            this.comboBillType.Location = new System.Drawing.Point(85, 52);
            this.comboBillType.Margin = new System.Windows.Forms.Padding(2);
            this.comboBillType.Name = "comboBillType";
            this.comboBillType.Size = new System.Drawing.Size(104, 21);
            this.comboBillType.TabIndex = 4;
            this.comboBillType.SelectedIndexChanged += new System.EventHandler(this.comboBillType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Bill Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Beneficiery";
            // 
            // txtPKBillID
            // 
            this.txtPKBillID.Location = new System.Drawing.Point(114, 2);
            this.txtPKBillID.Margin = new System.Windows.Forms.Padding(2);
            this.txtPKBillID.Name = "txtPKBillID";
            this.txtPKBillID.Size = new System.Drawing.Size(68, 20);
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
            this.BeneficiaryID,
            this.pKBillIDDataGridViewTextBoxColumn,
            this.billNumberDataGridViewTextBoxColumn,
            this.billNarrationDataGridViewTextBoxColumn,
            this.deptNameDataGridViewTextBoxColumn,
            this.billTypeDataGridViewTextBoxColumn,
            this.beneficieryNameDataGridViewTextBoxColumn,
            this.billStatusDataGridViewTextBoxColumn,
            this.fKDepIDDataGridViewTextBoxColumn,
            this.beneficiaryIDDataGridViewTextBoxColumn,
            this.fKBillStatusDataGridViewTextBoxColumn,
            this.fKBillTypeDataGridViewTextBoxColumn,
            this.billCreatedOnDataGridViewTextBoxColumn,
            this.billUpdatedOnDataGridViewTextBoxColumn,
            this.billUpdatedByDataGridViewTextBoxColumn});
            this.comboACID.DataSource = this.billMstViewBindingSource1;
            this.comboACID.Location = new System.Drawing.Point(29, 337);
            this.comboACID.Margin = new System.Windows.Forms.Padding(2);
            this.comboACID.Name = "comboACID";
            this.comboACID.ReadOnly = true;
            this.comboACID.RowTemplate.Height = 28;
            this.comboACID.Size = new System.Drawing.Size(522, 210);
            this.comboACID.TabIndex = 37;
            this.comboACID.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVbillMstView_CellClick);
            this.comboACID.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.comboACID_CellContentClick);
            // 
            // BeneficiaryID
            // 
            this.BeneficiaryID.DataPropertyName = "BeneficiaryID";
            this.BeneficiaryID.HeaderText = "BeneficiaryID";
            this.BeneficiaryID.Name = "BeneficiaryID";
            this.BeneficiaryID.ReadOnly = true;
            this.BeneficiaryID.Visible = false;
            this.BeneficiaryID.Width = 95;
            // 
            // billMstViewBindingSource1
            // 
            this.billMstViewBindingSource1.DataMember = "BillMstView";
            this.billMstViewBindingSource1.DataSource = this.financeDataSet18;
            // 
            // financeDataSet18
            // 
            this.financeDataSet18.DataSetName = "FinanceDataSet18";
            this.financeDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.DEPTTableAdapter = null;
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
            this.groupBox3.Controls.Add(this.comboBudgetACTYPE);
            this.groupBox3.Controls.Add(this.label17);
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
            this.groupBox3.Location = new System.Drawing.Point(29, 138);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(777, 131);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bill Details";
            // 
            // comboBudgetACTYPE
            // 
            this.comboBudgetACTYPE.FormattingEnabled = true;
            this.comboBudgetACTYPE.Location = new System.Drawing.Point(111, 21);
            this.comboBudgetACTYPE.Name = "comboBudgetACTYPE";
            this.comboBudgetACTYPE.Size = new System.Drawing.Size(229, 21);
            this.comboBudgetACTYPE.TabIndex = 49;
            this.comboBudgetACTYPE.SelectedIndexChanged += new System.EventHandler(this.comboBudgetACTYPE_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 24);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(90, 13);
            this.label17.TabIndex = 49;
            this.label17.Text = "Budget A/C Type";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(181, 105);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 48;
            this.label10.Text = "Account Balance";
            // 
            // txtAccountBalance
            // 
            this.txtAccountBalance.Enabled = false;
            this.txtAccountBalance.Location = new System.Drawing.Point(272, 99);
            this.txtAccountBalance.Margin = new System.Windows.Forms.Padding(2);
            this.txtAccountBalance.Name = "txtAccountBalance";
            this.txtAccountBalance.Size = new System.Drawing.Size(68, 20);
            this.txtAccountBalance.TabIndex = 47;
            // 
            // txtSL2Name
            // 
            this.txtSL2Name.Enabled = false;
            this.txtSL2Name.Location = new System.Drawing.Point(85, 75);
            this.txtSL2Name.Margin = new System.Windows.Forms.Padding(2);
            this.txtSL2Name.Name = "txtSL2Name";
            this.txtSL2Name.Size = new System.Drawing.Size(255, 20);
            this.txtSL2Name.TabIndex = 46;
            this.txtSL2Name.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 75);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "SL2";
            this.label7.Visible = false;
            // 
            // txtSL3Name
            // 
            this.txtSL3Name.Enabled = false;
            this.txtSL3Name.Location = new System.Drawing.Point(455, 71);
            this.txtSL3Name.Margin = new System.Windows.Forms.Padding(2);
            this.txtSL3Name.Name = "txtSL3Name";
            this.txtSL3Name.Size = new System.Drawing.Size(305, 20);
            this.txtSL3Name.TabIndex = 44;
            this.txtSL3Name.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(363, 71);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "SL3";
            this.label6.Visible = false;
            // 
            // txtSL1Name
            // 
            this.txtSL1Name.Enabled = false;
            this.txtSL1Name.Location = new System.Drawing.Point(455, 47);
            this.txtSL1Name.Margin = new System.Windows.Forms.Padding(2);
            this.txtSL1Name.Name = "txtSL1Name";
            this.txtSL1Name.Size = new System.Drawing.Size(305, 20);
            this.txtSL1Name.TabIndex = 42;
            this.txtSL1Name.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 102);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Bill Amount";
            // 
            // comboAccountName
            // 
            this.comboAccountName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboAccountName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboAccountName.FormattingEnabled = true;
            this.comboAccountName.Location = new System.Drawing.Point(85, 48);
            this.comboAccountName.Margin = new System.Windows.Forms.Padding(2);
            this.comboAccountName.Name = "comboAccountName";
            this.comboAccountName.Size = new System.Drawing.Size(255, 21);
            this.comboAccountName.TabIndex = 1;
            this.comboAccountName.SelectedIndexChanged += new System.EventHandler(this.comboAccountName_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 54);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Account";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(363, 49);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "SL1";
            this.label12.Visible = false;
            // 
            // txtBillAmount
            // 
            this.txtBillAmount.Location = new System.Drawing.Point(85, 99);
            this.txtBillAmount.Margin = new System.Windows.Forms.Padding(2);
            this.txtBillAmount.Name = "txtBillAmount";
            this.txtBillAmount.Size = new System.Drawing.Size(68, 20);
            this.txtBillAmount.TabIndex = 1;
            // 
            // billMstViewTableAdapter1
            // 
            this.billMstViewTableAdapter1.ClearBeforeFill = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dateTimePicker1);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txtBillNarrationSearch);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.txtBillNumberSearch);
            this.groupBox4.Controls.Add(this.btnSearch);
            this.groupBox4.Controls.Add(this.btnClearSearch);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox4.Location = new System.Drawing.Point(578, 337);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(228, 237);
            this.groupBox4.TabIndex = 48;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Grid Filter";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 142);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Bill Narration";
            // 
            // txtBillNarrationSearch
            // 
            this.txtBillNarrationSearch.Location = new System.Drawing.Point(12, 159);
            this.txtBillNarrationSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtBillNarrationSearch.Name = "txtBillNarrationSearch";
            this.txtBillNarrationSearch.Size = new System.Drawing.Size(203, 20);
            this.txtBillNarrationSearch.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 94);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "Bill Number";
            // 
            // txtBillNumberSearch
            // 
            this.txtBillNumberSearch.Location = new System.Drawing.Point(12, 111);
            this.txtBillNumberSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtBillNumberSearch.Name = "txtBillNumberSearch";
            this.txtBillNumberSearch.Size = new System.Drawing.Size(203, 20);
            this.txtBillNumberSearch.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(126, 195);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(89, 25);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.Location = new System.Drawing.Point(33, 195);
            this.btnClearSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(89, 25);
            this.btnClearSearch.TabIndex = 5;
            this.btnClearSearch.Text = "Clear Controls";
            this.btnClearSearch.UseVisualStyleBackColor = true;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(-82, 88);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "Account Name";
            // 
            // billUpdatedByDataGridViewTextBoxColumn
            // 
            this.billUpdatedByDataGridViewTextBoxColumn.DataPropertyName = "BillUpdatedBy";
            this.billUpdatedByDataGridViewTextBoxColumn.HeaderText = "BillUpdatedBy";
            this.billUpdatedByDataGridViewTextBoxColumn.Name = "billUpdatedByDataGridViewTextBoxColumn";
            this.billUpdatedByDataGridViewTextBoxColumn.ReadOnly = true;
            this.billUpdatedByDataGridViewTextBoxColumn.Visible = false;
            this.billUpdatedByDataGridViewTextBoxColumn.Width = 98;
            // 
            // billUpdatedOnDataGridViewTextBoxColumn
            // 
            this.billUpdatedOnDataGridViewTextBoxColumn.DataPropertyName = "BillUpdatedOn";
            this.billUpdatedOnDataGridViewTextBoxColumn.HeaderText = "BillUpdatedOn";
            this.billUpdatedOnDataGridViewTextBoxColumn.Name = "billUpdatedOnDataGridViewTextBoxColumn";
            this.billUpdatedOnDataGridViewTextBoxColumn.ReadOnly = true;
            this.billUpdatedOnDataGridViewTextBoxColumn.Visible = false;
            // 
            // billCreatedOnDataGridViewTextBoxColumn
            // 
            this.billCreatedOnDataGridViewTextBoxColumn.DataPropertyName = "BillCreatedOn";
            this.billCreatedOnDataGridViewTextBoxColumn.HeaderText = "BillCreatedOn";
            this.billCreatedOnDataGridViewTextBoxColumn.Name = "billCreatedOnDataGridViewTextBoxColumn";
            this.billCreatedOnDataGridViewTextBoxColumn.ReadOnly = true;
            this.billCreatedOnDataGridViewTextBoxColumn.Visible = false;
            this.billCreatedOnDataGridViewTextBoxColumn.Width = 96;
            // 
            // fKBillTypeDataGridViewTextBoxColumn
            // 
            this.fKBillTypeDataGridViewTextBoxColumn.DataPropertyName = "FKBillType";
            this.fKBillTypeDataGridViewTextBoxColumn.HeaderText = "FKBillType";
            this.fKBillTypeDataGridViewTextBoxColumn.Name = "fKBillTypeDataGridViewTextBoxColumn";
            this.fKBillTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.fKBillTypeDataGridViewTextBoxColumn.Visible = false;
            this.fKBillTypeDataGridViewTextBoxColumn.Width = 82;
            // 
            // fKBillStatusDataGridViewTextBoxColumn
            // 
            this.fKBillStatusDataGridViewTextBoxColumn.DataPropertyName = "FKBillStatus";
            this.fKBillStatusDataGridViewTextBoxColumn.HeaderText = "FKBillStatus";
            this.fKBillStatusDataGridViewTextBoxColumn.Name = "fKBillStatusDataGridViewTextBoxColumn";
            this.fKBillStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.fKBillStatusDataGridViewTextBoxColumn.Visible = false;
            this.fKBillStatusDataGridViewTextBoxColumn.Width = 88;
            // 
            // beneficiaryIDDataGridViewTextBoxColumn
            // 
            this.beneficiaryIDDataGridViewTextBoxColumn.DataPropertyName = "BeneficiaryID";
            this.beneficiaryIDDataGridViewTextBoxColumn.HeaderText = "BeneficiaryID";
            this.beneficiaryIDDataGridViewTextBoxColumn.Name = "beneficiaryIDDataGridViewTextBoxColumn";
            this.beneficiaryIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.beneficiaryIDDataGridViewTextBoxColumn.Visible = false;
            this.beneficiaryIDDataGridViewTextBoxColumn.Width = 95;
            // 
            // fKDepIDDataGridViewTextBoxColumn
            // 
            this.fKDepIDDataGridViewTextBoxColumn.DataPropertyName = "FKDepID";
            this.fKDepIDDataGridViewTextBoxColumn.HeaderText = "FKDepID";
            this.fKDepIDDataGridViewTextBoxColumn.Name = "fKDepIDDataGridViewTextBoxColumn";
            this.fKDepIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.fKDepIDDataGridViewTextBoxColumn.Visible = false;
            this.fKDepIDDataGridViewTextBoxColumn.Width = 76;
            // 
            // billStatusDataGridViewTextBoxColumn
            // 
            this.billStatusDataGridViewTextBoxColumn.DataPropertyName = "BillStatus";
            this.billStatusDataGridViewTextBoxColumn.HeaderText = "BillStatus";
            this.billStatusDataGridViewTextBoxColumn.Name = "billStatusDataGridViewTextBoxColumn";
            this.billStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.billStatusDataGridViewTextBoxColumn.Width = 75;
            // 
            // beneficieryNameDataGridViewTextBoxColumn
            // 
            this.beneficieryNameDataGridViewTextBoxColumn.DataPropertyName = "BeneficieryName";
            this.beneficieryNameDataGridViewTextBoxColumn.HeaderText = "BeneficieryName";
            this.beneficieryNameDataGridViewTextBoxColumn.Name = "beneficieryNameDataGridViewTextBoxColumn";
            this.beneficieryNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.beneficieryNameDataGridViewTextBoxColumn.Width = 112;
            // 
            // billTypeDataGridViewTextBoxColumn
            // 
            this.billTypeDataGridViewTextBoxColumn.DataPropertyName = "BillType";
            this.billTypeDataGridViewTextBoxColumn.HeaderText = "BillType";
            this.billTypeDataGridViewTextBoxColumn.Name = "billTypeDataGridViewTextBoxColumn";
            this.billTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.billTypeDataGridViewTextBoxColumn.Width = 69;
            // 
            // deptNameDataGridViewTextBoxColumn
            // 
            this.deptNameDataGridViewTextBoxColumn.DataPropertyName = "DeptName";
            this.deptNameDataGridViewTextBoxColumn.HeaderText = "DeptName";
            this.deptNameDataGridViewTextBoxColumn.Name = "deptNameDataGridViewTextBoxColumn";
            this.deptNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.deptNameDataGridViewTextBoxColumn.Width = 83;
            // 
            // billNarrationDataGridViewTextBoxColumn
            // 
            this.billNarrationDataGridViewTextBoxColumn.DataPropertyName = "BillNarration";
            this.billNarrationDataGridViewTextBoxColumn.HeaderText = "BillNarration";
            this.billNarrationDataGridViewTextBoxColumn.Name = "billNarrationDataGridViewTextBoxColumn";
            this.billNarrationDataGridViewTextBoxColumn.ReadOnly = true;
            this.billNarrationDataGridViewTextBoxColumn.Width = 88;
            // 
            // billNumberDataGridViewTextBoxColumn
            // 
            this.billNumberDataGridViewTextBoxColumn.DataPropertyName = "BillNumber";
            this.billNumberDataGridViewTextBoxColumn.HeaderText = "BillNumber";
            this.billNumberDataGridViewTextBoxColumn.Name = "billNumberDataGridViewTextBoxColumn";
            this.billNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.billNumberDataGridViewTextBoxColumn.Width = 82;
            // 
            // pKBillIDDataGridViewTextBoxColumn
            // 
            this.pKBillIDDataGridViewTextBoxColumn.DataPropertyName = "PKBillID";
            this.pKBillIDDataGridViewTextBoxColumn.HeaderText = "PKBillID";
            this.pKBillIDDataGridViewTextBoxColumn.Name = "pKBillIDDataGridViewTextBoxColumn";
            this.pKBillIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pKBillIDDataGridViewTextBoxColumn.Visible = false;
            this.pKBillIDDataGridViewTextBoxColumn.Width = 70;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(10, 15);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 13);
            this.label18.TabIndex = 29;
            this.label18.Text = "To Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(13, 31);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 30;
            this.dateTimePicker1.Value = new System.DateTime(2018, 5, 23, 14, 29, 0, 0);
            // 
            // frmBillDespatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(836, 597);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.comboACID);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPKBillID);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmBillDespatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill Despatch";
            this.Load += new System.EventHandler(this.frmBillDespatch_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboACID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billMstViewBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billMstViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billDtlBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private FinanceDataSet18 financeDataSet18;
        private System.Windows.Forms.BindingSource billMstViewBindingSource1;
        private FinanceDataSet18TableAdapters.BillMstViewTableAdapter billMstViewTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BeneficiaryID;
        private System.Windows.Forms.ComboBox comboBillTypeSub;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBillNarrationSearch;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtBillNumberSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClearSearch;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboBudgetACTYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn pKBillIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billNarrationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beneficieryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKDepIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beneficiaryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKBillStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKBillTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billCreatedOnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billUpdatedOnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billUpdatedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label18;
    }
}