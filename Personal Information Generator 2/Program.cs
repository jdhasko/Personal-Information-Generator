using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Personal_Information_Generator_2.Models;

namespace Personal_Information_Generator_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a functionality: ");
            Console.WriteLine("1. Return a fake CPR \n 2. Return a fake full name and gender \n 3. Return a fake full name, gender and date of birth\n 4. Return a fake CPR, full name and gender \n 5. Return a fake CPR, full name, gender and date of birth \n 6. Return a fake address \n 7. Return a fake mobile phone number \n 8. Return all information for a fake person (CPR, full name, gender, date of birth, address, mobile phone number) \n 9. Return fake person information in bulk (all information for 2 to 100 persons)");
            switch (Convert.ToInt16(Console.ReadLine()))
            {
                case 1:
                { 
                    Identity identity = new Identity();
                    Console.WriteLine(identity.Cpr);
                    break;
                }
                case 2:
                {
                    Identity identity = new Identity();
                    Console.WriteLine(identity.FullName);
                    break;
                    }
                case 3:
                {
                    Identity identity = new Identity();
                    Console.WriteLine(identity.FullName + " " + identity.Gender + " " + identity.BirthDate.ToShortDateString());
                    break;
                }
                case 4:
                {
                    Identity identity = new Identity();
                    Console.WriteLine(identity.Cpr + " " + identity.FullName + " " + identity.Gender);
                    break;
                }
                case 5:
                {
                    Identity identity = new Identity();
                    Console.WriteLine(identity.Cpr + " " + identity.FullName + " " + identity.Gender + " " + identity.BirthDate.ToShortDateString());
                    break;
                }
                case 6:
                {
                    Identity identity = new Identity();
                    Console.WriteLine(identity.Address);
                    break;
                }
                case 7:
                {
                    Identity identity = new Identity();
                    Console.WriteLine(identity.PhoneNumber);
                    break;
                }
                case 8:
                {
                    Identity NewMan = new Identity();
                    Console.WriteLine("Name: " + NewMan.FullName);
                    Console.WriteLine("Birthdate: " + NewMan.BirthDate.ToShortDateString());
                    Console.WriteLine("CPR: " + NewMan.Cpr);
                    Console.WriteLine("Gender: " + NewMan.Gender);
                    Console.WriteLine("Address: " + NewMan.Address);
                    Console.WriteLine("Mobile: " + NewMan.PhoneNumber);
                        break;
                }
                case 9:
                {
                    Console.WriteLine("How many persons do you wish to receive? ");
                    int nr = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; i <= nr; i++)
                    {
                        Identity NewMan = new Identity();
                        Console.WriteLine("Name: " + NewMan.FullName);
                        Console.WriteLine("Birthdate: " + NewMan.BirthDate.ToShortDateString());
                        Console.WriteLine("CPR: " + NewMan.Cpr);
                        Console.WriteLine("Gender: " + NewMan.Gender);
                        Console.WriteLine("Address: " + NewMan.Address);
                        Console.WriteLine("Mobile: " + NewMan.PhoneNumber);
                        Console.WriteLine();
                        Thread.Sleep(1);
                    }
                    break;
                }

            }
            //Identity NewMan = new Identity();
            //Console.WriteLine("Name: " + NewMan.FullName);
            //Console.WriteLine("Birthdate: " + NewMan.BirthDate.ToShortDateString());
            //Console.WriteLine("CPR: " + NewMan.Cpr);
            //Console.WriteLine("Gender: " + NewMan.Gender);
            //Console.WriteLine("Address: " + NewMan.Address);
            //Console.WriteLine("Mobile: " + NewMan.PhoneNumber);
            Console.Read();
        }
    }
}
