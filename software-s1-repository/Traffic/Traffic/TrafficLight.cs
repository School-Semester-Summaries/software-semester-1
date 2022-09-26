using System;
using System.Collections.Generic;
using System.Text;

namespace Traffic
{
    class TrafficLight
    {
        // variables
        static int stateNumber = 0;

        // fields
        private string color = "Red";

        // goes to the next color
        public void NextState()
        {
            // next color
            stateNumber++;

            if (stateNumber == 1)
            {
                color = "Green";
            }
            else if (stateNumber == 2)
            {
                color = "Orange";
            }
            else
            {
                color = "Red";

                // reset cycle
                stateNumber = 0;
            }
        }

        // displays current color in console
        public void GetCurrentColor()
        {
            Console.WriteLine(color);
        }
    }
}
