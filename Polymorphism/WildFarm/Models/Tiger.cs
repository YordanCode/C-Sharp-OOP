
using System;
using System.Collections.Generic;

namespace WildFarm.Models
{
    public class Tiger : Feline
    {
        private const double TigerIncreaseWeightMultiplier = 1.0;

        public Tiger(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
        }
        protected override double increaseWeightMultiplier
         => TigerIncreaseWeightMultiplier;
        public override IReadOnlyCollection<Type> PreferredFoods
         => new HashSet<Type>() { typeof(Meat) };
        public override void ProduceSound()
         => Console.WriteLine("ROAR!!!");
    }
}
