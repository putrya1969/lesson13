using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Vehicle
    {
        public string Manufacturer { get; set; }
        public Engine Engine{ get; set; }
        public Wheels Wheels { get; set; }

        public Vehicle(string manufacturer, Engine engine, Wheels wheels)
        {
            Manufacturer = manufacturer;
            Engine = engine;
            Wheels = wheels;
        }

        public override string ToString()
        {
            return $"Type vehicle: {this.GetType()}\nManufacture: {Manufacturer}\n{Engine.ToString()}\n{Wheels.ToString()}\n";
        }
    }
}
