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
    public partial class frmScheduleScreening : Form
    {
        Screening myScreening = new Screening();

        public frmScheduleScreening()
        {
            InitializeComponent();
        }

        private void frmScheduleScreening_Load(object sender, EventArgs e)
        {
            txtScreeningNumber.Text = Screening.nextScreening_Number().ToString("00");

            dtpDateFrom.MinDate = DateTime.Today;
            

            String theDate = dtpDateFrom.Value.ToShortDateString();
            dtpDateFrom.Format = DateTimePickerFormat.Custom;
            dtpDateFrom.CustomFormat = "dd-MM-yy";

            String theDate2 = dtpDateTo.Value.ToShortDateString();
            dtpDateTo.Format = DateTimePickerFormat.Custom;
            dtpDateTo.CustomFormat = "dd-MM-yy";

            loadComboTimes();

            loadComboScreen();

            loadComboMovie();

 

        }


        public void loadComboMovie()
        {
            // create instance of data set
            DataSet ds = new DataSet();

            ds = Movie.getAllMovies(ds);

            //Remove existing items from combo box
            cboMovieId.Items.Clear();

            //load data from ds to cboMovie
            for (int i = 0; i < ds.Tables["gam"].Rows.Count; i++)
                cboMovieId.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(1, '0') + " " + ds.Tables[0].Rows[i][1].ToString());

            cboMovieId.SelectedIndex = -1;
        }

        public void loadComboScreen()
        {
            DataSet ds = new DataSet();
            ds = Screen.getAllAvailableScreens(ds);

            cboScreenNo.Items.Clear();

            for (int i = 0; i < ds.Tables["gaas"].Rows.Count; i++)
                cboScreenNo.Items.Add("Screen".ToString() + "  " + ds.Tables[0].Rows[i][0].ToString().PadLeft(2, '0'));

            cboScreenNo.SelectedIndex = -1;
        }

        public void loadComboTimes()
        {
            DataSet ds = new DataSet();
            ds = ScreeningTimes.getAllScreeningTimes(ds);

            cboTimes.Items.Clear();

            for (int i = 0; i < ds.Tables["gasct"].Rows.Count; i++)
                cboTimes.Items.Add(ds.Tables[0].Rows[i][0].ToString()+ ". "+ds.Tables[0].Rows[i][1].ToString());

            cboTimes.SelectedIndex = -1;

        }

        private void btnScheduleScreening_Click(object sender, EventArgs e)
        {
            if (dtpDateTo.Value < dtpDateFrom.Value)
            {
                MessageBox.Show("Date To must be later than Date From", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDateTo.Focus();
                return;
            }

            if (cboScreenNo.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an screen! ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cboTimes.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Time! ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cboMovieId.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a movie! ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string time = cboTimes.Text.Substring(3, 5);
            string fromDate = dtpDateFrom.Value.ToShortDateString();
            string toDate = dtpDateTo.Value.ToShortDateString();

            if (Screening.isTimeBooked(time,cboScreenNo.Text.Substring(8, 2), fromDate, toDate) == true)
            {
                MessageBox.Show("This time for this screen is already booked!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            myScreening = new Screening();
            myScreening.setScreeningNumber(Convert.ToInt32(txtScreeningNumber.Text));
            myScreening.setDateFrom(Convert.ToDateTime(dtpDateFrom.Text));
            myScreening.setDateTo(Convert.ToDateTime(dtpDateTo.Text));
            myScreening.setTime(Convert.ToInt32(cboTimes.Text.Substring(0, 1)));
            myScreening.setSeatsAvailable(Convert.ToInt32(txtMaxSeats.Text));
            myScreening.setMaxSeats(Convert.ToInt32(txtMaxSeats.Text));
            myScreening.setScreenNo(Convert.ToInt32(cboScreenNo.Text.Substring(8, 2)));
            myScreening.setMovieId(Convert.ToInt32(cboMovieId.Text.Substring(0,1)));
            myScreening.regScreening();

            //Display Confirmation Message
            MessageBox.Show("Screening " + txtScreeningNumber.Text + " Updated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtScreeningNumber.Text = Screening.nextScreening_Number().ToString("00");
            dtpDateFrom.ResetText();
            dtpDateTo.ResetText();
            txtMaxSeats.ResetText();
            txtseatsAvailable.ResetText();
            loadComboScreen();
            loadComboMovie();
            loadComboTimes();
        }

        private void cboScreenNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Screen.isAvailable(cboScreenNo.Text.Substring(8, 2)) == false)
            {
                MessageBox.Show("Cannot use screen as it is currently blocked");
                loadComboScreen();
                return;
            }

            Screen myScreen = new Screen();
            myScreen.getScreen(Convert.ToInt32(cboScreenNo.Text.Substring(8, 2)));
            txtMaxSeats.Text = Convert.ToString(myScreen.getNumberOfSeats().ToString());
            txtseatsAvailable.Text = Convert.ToString(myScreen.getNumberOfSeats().ToString());

            
        }

    }
}
