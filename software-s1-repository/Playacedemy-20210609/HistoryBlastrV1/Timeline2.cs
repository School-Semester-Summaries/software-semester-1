using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoryBlastrV1
{
    public enum Gebeurtenis
    {
        willem_1 = 1,
        spoorlijn = 2,
        grondwet = 3,
        max_Havelaar = 4,
        van_Houten = 5,
        van_Gogh = 6,
        aletta = 7,
        wereld_Oorlog_1 = 8,
        anton = 9,
        wereld_Oorlog_2 = 10,
        anne_Frank = 11,
        indonesie = 12,
        watersnood = 13,
        tV = 14,
        rotterdam = 15,
        marga = 16,
        gastarbeiders = 17,
        annie = 18,
        kolen_en_Gas = 19,
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
            /*14 */ {Gebeurtenis.tV,              new TimelineItem(Gebeurtenis.tV,              1948) },
            /*11 */ {Gebeurtenis.anne_Frank,      new TimelineItem(Gebeurtenis.anne_Frank,      1945) },
            /*16 */ {Gebeurtenis.marga,           new TimelineItem(Gebeurtenis.marga,           1965) },
            /*18 */ {Gebeurtenis.annie,           new TimelineItem(Gebeurtenis.annie,           1995) },
            /*9  */ {Gebeurtenis.anton,           new TimelineItem(Gebeurtenis.anton,           1934) },
            /*22 */ {Gebeurtenis.europa,          new TimelineItem(Gebeurtenis.europa,          1992) },
            /*7  */ {Gebeurtenis.aletta,          new TimelineItem(Gebeurtenis.aletta,          1893) },
            /*1  */ {Gebeurtenis.willem_1,        new TimelineItem(Gebeurtenis.willem_1,        1772) },
            /*3  */ {Gebeurtenis.grondwet,        new TimelineItem(Gebeurtenis.grondwet,        1848) },
            /*6  */ {Gebeurtenis.van_Gogh,        new TimelineItem(Gebeurtenis.van_Gogh,        1890) },
            /*12 */ {Gebeurtenis.indonesie,       new TimelineItem(Gebeurtenis.indonesie,       1949) },
            /*2  */ {Gebeurtenis.spoorlijn,       new TimelineItem(Gebeurtenis.spoorlijn,       1839) },
            /*20 */ {Gebeurtenis.caribisch,       new TimelineItem(Gebeurtenis.caribisch,       1975) },
            /*15 */ {Gebeurtenis.rotterdam,       new TimelineItem(Gebeurtenis.rotterdam,       1962) },
            /*13 */ {Gebeurtenis.watersnood,      new TimelineItem(Gebeurtenis.watersnood,      1953) },
            /*5  */ {Gebeurtenis.van_Houten,      new TimelineItem(Gebeurtenis.van_Houten,      1874) },
            /*21 */ {Gebeurtenis.srebrenica,      new TimelineItem(Gebeurtenis.srebrenica,      1995) },
            /*4  */ {Gebeurtenis.max_Havelaar,    new TimelineItem(Gebeurtenis.max_Havelaar,    1860) },
            /*19 */ {Gebeurtenis.kolen_en_Gas,    new TimelineItem(Gebeurtenis.kolen_en_Gas,    1974) },
            /*23 */ {Gebeurtenis.oranjegevoel,    new TimelineItem(Gebeurtenis.oranjegevoel,    2021) },
            /*17 */ {Gebeurtenis.gastarbeiders,   new TimelineItem(Gebeurtenis.gastarbeiders,   1974) },
            /*8  */ {Gebeurtenis.wereld_Oorlog_1, new TimelineItem(Gebeurtenis.wereld_Oorlog_1, 1914) },
            /*10 */ {Gebeurtenis.wereld_Oorlog_2, new TimelineItem(Gebeurtenis.wereld_Oorlog_2, 1939) },

        };

        public void getSpots(int sp1, int sp2, int sp3, int sp4, int sp5)
        {
           spot1 = sp1;
           spot2 = sp2;  
           spot3 = sp3;  
           spot4 = sp4;  
           spot5 = sp5;   
        }

        public string GetNameBySpot(int Spot)
        {
            string Name = Enum.GetName(typeof(Gebeurtenis), Spot);
            Name = char.ToUpper(Name[0]) + Name.Substring(1);
            Name = Name.Replace("_", " ");

            return Name;
        }

        public int GetTimeBySpot(int spot)
        {

            Gebeurtenis yr = (Gebeurtenis)spot;
            TimelineItem item;
            bool success = _timelineItems.TryGetValue(yr, out item);
            return item.JaarGetal;

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
 