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
    public partial class frmRemoveScreening : Form
    {
        Screening myScreening = new Screening();

        public frmRemoveScreening()
        {
            InitializeComponent();
        }

        private void frmRemoveScreening_Load(object sender, EventArgs e)
        {
            grpScheduleScreening.Visible = false;

            loadCombo();
            loadComboMovie();
        }


       
        public void loadCombo()
        {
            DataSet ds = new DataSet();
            ds = Screening.getAllScreenings(ds);

            cboSelectScreening.Items.Clear();

            for (int i = 0; i < ds.Tables["gasc"].Rows.Count; i++)
                cboSelectScreening.Items.Add("Screening".ToString() + "  " + ds.Tables[0].Rows[i][0].ToString().PadLeft(2, '0'));

            cboSelectScreening.SelectedIndex = -1;
        }

        public void loadComboMovie()
        {
            // create instance of data set
            DataSet ds = new DataSet();

            ds = Movie.getAllMovies(ds);

            //Remove existing items from combo box
            cboMovieId.Items.Clear();

            //load data from ds to cboScreenType
            for (int i = 0; i < ds.Tables["gam"].Rows.Count; i++)
                cboMovieId.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(1, '0') + "  " + ds.Tables[0].Rows[i][1].ToString());

            cboMovieId.SelectedIndex = -1;
        }

        private void cboSelectScreening_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpScheduleScreening.Visible = false;
            if (Screening.isBooked(cboSelectScreening.Text.Substring(12, 1)) == true)
            {
                MessageBox.Show("Screening cannot be removed as it has been booked!");
                loadCombo();
                return;
            }

            grpScheduleScreening.Visible = true;

            //if resetting combo, ignore
            if (cboSelectScreening.SelectedIndex == -1)
            {
                return;
            }
            //find screen details
            myScreening = new Screening();
            myScreening.getScreening(Convert.ToInt32(cboSelectScreening.Text.Substring(12, 1)));

            if (myScreening.getScreenNo().Equals(0))
            {
                MessageBox.Show("No details found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            txtScreeningNumber.Text = myScreening.getScreeningNo().ToString();
            dtpDateFrom.Value = myScreening.getDateFrom();
            dtpDateTo.Value = myScreening.getDateTo();
            cboTimes.Text = myScreening.getTime().ToString();
            txtseatsAvailable.Text = myScreening.getSeatsAvailable().ToString();
            txtMaxSeats.Text = myScreening.getMaxSeats().ToString();
            cboScreenNo.Text = myScreening.getScreenNo().ToString();
            cboMovieId.Text = myScreening.getMovieId().ToString();
        }

        private void btnRemoveScreening_Click(object sender, EventArgs e)
        {
            if (myScreening.getScreeningNo().Equals(0))
            {
                MessageBox.Show("No details found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            myScreening.rmScreening();

            MessageBox.Show("Movie Details \r\nScreening Number: " + txtScreeningNumber.Text + "\r\nOpening Date: " + dtpDateFrom.Text + "\r\nClosing Date: " + dtpDateTo.Text + "\r\nTime: " + cboTimes.Text + "\r\nMovie ID: " + cboMovieId.Text + "\r\nScreen No: " + cboScreenNo.Text,
                                                        "Confirm Cancel!!", MessageBoxButtons.OK);
            grpScheduleScreening.Visible = false;
            loadCombo();
        }
    }
}
