using System;
using System.Globalization;

namespace FirstProject

    /* Zadanie:

    Utwórz aplikację konsolową, która będzie wczytywać wartości liczbowe od użytkownika, dopóki nie poda on wartości 0.

    Podczas czytania, aplikacja powinna:

    obliczyć sumę wszystkich elementów

    znaleźć największy element

    Po wczytaniu wartości 0, te dwie wartości powinny zostać wypisane w konsoli. */
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert numbers: ");

            int chosenNumber = int.Parse(Console.ReadLine());
            int sum = 0;
            int? highestNumber = null;

            while (chosenNumber != 0)
            {
                if (chosenNumber == null || chosenNumber > highestNumber)
                {
                    highestNumber = chosenNumber;
                }
                sum += chosenNumber;
                chosenNumber = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Sum of numbers = {sum}");
            if (highestNumber != null)
            {
            Console.WriteLine($"The highest number is: {highestNumber}");

            } else
            {
                Console.WriteLine("No values inserted");
            }
        }
    }
}


