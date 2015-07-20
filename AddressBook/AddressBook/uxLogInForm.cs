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
            u.PassWord = uxPassword.Text; //password from form
            if (c.handle(sender, e))
            {
                MessageBox.Show("Success");
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
