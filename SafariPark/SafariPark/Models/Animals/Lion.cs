using SafariPark.Models;

namespace SafariPark.Models.Animals
{
    internal class Lion : Mammals
    {
        public Lion(string name, string separationOfAnimals, string color, int age)
            : base(name, separationOfAnimals, color, age)
        {
        }
    }
}
