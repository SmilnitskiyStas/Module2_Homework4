using SafariPark.Enum;
using SafariPark.Models;

namespace SafariPark
{
    internal class Starter
    {
        public void Run()
        {
            GenerationAnimal();
        }

        /// <summary>
        /// Генерація тварин.
        /// </summary>
        private void GenerationAnimal()
        {
            GenerationAnimal animal = new GenerationAnimal();

            Animal[][] animals = animal.GenericAnimal();

            SortAnimal(animals);

            ShowInformationsByCriterios(animals);
        }

        /// <summary>
        /// Сортування тварин.
        /// </summary>
        /// <param name="animals">Зубчастий масив.</param>
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

        /// <summary>
        /// Вивід інформації по критеріям.
        /// </summary>
        /// <param name="animals">Зубчастий масив.</param>
        private void ShowInformationsByCriterios(Animal[][] animals)
        {
            Console.WriteLine("Do you want find animal by criterios?\n1. Yes\n2. No");
            int choiceByCriterios = int.Parse(Console.ReadLine()) - 1;

            switch (choiceByCriterios)
            {
                case 0:
                    Console.WriteLine("Input some parameters for find animals\n");

                    Console.WriteLine("Input sections for searching:\n1. Reptils\n2. Bird\n3. Mammals");
                    int inputSections = int.Parse(Console.ReadLine());

                    string sections = ((EnumSeparationAnimal)inputSections).ToString();

                    Console.WriteLine("Input color for searching:");
                    string color = Console.ReadLine();

                    Animal animal = new Animal();

                    animal.SearchForAnimalsByCriteria(animals, sections, color);

                    break;
                case 1:
                    Console.WriteLine("Goodbuy!");
                    break;
            }
        }

        /// <summary>
        /// Вивідимо всіх тварин на консоль.
        /// </summary>
        /// <param name="animals">Одномірний масив.</param>
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

        /// <summary>
        /// Показ кількості тварин в секції.
        /// </summary>
        /// <param name="animals">Масив строк імені тварин.</param>
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
