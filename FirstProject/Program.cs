using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace FirstProject
{
    class Program
    {
        //method to display List
        static void DisplayElements(List<int> list)
        {
            Console.WriteLine("** List **");
            foreach (int element in list)
            {
                Console.Write($"{element}, ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
           List<int> intList = new List<int>() { 6, 1, 20, 3, 45, 60, 100, 2 }; //creating collection type List with default values
            DisplayElements(intList); //displaying declared List
            //adding element to the List
            Console.WriteLine("New element: ");
            int newElement = int.Parse(Console.ReadLine());
            intList.Add(newElement);//adding new element to the list
            DisplayElements(intList); //display List again to show that new element was added to the List

            //example of using method RemoveRange
            Console.WriteLine("Remove range");
            intList.RemoveRange(1, 2);
            DisplayElements(intList);

            //sorting example
            Console.WriteLine("Sort");
            intList.Sort();
            DisplayElements(intList);
        }
    }
}


