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
    public partial class frmChangeScreen : Form
    {

        public frmChangeScreen()
        {
            InitializeComponent();
        }

        private void frmChangeScreen_Load(object sender, EventArgs e)
        {
            nudNoSeats.Value = 100;
            nudNoSeats.Minimum = 100;
            nudNoSeats.Maximum = 200;

            loadComboScreen();

            loadCombo();

            grpChangingScreen.Visible = false;

        }


        private void btnConfirmChanges_Click(object sender, EventArgs e)
        {
            //instantiate Screen Object
            Screen myScreen = new Screen();
            myScreen.setSno(Convert.ToInt32(txtScreenNo.Text));
            myScreen.setNumberOfSeats(Convert.ToInt32(nudNoSeats.Text));
            myScreen.setScreenTypeId(Convert.ToInt32(cboScreenType.Text.Substring(0, 1)));

            //INSERT Screen record into screen table
            myScreen.updScreen();

            //Display Confirmation Message
            MessageBox.Show("Screen " + txtScreenNo.Text + " Updated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            grpChangingScreen.Visible = false;

            loadComboScreen();

        }

        private void cboChangeScreen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Screen.isRemoved(cboChangeScreen.Text.Substring(8, 2)) == false)
            {
                MessageBox.Show("Error! Screen status must be set to removed to edit details");
                loadComboScreen();
                return;
            }

            grpChangingScreen.Visible = true;

            //if resetting combo, ignore
            if (cboChangeScreen.SelectedIndex == -1)
            {
                return;
            }
            //find screen details
            Screen updScreen = new Screen();
            updScreen.getScreen(Convert.ToInt32(cboChangeScreen.Text.Substring(8,2)));

            if (updScreen.getScreenNo().Equals(0))
            {
                MessageBox.Show("No details found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtScreenNo.Focus();
                return;
            }
            

            //display Screen details
            txtScreenNo.Text = updScreen.getScreenNo().ToString("00");
            nudNoSeats.Text = updScreen.getNumberOfSeats().ToString();
            cboScreenType.SelectedIndex = updScreen.getScreenTypeId()-1;

            //display details
            grpChangingScreen.Visible = true;
        }


        public void loadCombo()
        {
            // create instance of data set
            DataSet ds = new DataSet();

            ds = ScreenType.getScreenTypes(ds);

            //Remove existing items from combo box
            cboScreenType.Items.Clear();

            //load data from ds to cboScreenType
            for (int i = 0; i < ds.Tables["gst"].Rows.Count; i++)
                cboScreenType.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(1, '0') + " " + ds.Tables[0].Rows[i][1].ToString());

            cboScreenType.SelectedIndex = -1;
        }


        public void loadComboScreen()
        {
            // create instance of data set
            DataSet ds = new DataSet();

            ds = Screen.getAllRemovedScreens(ds);

            //Remove existing items from combo box
            cboChangeScreen.Items.Clear();

            //load combo with screenNo and Description for all screens
            for (int i = 0; i < ds.Tables["gars"].Rows.Count; i++)
                cboChangeScreen.Items.Add("Screen".ToString() + "  " + ds.Tables[0].Rows[i][0].ToString().PadLeft(2, '0'));
        }

    }
}
