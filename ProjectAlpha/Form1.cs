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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void cle()
        {
            //Reset all the controls
            txtUser.ResetText();
            txtPass.ResetText();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close the Application
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Creating the memory variables
            string user, pass;
            //Assigning the values to the variables
            user = txtUser.Text;
            pass = txtPass.Text;
            //cheacking the username and password
            if (user == "Admin" && pass == "admin")
            {
                this.Hide();
                Main ss = new Main();
                ss.Show();
            }
            else
            {
                //Displaying the Error Message
                MessageBox.Show("Username or Password incorrect!!! Please Check your Username and Passsword and try again","login Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                //Calling the clear procedure
                cle();
            }
        }
    }
}
