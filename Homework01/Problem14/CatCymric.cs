namespace Homework01.Problem14
{
    public class CatCymric: Cat
    {
        public CatCymric(string breed, string name, decimal property)
            :base(breed, name, property)
        {}

        public override string ToString()
        {
            return $"{Breed} {Name} {Property:f2}";
        }
    }
}
