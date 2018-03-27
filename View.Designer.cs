namespace MANUUFinance
{
    partial class View
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
            this.ldapDataSet4 = new MANUUFinance.LdapDataSet4();
            this.userDeptRoleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ldapDataSet3 = new MANUUFinance.LdapDataSet3();
            this.userDeptRoleTableAdapter = new MANUUFinance.LdapDataSet3TableAdapters.UserDeptRoleTableAdapter();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNameSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.userDeptRoleTableAdapter1 = new MANUUFinance.LdapDataSet4TableAdapters.UserDeptRoleTableAdapter();
            this.userDeptRoleBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userDeptRoleBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.ldapDataSet5 = new MANUUFinance.LdapDataSet5();
            this.userDeptRoleBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.userDeptRoleTableAdapter2 = new MANUUFinance.LdapDataSet5TableAdapters.UserDeptRoleTableAdapter();
            this.ldapDataSet6 = new MANUUFinance.LdapDataSet6();
            this.userDeptRoleviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userDeptRoleviewTableAdapter = new MANUUFinance.LdapDataSet6TableAdapters.UserDeptRoleviewTableAdapter();
            this.uDRIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.userDeptRoleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ldapDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDeptRoleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ldapDataSet3)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDeptRoleBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDeptRoleBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ldapDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDeptRoleBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ldapDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDeptRoleviewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // userDeptRoleBindingSource1
            // 
            this.userDeptRoleBindingSource1.DataMember = "UserDeptRole";
            this.userDeptRoleBindingSource1.DataSource = this.ldapDataSet4;
            // 
            // ldapDataSet4
            // 
            this.ldapDataSet4.DataSetName = "LdapDataSet4";
            this.ldapDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userDeptRoleBindingSource
            // 
            this.userDeptRoleBindingSource.DataMember = "UserDeptRole";
            this.userDeptRoleBindingSource.DataSource = this.ldapDataSet3;
            // 
            // ldapDataSet3
            // 
            this.ldapDataSet3.DataSetName = "LdapDataSet3";
            this.ldapDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userDeptRoleTableAdapter
            // 
            this.userDeptRoleTableAdapter.ClearBeforeFill = true;
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
            // userDeptRoleTableAdapter1
            // 
            this.userDeptRoleTableAdapter1.ClearBeforeFill = true;
            // 
            // userDeptRoleBindingSource2
            // 
            this.userDeptRoleBindingSource2.DataMember = "UserDeptRole";
            this.userDeptRoleBindingSource2.DataSource = this.ldapDataSet4;
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
            this.dataGridView1.DataSource = this.userDeptRoleviewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(42, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(336, 257);
            this.dataGridView1.TabIndex = 38;
            // 
            // userDeptRoleBindingSource3
            // 
            this.userDeptRoleBindingSource3.DataMember = "UserDeptRole";
            this.userDeptRoleBindingSource3.DataSource = this.ldapDataSet4;
            // 
            // ldapDataSet5
            // 
            this.ldapDataSet5.DataSetName = "LdapDataSet5";
            this.ldapDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userDeptRoleBindingSource4
            // 
            this.userDeptRoleBindingSource4.DataMember = "UserDeptRole";
            this.userDeptRoleBindingSource4.DataSource = this.ldapDataSet5;
            // 
            // userDeptRoleTableAdapter2
            // 
            this.userDeptRoleTableAdapter2.ClearBeforeFill = true;
            // 
            // ldapDataSet6
            // 
            this.ldapDataSet6.DataSetName = "LdapDataSet6";
            this.ldapDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userDeptRoleviewBindingSource
            // 
            this.userDeptRoleviewBindingSource.DataMember = "UserDeptRoleview";
            this.userDeptRoleviewBindingSource.DataSource = this.ldapDataSet6;
            // 
            // userDeptRoleviewTableAdapter
            // 
            this.userDeptRoleviewTableAdapter.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.ldapDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDeptRoleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ldapDataSet3)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDeptRoleBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDeptRoleBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ldapDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDeptRoleBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ldapDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDeptRoleviewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private LdapDataSet3 ldapDataSet3;
        private System.Windows.Forms.BindingSource userDeptRoleBindingSource;
        private LdapDataSet3TableAdapters.UserDeptRoleTableAdapter userDeptRoleTableAdapter;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNameSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClearSearch;
        private System.Windows.Forms.Label label5;
        private LdapDataSet4 ldapDataSet4;
        private System.Windows.Forms.BindingSource userDeptRoleBindingSource1;
        private LdapDataSet4TableAdapters.UserDeptRoleTableAdapter userDeptRoleTableAdapter1;
        private System.Windows.Forms.BindingSource userDeptRoleBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource userDeptRoleBindingSource3;
        private LdapDataSet5 ldapDataSet5;
        private System.Windows.Forms.BindingSource userDeptRoleBindingSource4;
        private LdapDataSet5TableAdapters.UserDeptRoleTableAdapter userDeptRoleTableAdapter2;
        private LdapDataSet6 ldapDataSet6;
        private System.Windows.Forms.BindingSource userDeptRoleviewBindingSource;
        private LdapDataSet6TableAdapters.UserDeptRoleviewTableAdapter userDeptRoleviewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn uDRIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptNameDataGridViewTextBoxColumn;
    }
}