using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaSYS
{
    public partial class frmChangeScreenStatus : Form
    {
        frmMainMenu parent;
        Screen myScreen = new Screen();

        public frmChangeScreenStatus()
        {
            InitializeComponent();
        }

        private void frmChangeScreenStatus_Load(object sender, EventArgs e)
        {

            grpSelectStatus.Visible = false;
            loadComboScreen();
            loadComboStatus();
        }

        private void cboSelectScreen_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboSelectScreen.SelectedIndex == -1)
            {
                return;
            }

            if (Screen.isScheduled(cboSelectScreen.Text.Substring(8,2)) == true)
            {
                MessageBox.Show("Cannot change status as screen has already been scheduled!");
                loadComboScreen();
                return;
            }

           // myScreen = new Screen();

            myScreen.getScreen(Convert.ToInt32(cboSelectScreen.Text.Substring(8, 2)));
            cboChangeScreenStatus.Text = myScreen.getScreenStatusId().ToString();

            grpSelectStatus.Visible = true;

        }

        public void loadComboStatus()
        {
            // create instance of data set
            DataSet ds = new DataSet();

            ds = ScreenStatus.getScreenStatus(ds);

            //Remove existing items from combo box
            cboChangeScreenStatus.Items.Clear();

            //load data from ds to cboSearchStatus
            for (int i = 0; i < ds.Tables["gss"].Rows.Count; i++)
                cboChangeScreenStatus.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(1, '0') + ". " + ds.Tables[0].Rows[i][1].ToString());
        }

        public void loadComboScreen()
        {
            DataSet ds = new DataSet();
            ds = Screen.getAllScreens(ds);

            cboSelectScreen.Items.Clear();

            for (int i = 0; i < ds.Tables["gas"].Rows.Count; i++)
                cboSelectScreen.Items.Add("Screen".ToString() + "  " + ds.Tables[0].Rows[i][0].ToString().PadLeft(2, '0'));
        }

        private void btnConfirmChanges_Click(object sender, EventArgs e)
        {
            
            myScreen.setScreenStatusId(Convert.ToInt32(cboChangeScreenStatus.Text.Substring(0, 1)));
            myScreen.updScreenStatus(Convert.ToInt32(cboSelectScreen.Text.Substring(8, 2)));
            MessageBox.Show("Screen Status Updated!");
            grpSelectStatus.Visible = false;
            loadComboScreen();
        }

    }
}
