namespace Vehicles.Models.Interfaces;

public interface IVehicle
{
    double FuelQuantity { get; }

    double FuelConsumption { get; }

    string Drive(double distance, string command, bool isIncreasedConsumtion = true);

    void Refuel(double amount);  
}