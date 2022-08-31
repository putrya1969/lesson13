using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class LorryEngine : Engine
    {
        const string typeEngine = "lorry engine";

        public LorryEngine(string brand, string volume, string horsePower) : base(brand, volume, horsePower)
        {
        }

        public override string ToString()
        {
            return $"Type of engine: {typeEngine}\n{base.ToString()}\n{new string('-', 20)}";
        }
    }
}
