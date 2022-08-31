using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class CarFactory : VehicleFactory
    {
        public override Engine CreateEngine(string manufacturer, string volume, string horsePower)
        {
            return new CarEngine(manufacturer, volume, horsePower);
        }

        public override Vehicle CreateVehicle(string manufacturer, Engine engine, Wheels wheels)
        {
            return new Car(manufacturer, engine, wheels);
        }

        public override Wheels CreateWheels(string radius, string treadWidth, string treadHeight, string brand)
        {
            return new CarWheels(radius, treadWidth, treadHeight, brand);
        }
    }
}
