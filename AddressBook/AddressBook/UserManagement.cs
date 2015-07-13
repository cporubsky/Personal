using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string UserName
        {
            get; set;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PassWord
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



        
    }
}
