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
            int year = r.Next(1900, DateTime.Now.Year);
            int month = r.Next(0, 12);
            int day = 0;
            switch (month)
            {
                case 1: case 3: case 5: case 7: case 8: case 10: case 12: 
                    day = r.Next(0, 31);
                    break;
                case 4: case 6: case 9: case 11:
                    day = r.Next(0, 30);
                    break;

                case 2:
                    day = r.Next(0, 29);
                    break;
            }
            return new DateTime(year, month, day);
        }

        public static string GetFakeCPR(string gender, DateTime birthDate)
        {
            Random rnd = new Random();
            string cpr = birthDate.Day.ToString() + birthDate.Month.ToString() + Convert.ToInt32(birthDate.Year.ToString().Substring(0, 2)) + rnd.Next(0, 10) + rnd.Next(0, 10) + rnd.Next(0, 10);

            if (gender == "male")
            {
                cpr += RandomNumberOdd(0,10);
            }
            else
            {
                cpr += RandomNumberEven(0,9);
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
    }
}
