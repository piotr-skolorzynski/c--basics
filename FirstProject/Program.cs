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
        static void Main(string[] args)
        {
            //example of using generic class to show values of different types in similar way
            //simulated list of restaurants to show
            var restaurants = new List<Restaurant>();
            //create object of Paginated generic class
            var result = new PaginatedResult<Restaurant>();
            //adding list of Restaurants to our newly created object
            result.Results = restaurants;

            //similar implementation
            var users = new List<User>();
            var result2 = new PaginatedResult<User>();
            result2.Results = users;

            //create repository with string values
            //after adding IEntity interface as generic constrain it
            //is imposible to do, var stringRepository = new Repository<string>();
            //stringRepository.AddElement("some value");
            //Console.WriteLine(stringRepository.GetElement(0));

            //implement usage of multiple parameters repository
            var userRepository = new Repository<string, User>();
            userRepository.AddElement("Bill", new User() { Name = "Bill"});
            User bill = userRepository.GetElement("Bill");


            //using generic method from Swap class
            int[] intArray = new[] { 1, 3, 5 };
            Console.WriteLine(string.Join(" ", intArray));
        }
    }
      
}


