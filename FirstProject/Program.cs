using System;
using System.Globalization;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Person bill = new Person("Bill", "Wick");
            bill.SetDateOfBirth(new DateTime(1982, 8, 25));
            bill.SayHi();

            Person john = new Person(new DateTime(1990, 2, 2), "John", "Malcowich");
            john.SayHi();
        }
    }
}


