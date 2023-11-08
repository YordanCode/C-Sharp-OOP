using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public class Vegetable : Food, IFood
    {
        public Vegetable(int quantity) : base(quantity)
        {
        }
    }
}
