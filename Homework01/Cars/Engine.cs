namespace Homework01.Cars
{
    public class Engine
    {
        private const double DefaultDisplacement = 0.0;
        private const double DefaultEfficiency = 0.0;
        public string Model { get; set; }
        public int Power { get; set; }
        public double Displacement { get; set; }
        public double Efficiency { get; set; }


        public Engine(string model, int power, double displacement, double efficiency = DefaultEfficiency)
        {
            Model = model;
            Power = power;
            Displacement = displacement;
            Efficiency = efficiency;
        }

        public Engine(string model, int power)
        : this(model, power, DefaultDisplacement)
        { }

        public Engine(string model, int power, double efficiency)
            : this(model, power, DefaultDisplacement, efficiency)
        { }
    }
}
