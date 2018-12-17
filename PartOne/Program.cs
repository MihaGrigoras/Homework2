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

            // Convert the 3 integers and create a DateTime for the birthdate
            Console.Write("Please enter the year of birth: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Please enter the month of birth: ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Please enter day of birth: ");
            int day = int.Parse(Console.ReadLine());

            DateTime birthDate = new DateTime(year, month, day);

            // Compute the age of the person, based on the birthdate 
            int age = (int)((DateTime.Now - birthDate).TotalDays/365.2425);
            Console.WriteLine("Your age is : {0}", age);

            //Colect the gender of the user
            Console.Write("Please enter your gender (M/F): ");

            string letterTyped = Console.ReadLine().ToUpper().Trim();
            Console.WriteLine("You typed : {0}", letterTyped);

            //Gender gender = Gender.Female;
            Gender? gender = null;
   
            switch (letterTyped)
            {
                case "M":
                    gender = Gender.Male;
                    Console.WriteLine("Your gender : {0}", gender);
                    Console.ReadLine();
                    break;
                case "F":
                    gender = Gender.Female;
                    Console.WriteLine("Your gender : {0}", gender);
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("The typed value is incorrect");
                    Console.ReadLine();
                    break;

            }

        }
    }
}
