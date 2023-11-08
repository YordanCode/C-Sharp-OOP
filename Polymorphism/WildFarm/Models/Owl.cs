
using System;
using System.Collections.Generic;

namespace WildFarm.Models
{
    public class Owl : Bird
    {
        private const double OwlIncreaseWeightMultiplier = 0.25;
        public Owl(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }
        protected override double increaseWeightMultiplier
            => OwlIncreaseWeightMultiplier;
        public override IReadOnlyCollection<Type> PreferredFoods
         => new HashSet<Type>() { typeof(Meat) };
        public override void ProduceSound()
         => Console.WriteLine("Hoot Hoot");
    }
}
