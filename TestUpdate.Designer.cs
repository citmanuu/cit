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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dropdown_sheet = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.open = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dropdown_sheet
            // 
            this.dropdown_sheet.FormattingEnabled = true;
            this.dropdown_sheet.Location = new System.Drawing.Point(525, 104);
            this.dropdown_sheet.Name = "dropdown_sheet";
            this.dropdown_sheet.Size = new System.Drawing.Size(102, 21);
            this.dropdown_sheet.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(484, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sheet";
            // 
            // tb_path
            // 
            this.tb_path.Location = new System.Drawing.Point(174, 105);
            this.tb_path.Name = "tb_path";
            this.tb_path.Size = new System.Drawing.Size(278, 20);
            this.tb_path.TabIndex = 8;
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(57, 104);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(111, 21);
            this.open.TabIndex = 7;
            this.open.Text = "Open";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(633, 102);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(109, 23);
            this.Load.TabIndex = 6;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(57, 159);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(685, 150);
            this.dataGridView.TabIndex = 11;
            // 
            // TestUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.dropdown_sheet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_path);
            this.Controls.Add(this.open);
            this.Controls.Add(this.Load);
            this.Name = "TestUpdate";
            this.Text = "TestUpdate";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox dropdown_sheet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}