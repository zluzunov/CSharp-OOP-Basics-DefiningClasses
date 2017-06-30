using System;
using System.Collections.Generic;

public class Car
{
    public static HashSet<string> Models;

    public Car(string userInput)
    {
        string[] carData = userInput.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

        this.Model = carData[0];
        this.Fuel = decimal.Parse(carData[1]);
        this.Consumption = decimal.Parse(carData[2]);
        this.Distance = 0;
    }

    public string Model { get; set; }

    public decimal Fuel { get; set; }

    public decimal Consumption { get; set; }

    public decimal Distance { get; set; }


    public void Print()
    {
        Console.WriteLine($"{Model} {Fuel:f2} {Distance}");
    }
}
