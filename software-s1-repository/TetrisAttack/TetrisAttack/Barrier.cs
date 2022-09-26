using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisAttack
{
    class Barrier
    {
        // Fields
        private int yBottom = 360;
        private int yTop = 0;
        private int xRight = 250;
        private int xLeft = 0;

        // Properties
        public int YBottom { get { return yBottom; } }
        public int YTop { get { return yTop; } }
        public int XRight { get { return xRight; } }
        public int XLeft { get { return xLeft; } }

        // Methods
        public bool HitTop(int yLocation)
        {
            if (yLocation <= yTop)
            {
                return true;
            }
            return false;
        }
        public bool HitRight(int xLocation, int xSize)
        {
            if (xLocation >= xRight - xSize)
            {
                return true;
            }
            return false;
        }
        public bool HitBottom(int yLocation, int ySize)
        {
            if (yLocation >= yBottom - ySize)
            {
                return true;
            }
            return false;
        }
        public bool HitLeft(int xLocation)
        {
            if (xLocation <= xLeft)
            {
                return true;
            }
            return false;
        }
    }
}
