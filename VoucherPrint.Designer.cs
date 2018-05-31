namespace MANUUFinance
{
    partial class VoucherPrint
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.VoucherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportView = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.VoucherBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportView
            // 
            this.ReportView.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.VoucherBindingSource;
            this.ReportView.LocalReport.DataSources.Add(reportDataSource1);
            this.ReportView.LocalReport.ReportEmbeddedResource = "MANUUFinance.BillVoucher.rdlc";
            this.ReportView.Location = new System.Drawing.Point(0, 0);
            this.ReportView.Name = "ReportView";
            this.ReportView.ServerReport.BearerToken = null;
            this.ReportView.Size = new System.Drawing.Size(829, 350);
            this.ReportView.TabIndex = 1;
            // 
            // VoucherPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 350);
            this.Controls.Add(this.ReportView);
            this.Name = "VoucherPrint";
            this.Text = "VoucherPrint";
            ((System.ComponentModel.ISupportInitialize)(this.VoucherBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer ReportView;
        private System.Windows.Forms.BindingSource VoucherBindingSource;
    }
}