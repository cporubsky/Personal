using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Controller
    {
   
        AddressBook a; UserManagement u; SqlConn sql; State state;

        private List<Observer> observers = new List<Observer>(); // registry of event handlers
      
        public void register(Observer f) { observers.Add(f); } //register(f) adds event-handler method  f  to the registry

        private void signalObservers() { foreach (Observer m in observers) { m(); } } 

        /// <summary>
        /// Default contstructor
        /// </summary>
        public Controller()
        {

        }

        public Controller(UserManagement u)
        {
            this.u = u;
        }

        public Controller(UserManagement u, AddressBook a, SqlConn sql, State state)
        {
            this.u = u;
            this.a = a;
            this.sql = sql;
            this.state = state;
        }


        private void Handle(object sender, EventArgs e)
        {
            switch (state.Status)
            {
                case "Log In":
                    {  
                        string logIn = "SELECT * from USERS WHERE UserName =  " + u.UserName;
                        break;
                    }
                case "Main Menu":
                    {
                        break;
                    }
                default:
                    break;
            }
        }
        


    }
}
