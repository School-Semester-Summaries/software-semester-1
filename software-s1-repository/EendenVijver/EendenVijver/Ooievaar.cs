using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EendenVijver
{
    public class Ooievaar
    {
        // Objects
        Wall wall = new Wall();
        Kikker dichtsbijzijndeKikker = new Kikker();

        // Fields
        private Geslacht geslacht;
        private Direction direction;

        private int[] location = new int[2] { 0, 0 };
        private int[] size = new int[2] { 50, 50 };
        private int movementSpeed = 25;

        // Properties
        public Geslacht Geslacht { get { return geslacht; } }
        public int[] Location { get { return location; } }
        public int[] Size { get { return size; } }

        // Constructors
        public Ooievaar()
        {
            // nothing
        }
        public Ooievaar(Random rnd)
        {
            geslacht = (Geslacht)(rnd.Next(0, 2));
            location[0] = rnd.Next(0, 3) * 100;
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

        public void AdvancedMovement(Random rnd, int aantalOoievaars, Ooievaar[] arrayOoievaar, int aantalKikkers, Kikker[] arrayKikker, Kikker kikker)
        {
            for (int i = 0; i < aantalOoievaars; i++) // ooievaar locaties worden hier niet opgeslagen
            {                
                if (arrayOoievaar[i].location[1] > kikker.Location[1])
                {
                    arrayOoievaar[i].MovingUp();
                }
                if (arrayOoievaar[i].location[0] < kikker.Location[0])
                {
                    arrayOoievaar[i].MovingRight();
                }
                if (arrayOoievaar[i].location[1] < kikker.Location[1])
                {
                    arrayOoievaar[i].MovingDown();
                }
                if (arrayOoievaar[i].location[0] > kikker.Location[0])
                {
                    arrayOoievaar[i].MovingLeft();
                }
            }
        }

        public Kikker SetTarget(Ooievaar[] arrayOoievaar, Kikker[] arrayKikker, int aantalKikkers)
        {
            int kortsteAfstandTotKikker = int.MaxValue;

            // check kortste x afstand
            for (int i = 0; i < aantalKikkers; i++)
            {
                // bereken afstand tot kikker
                int afstand = arrayOoievaar[0].Location[0] - arrayKikker[i].Location[0];
                if (afstand < 0)
                {
                    afstand = afstand * -1;
                }
                // overwrite de lange afstanden met de kortere
                if (afstand < kortsteAfstandTotKikker && arrayKikker[i].HidingBehindDuck == false)
                {
                    dichtsbijzijndeKikker = arrayKikker[i];
                    kortsteAfstandTotKikker = afstand;
                }
            }
            // check kortste y afstand
            for (int i = 0; i < aantalKikkers; i++)
            {
                //dichtsbijzijndeKikker = (arrayKikker[i]).WieIsDichterbij(arrayOoievaar[0].Location[1], dichtsbijzijndeKikker, kortsteAfstandTotKikker);
                //kortsteAfstandTotKikker = Math.Abs(arrayOoievaar[0].Location[1] - dichtsbijzijndeKikker.Location[1]);

                // bereken afstand tot kikker
                int afstand = arrayOoievaar[0].Location[1] - arrayKikker[i].Location[1];
                if (afstand < 0)
                {
                    afstand = afstand * -1;
                }
                // overwrite de lange afstanden met de kortere
                if (afstand < kortsteAfstandTotKikker && arrayKikker[i].HidingBehindDuck == false)
                {
                    dichtsbijzijndeKikker = arrayKikker[i];
                    kortsteAfstandTotKikker = afstand;
                }
            }

            //foreach (Kikker kikker in arrayKikker)
            //{

            //}

            // return de kikker met de kortste afstand
            return dichtsbijzijndeKikker;
        }
    }
}
