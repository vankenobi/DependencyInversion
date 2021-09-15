﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion
{
    public class Motocycle : IProduction
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }

        public bool Create() 
        {
            Console.WriteLine("Motocycle is created.");
            return true;
        }
    }
}
