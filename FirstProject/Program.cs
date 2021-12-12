using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Linq;

namespace FirstProject
{
    class Program
    {
        static List<Person> GetEmployees()
        {
            List<Person> employees = new List<Person>()
            {
                new Person(new DateTime(1990, 2, 2), "Bill", "Wick"),
                new Person(new DateTime(1995, 6, 3), "John", "Wick"),
                new Person(new DateTime(1996, 4, 3), "Bob", "Wick"),
                new Person(new DateTime(2001, 2, 2), "Bill", "Smith"),
                new Person(new DateTime(2000, 2, 2), "John", "Smith"),
                new Person(new DateTime(2005, 2, 2), "Bob", "Smith"),
                new Person(new DateTime(2003, 2, 2), "Ed", "Smith"),
            };
            return employees;
        }
        static void Main(string[] args)
        {
          List<Person> employees = GetEmployees();
            
            // using linq
          bool EmployeeIsYoung(Person employee)
          {
                return employee.GetDateOfBirth() > new DateTime(2000, 1, 1);
          }

          List<Person> youngEmployess = employees.Where(EmployeeIsYoung).ToList();
            
          Console.WriteLine($"Young employees count: {youngEmployess.Count}");

            // using linq
            bool EmployeeIsBob(Person employee)
            {
                return employee.FirstName == "Bob";
            }

            Person bob = youngEmployess.FirstOrDefault(EmployeeIsBob);

            if (bob != null)
            {
                bob.SayHi();
            }
            else
            {
                Console.WriteLine("Bob not found");
            }
        }
    }
}


