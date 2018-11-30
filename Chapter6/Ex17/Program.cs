using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex17
{
    class Program
    {
        static int FindGreatestCommonDivisor(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }
            if (a == 0)
                return b;
            else
                return a;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int greatestCommonDivisor;
            greatestCommonDivisor = FindGreatestCommonDivisor(n, k);
            Console.WriteLine(greatestCommonDivisor);
        }



    }
}

