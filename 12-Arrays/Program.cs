using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /* We maken een array die integers kan bevatten */

            int getal1 = 121;
            int getal2 = 234;
            int getal3 = 2;
            int getal4 = 5;
            int getal5 = 256;


            int[] geheleGetallen = new int[10];
            geheleGetallen[0] = 121;
            geheleGetallen[1] = 234;
            geheleGetallen[2] = 2;
            geheleGetallen[3] = 5;
            geheleGetallen[4] = 256;

            geheleGetallen[3] = 105;

            float[] floats = new float[] { 2.0f, 3.1f, 5.5f, 6.9f, 10.0f };

            for (int i = 0; i < geheleGetallen.Length; i++)
            {
                Console.WriteLine("Dit zijn de elementenuit het array geheleGetallen: {0}", geheleGetallen[i]);
            }
            /*
            Console.WriteLine("De waarde van getal1 is: {0}", getal1);
            Console.WriteLine("De waarde van getal2 is: {0}", getal2);
            Console.WriteLine("De waarde van getal2 is: {0}", getal3);
            Console.WriteLine("De waarde van getal2 is: {0}", getal4);
            Console.WriteLine("De waarde van getal2 is: {0}", getal5);
            */

            // Maak een string array die vijf zinnen als elementen heeft

            string[] asciArt = new string[5];
            asciArt[0] = "xxxxxxxxxxxxxxxxxx";
            asciArt[1] = "x  x   xx   x    x";
            asciArt[2] = "x  x   xx   x    x";
            asciArt[3] = "x  x   xx   x    x";
            asciArt[4] = "xxxxxxxxxxxxxxxxxx";

            for (int j = 0; j < asciArt.Length ; j++)
            {
                Console.WriteLine(asciArt[j]);
            }

            

            // Maak een char array bestaande uit 25 characters en vul deze zodanig dat er een 
            // woord gevormd wordt als je ze naar het scherm stuurd.

            char[] woord = new char[25];

            woord[0] = 't';
            woord[1] = 'e';
            woord[2] = 'r';
            woord[3] = 'u';
            woord[4] = 'g';
            woord[5] = 'k';
            woord[6] = 'o';
            woord[7] = 'p';
            woord[8] = 'p';
            woord[9] = 'e';
            woord[10] = 'l';
            woord[11] = 'i';
            woord[12] = 'n';
            woord[13] = 'g';
            woord[14] = 's';
            woord[15] = 'm';
            woord[16] = 'e';
            woord[17] = 'c';
            woord[18] = 'h';
            woord[19] = 'a';
            woord[20] = 'n'; 
            woord[21] = 'i';
            woord[22] = 's';
            woord[23] = 'm';
            woord[24] = 'e';

            foreach (char letter in woord)
            {
                if (letter == 'm')
                    break;
                Console.Write(letter);
            }


            Console.ReadLine();
        }
    }
}
