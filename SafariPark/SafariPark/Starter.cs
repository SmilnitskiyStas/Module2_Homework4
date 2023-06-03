using SafariPark.Models;

namespace SafariPark
{
    internal class Starter
    {
        public Starter()
        {
        }

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
                    return;
                }
            }
        }

        private void ShowInformations(Animal[] animals)
        {
            if (animals != null)
            {
                for (int y = 0; y < animals.Length; y++)
                {
                    Console.WriteLine($"Name: {animals[y].Name}, Groups of animals - {animals[y].SeparationOfAnimals}");
                }
            }
            else
            {
                return;
            }
        }
    }
}
