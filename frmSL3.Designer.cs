namespace MANUUFinance
{
    partial class frmSL3
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
            this.txtPKSL3 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboSL2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSL3Code = new System.Windows.Forms.TextBox();
            this.comboSL1 = new System.Windows.Forms.ComboBox();
            this.txtSL3Order = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioBtnSL3InActive = new System.Windows.Forms.RadioButton();
            this.radioBtnSL3Active = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSL3Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSL3ID = new System.Windows.Forms.TextBox();
            this.DGVSL3SL2SL1 = new System.Windows.Forms.DataGridView();
            this.PKSL3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL3ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pKSL3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sL3IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pKSL2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sL1IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sL1NameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sL2NameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sL3NameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sL3OrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sL3ActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sL3CodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sL3SL2SL1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.financeDataSet13 = new MANUUFinance.FinanceDataSet13();
            this.sL3SL2SL1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.financeDataSet = new MANUUFinance.FinanceDataSet();
            this.sL3SL2SL1TableAdapter = new MANUUFinance.FinanceDataSetTableAdapters.SL3SL2SL1TableAdapter();
            this.sL3SL2SL1TableAdapter1 = new MANUUFinance.FinanceDataSet13TableAdapters.SL3SL2SL1TableAdapter();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSL3SL2SL1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sL3SL2SL1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sL3SL2SL1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPKSL3
            // 
            this.txtPKSL3.Location = new System.Drawing.Point(714, 230);
            this.txtPKSL3.Margin = new System.Windows.Forms.Padding(2);
            this.txtPKSL3.Name = "txtPKSL3";
            this.txtPKSL3.Size = new System.Drawing.Size(68, 20);
            this.txtPKSL3.TabIndex = 27;
            this.txtPKSL3.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPrint);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Location = new System.Drawing.Point(87, 211);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(567, 45);
            this.groupBox2.TabIndex = 26;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboSL2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSL3Code);
            this.groupBox1.Controls.Add(this.comboSL1);
            this.groupBox1.Controls.Add(this.txtSL3Order);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtSL3Name);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSL3ID);
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(45, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(760, 180);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Schedule Level - 3";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboSL2
            // 
            this.comboSL2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboSL2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboSL2.FormattingEnabled = true;
            this.comboSL2.Location = new System.Drawing.Point(143, 50);
            this.comboSL2.Margin = new System.Windows.Forms.Padding(2);
            this.comboSL2.Name = "comboSL2";
            this.comboSL2.Size = new System.Drawing.Size(316, 21);
            this.comboSL2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "SL2 Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(545, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "SL3 Code";
            // 
            // txtSL3Code
            // 
            this.txtSL3Code.Enabled = false;
            this.txtSL3Code.Location = new System.Drawing.Point(625, 26);
            this.txtSL3Code.Margin = new System.Windows.Forms.Padding(2);
            this.txtSL3Code.Name = "txtSL3Code";
            this.txtSL3Code.Size = new System.Drawing.Size(68, 20);
            this.txtSL3Code.TabIndex = 1;
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
            // txtSL3Order
            // 
            this.txtSL3Order.Location = new System.Drawing.Point(625, 79);
            this.txtSL3Order.Margin = new System.Windows.Forms.Padding(2);
            this.txtSL3Order.Name = "txtSL3Order";
            this.txtSL3Order.Size = new System.Drawing.Size(68, 20);
            this.txtSL3Order.TabIndex = 5;
            this.txtSL3Order.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSL3Order_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(547, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "SL3 Order";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 129);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "SL3 Active";
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
            this.groupBox3.Location = new System.Drawing.Point(143, 123);
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
            this.label7.Location = new System.Drawing.Point(57, 103);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "SL3 Name";
            // 
            // txtSL3Name
            // 
            this.txtSL3Name.Location = new System.Drawing.Point(143, 103);
            this.txtSL3Name.Margin = new System.Windows.Forms.Padding(2);
            this.txtSL3Name.Name = "txtSL3Name";
            this.txtSL3Name.Size = new System.Drawing.Size(316, 20);
            this.txtSL3Name.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "SL3 ID";
            // 
            // txtSL3ID
            // 
            this.txtSL3ID.Location = new System.Drawing.Point(143, 76);
            this.txtSL3ID.Margin = new System.Windows.Forms.Padding(2);
            this.txtSL3ID.Name = "txtSL3ID";
            this.txtSL3ID.Size = new System.Drawing.Size(68, 20);
            this.txtSL3ID.TabIndex = 3;
            this.txtSL3ID.TextChanged += new System.EventHandler(this.txtSL3ID_TextChanged);
            this.txtSL3ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSL3ID_KeyPress);
            // 
            // DGVSL3SL2SL1
            // 
            this.DGVSL3SL2SL1.AllowUserToAddRows = false;
            this.DGVSL3SL2SL1.AllowUserToDeleteRows = false;
            this.DGVSL3SL2SL1.AllowUserToResizeColumns = false;
            this.DGVSL3SL2SL1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.DGVSL3SL2SL1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVSL3SL2SL1.AutoGenerateColumns = false;
            this.DGVSL3SL2SL1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVSL3SL2SL1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVSL3SL2SL1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSL3SL2SL1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PKSL3,
            this.SL3ID,
            this.pKSL3DataGridViewTextBoxColumn,
            this.sL3IDDataGridViewTextBoxColumn,
            this.pKSL2DataGridViewTextBoxColumn,
            this.sL1IDDataGridViewTextBoxColumn,
            this.sL1NameDataGridViewTextBoxColumn,
            this.sL2NameDataGridViewTextBoxColumn,
            this.sL3NameDataGridViewTextBoxColumn,
            this.sL3OrderDataGridViewTextBoxColumn,
            this.sL3ActiveDataGridViewCheckBoxColumn,
            this.sL3CodeDataGridViewTextBoxColumn});
            this.DGVSL3SL2SL1.DataSource = this.sL3SL2SL1BindingSource1;
            this.DGVSL3SL2SL1.Location = new System.Drawing.Point(45, 269);
            this.DGVSL3SL2SL1.Margin = new System.Windows.Forms.Padding(2);
            this.DGVSL3SL2SL1.MultiSelect = false;
            this.DGVSL3SL2SL1.Name = "DGVSL3SL2SL1";
            this.DGVSL3SL2SL1.ReadOnly = true;
            this.DGVSL3SL2SL1.RowTemplate.Height = 28;
            this.DGVSL3SL2SL1.Size = new System.Drawing.Size(760, 233);
            this.DGVSL3SL2SL1.TabIndex = 28;
            this.DGVSL3SL2SL1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVSL3SL2SL1_CellClick);
            // 
            // PKSL3
            // 
            this.PKSL3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PKSL3.DataPropertyName = "PKSL3";
            this.PKSL3.HeaderText = "PKSL3";
            this.PKSL3.Name = "PKSL3";
            this.PKSL3.ReadOnly = true;
            this.PKSL3.Visible = false;
            // 
            // SL3ID
            // 
            this.SL3ID.DataPropertyName = "SL3ID";
            this.SL3ID.HeaderText = "SL3ID";
            this.SL3ID.Name = "SL3ID";
            this.SL3ID.ReadOnly = true;
            this.SL3ID.Visible = false;
            this.SL3ID.Width = 62;
            // 
            // pKSL3DataGridViewTextBoxColumn
            // 
            this.pKSL3DataGridViewTextBoxColumn.DataPropertyName = "PKSL3";
            this.pKSL3DataGridViewTextBoxColumn.HeaderText = "PKSL3";
            this.pKSL3DataGridViewTextBoxColumn.Name = "pKSL3DataGridViewTextBoxColumn";
            this.pKSL3DataGridViewTextBoxColumn.ReadOnly = true;
            this.pKSL3DataGridViewTextBoxColumn.Visible = false;
            this.pKSL3DataGridViewTextBoxColumn.Width = 65;
            // 
            // sL3IDDataGridViewTextBoxColumn
            // 
            this.sL3IDDataGridViewTextBoxColumn.DataPropertyName = "SL3ID";
            this.sL3IDDataGridViewTextBoxColumn.HeaderText = "SL3ID";
            this.sL3IDDataGridViewTextBoxColumn.Name = "sL3IDDataGridViewTextBoxColumn";
            this.sL3IDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sL3IDDataGridViewTextBoxColumn.Visible = false;
            this.sL3IDDataGridViewTextBoxColumn.Width = 62;
            // 
            // pKSL2DataGridViewTextBoxColumn
            // 
            this.pKSL2DataGridViewTextBoxColumn.DataPropertyName = "PKSL2";
            this.pKSL2DataGridViewTextBoxColumn.HeaderText = "PKSL2";
            this.pKSL2DataGridViewTextBoxColumn.Name = "pKSL2DataGridViewTextBoxColumn";
            this.pKSL2DataGridViewTextBoxColumn.ReadOnly = true;
            this.pKSL2DataGridViewTextBoxColumn.Visible = false;
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
            // sL1NameDataGridViewTextBoxColumn
            // 
            this.sL1NameDataGridViewTextBoxColumn.DataPropertyName = "SL1Name";
            this.sL1NameDataGridViewTextBoxColumn.HeaderText = "SL1Name";
            this.sL1NameDataGridViewTextBoxColumn.Name = "sL1NameDataGridViewTextBoxColumn";
            this.sL1NameDataGridViewTextBoxColumn.ReadOnly = true;
            this.sL1NameDataGridViewTextBoxColumn.Width = 79;
            // 
            // sL2NameDataGridViewTextBoxColumn
            // 
            this.sL2NameDataGridViewTextBoxColumn.DataPropertyName = "SL2Name";
            this.sL2NameDataGridViewTextBoxColumn.HeaderText = "SL2Name";
            this.sL2NameDataGridViewTextBoxColumn.Name = "sL2NameDataGridViewTextBoxColumn";
            this.sL2NameDataGridViewTextBoxColumn.ReadOnly = true;
            this.sL2NameDataGridViewTextBoxColumn.Width = 79;
            // 
            // sL3NameDataGridViewTextBoxColumn
            // 
            this.sL3NameDataGridViewTextBoxColumn.DataPropertyName = "SL3Name";
            this.sL3NameDataGridViewTextBoxColumn.HeaderText = "SL3Name";
            this.sL3NameDataGridViewTextBoxColumn.Name = "sL3NameDataGridViewTextBoxColumn";
            this.sL3NameDataGridViewTextBoxColumn.ReadOnly = true;
            this.sL3NameDataGridViewTextBoxColumn.Width = 79;
            // 
            // sL3OrderDataGridViewTextBoxColumn
            // 
            this.sL3OrderDataGridViewTextBoxColumn.DataPropertyName = "SL3Order";
            this.sL3OrderDataGridViewTextBoxColumn.HeaderText = "SL3Order";
            this.sL3OrderDataGridViewTextBoxColumn.Name = "sL3OrderDataGridViewTextBoxColumn";
            this.sL3OrderDataGridViewTextBoxColumn.ReadOnly = true;
            this.sL3OrderDataGridViewTextBoxColumn.Width = 77;
            // 
            // sL3ActiveDataGridViewCheckBoxColumn
            // 
            this.sL3ActiveDataGridViewCheckBoxColumn.DataPropertyName = "SL3Active";
            this.sL3ActiveDataGridViewCheckBoxColumn.HeaderText = "SL3Active";
            this.sL3ActiveDataGridViewCheckBoxColumn.Name = "sL3ActiveDataGridViewCheckBoxColumn";
            this.sL3ActiveDataGridViewCheckBoxColumn.ReadOnly = true;
            this.sL3ActiveDataGridViewCheckBoxColumn.Width = 62;
            // 
            // sL3CodeDataGridViewTextBoxColumn
            // 
            this.sL3CodeDataGridViewTextBoxColumn.DataPropertyName = "SL3Code";
            this.sL3CodeDataGridViewTextBoxColumn.HeaderText = "SL3Code";
            this.sL3CodeDataGridViewTextBoxColumn.Name = "sL3CodeDataGridViewTextBoxColumn";
            this.sL3CodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.sL3CodeDataGridViewTextBoxColumn.Width = 76;
            // 
            // sL3SL2SL1BindingSource1
            // 
            this.sL3SL2SL1BindingSource1.DataMember = "SL3SL2SL1";
            this.sL3SL2SL1BindingSource1.DataSource = this.financeDataSet13;
            // 
            // financeDataSet13
            // 
            this.financeDataSet13.DataSetName = "FinanceDataSet13";
            this.financeDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sL3SL2SL1BindingSource
            // 
            this.sL3SL2SL1BindingSource.DataMember = "SL3SL2SL1";
            this.sL3SL2SL1BindingSource.DataSource = this.financeDataSet;
            // 
            // financeDataSet
            // 
            this.financeDataSet.DataSetName = "FinanceDataSet";
            this.financeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sL3SL2SL1TableAdapter
            // 
            this.sL3SL2SL1TableAdapter.ClearBeforeFill = true;
            // 
            // sL3SL2SL1TableAdapter1
            // 
            this.sL3SL2SL1TableAdapter1.ClearBeforeFill = true;
            // 
            // frmSL3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 542);
            this.Controls.Add(this.DGVSL3SL2SL1);
            this.Controls.Add(this.txtPKSL3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmSL3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule Level - 3";
            this.Load += new System.EventHandler(this.frmSL3_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSL3SL2SL1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sL3SL2SL1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sL3SL2SL1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPKSL3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSL3Code;
        private System.Windows.Forms.ComboBox comboSL1;
        private System.Windows.Forms.TextBox txtSL3Order;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioBtnSL3InActive;
        private System.Windows.Forms.RadioButton radioBtnSL3Active;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSL3Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSL3ID;
        private System.Windows.Forms.ComboBox comboSL2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DGVSL3SL2SL1;
        private FinanceDataSet financeDataSet;
        private System.Windows.Forms.BindingSource sL3SL2SL1BindingSource;
        private FinanceDataSetTableAdapters.SL3SL2SL1TableAdapter sL3SL2SL1TableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPrint;
        private FinanceDataSet13 financeDataSet13;
        private System.Windows.Forms.BindingSource sL3SL2SL1BindingSource1;
        private FinanceDataSet13TableAdapters.SL3SL2SL1TableAdapter sL3SL2SL1TableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PKSL3;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL3ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn pKSL3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sL3IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pKSL2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sL1IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sL1NameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sL2NameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sL3NameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sL3OrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sL3ActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sL3CodeDataGridViewTextBoxColumn;
    }
}