namespace MANUUFinance
{
    partial class Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forms));
            this.DGVForm = new System.Windows.Forms.DataGridView();
            this.formIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formMSTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btClearRecord = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFormNameSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.financeDataSet1 = new MANUUFinance.FinanceDataSet1();
            this.formMSTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.formMSTTableAdapter1 = new MANUUFinance.FinanceDataSet1TableAdapters.FormMSTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DGVForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formMSTBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formMSTBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVForm
            // 
            this.DGVForm.AllowUserToAddRows = false;
            this.DGVForm.AllowUserToDeleteRows = false;
            this.DGVForm.AutoGenerateColumns = false;
            this.DGVForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.formIdDataGridViewTextBoxColumn,
            this.formNameDataGridViewTextBoxColumn,
            this.formDescriptionDataGridViewTextBoxColumn});
            this.DGVForm.DataSource = this.formMSTBindingSource1;
            this.DGVForm.Location = new System.Drawing.Point(29, 319);
            this.DGVForm.Name = "DGVForm";
            this.DGVForm.ReadOnly = true;
            this.DGVForm.Size = new System.Drawing.Size(518, 169);
            this.DGVForm.TabIndex = 17;
            this.DGVForm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVFrom_CellContentClick);
            // 
            // formIdDataGridViewTextBoxColumn
            // 
            this.formIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.formIdDataGridViewTextBoxColumn.DataPropertyName = "FormId";
            this.formIdDataGridViewTextBoxColumn.FillWeight = 5F;
            this.formIdDataGridViewTextBoxColumn.HeaderText = "FormId";
            this.formIdDataGridViewTextBoxColumn.Name = "formIdDataGridViewTextBoxColumn";
            this.formIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.formIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // formNameDataGridViewTextBoxColumn
            // 
            this.formNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.formNameDataGridViewTextBoxColumn.DataPropertyName = "FormName";
            this.formNameDataGridViewTextBoxColumn.HeaderText = "FormName";
            this.formNameDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.formNameDataGridViewTextBoxColumn.Name = "formNameDataGridViewTextBoxColumn";
            this.formNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // formDescriptionDataGridViewTextBoxColumn
            // 
            this.formDescriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.formDescriptionDataGridViewTextBoxColumn.DataPropertyName = "FormDescription";
            this.formDescriptionDataGridViewTextBoxColumn.HeaderText = "FormDescription";
            this.formDescriptionDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.formDescriptionDataGridViewTextBoxColumn.Name = "formDescriptionDataGridViewTextBoxColumn";
            this.formDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // formMSTBindingSource
            // 
            this.formMSTBindingSource.DataMember = "FormMST";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Description";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(36, 98);
            this.richTextBox1.MaxLength = 250;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(344, 121);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btClearRecord);
            this.groupBox2.Controls.Add(this.btnExit);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox2.Location = new System.Drawing.Point(31, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(821, 47);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // btClearRecord
            // 
            this.btClearRecord.Location = new System.Drawing.Point(316, 12);
            this.btClearRecord.Name = "btClearRecord";
            this.btClearRecord.Size = new System.Drawing.Size(97, 28);
            this.btClearRecord.TabIndex = 7;
            this.btClearRecord.Text = "Clear Record";
            this.btClearRecord.UseVisualStyleBackColor = true;
            this.btClearRecord.Click += new System.EventHandler(this.btClearRecord_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(419, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(97, 28);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(213, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 28);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete Record";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(110, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(97, 28);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update Record";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(7, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 28);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add Record";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Enter FormName";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(249, 20);
            this.textBox1.TabIndex = 11;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtFormNameSearch);
            this.groupBox4.Controls.Add(this.btnSearch);
            this.groupBox4.Controls.Add(this.btnClearSearch);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox4.Location = new System.Drawing.Point(566, 314);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(286, 174);
            this.groupBox4.TabIndex = 26;
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
            // txtFormNameSearch
            // 
            this.txtFormNameSearch.Location = new System.Drawing.Point(12, 49);
            this.txtFormNameSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtFormNameSearch.Name = "txtFormNameSearch";
            this.txtFormNameSearch.Size = new System.Drawing.Size(225, 20);
            this.txtFormNameSearch.TabIndex = 4;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(290, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(93, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(469, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(379, 158);
            this.label4.TabIndex = 45;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // financeDataSet1
            // 
            this.financeDataSet1.DataSetName = "FinanceDataSet1";
            this.financeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // formMSTBindingSource1
            // 
            this.formMSTBindingSource1.DataMember = "FormMST";
            this.formMSTBindingSource1.DataSource = this.financeDataSet1;
            // 
            // formMSTTableAdapter1
            // 
            this.formMSTTableAdapter1.ClearBeforeFill = true;
            // 
            // Forms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 516);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.DGVForm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Name = "Forms";
            this.Text = "Forms";
            this.Load += new System.EventHandler(this.AddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formMSTBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formMSTBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVForm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtFormNameSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClearSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource formMSTBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btClearRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn formIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private FinanceDataSet1 financeDataSet1;
        private System.Windows.Forms.BindingSource formMSTBindingSource1;
        private FinanceDataSet1TableAdapters.FormMSTTableAdapter formMSTTableAdapter1;
    }
}