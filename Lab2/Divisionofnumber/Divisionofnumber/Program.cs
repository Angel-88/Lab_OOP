using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisionofnumber
{
    
        public delegate void Division(int[,] array);
        class Program
        {
            static void Main(string[] args)
            {
                int[,] array = { { 1, 10, 9, 14 }, { 19, 21, 90, 40 }, { 49, 70, 47, 33 }, { 89, 36, 33, 88 } };
                Console.WriteLine("Масив чисел: ");
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                Division div3 = new Division(Division_on_three);
                Division div7 = new Division(Division_on_seven);
                Division division = div3 + div7;
                division(array);
            Console.ReadKey();

            }
            public static void Division_on_three(int[,] array)
            {
                Console.WriteLine("Числа, що діляться на 3: ");
                foreach (int c in array)
                {
                    if (c % 3 == 0)
                    {
                        Console.Write(c + "  ");
                    }
                }
                Console.WriteLine();
            }
            public static void Division_on_seven(int[,] array)
            {
                Console.WriteLine("Числа, що діляться на 7: ");
                foreach (int c in array)
                {
                    if (c % 7 == 0)
                    {
                        Console.Write(c + "  ");
                    }
                }
                Console.WriteLine();
            }

        }
    
}
