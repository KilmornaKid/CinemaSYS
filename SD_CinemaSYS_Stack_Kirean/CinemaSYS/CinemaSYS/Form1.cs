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
    public partial class frmMainMenu : Form
    {

        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
        }

        private void addScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddScreen addScreen = new frmAddScreen();
            addScreen.ShowDialog();
        }

        private void changeScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangeScreen changeScreen = new frmChangeScreen();
            changeScreen.ShowDialog();
        }

        private void changeScreenStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangeScreenStatus changeScreenStatus = new frmChangeScreenStatus();
            changeScreenStatus.ShowDialog();
        }

        private void addMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddMovie addMovie = new frmAddMovie();
            addMovie.ShowDialog();
        }

        private void changeMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangeMovie changeMovie = new frmChangeMovie();
            changeMovie.ShowDialog();
        }

        private void removeMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRemoveMovie removeMovie = new frmRemoveMovie();
            removeMovie.ShowDialog();
        }

        private void scheduleScreeningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmScheduleScreening scheduleScreening = new frmScheduleScreening();
            scheduleScreening.ShowDialog();
        }

        private void changeScreeningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangeScreening changeScreening = new frmChangeScreening();
            changeScreening.ShowDialog();
        }

        private void removeScreeningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRemoveScreening removeScreening = new frmRemoveScreening();
            removeScreening.ShowDialog();
        }

        private void seatTicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSeatTickets seatTickets = new frmSeatTickets();
            seatTickets.ShowDialog();
        }

        private void yearlyRevenueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmYearlyRevenue yearlyRevenue = new frmYearlyRevenue();
            yearlyRevenue.ShowDialog();
        }

        private void soldOutScreeningsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSoldOutScreenings soldOutScreenings = new frmSoldOutScreenings();
            soldOutScreenings.ShowDialog();
        }

    }
}
