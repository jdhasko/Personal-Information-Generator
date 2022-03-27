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
            int year = r.Next(1900, 2022);
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
    }
}
