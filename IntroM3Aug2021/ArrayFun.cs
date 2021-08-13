using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace IntroM3Aug2021
{
    class ArrayFun
    {
        private static int j = default(int);
        public static void Demo1()
        {
            /*
             * verdityper - primitive datatyper
             * byte - heltall - 1 byte
             * short - heltall - 2 bytes
             * int - heltall - 4 bytes
             * uint - positivt heltall - 4 bytes
             * long - heltall - 8 bytes
             * float - desimaltall
             * double - desimaltall
             * bool - true eller false
             * char - ett tegn
             *
             * referanse-typer
             * string - tekst, dvs. flere tegn
             */

            string x = "Hei";
            int i = 2;
            uint u = 2;
            Console.WriteLine(i);
            Console.WriteLine(j);

            int[] b = null;
            int[] a = new int[10];
            string[] s = new string[10];



            //s[2] = 5;
            //a[2] = "gh";

            double d = 5.5;
            float f = 5.5f;

            
        }

        public static void Demo2()
        {
            string[] strings = new string[4];
            int i = 0;
            while (true)
            {
                var text = Console.ReadLine();
                strings[i] = text;
                Console.WriteLine(string.Join(" - ", strings));
                i++;
            }
        }
    }
}
