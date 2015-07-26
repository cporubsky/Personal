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

        private string connString;

        private List<Observer> observers = new List<Observer>(); // registry of event handlers
      
        public void register(Observer f) { observers.Add(f); } //register(f) adds event-handler method  f  to the registry

        private void signalObservers() { foreach (Observer m in observers) { m(); } } 

        /// <summary>
        /// Default contstructor
        /// </summary>
        public Controller()
        {

        }

        public Controller(UserManagement u, AddressBook a, State s, string connString)
        {

            this.u = u;
            this.a = a;
            this.s = s;
            this.connString = connString;
        }

        public bool handle(object sender, EventArgs e)
        {
            switch (s.Status)
            {
                case "Login":
                    {
                        if (u.Login(connString)) return true;
                        return false;         
                    }
                case "Forgot":
                    {
                        return true;
                    }
                case "Main Menu":
                    {
                        return true;
                    }
                case "Add User":
                    {
                        if(u.AddUser(connString) == 1) return true;
                        return false;
                       
                    }
                case "Remove User":
                    {
                        return true;
                    }
                default:
                    return false;
            }
        }



        public Dictionary<string, string> AllUsersTest(string Conn)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            string userFromTable = ""; //username from table
            string pwFromTable = ""; //password from table

            using (SqlConnection sqlConn = new SqlConnection(Conn)) //new sql connection obj
            {
                using (SqlCommand cmd = new SqlCommand("SELECT username, password FROM Login_Credentials", sqlConn)) //set sql statement
                {
                    sqlConn.Open(); //open connection
                    using (SqlDataReader reader = cmd.ExecuteReader()) //executing cmd variable
                    {
                        if (reader.HasRows) //while there are rows in db that match results
                        {
                            while (reader.Read()) //read row
                            {
                                userFromTable = reader.GetString(reader.GetOrdinal("username")); //gets username from column
                                pwFromTable = reader.GetString(reader.GetOrdinal("password"));  //gets password from column

                                dictionary.Add(userFromTable.Trim().ToLower(), pwFromTable.Trim().ToLower());
                            }
                        }
                    }
                }
            }

            return dictionary;
        }


    }
}
