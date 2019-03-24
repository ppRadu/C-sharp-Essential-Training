using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    public class School
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }


        //_twitterAddress is a backing variable 
        // which stores the actual value of TwitterAddress  
        private string _twitterAddress;
        public string TwitterAddress
        {
            get { return _twitterAddress; }
            
            // Making sure the twitter address has the correct format
            set
            {
                if (value.StartsWith("@"))
                {
                    _twitterAddress = value;
                }
                else
                {
                    throw new Exception("The twitter address must begin with @ symbol");
                }
            }
        }

        public School()
        {
            Name = "Untitled School";
            PhoneNumber = "555-1234";
        }

        public School(string SchoolName, string SchoolPhoneNumber)
        {
            Name = SchoolName;
            PhoneNumber = SchoolPhoneNumber;
        }
    }
}
