
using System;
using System.Collections.Generic;

namespace WildFarm.Models
{
    public class Cat : Feline
    {
        private const double CatIncreaseWeightMultiplier = 0.30;

        public Cat(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
        }
        protected override double increaseWeightMultiplier
            => CatIncreaseWeightMultiplier;
        public override IReadOnlyCollection<Type> PreferredFoods
         => new HashSet<Type>() { typeof(Vegetable), typeof(Meat) };
        public override void ProduceSound()
         => Console.WriteLine("Meow");
    }
}
