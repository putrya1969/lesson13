using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class CarEngine : Engine
    {
        const string typeEngine = "car engine";

        public CarEngine(string brand, string volume, string horsePower) : base(brand, volume, horsePower)
        {
        }

        //public string PetrolType { get; set; }
        public override string ToString()
        {
            return $"Type of engine: {typeEngine}\n{base.ToString()}\n{new string('-', 20)}";
        }
    }
}
