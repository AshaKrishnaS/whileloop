﻿using System;

namespace whileloop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, sum = 0;

            while (i <= 5)
            {
                sum += i;
                i++;
            }
            Console.WriteLine("Sum = {0}", sum);
        }
    }
}
