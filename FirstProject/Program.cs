using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Linq;
using System.IO;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System.Diagnostics;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise to transform string value to camel case and kebab case
            //kebab case:
            //some-variable-name

            //camel case:
            // someVariableName

            Console.WriteLine("Insert kebab cased variable name ");
            string kebabCased = Console.ReadLine();

            Console.WriteLine(KebabToCamelCase(kebabCased));

            Console.WriteLine("Insert camel cased variable name ");
            string camelCased = Console.ReadLine();
            
            Console.WriteLine(CamelCaseToKebab(camelCased));

        }
        static string KebabToCamelCase(string input)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                if (currentChar != '-')
                {
                    sb.Append(currentChar);
                }
                else
                {
                    // I presume there is no such situation lik some-variable-
                    char nextChar = input[i + 1];
                    sb.Append(char.ToUpper(nextChar)); //the same nextChar.ToString().ToUpper();
                    i++;
                }
            }
            return sb.ToString();
        }

        static string CamelCaseToKebab(string input)
        {
            StringBuilder sb = new StringBuilder();
            // this time use foreach loop
            foreach(char currentChar in input)
            {
                if (char.IsUpper(currentChar))
                {
                    sb.Append('-');
                    sb.Append(char.ToLower(currentChar));
                }
                else
                {
                    sb.Append(currentChar);
                }
            }
            return sb.ToString();
        }

    }
}


