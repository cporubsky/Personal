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
        State state;
        InputHandler handle;

        public uxLogInForm(State state)
        {
            this.state = state;
            InitializeComponent();

            uxPassword.Text = "";
            uxPassword.PasswordChar = '\u2022'; //creates bullets for chars in password for gui
        }

        private void uxLogIn_Click(object sender, EventArgs e)
        {
            state.Status = "Log In";
            handle(sender, e);
        }
    }
}
