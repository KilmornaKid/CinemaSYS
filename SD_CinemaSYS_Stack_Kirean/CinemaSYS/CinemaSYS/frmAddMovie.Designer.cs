namespace CinemaSYS
{
    partial class frmAddMovie
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
            this.grpAddMovie = new System.Windows.Forms.GroupBox();
            this.txtMovieId = new System.Windows.Forms.TextBox();
            this.lblMovieId = new System.Windows.Forms.Label();
            this.nudRunningTime = new System.Windows.Forms.NumericUpDown();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.cboAgeRating = new System.Windows.Forms.ComboBox();
            this.lblAgeRating = new System.Windows.Forms.Label();
            this.lblRunningTime = new System.Windows.Forms.Label();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.grpAddMovie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRunningTime)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAddMovie
            // 
            this.grpAddMovie.Controls.Add(this.txtMovieId);
            this.grpAddMovie.Controls.Add(this.lblMovieId);
            this.grpAddMovie.Controls.Add(this.nudRunningTime);
            this.grpAddMovie.Controls.Add(this.btnConfirm);
            this.grpAddMovie.Controls.Add(this.txtDescription);
            this.grpAddMovie.Controls.Add(this.lblDescription);
            this.grpAddMovie.Controls.Add(this.cboAgeRating);
            this.grpAddMovie.Controls.Add(this.lblAgeRating);
            this.grpAddMovie.Controls.Add(this.lblRunningTime);
            this.grpAddMovie.Controls.Add(this.txtMovieName);
            this.grpAddMovie.Controls.Add(this.lblMovieName);
            this.grpAddMovie.Location = new System.Drawing.Point(44, 29);
            this.grpAddMovie.Name = "grpAddMovie";
            this.grpAddMovie.Size = new System.Drawing.Size(722, 395);
            this.grpAddMovie.TabIndex = 1;
            this.grpAddMovie.TabStop = false;
            this.grpAddMovie.Text = "Add Movie";
            // 
            // txtMovieId
            // 
            this.txtMovieId.Enabled = false;
            this.txtMovieId.Location = new System.Drawing.Point(108, 29);
            this.txtMovieId.Name = "txtMovieId";
            this.txtMovieId.Size = new System.Drawing.Size(104, 20);
            this.txtMovieId.TabIndex = 11;
            // 
            // lblMovieId
            // 
            this.lblMovieId.AutoSize = true;
            this.lblMovieId.Location = new System.Drawing.Point(23, 32);
            this.lblMovieId.Name = "lblMovieId";
            this.lblMovieId.Size = new System.Drawing.Size(47, 13);
            this.lblMovieId.TabIndex = 10;
            this.lblMovieId.Text = "MovieID";
            // 
            // nudRunningTime
            // 
            this.nudRunningTime.Location = new System.Drawing.Point(108, 106);
            this.nudRunningTime.Name = "nudRunningTime";
            this.nudRunningTime.Size = new System.Drawing.Size(104, 20);
            this.nudRunningTime.TabIndex = 9;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(108, 336);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(224, 31);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(108, 203);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(490, 109);
            this.txtDescription.TabIndex = 7;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(23, 203);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Description";
            // 
            // cboAgeRating
            // 
            this.cboAgeRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAgeRating.FormattingEnabled = true;
            this.cboAgeRating.Items.AddRange(new object[] {
            "U",
            "PG",
            "12A",
            "12",
            "15",
            "18"});
            this.cboAgeRating.Location = new System.Drawing.Point(108, 148);
            this.cboAgeRating.Name = "cboAgeRating";
            this.cboAgeRating.Size = new System.Drawing.Size(104, 21);
            this.cboAgeRating.TabIndex = 5;
            // 
            // lblAgeRating
            // 
            this.lblAgeRating.AutoSize = true;
            this.lblAgeRating.Location = new System.Drawing.Point(23, 151);
            this.lblAgeRating.Name = "lblAgeRating";
            this.lblAgeRating.Size = new System.Drawing.Size(60, 13);
            this.lblAgeRating.TabIndex = 4;
            this.lblAgeRating.Text = "Age Rating";
            // 
            // lblRunningTime
            // 
            this.lblRunningTime.AutoSize = true;
            this.lblRunningTime.Location = new System.Drawing.Point(23, 108);
            this.lblRunningTime.Name = "lblRunningTime";
            this.lblRunningTime.Size = new System.Drawing.Size(73, 13);
            this.lblRunningTime.TabIndex = 2;
            this.lblRunningTime.Text = "Running Time";
            // 
            // txtMovieName
            // 
            this.txtMovieName.Location = new System.Drawing.Point(108, 65);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(248, 20);
            this.txtMovieName.TabIndex = 1;
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.Location = new System.Drawing.Point(23, 68);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(67, 13);
            this.lblMovieName.TabIndex = 0;
            this.lblMovieName.Text = "Movie Name";
            // 
            // frmAddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 478);
            this.Controls.Add(this.grpAddMovie);
            this.Name = "frmAddMovie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Movie";
            this.Load += new System.EventHandler(this.frmAddMovie_Load);
            this.grpAddMovie.ResumeLayout(false);
            this.grpAddMovie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRunningTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpAddMovie;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.ComboBox cboAgeRating;
        private System.Windows.Forms.Label lblAgeRating;
        private System.Windows.Forms.Label lblRunningTime;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.Label lblMovieName;
        private System.Windows.Forms.NumericUpDown nudRunningTime;
        private System.Windows.Forms.TextBox txtMovieId;
        private System.Windows.Forms.Label lblMovieId;
    }
}