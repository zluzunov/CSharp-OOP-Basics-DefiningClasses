namespace Homework01.Cars
{
    public class Engine
    {
        private const double DefaultDisplacement = 0.0;
        private const string DefaultEfficiency = "n/a";
        public string Model { get; set; }
        public int Power { get; set; }
        public double Displacement { get; set; }
        public string Efficiency { get; set; }


        public Engine(string model, double displacement, int power, string efficiency = DefaultEfficiency)
        {
            Model = model;
            Power = power;
            Displacement = displacement;
            Efficiency = efficiency;
        }

        public Engine(string model, int power)
        : this(model, DefaultDisplacement, power)
        { }

        public Engine(string model, int power, string efficiency)
            : this(model, DefaultDisplacement, power, efficiency)
        { }

        public Engine(string model, double displacement, int power)
            : this(model, displacement, power, DefaultEfficiency)
        { }

        public override string ToString()
        {
            string padding = "  ";
            string displacement = Displacement == DefaultDisplacement ? DefaultEfficiency : $"{Displacement}";

            string result = $"{padding}{Model}:\n{padding+padding}Power: {Power}\n{padding + padding}Displacement: {displacement}\n{padding + padding}Efficiency: {Efficiency}";

            return result;
        }
    }
}
