namespace MANUUFinance
{
    partial class FreeUpdatecs
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.BillerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BankId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BankRefNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PGIRefNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ref1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ref2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ref3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ref4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ref5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ref6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ref7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ref8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateofTxn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BillerId,
            this.BankId,
            this.BankRefNo,
            this.PGIRefNo,
            this.Ref1,
            this.Ref2,
            this.Ref3,
            this.Ref4,
            this.Ref5,
            this.Ref6,
            this.Ref7,
            this.Ref8,
            this.DateofTxn,
            this.Amount,
            this.Status});
            this.dataGridView.Location = new System.Drawing.Point(73, 154);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(601, 150);
            this.dataGridView.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(599, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BillerId
            // 
            this.BillerId.HeaderText = "BillerId";
            this.BillerId.Name = "BillerId";
            this.BillerId.ReadOnly = true;
            // 
            // BankId
            // 
            this.BankId.HeaderText = "BankId";
            this.BankId.Name = "BankId";
            this.BankId.ReadOnly = true;
            // 
            // BankRefNo
            // 
            this.BankRefNo.HeaderText = "BankRefNo";
            this.BankRefNo.Name = "BankRefNo";
            this.BankRefNo.ReadOnly = true;
            // 
            // PGIRefNo
            // 
            this.PGIRefNo.HeaderText = "PGIRefNo";
            this.PGIRefNo.Name = "PGIRefNo";
            this.PGIRefNo.ReadOnly = true;
            // 
            // Ref1
            // 
            this.Ref1.HeaderText = "Ref1";
            this.Ref1.Name = "Ref1";
            this.Ref1.ReadOnly = true;
            // 
            // Ref2
            // 
            this.Ref2.HeaderText = "Ref2";
            this.Ref2.Name = "Ref2";
            this.Ref2.ReadOnly = true;
            // 
            // Ref3
            // 
            this.Ref3.HeaderText = "Ref3";
            this.Ref3.Name = "Ref3";
            this.Ref3.ReadOnly = true;
            // 
            // Ref4
            // 
            this.Ref4.HeaderText = "Ref4";
            this.Ref4.Name = "Ref4";
            this.Ref4.ReadOnly = true;
            // 
            // Ref5
            // 
            this.Ref5.HeaderText = "Ref5";
            this.Ref5.Name = "Ref5";
            this.Ref5.ReadOnly = true;
            // 
            // Ref6
            // 
            this.Ref6.HeaderText = "Ref6";
            this.Ref6.Name = "Ref6";
            this.Ref6.ReadOnly = true;
            // 
            // Ref7
            // 
            this.Ref7.HeaderText = "Ref7";
            this.Ref7.Name = "Ref7";
            this.Ref7.ReadOnly = true;
            // 
            // Ref8
            // 
            this.Ref8.HeaderText = "Ref8";
            this.Ref8.Name = "Ref8";
            this.Ref8.ReadOnly = true;
            // 
            // DateofTxn
            // 
            this.DateofTxn.HeaderText = "DateofTxn";
            this.DateofTxn.Name = "DateofTxn";
            this.DateofTxn.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // FreeUpdatecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView);
            this.Name = "FreeUpdatecs";
            this.Text = "FreeUpdatecs";
            this.Load += new System.EventHandler(this.FreeUpdatecs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankRefNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PGIRefNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ref1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ref2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ref3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ref4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ref5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ref6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ref7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ref8;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateofTxn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}