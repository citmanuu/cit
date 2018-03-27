namespace MANUUFinance
{
    partial class frmSL1
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSL1ID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboAcType = new System.Windows.Forms.ComboBox();
            this.txtSL1Order = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGroupID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtScheduleID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioBtnSL1InActive = new System.Windows.Forms.RadioButton();
            this.radioBtnSL1Active = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSL1Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSL1Code = new System.Windows.Forms.TextBox();
            this.txtSL1UCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.financeDataSet = new MANUUFinance.FinanceDataSet();
            this.DGVSL1 = new System.Windows.Forms.DataGridView();
            this.sL1IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sL1CodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sl1UCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sL1NameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sL1ActiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sL1OrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sL1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sL1TableAdapter = new MANUUFinance.FinanceDataSetTableAdapters.SL1TableAdapter();
            this.financeDataSet1 = new MANUUFinance.FinanceDataSet();
            this.sL1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSL1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sL1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sL1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Location = new System.Drawing.Point(250, 298);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(712, 70);
            this.groupBox2.TabIndex = 19;
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
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            // txtSL1ID
            // 
            this.txtSL1ID.Enabled = false;
            this.txtSL1ID.Location = new System.Drawing.Point(298, 86);
            this.txtSL1ID.Name = "txtSL1ID";
            this.txtSL1ID.Size = new System.Drawing.Size(100, 26);
            this.txtSL1ID.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.comboAcType);
            this.groupBox1.Controls.Add(this.txtSL1Order);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtGroupID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtScheduleID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtSL1Name);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSL1Code);
            this.groupBox1.Controls.Add(this.txtSL1UCode);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(84, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1108, 235);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Schedule Level - 1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(374, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Account Type";
            // 
            // comboAcType
            // 
            this.comboAcType.FormattingEnabled = true;
            this.comboAcType.Location = new System.Drawing.Point(487, 80);
            this.comboAcType.Name = "comboAcType";
            this.comboAcType.Size = new System.Drawing.Size(199, 28);
            this.comboAcType.TabIndex = 17;
            // 
            // txtSL1Order
            // 
            this.txtSL1Order.Location = new System.Drawing.Point(903, 159);
            this.txtSL1Order.Name = "txtSL1Order";
            this.txtSL1Order.Size = new System.Drawing.Size(100, 26);
            this.txtSL1Order.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(785, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Sl1 Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(785, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Schedule ID";
            // 
            // txtGroupID
            // 
            this.txtGroupID.Location = new System.Drawing.Point(903, 120);
            this.txtGroupID.Name = "txtGroupID";
            this.txtGroupID.Size = new System.Drawing.Size(100, 26);
            this.txtGroupID.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(86, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "SL1 Active";
            // 
            // txtScheduleID
            // 
            this.txtScheduleID.Location = new System.Drawing.Point(903, 82);
            this.txtScheduleID.Name = "txtScheduleID";
            this.txtScheduleID.Size = new System.Drawing.Size(100, 26);
            this.txtScheduleID.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(785, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Group ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "SL1 ID";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioBtnSL1InActive);
            this.groupBox3.Controls.Add(this.radioBtnSL1Active);
            this.groupBox3.Location = new System.Drawing.Point(214, 153);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(273, 47);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            // 
            // radioBtnSL1InActive
            // 
            this.radioBtnSL1InActive.AutoSize = true;
            this.radioBtnSL1InActive.Location = new System.Drawing.Point(148, 16);
            this.radioBtnSL1InActive.Name = "radioBtnSL1InActive";
            this.radioBtnSL1InActive.Size = new System.Drawing.Size(89, 24);
            this.radioBtnSL1InActive.TabIndex = 1;
            this.radioBtnSL1InActive.TabStop = true;
            this.radioBtnSL1InActive.Text = "Inactive";
            this.radioBtnSL1InActive.UseVisualStyleBackColor = true;
            // 
            // radioBtnSL1Active
            // 
            this.radioBtnSL1Active.AutoSize = true;
            this.radioBtnSL1Active.Location = new System.Drawing.Point(40, 16);
            this.radioBtnSL1Active.Name = "radioBtnSL1Active";
            this.radioBtnSL1Active.Size = new System.Drawing.Size(77, 24);
            this.radioBtnSL1Active.TabIndex = 0;
            this.radioBtnSL1Active.TabStop = true;
            this.radioBtnSL1Active.Text = "Active";
            this.radioBtnSL1Active.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "SL1 Name";
            // 
            // txtSL1Name
            // 
            this.txtSL1Name.Location = new System.Drawing.Point(214, 121);
            this.txtSL1Name.Name = "txtSL1Name";
            this.txtSL1Name.Size = new System.Drawing.Size(472, 26);
            this.txtSL1Name.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(785, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "SL1 Code";
            // 
            // txtSL1Code
            // 
            this.txtSL1Code.Location = new System.Drawing.Point(903, 44);
            this.txtSL1Code.Name = "txtSL1Code";
            this.txtSL1Code.Size = new System.Drawing.Size(100, 26);
            this.txtSL1Code.TabIndex = 0;
            // 
            // txtSL1UCode
            // 
            this.txtSL1UCode.Enabled = false;
            this.txtSL1UCode.Location = new System.Drawing.Point(214, 83);
            this.txtSL1UCode.Name = "txtSL1UCode";
            this.txtSL1UCode.Size = new System.Drawing.Size(100, 26);
            this.txtSL1UCode.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "SL1 User Code";
            // 
            // financeDataSet
            // 
            this.financeDataSet.DataSetName = "FinanceDataSet";
            this.financeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DGVSL1
            // 
            this.DGVSL1.AllowUserToAddRows = false;
            this.DGVSL1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.DGVSL1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVSL1.AutoGenerateColumns = false;
            this.DGVSL1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVSL1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVSL1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSL1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sL1IDDataGridViewTextBoxColumn,
            this.sL1CodeDataGridViewTextBoxColumn,
            this.sl1UCDataGridViewTextBoxColumn,
            this.acTypeIDDataGridViewTextBoxColumn,
            this.scheduleIDDataGridViewTextBoxColumn,
            this.sL1NameDataGridViewTextBoxColumn,
            this.groupIDDataGridViewTextBoxColumn,
            this.sL1ActiveDataGridViewTextBoxColumn,
            this.sL1OrderDataGridViewTextBoxColumn});
            this.DGVSL1.DataSource = this.sL1BindingSource;
            this.DGVSL1.Location = new System.Drawing.Point(84, 388);
            this.DGVSL1.Name = "DGVSL1";
            this.DGVSL1.ReadOnly = true;
            this.DGVSL1.RowTemplate.Height = 28;
            this.DGVSL1.Size = new System.Drawing.Size(1108, 380);
            this.DGVSL1.TabIndex = 20;
            this.DGVSL1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVSL1_CellClick);
            // 
            // sL1IDDataGridViewTextBoxColumn
            // 
            this.sL1IDDataGridViewTextBoxColumn.DataPropertyName = "SL1ID";
            this.sL1IDDataGridViewTextBoxColumn.HeaderText = "SL1ID";
            this.sL1IDDataGridViewTextBoxColumn.Name = "sL1IDDataGridViewTextBoxColumn";
            this.sL1IDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sL1IDDataGridViewTextBoxColumn.Width = 91;
            // 
            // sL1CodeDataGridViewTextBoxColumn
            // 
            this.sL1CodeDataGridViewTextBoxColumn.DataPropertyName = "SL1Code";
            this.sL1CodeDataGridViewTextBoxColumn.HeaderText = "SL1Code";
            this.sL1CodeDataGridViewTextBoxColumn.Name = "sL1CodeDataGridViewTextBoxColumn";
            this.sL1CodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.sL1CodeDataGridViewTextBoxColumn.Width = 112;
            // 
            // sl1UCDataGridViewTextBoxColumn
            // 
            this.sl1UCDataGridViewTextBoxColumn.DataPropertyName = "Sl1UC";
            this.sl1UCDataGridViewTextBoxColumn.HeaderText = "Sl1UC";
            this.sl1UCDataGridViewTextBoxColumn.Name = "sl1UCDataGridViewTextBoxColumn";
            this.sl1UCDataGridViewTextBoxColumn.ReadOnly = true;
            this.sl1UCDataGridViewTextBoxColumn.Width = 91;
            // 
            // acTypeIDDataGridViewTextBoxColumn
            // 
            this.acTypeIDDataGridViewTextBoxColumn.DataPropertyName = "AcTypeID";
            this.acTypeIDDataGridViewTextBoxColumn.HeaderText = "AcTypeID";
            this.acTypeIDDataGridViewTextBoxColumn.Name = "acTypeIDDataGridViewTextBoxColumn";
            this.acTypeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.acTypeIDDataGridViewTextBoxColumn.Width = 115;
            // 
            // scheduleIDDataGridViewTextBoxColumn
            // 
            this.scheduleIDDataGridViewTextBoxColumn.DataPropertyName = "ScheduleID";
            this.scheduleIDDataGridViewTextBoxColumn.HeaderText = "ScheduleID";
            this.scheduleIDDataGridViewTextBoxColumn.Name = "scheduleIDDataGridViewTextBoxColumn";
            this.scheduleIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.scheduleIDDataGridViewTextBoxColumn.Width = 129;
            // 
            // sL1NameDataGridViewTextBoxColumn
            // 
            this.sL1NameDataGridViewTextBoxColumn.DataPropertyName = "SL1Name";
            this.sL1NameDataGridViewTextBoxColumn.HeaderText = "SL1Name";
            this.sL1NameDataGridViewTextBoxColumn.Name = "sL1NameDataGridViewTextBoxColumn";
            this.sL1NameDataGridViewTextBoxColumn.ReadOnly = true;
            this.sL1NameDataGridViewTextBoxColumn.Width = 116;
            // 
            // groupIDDataGridViewTextBoxColumn
            // 
            this.groupIDDataGridViewTextBoxColumn.DataPropertyName = "GroupID";
            this.groupIDDataGridViewTextBoxColumn.HeaderText = "GroupID";
            this.groupIDDataGridViewTextBoxColumn.Name = "groupIDDataGridViewTextBoxColumn";
            this.groupIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.groupIDDataGridViewTextBoxColumn.Width = 107;
            // 
            // sL1ActiveDataGridViewTextBoxColumn
            // 
            this.sL1ActiveDataGridViewTextBoxColumn.DataPropertyName = "SL1Active";
            this.sL1ActiveDataGridViewTextBoxColumn.HeaderText = "SL1Active";
            this.sL1ActiveDataGridViewTextBoxColumn.Name = "sL1ActiveDataGridViewTextBoxColumn";
            this.sL1ActiveDataGridViewTextBoxColumn.ReadOnly = true;
            this.sL1ActiveDataGridViewTextBoxColumn.Width = 117;
            // 
            // sL1OrderDataGridViewTextBoxColumn
            // 
            this.sL1OrderDataGridViewTextBoxColumn.DataPropertyName = "SL1Order";
            this.sL1OrderDataGridViewTextBoxColumn.HeaderText = "SL1Order";
            this.sL1OrderDataGridViewTextBoxColumn.Name = "sL1OrderDataGridViewTextBoxColumn";
            this.sL1OrderDataGridViewTextBoxColumn.ReadOnly = true;
            this.sL1OrderDataGridViewTextBoxColumn.Width = 114;
            // 
            // sL1BindingSource
            // 
            this.sL1BindingSource.DataMember = "SL1";
            this.sL1BindingSource.DataSource = this.financeDataSet;
            // 
            // sL1TableAdapter
            // 
            this.sL1TableAdapter.ClearBeforeFill = true;
            // 
            // financeDataSet1
            // 
            this.financeDataSet1.DataSetName = "FinanceDataSet";
            this.financeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sL1BindingSource1
            // 
            this.sL1BindingSource1.DataMember = "SL1";
            this.sL1BindingSource1.DataSource = this.financeDataSet;
            // 
            // frmSL1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1870, 841);
            this.Controls.Add(this.DGVSL1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtSL1ID);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSL1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule Level - 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSL1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sL1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sL1BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSL1ID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboAcType;
        private System.Windows.Forms.TextBox txtSL1Order;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGroupID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtScheduleID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioBtnSL1InActive;
        private System.Windows.Forms.RadioButton radioBtnSL1Active;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSL1Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSL1Code;
        private System.Windows.Forms.TextBox txtSL1UCode;
        private System.Windows.Forms.Label label3;
        private FinanceDataSet financeDataSet;
        private System.Windows.Forms.DataGridView DGVSL1;
        private System.Windows.Forms.BindingSource sL1BindingSource;
        private FinanceDataSetTableAdapters.SL1TableAdapter sL1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sL1IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sL1CodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sl1UCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scheduleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sL1NameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sL1ActiveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sL1OrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private FinanceDataSet financeDataSet1;
        private System.Windows.Forms.BindingSource sL1BindingSource1;
    }
}

