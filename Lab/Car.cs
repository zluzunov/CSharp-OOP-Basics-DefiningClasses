using System;
using System.Collections.Generic;

public class Car
{
    public Car(string userInput)
    {
        string[] carData = userInput.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        string model = carData[0];
        Engine engine = new Engine(int.Parse(carData[1]),int.Parse(carData[2]));
        Cargo cargo = new Cargo(int.Parse(carData[3]), carData[4]);
        List<Tire> tires = new List<Tire>();

        for (int i = 5; i < carData.Length; i += 2)
        {
            double pressure = double.Parse(carData[i]);
            int age = int.Parse(carData[i+1]);
            
            tires.Add(new Tire(pressure, age));
        }

        this.Model = model;
        this.Engine = engine;
        this.Cargo = cargo;
        this.Tires = tires;
    }

    public Car(
        string model,
        Engine engine,
        Cargo cargo,
        List<Tire> tires
        )
    {
        this.Model = model;
        this.Engine = engine;
        this.Cargo = cargo;
        this.Tires = tires;
    }

    public string Model { get; set; }

    public decimal Fuel { get; set; }

    public decimal Consumption { get; set; }

    public decimal Distance { get; set; }

    public Engine Engine { get; set; }

    public Cargo Cargo { get; set; }

    public List<Tire> Tires { get; set; }



    public void Print()
    {
        Console.WriteLine($"{Model} {Fuel:f2} {Distance}");
    }
}
