using System;
namespace FactoryPatternPractice
{
    public class SpaceShip : IVehicle
    {
        public SpaceShip()
        {
        }

        public void Drive()
        {
            Console.WriteLine("Up UP and aways!");
        }
    }
}
