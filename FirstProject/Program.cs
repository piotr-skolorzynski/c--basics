using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Web;
using System.Reflection;
using Newtonsoft.Json;


namespace FirstProject
{
    class Program
    {
        //create delegate
        public delegate void Display(string value);
        static void Main(string[] args)
        {
            Display display = Console.WriteLine;
            display("test");

            var numbers = new int[] { 10, 30, 50 };
            DisplayNumbers(numbers, display);
        }

        static void DisplayNumbers(IEnumerable<int> numbers, Display display)
        {
            foreach(int number in numbers)
            {
                display(number.ToString());
            }
        }
    }
      
}


