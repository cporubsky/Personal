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
    public partial class uxMainMenuForm : Form
    {
        private bool admin = false;
        Controller c;

        string tempConn = "Data Source=MAIN-PC;Initial Catalog=TEST_DB;Integrated Security=True";

        public uxMainMenuForm()
        {
            InitializeComponent();
        }

        public uxMainMenuForm(bool admin, Controller c)
        {
            this.c = c;
            this.admin = admin;
            InitializeComponent();

            if (admin)
            {
                uxAddUser.Enabled = true;
                uxButton4.Enabled = true;
            }
        }

        private void uxAddUser_Click(object sender, EventArgs e)
        {
            //create and move all to add user form
            //if (c.handle(sender, e)) MessageBox.Show("User Added");
            //else if (!c.handle(sender, e)) MessageBox.Show("Error adding user");

            ////for testing
            //Dictionary<string, string> temp = c.AllUsersTest(tempConn);

            //StringBuilder sb = new StringBuilder();

            //foreach (KeyValuePair<string, string> kvp in temp)
            //{
            //    string tempUser = kvp.Key;
            //    string tempPw = kvp.Value;
            //    sb.Append(tempUser + ": " + tempPw + Environment.NewLine);
            //}

            //MessageBox.Show(sb.ToString());

        }
    }
}

