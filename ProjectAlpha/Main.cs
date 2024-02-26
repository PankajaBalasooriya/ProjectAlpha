using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAlpha
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnDonerReg_Click(object sender, EventArgs e)
        {
            //Open the Doner Registration form
            FrmDonerReg formReg = new FrmDonerReg();
            formReg.Show();
            
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close the application
            Application.Exit();
        }

        private void btnSignout_Click(object sender, EventArgs e)
        {
            //opening the loging form
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void btnDonInfo_Click(object sender, EventArgs e)
        {
            FindDoners FindDoners = new FindDoners();
            FindDoners.Show();
        }

        private void btnSearchDonor_Click(object sender, EventArgs e)
        {
            DonerBloodTypes Bloodtypes = new DonerBloodTypes();
            Bloodtypes.Show();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            BloodStock Stock = new BloodStock();
            Stock.Show();
        }

        private void btupdateStock_Click(object sender, EventArgs e)
        {
            UpdateStock US = new UpdateStock();
            US.Show();
        }
    }
}
