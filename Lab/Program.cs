using System;

public class Program
{
    static void Main()
    {
        CarPark carPark = new CarPark();

        int cars = int.Parse(Console.ReadLine());

        for (int i = 0; i < cars; i++)
        {
            carPark.AddCar(new Car(Console.ReadLine()));
        }
        string track;
        while ((track = Console.ReadLine())!= "End")
        {
            carPark.Drive(track);
        }

        carPark.PrintCas();

    }
}


