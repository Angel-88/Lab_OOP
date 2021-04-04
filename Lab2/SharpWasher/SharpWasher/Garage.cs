using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpWasher
{
    public class Garage : ICollection<Car>
    {
        ICollection<Car> car;
        public Garage()
        {
            car = new List<Car>();
            {
                car.Add(new Car() { name = "BMW" });
                car.Add(new Car() { name = "Audi" });
                car.Add(new Car() { name = "Mersedes" });
                car.Add(new Car() { name = "Porshe" });
                car.Add(new Car() { name = "Toyota" });
                car.Add(new Car() { name = "Volvo" });
                car.Add(new Car() { name = "Range Rover" });
            }
        }

        public int Count => car.Count;

        public bool IsReadOnly => car.IsReadOnly;

        public void Add(Car car) => car.Add(car);

        public void Clear() => car.Clear();

        public bool Contains(Car car) => car.Contsins(car);

        public void CopyTo(Car[] array, int arrayIndex) => car.CopyTo(array, arrayIndex);

        public IEnumerator<Car> GetEnumerator() => car.GetEnumerator();

        public bool Remove(Car car) => car.Remove(car);

        IEnumerator IEnumerable.GetEnumerator() => car.GetEnumerator();
    }
}
