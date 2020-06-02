using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace PayrollManagmentSystem
{
    class db
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataSet ds;
        DataTable dt;
        public db()
        {
            string myconn = "SERVER=localhost;" + "DATABASE=payrollmanagmentsystem;" + "USERNAME=root;" + "PASSWORD=root;";
            connection = new MySqlConnection(myconn);

        }


        // Return Employee Data
        public DataTable getSearchEmployeeData(string id)
        {
            string q = "SELECT * FROM `employeedata` WHERE idemployeedata=\'" + id + "\';";

            connection.Open();
            da = new MySqlDataAdapter(q, connection);
            
            dt = new DataTable();
            da.Fill(dt);
            connection.Close();
            return dt;

        }   

        // Remove Employee Data
        public bool DelEmployee(string id)
        {
            string q= "DELETE FROM `employeedata` WHERE idemployeedata=\'" + id + "\';";
            try
            {
                connection.Open();
                cmd = new MySqlCommand(q, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                connection.Close();
                return false;
            }

        }

        // Validate id existance 
        public bool validateID(string id)
        {
            string q = "SELECT * FROM `employeedata` WHERE idemployeedata=\'" + id+ "\';";

            try
            {
                connection.Open();
                da = new MySqlDataAdapter(q, connection);
                ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count== 1)
                {
                    connection.Close();
                    return true;
                }
                else
                    return false;
            }
            catch(Exception)
            {
                connection.Close();
                return false;
            }



        }
        // Insert Employee Data into DB
        public bool InsertEmployee(string emID, string emName,
           string emEmail, string emCon, string emAd,string emDOB,
            string emJob, string emDep, string emSal, string emDate)
        {
            string q = "INSERT INTO `employeedata`( " +
               "`idemployeedata`, " +
               "`emname`, " +
               "`ememail`, " +
               "`emcontact`, " +
               "`emadress`, " +
               "`emdob`, " +
               "`emjob`, " +
               "`emdepartment`, " +
               "`emsalary`, " +
               "`emdate`) VALUES (\'" +
               emID + "\',\'" +
              emName + "\',\'" +
               emEmail + "\',\'" +
                emCon + "\',\'" +
              emAd + "\',\'" +
               emDOB+ "\',\'" +
               emJob+ "\',\'" +
               emDep+ "\',\'" +
               emSal + "\',\'" +
               emDate + "\')";

            try
            {
                connection.Open();
                cmd = new MySqlCommand( q, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
