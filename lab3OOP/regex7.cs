using System;
using System.IO;

namespace RegExLab_A
{
    class Program
    {
        static String searchPatt = @"(\b[A-Z][a-zA-Z]*\b(?: +\b[A-Z][a-zA-Z]*\b){2,})";
        static String replacePatt = @"""$1""";
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
