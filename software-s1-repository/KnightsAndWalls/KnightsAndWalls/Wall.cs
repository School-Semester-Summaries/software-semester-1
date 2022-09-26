using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightsAndWalls
{
    class Wall
    {
        // Fields
        int health = 200;
        int xLocation = 0;
        int yLocation = 0;
        int xSize = 50;
        int ySize = 50;

        // Properties
        public int Health { get { return health; } }
        public int XLocation { get { return xLocation; } }
        public int YLocation { get { return yLocation; } }
        public int XSize { get { return xSize; } }
        public int YSize { get { return ySize; } }

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
