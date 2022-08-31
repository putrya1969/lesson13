using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class CarWheels : Wheels
    {
        public string Brand { get; set; }
        public CarWheels(string radius, string treadWidth, string treadHeight, string brand) : base(radius, treadWidth, treadHeight)
        {
            Brand = brand;
        }
        public override string ToString()
        {
            return $"Wheels:\n{Brand} - car's wheels\n{base.ToString()}";
        }
    }
}
