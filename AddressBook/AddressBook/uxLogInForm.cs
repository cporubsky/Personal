using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AddressBook
{
    public partial class uxLogInForm : Form
    {
        State state;
        InputHandler handle;
        private SqlConnection sqlConn;
        private string connString = "Data Source=MAIN-PC;Initial Catalog=TEST_DB;Integrated Security=True";

        public uxLogInForm()
        {
            InitializeComponent();

            //uxPassword.Text = "";
            uxPassword.PasswordChar = '\u2022'; //creates bullets for chars in password for gui
        }

        public uxLogInForm(State state)
        {
            this.state = state;
            InitializeComponent();

            uxPassword.Text = "";
            uxPassword.PasswordChar = '\u2022'; //creates bullets for chars in password for gui
        }

        private void uxLogIn_Click(object sender, EventArgs e)
        {
            //state.Status = "Log In";
            string userForm = uxUserName.Text; //username from form
            string passwordForm = uxPassword.Text; //password from form

            string userFromTable = ""; //username from table
            string pwFromTable = ""; //password from table

            //handle(sender, e);

            using (SqlConnection sqlConn = new SqlConnection(connString)) //new sql connection obj
            {
                using (SqlCommand cmd = new SqlCommand("SELECT username, password FROM login_credentials WHERE username = @userForm;", sqlConn)) //set sql statement
                {
                    cmd.Parameters.AddWithValue("@userForm", userForm); //set value in query with username from form
                    sqlConn.Open(); //open connection
                    using (SqlDataReader reader = cmd.ExecuteReader()) //executing cmd variable
                    {
                        if (reader.HasRows) //while there are rows in db
                        {
                            while (reader.Read()) //read row
                            {
                                userFromTable = reader.GetString(reader.GetOrdinal("username")); //gets username from column
                                pwFromTable = reader.GetString(reader.GetOrdinal("password"));  //gets password from column
                                if (passwordForm.CompareTo(pwFromTable) != 0) //if passwords dont match for user
                                {
                                    MessageBox.Show("Incorrect Password");
                                    //clear un/pw to allow retry
                                    uxUserName.Text = ""; 
                                    uxPassword.Text = "";

                                }
                                else
                                {
                                    //eventually direct to next screen
                                    MessageBox.Show("Success");
                                }
                            }
                        }
                    }
                }
            }

        }
    }
}
