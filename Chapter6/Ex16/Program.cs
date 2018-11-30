using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex16
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[] printed = new bool[n + 1];
            Random randNumber = new Random();
            int numberToPrint;
            for (int i = 1; i <= n; i++)
            {
                numberToPrint = randNumber.Next(1, n + 1);
                if (!printed[numberToPrint])
                {
                    Console.WriteLine(numberToPrint);
                    printed[numberToPrint] = true;
                    continue;
                }
                i--;
            }

        }
    }
}
