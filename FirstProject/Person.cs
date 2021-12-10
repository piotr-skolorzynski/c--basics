using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    class Person
    {
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


