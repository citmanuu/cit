namespace MANUUFinance
{
    partial class frmCloneDeptBudget
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fromDepartmentList = new System.Windows.Forms.ListBox();
            this.dEPTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.financeDataSet = new MANUUFinance.FinanceDataSet();
            this.toDepartmentList = new System.Windows.Forms.ListBox();
            this.dEPTTableAdapter = new MANUUFinance.FinanceDataSetTableAdapters.DEPTTableAdapter();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnMoveAll = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.comboFromFinancialYear = new System.Windows.Forms.ComboBox();
            this.comboDepartment = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboToFinancialYear = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.chkUpdateOn = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dEPTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Copy From Department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Copy to Financial Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(154, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Available Departments";
            // 
            // fromDepartmentList
            // 
            this.fromDepartmentList.DataSource = this.dEPTBindingSource;
            this.fromDepartmentList.DisplayMember = "DEPNAME";
            this.fromDepartmentList.FormattingEnabled = true;
            this.fromDepartmentList.ItemHeight = 20;
            this.fromDepartmentList.Location = new System.Drawing.Point(126, 223);
            this.fromDepartmentList.Name = "fromDepartmentList";
            this.fromDepartmentList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.fromDepartmentList.Size = new System.Drawing.Size(271, 304);
            this.fromDepartmentList.TabIndex = 1;
            this.fromDepartmentList.ValueMember = "PKDEPID";
            // 
            // dEPTBindingSource
            // 
            this.dEPTBindingSource.DataMember = "DEPT";
            this.dEPTBindingSource.DataSource = this.financeDataSet;
            // 
            // financeDataSet
            // 
            this.financeDataSet.DataSetName = "FinanceDataSet";
            this.financeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toDepartmentList
            // 
            this.toDepartmentList.FormattingEnabled = true;
            this.toDepartmentList.ItemHeight = 20;
            this.toDepartmentList.Location = new System.Drawing.Point(587, 223);
            this.toDepartmentList.Name = "toDepartmentList";
            this.toDepartmentList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.toDepartmentList.Size = new System.Drawing.Size(274, 304);
            this.toDepartmentList.TabIndex = 2;
            // 
            // dEPTTableAdapter
            // 
            this.dEPTTableAdapter.ClearBeforeFill = true;
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(441, 261);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(112, 45);
            this.btnMove.TabIndex = 3;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnMoveAll
            // 
            this.btnMoveAll.Location = new System.Drawing.Point(441, 323);
            this.btnMoveAll.Name = "btnMoveAll";
            this.btnMoveAll.Size = new System.Drawing.Size(112, 45);
            this.btnMoveAll.TabIndex = 4;
            this.btnMoveAll.Text = "Move All";
            this.btnMoveAll.UseVisualStyleBackColor = true;
            this.btnMoveAll.Click += new System.EventHandler(this.btnMoveAll_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Location = new System.Drawing.Point(441, 446);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(112, 45);
            this.btnRemoveAll.TabIndex = 6;
            this.btnRemoveAll.Text = "Remove All";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(441, 384);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(112, 45);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // comboFromFinancialYear
            // 
            this.comboFromFinancialYear.FormattingEnabled = true;
            this.comboFromFinancialYear.Location = new System.Drawing.Point(316, 64);
            this.comboFromFinancialYear.Name = "comboFromFinancialYear";
            this.comboFromFinancialYear.Size = new System.Drawing.Size(121, 28);
            this.comboFromFinancialYear.TabIndex = 7;
            this.comboFromFinancialYear.SelectedIndexChanged += new System.EventHandler(this.comboFromFinancialYear_SelectedIndexChanged);
            // 
            // comboDepartment
            // 
            this.comboDepartment.FormattingEnabled = true;
            this.comboDepartment.Location = new System.Drawing.Point(316, 98);
            this.comboDepartment.Name = "comboDepartment";
            this.comboDepartment.Size = new System.Drawing.Size(545, 28);
            this.comboDepartment.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Copy from Financial Year";
            // 
            // comboToFinancialYear
            // 
            this.comboToFinancialYear.FormattingEnabled = true;
            this.comboToFinancialYear.Location = new System.Drawing.Point(316, 132);
            this.comboToFinancialYear.Name = "comboToFinancialYear";
            this.comboToFinancialYear.Size = new System.Drawing.Size(121, 28);
            this.comboToFinancialYear.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(336, 598);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(292, 45);
            this.button1.TabIndex = 10;
            this.button1.Text = "Copy Budget to Selected Departments";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(622, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Selected Departments";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 635);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(135, 688);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(726, 50);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "This will copy all Budget Heads From Selected Departments to Target Departnents ." +
    " In case Taget Departments contains the same budget head, they will be updated.";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(131, 563);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 14;
            // 
            // chkUpdateOn
            // 
            this.chkUpdateOn.AutoSize = true;
            this.chkUpdateOn.ForeColor = System.Drawing.Color.Red;
            this.chkUpdateOn.Location = new System.Drawing.Point(328, 563);
            this.chkUpdateOn.Name = "chkUpdateOn";
            this.chkUpdateOn.Size = new System.Drawing.Size(312, 24);
            this.chkUpdateOn.TabIndex = 15;
            this.chkUpdateOn.Text = "Update Budget Head(s), if already exist";
            this.chkUpdateOn.UseVisualStyleBackColor = true;
            // 
            // frmCloneDeptBudget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 817);
            this.Controls.Add(this.chkUpdateOn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboToFinancialYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboDepartment);
            this.Controls.Add(this.comboFromFinancialYear);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnMoveAll);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.toDepartmentList);
            this.Controls.Add(this.fromDepartmentList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmCloneDeptBudget";
            this.Text = " ";
            this.Load += new System.EventHandler(this.CloneDeptBudget_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dEPTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox fromDepartmentList;
        private System.Windows.Forms.ListBox toDepartmentList;
        private FinanceDataSet financeDataSet;
        private System.Windows.Forms.BindingSource dEPTBindingSource;
        private FinanceDataSetTableAdapters.DEPTTableAdapter dEPTTableAdapter;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnMoveAll;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ComboBox comboFromFinancialYear;
        private System.Windows.Forms.ComboBox comboDepartment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboToFinancialYear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkUpdateOn;
    }
}