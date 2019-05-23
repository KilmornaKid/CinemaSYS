namespace CinemaSYS
{
    partial class frmAddScreen
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
            this.grpAddScreen = new System.Windows.Forms.GroupBox();
            this.nudNoSeats = new System.Windows.Forms.NumericUpDown();
            this.txtScreenNo = new System.Windows.Forms.TextBox();
            this.btnAddScreen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboScreenType = new System.Windows.Forms.ComboBox();
            this.lblScreenType = new System.Windows.Forms.Label();
            this.lblNumberOfSeats = new System.Windows.Forms.Label();
            this.grpAddScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoSeats)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAddScreen
            // 
            this.grpAddScreen.Controls.Add(this.nudNoSeats);
            this.grpAddScreen.Controls.Add(this.txtScreenNo);
            this.grpAddScreen.Controls.Add(this.btnAddScreen);
            this.grpAddScreen.Controls.Add(this.label1);
            this.grpAddScreen.Controls.Add(this.cboScreenType);
            this.grpAddScreen.Controls.Add(this.lblScreenType);
            this.grpAddScreen.Controls.Add(this.lblNumberOfSeats);
            this.grpAddScreen.Location = new System.Drawing.Point(24, 46);
            this.grpAddScreen.Name = "grpAddScreen";
            this.grpAddScreen.Size = new System.Drawing.Size(724, 364);
            this.grpAddScreen.TabIndex = 0;
            this.grpAddScreen.TabStop = false;
            this.grpAddScreen.Text = "Add A Screen";
            // 
            // nudNoSeats
            // 
            this.nudNoSeats.Location = new System.Drawing.Point(176, 116);
            this.nudNoSeats.Name = "nudNoSeats";
            this.nudNoSeats.Size = new System.Drawing.Size(82, 20);
            this.nudNoSeats.TabIndex = 5;
            // 
            // txtScreenNo
            // 
            this.txtScreenNo.Enabled = false;
            this.txtScreenNo.Location = new System.Drawing.Point(176, 60);
            this.txtScreenNo.Name = "txtScreenNo";
            this.txtScreenNo.Size = new System.Drawing.Size(82, 20);
            this.txtScreenNo.TabIndex = 2;
            // 
            // btnAddScreen
            // 
            this.btnAddScreen.Location = new System.Drawing.Point(183, 257);
            this.btnAddScreen.Name = "btnAddScreen";
            this.btnAddScreen.Size = new System.Drawing.Size(219, 45);
            this.btnAddScreen.TabIndex = 4;
            this.btnAddScreen.Text = "Add Screen";
            this.btnAddScreen.UseVisualStyleBackColor = true;
            this.btnAddScreen.Click += new System.EventHandler(this.btnAddScreen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ScreenNo";
            // 
            // cboScreenType
            // 
            this.cboScreenType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboScreenType.FormattingEnabled = true;
            this.cboScreenType.Location = new System.Drawing.Point(176, 177);
            this.cboScreenType.Name = "cboScreenType";
            this.cboScreenType.Size = new System.Drawing.Size(226, 21);
            this.cboScreenType.TabIndex = 3;
            // 
            // lblScreenType
            // 
            this.lblScreenType.AutoSize = true;
            this.lblScreenType.Location = new System.Drawing.Point(56, 180);
            this.lblScreenType.Name = "lblScreenType";
            this.lblScreenType.Size = new System.Drawing.Size(68, 13);
            this.lblScreenType.TabIndex = 1;
            this.lblScreenType.Text = "Screen Type";
            // 
            // lblNumberOfSeats
            // 
            this.lblNumberOfSeats.AutoSize = true;
            this.lblNumberOfSeats.Location = new System.Drawing.Point(56, 118);
            this.lblNumberOfSeats.Name = "lblNumberOfSeats";
            this.lblNumberOfSeats.Size = new System.Drawing.Size(88, 13);
            this.lblNumberOfSeats.TabIndex = 0;
            this.lblNumberOfSeats.Text = "Number Of Seats";
            // 
            // frmAddScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 479);
            this.Controls.Add(this.grpAddScreen);
            this.Name = "frmAddScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Screen";
            this.Load += new System.EventHandler(this.frmAddScreen_Load);
            this.grpAddScreen.ResumeLayout(false);
            this.grpAddScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoSeats)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAddScreen;
        private System.Windows.Forms.Label lblNumberOfSeats;
        private System.Windows.Forms.ComboBox cboScreenType;
        private System.Windows.Forms.Label lblScreenType;
        private System.Windows.Forms.Button btnAddScreen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtScreenNo;
        private System.Windows.Forms.NumericUpDown nudNoSeats;
    }
}