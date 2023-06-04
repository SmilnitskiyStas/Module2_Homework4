using SafariPark.Interface;

namespace SafariPark.Models
{
    internal class Animal : IAnimals, IComparable
    {
        public string Name { get; set; }

        public string SeparationOfAnimals { get; set; }

        public string Color { get; set; }

        public int Age { get; set; }

        public Animal()
        {
        }

        protected Animal(string name, string separationOfAnimals, string color, int age)
        {
            Name = name;
            SeparationOfAnimals = separationOfAnimals;
            Color = color;
            Age = age;
        }

        public int CompareTo(object? obj)
        {
            if (obj is Animal animal)
            {
                return Name.CompareTo(animal.Name);
            }
            else
            {
                throw new ArgumentException("Не правильний об'єкт");
            }
        }
    }
}
