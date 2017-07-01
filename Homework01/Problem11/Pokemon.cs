namespace Homework01.Problem11
{
    public class Pokemon
    {
        private string name;
        private string element;
        private decimal health;

        public Pokemon(string name, string element, decimal health)
        {
            this.name = name;
            this.element = element;
            this.health = health;
        }

        public Pokemon(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public decimal Health
        {
            get { return this.health; }
            set { this.health = value; }
        }

        public string Element
        {
            get { return this.element; }
            set { this.element = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Type { get; set; }

        public override string ToString()
        {
            return $"{Name} {Type}\n";
        }
    }
}
