using System;
using System.IO;

namespace RegExLab_A
{
    class Program
    {
        static String searchPatt = @"\\texttt\{([A-Za-z]+|\d+)\}"; // modify regex here...
        static String replacePatt = @"\begin{ttfamily}$1\end{ttfamily}"; // ...and here
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
