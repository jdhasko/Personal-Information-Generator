using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Information_Generator_2.Models
{
    internal class Identity
    {
        private int _cpr;
        private string _fullName;
        private char _gender;
        private string _phoneNumber;
        private DateTime _birthDate;
        private string _address;

        public Identity(int cpr, string fullName, char gender, string phoneNumber, DateTime birthDate, string address)
        {
            _cpr = cpr;
            _fullName = fullName;
            _gender = gender;
            _phoneNumber = phoneNumber;
            _birthDate = birthDate;
            _address = address;
        }

        public int Cpr { get => _cpr; set => _cpr = value; }
        public string FullName { get => _fullName; set => _fullName = value; }
        public char Gender { get => _gender; set => _gender = value; }
        public string PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }
        public DateTime BirthDate { get => _birthDate; set => _birthDate = value; }
        public string Address { get => _address; set => _address = value; }
    
    
        public 
    
    }
}
