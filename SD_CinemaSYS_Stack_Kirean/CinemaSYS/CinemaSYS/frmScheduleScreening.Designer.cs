namespace CinemaSYS
{
    partial class frmScheduleScreening
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
            this.grpScheduleScreening = new System.Windows.Forms.GroupBox();
            this.cboTimes = new System.Windows.Forms.ComboBox();
            this.lblMaxSeats = new System.Windows.Forms.Label();
            this.lblScreeningNo = new System.Windows.Forms.Label();
            this.txtScreeningNumber = new System.Windows.Forms.TextBox();
            this.txtseatsAvailable = new System.Windows.Forms.TextBox();
            this.txtMaxSeats = new System.Windows.Forms.TextBox();
            this.cboMovieId = new System.Windows.Forms.ComboBox();
            this.lblMovieId = new System.Windows.Forms.Label();
            this.cboScreenNo = new System.Windows.Forms.ComboBox();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.btnScheduleScreening = new System.Windows.Forms.Button();
            this.lblScreenNo = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.grpScheduleScreening.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpScheduleScreening
            // 
            this.grpScheduleScreening.Controls.Add(this.cboTimes);
            this.grpScheduleScreening.Controls.Add(this.lblMaxSeats);
            this.grpScheduleScreening.Controls.Add(this.lblScreeningNo);
            this.grpScheduleScreening.Controls.Add(this.txtScreeningNumber);
            this.grpScheduleScreening.Controls.Add(this.txtseatsAvailable);
            this.grpScheduleScreening.Controls.Add(this.txtMaxSeats);
            this.grpScheduleScreening.Controls.Add(this.cboMovieId);
            this.grpScheduleScreening.Controls.Add(this.lblMovieId);
            this.grpScheduleScreening.Controls.Add(this.cboScreenNo);
            this.grpScheduleScreening.Controls.Add(this.dtpDateTo);
            this.grpScheduleScreening.Controls.Add(this.dtpDateFrom);
            this.grpScheduleScreening.Controls.Add(this.btnScheduleScreening);
            this.grpScheduleScreening.Controls.Add(this.lblScreenNo);
            this.grpScheduleScreening.Controls.Add(this.lblTime);
            this.grpScheduleScreening.Controls.Add(this.lblDateTo);
            this.grpScheduleScreening.Controls.Add(this.lblDateFrom);
            this.grpScheduleScreening.Location = new System.Drawing.Point(24, 30);
            this.grpScheduleScreening.Name = "grpScheduleScreening";
            this.grpScheduleScreening.Size = new System.Drawing.Size(729, 360);
            this.grpScheduleScreening.TabIndex = 0;
            this.grpScheduleScreening.TabStop = false;
            this.grpScheduleScreening.Text = "Schedule Screening";
            // 
            // cboTimes
            // 
            this.cboTimes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimes.FormattingEnabled = true;
            this.cboTimes.Location = new System.Drawing.Point(131, 197);
            this.cboTimes.Name = "cboTimes";
            this.cboTimes.Size = new System.Drawing.Size(200, 21);
            this.cboTimes.TabIndex = 18;
            // 
            // lblMaxSeats
            // 
            this.lblMaxSeats.AutoSize = true;
            this.lblMaxSeats.Location = new System.Drawing.Point(29, 76);
            this.lblMaxSeats.Name = "lblMaxSeats";
            this.lblMaxSeats.Size = new System.Drawing.Size(57, 13);
            this.lblMaxSeats.TabIndex = 17;
            this.lblMaxSeats.Text = "Max Seats";
            // 
            // lblScreeningNo
            // 
            this.lblScreeningNo.AutoSize = true;
            this.lblScreeningNo.Location = new System.Drawing.Point(30, 47);
            this.lblScreeningNo.Name = "lblScreeningNo";
            this.lblScreeningNo.Size = new System.Drawing.Size(95, 13);
            this.lblScreeningNo.TabIndex = 16;
            this.lblScreeningNo.Text = "Screening Number";
            // 
            // txtScreeningNumber
            // 
            this.txtScreeningNumber.Enabled = false;
            this.txtScreeningNumber.Location = new System.Drawing.Point(131, 44);
            this.txtScreeningNumber.Name = "txtScreeningNumber";
            this.txtScreeningNumber.Size = new System.Drawing.Size(100, 20);
            this.txtScreeningNumber.TabIndex = 13;
            // 
            // txtseatsAvailable
            // 
            this.txtseatsAvailable.Enabled = false;
            this.txtseatsAvailable.Location = new System.Drawing.Point(432, 158);
            this.txtseatsAvailable.Name = "txtseatsAvailable";
            this.txtseatsAvailable.Size = new System.Drawing.Size(100, 20);
            this.txtseatsAvailable.TabIndex = 12;
            // 
            // txtMaxSeats
            // 
            this.txtMaxSeats.Enabled = false;
            this.txtMaxSeats.Location = new System.Drawing.Point(131, 73);
            this.txtMaxSeats.Name = "txtMaxSeats";
            this.txtMaxSeats.Size = new System.Drawing.Size(100, 20);
            this.txtMaxSeats.TabIndex = 11;
            // 
            // cboMovieId
            // 
            this.cboMovieId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMovieId.FormattingEnabled = true;
            this.cboMovieId.Location = new System.Drawing.Point(131, 231);
            this.cboMovieId.Name = "cboMovieId";
            this.cboMovieId.Size = new System.Drawing.Size(200, 21);
            this.cboMovieId.TabIndex = 10;
            // 
            // lblMovieId
            // 
            this.lblMovieId.AutoSize = true;
            this.lblMovieId.Location = new System.Drawing.Point(32, 234);
            this.lblMovieId.Name = "lblMovieId";
            this.lblMovieId.Size = new System.Drawing.Size(48, 13);
            this.lblMovieId.TabIndex = 9;
            this.lblMovieId.Text = "Movie Id";
            // 
            // cboScreenNo
            // 
            this.cboScreenNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboScreenNo.FormattingEnabled = true;
            this.cboScreenNo.Location = new System.Drawing.Point(131, 168);
            this.cboScreenNo.Name = "cboScreenNo";
            this.cboScreenNo.Size = new System.Drawing.Size(200, 21);
            this.cboScreenNo.TabIndex = 8;
            this.cboScreenNo.SelectedIndexChanged += new System.EventHandler(this.cboScreenNo_SelectedIndexChanged);
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.CustomFormat = "dd-MM-yy";
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateTo.Location = new System.Drawing.Point(131, 135);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(200, 20);
            this.dtpDateTo.TabIndex = 6;
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.CustomFormat = "dd-MM-yy";
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateFrom.Location = new System.Drawing.Point(131, 105);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpDateFrom.TabIndex = 5;
            // 
            // btnScheduleScreening
            // 
            this.btnScheduleScreening.Location = new System.Drawing.Point(131, 286);
            this.btnScheduleScreening.Name = "btnScheduleScreening";
            this.btnScheduleScreening.Size = new System.Drawing.Size(280, 31);
            this.btnScheduleScreening.TabIndex = 4;
            this.btnScheduleScreening.Text = "Schedule Screening";
            this.btnScheduleScreening.UseVisualStyleBackColor = true;
            this.btnScheduleScreening.Click += new System.EventHandler(this.btnScheduleScreening_Click);
            // 
            // lblScreenNo
            // 
            this.lblScreenNo.AutoSize = true;
            this.lblScreenNo.Location = new System.Drawing.Point(32, 171);
            this.lblScreenNo.Name = "lblScreenNo";
            this.lblScreenNo.Size = new System.Drawing.Size(58, 13);
            this.lblScreenNo.TabIndex = 3;
            this.lblScreenNo.Text = "Screen No";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(32, 200);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(30, 13);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "Time";
            // 
            // lblDateTo
            // 
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.Location = new System.Drawing.Point(32, 141);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(46, 13);
            this.lblDateTo.TabIndex = 1;
            this.lblDateTo.Text = "Date To";
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.Location = new System.Drawing.Point(32, 111);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(56, 13);
            this.lblDateFrom.TabIndex = 0;
            this.lblDateFrom.Text = "Date From";
            // 
            // frmScheduleScreening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpScheduleScreening);
            this.Name = "frmScheduleScreening";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule Screening";
            this.Load += new System.EventHandler(this.frmScheduleScreening_Load);
            this.grpScheduleScreening.ResumeLayout(false);
            this.grpScheduleScreening.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpScheduleScreening;
        private System.Windows.Forms.Button btnScheduleScreening;
        private System.Windows.Forms.TextBox txtScreeningNumber;
        private System.Windows.Forms.TextBox txtseatsAvailable;
        private System.Windows.Forms.TextBox txtMaxSeats;
        private System.Windows.Forms.ComboBox cboMovieId;
        private System.Windows.Forms.Label lblMovieId;
        private System.Windows.Forms.ComboBox cboScreenNo;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.Label lblScreenNo;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.Label lblMaxSeats;
        private System.Windows.Forms.Label lblScreeningNo;
        private System.Windows.Forms.ComboBox cboTimes;
    }
}