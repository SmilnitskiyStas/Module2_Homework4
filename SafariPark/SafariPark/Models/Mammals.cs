using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark.Models
{
    internal class Mammals : Animal
    {
        public Mammals()
        {
        }

        public Mammals(string name, string separationOfAnimals, string color, int age)
            : base(name, separationOfAnimals, color, age)
        {
        }
    }
}
