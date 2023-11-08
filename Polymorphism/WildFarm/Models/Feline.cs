
using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public abstract class Feline : Mammal, IFelini
    {
        protected Feline(string name, double weight, string livingRegion, string breed)
            :base (name, weight, livingRegion)
        {
            Breed = breed;
        }

        public string Breed { get; private set; }

        public override string ToString()
         => base.ToString() + $"{Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
    }
}
