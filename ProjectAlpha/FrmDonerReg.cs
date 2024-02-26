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
    public partial class FrmDonerReg : Form
    {
        public FrmDonerReg()
        {
            InitializeComponent();
        }

        private void cle()
        {
            //reset all the controls
            txtDID.ResetText();
            txtAdd.ResetText();
            txtAge.ResetText();
            txtDName.ResetText();
            txtEmail.ResetText();
            txtNIC1.ResetText();
            txtTelNo.ResetText();
            CmbBloodType.ResetText();
            rdoFemale.Checked = false;
            rdoMale.Checked = false;

        }

        //creating memory variable
        String gen;

        //Inherit the class
        DatabaseClass dbClz = new DatabaseClass();

        private void button1_Click(object sender, EventArgs e)
        {
            //using error handler tool
            try
            {
                //call connection method
                dbClz.myCon();
                //call write record method
                dbClz.writeRec("insert into donerregistration values('" + txtDID.Text + "', '" + txtDName.Text + "', '" + txtNIC1.Text + "', '" + gen + "', '" + txtAdd.Text + "', '" + txtEmail.Text + "', '" + txtAge.Text + "', '" + txtTelNo.Text + "', '" + CmbBloodType.Text + "')");
                //show the message
                MessageBox.Show("New Record added successfully!", "Donor Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                //Display the Error Message
                MessageBox.Show("Error :" + ex.Message, "Donor Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            finally
            {
                //Call the Load Grid Method
                DgvDoner.DataSource = dbClz.LoadGrid("select * from donerregistration");
                //Close he Connection
                dbClz.CloseConn();
                //Call Clear Method
                cle();

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
        }

        private void btncle_Click(object sender, EventArgs e)
        {
           
        }

        private void txtNIC_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmDonerReg_Load(object sender, EventArgs e)
        {
            //Using Error Handler tool
            try
            {
                //open the connection
                dbClz.myCon();
                //Call the load mthod
                DgvDoner.DataSource = dbClz.LoadGrid("select * from donerregistration");
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

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            
            //close the register form
            this.Hide();
        }

        private void btncle_Click_1(object sender, EventArgs e)
        {
            //Call the clear procedure
            cle();
        }

        private void rdoMale_CheckedChanged(object sender, EventArgs e)
        {
            //set the values
            gen = "Male";
        }

        private void rdoFemale_CheckedChanged(object sender, EventArgs e)
        {
            //set the values
            gen = "Female";
        }

        private void DgvDoner_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblDID_Click(object sender, EventArgs e)
        {

        }
    }
}
