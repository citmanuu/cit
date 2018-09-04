namespace MANUUFinance
{
    partial class frmView
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
            this.userDeptRoleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.userDeptRoleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNameSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.userDeptRoleBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uDRIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDeptRoleviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userDeptRoleBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.userDeptRoleBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.financeDataSet3 = new MANUUFinance.FinanceDataSet3();
            this.userDeptRoleviewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.userDeptRoleviewTableAdapter1 = new MANUUFinance.FinanceDataSet3TableAdapters.UserDeptRoleviewTableAdapter();
            this.userDeptRoleviewBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.userDeptRoleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDeptRoleBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDeptRoleBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDeptRoleviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDeptRoleBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDeptRoleBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDeptRoleviewBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDeptRoleviewBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // userDeptRoleBindingSource1
            // 
            this.userDeptRoleBindingSource1.DataMember = "UserDeptRole";
            // 
            // userDeptRoleBindingSource
            // 
            this.userDeptRoleBindingSource.DataMember = "UserDeptRole";
            // 
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtNameSearch);
            this.groupBox4.Controls.Add(this.btnSearch);
            this.groupBox4.Controls.Add(this.btnClearSearch);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(411, 29);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(286, 121);
            this.groupBox4.TabIndex = 37;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Grid Filter";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 32);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Form Name";
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.Location = new System.Drawing.Point(12, 49);
            this.txtNameSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.Size = new System.Drawing.Size(225, 20);
            this.txtNameSearch.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(109, 84);
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
            this.btnClearSearch.Location = new System.Drawing.Point(16, 84);
            this.btnClearSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(89, 25);
            this.btnClearSearch.TabIndex = 5;
            this.btnClearSearch.Text = "Clear Controls";
            this.btnClearSearch.UseVisualStyleBackColor = true;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-82, 88);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Account Name";
            // 
            // 
            // userDeptRoleBindingSource2
            // 
            this.userDeptRoleBindingSource2.DataMember = "UserDeptRole";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uDRIDDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.roleIdDataGridViewTextBoxColumn,
            this.roleNameDataGridViewTextBoxColumn,
            this.deptIdDataGridViewTextBoxColumn,
            this.deptNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.userDeptRoleviewBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(42, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(336, 257);
            this.dataGridView1.TabIndex = 38;
            // 
            // uDRIDDataGridViewTextBoxColumn
            // 
            this.uDRIDDataGridViewTextBoxColumn.DataPropertyName = "UDRID";
            this.uDRIDDataGridViewTextBoxColumn.HeaderText = "UDRID";
            this.uDRIDDataGridViewTextBoxColumn.Name = "uDRIDDataGridViewTextBoxColumn";
            this.uDRIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.uDRIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roleIdDataGridViewTextBoxColumn
            // 
            this.roleIdDataGridViewTextBoxColumn.DataPropertyName = "RoleId";
            this.roleIdDataGridViewTextBoxColumn.HeaderText = "RoleId";
            this.roleIdDataGridViewTextBoxColumn.Name = "roleIdDataGridViewTextBoxColumn";
            this.roleIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.roleIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // roleNameDataGridViewTextBoxColumn
            // 
            this.roleNameDataGridViewTextBoxColumn.DataPropertyName = "RoleName";
            this.roleNameDataGridViewTextBoxColumn.HeaderText = "RoleName";
            this.roleNameDataGridViewTextBoxColumn.Name = "roleNameDataGridViewTextBoxColumn";
            this.roleNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deptIdDataGridViewTextBoxColumn
            // 
            this.deptIdDataGridViewTextBoxColumn.DataPropertyName = "DeptId";
            this.deptIdDataGridViewTextBoxColumn.HeaderText = "DeptId";
            this.deptIdDataGridViewTextBoxColumn.Name = "deptIdDataGridViewTextBoxColumn";
            this.deptIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.deptIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // deptNameDataGridViewTextBoxColumn
            // 
            this.deptNameDataGridViewTextBoxColumn.DataPropertyName = "DeptName";
            this.deptNameDataGridViewTextBoxColumn.HeaderText = "DeptName";
            this.deptNameDataGridViewTextBoxColumn.Name = "deptNameDataGridViewTextBoxColumn";
            this.deptNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userDeptRoleviewBindingSource
            // 
            this.userDeptRoleviewBindingSource.DataMember = "UserDeptRoleview"; 
            // userDeptRoleBindingSource3
            // 
            this.userDeptRoleBindingSource3.DataMember = "UserDeptRole"; 
            // userDeptRoleBindingSource4
            // 
            this.userDeptRoleBindingSource4.DataMember = "UserDeptRole";
           // 
            this.financeDataSet3.DataSetName = "FinanceDataSet3";
            this.financeDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userDeptRoleviewBindingSource1
            // 
            this.userDeptRoleviewBindingSource1.DataMember = "UserDeptRoleview";
            this.userDeptRoleviewBindingSource1.DataSource = this.financeDataSet3;
            // 
            // userDeptRoleviewTableAdapter1
            // 
            this.userDeptRoleviewTableAdapter1.ClearBeforeFill = true;
            // 
            // userDeptRoleviewBindingSource2
            // 
            this.userDeptRoleviewBindingSource2.DataMember = "UserDeptRoleview";
            this.userDeptRoleviewBindingSource2.DataSource = this.financeDataSet3;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 317);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox4);
            this.Name = "View";
            this.Text = "View";
            this.Load += new System.EventHandler(this.View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userDeptRoleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDeptRoleBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDeptRoleBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDeptRoleviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDeptRoleBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDeptRoleBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDeptRoleviewBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDeptRoleviewBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource userDeptRoleBindingSource;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNameSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClearSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource userDeptRoleBindingSource1;
        private System.Windows.Forms.BindingSource userDeptRoleBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource userDeptRoleBindingSource3;
        private System.Windows.Forms.BindingSource userDeptRoleBindingSource4;        
        private System.Windows.Forms.BindingSource userDeptRoleviewBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn uDRIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptNameDataGridViewTextBoxColumn;
        private FinanceDataSet3 financeDataSet3;
        private System.Windows.Forms.BindingSource userDeptRoleviewBindingSource1;
        private FinanceDataSet3TableAdapters.UserDeptRoleviewTableAdapter userDeptRoleviewTableAdapter1;
        private System.Windows.Forms.BindingSource userDeptRoleviewBindingSource2;
    }
}