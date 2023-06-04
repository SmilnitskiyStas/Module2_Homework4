using SafariPark.Animals;
using SafariPark.Enum;
using SafariPark.Interface;

namespace SafariPark.Models
{
    internal class GenerationAnimal
    {
        public Animal[][] Animals { get; set; }

        public GenerationAnimal()
        {
            Animals = new Animal[3][];
        }

        public Animal[][] GenericAnimal()
        {
            bool isWorking = true;

            Random random = new Random();

            Animal[] animals;

            while (isWorking)
            {
                Console.WriteLine("Who you want to buy\n1. Reptiles\n2. Bird\n3. Mammals");

                int choice = int.Parse(Console.ReadLine()) - 1;

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("How you want to buy Reptiles:");
                        int createReptiles = int.Parse(Console.ReadLine());

                        animals = new Animal[createReptiles];

                        for (int i = 0; i < createReptiles; i++)
                        {
                            int age = random.Next(1, 8);

                            animals[i] = CreateReptiles(age);
                        }

                        Animals[0] = animals;

                        break;
                    case 1:
                        Console.WriteLine("How you want to buy Bird:");
                        int createBird = int.Parse(Console.ReadLine());

                        animals = new Animal[createBird];

                        for (int i = 0; i < createBird; i++)
                        {
                            int age = random.Next(1, 13);

                            animals[i] = CreateBird(age);
                        }

                        Animals[1] = animals;

                        break;
                    case 2:
                        Console.WriteLine("How you want to buy Mammals");
                        int createMammals = int.Parse(Console.ReadLine());

                        animals = new Animal[createMammals];

                        for (int i = 0; i < createMammals; i++)
                        {
                            int age = random.Next(1, 19);

                            animals[i] = CreateMammals(age);
                        }

                        Animals[2] = animals;

                        break;
                }

                isWorking = IsWorking();
            }

            return Animals;
        }

        private bool IsWorking()
        {
            Console.WriteLine("Do you want to buy more?\n1. Yes\n2. No");
            int workingChoice = int.Parse(Console.ReadLine());

            if (workingChoice == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void CreateFish()
        {
        }

        private Animal CreateReptiles(int age)
        {
            Random random = new Random();

            Reptile reptile = new Reptile();

            int choice = random.Next(0, 3);

            string animal = ((EnumReptiles)choice).ToString();

            string separationReptile = ((EnumSeparationAnimal)1).ToString();

            switch (choice)
            {
                case 0:
                    reptile = new Crocodile(animal, separationReptile, "Green", age);
                    break;
                case 1:
                    reptile = new Lizard(animal, separationReptile, "Dark Green", age);
                    break;
                case 2:
                    reptile = new Snake(animal, separationReptile, "Green", age);
                    break;
            }

            return reptile;
        }

        private Animal CreateBird(int age)
        {
            Random random = new Random();

            Bird bird = new Bird();

            int choice = random.Next(0, 1);

            string animal = ((EnumBird)choice).ToString();

            string separationBird = ((EnumSeparationAnimal)2).ToString();

            switch (choice)
            {
                case 0:
                    bird = new Parrot(animal, separationBird, "Colorful", age);
                    break;
            }

            return bird;
        }

        private Animal CreateMammals(int age)
        {
            Random random = new Random();

            Mammals mammals = new Mammals();

            int choice = random.Next(0, 6);

            string animal = ((EnumMammals)choice).ToString();

            string separationMammals = ((EnumSeparationAnimal)3).ToString();

            switch (choice)
            {
                case 0:
                    mammals = new Buffalo(animal, separationMammals, "Brown", age);
                    break;
                case 1:
                    mammals = new Camel(animal, separationMammals, "Orange", age);
                    break;
                case 2:
                    mammals = new Fox(animal, separationMammals, "Orange", age);
                    break;
                case 3:
                    mammals = new Lion(animal, separationMammals, "Orange", age);
                    break;
                case 4:
                    mammals = new Wolf(animal, separationMammals, "Gray", age);
                    break;
                case 5:
                    mammals = new Zebra(animal, separationMammals, "Black and White", age);
                    break;
            }

            return mammals;
        }
    }
}
