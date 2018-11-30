using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N: ");
            int N = int.Parse(Console.ReadLine());
           
            for (int i = 0; i < N; i++)
            {
                for (int j = 1; j <= N; j++)
                {
                    Console.Write((i + j).ToString().PadLeft(3));
                }
                Console.WriteLine();
            }

        }
    }
}
