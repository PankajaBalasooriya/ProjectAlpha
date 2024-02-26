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
    public partial class FindDoners : Form
    {
        public FindDoners()
        {
            InitializeComponent();
        }
        //Inherit the class
        DatabaseClass dbClz = new DatabaseClass();
        private void cle()
        {
            //Reset all controls
            txtSearch.ResetText();
            txtAdd.ResetText();
            txtAge.ResetText();
            comboBoxBlood.ResetText();
            txtDID.ResetText();
            txtDName.ResetText();
            txtEmail.ResetText();
            txtGen.ResetText();
            txtNIC.ResetText();
            txtTelNo.ResetText();
        }
        private void enet()
        {
            txtAdd.Enabled = true;
            txtAge.Enabled = true;
            comboBoxBlood.Enabled = true;
            txtDName.Enabled = true;
            txtEmail.Enabled = true;
            txtGen.Enabled = true;
            txtNIC.Enabled = true;
            txtTelNo.Enabled = true;
        }
        private void enef()
        {
            txtAdd.Enabled = false;
            txtAge.Enabled = false;
            comboBoxBlood.Enabled = false;
            txtDName.Enabled = false;
            txtEmail.Enabled = false;
            txtGen.Enabled = false;
            txtNIC.Enabled = false;
            txtTelNo.Enabled = false;
        }
        private void FindDoners_Load(object sender, EventArgs e)
        {
            //using error handler tool
            try
            {
                //open the connection
                dbClz.myCon();
                //call the load method
                dataGridView1.DataSource = dbClz.LoadGrid("select * from donerregistration");
            }
            catch(Exception ex)
            {
                //catch the error
                MessageBox.Show("Error: " + ex.Message, "Doner Details", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            finally
            {
                //close the connection
                dbClz.CloseConn();
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            
            try
            {
                //call the connection method
                dbClz.myCon();
                //create the reader and assigning the values
                MySql.Data.MySqlClient.MySqlDataReader dr = dbClz.myRead("Select * from donerregistration where "+comboBoxAccording.Text+"='"+txtSearch.Text+"'");
                //using try catch function
                try
                {
                    //Read the reader command
                    dr.Read();
                    //Assigning the values
                    txtDID.Text = dr[0].ToString();
                    txtDName.Text = dr[1].ToString();
                    txtNIC.Text = dr[2].ToString();
                    txtGen.Text = dr[3].ToString();
                    txtAdd.Text = dr[4].ToString();
                    txtEmail.Text = dr[5].ToString();
                    txtAge.Text = dr[6].ToString();
                    txtTelNo.Text = dr[7].ToString();
                    comboBoxBlood.Text = dr[8].ToString();
                    //display the message
                    MessageBox.Show("Record Found !!", "Doner Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch
                {
                    //catch the error
                    MessageBox.Show("Record Not Found !!", "Doner Infomation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //clear the text boxes
                    txtSearch.Focus();
                    cle();
                }
            }
            catch(Exception ex)
            {
                //catch the error
                MessageBox.Show("Error : " + ex.Message, "Doner infomation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
            }
            
        }

        private void btncle_Click(object sender, EventArgs e)
        {
            //call the clear procedure
            cle();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FindDoners_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void txtDID_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void txtDID_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtAdd.Enabled == false)
            {
                //call the enable procedure
                enet();
            }
            else
            {
                //using the error handler tool
                try
                {
                    //call the connection method
                    dbClz.myCon();
                    //call write record method
                    dbClz.writeRec("update donerregistration set DonerName='" + txtDName.Text + "',NIC='" + txtNIC.Text + "',Gender='" + txtGen.Text + "',Address='" + txtAdd.Text + "',Email='" + txtEmail.Text + "',Age='" + txtAge.Text + "',TelNo='" + txtTelNo.Text + "',BloodGroup='" + comboBoxBlood.Text + "'where DonerID='" + txtDID.Text + "'");
                    //show the message
                    MessageBox.Show("Record Updated Successfully !!", "Donor Details Updater", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    //Display Error Message
                    MessageBox.Show("Error : " + ex.Message, "Donor details Updater", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    //Call the Load Grid Method
                    dataGridView1.DataSource = dbClz.LoadGrid("select * from donerregistration");
                    //Close he Connection
                    dbClz.CloseConn();
                    //Call Clear Method
                    cle();
                    //call enable prodedure false
                    enef();
                }
            }
        }

        private void txtDID_TextChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = !string.IsNullOrEmpty(txtDID.Text);
            btnDel.Enabled = !string.IsNullOrEmpty(txtDID.Text);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Delete the Record?", "Donor Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //using error handler tool
                try
                {
                    //call the connection method
                    dbClz.myCon();
                    //call th write record method
                    dbClz.writeRec("delete from donerregistration where DonerID='" + txtDID.Text + "'");
                    //show the message
                    MessageBox.Show("Record deleted successfully", "Donor Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    //Display Error Message
                    MessageBox.Show("Error : " + ex.Message, "Donor Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    //Call the Load Grid Method
                    dataGridView1.DataSource = dbClz.LoadGrid("select * from donerregistration");
                    //Close he Connection
                    dbClz.CloseConn();
                    //Call Clear Method
                    cle();
                    //call enable prodedure false
                    enef();
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //Open the Doner Registration form
            FrmDonerReg formReg = new FrmDonerReg();
            formReg.Show();
            this.Hide();
        }
    }
}
