using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// Include namespaces to enable database access
using System.Data.OleDb;
using System.Net;
using System.Data;

namespace Lab1_AnnualSalaryCalculator
{
    public class clsDataLayer
    {
        // This function gets the user activity from the tblUserActivity
        public static dsUserActivity GetUserActivity(string Database)
        {
            // variables to connect to database
            dsUserActivity DS;
            OleDbConnection sqlConn;
            OleDbDataAdapter sqlDA;
            // Create object to connect to database
            sqlConn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + Database);
            // Create object to grab data from table
            sqlDA = new OleDbDataAdapter("select * from tblUserActivity", sqlConn);
            // Object to create new dataset
            DS = new dsUserActivity();
            // Fill in the object with the data
            sqlDA.Fill(DS.tblUserActivity);
            // Pass the data through
            return DS;
        }
        // This function saves the user activity
        public static void SaveUserActivity(string Database, string FormAccessed)
        {
            // Variables to connect to database
            OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=" + Database);
            conn.Open();
            OleDbCommand command = conn.CreateCommand();
            string strSQL;
            strSQL = "Insert into tblUserActivity (UserIP, FormAccessed) values ('" +
            GetIP4Address() + "', '" + FormAccessed + "')";
            command.CommandType = CommandType.Text;
            command.CommandText = strSQL;
            command.ExecuteNonQuery();
            conn.Close();
        }
        // This function gets the IP Address
        public static string GetIP4Address()
        {
            string IP4Address = string.Empty;
            foreach (IPAddress IPA in
            Dns.GetHostAddresses(HttpContext.Current.Request.UserHostAddress))
            {
                if (IPA.AddressFamily.ToString() == "InterNetwork")
                {
                    IP4Address = IPA.ToString();
                    break;
                }
            }
            if (IP4Address != string.Empty)
            {
                return IP4Address;
            }
            foreach (IPAddress IPA in Dns.GetHostAddresses(Dns.GetHostName()))
            {
                if (IPA.AddressFamily.ToString() == "InterNetwork")
                {
                    IP4Address = IPA.ToString();
                    break;
                }
            }
            return IP4Address;
        }

        // This function saves the personnel data
        public static bool SavePersonnel(string Database, string FirstName, string LastName,
        string PayRate, string StartDate, string EndDate)
        {
            bool recordSaved;
            try
            {
                // Connect to database
                OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=" + Database);
                conn.Open();
                OleDbCommand command = conn.CreateCommand();
                string strSQL;
                // Saving all the string values of the personnel data 
                strSQL = "Insert into tblPersonnel " +
                "(FirstName, LastName, PayRate, StartDate, EndDate) values ('" +
                FirstName + "', '" + LastName + "', " + PayRate + ", '" + StartDate +
                "', '" + EndDate + "')";
                // define the type of the command object
                command.CommandType = CommandType.Text;
                command.CommandText = strSQL;
                // The command execute
                command.ExecuteNonQuery();
                // close the connection to prevent leak
                conn.Close();
                recordSaved = true;
            }
            catch (Exception ex)
            {
                recordSaved = false;
            }
            return recordSaved;
        }

        public static dsPersonnel GetPersonnel(string Database, string strSearch)
        {
            // variables to connect to database
            dsPersonnel DS;
            OleDbConnection sqlConn;
            OleDbDataAdapter sqlDA;

            // Create object to connect to database
            sqlConn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + Database);

            // Create object to grab data from table
            sqlDA = new OleDbDataAdapter("select * from tblPersonnel", sqlConn);

            //test if a value is entered for a search parameter
            if (strSearch == null || strSearch.Trim() == "")
            {
                sqlDA = new OleDbDataAdapter("select * from tblPersonnel", sqlConn);
            }
            else
            {
                sqlDA = new OleDbDataAdapter("select * from tblPersonnel where LastName = '" + strSearch + "'", sqlConn);
            }

            // Object to create new dataset
            DS = new dsPersonnel();
           
            // Fill in the object with the data
            sqlDA.Fill(DS.tblPersonnel);
            
            // Pass the data through
            return DS;
        }


    }


   
}