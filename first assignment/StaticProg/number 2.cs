﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_assignment.StaticProg
{
    public static class Number_2
    {
        public static void add(int a, int b)
        {
            int result = a + b;

            Console.WriteLine("the addition of {0} and {1} is {2}", a, b, result);
            Console.ReadLine();
        }

        public static void subtract(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("the subtraction of {0} and {1} is {2}", a, b, result);
            Console.ReadLine();
        }
        public static void division(int a, int b)
        {
            int result = a / b;
            Console.WriteLine("the division of {0} and {1} is {2}", a, b, result);
            Console.ReadLine();
        }
        public static void multiplication(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("the multiplication of {0} and {1} is {2}", a, b, result);

            Console.ReadLine();

        }
    }
}
