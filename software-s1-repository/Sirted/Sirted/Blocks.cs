using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;
using System.Drawing;

namespace Sirted
{
    class Blocks
    {
        // create Random object
        public Random rng = new Random();

        // create location variables
        static int xLocation = 200;
        static int yLocation = 0;

        public PictureBox GiveBlockSpecs()
        {
            xLocation = 200;
            yLocation = 0;
            PictureBox Block = new PictureBox();
            Block.Location = new Point(xLocation, yLocation);
            Block.Size = new Size(50,50);
            Block.BackColor = RandomColor();
            return Block;
        }

        public void UpdateLocation(int xLocationModifier, int yLocationModifier, PictureBox Block)
        {
            xLocation = xLocation + xLocationModifier;
            yLocation = yLocation + yLocationModifier;
            Block.Location = new Point(xLocation, yLocation);
        }

        private Color RandomColor()
        {
            int color = rng.Next(0, 3);

            if (color == 0)
            {
                return Color.Red;
            }
            else if (color == 1)
            {
                return Color.Blue;
            }
            else if (color == 2)
            {
                return Color.Green;
            }

            return Color.Black;
        }

        public int GetXLocation()
        {
            return xLocation;
        }
        public int GetYLocation()
        {
            return yLocation;
        }





        /*
        private Point RandomLocation()
        {
            int xLocation = rng.Next(0, 9);
            xLocation = xLocation * 50;


            int yLocation = rng.Next(0, 8);
            yLocation = yLocation * 50;

            return new Point(xLocation, yLocation);
        }
        */

    }
}
