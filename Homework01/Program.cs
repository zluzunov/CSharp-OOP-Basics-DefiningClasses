namespace Homework01
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Cars;
    using Company;
    using Problem11;

    public class Program
    {
        static void Main()
        {
            string endCommand = "End";

            Dictionary<string, Person> people = new Dictionary<string, Person>();

            string input;

            while ((input = Console.ReadLine()) != endCommand)
            {
                string[] personData = input
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                string name = personData[0];
                string command = personData[1];

                if (!people.ContainsKey(name))
                {
                    people[name] = new Person(name);
                }

                switch (command)
                {
                    case "company":
                        people[name].Company = new Company.Company(personData[2],personData[3], double.Parse(personData[4]));
                        break;
                    case "pokemon":
                        people[name].Pokemons.Add(new Pokemon(personData[2], personData[3]));
                        break;
                    case "parents":
                        people[name].Parents.Add(new Person(personData[2],personData[3]));
                        break;
                    case "children":
                        people[name].Children.Add(new Person(personData[2], personData[3]));
                        break;
                    case "car":
                        people[name].Car = new Car(personData[2], decimal.Parse(personData[3]));
                        break;
                }
            }

            input = Console.ReadLine();

            people[input].PrintPersonData();


        }
    }
}




