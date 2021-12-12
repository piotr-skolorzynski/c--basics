﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Linq;

namespace FirstProject
{
    class Program
    {
        static Dictionary<string,Currency> GetCurrencies()
        {
            return new Dictionary<string, Currency>
            {
                {"usd", new Currency("usd", "United States Dollar", 1) },
                {"eur", new Currency("eur", "Euro", 0.83975) },
                {"gbp", new Currency("gbp", "British Pound", 0.74771) },
                {"cad", new Currency("cad", "Canadian Dollar", 1.30724) },
                {"inr", new Currency("inr", "Indian Rupee", 73.04) },
                {"mxn", new Currency("mxn", "Mexican Peso", 21.7571) },
            };
        }
        static void Main(string[] args)
        {
            var currencies = GetCurrencies();
            Console.WriteLine("Check the rate for:");
            var userInput  = Console.ReadLine();

            Currency selectedCurrency = null;
            if (currencies.TryGetValue(userInput, out selectedCurrency))
            {
                Console.WriteLine($"Rate for USD to {selectedCurrency.FullName} is {selectedCurrency.Rate}");
            }
            else
            {
                Console.WriteLine("Currency not found");
            }

            currencies.Remove("usd"); //how to delete element in dictionary

            //currencies.Add("usd", new Currency("pln", "Polski złoty", 4.45)); //adding element to dictionary
            currencies.TryAdd("usd", new Currency("pln", "Polski złoty", 4.45));
        }
    }
}


