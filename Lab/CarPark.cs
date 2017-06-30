using System;
using System.Collections.Generic;
using System.Linq;

public class CarPark
{
    public Queue<Car> Cars { get; set; }

    public CarPark()
    {
        Cars = new Queue<Car>();
    }

    public void AddCar(Car car)
    {
        Cars.Enqueue(car);
    }

    public void PrintCars()
    {
        foreach (Car car in Cars)
        {
            car.Print();
        }
    }

    public void PrintCars(string command)
    {
        Car[] printCollection;

        if (command == "fragile")
        {
            printCollection = Cars
                .Where(c => c.Cargo.Type == command)
                .Where(c => c.Tires.Count(t => t.Pressure < 1) > 0)
                .ToArray();
        }
        else if (command == "flamable")
        {
            printCollection = Cars
                .Where(c => c.Cargo.Type == command)
                .Where(c => c.Engine.Power > 250)
                .ToArray();
        }
        else
        {
            printCollection = new Car[]{};
        }

        foreach (Car car in printCollection)
        {
            Console.WriteLine(car.Model);
        }
    }
}
