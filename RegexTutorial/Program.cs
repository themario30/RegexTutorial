using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexTutorial
{
    class Program
    {
        static void Main(string[] args)
            {
            string test = "This is [:test 5] test.";
            string output;

            output = Regex.Replace(test, @"[.] *", "");


            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
