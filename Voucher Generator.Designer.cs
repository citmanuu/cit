namespace MANUUFinance
{
    partial class Voucher_Generator
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.deptNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bECYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKFYIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountBalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voucherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnVaucherPrint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toDate = new System.Windows.Forms.DateTimePicker();
            this.fromDate = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voucherBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deptNameDataGridViewTextBoxColumn,
            this.bECYDataGridViewTextBoxColumn,
            this.fKFYIDDataGridViewTextBoxColumn,
            this.accountBalanceDataGridViewTextBoxColumn,
            this.billAmountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.voucherBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(674, 213);
            this.dataGridView1.TabIndex = 0;
            // 
            // deptNameDataGridViewTextBoxColumn
            // 
            this.deptNameDataGridViewTextBoxColumn.DataPropertyName = "DeptName";
            this.deptNameDataGridViewTextBoxColumn.HeaderText = "DeptName";
            this.deptNameDataGridViewTextBoxColumn.Name = "deptNameDataGridViewTextBoxColumn";
            this.deptNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bECYDataGridViewTextBoxColumn
            // 
            this.bECYDataGridViewTextBoxColumn.DataPropertyName = "BECY";
            this.bECYDataGridViewTextBoxColumn.HeaderText = "BECY";
            this.bECYDataGridViewTextBoxColumn.Name = "bECYDataGridViewTextBoxColumn";
            this.bECYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fKFYIDDataGridViewTextBoxColumn
            // 
            this.fKFYIDDataGridViewTextBoxColumn.DataPropertyName = "FKFYID";
            this.fKFYIDDataGridViewTextBoxColumn.HeaderText = "FKFYID";
            this.fKFYIDDataGridViewTextBoxColumn.Name = "fKFYIDDataGridViewTextBoxColumn";
            this.fKFYIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountBalanceDataGridViewTextBoxColumn
            // 
            this.accountBalanceDataGridViewTextBoxColumn.DataPropertyName = "AccountBalance";
            this.accountBalanceDataGridViewTextBoxColumn.HeaderText = "AccountBalance";
            this.accountBalanceDataGridViewTextBoxColumn.Name = "accountBalanceDataGridViewTextBoxColumn";
            this.accountBalanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // billAmountDataGridViewTextBoxColumn
            // 
            this.billAmountDataGridViewTextBoxColumn.DataPropertyName = "BillAmount";
            this.billAmountDataGridViewTextBoxColumn.HeaderText = "BillAmount";
            this.billAmountDataGridViewTextBoxColumn.Name = "billAmountDataGridViewTextBoxColumn";
            this.billAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // voucherBindingSource
            // 
            this.voucherBindingSource.DataSource = typeof(MANUUFinance.Voucher);
            // 
            // btnVaucherPrint
            // 
            this.btnVaucherPrint.Location = new System.Drawing.Point(608, 307);
            this.btnVaucherPrint.Name = "btnVaucherPrint";
            this.btnVaucherPrint.Size = new System.Drawing.Size(88, 23);
            this.btnVaucherPrint.TabIndex = 1;
            this.btnVaucherPrint.Text = "Voucher Print";
            this.btnVaucherPrint.UseVisualStyleBackColor = true;
            this.btnVaucherPrint.Click += new System.EventHandler(this.btnVaucherPrint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bill Number";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.toDate);
            this.groupBox1.Controls.Add(this.fromDate);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 63);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // toDate
            // 
            this.toDate.Location = new System.Drawing.Point(354, 10);
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(199, 20);
            this.toDate.TabIndex = 5;
            // 
            // fromDate
            // 
            this.fromDate.Location = new System.Drawing.Point(78, 11);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(199, 20);
            this.fromDate.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "To Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "From Date";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(600, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 58);
            this.button1.TabIndex = 4;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Voucher_Generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 348);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVaucherPrint);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Voucher_Generator";
            this.Text = "Voucher_Generator";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voucherBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnVaucherPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker toDate;
        private System.Windows.Forms.DateTimePicker fromDate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bECYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKFYIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountBalanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource voucherBindingSource;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}