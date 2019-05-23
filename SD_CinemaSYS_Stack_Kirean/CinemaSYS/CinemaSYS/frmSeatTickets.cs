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

    public partial class frmSeatTickets : Form
    {
        Screening fndScreening = new Screening();
        DateTime today = DateTime.Today;
        Sale sale = new Sale();
        Screening screen = new Screening();
        Screening updScreening = new Screening();
        DateTime fromDate = new DateTime();
        DateTime toDate = new DateTime();
        DataSet ds = new DataSet();
        

        public frmSeatTickets()
        {
            InitializeComponent();
        }

        private void frmSeatTickets_Load(object sender, EventArgs e)
        {
            
            //Data loaded to screen
            txtSaleId.Text = Sale.nextSale_Id().ToString("00000");
            loadComboMovie();
            loadComboRates();
            
            String theDate = dtpDateFrom.Value.ToShortDateString();
            dtpDateFrom.Format = DateTimePickerFormat.Custom;
            dtpDateFrom.CustomFormat = "dd-MM-yy";

            String theDate2 = dtpDateTo.Value.ToShortDateString();
            dtpDateTo.Format = DateTimePickerFormat.Custom;
            dtpDateTo.CustomFormat = "dd-MM-yy";


            //txtMaxSeats = Screening.get
            nudNumOfTickets.Minimum = 1;

        }

        public void loadComboMovie()
        {
            // create instance of data set
            DataSet ds = new DataSet();

            ds = Movie.getAllMovies(ds);

            //Remove existing items from combo box
            cboSelectMovie.Items.Clear();

            //load data from ds to cboMovie
            for (int i = 0; i < ds.Tables["gam"].Rows.Count; i++)
                cboSelectMovie.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(2, '0') + " " + ds.Tables[0].Rows[i][1].ToString());

            cboSelectMovie.SelectedIndex = -1;
        }

        public void loadComboRates()
        {
            DataSet ds = new DataSet();
            ds = Rate.getAllRates(ds);

            cboSelectRate.Items.Clear();

            for (int i = 0; i < ds.Tables["rat"].Rows.Count; i++)
                cboSelectRate.Items.Add(ds.Tables[0].Rows[i][0].ToString() + ' ' + ds.Tables[0].Rows[i][1].ToString());

            cboSelectRate.SelectedIndex = -1;
        }

        private void btnBookTicket_Click(object sender, EventArgs e)
        {
            if (cboSelectMovie.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a movie!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cboDate.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Date! ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
            sale.setSaleId(Convert.ToInt32(txtSaleId.Text));
            sale.setScreeningNumber(Convert.ToInt32(cboSelectMovie.Text.Substring(0, 1)));
            sale.setRateId(Convert.ToInt32(cboSelectRate.Text.Substring(0, 1)));
            sale.regSale();

            screen.setScreeningNumber(Convert.ToInt32(cboSelectMovie.Text.Substring(0, 1)));
            screen.setSeatsAvailable(Convert.ToInt32(txtseatsAvailable.Text));
            screen.updAvailSeats();

            MessageBox.Show("Ticket Booked " + txtSaleId.Text, "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);


            loadComboMovie();
            loadComboRates();
            txtSaleId.Text = Sale.nextSale_Id().ToString("00000");
            
        }

        private void cboSelectMovie_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //find screen details
            updScreening = new Screening();
            updScreening.getScreeningTwo(Convert.ToInt32(cboSelectMovie.Text.Substring(0, 2)));

            dtpDateFrom.Value = updScreening.getDateFrom();
            dtpDateTo.Value = updScreening.getDateTo();

            fromDate = dtpDateFrom.Value;
            toDate = dtpDateTo.Value;

            loadComboDates();
        }

        public void loadComboDates()
        {
            cboDate.Items.Clear();

            updScreening.setDateFrom(fromDate);
            updScreening.setDateTo(toDate);

            for (DateTime date = fromDate; date <= toDate; date = date.AddDays(1))
            {
                if(date >= today)
                {
                    cboDate.Items.Add(date);
                }
                
            }

            cboDate.SelectedIndex = -1;
        }

        private void cboDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadComboTimes();
        }


        public void loadComboTimes()
        {
            DataSet ds = new DataSet();
            ds = Screening.getTimes(cboSelectMovie.Text.Substring(0, 1), cboDate.SelectedText.ToString());

            for (int i = 0; i < ds.Tables["getTimes"].Rows.Count; i++)
                cboTime.Items.Add(ds.Tables[0].Rows[i][0].ToString() + ' ' + ds.Tables[0].Rows[i][9].ToString());

            cboSelectRate.SelectedIndex = -1;

        }
    }
}
