using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightsAndWalls
{
    class Townhall
    {
        // Fields
        int health = 1000;
        int xLocation = 0;
        int yLocation = 0;
        int xSize = 100;
        int ySize = 100;

        // Properties
        public int Health { get { return health; } }
        public int XLocation { get { return xLocation; } }
        public int YLocation { get { return yLocation; } }
        public int XSize { get { return xSize; } }
        public int YSize { get { return ySize; } }
        public int XCenter { get { return xLocation + xSize / 2; } }
        public int YCenter { get { return yLocation + ySize / 2; } }

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
    }
}

