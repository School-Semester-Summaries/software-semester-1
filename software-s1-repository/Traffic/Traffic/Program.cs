using System;

namespace Traffic
{
    class Program
    {
        static void Main(string[] args)
        {
            TrafficLight kalverstraat = new TrafficLight();
            kalverstraat.GetCurrentColor();
            kalverstraat.NextState();
            kalverstraat.GetCurrentColor();
            kalverstraat.NextState();
            kalverstraat.GetCurrentColor();
            kalverstraat.NextState();
            kalverstraat.GetCurrentColor();
            kalverstraat.NextState();
            kalverstraat.GetCurrentColor();
        }
    }
}
