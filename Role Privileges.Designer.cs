namespace MANUUFinance
{
    partial class RolePrivileges
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btRolesRemoveAll = new System.Windows.Forms.Button();
            this.btRolesRemove = new System.Windows.Forms.Button();
            this.btRolesMoveAll = new System.Windows.Forms.Button();
            this.btRolesMove = new System.Windows.Forms.Button();
            this.toRolesList = new System.Windows.Forms.ListBox();
            this.fromRolesList = new System.Windows.Forms.ListBox();
            this.roleMSTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ldapDataSet = new MANUUFinance.LdapDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btAddToDatabase = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.roleMSTTableAdapter = new MANUUFinance.LdapDataSetTableAdapters.RoleMSTTableAdapter();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roleMSTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ldapDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btRolesRemoveAll);
            this.groupBox2.Controls.Add(this.btRolesRemove);
            this.groupBox2.Controls.Add(this.btRolesMoveAll);
            this.groupBox2.Controls.Add(this.btRolesMove);
            this.groupBox2.Controls.Add(this.toRolesList);
            this.groupBox2.Controls.Add(this.fromRolesList);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(31, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(526, 250);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Roles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 256);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(348, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Selected Roles";
            // 
            // btRolesRemoveAll
            // 
            this.btRolesRemoveAll.Location = new System.Drawing.Point(227, 180);
            this.btRolesRemoveAll.Margin = new System.Windows.Forms.Padding(2);
            this.btRolesRemoveAll.Name = "btRolesRemoveAll";
            this.btRolesRemoveAll.Size = new System.Drawing.Size(75, 29);
            this.btRolesRemoveAll.TabIndex = 22;
            this.btRolesRemoveAll.Text = "Remove All";
            this.btRolesRemoveAll.UseVisualStyleBackColor = true;
            this.btRolesRemoveAll.Click += new System.EventHandler(this.btRolesRemoveAll_Click);
            // 
            // btRolesRemove
            // 
            this.btRolesRemove.Location = new System.Drawing.Point(227, 140);
            this.btRolesRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btRolesRemove.Name = "btRolesRemove";
            this.btRolesRemove.Size = new System.Drawing.Size(75, 29);
            this.btRolesRemove.TabIndex = 21;
            this.btRolesRemove.Text = "Remove";
            this.btRolesRemove.UseVisualStyleBackColor = true;
            this.btRolesRemove.Click += new System.EventHandler(this.btRolesRemove_Click);
            // 
            // btRolesMoveAll
            // 
            this.btRolesMoveAll.Location = new System.Drawing.Point(227, 100);
            this.btRolesMoveAll.Margin = new System.Windows.Forms.Padding(2);
            this.btRolesMoveAll.Name = "btRolesMoveAll";
            this.btRolesMoveAll.Size = new System.Drawing.Size(75, 29);
            this.btRolesMoveAll.TabIndex = 20;
            this.btRolesMoveAll.Text = "Move All";
            this.btRolesMoveAll.UseVisualStyleBackColor = true;
            this.btRolesMoveAll.Click += new System.EventHandler(this.btRolesMoveAll_Click);
            // 
            // btRolesMove
            // 
            this.btRolesMove.Location = new System.Drawing.Point(227, 60);
            this.btRolesMove.Margin = new System.Windows.Forms.Padding(2);
            this.btRolesMove.Name = "btRolesMove";
            this.btRolesMove.Size = new System.Drawing.Size(75, 29);
            this.btRolesMove.TabIndex = 19;
            this.btRolesMove.Text = "Move";
            this.btRolesMove.UseVisualStyleBackColor = true;
            this.btRolesMove.Click += new System.EventHandler(this.btRolesMove_Click);
            // 
            // toRolesList
            // 
            this.toRolesList.FormattingEnabled = true;
            this.toRolesList.Location = new System.Drawing.Point(324, 35);
            this.toRolesList.Margin = new System.Windows.Forms.Padding(2);
            this.toRolesList.Name = "toRolesList";
            this.toRolesList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.toRolesList.Size = new System.Drawing.Size(184, 199);
            this.toRolesList.TabIndex = 18;
            // 
            // fromRolesList
            // 
            this.fromRolesList.DataSource = this.roleMSTBindingSource;
            this.fromRolesList.DisplayMember = "RoleName";
            this.fromRolesList.FormattingEnabled = true;
            this.fromRolesList.Location = new System.Drawing.Point(17, 35);
            this.fromRolesList.Margin = new System.Windows.Forms.Padding(2);
            this.fromRolesList.Name = "fromRolesList";
            this.fromRolesList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.fromRolesList.Size = new System.Drawing.Size(182, 199);
            this.fromRolesList.TabIndex = 17;
            this.fromRolesList.ValueMember = "RoleId";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Available Roles";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(482, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(113, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 21);
            this.comboBox1.TabIndex = 36;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Existing Users";
            // 
            // btAddToDatabase
            // 
            this.btAddToDatabase.Location = new System.Drawing.Point(257, 351);
            this.btAddToDatabase.Margin = new System.Windows.Forms.Padding(2);
            this.btAddToDatabase.Name = "btAddToDatabase";
            this.btAddToDatabase.Size = new System.Drawing.Size(76, 29);
            this.btAddToDatabase.TabIndex = 38;
            this.btAddToDatabase.Text = "Ok";
            this.btAddToDatabase.UseVisualStyleBackColor = true;
            this.btAddToDatabase.Click += new System.EventHandler(this.btAddToDatabase_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(113, 52);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(151, 21);
            this.comboBox2.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Department";
            // 
            // roleMSTTableAdapter
            // 
            this.roleMSTTableAdapter.ClearBeforeFill = true;
            // 
            // RolePrivileges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 397);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btAddToDatabase);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Name = "RolePrivileges";
            this.Text = "Role Privileges";
            this.Load += new System.EventHandler(this.Role_Modify_Privileges_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roleMSTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ldapDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btRolesRemoveAll;
        private System.Windows.Forms.Button btRolesRemove;
        private System.Windows.Forms.Button btRolesMoveAll;
        private System.Windows.Forms.Button btRolesMove;
        private System.Windows.Forms.ListBox toRolesList;
        private System.Windows.Forms.ListBox fromRolesList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAddToDatabase;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private LdapDataSet ldapDataSet;
        private System.Windows.Forms.BindingSource roleMSTBindingSource;
        private LdapDataSetTableAdapters.RoleMSTTableAdapter roleMSTTableAdapter;
    }
}