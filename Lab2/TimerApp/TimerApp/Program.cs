using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimerApp
{
    delegate void Methods();
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.Write("Введіть кількість секунд: ");
            int seconds = int.Parse(Console.ReadLine());
            Timer timer = new Timer(seconds);
            timer.Start();
        }
    }
}
