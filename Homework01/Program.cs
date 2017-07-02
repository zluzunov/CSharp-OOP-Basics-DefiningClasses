namespace Homework01
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Problem14;

    public class Program
    {
        static void Main()
        {
            string line;
            string endCommand = "End";

            List<Cat> cats = new List<Cat>();

            while ((line = Console.ReadLine()) != endCommand)
            {
                string[] catData = line.Split(new []{' '},StringSplitOptions.RemoveEmptyEntries);

                string breed = catData[0];
                string name = catData[1];
                decimal property = decimal.Parse(catData[2]);

                if (breed == "Cymric")
                {
                    cats.Add(new CatCymric(breed,name,property));
                }
                else
                {
                    cats.Add(new Cat(breed, name, property));
                }
            }
            string targetCatName = Console.ReadLine();

            Console.WriteLine(cats.FirstOrDefault(c => c.Name == targetCatName));

        }
    }

}