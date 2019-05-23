namespace CinemaSYS
{
    partial class frmSeatTickets
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
            this.grpSelectMovie = new System.Windows.Forms.GroupBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.cboTime = new System.Windows.Forms.ComboBox();
            this.txtMaxSeats = new System.Windows.Forms.TextBox();
            this.nudNumOfTickets = new System.Windows.Forms.NumericUpDown();
            this.lblAmountOfTickets = new System.Windows.Forms.Label();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cboDate = new System.Windows.Forms.ComboBox();
            this.lblSelectRate = new System.Windows.Forms.Label();
            this.cboSelectRate = new System.Windows.Forms.ComboBox();
            this.lblSaleId = new System.Windows.Forms.Label();
            this.lblSelectMovie = new System.Windows.Forms.Label();
            this.txtSaleId = new System.Windows.Forms.TextBox();
            this.cboSelectMovie = new System.Windows.Forms.ComboBox();
            this.btnBookTicket = new System.Windows.Forms.Button();
            this.cboDateOfBooking = new System.Windows.Forms.ComboBox();
            this.txtseatsAvailable = new System.Windows.Forms.TextBox();
            this.lblSelectTime = new System.Windows.Forms.Label();
            this.cboSelectTime = new System.Windows.Forms.ComboBox();
            this.grpSelectMovie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumOfTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSelectMovie
            // 
            this.grpSelectMovie.Controls.Add(this.lblTime);
            this.grpSelectMovie.Controls.Add(this.cboTime);
            this.grpSelectMovie.Controls.Add(this.txtMaxSeats);
            this.grpSelectMovie.Controls.Add(this.nudNumOfTickets);
            this.grpSelectMovie.Controls.Add(this.lblAmountOfTickets);
            this.grpSelectMovie.Controls.Add(this.dtpDateTo);
            this.grpSelectMovie.Controls.Add(this.dtpDateFrom);
            this.grpSelectMovie.Controls.Add(this.label1);
            this.grpSelectMovie.Controls.Add(this.cboDate);
            this.grpSelectMovie.Controls.Add(this.lblSelectRate);
            this.grpSelectMovie.Controls.Add(this.cboSelectRate);
            this.grpSelectMovie.Controls.Add(this.lblSaleId);
            this.grpSelectMovie.Controls.Add(this.lblSelectMovie);
            this.grpSelectMovie.Controls.Add(this.txtSaleId);
            this.grpSelectMovie.Controls.Add(this.cboSelectMovie);
            this.grpSelectMovie.Controls.Add(this.btnBookTicket);
            this.grpSelectMovie.Location = new System.Drawing.Point(33, 35);
            this.grpSelectMovie.Name = "grpSelectMovie";
            this.grpSelectMovie.Size = new System.Drawing.Size(710, 355);
            this.grpSelectMovie.TabIndex = 3;
            this.grpSelectMovie.TabStop = false;
            this.grpSelectMovie.Text = "Select Movie";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(34, 203);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(63, 13);
            this.lblTime.TabIndex = 26;
            this.lblTime.Text = "Select Time";
            // 
            // cboTime
            // 
            this.cboTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTime.FormattingEnabled = true;
            this.cboTime.Location = new System.Drawing.Point(118, 200);
            this.cboTime.Name = "cboTime";
            this.cboTime.Size = new System.Drawing.Size(337, 21);
            this.cboTime.TabIndex = 25;
            // 
            // txtMaxSeats
            // 
            this.txtMaxSeats.Enabled = false;
            this.txtMaxSeats.Location = new System.Drawing.Point(468, 207);
            this.txtMaxSeats.Name = "txtMaxSeats";
            this.txtMaxSeats.Size = new System.Drawing.Size(140, 20);
            this.txtMaxSeats.TabIndex = 24;
            // 
            // nudNumOfTickets
            // 
            this.nudNumOfTickets.Location = new System.Drawing.Point(118, 238);
            this.nudNumOfTickets.Name = "nudNumOfTickets";
            this.nudNumOfTickets.Size = new System.Drawing.Size(70, 20);
            this.nudNumOfTickets.TabIndex = 23;
            // 
            // lblAmountOfTickets
            // 
            this.lblAmountOfTickets.AutoSize = true;
            this.lblAmountOfTickets.Location = new System.Drawing.Point(31, 240);
            this.lblAmountOfTickets.Name = "lblAmountOfTickets";
            this.lblAmountOfTickets.Size = new System.Drawing.Size(66, 13);
            this.lblAmountOfTickets.TabIndex = 22;
            this.lblAmountOfTickets.Text = "# Of Tickets";
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Enabled = false;
            this.dtpDateTo.Location = new System.Drawing.Point(468, 166);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(140, 20);
            this.dtpDateTo.TabIndex = 21;
            this.dtpDateTo.Visible = false;
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Enabled = false;
            this.dtpDateFrom.Location = new System.Drawing.Point(468, 128);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(140, 20);
            this.dtpDateFrom.TabIndex = 20;
            this.dtpDateFrom.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Select Date";
            // 
            // cboDate
            // 
            this.cboDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDate.FormattingEnabled = true;
            this.cboDate.Location = new System.Drawing.Point(118, 125);
            this.cboDate.Name = "cboDate";
            this.cboDate.Size = new System.Drawing.Size(140, 21);
            this.cboDate.TabIndex = 18;
            this.cboDate.SelectedIndexChanged += new System.EventHandler(this.cboDate_SelectedIndexChanged);
            // 
            // lblSelectRate
            // 
            this.lblSelectRate.AutoSize = true;
            this.lblSelectRate.Location = new System.Drawing.Point(34, 166);
            this.lblSelectRate.Name = "lblSelectRate";
            this.lblSelectRate.Size = new System.Drawing.Size(63, 13);
            this.lblSelectRate.TabIndex = 17;
            this.lblSelectRate.Text = "Select Rate";
            // 
            // cboSelectRate
            // 
            this.cboSelectRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectRate.FormattingEnabled = true;
            this.cboSelectRate.Location = new System.Drawing.Point(118, 163);
            this.cboSelectRate.Name = "cboSelectRate";
            this.cboSelectRate.Size = new System.Drawing.Size(121, 21);
            this.cboSelectRate.TabIndex = 15;
            // 
            // lblSaleId
            // 
            this.lblSaleId.AutoSize = true;
            this.lblSaleId.Location = new System.Drawing.Point(61, 36);
            this.lblSaleId.Name = "lblSaleId";
            this.lblSaleId.Size = new System.Drawing.Size(42, 13);
            this.lblSaleId.TabIndex = 13;
            this.lblSaleId.Text = "Sale ID";
            // 
            // lblSelectMovie
            // 
            this.lblSelectMovie.AutoSize = true;
            this.lblSelectMovie.Location = new System.Drawing.Point(34, 86);
            this.lblSelectMovie.Name = "lblSelectMovie";
            this.lblSelectMovie.Size = new System.Drawing.Size(69, 13);
            this.lblSelectMovie.TabIndex = 4;
            this.lblSelectMovie.Text = "Select Movie";
            // 
            // txtSaleId
            // 
            this.txtSaleId.Enabled = false;
            this.txtSaleId.Location = new System.Drawing.Point(118, 33);
            this.txtSaleId.Name = "txtSaleId";
            this.txtSaleId.Size = new System.Drawing.Size(140, 20);
            this.txtSaleId.TabIndex = 12;
            // 
            // cboSelectMovie
            // 
            this.cboSelectMovie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectMovie.FormattingEnabled = true;
            this.cboSelectMovie.Location = new System.Drawing.Point(118, 83);
            this.cboSelectMovie.Name = "cboSelectMovie";
            this.cboSelectMovie.Size = new System.Drawing.Size(391, 21);
            this.cboSelectMovie.TabIndex = 3;
            this.cboSelectMovie.SelectedIndexChanged += new System.EventHandler(this.cboSelectMovie_SelectedIndexChanged_1);
            // 
            // btnBookTicket
            // 
            this.btnBookTicket.Location = new System.Drawing.Point(118, 289);
            this.btnBookTicket.Name = "btnBookTicket";
            this.btnBookTicket.Size = new System.Drawing.Size(337, 29);
            this.btnBookTicket.TabIndex = 2;
            this.btnBookTicket.Text = "Book Ticket";
            this.btnBookTicket.UseVisualStyleBackColor = true;
            this.btnBookTicket.Click += new System.EventHandler(this.btnBookTicket_Click);
            // 
            // cboDateOfBooking
            // 
            this.cboDateOfBooking.Enabled = false;
            this.cboDateOfBooking.FormattingEnabled = true;
            this.cboDateOfBooking.Location = new System.Drawing.Point(918, 282);
            this.cboDateOfBooking.Name = "cboDateOfBooking";
            this.cboDateOfBooking.Size = new System.Drawing.Size(131, 21);
            this.cboDateOfBooking.TabIndex = 19;
            this.cboDateOfBooking.Visible = false;
            // 
            // txtseatsAvailable
            // 
            this.txtseatsAvailable.Enabled = false;
            this.txtseatsAvailable.Location = new System.Drawing.Point(918, 237);
            this.txtseatsAvailable.Name = "txtseatsAvailable";
            this.txtseatsAvailable.Size = new System.Drawing.Size(100, 20);
            this.txtseatsAvailable.TabIndex = 18;
            this.txtseatsAvailable.Visible = false;
            // 
            // lblSelectTime
            // 
            this.lblSelectTime.AutoSize = true;
            this.lblSelectTime.Location = new System.Drawing.Point(839, 206);
            this.lblSelectTime.Name = "lblSelectTime";
            this.lblSelectTime.Size = new System.Drawing.Size(63, 13);
            this.lblSelectTime.TabIndex = 16;
            this.lblSelectTime.Text = "Select Time";
            this.lblSelectTime.Visible = false;
            // 
            // cboSelectTime
            // 
            this.cboSelectTime.Enabled = false;
            this.cboSelectTime.FormattingEnabled = true;
            this.cboSelectTime.Location = new System.Drawing.Point(917, 203);
            this.cboSelectTime.Name = "cboSelectTime";
            this.cboSelectTime.Size = new System.Drawing.Size(121, 21);
            this.cboSelectTime.TabIndex = 14;
            this.cboSelectTime.Visible = false;
            // 
            // frmSeatTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 414);
            this.Controls.Add(this.cboDateOfBooking);
            this.Controls.Add(this.grpSelectMovie);
            this.Controls.Add(this.txtseatsAvailable);
            this.Controls.Add(this.lblSelectTime);
            this.Controls.Add(this.cboSelectTime);
            this.Name = "frmSeatTickets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seat Tickets";
            this.Load += new System.EventHandler(this.frmSeatTickets_Load);
            this.grpSelectMovie.ResumeLayout(false);
            this.grpSelectMovie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumOfTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSelectMovie;
        private System.Windows.Forms.ComboBox cboSelectMovie;
        private System.Windows.Forms.Button btnBookTicket;
        private System.Windows.Forms.Label lblSelectMovie;
        private System.Windows.Forms.Label lblSaleId;
        private System.Windows.Forms.TextBox txtSaleId;
        private System.Windows.Forms.Label lblSelectRate;
        private System.Windows.Forms.Label lblSelectTime;
        private System.Windows.Forms.ComboBox cboSelectRate;
        private System.Windows.Forms.ComboBox cboSelectTime;
        private System.Windows.Forms.TextBox txtseatsAvailable;
        private System.Windows.Forms.ComboBox cboDateOfBooking;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboDate;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.Label lblAmountOfTickets;
        private System.Windows.Forms.NumericUpDown nudNumOfTickets;
        private System.Windows.Forms.TextBox txtMaxSeats;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ComboBox cboTime;
    }
}