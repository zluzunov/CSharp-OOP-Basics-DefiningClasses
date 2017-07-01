namespace Homework01
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Cars;

    public class Program
    {
        static void Main()
        {
            int enginesCount = int.Parse(Console.ReadLine());

            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            for (int i = 0; i < enginesCount; i++)
            {
                var engine = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string model = engine[0];
                int power = int.Parse(engine[1]);
                string efficiency;
                double displacement;
                if (engine.Length == 4)
                {
                    efficiency = engine[3];
                    displacement = double.Parse(engine[2]);
                    engines.Add(new Engine(model, displacement, power, efficiency));
                }
                else if (engine.Length == 3)
                {
                    if (double.TryParse(engine[2], out displacement))
                    {
                        engines.Add(new Engine(model, displacement, power));
                    }
                    else
                    {
                        efficiency = engine[2];
                        engines.Add(new Engine(model, power, efficiency));
                    }
                }
                else
                {
                    engines.Add(new Engine(model, power));
                }
            }

            int carsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < carsCount; i++)
            {
                string[] carData = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string model = carData[0];
                Engine engine = engines.FirstOrDefault(e => e.Model == carData[1]);
                string color;
                double weight;
                if (carData.Length == 4)
                {
                    color = carData[3];
                    weight = double.Parse(carData[2]);
                    cars.Add(new Car(model,engine,weight,color));
                }
                else if (carData.Length == 3)
                {
                    if (double.TryParse(carData[2], out weight))
                    {
                        cars.Add(new Car(model, engine, weight));
                    }
                    else
                    {
                        color = carData[2];
                        cars.Add(new Car(model, engine, color));
                    }
                }
                else
                {
                    cars.Add(new Car(model, engine));
                }
            }

            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }

}




