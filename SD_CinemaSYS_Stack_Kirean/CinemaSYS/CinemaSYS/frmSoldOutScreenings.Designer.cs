namespace CinemaSYS
{
    partial class frmSoldOutScreenings
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
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.btnPrintReport = new System.Windows.Forms.Button();
            this.grpReport = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(194, 12);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(166, 29);
            this.btnGenerateReport.TabIndex = 1;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.Location = new System.Drawing.Point(366, 12);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(166, 29);
            this.btnPrintReport.TabIndex = 4;
            this.btnPrintReport.Text = "Print Report";
            this.btnPrintReport.UseVisualStyleBackColor = true;
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // grpReport
            // 
            this.grpReport.Location = new System.Drawing.Point(28, 47);
            this.grpReport.Name = "grpReport";
            this.grpReport.Size = new System.Drawing.Size(727, 391);
            this.grpReport.TabIndex = 5;
            this.grpReport.TabStop = false;
            this.grpReport.Text = "Report";
            // 
            // frmSoldOutScreenings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpReport);
            this.Controls.Add(this.btnPrintReport);
            this.Controls.Add(this.btnGenerateReport);
            this.Name = "frmSoldOutScreenings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sold Out Screenings";
            this.Load += new System.EventHandler(this.frmSoldOutScreenings_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Button btnPrintReport;
        private System.Windows.Forms.GroupBox grpReport;
    }
}