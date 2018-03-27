namespace MANUUFinance
{
    partial class DeptPrivileges
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
            this.roleMSTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ldapDataSet = new MANUUFinance.LdapDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnMoveAll = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.toDepartmentList = new System.Windows.Forms.ListBox();
            this.fromDepartmentList = new System.Windows.Forms.ListBox();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.departmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btAddToDatabase = new System.Windows.Forms.Button();
            this.departmentTableAdapter = new MANUUFinance.LdapDataSetTableAdapters.DepartmentTableAdapter();
            this.roleMSTTableAdapter = new MANUUFinance.LdapDataSetTableAdapters.RoleMSTTableAdapter();
            this.departmentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.roleMSTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ldapDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // roleMSTBindingSource
            // 
            this.roleMSTBindingSource.DataMember = "RoleMST";
            this.roleMSTBindingSource.DataSource = this.ldapDataSet;
            // 
            // ldapDataSet
            // 
            this.ldapDataSet.DataSetName = "LdapDataSet";
            this.ldapDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnRemoveAll);
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.btnMoveAll);
            this.groupBox1.Controls.Add(this.btnMove);
            this.groupBox1.Controls.Add(this.toDepartmentList);
            this.groupBox1.Controls.Add(this.fromDepartmentList);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(27, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 264);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Department";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 256);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(348, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Selected Departments";
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Location = new System.Drawing.Point(227, 180);
            this.btnRemoveAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(75, 29);
            this.btnRemoveAll.TabIndex = 22;
            this.btnRemoveAll.Text = "Remove All";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(227, 140);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 29);
            this.btnRemove.TabIndex = 21;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnMoveAll
            // 
            this.btnMoveAll.Location = new System.Drawing.Point(227, 100);
            this.btnMoveAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnMoveAll.Name = "btnMoveAll";
            this.btnMoveAll.Size = new System.Drawing.Size(75, 29);
            this.btnMoveAll.TabIndex = 20;
            this.btnMoveAll.Text = "Move All";
            this.btnMoveAll.UseVisualStyleBackColor = true;
            this.btnMoveAll.Click += new System.EventHandler(this.btnMoveAll_Click);
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(227, 60);
            this.btnMove.Margin = new System.Windows.Forms.Padding(2);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(75, 29);
            this.btnMove.TabIndex = 19;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // toDepartmentList
            // 
            this.toDepartmentList.FormattingEnabled = true;
            this.toDepartmentList.Location = new System.Drawing.Point(324, 35);
            this.toDepartmentList.Margin = new System.Windows.Forms.Padding(2);
            this.toDepartmentList.Name = "toDepartmentList";
            this.toDepartmentList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.toDepartmentList.Size = new System.Drawing.Size(184, 199);
            this.toDepartmentList.TabIndex = 18;
            // 
            // fromDepartmentList
            // 
            this.fromDepartmentList.DataSource = this.departmentBindingSource;
            this.fromDepartmentList.DisplayMember = "DeptName";
            this.fromDepartmentList.FormattingEnabled = true;
            this.fromDepartmentList.Location = new System.Drawing.Point(17, 35);
            this.fromDepartmentList.Margin = new System.Windows.Forms.Padding(2);
            this.fromDepartmentList.Name = "fromDepartmentList";
            this.fromDepartmentList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.fromDepartmentList.Size = new System.Drawing.Size(182, 199);
            this.fromDepartmentList.TabIndex = 17;
            this.fromDepartmentList.ValueMember = "DeptId";
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this.ldapDataSet;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Available Departments";
            // 
            // departmentBindingSource1
            // 
            this.departmentBindingSource1.DataMember = "Department";
            this.departmentBindingSource1.DataSource = this.ldapDataSet;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(108, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 21);
            this.comboBox1.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Existing Users";
            // 
            // btAddToDatabase
            // 
            this.btAddToDatabase.Location = new System.Drawing.Point(244, 328);
            this.btAddToDatabase.Margin = new System.Windows.Forms.Padding(2);
            this.btAddToDatabase.Name = "btAddToDatabase";
            this.btAddToDatabase.Size = new System.Drawing.Size(76, 29);
            this.btAddToDatabase.TabIndex = 30;
            this.btAddToDatabase.Text = "Ok";
            this.btAddToDatabase.UseVisualStyleBackColor = true;
            this.btAddToDatabase.Click += new System.EventHandler(this.btAddToDatabase_Click);
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // roleMSTTableAdapter
            // 
            this.roleMSTTableAdapter.ClearBeforeFill = true;
            // 
            // departmentBindingSource2
            // 
            this.departmentBindingSource2.DataMember = "Department";
            this.departmentBindingSource2.DataSource = this.ldapDataSet;
            // 
            // DeptPrivileges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 374);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAddToDatabase);
            this.Name = "DeptPrivileges";
            this.Text = "Dept Privileges";
            this.Load += new System.EventHandler(this.AssignUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roleMSTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ldapDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnMoveAll;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.ListBox toDepartmentList;
        private System.Windows.Forms.ListBox fromDepartmentList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAddToDatabase;
        private LdapDataSet ldapDataSet;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private LdapDataSetTableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.BindingSource roleMSTBindingSource;
        private LdapDataSetTableAdapters.RoleMSTTableAdapter roleMSTTableAdapter;
        private System.Windows.Forms.BindingSource departmentBindingSource1;
        private System.Windows.Forms.BindingSource departmentBindingSource2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
    }
}