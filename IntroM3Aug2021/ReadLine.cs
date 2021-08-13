using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroM3Aug2021
{
    class ReadLine
    {
        public static void Demo()
        {
            Console.WriteLine("Velkommen!");
            Console.Write("Hva heter du? ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hei på deg, {name}!");
            //Console.WriteLine("Hei på deg, {0}-{0}!", name);
            Console.Write("I hvilket år er du født? ");
            string yearString = Console.ReadLine();
            int year = Convert.ToInt32(yearString);
            int age = 2021 - year;
            Console.WriteLine($"Da er du, {name}, {age} år gammel.");
            // `Da er du ${age} år gammel.`
        }
    }
}
