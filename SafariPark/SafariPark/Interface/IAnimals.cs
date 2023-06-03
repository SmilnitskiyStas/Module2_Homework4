using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark.Interface
{
    internal interface IAnimals
    {
        string Name { get; }

        string SeparationOfAnimals { get; }

        string Color { get; }

        int Age { get; }
    }
}
