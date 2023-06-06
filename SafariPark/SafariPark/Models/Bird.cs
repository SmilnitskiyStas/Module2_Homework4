using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark.Models
{
    internal class Bird : Animal
    {
        public Bird()
        {
        }

        public Bird(string name, string separationOfAnimals, string color, int age)
            : base(name, separationOfAnimals, color, age)
        {
        }
    }
}
