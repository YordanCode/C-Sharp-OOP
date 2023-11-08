﻿
namespace WildFarm.Models.Interfaces
{
    public interface IAnimal
    {
        string Name { get; }
        double Weight { get; }
        void ProduceSound();
        void Eat(IFood food);
    }
}
