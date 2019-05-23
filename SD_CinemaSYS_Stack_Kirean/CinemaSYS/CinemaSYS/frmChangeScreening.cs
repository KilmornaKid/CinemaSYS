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
    public partial class frmChangeScreening : Form
    {

        Screening updScreening = new Screening();

        public frmChangeScreening()
        {
            InitializeComponent();
        }

        private void frmChangeScreening_Load(object sender, EventArgs e)
        {
           // dtpDateFrom.MinDate = DateTime.Today;


            grpScheduleScreening.Visible = false;

            loadCombo();
            loadComboScreen();
            loadComboMovie();
            loadComboTimes();
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

        private void cboSelectScreening_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpScheduleScreening.Visible = true;

            //if resetting combo, ignore
            if (cboSelectScreening.SelectedIndex == -1)
            {
                return;
            }
            //find screen details
            updScreening = new Screening();
            updScreening.getScreening(Convert.ToInt32(cboSelectScreening.Text.Substring(12, 1)));

            if (updScreening.getScreenNo().Equals(0))
            {
                MessageBox.Show("No details found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //display Screen details
            txtScreeningNumber.Text = updScreening.getScreeningNo().ToString();
            dtpDateFrom.Value = updScreening.getDateFrom();
            dtpDateTo.Value = updScreening.getDateTo();
            cboTimes.SelectedIndex = updScreening.getTime()-1;
            txtseatsAvailable.Text = updScreening.getSeatsAvailable().ToString();
            txtMaxSeats.Text = updScreening.getMaxSeats().ToString();
            cboScreenNo.SelectedIndex = updScreening.getScreenNo()-1;
            cboMovieId.SelectedIndex = updScreening.getMovieId()-1;

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

        public void loadComboScreen()
        {
            DataSet ds = new DataSet();
            ds = Screen.getAllAvailableScreens(ds);

            cboScreenNo.Items.Clear();

            for (int i = 0; i < ds.Tables["gaas"].Rows.Count; i++)
                cboScreenNo.Items.Add("Screen".ToString() + "  " + ds.Tables[0].Rows[i][0].ToString().PadLeft(2, '0'));

            cboMovieId.SelectedIndex = -1;
        }


        public void loadComboTimes()
        {
            DataSet ds = new DataSet();
            ds = ScreeningTimes.getAllScreeningTimes(ds);

            cboTimes.Items.Clear();

            for (int i = 0; i < ds.Tables["gasct"].Rows.Count; i++)
                cboTimes.Items.Add(ds.Tables[0].Rows[i][0].ToString() + ". " + ds.Tables[0].Rows[i][1].ToString());

            cboTimes.SelectedIndex = -1;

        }


        private void cboScreenNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Screen.isAvailable(cboScreenNo.Text.Substring(8, 2)) == false)
            {
                MessageBox.Show("Cannot use screen as it is currently blocked");
                loadCombo();
                grpScheduleScreening.Visible = false;
                return;
            }

            Screen myScreen = new Screen();
            myScreen.getScreen(Convert.ToInt32(cboScreenNo.Text.Substring(8, 2)));
            txtMaxSeats.Text = Convert.ToString(myScreen.getNumberOfSeats().ToString());
            txtseatsAvailable.Text = Convert.ToString(myScreen.getNumberOfSeats().ToString());
        }

        private void btnScheduleScreening_Click(object sender, EventArgs e)
        {
            if (dtpDateTo.Value < dtpDateFrom.Value)
            {
                MessageBox.Show("Error! Date To must be later than or Equal to Date From");
                dtpDateTo.Focus();
                return;
            }

            string time = cboTimes.Text.Substring(3, 5);
            string fromDate = dtpDateFrom.Value.ToShortDateString();
            string toDate = dtpDateTo.Value.ToShortDateString();

            if (Screening.isTimeBooked(time, cboScreenNo.Text.Substring(8, 2), fromDate, toDate) == true)
            {
                MessageBox.Show("Error! This time for this screen is already booked!");
                return;
            }

            updScreening.setScreeningNumber(Convert.ToInt32(txtScreeningNumber.Text));
            updScreening.setDateFrom(Convert.ToDateTime(dtpDateFrom.Text));
            updScreening.setDateTo(Convert.ToDateTime(dtpDateTo.Text));
            updScreening.setTime(Convert.ToInt32(cboTimes.Text.Substring(0,1)));
            updScreening.setSeatsAvailable(Convert.ToInt32(txtMaxSeats.Text));
            updScreening.setMaxSeats(Convert.ToInt32(txtMaxSeats.Text));
            updScreening.setScreenNo(Convert.ToInt32(cboScreenNo.Text.Substring(8,2)));
            updScreening.setMovieId(Convert.ToInt32(cboMovieId.Text.Substring(0,1)));
            updScreening.updScreen();

            MessageBox.Show("Movie " + txtScreeningNumber.Text + " Updated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            loadCombo();

            grpScheduleScreening.Visible = false;
        }

       
    }
}
