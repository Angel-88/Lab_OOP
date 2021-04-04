using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpWasher
{
     public class Car
    {
        public string name { get; set; }
        public bool station { get; set; }
        public Car()
        {

            this.name = name;
            this.station = false;
        }

        internal void Add(Car car) => throw new NotImplementedException();
        internal bool Contsins(Car car) => throw new NotImplementedException();
        internal bool Remove(Car car) => throw new NotImplementedException();
    }
}
