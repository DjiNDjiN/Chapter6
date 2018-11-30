using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            int nFactoriel = 1;
            for (int i = 1; i <= n; i++)
            {
                if (i % 5 == 0)
                {
                    counter++;
                }
                nFactoriel *= i;
            }

            Console.WriteLine("N = {0} -> N! = {1} -> {2}", n, nFactoriel, counter);

        }
    }
}
