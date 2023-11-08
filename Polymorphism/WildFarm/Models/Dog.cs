
using System;
using System.Collections.Generic;

namespace WildFarm.Models
{
    public class Dog : Mammal
    {
        private const double DogIncreaseWeightMultiplier = 0.40;
        public Dog(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {
        }

        protected override double increaseWeightMultiplier
            => DogIncreaseWeightMultiplier;
        public override IReadOnlyCollection<Type> PreferredFoods
          => new HashSet<Type>() { typeof(Meat) };
        public override void ProduceSound()
          => Console.WriteLine("Woof!");
        public override string ToString()
    => base.ToString() + $"{Weight}, {LivingRegion}, {FoodEaten}]";
    }
}
