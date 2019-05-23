namespace CinemaSYS
{
    partial class frmYearlyRevenue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYearlyRevenue));
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.picReport = new System.Windows.Forms.PictureBox();
            this.grpReport = new System.Windows.Forms.GroupBox();
            this.btnPrintReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picReport)).BeginInit();
            this.grpReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(222, 12);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(166, 29);
            this.btnGenerateReport.TabIndex = 0;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // picReport
            // 
            this.picReport.Image = ((System.Drawing.Image)(resources.GetObject("picReport.Image")));
            this.picReport.Location = new System.Drawing.Point(43, 19);
            this.picReport.Name = "picReport";
            this.picReport.Size = new System.Drawing.Size(626, 358);
            this.picReport.TabIndex = 1;
            this.picReport.TabStop = false;
            // 
            // grpReport
            // 
            this.grpReport.Controls.Add(this.picReport);
            this.grpReport.Location = new System.Drawing.Point(36, 47);
            this.grpReport.Name = "grpReport";
            this.grpReport.Size = new System.Drawing.Size(727, 391);
            this.grpReport.TabIndex = 2;
            this.grpReport.TabStop = false;
            this.grpReport.Text = "Report";
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.Location = new System.Drawing.Point(394, 12);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(166, 29);
            this.btnPrintReport.TabIndex = 3;
            this.btnPrintReport.Text = "Print Report";
            this.btnPrintReport.UseVisualStyleBackColor = true;
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // frmYearlyRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrintReport);
            this.Controls.Add(this.grpReport);
            this.Controls.Add(this.btnGenerateReport);
            this.Name = "frmYearlyRevenue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yearly Revenue";
            this.Load += new System.EventHandler(this.frmYearlyRevenue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picReport)).EndInit();
            this.grpReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.PictureBox picReport;
        private System.Windows.Forms.GroupBox grpReport;
        private System.Windows.Forms.Button btnPrintReport;
    }
}