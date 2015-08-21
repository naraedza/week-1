using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_1
{
    class BubbleSort
    {
        static void Main(string[] args)
        {
            int x = 0;
            //int ii = 0;
            // input
            int[] input = { 4, 5, 2, 8, 9, 1, 2, 4, 3, 1 };


            // process
            do
            {
                x = 0;
                for (int i = 0; i != input.Length - 1; i++)
                {
                    if (input[i] > input[i + 1])
                    {
                        int temp = input[i];
                        input[i] = input[i + 1];
                        input[i + 1] = temp;
                        x=1;
                    }
                }
            } while (x != 0);

            // output
            for (int i = 0; i != input.Length; i++)
            {
                Console.Write(input[i]);
                Console.Write(" ");
            }

            //Console.Write(ii);
            Console.ReadKey();
        }
    }
}
