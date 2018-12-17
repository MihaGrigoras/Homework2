using System;
using System.Runtime.InteropServices;

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

        //public readonly int MinimumAgeForRetirement;

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
            Console.Write("Please enter your gender (m/f): ");

            string genderTyped = Console.ReadLine().ToLower().Trim();

            Gender gender = Gender.Female;


            switch (genderTyped)
            {
                case "f":
                    gender = Gender.Female;
                    Console.WriteLine("Gender : Female");
                    Console.ReadLine();
                    break;
                case "m":
                    gender = Gender.Male;
                    Console.WriteLine("Gender : Male");
                    Console.ReadLine();
                    break;



            }



        }
    }
}
