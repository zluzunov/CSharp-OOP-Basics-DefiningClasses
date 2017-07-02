namespace Homework01.Problem13
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Person
    {
        public List<Person> Parents;
        public List<Person> Children;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }

        public Person(string firstName, string lastName, string birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Parents = new List<Person>();
            Children = new List<Person>();
        }

        public Person(string startString)
        {
            if (startString.Contains("/"))
            {
                BirthDate = startString;
            }
            else
            {
                string[] names = startString.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                FirstName = names[0];
                LastName = names[1];
            }
            
            Parents = new List<Person>();
            Children = new List<Person>();
        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Parents = new List<Person>();
            Children = new List<Person>();
        }

        public Person(string[] personData)
        {
            FirstName = personData[0];
            LastName = personData[1];
            BirthDate = personData[2];

            Parents = new List<Person>();
            Children = new List<Person>();
        }

        public string Name()
        {
            string result = "";

            if (FirstName != null && LastName != null)
            {
                result = $"{FirstName} {LastName}";
            }

            return result;
        }

        public Person GetTreeMember(string searchString)
        {
            Person result = GetByBirthdate(searchString);
            if (result == null)
            {
                result = GetByName(searchString);
            }

            return result;
        }

        private Person GetByBirthdate(string birthDate)
        {
            Person result = Parents.FirstOrDefault(p => p.BirthDate == birthDate);
            if (result == null)
            {
                result = Children.FirstOrDefault(p => p.BirthDate == birthDate);
            }

            return result;
        }

        private Person GetByName(string name)
        {
            Person result = Parents.FirstOrDefault(p => p.Name() == name);
            if (result == null)
            {
                result = Children.FirstOrDefault(p => p.Name() == name);
            }

            return result;
        }

        public override string ToString()
        {
            string result = $"{Name()} {BirthDate}\n";

            return result;
        }

        public void PrintTree()
        {
            string parents = string.Join("", Parents);
            string children = string.Join("", Children);

            string result = $"{this}Parents:\n{parents}Children:\n{children}";

            Console.WriteLine(result);
        }
    }
}
