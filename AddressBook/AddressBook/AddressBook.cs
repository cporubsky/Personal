using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBook
    {
        /// <summary>
        /// 
        /// </summary>
        private int _id;
        
        /// <summary>
        /// 
        /// </summary>
        private string _firstName;

        /// <summary>
        /// 
        /// </summary>
        private string _lastName;

        /// <summary>
        /// 
        /// </summary>
        private string _street;

        /// <summary>
        /// 
        /// </summary>
        private string _city;

        /// <summary>
        /// 
        /// </summary>
        private string _state;

        /// <summary>
        /// 
        /// </summary>
        private int _zip;
        
        /// <summary>
        /// 
        /// </summary>
        private int _phoneNumber;
        
        /// <summary>
        /// 
        /// </summary>
        private string _email;


        public AddressBook(string FirstName, string LastName, string Street, string City, string State, int Zip, int PhoneNumber, string Email)
        {
            _firstName = FirstName;
            _lastName = LastName;
            _street = Street;
            _city = City;
            _state = State;
            _zip = Zip;
            _phoneNumber = PhoneNumber;
            _email = Email;
        }

        /// <summary>
        /// 
        /// </summary>
        public int Id
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public string FirstName
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public string LastName
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public string Street
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public string City
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public string State
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public int Zip
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public int PhoneNumber
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public string Email
        {
            get;
            set;
        }

        private void NewEntry(string FirstName, string LastName, string Street, string City, string State, int Zip, int PhoneNumber, string Email)
        {

        }
    }
}
