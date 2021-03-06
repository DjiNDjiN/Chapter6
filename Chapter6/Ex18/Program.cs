﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex18
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int row = 0, column = 0, m = 0, i = 1, temp = n;
            while (i <= temp * temp)
            {
                for (; column < n; column++)
                {
                    matrix[row, column] = i;
                    i++;
                }
                row++;
                column--;
                for (; row < n; row++)
                {
                    matrix[row, column] = i;
                    i++;
                }
                row--;
                column--;
                for (; column >= m; column--)
                {
                    matrix[row, column] = i;
                    i++;
                }
                column++;
                row--;
                for (; row > m; row--)
                {
                    matrix[row, column] = i;
                    i++;
                }
                row++;
                column++;
                m++;
                n--;
            }

            for (int k = 0; k < temp; k++)
            {
                for (int j = 0; j < temp; j++)
                {
                    Console.Write("{0,4}", matrix[k, j]);
                }
                Console.WriteLine();

            }
        }
    }
}