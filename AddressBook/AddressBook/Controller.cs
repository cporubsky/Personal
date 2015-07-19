using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AddressBook
{
    public class Controller
    {
   
        AddressBook a; UserManagement u; State state;

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

        public Controller(UserManagement u, AddressBook a, State state)
        {
            this.u = u;
            this.a = a;
            this.state = state;
        }


        private bool Handle(object sender, EventArgs e)
        {
            bool result = false;

            switch (state.Status)
            {
                case "Log In":
                    {  
                        string logIn = "SELECT * from USERS WHERE UserName =  " + u.UserName;


                        result = true;
                        break;
                    }
                case "Main Menu":
                    {
                        break;
                    }
                default:
                    break;
            }
            return result;
        }
        
       

    }
}
