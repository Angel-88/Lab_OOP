using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpWasher
{
    

    class Program
    {
        delegate void CarWash(Car car);

        static void Main(string[] args)
        {
           
            Garage garage = new Garage();
            foreach (var car in garage)
            {
                CarWash wash = Washer.Wash;
                wash(car);
                Console.WriteLine("Car " + car.name + " is " + car.station);
            }
            Console.ReadKey();
        }

    
    }

    
}
