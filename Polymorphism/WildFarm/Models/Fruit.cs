﻿using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public class Fruit : Food, IFood
    {
        public Fruit(int quantity) : base(quantity)
        {
        }
    }
}
