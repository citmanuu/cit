namespace MANUUFinance
{
    partial class EnableDisableHeads
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
            this.DGVVH = new System.Windows.Forms.DataGridView();
            this.vHMstBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.financeDataSet7 = new MANUUFinance.FinanceDataSet7();
            this.radioActive = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioDeactive = new System.Windows.Forms.RadioButton();
            this.vHMstTableAdapter = new MANUUFinance.FinanceDataSet7TableAdapters.VHMstTableAdapter();
            this.SAVE = new System.Windows.Forms.Button();
            this.vHIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vHNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.vHAddedOnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vHUpdatedOnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vHUpdatedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVVH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vHMstBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet7)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVVH
            // 
            this.DGVVH.AllowUserToOrderColumns = true;
            this.DGVVH.AutoGenerateColumns = false;
            this.DGVVH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVVH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vHIDDataGridViewTextBoxColumn,
            this.vHNAMEDataGridViewTextBoxColumn,
            this.isActiveDataGridViewCheckBoxColumn,
            this.vHAddedOnDataGridViewTextBoxColumn,
            this.vHUpdatedOnDataGridViewTextBoxColumn,
            this.vHUpdatedByDataGridViewTextBoxColumn});
            this.DGVVH.DataSource = this.vHMstBindingSource;
            this.DGVVH.Location = new System.Drawing.Point(11, 21);
            this.DGVVH.Name = "DGVVH";
            this.DGVVH.Size = new System.Drawing.Size(240, 171);
            this.DGVVH.TabIndex = 0;
            this.DGVVH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVVH_CellContentClick);
            // 
            // vHMstBindingSource
            // 
            this.vHMstBindingSource.DataMember = "VHMst";
            this.vHMstBindingSource.DataSource = this.financeDataSet7;
            // 
            // financeDataSet7
            // 
            this.financeDataSet7.DataSetName = "FinanceDataSet7";
            this.financeDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radioActive
            // 
            this.radioActive.AutoSize = true;
            this.radioActive.Location = new System.Drawing.Point(23, 19);
            this.radioActive.Name = "radioActive";
            this.radioActive.Size = new System.Drawing.Size(55, 17);
            this.radioActive.TabIndex = 1;
            this.radioActive.TabStop = true;
            this.radioActive.Text = "Active";
            this.radioActive.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioDeactive);
            this.groupBox1.Controls.Add(this.radioActive);
            this.groupBox1.Location = new System.Drawing.Point(270, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 85);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // radioDeactive
            // 
            this.radioDeactive.AutoSize = true;
            this.radioDeactive.Location = new System.Drawing.Point(23, 42);
            this.radioDeactive.Name = "radioDeactive";
            this.radioDeactive.Size = new System.Drawing.Size(68, 17);
            this.radioDeactive.TabIndex = 2;
            this.radioDeactive.TabStop = true;
            this.radioDeactive.Text = "Deactive";
            this.radioDeactive.UseVisualStyleBackColor = true;
            // 
            // vHMstTableAdapter
            // 
            this.vHMstTableAdapter.ClearBeforeFill = true;
            // 
            // SAVE
            // 
            this.SAVE.Location = new System.Drawing.Point(326, 169);
            this.SAVE.Name = "SAVE";
            this.SAVE.Size = new System.Drawing.Size(75, 23);
            this.SAVE.TabIndex = 3;
            this.SAVE.Text = "Save";
            this.SAVE.UseVisualStyleBackColor = true;
            this.SAVE.Click += new System.EventHandler(this.SAVE_Click);
            // 
            // vHIDDataGridViewTextBoxColumn
            // 
            this.vHIDDataGridViewTextBoxColumn.DataPropertyName = "VHID";
            this.vHIDDataGridViewTextBoxColumn.HeaderText = "VHID";
            this.vHIDDataGridViewTextBoxColumn.Name = "vHIDDataGridViewTextBoxColumn";
            this.vHIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vHNAMEDataGridViewTextBoxColumn
            // 
            this.vHNAMEDataGridViewTextBoxColumn.DataPropertyName = "VHNAME";
            this.vHNAMEDataGridViewTextBoxColumn.HeaderText = "VHNAME";
            this.vHNAMEDataGridViewTextBoxColumn.Name = "vHNAMEDataGridViewTextBoxColumn";
            this.vHNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "isActive";
            this.isActiveDataGridViewCheckBoxColumn.HeaderText = "isActive";
            this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            this.isActiveDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // vHAddedOnDataGridViewTextBoxColumn
            // 
            this.vHAddedOnDataGridViewTextBoxColumn.DataPropertyName = "VHAddedOn";
            this.vHAddedOnDataGridViewTextBoxColumn.HeaderText = "VHAddedOn";
            this.vHAddedOnDataGridViewTextBoxColumn.Name = "vHAddedOnDataGridViewTextBoxColumn";
            this.vHAddedOnDataGridViewTextBoxColumn.ReadOnly = true;
            this.vHAddedOnDataGridViewTextBoxColumn.Visible = false;
            // 
            // vHUpdatedOnDataGridViewTextBoxColumn
            // 
            this.vHUpdatedOnDataGridViewTextBoxColumn.DataPropertyName = "VHUpdatedOn";
            this.vHUpdatedOnDataGridViewTextBoxColumn.HeaderText = "VHUpdatedOn";
            this.vHUpdatedOnDataGridViewTextBoxColumn.Name = "vHUpdatedOnDataGridViewTextBoxColumn";
            this.vHUpdatedOnDataGridViewTextBoxColumn.ReadOnly = true;
            this.vHUpdatedOnDataGridViewTextBoxColumn.Visible = false;
            // 
            // vHUpdatedByDataGridViewTextBoxColumn
            // 
            this.vHUpdatedByDataGridViewTextBoxColumn.DataPropertyName = "VHUpdatedBy";
            this.vHUpdatedByDataGridViewTextBoxColumn.HeaderText = "VHUpdatedBy";
            this.vHUpdatedByDataGridViewTextBoxColumn.Name = "vHUpdatedByDataGridViewTextBoxColumn";
            this.vHUpdatedByDataGridViewTextBoxColumn.ReadOnly = true;
            this.vHUpdatedByDataGridViewTextBoxColumn.Visible = false;
            // 
            // EnableDisableHeads
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 204);
            this.Controls.Add(this.SAVE);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DGVVH);
            this.MinimizeBox = false;
            this.Name = "EnableDisableHeads";
            this.Text = "EnableDisableHeads";
            this.Load += new System.EventHandler(this.EnableDisableHeads_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVVH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vHMstBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet7)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVVH;
        private System.Windows.Forms.RadioButton radioActive;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioDeactive;
        private FinanceDataSet7 financeDataSet7;
        private System.Windows.Forms.BindingSource vHMstBindingSource;
        private FinanceDataSet7TableAdapters.VHMstTableAdapter vHMstTableAdapter;
        private System.Windows.Forms.Button SAVE;
        private System.Windows.Forms.DataGridViewTextBoxColumn vHIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vHNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vHAddedOnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vHUpdatedOnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vHUpdatedByDataGridViewTextBoxColumn;
    }
}