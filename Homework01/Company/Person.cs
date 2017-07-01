namespace Homework01.Company
{
    using System;
    using System.Collections.Generic;
    using Cars;
    using Problem11;

    public class Person
    {
        public string name;
        public int age;

        public Person()
            :this("No name", -1)
        {
        
        }

        public Person(int age)
            :this("No name", age)
        {
        
        }

        public Person(string name)
            : this(name, 0)
        {
            Pokemons = new List<Pokemon>();
            Parents = new List<Person>();
            Children = new List<Person>();
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Person(string name, string birthday)
        {
            this.name = name;
            Birthday = birthday;

        }

        public Company Company { get; set; }

        public Car Car { get; set; }

        public List<Pokemon> Pokemons { get; set; }

        public List<Person> Parents { get; set; }

        public List<Person> Children { get; set; }

        public string Birthday { get; set; }

        public string Name
        {
            get { return name; }
        }

        public int Age
        {
            get { return age; }
        }

        public override string ToString()
        {
            return $"{Name} {Birthday}\n";
        }

        public void PrintPersonData()
        {
            string pokemons = string.Join("", Pokemons);
            string parents = string.Join("", Parents);
            string children = string.Join("", Children);

            string result =
                $"{Name}\nCompany:\n{Company}Car:\n{Car}Pokemon:\n{pokemons}Parents:\n{parents}Children:\n{children}";

            Console.WriteLine(result);
        }


    }
}
