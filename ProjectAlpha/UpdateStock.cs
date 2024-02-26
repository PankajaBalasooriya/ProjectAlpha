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
    public partial class UpdateStock : Form
    {
        public UpdateStock()
        {
            InitializeComponent();
        }
        //Inherit the class
        DatabaseClass dbClz = new DatabaseClass();
        
        private void UpdateStock_Load(object sender, EventArgs e)
        {
            //Using Error Handler tool
            try
            {
                //open the connection
                dbClz.myCon();
                //Call the load mthod
                dataGridViewStockUpdate.DataSource = dbClz.LoadGrid("select * from bloodstock");



            }
            catch (Exception ex)
            {
                //catch the error
                MessageBox.Show("Error : " + ex.Message, "Blood Stock Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //colose the connection
                dbClz.CloseConn();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = !string.IsNullOrEmpty(txtValue.Text);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //using the error handler tool
            try
            {
                //call the connection method
                dbClz.myCon();
                //call write record method
                dbClz.writeRec("update bloodstock set Available_Stock='" + txtValue.Text + "'where BloodGroup = '" + comboBox1.Text + "'");
                //show the message
                MessageBox.Show("Record Updated Successfully !!", "Donor Details Updater", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                //Display Error Message
                MessageBox.Show("Error : " + ex.Message, "Blood Stock Updater", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //Call the Load Grid Method
                dataGridViewStockUpdate.DataSource = dbClz.LoadGrid("select * from bloodstock");
                //Close he Connection
                dbClz.CloseConn();
                //Call Clear Method
                txtValue.ResetText();
                comboBox1.ResetText();
                //call enable prodedure false
                btnUpdate.Enabled = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

