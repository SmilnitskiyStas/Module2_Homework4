namespace SafariPark.Models
{
    internal static class AnimalExtension
    {
        public static void SearchForAnimalsByCriteria(this Animal animal, Animal[][] animals, string sectionsSearch = null, string color = null)
        {
            Animal[] animalSections = new Animal[1];

            Animal[] animalColor = new Animal[1];

            for (int i = 0; i < animals.Length; i++)
            {
                if (!string.IsNullOrEmpty(sectionsSearch) && animals[i] != null)
                {
                    if (animals[i][0].SeparationOfAnimals == sectionsSearch)
                    {
                        animalSections = SearchBySections(animals[i]);

                        if (!string.IsNullOrEmpty(color))
                        {
                            animalColor = SearchByColor(animals[i], color);
                        }
                    }
                }
            }

            if (animalSections[0] != null && animalColor[0] != null)
            {
                ShowInfo(animalSections, animalColor);
            }
            else
            {
                Console.WriteLine("\n!!!!!!!!!!\nWe don`t find animals by your criterias\n!!!!!!!!!!\n");
            }
        }

        /// <summary>
        /// Отримуємо масив із тваринами підходящі по характеристиці (Секції).
        /// </summary>
        /// <param name="animals">Одномірний масив.</param>
        /// <returns>Одномірний масив із тваринами які підходять по секції.</returns>
        private static Animal[] SearchBySections(Animal[] animals)
        {
            Animal[] addedAnimal = new Animal[animals.Length];

            int count = 0;

            Console.WriteLine();

            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine($"Name animal by sections {animals[i].SeparationOfAnimals} - {animals[i].Name}");

                addedAnimal[count++] = animals[i];
            }

            Array.Resize(ref addedAnimal, count);

            return addedAnimal;
        }

        /// <summary>
        /// Отримуємо масив із тваринами підходящі по характеристиці (Кольору).
        /// </summary>
        /// <param name="animals">Масив тварин.</param>
        /// <param name="color">Колір для пошуку.</param>
        /// <returns>Одномірний масив із тваринами які підходять по кольору.</returns>
        private static Animal[] SearchByColor(Animal[] animals, string color)
        {
            Animal[] addedAnimal = new Animal[animals.Length];

            int count = 0;

            Console.WriteLine();

            for (int i = 0; i < animals.Length; i++)
            {
                if (animals[i].Color.ToLower() == color.ToLower())
                {
                    Console.WriteLine($"Name animal by color {animals[i].Color} - {animals[i].Name}");

                    addedAnimal[count++] = animals[i];
                }
            }

            Array.Resize(ref addedAnimal, count);

            return addedAnimal;
        }

        /// <summary>
        /// Вивід інформації по співпадінню тварин по двума масивами тварин.
        /// </summary>
        /// <param name="animalsSection">Масив тварин із секції.</param>
        /// <param name="animalColor">Масив тварин по кольору.</param>
        private static void ShowInfo(Animal[] animalsSection, Animal[] animalColor)
        {
            for (int i = 0; i < animalsSection.Length; i++)
            {
                for (int y = 0; y < animalColor.Length; y++)
                {
                    if (animalColor[y].Name == animalsSection[i].Name)
                    {
                        Console.WriteLine($"Name animal - {animalsSection[i].Name}, section - {animalsSection[i].SeparationOfAnimals}, color - {animalsSection[i].Color}");
                    }
                }
            }
        }
    }
}
