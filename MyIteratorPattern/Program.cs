using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyIteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Collection collection = new Collection();
            collection[0] = new Horse("Jerry");
            collection[1] = new Horse("Lucy");
            collection[2] = new Horse("Chipper");
            collection[3] = new Horse("Clarcon");
            collection[4] = new Horse("Cardento");
            collection[5] = new Horse("Toulon");
            collection[6] = new Horse("Don");
            collection[7] = new Horse("Kilka");
            collection[8] = new Horse("Champ");

            Iterator iterator = collection.CreateIterator();

            Console.WriteLine("Iterating over collection:");

            for (Horse horse = iterator.First();
                !iterator.IsRidden(); horse = iterator.Next())
            {
                Console.WriteLine(horse.Name);
            }

            Console.ReadKey();
        }
    }
}
