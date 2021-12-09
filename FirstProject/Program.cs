using System;
using System.Globalization;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Person bill = new Person();
            bill.FirstName = "Bill";
            bill.SetDateOfBirth(new DateTime(1982, 8, 25));
            bill.SayHi();
        }
    }
}


