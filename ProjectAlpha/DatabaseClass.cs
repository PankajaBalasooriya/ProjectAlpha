using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace ProjectAlpha
{
    class DatabaseClass
    {
        //create the instant variable
        MySqlConnection mysqlConn;
        MySqlCommand mysqlComm;
        MySqlDataAdapter mysqlAdapt;
        MySqlDataReader mysqlRead;
        DataSet dsDoners;

        //create memory variables
        String qry;

        //creating the connection Method
        public MySqlConnection myCon()
        {
            //Create the memory variable
            string srv, db, uid, pwd;
            //Assigning the values
            srv = "localhost"; db = "bloodbank"; uid = "root"; pwd = "";

            //creating the statement
            qry = "SERVER=" + srv + ";" + "DATABASE=" + db + ";" + "UID=" + uid + ";" + "PASSWORD=" + pwd + ";";
            //Assigning the connection
            mysqlConn = new MySqlConnection(qry);
            //open the connection
            mysqlConn.Open();
            //pass the connection
            return mysqlConn;
        }

        //creating the close connection method
        public void CloseConn()
        {
            //close the connection
            mysqlConn.Close();
        }

        //creating the Data Load Method
        public object LoadGrid(string sql)
        {
            //Assigning the adaptor control command
            mysqlAdapt = new MySqlDataAdapter(sql, mysqlConn);
            //fill the dataset
            mysqlAdapt.Fill(dsDoners = new DataSet());
            //Assigning the the values in Grid Control
            object dataload = dsDoners.Tables[0];
            //pass the values from
            return dataload;
        }

        //create the search record metod
        public MySqlDataReader myRead(string sql)
        {
            //set the connection
            mysqlComm = new MySqlCommand(sql, mysqlConn);
            //Read the statement
            mysqlRead = mysqlComm.ExecuteReader();
            //Pass the value
            return mysqlRead;
        }

        //Create the table handling mehod
        public void writeRec(string sql)
        {
            //set the connection in the statement
            mysqlComm = new MySqlCommand(sql, mysqlConn);
            //update the record
            mysqlComm.ExecuteNonQuery();
        }


    }
}
