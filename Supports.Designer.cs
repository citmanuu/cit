namespace MANUUFinance
{
    partial class Supports
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
            this.generatePDF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // generatePDF
            // 
            this.generatePDF.ForeColor = System.Drawing.Color.Maroon;
            this.generatePDF.Location = new System.Drawing.Point(223, 173);
            this.generatePDF.Name = "generatePDF";
            this.generatePDF.Size = new System.Drawing.Size(75, 23);
            this.generatePDF.TabIndex = 0;
            this.generatePDF.Text = "Create PDF";
            this.generatePDF.UseVisualStyleBackColor = true;
            this.generatePDF.Click += new System.EventHandler(this.generatePDF_Click);
            // 
            // Supports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 216);
            this.Controls.Add(this.generatePDF);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Supports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Please select the Column";
            this.Load += new System.EventHandler(this.Supports_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button generatePDF;
    }
}