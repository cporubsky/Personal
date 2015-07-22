using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AddressBook
{
    public class Controller
    {
   
        AddressBook a; UserManagement u; State s;

        private string connString = "Data Source=MAIN-PC;Initial Catalog=TEST_DB;Integrated Security=True";

        private List<Observer> observers = new List<Observer>(); // registry of event handlers
      
        public void register(Observer f) { observers.Add(f); } //register(f) adds event-handler method  f  to the registry

        private void signalObservers() { foreach (Observer m in observers) { m(); } } 

        /// <summary>
        /// Default contstructor
        /// </summary>
        public Controller()
        {

        }

        public Controller(UserManagement u, AddressBook a, State s)
        {
            this.u = u;
            this.a = a;
            this.s = s;
        }

        public bool handle(object sender, EventArgs e)
        {
            switch (s.Status)
            {
                case "Login":
                    {
                        string userFromTable = ""; //username from table
                        string pwFromTable = ""; //password from table

                        using (SqlConnection sqlConn = new SqlConnection(connString)) //new sql connection obj
                        {
                            using (SqlCommand cmd = new SqlCommand("SELECT username, password FROM Login_Credentials WHERE username = @userForm;", sqlConn)) //set sql statement
                            {
                                cmd.Parameters.AddWithValue("@userForm", u.UserName); //set value in query with username from form
                                sqlConn.Open(); //open connection
                                using (SqlDataReader reader = cmd.ExecuteReader()) //executing cmd variable
                                {
                                    if (reader.HasRows) //while there are rows in db that match results
                                    {
                                        while (reader.Read()) //read row
                                        {
                                            userFromTable = reader.GetString(reader.GetOrdinal("username")); //gets username from column
                                            pwFromTable = reader.GetString(reader.GetOrdinal("password"));  //gets password from column
                                            if (u.PassWord.CompareTo(pwFromTable) == 0) return true;
                                        }
                                    }
                                }
                            }
                        }
                        return false; //incorrect username or password
                    }
                case "Main Menu":
                    {
                        return true;
                    }
                default:
                    return false;
            }
        }


        
        
       

    }
}
