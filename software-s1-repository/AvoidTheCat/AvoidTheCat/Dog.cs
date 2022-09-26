using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvoidTheCat
{
    class Dog
    {
        // Objects
        Direction direction;
        Barrier barrier = new Barrier();

        // Fields
        private int xLocation = 100;
        private int yLocation = 100;
        private int xSize = 150;
        private int ySize = 150;
        private int movementSpeed = 2;
        private bool sleeping = false;
        private int fallingAsleepIn = 50;
        private int wakingUpIn = -50;

        // Properties
        public int XLocation { get { return xLocation; } }
        public int YLocation { get { return yLocation; } }
        public int XSize { get { return xSize; } }
        public int YSize { get { return ySize; } }
        public bool Sleeping { get { return sleeping; } }
        public int FallingAsleepIn { get { return fallingAsleepIn; } }
        public int WakingUpIn { get { return wakingUpIn; } }
        public Direction Direction { get { return direction; } }

        // Methods
        public void Movement(Random rnd)
        {
            if (!sleeping)
            {
                direction = (Direction)rnd.Next(0, 8);

                if (direction == Direction.Up)
                {
                    MoveUp();
                }
                if (direction == Direction.Upright)
                {
                    MoveUpRight();
                }
                if (direction == Direction.Right)
                {
                    MoveRight();
                }
                if (direction == Direction.Downright)
                {
                    MoveDownRight();
                }
                if (direction == Direction.Down)
                {
                    MoveDown();
                }
                if (direction == Direction.Downleft)
                {
                    MoveDownLeft();
                }
                if (direction == Direction.Left)
                {
                    MoveLeft();
                }
                if (direction == Direction.Upleft)
                {
                    MoveUpLeft();
                }
            }
        }
        public void FallAsleep()
        {
            sleeping = true;
        }
        public void WakeUp(int newFallingAsleepIn)
        {
            sleeping = false;
            fallingAsleepIn = newFallingAsleepIn;
        } // HARDOCDED
        public void FallingAsleepInMinusOne()
        {
            fallingAsleepIn--;
        }

        public void MoveUp()
        {
            if (!barrier.HitTop(yLocation))
            {
                yLocation = yLocation - movementSpeed;
            }
        }
        public void MoveUpRight()
        {
            if (!barrier.HitTop(yLocation) && !barrier.HitRight(xLocation, xSize))
            {
                yLocation = yLocation - movementSpeed;
                xLocation = xLocation + movementSpeed;
            }
        }
        public void MoveRight()
        {
            if (!barrier.HitRight(xLocation, xSize))
            {
                xLocation = xLocation + movementSpeed;
            }
        }
        public void MoveDownRight()
        {
            if (!barrier.HitRight(xLocation, xSize) && !barrier.HitBottom(yLocation, ySize))
            {
                xLocation = xLocation + movementSpeed;
                yLocation = yLocation + movementSpeed;
            }
        }
        public void MoveDown()
        {
            if (!barrier.HitBottom(yLocation, ySize))
            {
                yLocation = yLocation + movementSpeed;
            }
        }
        public void MoveDownLeft()
        {
            if (!barrier.HitBottom(yLocation, ySize) && !barrier.HitLeft(xLocation))
            {
                yLocation = yLocation + movementSpeed;
                xLocation = xLocation - movementSpeed;
            }
        }
        public void MoveLeft()
        {
            if (!barrier.HitLeft(xLocation))
            {
                xLocation = xLocation - movementSpeed;
            }
        }
        public void MoveUpLeft()
        {
            if (!barrier.HitTop(yLocation) && !barrier.HitLeft(xLocation))
            {
                yLocation = yLocation - movementSpeed;
                xLocation = xLocation - movementSpeed;
            }
        }

        public void ModifyLocation(int x, int y)
        {
            xLocation = x;
            yLocation = y;
        }
        public void ModifyFallingAsleepIn(int newFallingAsleepIn)
        {
            fallingAsleepIn = newFallingAsleepIn;
        }
        public void ModifyWakeUpIn(int newWakeUpIn)
        {
            wakingUpIn = newWakeUpIn;
        }
    }
}
