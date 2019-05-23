namespace CinemaSYS
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.picMainMenuCinema = new System.Windows.Forms.PictureBox();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.screensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeScreenStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.screeningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleScreeningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeScreeningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeScreeningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seatTicketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearlyRevenueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soldOutScreeningsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picMainMenuCinema)).BeginInit();
            this.MainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // picMainMenuCinema
            // 
            this.picMainMenuCinema.Image = ((System.Drawing.Image)(resources.GetObject("picMainMenuCinema.Image")));
            this.picMainMenuCinema.Location = new System.Drawing.Point(-1, 21);
            this.picMainMenuCinema.Name = "picMainMenuCinema";
            this.picMainMenuCinema.Size = new System.Drawing.Size(800, 657);
            this.picMainMenuCinema.TabIndex = 0;
            this.picMainMenuCinema.TabStop = false;
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.screensToolStripMenuItem,
            this.moviesToolStripMenuItem,
            this.screeningToolStripMenuItem,
            this.salesToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(799, 24);
            this.MainMenuStrip.TabIndex = 1;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // screensToolStripMenuItem
            // 
            this.screensToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addScreenToolStripMenuItem,
            this.changeScreenToolStripMenuItem,
            this.changeScreenStatusToolStripMenuItem});
            this.screensToolStripMenuItem.Name = "screensToolStripMenuItem";
            this.screensToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.screensToolStripMenuItem.Text = "Screens";
            // 
            // addScreenToolStripMenuItem
            // 
            this.addScreenToolStripMenuItem.Name = "addScreenToolStripMenuItem";
            this.addScreenToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.addScreenToolStripMenuItem.Text = "Add Screen";
            this.addScreenToolStripMenuItem.Click += new System.EventHandler(this.addScreenToolStripMenuItem_Click);
            // 
            // changeScreenToolStripMenuItem
            // 
            this.changeScreenToolStripMenuItem.Name = "changeScreenToolStripMenuItem";
            this.changeScreenToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.changeScreenToolStripMenuItem.Text = "Change Screen";
            this.changeScreenToolStripMenuItem.Click += new System.EventHandler(this.changeScreenToolStripMenuItem_Click);
            // 
            // changeScreenStatusToolStripMenuItem
            // 
            this.changeScreenStatusToolStripMenuItem.Name = "changeScreenStatusToolStripMenuItem";
            this.changeScreenStatusToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.changeScreenStatusToolStripMenuItem.Text = "Change Screen Status";
            this.changeScreenStatusToolStripMenuItem.Click += new System.EventHandler(this.changeScreenStatusToolStripMenuItem_Click);
            // 
            // moviesToolStripMenuItem
            // 
            this.moviesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMovieToolStripMenuItem,
            this.changeMovieToolStripMenuItem,
            this.removeMovieToolStripMenuItem});
            this.moviesToolStripMenuItem.Name = "moviesToolStripMenuItem";
            this.moviesToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.moviesToolStripMenuItem.Text = "Movies";
            // 
            // addMovieToolStripMenuItem
            // 
            this.addMovieToolStripMenuItem.Name = "addMovieToolStripMenuItem";
            this.addMovieToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.addMovieToolStripMenuItem.Text = "Add Movie";
            this.addMovieToolStripMenuItem.Click += new System.EventHandler(this.addMovieToolStripMenuItem_Click);
            // 
            // changeMovieToolStripMenuItem
            // 
            this.changeMovieToolStripMenuItem.Name = "changeMovieToolStripMenuItem";
            this.changeMovieToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.changeMovieToolStripMenuItem.Text = "Change Movie";
            this.changeMovieToolStripMenuItem.Click += new System.EventHandler(this.changeMovieToolStripMenuItem_Click);
            // 
            // removeMovieToolStripMenuItem
            // 
            this.removeMovieToolStripMenuItem.Name = "removeMovieToolStripMenuItem";
            this.removeMovieToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.removeMovieToolStripMenuItem.Text = "Remove Movie";
            this.removeMovieToolStripMenuItem.Click += new System.EventHandler(this.removeMovieToolStripMenuItem_Click);
            // 
            // screeningToolStripMenuItem
            // 
            this.screeningToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scheduleScreeningToolStripMenuItem,
            this.changeScreeningToolStripMenuItem,
            this.removeScreeningToolStripMenuItem});
            this.screeningToolStripMenuItem.Name = "screeningToolStripMenuItem";
            this.screeningToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.screeningToolStripMenuItem.Text = "Screening";
            // 
            // scheduleScreeningToolStripMenuItem
            // 
            this.scheduleScreeningToolStripMenuItem.Name = "scheduleScreeningToolStripMenuItem";
            this.scheduleScreeningToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.scheduleScreeningToolStripMenuItem.Text = "Schedule Screening";
            this.scheduleScreeningToolStripMenuItem.Click += new System.EventHandler(this.scheduleScreeningToolStripMenuItem_Click);
            // 
            // changeScreeningToolStripMenuItem
            // 
            this.changeScreeningToolStripMenuItem.Name = "changeScreeningToolStripMenuItem";
            this.changeScreeningToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.changeScreeningToolStripMenuItem.Text = "Change Screening";
            this.changeScreeningToolStripMenuItem.Click += new System.EventHandler(this.changeScreeningToolStripMenuItem_Click);
            // 
            // removeScreeningToolStripMenuItem
            // 
            this.removeScreeningToolStripMenuItem.Name = "removeScreeningToolStripMenuItem";
            this.removeScreeningToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.removeScreeningToolStripMenuItem.Text = "Remove Screening";
            this.removeScreeningToolStripMenuItem.Click += new System.EventHandler(this.removeScreeningToolStripMenuItem_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seatTicketsToolStripMenuItem,
            this.yearlyRevenueToolStripMenuItem,
            this.soldOutScreeningsToolStripMenuItem});
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.salesToolStripMenuItem.Text = "Sales";
            // 
            // seatTicketsToolStripMenuItem
            // 
            this.seatTicketsToolStripMenuItem.Name = "seatTicketsToolStripMenuItem";
            this.seatTicketsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.seatTicketsToolStripMenuItem.Text = "Make Sale";
            this.seatTicketsToolStripMenuItem.Click += new System.EventHandler(this.seatTicketsToolStripMenuItem_Click);
            // 
            // yearlyRevenueToolStripMenuItem
            // 
            this.yearlyRevenueToolStripMenuItem.Name = "yearlyRevenueToolStripMenuItem";
            this.yearlyRevenueToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yearlyRevenueToolStripMenuItem.Text = "Yearly Revenue";
            this.yearlyRevenueToolStripMenuItem.Click += new System.EventHandler(this.yearlyRevenueToolStripMenuItem_Click);
            // 
            // soldOutScreeningsToolStripMenuItem
            // 
            this.soldOutScreeningsToolStripMenuItem.Name = "soldOutScreeningsToolStripMenuItem";
            this.soldOutScreeningsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.soldOutScreeningsToolStripMenuItem.Text = "Sold Out Screenings";
            this.soldOutScreeningsToolStripMenuItem.Click += new System.EventHandler(this.soldOutScreeningsToolStripMenuItem_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 484);
            this.Controls.Add(this.picMainMenuCinema);
            this.Controls.Add(this.MainMenuStrip);
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMainMenuCinema)).EndInit();
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMainMenuCinema;
        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem screensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeScreenStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMovieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeMovieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeMovieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem screeningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleScreeningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeScreeningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeScreeningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seatTicketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yearlyRevenueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soldOutScreeningsToolStripMenuItem;
    }
}

