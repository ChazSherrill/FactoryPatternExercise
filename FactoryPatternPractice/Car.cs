using System;
namespace FactoryPatternPractice
{
    public class Car : IVehicle
    {
        public Car()
        {
        }
        public void Drive()
        {
            Console.WriteLine("Building a new car.");
        }
    }
}
