using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightsAndWalls
{
    class Swordsman
    {
        // Fields
        int health = 250;
        int xLocation = 0;
        int yLocation = 0;
        int xSize = 50;
        int ySize = 50;
        int movementSpeed = 2;
        int attackPower = 1;
        bool moving = true;
        int xTarget;
        int yTarget;

        // Properties
        public int Health { get { return health; } }
        public int XLocation { get { return xLocation; } }
        public int YLocation { get { return yLocation; } }
        public int XSize { get { return xSize; } }
        public int YSize { get { return ySize; } }
        public int XCenter { get { return xLocation + xSize / 2; } }
        public int YCenter { get { return yLocation + ySize / 2; } }
        public int AttackPower { get { return attackPower; } }
        public bool Moving { get { return moving; } }

        // Methods
        public void SetLocation(int xImageLocation, int yImageLocation)
        {
            xLocation = xImageLocation;
            yLocation = yImageLocation;
        }

        public void HuntTarget()
        {
            if (moving)
            {
                if (xLocation < xTarget)
                {
                    MoveRight();
                }
                if (xLocation > xTarget)
                {
                    MoveLeft();
                }
                if (yLocation < yTarget)
                {
                    MoveDown();
                }
                if (yLocation > yTarget)
                {
                    MoveUp();
                }
            }
        }
        public void SetTarget(List<Cannon> cannonList, List<Townhall> townhallList)
        {
            /*
            [SetTarget EXPLAINED]
            1. creëer een double oldDistance, deze waarden moet zo hoog mogelijk zijn omdat we hem heel de tijd gaan overwriten met kleinere waardes
            2. for loop rekent per cannon uit wat de afstand er toe is, dit gebeurt met de stelling van pythagoras, afstand wordt in distance gezet
            3. als distance kleiner is dan oldDistance (wat de eerste keer dus altijd is) dan worden de locatie gegevens doorgegeven van de cannon
            4. nadat de waarden zijn doorgegeven van de cannon, overwrite we oldDistance met distance, op deze manier gaan we de volgende keer in de for loop alleen overwriten als de volgende cannon nog dichterbij zit. op deze manier wordt er in de for loop uitgerekend welke cannon het dichtsbij zit
            */
            double oldDistance = int.MaxValue;

            // calculate closest cannon
            for (int i = 0; i < cannonList.Count; i++)
            {
                // Pythagoras 
                double width = Math.Abs(XCenter - cannonList[i].XCenter);
                double length = Math.Abs(YCenter - cannonList[i].YCenter);
                double distance = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(length, 2));

                // Overwrite the target with the closest cannon
                if (distance < oldDistance)
                {
                    xTarget = cannonList[i].XLocation;
                    yTarget = cannonList[i].YLocation;
                    oldDistance = distance;
                }
            }
            // calculate closest townhall
            for (int i = 0; i < townhallList.Count; i++)
            {
                // Pythagoras 
                double width = Math.Abs(XCenter - (townhallList[i].XLocation + townhallList[i].XSize / 2));
                double length = Math.Abs(YCenter - (townhallList[i].YLocation + townhallList[i].YSize / 2));
                double distance = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(length, 2));

                if (distance < oldDistance)
                {
                    xTarget = townhallList[i].XLocation;
                    yTarget = townhallList[i].YLocation;
                    oldDistance = distance;
                }
            }
            // prevent crash
            if (cannonList.Count == 0 && townhallList.Count == 0)
            {
                xTarget = XLocation; // if there are no possible targets, the swordsman sets itself as target so it wont move
                yTarget = YLocation;
            }
        }

        public void MoveUp()
        {
            yLocation = yLocation - movementSpeed;
        }
        public void MoveRight()
        {
            xLocation = xLocation + movementSpeed;
        }
        public void MoveDown()
        {
            yLocation = yLocation + movementSpeed;
        }
        public void MoveLeft()
        {
            xLocation = xLocation - movementSpeed;
        }

        public void StartMoving()
        {
            moving = true;
        }
        public void StopMoving()
        {
            moving = false;
        }

        public void LoseHealth(int damage)
        {
            health = health - damage;
        }
    }
}
