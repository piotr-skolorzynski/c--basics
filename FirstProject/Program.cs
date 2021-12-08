using System;
using System.Globalization;

namespace FirstProject
{
    class Program
    {

        /* Utwórz aplikację konsolową która pobierze
         * od użytkownika datę jego urodzin i na tej podstawie
         * obliczy ile mięło dni od tej daty do obecnego dnia. */

        static void Main(string[] args)
        {
            /* Console.WriteLine("Insert the day");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert the month");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert the year");
            int year = int.Parse(Console.ReadLine());

            DateTime dateOfBirth = new DateTime(year, month, day);

            TimeSpan timeSpan = DateTime.Now - dateOfBirth;
            Console.WriteLine($"You were born {timeSpan.TotalDays} days ago"); */

            Console.WriteLine("Insert the date of birth (dd.MM.yyyy)");
            string dateOfBirthString = Console.ReadLine();
            DateTime dateOfBirth = DateTime.Parse(dateOfBirthString);
            TimeSpan timeSpan = DateTime.Now - dateOfBirth;
            Console.WriteLine($"You were born: {timeSpan.TotalDays} days ago");


        }
    }
}


