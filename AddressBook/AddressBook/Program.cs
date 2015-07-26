using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string connString = "Data Source=MAIN-PC;Initial Catalog=TEST_DB;Integrated Security=True";
            UserManagement u = new UserManagement();
            AddressBook a = new AddressBook();
            State s = new State("Login");

            Controller c = new Controller(u, a, s, connString);

            Application.Run(new uxLogInForm(s, u, c));
        }
    }
}
