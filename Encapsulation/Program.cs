using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static string[] TireBrands = new string []{ "BFGOODRICH", "Bridgestone","Continental","Dunlop Tires","Firestone","General Tire","Goodyear","Hankook","Michelin","Pirelli","Toyo Tires","Uniroyal","Yokohama"};
        static string[] TireWidth = new string[] { "155", "160", "165", "170", "175", "180", "185", "190", "195", "200", "205", "210", "215" };
        static string[] TireHeight = new string[] { "55", "60", "65", "70", "75", "80", "85", "90"};
        static string[] TireRadius = new string[] { "13", "14", "15", "16", "17", "18", "19", "20" };
        static Random random = new Random(DateTime.Now.Millisecond);
        static void Main(string[] args)
        {
            List<Wheels> wheels = new List<Wheels>();
            for (int i = 0; i < 50; i++)
            {
                wheels.Add(CreateWheels(random.Next(0, 2)));
            }
            foreach (var item in wheels)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadKey();
        }

        static Wheels CreateWheels(int typeOfEngine)
        {
            Wheels createdWheels = null;
            switch (typeOfEngine)
            {
                case 0:
                    createdWheels = new CastWheels(GetString(TireRadius), GetString(TireWidth), GetString(TireHeight), GetString(TireBrands));
                    break;
                case 1:
                    createdWheels = new StampedWheels(GetString(TireRadius), GetString(TireWidth), GetString(TireHeight), GetString(TireBrands));
                    break;
            }
            return createdWheels;
        }

        static string GetString(string[] sourceArray)
        {
            return sourceArray[random.Next(0, sourceArray.Length)];
        }
    }

    class Engine
    {
        public string Brand { get; set; }
        public int Volume { get; set; }
        public int HorsePower { get; set; }
        public override string ToString()
        {
            return $"Engine: {Brand} {Volume}-hp{HorsePower}";
        }
    }

    class DieselEngine : Engine
    {
        public string Seria { get; set; }
        public override string ToString()
        {
            return base.ToString() + $"\n{Seria} series";
        }
    }

    class PetroleEngine : Engine
    {
        public string PetrolType { get; set; }
        public override string ToString()
        {
            return base.ToString() + $"\n{PetrolType} petrol";
        }
    }

    class Wheels
    {
        public string Radius { get; set; }
        public string TreadWidth { get; set; }
        public string TreadHeight { get; set; }
        public Wheels(string radius, string treadWidth, string treadHeight)
        {
            Radius = radius;
            TreadWidth = treadWidth;
            TreadHeight = treadHeight;
        }
        public override string ToString()
        {
            return $"Wheel size: {TreadWidth}/{TreadHeight}R{Radius}";
        }
    }

    class CastWheels : Wheels
    {
        public string Brand { get; set; }
        public CastWheels(string radius, string treadWidth, string treadHeight, string brand): base(radius, treadWidth, treadHeight)
        {
            Brand = brand;
        }
        public override string ToString()
        {
            return base.ToString() + $"\n{Brand} - CastWheel\n"+ new string('*', 10);
        }
    }

    class StampedWheels : Wheels
    {
        public string Brand { get; set; }
        public StampedWheels(string radius, string treadWidth, string treadHeight, string brand) : base(radius, treadWidth, treadHeight)
        {
            Brand = brand;
        }
        public override string ToString()
        {
            return base.ToString() + $"\n{Brand} - Steel\n" + new string('*', 10);
        }
    }
}
