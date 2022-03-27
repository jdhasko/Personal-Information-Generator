using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Information_Generator_2.Models
{
    /// <summary>
    /// This class is the equivalent of the JSON objects in the person-names.json provided by the teacher.
    /// </summary>
    [Serializable]
    internal class Person
    {
        public Person(string firstname, string surname, string gender)
        {
            Firstname = firstname;
            Surname = surname;
            Gender = gender;
        }


        [JsonProperty("name")]
        public string Firstname { get; set; }
        [JsonProperty("surname")]

        public string Surname { get; set; }
        
        [JsonProperty("gender")]
        public string Gender { get; set; }

    }
}
