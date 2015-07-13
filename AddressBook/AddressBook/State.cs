using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class State
    {
        private string _state;

        public string Status
        {
            get { return _state; }
            set { _state = value; }
        }


        public State() { }


        public State(string s)
        {
            _state = s;
        }

        
    }
}
