using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class AutoService
    {
        static public Random Random { get; set; } = new Random(DateTime.Now.Millisecond);
        public List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
        public AutoService(int countVehicles)
        {
            for (int i = 0; i < countVehicles; i++)
            {
                Vehicles.Add(VehiclesGenerator.Generate(GetFactory(), Random));
            }
        }

        private VehicleFactory GetFactory()
        {
            int select = Random.Next(0, 2);
            VehicleFactory factory = null;
            switch (select)
            {
                case 0:
                    factory = new CarFactory();
                    break;
                case 1:
                    factory = new LorryFactory();
                    break;
            }
            return factory;
        }
    }
}
