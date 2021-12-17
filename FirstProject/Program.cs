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
            var document1 = File.ReadAllText(@"D:\csharp-basics\FirstProject\TextFiles\Read\document1.txt");
            var document2 = File.ReadAllLines(@"D:\csharp-basics\FirstProject\TextFiles\Read\document2.txt");

            Console.WriteLine("document1:");
            Console.WriteLine(document1);
            Console.WriteLine("document2:");
            //first solution to show text from table
            /*foreach (var element in document2)
            {
                Console.WriteLine(element);
            }*/
            //second solution
            var documentToString = string.Join(Environment.NewLine, document2);
            Console.WriteLine(documentToString);
        }

        //example of saving text file using template in template.txt file
        static void GenerateDocuments()
        {
            Console.WriteLine("Insert name:");
            var name = Console.ReadLine();

            Console.WriteLine("Insert order number");
            var orderNumber = Console.ReadLine();

            var template = File.ReadAllText(@"D:\csharp-basics\FirstProject\TextFiles\Write\template.txt");
            //replace values in template
            var document = template.Replace("{name}", name)
                .Replace("{orderNumber}", orderNumber)
                .Replace("{dateTime}", DateTime.Now.ToString());
            //create txt file on hard drive
            File.WriteAllText($"D:/csharp-basics/FirstProject/TextFiles/Write/document-{name}.txt", document);

        }
        static void Main(string[] args)
        {
            //execute method
            ReadFiles();
            GenerateDocuments();
        }
    }
}


