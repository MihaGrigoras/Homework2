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
            Console.WriteLine("1.toLower Method: {0}", lower);
           // Console.ReadLine();

            // 2. Trim
            string textWithSpaces = "  Coffee Time "; ;
            string textWithoutSpaces = textWithSpaces.Trim();
            Console.WriteLine("2.TrimMethod: {0}", textWithoutSpaces);
            //Console.ReadLine();

            // 3.Length
            string a = "I like coffee";
            Console.WriteLine("3.Length method: {0}", a.Length);

            // 4.Substring
            string fullName = "Miha Grigoras";
            // Get first three characters.
            string firstName = fullName.Substring(0, 4);
            Console.WriteLine("4.Substring method: {0}", firstName);

            // 5.Remove
            string input = "MihaG";
            string result = input.Remove(4);
            Console.WriteLine("5.Remove method: {0}", result);

            // 6. Concat
            string lastName = "Grigoras";
            string name = "Miha" + lastName;
            Console.WriteLine("6.Concat method: {0}", name);

            // 7.IsNullOrEmpty
            string s = null;
            if (string.IsNullOrEmpty(s) == true)
            {
                Console.WriteLine("7.IsNullOrEmpty method: Null or empty");
            }
            else
            {
                Console.WriteLine("7.IsNullOrEmpty method: Not null and not empty");
            }
            Console.ReadLine();



        }
    }
}
