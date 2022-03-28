using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personal_Information_Generator_2.Models;

namespace Personal_Information_Generator_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Identity NewMan = new Identity();
            Console.WriteLine("Neam: " + NewMan.FullName);
            Console.WriteLine("Birthdate: " + NewMan.BirthDate);
            Console.WriteLine("CPR: " + NewMan.Cpr);
            Console.WriteLine("Gender: " + NewMan.Gender);
            Console.WriteLine("Address: " + NewMan.Address);
            Console.WriteLine("Mobile: " + NewMan.PhoneNumber);
            Console.Read();
        }
    }
}
