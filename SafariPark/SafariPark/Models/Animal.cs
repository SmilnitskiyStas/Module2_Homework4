using SafariPark.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark.Models
{

    internal abstract class Animal : IAnimals
    {
        public string Name { get; set; }

        public string SeparationOfAnimals { get; set; }

        public string Color { get; set; }

        protected Animal(string name, string separationOfAnimals, string color)
        {
            Name = name;
            SeparationOfAnimals = separationOfAnimals;
            Color = color;
        }
    }
}
