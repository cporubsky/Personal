using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AddressBook
{
    public class UserManagement
    {
        /// <summary>
        /// 
        /// </summary>
        private string _userName;

        /// <summary>
        /// 
        /// </summary>
        private string _password;

        /// <summary>
        /// 
        /// </summary>
        public string Username
        {
            get; set;
        }

        /// <summary>
        /// 
        /// </summary>
        public string Password
        {
            get; set;         
        }

        /// <summary>
        /// 
        /// </summary>
        public UserManagement()
        {

        }

        
        public UserManagement(string UserName, string Password)
        {
            _userName = UserName;
            _password = Password;
        }

        public int AddUser(string Conn)
        {
            int rowsAffected = 0;
            using (SqlConnection sqlConn = new SqlConnection(Conn)) //new sql connection obj
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Login_Credentials (username, password) VALUES (@user, @password)" , sqlConn)) //set sql statement
                {
                    cmd.Parameters.AddWithValue("user", _userName.Trim().ToLower());
                    cmd.Parameters.AddWithValue("password", _password.Trim().ToLower());

                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }
            return rowsAffected;
        }

        public void RemoveUser()
        {

        }


       public bool Login(string Conn)
        {

            string userFromTable = ""; //username from table
            string pwFromTable = ""; //password from table

            using (SqlConnection sqlConn = new SqlConnection(Conn)) //new sql connection obj
            {
                using (SqlCommand cmd = new SqlCommand("SELECT username, password FROM Login_Credentials WHERE username = @userForm;", sqlConn)) //set sql statement
                {
                    cmd.Parameters.AddWithValue("@userForm", Username); //set value in query with username from form
                    sqlConn.Open(); //open connection
                    using (SqlDataReader reader = cmd.ExecuteReader()) //executing cmd variable
                    {
                        if (reader.HasRows) //while there are rows in db that match results
                        {
                            while (reader.Read()) //read row
                            {
                                userFromTable = reader.GetString(reader.GetOrdinal("username")); //gets username from column
                                pwFromTable = reader.GetString(reader.GetOrdinal("password"));  //gets password from column
                                if (Password.CompareTo(pwFromTable) == 0) return true;
                            }
                        }
                    }
                }
            }
            return false; //incorrect username or password




        }

        public void GetSecurityQuestion()
        {

        }

        public void ResetPassword()
        {

        }


        public Dictionary<string, string> AllUsers(string Conn)
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
