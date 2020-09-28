﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples3and5
{
    class Program
    {
        static void Main(string[] args)
        {
            // If we list all the natural numbers below 10
            // that are multiples of 3 or 5, we get 3, 5,
            // 6 and 9.The sum of these multiples is 23.
            // Find the sum of all the multiples of 3 or 5 below 1000 and print it out to the console.
            int sum = 0;

            //multiples of 5
            for (int i = 0; i < 1000; i += 5) { sum += i; }
            //multiples of 3 excluding multiples of 5
            for (int i = 0; i < 1000; i += 3) { if (i % 5 != 0) sum += i; }

            Console.WriteLine(sum);
        }
    }
}
