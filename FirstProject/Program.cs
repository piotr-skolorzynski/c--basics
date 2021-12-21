using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Linq;
using System.IO;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System.Diagnostics;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //using extenden method from created type Utils
            DateTime now = DateTime.Now;
            DateTime before = now.Subtract(new TimeSpan(7,0,0,0));
            DateTime after = now.AddDays(7);
            //using static method
            bool isDateBetween = Utils.IsDateBetween(now, before, after);
            //using extension method
            bool isDateBetween2 = now.IsBetween(before, after);

            //another examp for int type returnin squared number
            int value = 2;
            Console.WriteLine($"Squared value: {value.Suqared()}");

        }

    }
}


