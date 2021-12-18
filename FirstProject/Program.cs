using System;
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
            /*var player = new Player()
            {
                Name = "Mario",
                Level = 1,
                HealPoints = 100,
                Statistics = new List<Statistics>()
                {
                    new Statistics()
                    {
                        Name = "Strength",
                        Points = 10
                    },
                    new Statistics()
                    {
                        Name = "Intelligence",
                        Points = 10
                    }
                }
            };

            //..
            player.Level++;

            //serialize object to JSON
            string playerSerialized = JsonConvert.SerializeObject(player);
            //save serialized object in file
            File.WriteAllText(@"D:/csharp-basics/FirstProject/TextFiles/JSON/playerSerialized.json", playerSerialized);*/

            //deserialization
            string playerSerialized = File.ReadAllText(@"D:/csharp-basics/FirstProject/TextFiles/JSON/playerSerialized.json");
            Player player = JsonConvert.DeserializeObject<Player>(playerSerialized);
            Console.WriteLine(player.Name);
        }
    }
}


