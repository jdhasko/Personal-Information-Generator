﻿using Personal_Information_Generator_2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Personal_Information_Generator_2.Models
{
    public class Identity
    {
        private int _cpr;
        private string _fullName;
        private string _gender;
        private string _phoneNumber;
        private DateTime _birthDate;
        private string _address;

        //public Identity(int cpr, string fullName, string gender, string phoneNumber, DateTime birthDate, string address)
        //{
        //    _cpr = cpr;
        //    _fullName = fullName;
        //    _gender = gender;
        //    _phoneNumber = phoneNumber;
        //    _birthDate = birthDate;
        //    _address = address;
        //}

        public int Cpr { get => _cpr; set => _cpr = value; }
        public string FullName { get => _fullName; set => _fullName = value; }
        public string Gender { get => _gender; set => _gender = value; }
        public string PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }
        public DateTime BirthDate { get => _birthDate; set => _birthDate = value; }
        public string Address { get => _address; set => _address = value; }
    
    
       public string GetFullNameAndGender()
        {
            if(_fullName ==null || Gender == null)
            {
                string personsJSON = FileReader.ReadText(@"C:\Users\Dominik Haskó\source\repos\Personal Information Generator\Personal Information Generator 2\Files\person-names.json");
                List<Person> persons = JsonConvert.DeserializeObject<List<Person>>(personsJSON);
                Random rnd = new Random();
                int personNumber = rnd.Next(0, persons.Count);
                FullName = persons[personNumber].Firstname + " " + persons[personNumber].Surname;
                Gender = persons[personNumber].Gender;

            }
            return _fullName + " " + _gender;
        }
    
    }
}