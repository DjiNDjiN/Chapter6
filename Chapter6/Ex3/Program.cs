using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int min = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                int integer = int.Parse(Console.ReadLine());
                if (integer > max)
                {
                    max = integer;
                }
                if (min > integer)
                {
                    min = integer;
                }
            }
            Console.WriteLine(min);
            Console.WriteLine(max);

        }
    }
}
