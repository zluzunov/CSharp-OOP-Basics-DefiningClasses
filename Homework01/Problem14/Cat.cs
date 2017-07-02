namespace Homework01.Problem14
{
    public class Cat
    {
        public string Name;
        protected string Breed;

        //stores ears size or meowing decibels :)
        protected decimal Property;

        public Cat(string breed, string name, decimal property)
        {
            Breed = breed;
            Name = name;
            Property = property;
        }

        public override string ToString()
        {
            return $"{Breed} {Name} {Property}";
        }
    }
}
