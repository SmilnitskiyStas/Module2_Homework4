namespace SafariPark.Models
{
    internal static class AnimalExtension
    {
        public static void SearchForAnimalsByCriteria(this Animal animal, Animal[] animals, string sectionsSearch, string color)
        {
            if (sectionsSearch != null)
            {
                SearchBySections(animals, sectionsSearch);
            }

            if (color != null)
            {
                SearchByColor(animals, color);
            }
        }

        private static void SearchBySections(Animal[] animals, string section)
        {
            for (int i = 0; i < animals.Length; i++)
            {
                if (animals[i].SeparationOfAnimals == section)
                {
                    Console.WriteLine($"Name animal - {animals[i].Name}");
                }
            }
        }

        private static void SearchByColor(Animal[] animals, string color)
        {
            for (int i = 0; i < animals.Length; i++)
            {
                if (animals[i].Color.ToLower() == color.ToLower())
                {
                    Console.WriteLine($"Name animal - {animals[i].Name}");
                }
            }
        }
    }
}
