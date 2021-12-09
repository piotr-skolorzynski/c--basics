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

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        /*public Person(DateTime dateOfBirth, string firstName, string lastName)
        {
            SetDateOfBirth(dateOfBirth);
            FirstName = firstName;
            LastName=lastName;
        }*/
        //zapisa powyższego konstruktora z 3 parametrami można uprościć, a bardziej zaznaczyć, że najpierw
        // ma się wykonać konstruktor z 2 parametrami a następnie trzema

        public Person(DateTime dateOfBirth, string firstName, string lastName) : this(firstName, lastName)
        {
            SetDateOfBirth(dateOfBirth);
        }

        // konstruktorów można mieć wiele, byle różniły się między sobą m.in. liczbą i typami parametrów
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

        public DateTime GetDateOfBirth()
        {
            return dateOfBirth;
        }
        // można zastosować expression value 
        // public DateTime GetDateOfBirth() => dateOfBirth;

        public void SayHi()
        {
            Console.WriteLine($"Hi, I'm {FirstName} {LastName} and I was born {GetDateOfBirth()}");
        }
    }

}


