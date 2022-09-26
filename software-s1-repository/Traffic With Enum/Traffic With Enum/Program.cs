using System;

namespace Traffic_With_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        Trafficlight trafficlight1 = new Trafficlight();
        Trafficlight trafficlight2 = new Trafficlight(TrafficlightColors.Orange);
        Trafficlight trafficlight3 = new Trafficlight(TrafficlightColors.Green);
    }
}
