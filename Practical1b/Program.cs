using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical1b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a String");
            string s = Console.ReadLine();
            Console.WriteLine(s.ToLower());
            Console.WriteLine(s.ToUpper());
            Console.WriteLine(s.Contains("More"));
            Console.WriteLine(s.Length);
            Console.WriteLine(s.Trim().Length);
            Console.WriteLine(s.TrimEnd().Length);
            Console.WriteLine(s.TrimStart().Length);
            Console.ReadKey();

        }
    }
}
