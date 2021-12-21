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
            //DateTimeModification();
            //DateTimeFormatting();
            //TimeMeasurement();
            DateTimeHelpers();
        }

        static void DateTimeModification()
        {
            DateTime now = DateTime.Now;
            DateTime openDate = new DateTime(1992, 6, 17);

            TimeSpan result = now - openDate;

            Console.WriteLine(result.Days);
            Console.Write(result.TotalDays);

            DateTime expiresAt = now.AddDays(7);
            DateTime expiresAt2 = now.Add(new TimeSpan(7,1,0,0));

            Console.WriteLine(expiresAt);
            Console.Write(expiresAt2);

            bool expiresAtTheSameDay = expiresAt == expiresAt2;
            bool expiresAtTheSameDay2 = expiresAt.Date == expiresAt2.Date;
            Console.WriteLine($"expiresAtTheSameDay: {expiresAtTheSameDay}");
            Console.WriteLine($"expiresAtTheSameDay2: {expiresAtTheSameDay2}");
        }

        static void DateTimeFormatting()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToString("g"));
            Console.WriteLine(now.ToString("G"));
            Console.WriteLine(now.ToString("yyyy-MM-dd"));
            Console.WriteLine(now.ToString("yyyy-MM-dd hh:mm:ss"));
            Console.WriteLine(now.ToString("dd-MM-yyyy"));
        }

        static void TimeMeasurement()
        {
            Console.WriteLine("What is 2 + 2?");
            Console.WriteLine("A)4");
            Console.WriteLine("B)6");
            Console.WriteLine("C)8");
            /*
            DateTime start = DateTime.Now;
            string userAnswer = Console.ReadLine();
            DateTime end = DateTime.Now;
            TimeSpan responseTime = end - start;

            Console.WriteLine($"Response took you {responseTime.TotalSeconds} Seconds");
            */
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            // or Stopwatch stopwatch = StopWatch.StartNew();
            string userAnswer = Console.ReadLine();
            stopwatch.Stop();
            Console.WriteLine($"Response took you {stopwatch.Elapsed.TotalSeconds} Seconds");
        }

        static void DateTimeHelpers()
        {
            int daysInFeb2021 = DateTime.DaysInMonth(2021, 2);
            bool is2021LeapYear = DateTime.IsLeapYear(2021);

            Console.WriteLine($"days in February 2021: {daysInFeb2021} and is 2021 a leap year?: {is2021LeapYear}");
        }
    }
}


