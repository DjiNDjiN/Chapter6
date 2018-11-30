using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13
{
    class Program
    {
        static void Main(string[] args)
        {
            string number;
            int dec = 0;
            number = Console.ReadLine();

            for (int i = number.Length - 1, j = 0; i >= 0; i--, j++)
            {
                if (number[i] == '1')
                {
                    dec = dec | (1 << j);
                }
            }
            Console.WriteLine(dec);


        }
    }
}
