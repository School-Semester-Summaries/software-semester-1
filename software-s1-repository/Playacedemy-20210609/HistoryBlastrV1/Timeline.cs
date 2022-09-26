using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoryBlastrV1
{
    public enum Gebeurtenis
    {
        willem1 = 1,
        spoorlijn = 2,
        grondwet = 3,
        maxhavelaar = 4,
        vhouten = 5,
        vgogh = 6,
        aletta = 7,
        wo1 = 8,
        anton = 9,
        wo2 = 10,
        anne = 11,
        indonesie = 12,
        watersnood = 13,
        tv = 14,
        rotterdam = 15,
        Marga = 16,
        gastarbeiders = 17,
        Annie = 18,
        kolen = 19,
        caribisch = 20,
        srebrenica = 21,
        europa = 22,
        oranjegevoel = 23,
    }

    public class Timeline
    {
        //TimelineItem timeline_item = new TimelineItem();


        private Dictionary<Gebeurtenis, TimelineItem> _timelineItems = new Dictionary<Gebeurtenis, TimelineItem>
        {
            {Gebeurtenis.willem1, new TimelineItem(Gebeurtenis.willem1, 1772) },
            {Gebeurtenis.spoorlijn, new TimelineItem(Gebeurtenis.spoorlijn, 1839) },

        };


        
        public Timeline()
        {
            var spot1 = 1;
            var spot2 = 2;
            var spot3 = 3;
            var spot4 = 4;
            var spot5 = 5;

            var listOfInputs = new List<int>()
            {
                spot1,
                spot2,
                spot3,
                spot4,
                spot5,
            };

            var listOfOutputs = listOfInputs.Select(input => _timelineItems[(Gebeurtenis)input])
                .OrderBy(e => e.JaarGetal)
                .Select(e => (int)e.Gebeurtenis)
                .ToList();


        }

       

    }
}
 