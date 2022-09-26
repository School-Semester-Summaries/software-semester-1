using System;
using System.Collections.Generic;
using System.Text;

namespace Traffic_With_Enum
{
    public enum TrafficlightColors
    {
        Red,
        Orange,
        Green
    }

    class Trafficlight
    {
        private TrafficlightColors trafficlightcolors;


        public Trafficlight()
        {
            this.trafficlightcolors = TrafficlightColors.Red;
        }
        public Trafficlight(TrafficlightColors TrafficlightColors)
        {
            this.trafficlightcolors = TrafficlightColors;
        }
    }
}
