
using System;
using System.Collections.Generic;
using System.Linq;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public abstract class Animal : IAnimal
    {
        protected Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        public string Name { get; private set; }
        public double Weight { get; private set; }
        public int FoodEaten { get; private set; }

        protected abstract double increaseWeightMultiplier { get; }
        public abstract IReadOnlyCollection<Type> PreferredFoods { get; }
        public abstract void ProduceSound();
        public void Eat(IFood food)
        {
            if (!PreferredFoods.Any(pf => food.GetType().Name == pf.Name))
            {
                throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
            Weight += food.Quantity * increaseWeightMultiplier;
            FoodEaten += food.Quantity;
        }

        public override string ToString()
           => ($"{GetType().Name} [{Name}, ");

    }
}
