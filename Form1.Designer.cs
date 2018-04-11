namespace MANUUFinance
{
    partial class pdfsupports
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SL1Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL2Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BankName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BankAccountType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PKACID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FKSL1ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FKBankAccountID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL1ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PKSL2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL3Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SL1Name,
            this.SL2Name,
            this.SL3,
            this.AcOrder,
            this.AcActive,
            this.AccountName,
            this.BankName,
            this.BankAccountType,
            this.AccountNumber,
            this.AccountType,
            this.PKACID,
            this.FKSL1ID,
            this.FKBankAccountID,
            this.SL1ID,
            this.PKSL2,
            this.SL3Code});
            this.dataGridView1.Location = new System.Drawing.Point(12, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(782, 150);
            this.dataGridView1.TabIndex = 0;
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
            // SL3
            // 
            this.SL3.DataPropertyName = "SL3Name";
            this.SL3.HeaderText = "SL3Name";
            this.SL3.Name = "SL3";
            this.SL3.ReadOnly = true;
            // 
            // AcOrder
            // 
            this.AcOrder.DataPropertyName = "AcOrder";
            this.AcOrder.HeaderText = "Order";
            this.AcOrder.Name = "AcOrder";
            this.AcOrder.ReadOnly = true;
            // 
            // AcActive
            // 
            this.AcActive.DataPropertyName = "AcActive";
            this.AcActive.HeaderText = "Active";
            this.AcActive.Name = "AcActive";
            this.AcActive.ReadOnly = true;
            // 
            // AccountName
            // 
            this.AccountName.DataPropertyName = "AccountName";
            this.AccountName.HeaderText = "AccountName";
            this.AccountName.Name = "AccountName";
            this.AccountName.ReadOnly = true;
            // 
            // BankName
            // 
            this.BankName.DataPropertyName = "BankName";
            this.BankName.HeaderText = "BankName";
            this.BankName.Name = "BankName";
            this.BankName.ReadOnly = true;
            // 
            // BankAccountType
            // 
            this.BankAccountType.DataPropertyName = "BankAccountType";
            this.BankAccountType.HeaderText = "BankAccountType";
            this.BankAccountType.Name = "BankAccountType";
            this.BankAccountType.ReadOnly = true;
            // 
            // AccountNumber
            // 
            this.AccountNumber.DataPropertyName = "AccountNumber";
            this.AccountNumber.HeaderText = "AccountNumber";
            this.AccountNumber.Name = "AccountNumber";
            this.AccountNumber.ReadOnly = true;
            // 
            // AccountType
            // 
            this.AccountType.DataPropertyName = "AccountType";
            this.AccountType.HeaderText = "AccountType";
            this.AccountType.Name = "AccountType";
            this.AccountType.ReadOnly = true;
            // 
            // PKACID
            // 
            this.PKACID.DataPropertyName = "PKACID";
            this.PKACID.HeaderText = "PKACID";
            this.PKACID.Name = "PKACID";
            this.PKACID.ReadOnly = true;
            this.PKACID.Visible = false;
            // 
            // FKSL1ID
            // 
            this.FKSL1ID.DataPropertyName = "FKSL3ID";
            this.FKSL1ID.HeaderText = "FKSL1ID";
            this.FKSL1ID.Name = "FKSL1ID";
            this.FKSL1ID.ReadOnly = true;
            this.FKSL1ID.Visible = false;
            // 
            // FKBankAccountID
            // 
            this.FKBankAccountID.DataPropertyName = "FKBankAccountID";
            this.FKBankAccountID.HeaderText = "FKBankAccountID";
            this.FKBankAccountID.Name = "FKBankAccountID";
            this.FKBankAccountID.ReadOnly = true;
            this.FKBankAccountID.Visible = false;
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
            // SL3Code
            // 
            this.SL3Code.DataPropertyName = "SL3Code";
            this.SL3Code.HeaderText = "SL3Code";
            this.SL3Code.Name = "SL3Code";
            this.SL3Code.ReadOnly = true;
            this.SL3Code.Visible = false;
            // 
            // pdfsupports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 384);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "pdfsupports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demonstration";
            this.Load += new System.EventHandler(this.pdfsupports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL1Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL2Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL3;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankAccountType;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountType;
        private System.Windows.Forms.DataGridViewTextBoxColumn PKACID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FKSL1ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FKBankAccountID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL1ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PKSL2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL3Code;
    }
}