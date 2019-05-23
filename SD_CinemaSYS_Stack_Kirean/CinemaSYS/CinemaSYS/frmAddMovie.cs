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
    public partial class frmAddMovie : Form
    {
        frmMainMenu parent;

        public frmAddMovie()
        {
            InitializeComponent();
        }

        private void frmAddMovie_Load(object sender, EventArgs e)
        {
            nudRunningTime.Value = 1;
            nudRunningTime.Minimum = 1;
            nudRunningTime.Maximum = 500;

            txtMovieId.Text = Movie.nextMovie_Id().ToString("0000");
            DataSet ds = new DataSet();

            loadCombo();
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

            //cboScreenType.SelectedIndex = 0;
        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //Validation
            string getInput = txtMovieName.Text;
            if(!System.Text.RegularExpressions.Regex.IsMatch(getInput, "^[a-zA-Z0-9\\s]+$"))
            {
                MessageBox.Show("Please use only letters and numbers! ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMovieName.ResetText();
                return;
            }
            string getInput2 = txtDescription.Text;
            if (!System.Text.RegularExpressions.Regex.IsMatch(getInput, "^[a-zA-Z0-9\\s]+$"))
            {
                MessageBox.Show("Please use only letters and numbers! ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescription.ResetText();
                return;
            }
            if (String.IsNullOrWhiteSpace(txtMovieName.Text))
            {
                MessageBox.Show("Please enter a movie name! ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cboAgeRating.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an age Rating! ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Please enter a description! ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //save screen details in DB
            Movie myMovie = new Movie(Convert.ToInt32(txtMovieId.Text),Convert.ToString(txtMovieName.Text.ToUpper()), Convert.ToInt32(nudRunningTime.Text), Convert.ToString(txtDescription.Text), Convert.ToInt32(cboAgeRating.Text.Substring(0, 1)));
            myMovie.regMovie();



            //Display confirmation Message
            MessageBox.Show("Screen Details \r\nMovieID: " + txtMovieId.Text +"\r\nMovie: " + txtMovieName.Text + "\r\nRunning Time: " + nudRunningTime.Text + "\r\nAge Rating: " + cboAgeRating.Text + "\r\nDescription " + txtDescription.Text,
                                                        "Confirm Cancel!!", MessageBoxButtons.OK);

            //reset UI
            txtMovieId.Text = Movie.nextMovie_Id().ToString("0000");
            txtMovieName.Clear();
            nudRunningTime.Value = 1;
            cboAgeRating.ResetText();
            loadCombo();
            txtDescription.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainMenu main = new frmMainMenu();
            main.ShowDialog();
        }
    }
}
