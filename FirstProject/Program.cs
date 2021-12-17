using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Linq;
using System.IO;

namespace FirstProject
{
    class Program
    {
        static void ReadFiles()
        {
            //reading text files
            var document1 = File.ReadAllText(@"D:\csharp-basics\FirstProject\TextFiles\document1.txt");
            var document2 = File.ReadAllLines(@"D:\csharp-basics\FirstProject\TextFiles\document2.txt");

            Console.WriteLine("document1:");
            Console.WriteLine(document1);
            Console.WriteLine("document2:");
            //first solution to show text from table
            /*foreach (var element in document2)
            {
                Console.WriteLine(element);
            }*/
            //second solution
            var documentToString =  string.Join(Environment.NewLine, document2);
            Console.WriteLine(documentToString);
        }
        static void Main(string[] args)
        {
            //execute method
            ReadFiles();
        }
    }
}


