using System;
using System.IO;

namespace RegExLab_A
{
    class Program
    {
        static String searchPatt = @"\$v_(?:([\dA-Za-z])|\{([\dA-Za-z]*)\})\$"; // modify regex here...
        static String replacePatt = "v[$1$2]"; // ...and here
        static void Main(string[] args)
        {
            String str = Console.ReadLine();
            while (str != null)
            {
                String newStr = System.Text.RegularExpressions.Regex.Replace(str, searchPatt, replacePatt);
                Console.WriteLine(newStr);
                str = Console.ReadLine();
            }
        }
    }
}
