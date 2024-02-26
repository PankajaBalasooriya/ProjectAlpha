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
    public partial class BloodStock : Form
    {
        public BloodStock()
        {
            InitializeComponent();
        }
        //Inherit the class
        DatabaseClass dbClz = new DatabaseClass();
        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateStock US = new UpdateStock();
            US.Show();
        }

        private void BloodStock_Load(object sender, EventArgs e)
        {
            //Using Error Handler tool
            try
            {
                //open the connection
                dbClz.myCon();
                //Call the load mthod
                dataGridViewStock.DataSource = dbClz.LoadGrid("select * from bloodstock");

                

            }
            catch (Exception ex)
            {
                //catch the error
                MessageBox.Show("Error : " + ex.Message, "Blood Stock Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //colose the connection
                dbClz.CloseConn();
            }
            
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridViewStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
