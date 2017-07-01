using System.Collections.Generic;
using Homework01.Cars;

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
}
