namespace Homework01
{
    using System;
    using System.Collections.Generic;
    using Problem13;

    public class Program
    {
        static void Main()
        {

            string line = Console.ReadLine();
            string endCommand = "End";
            List<string[]> relations = new List<string[]>();
            List<Person> people = new List<Person>();

            Person person;

            char[] delimiters = { ' ', '-' };

            person = new Person(line);

            while ((line = Console.ReadLine()) != endCommand)
            {
                string[] lineData = line.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                string[] commandPair = GetCommandPair(lineData);
                string leftString = commandPair[0];
                string rightString = commandPair[1];

                if (line.Contains("-"))
                {
                    relations.Add(commandPair);
                }
                else
                {
                    people.Add(new Person(lineData));
                }
            }

            person.PrintTree();
        }

        public static string[] GetCommandPair(string[] line)
        {
            string[] result;

            if (line.Length == 4)
            {
                //name - name
                result = new [] { $"{line[0]} {line[1]}", $"{line[2]} {line[3]}"};
            }
            else if (line.Length == 3)
            {
                if (line[0].Contains("/"))
                {
                    //date - name
                    result = new[] { line[0], $"{line[1]} {line[2]}" };
                }
                else
                {
                    //name - date
                    result = new[] { $"{line[0]} {line[1]}", line[0] };
                }
            }
            else if (line.Length == 2)
            {
                //date - date
                result = new[] { line[0], line[1] };
            }
            else
            {
                result = new string[] { };
            }

            return result;
        }

        public Person GetPerson(string id)
        {


            return new Person(" ");
        }
    }
}




