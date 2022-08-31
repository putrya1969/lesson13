using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Car : Vehicle
    {
        public Car(string manufacturer, Engine engine, Wheels wheels) : base(manufacturer, engine, wheels)
        {
        }
    }
}
