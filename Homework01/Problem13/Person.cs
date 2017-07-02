namespace Homework01.Problem13
{
    using System;
    using System.Collections.Generic;

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
        }

        public Person(string[] personData)
            :this(personData[0], personData[1], personData[2])
        {}

        public string Name()
        {
            string result = "";

            if (FirstName != null && LastName != null)
            {
                result = $"{FirstName} {LastName}";
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
