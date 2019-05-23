namespace CinemaSYS
{
    partial class frmChangeScreen
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
            this.grpChangeScreen = new System.Windows.Forms.GroupBox();
            this.cboChangeScreen = new System.Windows.Forms.ComboBox();
            this.lblSelectScreen = new System.Windows.Forms.Label();
            this.grpChangingScreen = new System.Windows.Forms.GroupBox();
            this.nudNoSeats = new System.Windows.Forms.NumericUpDown();
            this.txtScreenNo = new System.Windows.Forms.TextBox();
            this.lblScreenNo = new System.Windows.Forms.Label();
            this.btnConfirmChanges = new System.Windows.Forms.Button();
            this.cboScreenType = new System.Windows.Forms.ComboBox();
            this.lblChangeScreenType = new System.Windows.Forms.Label();
            this.lblChangeAmountOfSeats = new System.Windows.Forms.Label();
            this.grpChangeScreen.SuspendLayout();
            this.grpChangingScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoSeats)).BeginInit();
            this.SuspendLayout();
            // 
            // grpChangeScreen
            // 
            this.grpChangeScreen.Controls.Add(this.cboChangeScreen);
            this.grpChangeScreen.Controls.Add(this.lblSelectScreen);
            this.grpChangeScreen.Location = new System.Drawing.Point(33, 30);
            this.grpChangeScreen.Name = "grpChangeScreen";
            this.grpChangeScreen.Size = new System.Drawing.Size(728, 111);
            this.grpChangeScreen.TabIndex = 0;
            this.grpChangeScreen.TabStop = false;
            this.grpChangeScreen.Text = "Change A Screen";
            // 
            // cboChangeScreen
            // 
            this.cboChangeScreen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChangeScreen.FormattingEnabled = true;
            this.cboChangeScreen.Location = new System.Drawing.Point(140, 60);
            this.cboChangeScreen.Name = "cboChangeScreen";
            this.cboChangeScreen.Size = new System.Drawing.Size(114, 21);
            this.cboChangeScreen.TabIndex = 3;
            this.cboChangeScreen.SelectedIndexChanged += new System.EventHandler(this.cboChangeScreen_SelectedIndexChanged);
            // 
            // lblSelectScreen
            // 
            this.lblSelectScreen.AutoSize = true;
            this.lblSelectScreen.Location = new System.Drawing.Point(47, 63);
            this.lblSelectScreen.Name = "lblSelectScreen";
            this.lblSelectScreen.Size = new System.Drawing.Size(74, 13);
            this.lblSelectScreen.TabIndex = 0;
            this.lblSelectScreen.Text = "Select Screen";
            // 
            // grpChangingScreen
            // 
            this.grpChangingScreen.Controls.Add(this.nudNoSeats);
            this.grpChangingScreen.Controls.Add(this.txtScreenNo);
            this.grpChangingScreen.Controls.Add(this.lblScreenNo);
            this.grpChangingScreen.Controls.Add(this.btnConfirmChanges);
            this.grpChangingScreen.Controls.Add(this.cboScreenType);
            this.grpChangingScreen.Controls.Add(this.lblChangeScreenType);
            this.grpChangingScreen.Controls.Add(this.lblChangeAmountOfSeats);
            this.grpChangingScreen.Location = new System.Drawing.Point(33, 161);
            this.grpChangingScreen.Name = "grpChangingScreen";
            this.grpChangingScreen.Size = new System.Drawing.Size(728, 277);
            this.grpChangingScreen.TabIndex = 1;
            this.grpChangingScreen.TabStop = false;
            this.grpChangingScreen.Text = "Change Selected Screen";
            // 
            // nudNoSeats
            // 
            this.nudNoSeats.Location = new System.Drawing.Point(140, 103);
            this.nudNoSeats.Name = "nudNoSeats";
            this.nudNoSeats.Size = new System.Drawing.Size(68, 20);
            this.nudNoSeats.TabIndex = 7;
            // 
            // txtScreenNo
            // 
            this.txtScreenNo.Enabled = false;
            this.txtScreenNo.Location = new System.Drawing.Point(140, 51);
            this.txtScreenNo.Name = "txtScreenNo";
            this.txtScreenNo.Size = new System.Drawing.Size(68, 20);
            this.txtScreenNo.TabIndex = 6;
            // 
            // lblScreenNo
            // 
            this.lblScreenNo.AutoSize = true;
            this.lblScreenNo.Location = new System.Drawing.Point(47, 54);
            this.lblScreenNo.Name = "lblScreenNo";
            this.lblScreenNo.Size = new System.Drawing.Size(58, 13);
            this.lblScreenNo.TabIndex = 5;
            this.lblScreenNo.Text = "Screen No";
            // 
            // btnConfirmChanges
            // 
            this.btnConfirmChanges.Location = new System.Drawing.Point(176, 214);
            this.btnConfirmChanges.Name = "btnConfirmChanges";
            this.btnConfirmChanges.Size = new System.Drawing.Size(329, 29);
            this.btnConfirmChanges.TabIndex = 4;
            this.btnConfirmChanges.Text = "Confirm Changes";
            this.btnConfirmChanges.UseVisualStyleBackColor = true;
            this.btnConfirmChanges.Click += new System.EventHandler(this.btnConfirmChanges_Click);
            // 
            // cboScreenType
            // 
            this.cboScreenType.FormattingEnabled = true;
            this.cboScreenType.Location = new System.Drawing.Point(140, 160);
            this.cboScreenType.Name = "cboScreenType";
            this.cboScreenType.Size = new System.Drawing.Size(216, 21);
            this.cboScreenType.TabIndex = 3;
            // 
            // lblChangeScreenType
            // 
            this.lblChangeScreenType.AutoSize = true;
            this.lblChangeScreenType.Location = new System.Drawing.Point(47, 163);
            this.lblChangeScreenType.Name = "lblChangeScreenType";
            this.lblChangeScreenType.Size = new System.Drawing.Size(68, 13);
            this.lblChangeScreenType.TabIndex = 1;
            this.lblChangeScreenType.Text = "Screen Type";
            // 
            // lblChangeAmountOfSeats
            // 
            this.lblChangeAmountOfSeats.AutoSize = true;
            this.lblChangeAmountOfSeats.Location = new System.Drawing.Point(47, 105);
            this.lblChangeAmountOfSeats.Name = "lblChangeAmountOfSeats";
            this.lblChangeAmountOfSeats.Size = new System.Drawing.Size(86, 13);
            this.lblChangeAmountOfSeats.TabIndex = 0;
            this.lblChangeAmountOfSeats.Text = "Number of Seats";
            // 
            // frmChangeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.grpChangingScreen);
            this.Controls.Add(this.grpChangeScreen);
            this.Name = "frmChangeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Screen";
            this.Load += new System.EventHandler(this.frmChangeScreen_Load);
            this.grpChangeScreen.ResumeLayout(false);
            this.grpChangeScreen.PerformLayout();
            this.grpChangingScreen.ResumeLayout(false);
            this.grpChangingScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoSeats)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpChangeScreen;
        private System.Windows.Forms.Label lblSelectScreen;
        private System.Windows.Forms.ComboBox cboChangeScreen;
        private System.Windows.Forms.GroupBox grpChangingScreen;
        private System.Windows.Forms.Label lblChangeAmountOfSeats;
        private System.Windows.Forms.Label lblChangeScreenType;
        private System.Windows.Forms.ComboBox cboScreenType;
        private System.Windows.Forms.Button btnConfirmChanges;
        private System.Windows.Forms.TextBox txtScreenNo;
        private System.Windows.Forms.Label lblScreenNo;
        private System.Windows.Forms.NumericUpDown nudNoSeats;
    }
}