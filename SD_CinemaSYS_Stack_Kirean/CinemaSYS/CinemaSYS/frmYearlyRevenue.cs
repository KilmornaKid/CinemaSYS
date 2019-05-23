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
    public partial class frmYearlyRevenue : Form
    {
        public frmYearlyRevenue()
        {
            InitializeComponent();
        }

        private void frmYearlyRevenue_Load(object sender, EventArgs e)
        {
            grpReport.Visible = false;
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            grpReport.Visible = true;
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
         
        }
    }
}
