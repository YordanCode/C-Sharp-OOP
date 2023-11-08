

using System;
using System.Collections.Generic;
using WildFarm.Models.Interfaces;
using WildFarm.Factories.Interfaces;
using WildFarm.Factories;

namespace WildFarm.Core
{
    public class Engine : IEngine
    {
        private IAnimalFactory animalFactory;
        private IFoodFactory foodFactory;
        private readonly ICollection<IAnimal> animals;

        public Engine(IAnimalFactory animalFactory, IFoodFactory foodFactory)
        {
            this.animalFactory = animalFactory;
            this.foodFactory = foodFactory;
            this.animals = new List<IAnimal>();
        }
        public void Run()
        {
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                IAnimal animal = null;
                try
                {
                    animal = CreateAnimal(command);
                    IFood food = CreateFood();
                    animal.ProduceSound();
                    animal.Eat(food);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception)
                {
                    throw;
                }
                animals.Add(animal);
            }
            foreach (IAnimal animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }
        private IAnimal CreateAnimal(string command)
        {
            string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            IAnimal animal = animalFactory.CreateAnimal(tokens);
            return animal;
        }

        private IFood CreateFood()
        {
            string[] foodTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string foodType = foodTokens[0];
            int quantity = int.Parse(foodTokens[1]);
            IFood food = foodFactory.CreateFood(foodType, quantity);
            return food;
        }
    }
}
