using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    class Program
    {
        public delegate void Method(int n);
        static void Main(string[] args)
        {
            Console.Write("Введите точность: ");
            int n = int.Parse(Console.ReadLine());
            Method met1 = new Method(Method1);
            met1 += Method2;
            met1 += Method3;
            met1(n);
            Console.ReadKey();
        }
        public static void Method1(int n)
        {
            double result = 0;
            int denom = 1;
            for (int i = 1; i <= n; i++)
            {
                result = result + 1.0 / denom;
                denom *= 2;
            }
            Console.WriteLine("Результат обчислення за першою формулою: {0:0.00} ", result);


        }

        public static void Method2(int n)
        {
            double result = 0;
            for (int i = 1; i <= n; i++)
            {
                result += 1.0 / Factorial(i);
            }
            Console.WriteLine("Результат обчислення за другою формулою: {0:0.00} ", result);


        }
        public static void Method3(int n)
        {
            double result = 1;
            int denom = 1;
            for (int i = 2; i <= n; i++)
            {
                denom *= 2;
                if (i % 2 != 0)
                {
                    result -= 1.0 / denom;
                }
                else { result += 1.0 / denom; }
                denom *= 2;
            }
            Console.WriteLine("Результат обчислення за третьою формулою: {0:0.00} ", result);
        }
        public static int Factorial(int a)
        {
            int result = 1;
            for (int i = 1; i <= a; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
