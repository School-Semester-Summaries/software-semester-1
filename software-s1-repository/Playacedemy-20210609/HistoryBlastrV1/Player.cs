using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoryBlastrV1
{
    public class Player
    {
        Database database = new Database();
        //Database.getuserdata();

        public int score { get; private set; }

        public string naam { get; private set; }

        public int coins { get; private set; }

        public void getname()
        {
            //database.name = naam
        }

        public Player():this("pietje")
        {
            
        }
       
        public Player(string Name)
        {
            coins = 0;
            score = 0;
            naam = Name;
            // naam = databasenaam
        }

        public void addscore(int amount)
        {
            score += amount; 
        }

        public void addcoins(int amount)
        {
            coins = amount / 10;
        }


        
    }
}
