using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class LorryWheels : Wheels
    {
        public string Brand { get; set; }
        public LorryWheels(string radius, string treadWidth, string treadHeight, string brand) : base(radius, treadWidth, treadHeight)
        {
            Brand = brand;
        }

        public override string ToString()
        {
            return $"Wheels:\n{Brand} - lorry's wheels\n{base.ToString()}" ;
        }
    }
}
