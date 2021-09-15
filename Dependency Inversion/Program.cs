using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Motocycle motocycle = new Motocycle()
            {
                Id = 5,
                Brand = "Honda",
                Model = "CBR"
            };

            Tractor tractor = new Tractor()
            {
                Id = 5,
                Brand = "Honda",
                Model = "CBR"
            };

            var vehicle1 = new ProductManager(motocycle);
            var vehicle2 = new ProductManager(tractor);

            vehicle1.Create();
            vehicle2.Create();

            Console.ReadLine(); // Finish
        }
    }
}
