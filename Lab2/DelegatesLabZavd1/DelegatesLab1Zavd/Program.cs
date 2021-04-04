using System;

namespace DelegatesLab1Zavd
{
	class Program
	{
        private delegate double Operation(double x);

        private static Operation[] Operations =
        {
            DoSqrtWithNumber,
            SetNumberToThirdDegree,
            AddNumberToGivenNumber
        };

        public static void Main(string[] args)
        {
            Console.WriteLine(
                "Вводьте рядки послiдовно один за одним." +
                "\nПоки вони матимуть вигляд 0 X чи 1 X чи 2 X" +
                "\n(тобто, цифра вiд 0 до 2, а пiсля неї запис конкретного дiйсного числа)," +
                "\nпрограма обчислюватиме одну з трьох функцiй" +
                "\n        0 -- sqrt(abs(x))" +
                "\n        1 -- x^3 (iнакше кажучи, x*x*x)" +
                "\n        2 -- x + 3.5" +
                "\n(згiдно цифри на початку) i виводитиме результат." +
                "\n" +
                "\nЯкщо вхiдний рядок не задовольнятиме цей формат, програма завершить роботу." +
                "\n"
            );

            try
            {
                while (true)
                {
                    string[] Input = Console.ReadLine().Split(' ');
                    int MathOperationNumber = Int32.Parse(Input[0]);
                    double X = Double.Parse(Input[1]);

                    Console.WriteLine(Operations[MathOperationNumber](X));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(
                    "Сталася помилка " + e.Message +
                    "\nНатиснiть будь-яку клавiшу для остаточного виходу"
                );
                Console.ReadKey();
            }
        }

        private static double DoSqrtWithNumber(double x)
        {
            return Math.Sqrt(Math.Abs(x));
        }

        private static double SetNumberToThirdDegree(double x)
        {
            return Math.Pow(x, 3);
        }

        private static double AddNumberToGivenNumber(double x)
        {
            return x + 3.5;
        }
    }
}
