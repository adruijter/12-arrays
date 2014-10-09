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

            for (int i = 0; i < 5; i++)
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


            Console.ReadLine();
        }
    }
}
