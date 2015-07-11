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
        public uxMainMenuForm()
        {
            InitializeComponent();
        }

        public void SqlConn()
        {
            SqlConnection sql = new SqlConnection("server = beast-pc;" +
                                       "Trusted_Connection = yes;" +
                                       "database = TestDB; " +
                                       "connection timeout = 30");


            try
            {
                sql.Open();
                MessageBox.Show("Connection is open!");
                sql.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
         

        }
    }
}
