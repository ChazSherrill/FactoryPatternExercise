using System;
namespace FactoryPatternPractice
{
    public class Motorcylce : IVehicle
    {
        public Motorcylce()
        {
        }

        public void Drive()
        {
            Console.WriteLine("Building a new Motorcycle.");
        }
    }
}
