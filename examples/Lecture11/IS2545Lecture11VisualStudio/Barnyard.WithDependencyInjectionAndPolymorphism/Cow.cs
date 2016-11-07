﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barnyard.WithDependencyInjectionAndPolymorphism
{
    public class Cow : IAnimal
    {
        public string Vocalize()
        {
            return "Mooo!";
        }
    }
}
