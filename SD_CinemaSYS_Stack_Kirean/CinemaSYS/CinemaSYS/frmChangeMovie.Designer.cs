namespace CinemaSYS
{
    partial class frmChangeMovie
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
            this.grpSearchMovie = new System.Windows.Forms.GroupBox();
            this.btnSearchMovie = new System.Windows.Forms.Button();
            this.txtSearchMovie = new System.Windows.Forms.TextBox();
            this.lblSearchMovie = new System.Windows.Forms.Label();
            this.grpChangeSelectedMovie = new System.Windows.Forms.GroupBox();
            this.txtMovieId = new System.Windows.Forms.TextBox();
            this.nudRunningTime = new System.Windows.Forms.NumericUpDown();
            this.btnConfirmChanges = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cboAgeRating = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblAgeRating = new System.Windows.Forms.Label();
            this.lblRunningTime = new System.Windows.Forms.Label();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.grpSearchMovie.SuspendLayout();
            this.grpChangeSelectedMovie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRunningTime)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSearchMovie
            // 
            this.grpSearchMovie.Controls.Add(this.btnSearchMovie);
            this.grpSearchMovie.Controls.Add(this.txtSearchMovie);
            this.grpSearchMovie.Controls.Add(this.lblSearchMovie);
            this.grpSearchMovie.Location = new System.Drawing.Point(38, 29);
            this.grpSearchMovie.Name = "grpSearchMovie";
            this.grpSearchMovie.Size = new System.Drawing.Size(710, 152);
            this.grpSearchMovie.TabIndex = 0;
            this.grpSearchMovie.TabStop = false;
            this.grpSearchMovie.Text = "Search Movie";
            // 
            // btnSearchMovie
            // 
            this.btnSearchMovie.Location = new System.Drawing.Point(34, 102);
            this.btnSearchMovie.Name = "btnSearchMovie";
            this.btnSearchMovie.Size = new System.Drawing.Size(264, 29);
            this.btnSearchMovie.TabIndex = 2;
            this.btnSearchMovie.Text = "Search Movie";
            this.btnSearchMovie.UseVisualStyleBackColor = true;
            this.btnSearchMovie.Click += new System.EventHandler(this.btnSearchMovie_Click);
            // 
            // txtSearchMovie
            // 
            this.txtSearchMovie.Location = new System.Drawing.Point(126, 44);
            this.txtSearchMovie.Name = "txtSearchMovie";
            this.txtSearchMovie.Size = new System.Drawing.Size(250, 20);
            this.txtSearchMovie.TabIndex = 1;
            // 
            // lblSearchMovie
            // 
            this.lblSearchMovie.AutoSize = true;
            this.lblSearchMovie.Location = new System.Drawing.Point(31, 47);
            this.lblSearchMovie.Name = "lblSearchMovie";
            this.lblSearchMovie.Size = new System.Drawing.Size(73, 13);
            this.lblSearchMovie.TabIndex = 0;
            this.lblSearchMovie.Text = "Search Movie";
            // 
            // grpChangeSelectedMovie
            // 
            this.grpChangeSelectedMovie.Controls.Add(this.txtMovieId);
            this.grpChangeSelectedMovie.Controls.Add(this.nudRunningTime);
            this.grpChangeSelectedMovie.Controls.Add(this.btnConfirmChanges);
            this.grpChangeSelectedMovie.Controls.Add(this.txtDescription);
            this.grpChangeSelectedMovie.Controls.Add(this.cboAgeRating);
            this.grpChangeSelectedMovie.Controls.Add(this.lblDescription);
            this.grpChangeSelectedMovie.Controls.Add(this.lblAgeRating);
            this.grpChangeSelectedMovie.Controls.Add(this.lblRunningTime);
            this.grpChangeSelectedMovie.Controls.Add(this.txtMovieName);
            this.grpChangeSelectedMovie.Controls.Add(this.lblMovieName);
            this.grpChangeSelectedMovie.Location = new System.Drawing.Point(38, 187);
            this.grpChangeSelectedMovie.Name = "grpChangeSelectedMovie";
            this.grpChangeSelectedMovie.Size = new System.Drawing.Size(710, 251);
            this.grpChangeSelectedMovie.TabIndex = 1;
            this.grpChangeSelectedMovie.TabStop = false;
            this.grpChangeSelectedMovie.Text = "Change Selected Movie";
            // 
            // txtMovieId
            // 
            this.txtMovieId.Enabled = false;
            this.txtMovieId.Location = new System.Drawing.Point(126, 10);
            this.txtMovieId.Name = "txtMovieId";
            this.txtMovieId.Size = new System.Drawing.Size(100, 20);
            this.txtMovieId.TabIndex = 10;
            this.txtMovieId.Visible = false;
            // 
            // nudRunningTime
            // 
            this.nudRunningTime.Location = new System.Drawing.Point(126, 69);
            this.nudRunningTime.Name = "nudRunningTime";
            this.nudRunningTime.Size = new System.Drawing.Size(87, 20);
            this.nudRunningTime.TabIndex = 9;
            // 
            // btnConfirmChanges
            // 
            this.btnConfirmChanges.Location = new System.Drawing.Point(229, 213);
            this.btnConfirmChanges.Name = "btnConfirmChanges";
            this.btnConfirmChanges.Size = new System.Drawing.Size(250, 32);
            this.btnConfirmChanges.TabIndex = 8;
            this.btnConfirmChanges.Text = "Confirm Changes";
            this.btnConfirmChanges.UseVisualStyleBackColor = true;
            this.btnConfirmChanges.Click += new System.EventHandler(this.btnConfirmChanges_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(126, 125);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(412, 81);
            this.txtDescription.TabIndex = 7;
            // 
            // cboAgeRating
            // 
            this.cboAgeRating.FormattingEnabled = true;
            this.cboAgeRating.Items.AddRange(new object[] {
            "U",
            "PG",
            "12A",
            "12",
            "15",
            "18"});
            this.cboAgeRating.Location = new System.Drawing.Point(126, 96);
            this.cboAgeRating.Name = "cboAgeRating";
            this.cboAgeRating.Size = new System.Drawing.Size(250, 21);
            this.cboAgeRating.TabIndex = 6;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(37, 128);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description";
            // 
            // lblAgeRating
            // 
            this.lblAgeRating.AutoSize = true;
            this.lblAgeRating.Location = new System.Drawing.Point(34, 99);
            this.lblAgeRating.Name = "lblAgeRating";
            this.lblAgeRating.Size = new System.Drawing.Size(60, 13);
            this.lblAgeRating.TabIndex = 3;
            this.lblAgeRating.Text = "Age Rating";
            // 
            // lblRunningTime
            // 
            this.lblRunningTime.AutoSize = true;
            this.lblRunningTime.Location = new System.Drawing.Point(34, 71);
            this.lblRunningTime.Name = "lblRunningTime";
            this.lblRunningTime.Size = new System.Drawing.Size(73, 13);
            this.lblRunningTime.TabIndex = 2;
            this.lblRunningTime.Text = "Running Time";
            // 
            // txtMovieName
            // 
            this.txtMovieName.Location = new System.Drawing.Point(126, 36);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(250, 20);
            this.txtMovieName.TabIndex = 1;
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.Location = new System.Drawing.Point(34, 39);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(67, 13);
            this.lblMovieName.TabIndex = 0;
            this.lblMovieName.Text = "Movie Name";
            // 
            // frmChangeMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpChangeSelectedMovie);
            this.Controls.Add(this.grpSearchMovie);
            this.Name = "frmChangeMovie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Movie";
            this.Load += new System.EventHandler(this.frmChangeMovie_Load);
            this.grpSearchMovie.ResumeLayout(false);
            this.grpSearchMovie.PerformLayout();
            this.grpChangeSelectedMovie.ResumeLayout(false);
            this.grpChangeSelectedMovie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRunningTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSearchMovie;
        private System.Windows.Forms.Label lblSearchMovie;
        private System.Windows.Forms.Button btnSearchMovie;
        private System.Windows.Forms.TextBox txtSearchMovie;
        private System.Windows.Forms.GroupBox grpChangeSelectedMovie;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblAgeRating;
        private System.Windows.Forms.Label lblRunningTime;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.Label lblMovieName;
        private System.Windows.Forms.Button btnConfirmChanges;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cboAgeRating;
        private System.Windows.Forms.NumericUpDown nudRunningTime;
        private System.Windows.Forms.TextBox txtMovieId;
    }
}