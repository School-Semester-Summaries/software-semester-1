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
        marga = 16,
        gastarbeiders = 17,
        annie = 18,
        kolen = 19,
        caribisch = 20,
        srebrenica = 21,
        europa = 22,
        oranjegevoel = 23,
    }

    public class Timeline
    {
        //TimelineItem timeline_item = new TimelineItem();

        public int spot1 { get; private set; }
        public int spot2 { get; private set; }
        public int spot3 { get; private set; }
        public int spot4 { get; private set; }
        public int spot5 { get; private set; }


        private Dictionary<Gebeurtenis, TimelineItem> _timelineItems = new Dictionary<Gebeurtenis, TimelineItem>
        {
            {Gebeurtenis.tv,            new TimelineItem(Gebeurtenis.tv,            1948) },
            {Gebeurtenis.wo1,           new TimelineItem(Gebeurtenis.wo1,           1914) },
            {Gebeurtenis.wo2,           new TimelineItem(Gebeurtenis.wo2,           1939) },
            {Gebeurtenis.anne,          new TimelineItem(Gebeurtenis.anne,          1945) },
            {Gebeurtenis.marga,         new TimelineItem(Gebeurtenis.marga,         1965) },
            {Gebeurtenis.vgogh,         new TimelineItem(Gebeurtenis.vgogh,         1890) },
            {Gebeurtenis.annie,         new TimelineItem(Gebeurtenis.annie,         1995) },
            {Gebeurtenis.anton,         new TimelineItem(Gebeurtenis.anton,         1934) },
            {Gebeurtenis.kolen,         new TimelineItem(Gebeurtenis.kolen,         1974) },
            {Gebeurtenis.europa,        new TimelineItem(Gebeurtenis.europa,        1992) },
            {Gebeurtenis.aletta,        new TimelineItem(Gebeurtenis.aletta,        1893) },
            {Gebeurtenis.vhouten,       new TimelineItem(Gebeurtenis.vhouten,       1874) },
            {Gebeurtenis.willem1,       new TimelineItem(Gebeurtenis.willem1,       1772) },
            {Gebeurtenis.grondwet,      new TimelineItem(Gebeurtenis.grondwet,      1848) },
            {Gebeurtenis.indonesie,     new TimelineItem(Gebeurtenis.indonesie,     1949) },
            {Gebeurtenis.spoorlijn,     new TimelineItem(Gebeurtenis.spoorlijn,     1839) },
            {Gebeurtenis.caribisch,     new TimelineItem(Gebeurtenis.caribisch,     1975) },
            {Gebeurtenis.rotterdam,     new TimelineItem(Gebeurtenis.rotterdam,     1962) },
            {Gebeurtenis.watersnood,    new TimelineItem(Gebeurtenis.watersnood,    1953) },
            {Gebeurtenis.srebrenica,    new TimelineItem(Gebeurtenis.srebrenica,    1995) },
            {Gebeurtenis.maxhavelaar,   new TimelineItem(Gebeurtenis.maxhavelaar,   1860) },
            {Gebeurtenis.oranjegevoel,  new TimelineItem(Gebeurtenis.oranjegevoel,  2021) },
            {Gebeurtenis.gastarbeiders, new TimelineItem(Gebeurtenis.gastarbeiders, 1974) },

        };

        public void getSpots(int sp1, int sp2, int sp3, int sp4, int sp5)
        {
            sp1 = spot1;  
            sp2 = spot2; 
            sp3 = spot3; 
            sp4 = spot4; 
            sp5 = spot5;  
        }

        public Timeline()
        {
            

           


        }

       public List<int>  Reorderdlist { get {
                var listOfInputs = new List<int>()
                {
                spot1,   //3
                spot2,    // 1
                spot3,     // 8
                spot4     ,  // 4
                spot5,    /// 22
                 };
                return listOfInputs.Select(input => _timelineItems[(Gebeurtenis)input])
                   .OrderBy(e => e.JaarGetal)
                   .Select(e => (int)e.Gebeurtenis)
                   .ToList();
                 } }
        
    }
}
 