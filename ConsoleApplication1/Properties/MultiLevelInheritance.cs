using System;

namespace ConsoleApplication1.Properties
{
    class Vehicles
    {
        public virtual void wheels()
        {
            Console.WriteLine("Do all vehicles have wheels?");
        }
    }

    class RoadVehicles : Vehicles
    {
        public override void wheels()
        {
            Console.WriteLine("Well Road vehicles do");
        }
    }

    class Cars : RoadVehicles
    {
        public override void wheels()
        {
            Console.WriteLine("Some cars have 4, Some have 3... 3s are weird");
        }
    }
    public class MultiLevelInheritance
    {
        public static void Main(string[] args)
        {
            Cars honda = new Cars();
            honda.wheels();

            RoadVehicles trucks = new RoadVehicles();
            trucks.wheels();

            Vehicles vehicles = new Vehicles();
            vehicles.wheels();
        }
    }
}