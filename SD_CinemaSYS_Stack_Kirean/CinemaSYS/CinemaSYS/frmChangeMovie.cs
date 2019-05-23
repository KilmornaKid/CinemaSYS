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
    public partial class frmChangeMovie : Form
    {
        Movie myMovie = new Movie();

        public frmChangeMovie()
        {
            InitializeComponent();
        }

        private void frmChangeMovie_Load(object sender, EventArgs e)
        {
    
            nudRunningTime.Value = 0;
            nudRunningTime.Minimum = 1;
            nudRunningTime.Maximum = 500;

            loadCombo();

            grpChangeSelectedMovie.Visible = false;
        }

        public void loadCombo()
        {
            // create instance of data set
            DataSet ds = new DataSet();

            ds = AgeRating.getAgeRatings(ds);

            //Remove existing items from combo box
            cboAgeRating.Items.Clear();

            //load data from ds to cboAgeRating
            for (int i = 0; i < ds.Tables["gar"].Rows.Count; i++)
                cboAgeRating.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(1, '0') + ". " + ds.Tables[0].Rows[i][1].ToString());
        }

        private void btnSearchMovie_Click(object sender, EventArgs e)
        {
            string getInput = txtSearchMovie.Text;
            if (!System.Text.RegularExpressions.Regex.IsMatch(getInput, "^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("Please enter a query using only letters and numbers! ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearchMovie.ResetText();
                return;
            }

            grpChangeSelectedMovie.Visible = true;

            myMovie = Movie.getMovie(txtSearchMovie.Text);

            txtMovieId.Text = myMovie.getMovieId().ToString();
            txtMovieName.Text = Convert.ToString(myMovie.getMovieName());
            nudRunningTime.Text = Convert.ToString(myMovie.getRunningTime());
            cboAgeRating.SelectedIndex = myMovie.getAgeRatingId()-1;
            txtDescription.Text = Convert.ToString(myMovie.getDescription());
        }

        private void btnConfirmChanges_Click(object sender, EventArgs e)
        {
            

            myMovie.setMovieId(Convert.ToInt32(txtMovieId.Text));
            myMovie.setMovieName(Convert.ToString(txtMovieName.Text.ToUpper()));
            myMovie.setRunningTime(Convert.ToInt32(nudRunningTime.Text));
            myMovie.setAgeRatingId(Convert.ToInt32(cboAgeRating.Text.Substring(0, 1)));
            myMovie.setDescription(Convert.ToString(txtDescription.Text));
            myMovie.updMovie();
            MessageBox.Show("Movie " + txtMovieName.Text + " Updated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
   
            grpChangeSelectedMovie.Visible = false;
            txtSearchMovie.Clear();
        }
    }
}
