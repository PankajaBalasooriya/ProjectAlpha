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
    public partial class DonerBloodTypes : Form
    {
        public DonerBloodTypes()
        {
            InitializeComponent();
        }
        //Inherit the class
        DatabaseClass dbClz = new DatabaseClass();
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void DonerBloodTypes_Load(object sender, EventArgs e)
        {
           
        }

        private void comboBoxBloodTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Using Error Handler tool
            try
            {
                //open the connection
                dbClz.myCon();
                //Call the load mthod
                dgvBloodtypes.DataSource = dbClz.LoadGrid("select * from donerregistration where BloodGroup='" + comboBoxBloodTypes.Text + "';");
            }
            catch (Exception ex)
            {
                //catch the error
                MessageBox.Show("Error : " + ex.Message, "Doner Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //colose the connection
                dbClz.CloseConn();
            }
        }

        private void btnDInfo_Click(object sender, EventArgs e)
        {
            FindDoners FindDoners = new FindDoners();
            FindDoners.Show();
            this.Hide();
        }
    }
}
