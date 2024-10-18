using System;
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
            int a, b, resultAdd, resultSub, resultMul;
            double resultSin;
            Console.WriteLine("Введите первое число ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число ");
            b = Convert.ToInt32(Console.ReadLine());
            resultAdd = a + b;
            Console.WriteLine("{0} + {1} = {2}",a,b,resultAdd);
            resultSub = a - b;
            Console.WriteLine("{0} - {1} = {2}", a, b, resultSub);
            resultMul = a * b;
            Console.WriteLine("{0} * {1} = {2}", a, b, resultMul);
            resultSin = Math.Sin(a);
            Console.WriteLine($"Sin({a}) = {resultSin}");

            Console.ReadKey();
        }
    }
}
