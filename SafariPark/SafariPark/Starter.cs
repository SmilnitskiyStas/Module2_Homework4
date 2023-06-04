using SafariPark.Models;

namespace SafariPark
{
    internal class Starter
    {
        public void Run()
        {
            GenerationAnimal();
        }

        private void GenerationAnimal()
        {
            GenerationAnimal animal = new GenerationAnimal();

            Animal[][] animals = animal.GenericAnimal();

            SortAnimal(animals);
        }

        private void SortAnimal(Animal[][] animals)
        {
            for (int i = 0; i < animals.Length; i++)
            {
                if (animals[i] != null)
                {
                    Console.WriteLine($"\nYou show '{animals[i][0].SeparationOfAnimals.ToUpper()}'\n");

                    Array.Sort(animals[i]);

                    ShowInformations(animals[i]);
                }
                else
                {
                    continue;
                }
            }
        }

        private void ShowInformations(Animal[] animals)
        {
            string[] name = new string[animals.Length];

            if (animals != null)
            {
                for (int y = 0; y < animals.Length; y++)
                {
                    Console.WriteLine($"Name: {animals[y].Name}, Groups of animals - {animals[y].SeparationOfAnimals}");

                    name[y] = animals[y].Name;
                }

                Console.WriteLine("\n=======================");

                ShowCountAnimalsInTheSections(name);

                Console.WriteLine("=======================");
            }
            else
            {
                return;
            }
        }

        private void ShowCountAnimalsInTheSections(string[] animals)
        {
            string[] s = animals.Distinct().ToArray();

            for (int y = 0; y < s.Length; y++)
            {
                string[] count = Array.FindAll(animals, n => n == s[y]);

                Console.WriteLine($"Name - {s[y]}, Count - {count.Length}");
            }
        }
    }
}
