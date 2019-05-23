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
    public partial class frmRemoveMovie : Form
    {
        Movie myMovie = new Movie();

        public frmRemoveMovie()
        {
            InitializeComponent();
        }

        private void frmRemoveMovie_Load(object sender, EventArgs e)
        {
            grpRemoveSelectedMovie.Visible = false;

            loadCombo();
        }

        private void btnRemoveMovie_Click(object sender, EventArgs e)
        {
            
            if (myMovie.getMovieId().Equals(0))
            {
                MessageBox.Show("No details found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            myMovie.rmMovie();

            MessageBox.Show("Movie Details \r\nMovie ID: " + txtMovieId.Text + "\r\nMovie Name: " + txtMovieName.Text + "\r\nRunning Time:: " + nudRunningTime.Text + "\r\nAge Rating: " + cboAgeRating.Text + "\r\nDescription: " + txtDescription.Text,
                                                        "Confirm Cancel!!", MessageBoxButtons.OK);
            grpRemoveSelectedMovie.Visible = false;
            cboSearchMovie.Items.Clear();
            loadCombo();
            

        }
        

        private void cboSearchMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public void loadCombo()
        {
            // create instance of data set
            DataSet ds = new DataSet();

            ds = Movie.getAllMovies(ds);

            //Remove existing items from combo box
            cboSearchMovie.Items.Clear();

            //load data from ds to cboSearchScreen
            for (int i = 0; i < ds.Tables["gam"].Rows.Count; i++)
                cboSearchMovie.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(1, '0') + ". " + ds.Tables[0].Rows[i][1].ToString());
        }

        private void cboSearchMovie_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (Movie.isShowing(cboSearchMovie.Text.Substring(0, 1)) == true)
            {
                MessageBox.Show("Cannot remove movie as it is currently scheduled!");
                loadCombo();
                return;
            }

            grpRemoveSelectedMovie.Visible = true;

            if (cboSearchMovie.SelectedIndex == -1)
            {
                return;
            }

            //display Movie details
            myMovie = Movie.getMovieById(Convert.ToInt32(cboSearchMovie.Text.Substring(0, 1)));
            txtMovieId.Text = myMovie.getMovieId().ToString();
            txtMovieName.Text = Convert.ToString(myMovie.getMovieName());
            nudRunningTime.Text = Convert.ToString(myMovie.getRunningTime());
            cboAgeRating.Text = Convert.ToString(myMovie.getAgeRatingId());
            txtDescription.Text = Convert.ToString(myMovie.getDescription());


            //display details
            grpRemoveSelectedMovie.Visible = true;
        }
    }
}
