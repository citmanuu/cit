namespace MANUUFinance
{
    partial class TestUpdate
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dropdown_sheet = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.open = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.SrID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistrationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RollNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Standard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.testingExcellBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.financeDataSet5 = new MANUUFinance.FinanceDataSet5();
            this.btnExport = new System.Windows.Forms.Button();
            this.testingExcellTableAdapter = new MANUUFinance.FinanceDataSet5TableAdapters.testingExcellTableAdapter();
            this.financeDataSet1 = new MANUUFinance.FinanceDataSet();
            this.testingExcellBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.testingExcellBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtExport = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testingExcellBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testingExcellBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testingExcellBindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dropdown_sheet
            // 
            this.dropdown_sheet.FormattingEnabled = true;
            this.dropdown_sheet.Location = new System.Drawing.Point(517, 43);
            this.dropdown_sheet.Name = "dropdown_sheet";
            this.dropdown_sheet.Size = new System.Drawing.Size(136, 21);
            this.dropdown_sheet.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(476, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sheet";
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(36, 41);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(109, 23);
            this.open.TabIndex = 7;
            this.open.Text = "Open";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(659, 41);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(109, 23);
            this.Load.TabIndex = 6;
            this.Load.Text = "Import";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SrID,
            this.RegistrationID,
            this.Student,
            this.RollNumber,
            this.Standard});
            this.dataGridView.Location = new System.Drawing.Point(36, 154);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(733, 150);
            this.dataGridView.TabIndex = 11;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // SrID
            // 
            this.SrID.DataPropertyName = "SrID";
            this.SrID.HeaderText = "SrID";
            this.SrID.Name = "SrID";
            this.SrID.ReadOnly = true;
            // 
            // RegistrationID
            // 
            this.RegistrationID.DataPropertyName = "RegistrationID";
            this.RegistrationID.HeaderText = "RegistrationID";
            this.RegistrationID.Name = "RegistrationID";
            this.RegistrationID.ReadOnly = true;
            // 
            // Student
            // 
            this.Student.DataPropertyName = "Student";
            this.Student.HeaderText = "Student";
            this.Student.Name = "Student";
            this.Student.ReadOnly = true;
            // 
            // RollNumber
            // 
            this.RollNumber.DataPropertyName = "RollNumber";
            this.RollNumber.HeaderText = "RollNumber";
            this.RollNumber.Name = "RollNumber";
            this.RollNumber.ReadOnly = true;
            // 
            // Standard
            // 
            this.Standard.DataPropertyName = "Standard";
            this.Standard.HeaderText = "Standard";
            this.Standard.Name = "Standard";
            this.Standard.ReadOnly = true;
            // 
            // tb_path
            // 
            this.tb_path.Location = new System.Drawing.Point(153, 42);
            this.tb_path.Name = "tb_path";
            this.tb_path.Size = new System.Drawing.Size(317, 20);
            this.tb_path.TabIndex = 8;
            // 
            // testingExcellBindingSource
            // 
            this.testingExcellBindingSource.DataMember = "testingExcell";
            this.testingExcellBindingSource.DataSource = this.financeDataSet5;
            // 
            // financeDataSet5
            // 
            this.financeDataSet5.DataSetName = "FinanceDataSet5";
            this.financeDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(215, 22);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(109, 23);
            this.btnExport.TabIndex = 13;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // testingExcellTableAdapter
            // 
            this.testingExcellTableAdapter.ClearBeforeFill = true;
            // 
            // financeDataSet1
            // 
            this.financeDataSet1.DataSetName = "FinanceDataSet";
            this.financeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testingExcellBindingSource2
            // 
            this.testingExcellBindingSource2.DataMember = "testingExcell";
            this.testingExcellBindingSource2.DataSource = this.financeDataSet5;
            // 
            // testingExcellBindingSource1
            // 
            this.testingExcellBindingSource1.DataMember = "testingExcell";
            this.testingExcellBindingSource1.DataSource = this.financeDataSet5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Enter Sheet Name";
            // 
            // txtExport
            // 
            this.txtExport.Location = new System.Drawing.Point(107, 22);
            this.txtExport.Name = "txtExport";
            this.txtExport.Size = new System.Drawing.Size(102, 20);
            this.txtExport.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtExport);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnExport);
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(438, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 55);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Export";
            // 
            // TestUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 336);
            this.Controls.Add(this.dropdown_sheet);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.tb_path);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.open);
            this.Name = "TestUpdate";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testingExcellBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testingExcellBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testingExcellBindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox dropdown_sheet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student;
        private System.Windows.Forms.DataGridViewTextBoxColumn RollNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Standard;
        private System.Windows.Forms.Button btnExport;
        private FinanceDataSet5 financeDataSet5;
        private System.Windows.Forms.BindingSource testingExcellBindingSource;
        private FinanceDataSet5TableAdapters.testingExcellTableAdapter testingExcellTableAdapter;
        private FinanceDataSet financeDataSet1;
        private System.Windows.Forms.BindingSource testingExcellBindingSource1;
        private System.Windows.Forms.BindingSource testingExcellBindingSource2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtExport;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}