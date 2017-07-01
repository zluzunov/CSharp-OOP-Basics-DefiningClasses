namespace Homework01.Cars
{
    public class Engine
    {
        public int Speed { get; set; }
        public int Power { get; set; }
        public double Displacement { get; set; }
        public double Efficiency { get; set; }


        public Engine(int speed, int power)
        {
            Speed = speed;
            Power = power;
        }
    }
}
