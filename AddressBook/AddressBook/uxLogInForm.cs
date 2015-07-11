using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook
{
    public partial class uxLogInForm : Form
    {
        private string _userName;
        private string _password;
        UserManagement _um;

        public uxLogInForm()
        {
            InitializeComponent();
        }

        private void uxLogIn_Click(object sender, EventArgs e)
        {
            _userName = uxUserName.Text;
            _password = uxPassword.Text;

            _um = new UserManagement();

        }
    }
}
