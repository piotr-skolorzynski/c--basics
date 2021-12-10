using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    class Person
    {
        // example of using static properties in class
        public static int Count = 0; //property to count number of created objects using this class
        public string FirstName;
        public string LastName;

        private DateTime dateOfBirth;

        //example of private property and methods getter and setter giving protected access
        /* private string contactNumber;

        public string ContactNumber
        {
            get { return contactNumber; }
            set { contactNumber = value; }
        } */

        //example of using shorthand for property

        public string ContactNumber { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Count++; //how to change static property when object is created
        }

        public Person(DateTime dateOfBirth, string firstName, string lastName) : this(firstName, lastName)
        {
            SetDateOfBirth(dateOfBirth);
        }

        public void SetDateOfBirth(DateTime date)
        {
            if(date > DateTime.Now)
            {
                Console.WriteLine("Invalid date of birth");
            }
            else
            {
                dateOfBirth = date;
            }
        }

        public DateTime GetDateOfBirth() => dateOfBirth;

        public void SayHi()
        {
            Console.WriteLine($"Hi, I'm {FirstName} {LastName} and I was born {GetDateOfBirth()}");
        }
    }

}


