using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string hex = string.Empty;
            int remainder = int.MaxValue;

            while (n > 0)
            {
                remainder = n % 16;
                n = n / 16;
                if (remainder > 9)
                {
                    hex += (char)(65 + remainder - 10);
                }
                else
                {
                    hex += (char)('0' + remainder);
                }
            }
            for (int i = hex.Length - 1; i >= 0; i--)
            {
                Console.Write(hex[i]);
            }
            Console.WriteLine();

        }
    }
}
