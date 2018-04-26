namespace MANUUFinance
{
    partial class BudgetPurpose
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
            this.DGVAccounts = new System.Windows.Forms.DataGridView();
            this.FYName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeptName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL3Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BECY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RBECY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BENY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL1Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL2Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL3Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL1ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PKSL2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FKSL3ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PKFYID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PKBUDGETID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PKACID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApprovalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAppAmount = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtBECY = new System.Windows.Forms.TextBox();
            this.comboAccount = new System.Windows.Forms.ComboBox();
            this.comboDept = new System.Windows.Forms.ComboBox();
            this.comboFY = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBENY = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboSL3 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboSL2 = new System.Windows.Forms.ComboBox();
            this.comboSL1 = new System.Windows.Forms.ComboBox();
            this.txtRBECY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPKBudgetID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAccounts)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVAccounts
            // 
            this.DGVAccounts.AllowUserToAddRows = false;
            this.DGVAccounts.AllowUserToDeleteRows = false;
            this.DGVAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FYName,
            this.DeptName,
            this.SL3Code,
            this.BECY,
            this.RBECY,
            this.BENY,
            this.AccountName,
            this.SL1Name,
            this.SL2Name,
            this.SL3Name,
            this.SL1ID,
            this.PKSL2,
            this.FKSL3ID,
            this.Dept,
            this.PKFYID,
            this.PKBUDGETID,
            this.PKACID,
            this.ApprovalAmount});
            this.DGVAccounts.Location = new System.Drawing.Point(12, 264);
            this.DGVAccounts.Name = "DGVAccounts";
            this.DGVAccounts.ReadOnly = true;
            this.DGVAccounts.Size = new System.Drawing.Size(979, 150);
            this.DGVAccounts.TabIndex = 45;
            this.DGVAccounts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVAccounts_CellContentClick);
            // 
            // FYName
            // 
            this.FYName.DataPropertyName = "FYName";
            this.FYName.HeaderText = "FYName";
            this.FYName.Name = "FYName";
            this.FYName.ReadOnly = true;
            // 
            // DeptName
            // 
            this.DeptName.DataPropertyName = "DeptName";
            this.DeptName.HeaderText = "DeptName";
            this.DeptName.Name = "DeptName";
            this.DeptName.ReadOnly = true;
            // 
            // SL3Code
            // 
            this.SL3Code.DataPropertyName = "SL3Code";
            this.SL3Code.HeaderText = "SL3Code";
            this.SL3Code.Name = "SL3Code";
            this.SL3Code.ReadOnly = true;
            // 
            // BECY
            // 
            this.BECY.DataPropertyName = "BECY";
            this.BECY.HeaderText = "BECY";
            this.BECY.Name = "BECY";
            this.BECY.ReadOnly = true;
            // 
            // RBECY
            // 
            this.RBECY.DataPropertyName = "RBECY";
            this.RBECY.HeaderText = "RBECY";
            this.RBECY.Name = "RBECY";
            this.RBECY.ReadOnly = true;
            // 
            // BENY
            // 
            this.BENY.DataPropertyName = "BENY";
            this.BENY.HeaderText = "BENY";
            this.BENY.Name = "BENY";
            this.BENY.ReadOnly = true;
            // 
            // AccountName
            // 
            this.AccountName.DataPropertyName = "AccountName";
            this.AccountName.HeaderText = "AccountName";
            this.AccountName.Name = "AccountName";
            this.AccountName.ReadOnly = true;
            // 
            // SL1Name
            // 
            this.SL1Name.DataPropertyName = "SL1Name";
            this.SL1Name.HeaderText = "SL1Name";
            this.SL1Name.Name = "SL1Name";
            this.SL1Name.ReadOnly = true;
            // 
            // SL2Name
            // 
            this.SL2Name.DataPropertyName = "SL2Name";
            this.SL2Name.HeaderText = "SL2Name";
            this.SL2Name.Name = "SL2Name";
            this.SL2Name.ReadOnly = true;
            // 
            // SL3Name
            // 
            this.SL3Name.DataPropertyName = "SL3Name";
            this.SL3Name.HeaderText = "SL3Name";
            this.SL3Name.Name = "SL3Name";
            this.SL3Name.ReadOnly = true;
            // 
            // SL1ID
            // 
            this.SL1ID.DataPropertyName = "SL1ID";
            this.SL1ID.HeaderText = "SL1ID";
            this.SL1ID.Name = "SL1ID";
            this.SL1ID.ReadOnly = true;
            this.SL1ID.Visible = false;
            // 
            // PKSL2
            // 
            this.PKSL2.DataPropertyName = "PKSL2";
            this.PKSL2.HeaderText = "PKSL2";
            this.PKSL2.Name = "PKSL2";
            this.PKSL2.ReadOnly = true;
            this.PKSL2.Visible = false;
            // 
            // FKSL3ID
            // 
            this.FKSL3ID.DataPropertyName = "FKSL3ID";
            this.FKSL3ID.HeaderText = "FKSL3ID";
            this.FKSL3ID.Name = "FKSL3ID";
            this.FKSL3ID.ReadOnly = true;
            this.FKSL3ID.Visible = false;
            // 
            // Dept
            // 
            this.Dept.DataPropertyName = "DeptId";
            this.Dept.HeaderText = "DeptId";
            this.Dept.Name = "Dept";
            this.Dept.ReadOnly = true;
            this.Dept.Visible = false;
            // 
            // PKFYID
            // 
            this.PKFYID.DataPropertyName = "PKFYID";
            this.PKFYID.HeaderText = "PKFYID";
            this.PKFYID.Name = "PKFYID";
            this.PKFYID.ReadOnly = true;
            this.PKFYID.Visible = false;
            // 
            // PKBUDGETID
            // 
            this.PKBUDGETID.DataPropertyName = "v";
            this.PKBUDGETID.HeaderText = "PKBUDGETID";
            this.PKBUDGETID.Name = "PKBUDGETID";
            this.PKBUDGETID.ReadOnly = true;
            this.PKBUDGETID.Visible = false;
            // 
            // PKACID
            // 
            this.PKACID.DataPropertyName = "PKACID";
            this.PKACID.HeaderText = "PKACID";
            this.PKACID.Name = "PKACID";
            this.PKACID.ReadOnly = true;
            this.PKACID.Visible = false;
            // 
            // ApprovalAmount
            // 
            this.ApprovalAmount.DataPropertyName = "ApprAmount";
            this.ApprovalAmount.HeaderText = "ApprovalAmount";
            this.ApprovalAmount.Name = "ApprovalAmount";
            this.ApprovalAmount.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPrint);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Location = new System.Drawing.Point(15, 205);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(566, 45);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(286, 12);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(89, 25);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Print Record";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(472, 12);
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
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAppAmount);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtBECY);
            this.groupBox1.Controls.Add(this.comboAccount);
            this.groupBox1.Controls.Add(this.comboDept);
            this.groupBox1.Controls.Add(this.comboFY);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBENY);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboSL3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboSL2);
            this.groupBox1.Controls.Add(this.comboSL1);
            this.groupBox1.Controls.Add(this.txtRBECY);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPKBudgetID);
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(15, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(979, 167);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Budget";
            // 
            // txtAppAmount
            // 
            this.txtAppAmount.Location = new System.Drawing.Point(632, 135);
            this.txtAppAmount.Margin = new System.Windows.Forms.Padding(2);
            this.txtAppAmount.Name = "txtAppAmount";
            this.txtAppAmount.Size = new System.Drawing.Size(68, 20);
            this.txtAppAmount.TabIndex = 39;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(523, 138);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 13);
            this.label15.TabIndex = 38;
            this.label15.Text = "Approval Amount";
            // 
            // txtBECY
            // 
            this.txtBECY.Location = new System.Drawing.Point(186, 105);
            this.txtBECY.Margin = new System.Windows.Forms.Padding(2);
            this.txtBECY.Name = "txtBECY";
            this.txtBECY.Size = new System.Drawing.Size(305, 20);
            this.txtBECY.TabIndex = 6;
            // 
            // comboAccount
            // 
            this.comboAccount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboAccount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboAccount.FormattingEnabled = true;
            this.comboAccount.Location = new System.Drawing.Point(632, 75);
            this.comboAccount.Margin = new System.Windows.Forms.Padding(2);
            this.comboAccount.Name = "comboAccount";
            this.comboAccount.Size = new System.Drawing.Size(305, 21);
            this.comboAccount.TabIndex = 5;
            // 
            // comboDept
            // 
            this.comboDept.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboDept.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboDept.FormattingEnabled = true;
            this.comboDept.Location = new System.Drawing.Point(632, 21);
            this.comboDept.Margin = new System.Windows.Forms.Padding(2);
            this.comboDept.Name = "comboDept";
            this.comboDept.Size = new System.Drawing.Size(305, 21);
            this.comboDept.TabIndex = 1;
            // 
            // comboFY
            // 
            this.comboFY.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboFY.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboFY.FormattingEnabled = true;
            this.comboFY.Location = new System.Drawing.Point(186, 21);
            this.comboFY.Margin = new System.Windows.Forms.Padding(2);
            this.comboFY.Name = "comboFY";
            this.comboFY.Size = new System.Drawing.Size(305, 21);
            this.comboFY.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 23);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Financial year";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(523, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Department";
            // 
            // txtBENY
            // 
            this.txtBENY.Location = new System.Drawing.Point(186, 131);
            this.txtBENY.Margin = new System.Windows.Forms.Padding(2);
            this.txtBENY.Name = "txtBENY";
            this.txtBENY.Size = new System.Drawing.Size(68, 20);
            this.txtBENY.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 133);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Budget Estimate (Next Year)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Budget Estimate (Current Year)";
            // 
            // comboSL3
            // 
            this.comboSL3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboSL3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboSL3.FormattingEnabled = true;
            this.comboSL3.Location = new System.Drawing.Point(186, 75);
            this.comboSL3.Margin = new System.Windows.Forms.Padding(2);
            this.comboSL3.Name = "comboSL3";
            this.comboSL3.Size = new System.Drawing.Size(305, 21);
            this.comboSL3.TabIndex = 4;
            this.comboSL3.SelectedIndexChanged += new System.EventHandler(this.comboSL3_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "SL3 Name";
            // 
            // comboSL2
            // 
            this.comboSL2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboSL2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboSL2.FormattingEnabled = true;
            this.comboSL2.Location = new System.Drawing.Point(632, 48);
            this.comboSL2.Margin = new System.Windows.Forms.Padding(2);
            this.comboSL2.Name = "comboSL2";
            this.comboSL2.Size = new System.Drawing.Size(305, 21);
            this.comboSL2.TabIndex = 3;
            this.comboSL2.SelectedIndexChanged += new System.EventHandler(this.comboSL2_SelectedIndexChanged);
            // 
            // comboSL1
            // 
            this.comboSL1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboSL1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboSL1.FormattingEnabled = true;
            this.comboSL1.Location = new System.Drawing.Point(186, 48);
            this.comboSL1.Margin = new System.Windows.Forms.Padding(2);
            this.comboSL1.Name = "comboSL1";
            this.comboSL1.Size = new System.Drawing.Size(305, 21);
            this.comboSL1.TabIndex = 2;
            this.comboSL1.SelectedIndexChanged += new System.EventHandler(this.comboSL1_SelectedIndexChanged);
            // 
            // txtRBECY
            // 
            this.txtRBECY.Location = new System.Drawing.Point(632, 103);
            this.txtRBECY.Margin = new System.Windows.Forms.Padding(2);
            this.txtRBECY.Name = "txtRBECY";
            this.txtRBECY.Size = new System.Drawing.Size(68, 20);
            this.txtRBECY.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(523, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "R.B.E. (Purpose)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 50);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "SL1 Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(523, 49);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "SL2 Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(523, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Account Name";
            // 
            // txtPKBudgetID
            // 
            this.txtPKBudgetID.Location = new System.Drawing.Point(855, 120);
            this.txtPKBudgetID.Margin = new System.Windows.Forms.Padding(2);
            this.txtPKBudgetID.Name = "txtPKBudgetID";
            this.txtPKBudgetID.Size = new System.Drawing.Size(68, 20);
            this.txtPKBudgetID.TabIndex = 1;
            // 
            // BudgetPurpose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 427);
            this.Controls.Add(this.DGVAccounts);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "BudgetPurpose";
            this.Text = "BudgetPurpose";
            this.Load += new System.EventHandler(this.BudgetPurpose_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVAccounts)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVAccounts;
        private System.Windows.Forms.DataGridViewTextBoxColumn FYName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeptName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL3Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn BECY;
        private System.Windows.Forms.DataGridViewTextBoxColumn RBECY;
        private System.Windows.Forms.DataGridViewTextBoxColumn BENY;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL1Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL2Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL3Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL1ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PKSL2;
        private System.Windows.Forms.DataGridViewTextBoxColumn FKSL3ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dept;
        private System.Windows.Forms.DataGridViewTextBoxColumn PKFYID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PKBUDGETID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PKACID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApprovalAmount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAppAmount;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtBECY;
        private System.Windows.Forms.ComboBox comboAccount;
        private System.Windows.Forms.ComboBox comboDept;
        private System.Windows.Forms.ComboBox comboFY;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBENY;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboSL3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboSL2;
        private System.Windows.Forms.ComboBox comboSL1;
        private System.Windows.Forms.TextBox txtRBECY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPKBudgetID;
    }
}