using System;

namespace PartTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. ToLower()
            string upperCase = "SUMMER DAYS";
            // Call ToLower instance method, which returns a new copy.
            string lower = upperCase.ToLower();
            Console.WriteLine("{0}", lower);
           // Console.ReadLine();

            // 2. Trim
            string textWithSpaces = "  Coffee Time "; ;
            string textWithoutSpaces = textWithSpaces.Trim();
            Console.WriteLine("{0}", textWithoutSpaces);
            //Console.ReadLine();

        }
    }
}
