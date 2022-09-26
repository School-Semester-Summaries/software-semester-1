using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EendenVijver
{
    public class Kikker
    {
        // Objects
        Wall wall = new Wall();

        // Fields
        private Geslacht geslacht;
        private Direction direction;

        private int[] location = new int[2] { 700, 300 };
        private int[] size = new int[2] { 30, 30 };
        private int movementSpeed = 10;
        private bool hidingBehindDuck = false;

        // Properties
        public Geslacht Geslacht { get { return geslacht; } }
        public int[] Location { get { return location; } }
        public int[] Size { get { return size; } }
        public bool HidingBehindDuck { get { return hidingBehindDuck; } }

        // Constructors
        public Kikker()
        {
            // nothing
        }
        public Kikker(Random rnd)
        {
            geslacht = (Geslacht)(rnd.Next(0, 2));
            location[0] = rnd.Next(5, 8) * 100;
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

        public void KikkerMovement(Random rnd, int aantalKikkers, Kikker[] arrayKikker)
        {
            for (int i = 0; i < aantalKikkers; i++)
            {
                direction = (Direction)(rnd.Next(0, 4));

                if (direction == Direction.Up)
                {
                    arrayKikker[i].MovingUp();
                }
                if (direction == Direction.Right)
                {
                    arrayKikker[i].MovingRight();
                }
                if (direction == Direction.Down)
                {
                    arrayKikker[i].MovingDown();
                }
                if (direction == Direction.Left)
                {
                    arrayKikker[i].MovingLeft();
                }
            }
        }

        public void HideBehindDuck()
        {
            hidingBehindDuck = true;
        }
        public void NotHideBehindDuck()
        {
            hidingBehindDuck = false;
        }

        internal Kikker WieIsDichterbij(int ooievaarLocation, Kikker dichtsbijzijndeKikker, int kortsteAfstandTotKikker)
        {
            if (this.hidingBehindDuck)
            {
                return dichtsbijzijndeKikker;
            }

            if (Math.Abs(ooievaarLocation - this.Location[1]) > kortsteAfstandTotKikker)
            {
                return dichtsbijzijndeKikker;
            }
            else
            {
                return this;
            }
        }

        public override string ToString()
        {
            return this.Geslacht.ToString();
        }
    }
}
