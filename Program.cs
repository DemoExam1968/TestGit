﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, resultAdd;
            Console.WriteLine("Введите первое число ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число ");
            b = Convert.ToInt32(Console.ReadLine());
            resultAdd = a + b;
            Console.WriteLine("{0} + {1} = {2}",a,b,resultAdd);
            Console.ReadKey();
        }
    }
}
