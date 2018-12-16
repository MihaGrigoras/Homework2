using System;

namespace PartOne
{
    class Program
    {
        // Create an enum for the genders (Female, Male)
        public enum Gender
        {
            Female,
            Male
        }

        static void Main(string[] args)
        {
            //Convert the 3 integers and create a DateTime for the birthdate

            Console.Write("Please enter the year of birth: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Please enter the month of birth: ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Please enter day of birth: ");
            int day = int.Parse(Console.ReadLine());

            DateTime birthDate = new DateTime(year, month, day);

            // Compute the age of the person, based on the birthdate 
            int age = (int)((DateTime.Now - birthDate).TotalDays/365.2425);
            Console.WriteLine("Your age is");
            Console.WriteLine(age);
          

            //Colect the gender of the user
            Console.Write("Please enter your gender (M/F): ");
            string gender= Console.ReadLine().ToUpper().Trim();
            Console.WriteLine(gender);
            Console.ReadLine();

            switch (gender)
            {
                case "M": gender = "male";
                    Console.WriteLine("male");
                    Console.ReadLine();
                    break;
                case "F": gender = "femele";
                    Console.WriteLine("femele");
                    Console.ReadLine();
                    break;
                default: throw new ArgumentException("Invalid value for gender");


            }

        }
    }
}
