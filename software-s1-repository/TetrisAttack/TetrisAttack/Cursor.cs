using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisAttack
{
    class Cursor
    {
        // Objects 
        Barrier barrier = new Barrier();

        // Fields
        int xLocationLeft = 0;
        int yLocationLeft = -10;
        int xLocationRight = 50;
        int yLocationRight = -10;
        int xSize = 50;
        int ySize = 50;
        int movementSpeed = 50;

        // Properties
        public int XLocationLeft { get { return xLocationLeft; } }
        public int YLocationLeft { get { return yLocationLeft; } }
        public int XLocationRight { get { return xLocationRight; } }
        public int YLocationRight { get { return yLocationRight; } }
        public int XSize { get { return xSize; } }
        public int YSize { get { return ySize; } }

        // Methods
        public void MoveUp()
        {
            if (!barrier.HitTop(yLocationLeft))
            {
                yLocationLeft = yLocationLeft - movementSpeed;
                yLocationRight = yLocationRight - movementSpeed;
            }
        }
        public void MoveRight()
        {
            if (!barrier.HitRight(xLocationLeft, xSize))
            {
                xLocationLeft = xLocationLeft + movementSpeed;
                xLocationRight = xLocationRight + movementSpeed;
            }
        }
        public void MoveDown()
        {
            if (!barrier.HitBottom(yLocationLeft, ySize))
            {
                yLocationLeft = yLocationLeft + movementSpeed;
                yLocationRight = yLocationRight + movementSpeed;
            }
        }
        public void MoveLeft()
        {
            if (!barrier.HitLeft(xLocationLeft))
            {
                xLocationLeft = xLocationLeft - movementSpeed;
                xLocationRight = xLocationRight - movementSpeed;
            }
        }
        public void ModifyLocation(int x, int y)
        {
            xLocationLeft = XLocationLeft + x;
            xLocationRight = XLocationRight + x;
            yLocationLeft = YLocationLeft + y;
            yLocationRight = YLocationRight + y;
        }
    }
}
