using System;
namespace FactoryPatternPractice
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle()
        {
            Console.WriteLine("How many tires do you want your new car to have?");
            string numberOfTires = Console.ReadLine();

            switch(numberOfTires.ToLower())
            {
                case "0":
                    return new SpaceShip();
                case "none":
                    return new SpaceShip();
                case "2":
                    return new Motorcylce();
                case "4":
                    return new Car();
                default:
                    return new Car();
            }


        }

    }
}
