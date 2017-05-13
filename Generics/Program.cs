using System;
using System.Collections.Generic;


namespace Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            UseTheMagicHat();

            Console.WriteLine("Ta Da!");
            Console.ReadLine();
        }

        private static void UseTheMagicHat()
        {
 
            List<Rabbit> rabbitList = new List<Rabbit>      // intialize List of Rabbit collection
            {
                new Rabbit {Name = "Bugs"},
                new Rabbit {Name = "Roger"},
                new Rabbit {Name = "Thumper"}
            };

            var firstRabbitName = rabbitList[0].Name;

            Console.WriteLine(firstRabbitName);

            // rabbitList.Add("Energizer Bunny");     // compile error

            #region Dictionary Example

            //Dictionary<string, Rabbit> rabbitDictionary = new Dictionary<string, Rabbit>();

            //rabbitDictionary.Add("1", new Rabbit { Name = "Bugs" });
            //rabbitDictionary.Add("2", new Rabbit { Name = "Roger" });
            //rabbitDictionary.Add("3", new Rabbit { Name = "Thumper" });

            //var firstRabbitName2 = rabbitDictionary["1"].Name;
            //Console.WriteLine(firstRabbitName2);

            //// rabbitDictionary.Add("4", "Energizer Bunny"});    // compile error


            //Console.ReadLine();

            #endregion
        }

    }
}
