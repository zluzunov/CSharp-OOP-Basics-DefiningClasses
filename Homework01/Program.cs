namespace Homework01
{
    using System;
    using System.Linq;
    using Rectangles;

    public class Program
    {
        static void Main()
        {
            int[] inputs = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < inputs[0]; i++)
            {
                string[] rectangle = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                Rectangle.Collection[rectangle[0]] = new Rectangle(
                    rectangle[0],
                    double.Parse(rectangle[1]),
                    double.Parse(rectangle[2]),
                    double.Parse(rectangle[3]),
                    double.Parse(rectangle[4])
                );
            }

            for (int i = 0; i < inputs[1]; i++)
            {
                string[] ids = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                Rectangle rectangleOne = Rectangle.Collection[ids[0]];
                Rectangle rectangleTwo = Rectangle.Collection[ids[1]];

                bool result = rectangleOne.CheckIntersect(rectangleTwo);
                Console.WriteLine(result.ToString().ToLower());
            }
        }
    }

}