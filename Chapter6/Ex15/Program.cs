using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15
{
    class Program
    {
        static void Main(string[] args)
        {
            string hex = Console.ReadLine();
            int counter = 0;
            double dec = 0;
            double digit = 0;
            for (int i = hex.Length - 1; i >= 0; i--)
            {
                if (hex[i] > '0' + 9)
                {
                    digit = hex[i] - 55;
                }
                else
                {
                    digit = hex[i] - 48;
                }
                dec += digit * Math.Pow(16, counter);
                counter++;
            }
            Console.WriteLine(dec);

        }
    }
}
