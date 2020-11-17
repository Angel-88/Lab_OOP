using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter matrix length = ");
            var matrixLength = int.Parse(Console.ReadLine() ?? "1");
            Console.Write("Please enter matrix width = ");
            var matrixWidth = int.Parse(Console.ReadLine() ?? "1");

            var matrix = new Matrix(matrixWidth, matrixLength);
            matrix.FillMatrixByRandomValues();


            Console.WriteLine("Matrix dimensions: length = " + matrix.Length + ", width = " + matrix.Width);
            Console.WriteLine("Matrix with random values:\n" + matrix);

            // matrix[1, 1] = 50;
            // Console.WriteLine("Matrix value at [1, 1]: " + matrix[1, 1]);

            Console.WriteLine("Max matrix value = " + matrix.FindMaxElement());
            Console.WriteLine("Min matrix value = " + matrix.FindMixElement());

            Console.ReadKey();
        }
    }
}
