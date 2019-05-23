namespace CinemaSYS
{
    partial class frmChangeScreenStatus
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
            this.lblSelectScreen = new System.Windows.Forms.Label();
            this.grpChangeScreenStatus = new System.Windows.Forms.GroupBox();
            this.cboSelectScreen = new System.Windows.Forms.ComboBox();
            this.grpSelectStatus = new System.Windows.Forms.GroupBox();
            this.btnConfirmChanges = new System.Windows.Forms.Button();
            this.cboChangeScreenStatus = new System.Windows.Forms.ComboBox();
            this.lblChangeStatus = new System.Windows.Forms.Label();
            this.grpChangeScreenStatus.SuspendLayout();
            this.grpSelectStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelectScreen
            // 
            this.lblSelectScreen.AutoSize = true;
            this.lblSelectScreen.Location = new System.Drawing.Point(43, 54);
            this.lblSelectScreen.Name = "lblSelectScreen";
            this.lblSelectScreen.Size = new System.Drawing.Size(74, 13);
            this.lblSelectScreen.TabIndex = 0;
            this.lblSelectScreen.Text = "Select Screen";
            // 
            // grpChangeScreenStatus
            // 
            this.grpChangeScreenStatus.Controls.Add(this.cboSelectScreen);
            this.grpChangeScreenStatus.Controls.Add(this.lblSelectScreen);
            this.grpChangeScreenStatus.Location = new System.Drawing.Point(27, 28);
            this.grpChangeScreenStatus.Name = "grpChangeScreenStatus";
            this.grpChangeScreenStatus.Size = new System.Drawing.Size(745, 126);
            this.grpChangeScreenStatus.TabIndex = 1;
            this.grpChangeScreenStatus.TabStop = false;
            this.grpChangeScreenStatus.Text = "Change Screen Status";
            // 
            // cboSelectScreen
            // 
            this.cboSelectScreen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectScreen.FormattingEnabled = true;
            this.cboSelectScreen.Location = new System.Drawing.Point(140, 51);
            this.cboSelectScreen.Name = "cboSelectScreen";
            this.cboSelectScreen.Size = new System.Drawing.Size(238, 21);
            this.cboSelectScreen.TabIndex = 1;
            this.cboSelectScreen.SelectedIndexChanged += new System.EventHandler(this.cboSelectScreen_SelectedIndexChanged);
            // 
            // grpSelectStatus
            // 
            this.grpSelectStatus.Controls.Add(this.btnConfirmChanges);
            this.grpSelectStatus.Controls.Add(this.cboChangeScreenStatus);
            this.grpSelectStatus.Controls.Add(this.lblChangeStatus);
            this.grpSelectStatus.Location = new System.Drawing.Point(27, 181);
            this.grpSelectStatus.Name = "grpSelectStatus";
            this.grpSelectStatus.Size = new System.Drawing.Size(745, 206);
            this.grpSelectStatus.TabIndex = 2;
            this.grpSelectStatus.TabStop = false;
            this.grpSelectStatus.Text = "Select Status";
            // 
            // btnConfirmChanges
            // 
            this.btnConfirmChanges.Location = new System.Drawing.Point(140, 136);
            this.btnConfirmChanges.Name = "btnConfirmChanges";
            this.btnConfirmChanges.Size = new System.Drawing.Size(329, 29);
            this.btnConfirmChanges.TabIndex = 5;
            this.btnConfirmChanges.Text = "Confirm Changes";
            this.btnConfirmChanges.UseVisualStyleBackColor = true;
            this.btnConfirmChanges.Click += new System.EventHandler(this.btnConfirmChanges_Click);
            // 
            // cboChangeScreenStatus
            // 
            this.cboChangeScreenStatus.FormattingEnabled = true;
            this.cboChangeScreenStatus.Location = new System.Drawing.Point(140, 76);
            this.cboChangeScreenStatus.Name = "cboChangeScreenStatus";
            this.cboChangeScreenStatus.Size = new System.Drawing.Size(238, 21);
            this.cboChangeScreenStatus.TabIndex = 1;
            // 
            // lblChangeStatus
            // 
            this.lblChangeStatus.AutoSize = true;
            this.lblChangeStatus.Location = new System.Drawing.Point(43, 78);
            this.lblChangeStatus.Name = "lblChangeStatus";
            this.lblChangeStatus.Size = new System.Drawing.Size(80, 13);
            this.lblChangeStatus.TabIndex = 0;
            this.lblChangeStatus.Text = "Change Status ";
            // 
            // frmChangeScreenStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpSelectStatus);
            this.Controls.Add(this.grpChangeScreenStatus);
            this.Name = "frmChangeScreenStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Screen Status";
            this.Load += new System.EventHandler(this.frmChangeScreenStatus_Load);
            this.grpChangeScreenStatus.ResumeLayout(false);
            this.grpChangeScreenStatus.PerformLayout();
            this.grpSelectStatus.ResumeLayout(false);
            this.grpSelectStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSelectScreen;
        private System.Windows.Forms.GroupBox grpChangeScreenStatus;
        private System.Windows.Forms.ComboBox cboSelectScreen;
        private System.Windows.Forms.GroupBox grpSelectStatus;
        private System.Windows.Forms.ComboBox cboChangeScreenStatus;
        private System.Windows.Forms.Label lblChangeStatus;
        private System.Windows.Forms.Button btnConfirmChanges;
    }
}