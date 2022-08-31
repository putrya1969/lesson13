using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Engine
    {
        public string Brand { get; set; }
        public string Volume { get; set; }
        public string HorsePower { get; set; }
        public Engine(string brand, string volume, string horsePower)
        {
            Brand = brand;
            Volume = volume;
            HorsePower = horsePower;
        }
        public override string ToString()
        {
            return $"Engine: {Brand} Vol: {Volume} - {HorsePower}Hp";
        }
    }
}
