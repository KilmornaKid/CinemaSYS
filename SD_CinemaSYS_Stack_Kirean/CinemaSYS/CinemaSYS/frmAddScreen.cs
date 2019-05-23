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
    public partial class frmAddScreen : Form
    {

        public frmAddScreen()
        {
            InitializeComponent();
        }

        private void frmAddScreen_Load(object sender, EventArgs e)
        {
            nudNoSeats.Value = 100;
            nudNoSeats.Minimum = 100;
            nudNoSeats.Maximum = 200;
            txtScreenNo.Text = Screen.nextScreen_No().ToString("00");
            DataSet ds = new DataSet();

            loadCombo();
        }


        public void loadCombo()
        {
            // create instance of data set
            DataSet ds = new DataSet();

            ds = ScreenType.getScreenTypes(ds);

            //Remove existing items from combo box
            cboScreenType.Items.Clear();

            //load data from ds to cboScreen
            for (int i = 0; i < ds.Tables["gst"].Rows.Count; i++)
                cboScreenType.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(1, '0') + " " + ds.Tables[0].Rows[i][1].ToString());
        }

        private void btnAddScreen_Click(object sender, EventArgs e)
        {

            //Validation
            if (cboScreenType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a screen type ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nudNoSeats.Focus();
                return;
            }

            //save screen details in DB
            Screen myScreen = new Screen(Convert.ToInt32(txtScreenNo.Text), Convert.ToInt32(nudNoSeats.Text), Convert.ToInt32(cboScreenType.Text.Substring(0,1)), Convert.ToInt32(1));
            myScreen.regScreen();



            //Display confirmation Message
            MessageBox.Show("Screen Details \r\nScreen No: " + txtScreenNo.Text + "\r\nNumber of Seats: " + nudNoSeats.Text + "\r\nScreen Type: " + cboScreenType.Text + "\r\nStatus: Availible",
                                                        "Confirm Cancel!!", MessageBoxButtons.OK);

            //reset UI
            txtScreenNo.Text = Screen.nextScreen_No().ToString("00");
            nudNoSeats.Value = 100;
            loadCombo();

        }

    }
}
