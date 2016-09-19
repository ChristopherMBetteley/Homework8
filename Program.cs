using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> animals = new Dictionary<string, int>();
            animals.Add("Bear", 4);
            animals.Add("Squid", 10);
            animals.Add("Bird", 2);
            animals.Add("Penguin", 2);
            animals.Add("Snake", 0);
            animals.Add("Raccoon", 4);

            if (animals.ContainsKey("Bear"))
            {
                int value = animals["Bear"];
                Console.WriteLine("Bear has " +value + " legs.");
            }
            if (animals.ContainsKey("Snake"))
            {
                int value = animals["Snake"];
                Console.WriteLine("Snake has " + value + " legs.");
            }
            if (animals.ContainsKey("Bat"))
            {
                int value = animals["Bat"];
                Console.WriteLine("Bat has " + value + " legs.");
            }
            if (animals.ContainsKey("Bird"))
            {
                int value = animals["Bird"];
                Console.WriteLine("Bird has " + value + " legs.");
            }
            Console.ReadKey();
        }
    }
}
