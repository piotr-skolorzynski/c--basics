﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Linq;
using System.IO;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert input:");
            string userInput = Console.ReadLine();

            //SubString(userInput);
            //Replace(userInput);
            //Modify(userInput);
            //Split(userInput);
            // CheckString(userInput);
        }

        //examp of using method Substring
        static void SubString(string userInput)
        {
            if(userInput.Length > 10)
            {
                string startSubstring = userInput.Substring(0,10);
                string endSubstring = userInput.Substring(userInput.Length - 10);
                Console.WriteLine($"{startSubstring}..., ...{endSubstring}");

            }
        }

        static void Replace(string userInput)
        {
            string template = "Hello {name}, how are you?";
            string output = template.Replace("{name}", userInput);
            Console.WriteLine(output);
        }

        static void Modify(string userInput)
        {
            string removedString = userInput.Remove(5);
            string insertedString = userInput.Insert(5, "INSERT");
            Console.WriteLine(insertedString);
            string trimmedString = userInput.Trim();
            Console.WriteLine(trimmedString);

        }

        static void AlterTextCase(string userInput)
        {
            string upperCased = userInput.ToUpper();
            string lowerCased = userInput.ToLower();

            Console.WriteLine(upperCased);
            Console.WriteLine(lowerCased);
        }

        static void Split(string userInput)
        {
            string[] inputParts = userInput.Split(" ");
            string firstName = inputParts[0];
            string lastName = inputParts[inputParts.Length - 1];
            Console.WriteLine($"Hello {firstName} {lastName}");
        }

        static void CheckString(string userInput)
        {
            bool isTextFile = userInput.EndsWith(".txt", StringComparison.CurrentCultureIgnoreCase);
            bool startsWithDocPrefix = userInput.StartsWith("doc-", StringComparison.CurrentCultureIgnoreCase);
            bool containsText = userInput.Contains("TEXT", StringComparison.CurrentCultureIgnoreCase);
            Console.WriteLine($"containsText: {containsText}");
            Console.WriteLine($"isTextFile: {isTextFile}");
            Console.WriteLine($"startsWithDocPrefix: {startsWithDocPrefix}");
        }
    }
}


