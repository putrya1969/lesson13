using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    static class VehiclesGenerator
    {
        static string[] TireBrands = new string[] { "BFGOODRICH", "Bridgestone", "Continental", "Dunlop Tires", "Firestone", "General Tire", "Goodyear", "Hankook", "Michelin", "Pirelli", "Toyo Tires", "Uniroyal", "Yokohama" };
        static string[] TireWidth = new string[] { "155", "160", "165", "170", "175", "180", "185", "190", "195", "200", "205", "210", "215" };
        static string[] TireHeight = new string[] { "55", "60", "65", "70", "75", "80", "85", "90" };
        static string[] TireRadius = new string[] { "13", "14", "15", "16", "17", "18", "19", "20" };
        static string[] Manufacturer = new string[] { "Acura", "Alfa-Romeo", "Aston-Martin", "Audi", "Bentley", "BMW", "Bugatti", "Buick", "Cadillac", "Chevrolet", "Chrysler", "Citroen", "DeusAutomobiles", "DeusAutomobilesVayanne", "Dodge", "Ferrari", "Fiat", "Ford", "Geely", "Genesis", "GMC", "Honda", "Hyundai", "Infiniti", "Jaguar", "Jeep", "Kia", "Koenigsegg", "Lamborghini", "Lancia", "LandRover", "Lexus", "Lincoln", "Lotus", "Maserati", "Maybach", "Mazda", "McLaren", "Mercedes", "Mini", "Mitsubishi", "Nissan", "Opel", "Pagani", "Peugeot", "Pontiac", "Porsche", "Ram", "Renault", "Rolls-Royce", "Skoda", "Smart", "Subaru", "Suzuki", "Tesla", "Toyota", "Volkswagen", "Volvo", };
        static string[] HorsePower = new string[] { "50", "55", "60", "65", "70", "75", "80", "85", "90", "100", "150", "250" };
        static string[] Volume = new string[] { "1100", "1300", "1400", "1600", "2000", "2200", "2500", "3000", "3500", "4000", "4500", };
        static public Vehicle Generate(VehicleFactory vehicleFactory, Random random)
        {
            var wheels = vehicleFactory.CreateWheels(GetString(TireRadius, random), GetString(TireWidth, random), GetString(TireHeight, random), GetString(TireBrands, random));
            var brand = GetString(Manufacturer, random);
            var engine = vehicleFactory.CreateEngine(brand, GetString(Volume, random), GetString(HorsePower,random));
            var vehicle = vehicleFactory.CreateVehicle(brand, engine, wheels);
            return vehicle;
        }

        static string GetString(string[] sourceArray, Random random)
        {
            return sourceArray[random.Next(0, sourceArray.Length)];
        }
    }
}
