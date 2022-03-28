using Personal_Information_Generator_2.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Personal_Information_Generator_2.Models
{
    public class Identity
    {
        private string _cpr;
        private string _fullName;
        private string _gender;
        private int _phoneNumber;
        private DateTime _birthDate;
        private string _address;

        public Identity()
        {
            _birthDate = Generator.GetRandomBirthDate();
            _address = CreateAdress();
            CreateCPR();

            _phoneNumber = Generator.GetPhoneNumber();
        }

        public string Cpr { get => _cpr; set => _cpr = value; }
        public string FullName { get => _fullName; set => _fullName = value; }
        public string Gender { get => _gender; set => _gender = value; }
        public int PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }
        public DateTime BirthDate { get => _birthDate; set => _birthDate = value; }
        public string Address { get => _address; set => _address = value; }
    
    
       public void GetFullNameAndGender()
        {
            if(_fullName ==null || Gender == null)
            {
                string path= @"Files\person-names.json";
                string personsJSON = FileReader.ReadText(path);
                List<Person> persons = JsonConvert.DeserializeObject<List<Person>>(personsJSON);
                Random rnd = new Random();
                int personNumber = rnd.Next(0, persons.Count);
                FullName = persons[personNumber].Firstname + " " + persons[personNumber].Surname;
                Gender = persons[personNumber].Gender;

            }
            //return _fullName + " " + _gender;
        }

        public void CreateCPR() 
        { 
            if(BirthDate == null)
            {
                BirthDate = Generator.GetRandomBirthDate();
            }

            if(Gender == null)
            {
                GetFullNameAndGender();
            }

            _cpr = Generator.GetFakeCPR(_gender, _birthDate);

        }

        public string CreateAdress()
        {
            //Street
            Random rand = new Random();
            int stringlen = rand.Next(4, 10);
    
            string street = "";
            
            for (int i = 0; i < stringlen; i++)
            {

                // Generating a random number.
                int randValue = rand.Next(0, 26);

                // Generating random character by converting
                // the random number into character.
                char letter = Convert.ToChar(randValue + 97);

                // Appending the letter to string.
                street = street + letter;
            }

            //Street nr
            int number = rand.Next(1, 999);
            street += " " + number;
            if (rand.Next(0, 1) == 1)
            {
                int randValue = rand.Next(0, 26);

                // Generating random character by converting
                // the random number into character.
                char letter = Convert.ToChar(randValue + 65);
                street += char.ToUpper(letter);
            }
            street += ", ";

            //Floor
            int floor = rand.Next(0, 99);
            if (floor == 0)
            {
                street += "st, ";
            }
            else
            {
                street += floor +", ";
            }

            //Door
            if (rand.Next(0, 1) == 1)
            {
               int th = rand.Next(1, 3);
               switch (th)
               {
                    case 1:
                        street += "th ";
                        break;
                    case 2:
                        street += "mf ";
                        break;
                    case 3:
                        street += "tv ";
                        break;
                }

               street += rand.Next(1, 50);
            }
            else
            {
                int randValue = rand.Next(0, 26);

                // Generating random character by converting
                // the random number into character.
                char letter = Convert.ToChar(randValue + 65);
                street += char.ToLower(letter);
                street += rand.Next(1, 999);
            }
            street += ", ";

            //Post
            bool keepTrying = true;
            while (keepTrying)
            {
                int key = rand.Next(1300, 9999);
                keepTrying = !PostalCodes.postCodesDictionary.ContainsKey(key.ToString());
                if (!keepTrying)
                {
                    street += key + " " + PostalCodes.postCodesDictionary[key.ToString()];
                }
            }

            return street;
        }

    
    }
}
