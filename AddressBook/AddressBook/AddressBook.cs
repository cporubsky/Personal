using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBook
    {
        private int _id;
        private string _firstName;
        private string _lastName;
        private string _street;
        private string _city;
        private string _state;
        private int _zip;
        private int _phoneNumber;
        private string _email;

        public int Id
        {
            get;
            set;
        }

        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public string Street
        {
            get;
            set;
        }

        public string City
        {
            get;
            set;
        }

        public string State
        {
            get;
            set;
        }

        public int Zip
        {
            get;
            set;
        }

        public int PhoneNumber
        {
            get;
            set;
        }

        public string Email
        {
            get;
            set;
        }
    }
}
