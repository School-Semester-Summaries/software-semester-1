using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EendenVijver
{
    public class Eend
    {
        // Objects
        Wall wall = new Wall();

        // Fields
        private Geslacht geslacht;
        private Direction direction;

        private int[] location = new int[2] { 350, 150 };
        private int[] size = new int[2] {40, 40 };
        private int movementSpeed = 10;

        // Properties
        public Geslacht Geslacht { get { return geslacht; } }
        public int[] Location { get { return location; } }
        public int[] Size { get { return size; } }

        // Constructors
        public Eend()
        {
            // nothing
        }
        public Eend(Random rnd)
        {
            geslacht = (Geslacht)(rnd.Next(0, 2));
            location[0] = rnd.Next(3, 6) * 100;
            location[1] = rnd.Next(0, 7) * 50;
        }

        // Methods
        public void MovingRight()
        {
            if (location[0] != wall.RightWall)
            {
                location[0] = location[0] + movementSpeed;
            }
        }
        public void MovingLeft()
        {
            if (location[0] != wall.LeftWall)
            {
                location[0] = location[0] - movementSpeed;
            }
        }
        public void MovingUp()
        {
            if (location[1] != wall.UpWall)
            {
                location[1] = location[1] - movementSpeed;
            }
        }
        public void MovingDown()
        {
            if (location[1] != wall.DownWall)
            {
                location[1] = location[1] + movementSpeed;
            }
        }

        public void EendMovement(Random rnd, int aantalEenden, Eend[] arrayEend)
        {
            for (int i = 0; i < aantalEenden; i++)
            {
                direction = (Direction)(rnd.Next(0, 4));

                if (direction == Direction.Up)
                {
                    arrayEend[i].MovingUp();
                }
                if (direction == Direction.Right)
                {
                    arrayEend[i].MovingRight();
                }
                if (direction == Direction.Down)
                {
                    arrayEend[i].MovingDown();
                }
                if (direction == Direction.Left)
                {
                    arrayEend[i].MovingLeft();
                }
            }
        }
    }
}
