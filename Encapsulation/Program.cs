using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {

        static Random random = new Random(DateTime.Now.Millisecond);
        static void Main(string[] args)
        {
            var autoService = new AutoService(10);
            foreach (var item in autoService.Vehicles)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
//checked
