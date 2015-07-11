using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class UserManagement
    {

        private string _userName;
        private string _password;

        public UserManagement()
        {

        }

        public UserManagement(string UserName, string Password)
        {
            _userName = UserName;
            _password = Password;
        }

        public bool validateUser(string UserName, string Password)
        {

            string sql = "SELECT * from USERS WHERE UserName =  " + UserName.ToLower();


            return true;
        }

        
    }
}
