using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    abstract class VehicleFactory
    {
        public abstract Vehicle CreateVehicle(string manufacturer, Engine engine, Wheels wheels);
        public abstract Engine CreateEngine(string manufacturer, string volume, string horsePower);
        public abstract Wheels CreateWheels(string radius, string treadWidth, string treadHeight, string brand);
    }
}
