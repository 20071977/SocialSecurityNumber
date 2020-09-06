using System;
using System.Globalization;

namespace SocialSecurityNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Social Security Number(yyMMdd-xxxx): ");

            string socialSecurityNumber = Console.ReadLine();
            string gender;
            int genderNumber=int.Parse(socialSecurityNumber.Substring(socialSecurityNumber.Length -2,1));
            bool isFemale = genderNumber % 2 == 0;
            gender = isFemale ? "Female" : "Male";

            DateTime birthDate = DateTime.ParseExact(socialSecurityNumber.Substring(0, 6), "yyMMdd", CultureInfo.InvariantCulture);
            int age = DateTime.Now.Year - birthDate.Year;
            if((birthDate.Month>DateTime.Now.Month)|| (birthDate.Month == DateTime.Now.Month && birthDate.Day > DateTime.Now.Day))
            {
                age = age - 1;
            }
            Console.WriteLine($"{gender},{age}");
            

        }
    }
}
