using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightsAndWalls
{
    class Cannon
    {
        // Fields
        int health = 350;
        int xLocation = 0;
        int yLocation = 0;
        int xSize = 50;
        int ySize = 50;
        int attackPower = 5;
        int range = 100; // 50 van een tile + 25 want size/2 = 25

        // Properties
        public int Health { get { return health; } }
        public int XLocation { get { return xLocation; } }
        public int YLocation { get { return yLocation; } }
        public int XSize { get { return xSize; } }
        public int YSize { get { return ySize; } }
        public int XCenter { get { return xLocation + xSize / 2; } }
        public int YCenter { get { return yLocation + ySize / 2; } }
        public int Range { get { return range; } }

        // Methods
        public void SetLocation(int xImageLocation, int yImageLocation)
        {
            xLocation = xImageLocation;
            yLocation = yImageLocation;
        }
        public void LoseHealth(int damage)
        {
            health = health - damage;
        }
        public void Shoot(List<Swordsman> swordsmanList, List<Bodyguard> bodyguardList)
        {
            for (int i = 0; i < swordsmanList.Count; i++)
            {
                swordsmanList[i].LoseHealth(attackPower);
            }
            for (int i = 0; i < bodyguardList.Count; i++)
            {
                bodyguardList[i].LoseHealth(attackPower);
            }
        }
    }
}
/*
logic cannon
als er een unit is binnen 1 block radius, dan doet de cannon damage
 */ 
