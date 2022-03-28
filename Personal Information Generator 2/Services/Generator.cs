using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Information_Generator_2
{
    public static class Generator
    {
        public static DateTime GetRandomBirthDate()
        {
            Random r = new Random();
            int year = r.Next(1900, DateTime.Now.Year+1);
            int month = r.Next(1, 13);
            int day = 0;
            switch (month)
            {
                case 1: case 3: case 5: case 7: case 8: case 10: case 12: 
                    day = r.Next(1, 32);
                    break;
                case 4: case 6: case 9: case 11:
                    day = r.Next(1, 31);
                    break;

                case 2:
                    day = r.Next(1, 29);
                    break;
            }

            return new DateTime(year, month, day);
        }

        public static string GetFakeCPR(string gender, DateTime birthDate)
        {
            Random rnd = new Random();

            string day;
            string month;

            if (birthDate.Day < 10)
                day = "0" + birthDate.Day.ToString();
            else day = birthDate.Day.ToString();
            if (birthDate.Month < 10)
                month =  "0" + birthDate.Month.ToString();
            else month = birthDate.Month.ToString();

            string cpr = day + month + birthDate.Year.ToString().Substring(2, 2) + rnd.Next(0, 10).ToString() + rnd.Next(0, 10).ToString() + rnd.Next(0, 10).ToString();


            if (gender == "male")
            {
                cpr += RandomNumberOdd(0,10);
            }
            else if(gender=="female")
            {
                cpr += RandomNumberEven(0,10);
            }
            else
            {
                throw new Exception();
            }
            return cpr;
        }

        /// <summary>
        /// Random number generators by Farhad Jabiyev
        /// </summary>
        private static int RandomNumberEven(int min, int max)
        {
            Random random = new Random();
            int ans = random.Next(min, max);
            if (ans % 2 == 0) return ans;
            else
            {
                if (ans + 1 <= max)
                    return ans + 1;
                else if (ans - 1 >= min)
                    return ans - 1;
                else return 0;
            }
        }

        /// <summary>
        /// Random number generators by Farhad Jabiyev
        /// </summary>
        private static int RandomNumberOdd(int min, int max)
        {
            Random random = new Random();
            int ans = random.Next(min, max);
            if (ans % 2 == 1) return ans;
            else
            {
                if (ans + 1 <= max)
                    return ans + 1;
                else if (ans - 1 >= min)
                    return ans - 1;
                else return 0;
            }
        }

        public static int GetPhoneNumber()
        {
            List<int> list = new List<int>()
            { 2, 30, 31, 40, 41, 42, 50, 51, 52, 53, 60, 61, 71, 81, 91, 92, 93, 342, 344, 345, 346, 347, 348, 349, 356, 357, 359, 
                362, 365, 366, 389, 398, 431, 441, 462, 466,  468,  472,  474,  476,  478,  485, 486,  488, 489, 493, 494, 495, 496,  
                498, 499,  542, 543,  545,  551, 552, 556, 571, 572, 573, 574, 577, 579, 584, 586, 587, 589, 597, 598, 627, 629, 641, 
                649, 658, 662, 663, 664, 665, 667, 692, 693, 694, 697, 771, 772, 782, 783, 785, 786, 788, 789, 826,827,829 };
            Random random = new Random();
            int phone = list[random.Next(0, list.Count)];
            //phone = phone * 10 ^ (8 - phone.ToString().Length) + random.Next(0, 9) * 10 ^ (8 - phone.ToString().Length - 1);
            //switch (phone.ToString().Length)
            //{
            //    case 4: phone = phone * 10000 + random.Next(1000, 9999);
            //        break;
            //    case 3: phone = phone * 100000 + random.Next(10000, 99999);
            //        break ;
            //    case 2:
            //        phone = phone * 1000000 + random.Next(100000, 999999);
            //        break;
            //    default: break;
            //}
            //return phone;
            while (phone.ToString().Length !=8)
            {
                phone = phone*10 + random.Next(0,10);
            }
            return phone;
        }
        
    }
}
