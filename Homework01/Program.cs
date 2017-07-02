namespace Homework01
{
    using System;
    using Rectangles;

    public class Program
    {
        static void Main()
        {
            string shapeName = Console.ReadLine();

            if (shapeName == "Square")
            {
                int side = int.Parse(Console.ReadLine());
                Square shape = new Square(side);
                shape.Draw();
            }
            else
            {
                int width = int.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                Rectangle shape = new Rectangle("",width,height,0,0);

                shape.Draw();
            }
        }
    }

}