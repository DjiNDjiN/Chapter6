
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете десетично число n:");
            int n = int.Parse(Console.ReadLine());            
            Console.WriteLine("Числото n е {0} като двуично.", Convert.ToString(n, 2));
        }
    }
}
