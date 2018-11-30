using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter x: ");
            int x = int.Parse(Console.ReadLine());
            int i = 1;
            double sum = 1;
            double factorial = 1;
            double division = 1;
            do
            {
                factorial *= i;
                division = Math.Pow(x, i);
                sum += factorial / division;
                i++;
            } while (i <= n);
            Console.WriteLine("{0}", sum);
        }
    }
}
