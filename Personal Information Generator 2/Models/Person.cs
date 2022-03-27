using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Information_Generator_2.Models
{
    internal class Person
    {
        public Person(string firstname, string surname, string gender)
        {
            Firstname = firstname;
            Surname = surname;
            Gender = gender;
        }

        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }

    }
}
