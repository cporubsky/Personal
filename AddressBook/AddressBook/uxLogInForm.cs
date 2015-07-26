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
        
        State s;
        Controller c;
        UserManagement u;

        //tempConn = "Data Source=MAIN-PC;Initial Catalog=TEST_DB;Integrated Security=True";

        public uxLogInForm()
        {
            InitializeComponent();
            
            //uxPassword.Text = "";
            uxPassword.PasswordChar = '\u2022'; //creates bullets for chars in password for gui
        }

        public uxLogInForm(State s, UserManagement u, Controller c)
        {
            this.s = s;
            this.u = u;
            this.c = c;
            InitializeComponent();

            uxPassword.Text = "";
            uxPassword.PasswordChar = '\u2022'; //creates bullets for chars in password for gui
        }

        private void uxLogIn_Click(object sender, EventArgs e)
        {
            s.Status = "Login";

            u.UserName = uxUserName.Text; //username from form
            u.Password = uxPassword.Text; //password from form
            if (c.handle(sender, e))
            {
                //for testing
                //Dictionary<string, string> temp = u.AllUsers(tempConn);

                //StringBuilder sb = new StringBuilder();

                //foreach(KeyValuePair<string,string> kvp in temp)
                //{
                //    string tempUser = kvp.Key;
                //    string tempPw = kvp.Value;
                //    sb.Append(tempUser + ": " + tempPw + Environment.NewLine);
                    
                //}

                //MessageBox.Show(sb.ToString());

                if (uxUserName.Text == "corey")
                {
                    MessageBox.Show("Admin is now logged in");             
                    uxMainMenuForm mainMenu = new uxMainMenuForm(true, c);
                    this.Hide();
                    mainMenu.Show();
                    this.Owner = mainMenu;
                    
                }
                else
                {
                    MessageBox.Show("Success");
                }
            }
            else
            {
                MessageBox.Show("Wrong username or password");
                uxUserName.Text = ""; 
                uxPassword.Text = ""; 
            }
        }  
    }
}
