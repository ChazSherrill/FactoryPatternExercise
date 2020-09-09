using System;

namespace FactoryPatternPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            IVehicle vehicle = VehicleFactory.GetVehicle();

            vehicle.Drive();
        }
    }
}
