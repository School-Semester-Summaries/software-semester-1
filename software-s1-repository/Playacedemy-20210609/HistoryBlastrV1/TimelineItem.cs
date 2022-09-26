using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoryBlastrV1
{
    public class TimelineItem
    {
        public Gebeurtenis Gebeurtenis { get; private set; }
        public int JaarGetal { get; private set; }

        public TimelineItem(Gebeurtenis gebeurtenis, int jaarGetal)
        {
            Gebeurtenis = gebeurtenis;
            JaarGetal = jaarGetal;
        }



    }
}
