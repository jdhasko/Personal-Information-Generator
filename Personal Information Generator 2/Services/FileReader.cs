using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Personal_Information_Generator_2.Services
{
    internal class FileReader
    {
        public static string ReadText(string path)
        {
            return System.IO.File.ReadAllText(path);
        }
    }
}
