using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark.Models
{
    internal class Reptile : Animal
    {
        public Reptile()
        {
        }

        public Reptile(string name, string separationOfAnimals, string color, int age)
            : base(name, separationOfAnimals, color, age)
        {
        }
    }
}
