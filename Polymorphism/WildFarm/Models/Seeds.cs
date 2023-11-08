using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public class Seeds : Food, IFood
    {
        public Seeds(int quantity) : base(quantity)
        {
        }
    }
}
