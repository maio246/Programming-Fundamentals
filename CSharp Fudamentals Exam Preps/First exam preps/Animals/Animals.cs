namespace Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Anials;

    public class Animals
    {
        public static void Main(string[] args)
        {
            var cats = new List<Cat>();
            var dogs = new List<Dog>();
            var snakes = new List<Snake>();

            var input = Console.ReadLine();

            while (input != "I'm your Huckleberry")
            {
                var tokens = input.Split().ToArray();

                if (tokens[0] != "talk")
                {
                    AddCurrentAnimalInItsList(tokens, dogs, cats, snakes);
                }
                else
                {
                    HasToTalk(tokens, dogs, cats, snakes);

                }

                input = Console.ReadLine();
            }

            foreach (var dog in dogs)
            {
                Console.WriteLine($"Dog: {dog.Name}, Age: {dog.Age}, Number Of Legs: {dog.Parameter}");
            }
            foreach (var cat in cats)
            {
                Console.WriteLine($"Cat: {cat.Name}, Age: {cat.Age}, IQ: {cat.Parameter}");

            }
            foreach (var snake in snakes)
            {
                Console.WriteLine($"Snake: {snake.Name}, Age: {snake.Age}, Cruelty: {snake.Parameter}");

            }
        }

        private static void HasToTalk(string[] tokens, List<Dog> dogs, List<Cat> cats, List<Snake> snakes)
        {
            var animalName = tokens[1];

            if (dogs.Any(x => x.Name == animalName))
            {
                var animal = new Dog();
                animal = dogs.First(x => x.Name == animalName);
                animal.ProduceSound();
            }
            if (cats.Any(x => x.Name == animalName))
            {
                var animal = new Cat();
                animal = cats.First(x => x.Name == animalName);
                animal.ProduceSound();
            }
            if (snakes.Any(x => x.Name == animalName))
            {
                var animal = new Snake();
                animal = snakes.First(x => x.Name == animalName);
                animal.ProduceSound();
            }
        }

        private static void AddCurrentAnimalInItsList(string[] tokens, List<Dog> dogs, List<Cat> cats, List<Snake> snakes)
        {

            var clas = tokens[0];
            var name = tokens[1];
            var age = int.Parse(tokens[2]);
            var parameter = int.Parse(tokens[3]);

            switch (clas)
            {
                case "Dog":
                    var currentDog = new Dog()
                    {
                        Name = name,
                        Age = age,
                        Parameter = parameter
                    };
                    if (!dogs.Contains(currentDog))
                    {
                        dogs.Add(currentDog);
                    }
                    break;
                case "Cat":
                    var currentCat = new Cat()
                    {
                        Name = name,
                        Age = age,
                        Parameter = parameter
                    };
                    if (!cats.Contains(currentCat))
                    {
                        cats.Add(currentCat);
                    }
                    break;
                case "Snake":
                    var currentSnake = new Snake()
                    {
                        Name = name,
                        Age = age,
                        Parameter = parameter
                    };
                    if (!snakes.Contains(currentSnake))
                    {
                        snakes.Add(currentSnake);
                    }
                    break;
            }
        }
    }
}
