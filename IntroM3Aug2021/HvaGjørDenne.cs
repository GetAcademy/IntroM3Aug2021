using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroM3Aug2021
{
    class HvaGjørDenne
    {
        public static void Demo()
        {
            var range = 255;
            var counts = new int[range];
            string text = "something";
            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine();
                CountChars(text, counts);
                ShowCharsAndCounts(range, counts);
            }
        }

        private static void ShowCharsAndCounts(int range, int[] counts)
        {
            for (var i = 0; i < range; i++)
            {
                if (counts[i] > 0)
                {
                    var character = (char)i;
                    Console.WriteLine(character + " - " + counts[i]);
                }
            }
        }

        private static void CountChars(string text, int[] counts)
        {
            foreach (char character in text)
            {
                counts[(int)character]++;
            }
        }
    }
}
