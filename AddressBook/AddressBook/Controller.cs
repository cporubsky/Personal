using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Controller
    {

        AddressBook a;
        SqlConn s;
        UserManagement u;

        public Controller(UserManagement u, AddressBook a, SqlConn s)
        {
            this.u = u;
            this.a = a;
            this.s = s;
        }

        private void NewEntry()
        {

        }


    }
}
