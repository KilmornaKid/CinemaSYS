namespace CinemaSYS
{
    partial class frmRemoveMovie
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
            this.cboSearchMovie = new System.Windows.Forms.ComboBox();
            this.lblSearchMovie = new System.Windows.Forms.Label();
            this.grpRemoveSelectedMovie = new System.Windows.Forms.GroupBox();
            this.lblMovieId = new System.Windows.Forms.Label();
            this.txtMovieId = new System.Windows.Forms.TextBox();
            this.nudRunningTime = new System.Windows.Forms.NumericUpDown();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cboAgeRating = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblAgeRating = new System.Windows.Forms.Label();
            this.lblRunningTime = new System.Windows.Forms.Label();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.btnRemoveMovie = new System.Windows.Forms.Button();
            this.grpSearchMovie.SuspendLayout();
            this.grpRemoveSelectedMovie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRunningTime)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSearchMovie
            // 
            this.grpSearchMovie.Controls.Add(this.cboSearchMovie);
            this.grpSearchMovie.Controls.Add(this.lblSearchMovie);
            this.grpSearchMovie.Location = new System.Drawing.Point(30, 22);
            this.grpSearchMovie.Name = "grpSearchMovie";
            this.grpSearchMovie.Size = new System.Drawing.Size(710, 97);
            this.grpSearchMovie.TabIndex = 1;
            this.grpSearchMovie.TabStop = false;
            this.grpSearchMovie.Text = "Search Movie";
            // 
            // cboSearchMovie
            // 
            this.cboSearchMovie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboSearchMovie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboSearchMovie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSearchMovie.FormattingEnabled = true;
            this.cboSearchMovie.Location = new System.Drawing.Point(126, 44);
            this.cboSearchMovie.Name = "cboSearchMovie";
            this.cboSearchMovie.Size = new System.Drawing.Size(250, 21);
            this.cboSearchMovie.TabIndex = 1;
            this.cboSearchMovie.SelectedIndexChanged += new System.EventHandler(this.cboSearchMovie_SelectedIndexChanged_1);
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
            // grpRemoveSelectedMovie
            // 
            this.grpRemoveSelectedMovie.Controls.Add(this.lblMovieId);
            this.grpRemoveSelectedMovie.Controls.Add(this.txtMovieId);
            this.grpRemoveSelectedMovie.Controls.Add(this.nudRunningTime);
            this.grpRemoveSelectedMovie.Controls.Add(this.txtDescription);
            this.grpRemoveSelectedMovie.Controls.Add(this.cboAgeRating);
            this.grpRemoveSelectedMovie.Controls.Add(this.lblDescription);
            this.grpRemoveSelectedMovie.Controls.Add(this.lblAgeRating);
            this.grpRemoveSelectedMovie.Controls.Add(this.lblRunningTime);
            this.grpRemoveSelectedMovie.Controls.Add(this.txtMovieName);
            this.grpRemoveSelectedMovie.Controls.Add(this.lblMovieName);
            this.grpRemoveSelectedMovie.Controls.Add(this.btnRemoveMovie);
            this.grpRemoveSelectedMovie.Location = new System.Drawing.Point(30, 142);
            this.grpRemoveSelectedMovie.Name = "grpRemoveSelectedMovie";
            this.grpRemoveSelectedMovie.Size = new System.Drawing.Size(710, 296);
            this.grpRemoveSelectedMovie.TabIndex = 2;
            this.grpRemoveSelectedMovie.TabStop = false;
            this.grpRemoveSelectedMovie.Text = "Remove Movie";
            // 
            // lblMovieId
            // 
            this.lblMovieId.AutoSize = true;
            this.lblMovieId.Location = new System.Drawing.Point(34, 29);
            this.lblMovieId.Name = "lblMovieId";
            this.lblMovieId.Size = new System.Drawing.Size(50, 13);
            this.lblMovieId.TabIndex = 20;
            this.lblMovieId.Text = "Movie ID";
            // 
            // txtMovieId
            // 
            this.txtMovieId.Enabled = false;
            this.txtMovieId.Location = new System.Drawing.Point(126, 26);
            this.txtMovieId.Name = "txtMovieId";
            this.txtMovieId.Size = new System.Drawing.Size(100, 20);
            this.txtMovieId.TabIndex = 19;
            // 
            // nudRunningTime
            // 
            this.nudRunningTime.Enabled = false;
            this.nudRunningTime.Location = new System.Drawing.Point(126, 88);
            this.nudRunningTime.Name = "nudRunningTime";
            this.nudRunningTime.Size = new System.Drawing.Size(87, 20);
            this.nudRunningTime.TabIndex = 18;
            // 
            // txtDescription
            // 
            this.txtDescription.Enabled = false;
            this.txtDescription.Location = new System.Drawing.Point(126, 144);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(412, 81);
            this.txtDescription.TabIndex = 17;
            // 
            // cboAgeRating
            // 
            this.cboAgeRating.Enabled = false;
            this.cboAgeRating.FormattingEnabled = true;
            this.cboAgeRating.Items.AddRange(new object[] {
            "U",
            "PG",
            "12A",
            "12",
            "15",
            "18"});
            this.cboAgeRating.Location = new System.Drawing.Point(126, 115);
            this.cboAgeRating.Name = "cboAgeRating";
            this.cboAgeRating.Size = new System.Drawing.Size(250, 21);
            this.cboAgeRating.TabIndex = 16;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(34, 147);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 15;
            this.lblDescription.Text = "Description";
            // 
            // lblAgeRating
            // 
            this.lblAgeRating.AutoSize = true;
            this.lblAgeRating.Location = new System.Drawing.Point(34, 118);
            this.lblAgeRating.Name = "lblAgeRating";
            this.lblAgeRating.Size = new System.Drawing.Size(60, 13);
            this.lblAgeRating.TabIndex = 14;
            this.lblAgeRating.Text = "Age Rating";
            // 
            // lblRunningTime
            // 
            this.lblRunningTime.AutoSize = true;
            this.lblRunningTime.Location = new System.Drawing.Point(34, 90);
            this.lblRunningTime.Name = "lblRunningTime";
            this.lblRunningTime.Size = new System.Drawing.Size(73, 13);
            this.lblRunningTime.TabIndex = 13;
            this.lblRunningTime.Text = "Running Time";
            // 
            // txtMovieName
            // 
            this.txtMovieName.Location = new System.Drawing.Point(126, 55);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(250, 20);
            this.txtMovieName.TabIndex = 12;
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.Location = new System.Drawing.Point(34, 58);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(67, 13);
            this.lblMovieName.TabIndex = 11;
            this.lblMovieName.Text = "Movie Name";
            // 
            // btnRemoveMovie
            // 
            this.btnRemoveMovie.Location = new System.Drawing.Point(126, 259);
            this.btnRemoveMovie.Name = "btnRemoveMovie";
            this.btnRemoveMovie.Size = new System.Drawing.Size(264, 31);
            this.btnRemoveMovie.TabIndex = 0;
            this.btnRemoveMovie.Text = "Remove Movie";
            this.btnRemoveMovie.UseVisualStyleBackColor = true;
            this.btnRemoveMovie.Click += new System.EventHandler(this.btnRemoveMovie_Click);
            // 
            // frmRemoveMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpRemoveSelectedMovie);
            this.Controls.Add(this.grpSearchMovie);
            this.Name = "frmRemoveMovie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove Movie";
            this.Load += new System.EventHandler(this.frmRemoveMovie_Load);
            this.grpSearchMovie.ResumeLayout(false);
            this.grpSearchMovie.PerformLayout();
            this.grpRemoveSelectedMovie.ResumeLayout(false);
            this.grpRemoveSelectedMovie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRunningTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSearchMovie;
        private System.Windows.Forms.Label lblSearchMovie;
        private System.Windows.Forms.GroupBox grpRemoveSelectedMovie;
        private System.Windows.Forms.Button btnRemoveMovie;
        private System.Windows.Forms.Label lblMovieId;
        private System.Windows.Forms.TextBox txtMovieId;
        private System.Windows.Forms.NumericUpDown nudRunningTime;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cboAgeRating;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblAgeRating;
        private System.Windows.Forms.Label lblRunningTime;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.Label lblMovieName;
        private System.Windows.Forms.ComboBox cboSearchMovie;
    }
}