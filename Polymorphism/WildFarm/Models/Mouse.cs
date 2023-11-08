
using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace WildFarm.Models
{
    public class Mouse : Mammal
    {
        private const double MouseIncreaseWeightMultiplier = 0.10;

        public Mouse(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {
        }

        protected override double increaseWeightMultiplier
            => MouseIncreaseWeightMultiplier;
        public override IReadOnlyCollection<Type> PreferredFoods
         => new HashSet<Type>() { typeof(Vegetable), typeof(Fruit) };
        public override void ProduceSound()
          => Console.WriteLine("Squeak");
        public override string ToString()
           => base.ToString() + $"{Weight}, {LivingRegion}, {FoodEaten}]";
    }
}
