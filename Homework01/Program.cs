namespace Homework01
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Problem13;

    public class Program
    {
        static void Main()
        {
            string endCommand = "End";

            List<string[]> relations = new List<string[]>();
            List<Person> people = new List<Person>();

            char[] delimiters = { ' ', '-' };

            string line = Console.ReadLine();
            string targetPersonId = line;

            //collect people and their relations
            while ((line = Console.ReadLine()) != endCommand)
            {
                string[] lineData = line.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

                if (line.Contains("-"))
                {
                    string[] commandPair = GetRelations(lineData);
                    relations.Add(commandPair);
                }
                else
                {
                    people.Add(new Person(lineData));
                }
            }

            //get the target person
            Person targetPerson = people
                .FirstOrDefault(p => p.Name() == targetPersonId || p.BirthDate == targetPersonId);

            //get the IDs of targetPerson parents
            string[] parents = relations
                .Where(r => r[1] == targetPerson.Name() || r[1] == targetPerson.BirthDate)
                .Select(r => r[0]).ToArray();
            
            //Add parents
            targetPerson.Parents = people
                .Where(p => parents.Contains(p.Name()) || parents.Contains(p.BirthDate))
                .ToList();

            //get the IDs of targetPerson children
            string[] children = relations
                .Where(r => r[0] == targetPerson.Name() || r[0] == targetPerson.BirthDate)
                .Select(r => r[1]).ToArray();

            //Add children
            targetPerson.Children = people
                .Where(p => children.Contains(p.Name()) || children.Contains(p.BirthDate))
                .ToList();

            //print target person tree
            targetPerson.PrintTree();
        }

        public static string[] GetRelations(string[] line)
        {
            string[] result;

            if (line.Length == 4)
            {
                //name - name
                result = new[] { $"{line[0]} {line[1]}", $"{line[2]} {line[3]}" };
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
                    result = new[] { $"{line[0]} {line[1]}", line[2] };
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
    }
}




