namespace Homework01.Cars
{
    public class Car
    {
        private const double WeightDefault = 0.0;
        private const string ColorDefault = "n/a";

        public Car(
            string model,
            Engine engine,
            double weight,
            string color
        )
        {
            Model = model;
            Engine = engine;
            Weight = weight;
            Color = color;
        }

        public Car(string model, Engine engine)
            :this(model, engine, WeightDefault,ColorDefault)
        {}

        public Car(string model, Engine engine, double weight)
            : this(model, engine, weight, ColorDefault)
        { }

        public Car(string model, Engine engine, string color)
            : this(model, engine, WeightDefault, color)
        { }

        public Car(string model, decimal speed)
        {
            Model = model;
            Speed = speed;
        }

        public string Model { get; set; }

        public Engine Engine { get; set; }

        public double Weight { get; set; }

        public string Color { get; set; }

        public decimal Speed { get; set; }

        public override string ToString()
        {
            return $"{Model} {Speed}\n";
        }
    }
}
