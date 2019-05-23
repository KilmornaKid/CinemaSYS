namespace CinemaSYS
{
    partial class frmRemoveScreening
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
            this.grpSelectScreening = new System.Windows.Forms.GroupBox();
            this.cboSelectScreening = new System.Windows.Forms.ComboBox();
            this.lblSelectScreeningNumber = new System.Windows.Forms.Label();
            this.grpScheduleScreening = new System.Windows.Forms.GroupBox();
            this.cboTimes = new System.Windows.Forms.ComboBox();
            this.txtScreeningNumber = new System.Windows.Forms.TextBox();
            this.txtseatsAvailable = new System.Windows.Forms.TextBox();
            this.txtMaxSeats = new System.Windows.Forms.TextBox();
            this.cboMovieId = new System.Windows.Forms.ComboBox();
            this.lblMovieId = new System.Windows.Forms.Label();
            this.cboScreenNo = new System.Windows.Forms.ComboBox();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.btnRemoveScreening = new System.Windows.Forms.Button();
            this.lblScreenNo = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.grpSelectScreening.SuspendLayout();
            this.grpScheduleScreening.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSelectScreening
            // 
            this.grpSelectScreening.Controls.Add(this.cboSelectScreening);
            this.grpSelectScreening.Controls.Add(this.lblSelectScreeningNumber);
            this.grpSelectScreening.Location = new System.Drawing.Point(35, 12);
            this.grpSelectScreening.Name = "grpSelectScreening";
            this.grpSelectScreening.Size = new System.Drawing.Size(710, 120);
            this.grpSelectScreening.TabIndex = 2;
            this.grpSelectScreening.TabStop = false;
            this.grpSelectScreening.Text = "Select Screening";
            // 
            // cboSelectScreening
            // 
            this.cboSelectScreening.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectScreening.FormattingEnabled = true;
            this.cboSelectScreening.Location = new System.Drawing.Point(165, 44);
            this.cboSelectScreening.Name = "cboSelectScreening";
            this.cboSelectScreening.Size = new System.Drawing.Size(221, 21);
            this.cboSelectScreening.TabIndex = 3;
            this.cboSelectScreening.SelectedIndexChanged += new System.EventHandler(this.cboSelectScreening_SelectedIndexChanged);
            // 
            // lblSelectScreeningNumber
            // 
            this.lblSelectScreeningNumber.AutoSize = true;
            this.lblSelectScreeningNumber.Location = new System.Drawing.Point(31, 47);
            this.lblSelectScreeningNumber.Name = "lblSelectScreeningNumber";
            this.lblSelectScreeningNumber.Size = new System.Drawing.Size(128, 13);
            this.lblSelectScreeningNumber.TabIndex = 0;
            this.lblSelectScreeningNumber.Text = "Select Screening Number";
            // 
            // grpScheduleScreening
            // 
            this.grpScheduleScreening.Controls.Add(this.cboTimes);
            this.grpScheduleScreening.Controls.Add(this.txtScreeningNumber);
            this.grpScheduleScreening.Controls.Add(this.txtseatsAvailable);
            this.grpScheduleScreening.Controls.Add(this.txtMaxSeats);
            this.grpScheduleScreening.Controls.Add(this.cboMovieId);
            this.grpScheduleScreening.Controls.Add(this.lblMovieId);
            this.grpScheduleScreening.Controls.Add(this.cboScreenNo);
            this.grpScheduleScreening.Controls.Add(this.dtpDateTo);
            this.grpScheduleScreening.Controls.Add(this.dtpDateFrom);
            this.grpScheduleScreening.Controls.Add(this.btnRemoveScreening);
            this.grpScheduleScreening.Controls.Add(this.lblScreenNo);
            this.grpScheduleScreening.Controls.Add(this.lblTime);
            this.grpScheduleScreening.Controls.Add(this.lblDateTo);
            this.grpScheduleScreening.Controls.Add(this.lblDateFrom);
            this.grpScheduleScreening.Location = new System.Drawing.Point(35, 147);
            this.grpScheduleScreening.Name = "grpScheduleScreening";
            this.grpScheduleScreening.Size = new System.Drawing.Size(710, 295);
            this.grpScheduleScreening.TabIndex = 4;
            this.grpScheduleScreening.TabStop = false;
            this.grpScheduleScreening.Text = "Schedule Screening";
            // 
            // cboTimes
            // 
            this.cboTimes.Enabled = false;
            this.cboTimes.FormattingEnabled = true;
            this.cboTimes.Location = new System.Drawing.Point(99, 128);
            this.cboTimes.Name = "cboTimes";
            this.cboTimes.Size = new System.Drawing.Size(200, 21);
            this.cboTimes.TabIndex = 20;
            // 
            // txtScreeningNumber
            // 
            this.txtScreeningNumber.Enabled = false;
            this.txtScreeningNumber.Location = new System.Drawing.Point(432, 43);
            this.txtScreeningNumber.Name = "txtScreeningNumber";
            this.txtScreeningNumber.Size = new System.Drawing.Size(100, 20);
            this.txtScreeningNumber.TabIndex = 13;
            this.txtScreeningNumber.Visible = false;
            // 
            // txtseatsAvailable
            // 
            this.txtseatsAvailable.Enabled = false;
            this.txtseatsAvailable.Location = new System.Drawing.Point(432, 158);
            this.txtseatsAvailable.Name = "txtseatsAvailable";
            this.txtseatsAvailable.Size = new System.Drawing.Size(100, 20);
            this.txtseatsAvailable.TabIndex = 12;
            this.txtseatsAvailable.Visible = false;
            // 
            // txtMaxSeats
            // 
            this.txtMaxSeats.Enabled = false;
            this.txtMaxSeats.Location = new System.Drawing.Point(432, 123);
            this.txtMaxSeats.Name = "txtMaxSeats";
            this.txtMaxSeats.Size = new System.Drawing.Size(100, 20);
            this.txtMaxSeats.TabIndex = 11;
            this.txtMaxSeats.Visible = false;
            // 
            // cboMovieId
            // 
            this.cboMovieId.Enabled = false;
            this.cboMovieId.FormattingEnabled = true;
            this.cboMovieId.Location = new System.Drawing.Point(99, 163);
            this.cboMovieId.Name = "cboMovieId";
            this.cboMovieId.Size = new System.Drawing.Size(200, 21);
            this.cboMovieId.TabIndex = 10;
            // 
            // lblMovieId
            // 
            this.lblMovieId.AutoSize = true;
            this.lblMovieId.Location = new System.Drawing.Point(26, 166);
            this.lblMovieId.Name = "lblMovieId";
            this.lblMovieId.Size = new System.Drawing.Size(48, 13);
            this.lblMovieId.TabIndex = 9;
            this.lblMovieId.Text = "Movie Id";
            // 
            // cboScreenNo
            // 
            this.cboScreenNo.Enabled = false;
            this.cboScreenNo.FormattingEnabled = true;
            this.cboScreenNo.Location = new System.Drawing.Point(99, 96);
            this.cboScreenNo.Name = "cboScreenNo";
            this.cboScreenNo.Size = new System.Drawing.Size(200, 21);
            this.cboScreenNo.TabIndex = 8;
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.CustomFormat = "dd-MM-yyyy";
            this.dtpDateTo.Enabled = false;
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateTo.Location = new System.Drawing.Point(99, 58);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(200, 20);
            this.dtpDateTo.TabIndex = 6;
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.CustomFormat = "dd-MM-yyyy";
            this.dtpDateFrom.Enabled = false;
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateFrom.Location = new System.Drawing.Point(99, 24);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpDateFrom.TabIndex = 5;
            // 
            // btnRemoveScreening
            // 
            this.btnRemoveScreening.Location = new System.Drawing.Point(99, 232);
            this.btnRemoveScreening.Name = "btnRemoveScreening";
            this.btnRemoveScreening.Size = new System.Drawing.Size(280, 31);
            this.btnRemoveScreening.TabIndex = 4;
            this.btnRemoveScreening.Text = "Remove Screening";
            this.btnRemoveScreening.UseVisualStyleBackColor = true;
            this.btnRemoveScreening.Click += new System.EventHandler(this.btnRemoveScreening_Click);
            // 
            // lblScreenNo
            // 
            this.lblScreenNo.AutoSize = true;
            this.lblScreenNo.Location = new System.Drawing.Point(26, 99);
            this.lblScreenNo.Name = "lblScreenNo";
            this.lblScreenNo.Size = new System.Drawing.Size(58, 13);
            this.lblScreenNo.TabIndex = 3;
            this.lblScreenNo.Text = "Screen No";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(26, 131);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(30, 13);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "Time";
            // 
            // lblDateTo
            // 
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.Location = new System.Drawing.Point(26, 64);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(46, 13);
            this.lblDateTo.TabIndex = 1;
            this.lblDateTo.Text = "Date To";
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.Location = new System.Drawing.Point(26, 30);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(56, 13);
            this.lblDateFrom.TabIndex = 0;
            this.lblDateFrom.Text = "Date From";
            // 
            // frmRemoveScreening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.grpScheduleScreening);
            this.Controls.Add(this.grpSelectScreening);
            this.Name = "frmRemoveScreening";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove Screening";
            this.Load += new System.EventHandler(this.frmRemoveScreening_Load);
            this.grpSelectScreening.ResumeLayout(false);
            this.grpSelectScreening.PerformLayout();
            this.grpScheduleScreening.ResumeLayout(false);
            this.grpScheduleScreening.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSelectScreening;
        private System.Windows.Forms.ComboBox cboSelectScreening;
        private System.Windows.Forms.Label lblSelectScreeningNumber;
        private System.Windows.Forms.GroupBox grpScheduleScreening;
        private System.Windows.Forms.TextBox txtScreeningNumber;
        private System.Windows.Forms.TextBox txtseatsAvailable;
        private System.Windows.Forms.TextBox txtMaxSeats;
        private System.Windows.Forms.ComboBox cboMovieId;
        private System.Windows.Forms.Label lblMovieId;
        private System.Windows.Forms.ComboBox cboScreenNo;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.Button btnRemoveScreening;
        private System.Windows.Forms.Label lblScreenNo;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.ComboBox cboTimes;
    }
}