
using System;
using System.Collections.Generic;

namespace WildFarm.Models
{
    public class Hen : Bird
    {
        private const double HenIncreaseWeightMultiplier = 0.35;
        public Hen(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }
        protected override double increaseWeightMultiplier
            => HenIncreaseWeightMultiplier;
        public override IReadOnlyCollection<Type> PreferredFoods
          => new HashSet<Type>() { typeof(Vegetable), typeof(Meat)
            , typeof(Seeds), typeof(Fruit) };
        public override void ProduceSound()
          => Console.WriteLine("Cluck");
    }
}
