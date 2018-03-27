namespace MANUUFinance
{
    partial class ManagePrivilege
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.managePrivilegesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentPrivilegesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolePrivilegesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.privilegeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managePrivilegesToolStripMenuItem,
            this.privilegeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(774, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // managePrivilegesToolStripMenuItem
            // 
            this.managePrivilegesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departmentPrivilegesToolStripMenuItem,
            this.rolePrivilegesToolStripMenuItem});
            this.managePrivilegesToolStripMenuItem.Name = "managePrivilegesToolStripMenuItem";
            this.managePrivilegesToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.managePrivilegesToolStripMenuItem.Text = "Modifye Privileges";
            // 
            // departmentPrivilegesToolStripMenuItem
            // 
            this.departmentPrivilegesToolStripMenuItem.Name = "departmentPrivilegesToolStripMenuItem";
            this.departmentPrivilegesToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.departmentPrivilegesToolStripMenuItem.Text = "Department Privileges";
            this.departmentPrivilegesToolStripMenuItem.Click += new System.EventHandler(this.departmentPrivilegesToolStripMenuItem_Click);
            // 
            // rolePrivilegesToolStripMenuItem
            // 
            this.rolePrivilegesToolStripMenuItem.Name = "rolePrivilegesToolStripMenuItem";
            this.rolePrivilegesToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.rolePrivilegesToolStripMenuItem.Text = "Role Privileges";
            this.rolePrivilegesToolStripMenuItem.Click += new System.EventHandler(this.rolePrivilegesToolStripMenuItem_Click);
            // 
            // privilegeToolStripMenuItem
            // 
            this.privilegeToolStripMenuItem.Name = "privilegeToolStripMenuItem";
            this.privilegeToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.privilegeToolStripMenuItem.Text = "Add Privilege";
            this.privilegeToolStripMenuItem.Click += new System.EventHandler(this.privilegeToolStripMenuItem_Click);
            // 
            // ManagePrivilege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ManagePrivilege";
            this.Text = "Manage Privilege";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem privilegeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managePrivilegesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentPrivilegesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolePrivilegesToolStripMenuItem;
    }
}