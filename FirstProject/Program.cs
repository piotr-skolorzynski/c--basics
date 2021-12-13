using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Linq;

namespace FirstProject
{
    class Program
    {
        public static IEnumerable<int> GetData()
        {
            Console.WriteLine("Get data start");
            var result = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Get data element: {i}");
                result.Add(i);
            }

            Console.WriteLine("Get data end");

            return result;
        }
        public static IEnumerable<int> GetYieldedData()
        {
            Console.WriteLine("Get yieldData start");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Get data element: {i}");
                yield return i;
                if (i % 3 == 0)
                {
                    yield break;
                }
            }

            Console.WriteLine("GetYieldData end");

        }
        static void Main(string[] args)
        {
            var data = GetData();
            foreach (int element in data)
            {
                Console.WriteLine(element);
            } 

            var yieldedData = GetYieldedData();
            foreach(int element in yieldedData)
            {
                Console.WriteLine(element);
            }
        }
    }
}


