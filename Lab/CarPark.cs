using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class CarPark
{
    private Dictionary<string, Car> Cars { get; set; }

    public CarPark()
    {
        Cars = new Dictionary<string, Car>();
    }

    public void AddCar(Car car)
    {
        if (!Cars.Keys.Contains(car.Model))
        {
            Cars[car.Model] = car;
        }
        else
        {
            throw new ArgumentException("Such model already exists!");
        }
    }

    public void PrintCas()
    {
        foreach (Car car in Cars.Values)
        {
            car.Print();
        }
    }

    private void Drive(string carModel, decimal kilometers)
    {
        if (Cars.Keys.Contains(carModel))
        {
            Car car = Cars[carModel];
            decimal fuelNeeded = car.Consumption * kilometers;

            if (fuelNeeded <= car.Fuel)
            {
                car.Fuel -= fuelNeeded;
                car.Distance += kilometers;
                Cars[car.Model] = car;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            
        }
        else
        {
            throw new ArgumentException("No such model in the car park!");
        }
    }

    public void Drive(string userInput)
    {
        string[] distanceData = userInput.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        Drive(distanceData[1], decimal.Parse(distanceData[2]));
    }
}
