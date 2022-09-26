using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvoidTheCat
{
    enum CornerEscape
    {
        UpRight,
        BottomRight,
        BottomLeft,
        UpLeft,
        NotInCorner
    }

    class Mouse
    {
        // Objects
        CornerEscape cornerEscape;
        Barrier barrier = new Barrier();

        // Fields
        int xLocation = 0;
        int yLocation = 0;
        int xSize = 50;
        int ySize = 50;
        int movementSpeed = 4;
        bool hiding = false;
        bool dead = false;
        int timeSurvived = 0;

        // Properties
        public int XLocation { get { return xLocation; } }
        public int YLocation { get { return yLocation; } }
        public int XSize { get { return xSize; } }
        public int YSize { get { return ySize; } }
        public bool Hiding { get { return hiding; } }
        public CornerEscape CornerEsacpe { get { return cornerEscape; } }

        // Methods
        public void HideMovement(int xDogLocation, int yDogLocation)
        {
            if (!dead)
            {
                cornerEscape = CornerEscape.NotInCorner;
                movementSpeed = 4;

                if (YLocation > yDogLocation + ySize && XLocation < xDogLocation + xSize)
                {
                    MoveUpRight();
                }
                if (XLocation < xDogLocation + xSize && YLocation < yDogLocation + ySize)
                {
                    MoveDownRight();
                }
                if (YLocation < yDogLocation + ySize && XLocation > xDogLocation + xSize)
                {
                    MoveDownLeft();
                }
                if (XLocation > xDogLocation + xSize && YLocation > yDogLocation + ySize)
                {
                    MoveUpLeft();
                }
                if (YLocation > yDogLocation + ySize)
                {
                    MoveUp();
                }
                if (XLocation < xDogLocation + xSize)
                {
                    MoveRight();
                }
                if (YLocation < yDogLocation + ySize)
                {
                    MoveDown();
                }
                if (XLocation > xDogLocation + xSize)
                {
                    MoveLeft();
                }
            }
        }

        public void RunAwayMovement(int xCatLocation, int yCatLocation, int yCatSize, int xCatSize)
        {
            if (!dead)
            {
                // check if mouse is in top-right corner
                if (xLocation + xSize >= barrier.XRight && yLocation <= barrier.YTop)
                {
                    cornerEscape = CornerEscape.UpRight;
                    movementSpeed = 8;

                    if (yCatLocation - barrier.YTop < Math.Abs((xCatLocation + xCatSize) - barrier.XRight)) // decide where to go
                    {
                        MoveDown();
                    }
                    else
                    {
                        MoveLeft();
                    }
                }
                // check if mouse is in bottom-right corner
                else if (xLocation + xSize >= barrier.XRight && yLocation >= barrier.YBottom - YSize)
                {
                    cornerEscape = CornerEscape.BottomRight;
                    movementSpeed = 8;

                    if (Math.Abs((yCatLocation + yCatSize) - barrier.YBottom) < Math.Abs((xCatLocation + xCatSize) - barrier.XRight))
                    {
                        MoveUp();
                    }
                    else
                    {
                        MoveLeft();
                    }
                }
                // check if mouse is in bottom-left corner
                else if (xLocation <= barrier.XLeft && yLocation >= barrier.YBottom - YSize)
                {
                    cornerEscape = CornerEscape.BottomLeft;
                    movementSpeed = 8;

                    if (Math.Abs((yCatLocation + yCatSize) - barrier.YBottom) < xCatLocation - barrier.XLeft) // decide where to go // missschien moet het zijn ycatlocation - ycatsize
                    {
                        MoveUp();
                    }
                    else
                    {
                        MoveRight();
                    }
                }   
                // check if mouse is in up-left corner
                else if (xLocation <= barrier.XLeft && yLocation <= barrier.YTop)
                {
                    cornerEscape = CornerEscape.UpLeft;
                    movementSpeed = 8;

                    if (yCatLocation - barrier.YTop < xCatLocation - barrier.XLeft) // decide where to go
                    {
                        MoveDown();
                    }
                    else
                    {
                        MoveRight();
                    }
                }
                // check if mouse is in top-right corner
                else if (cornerEscape == CornerEscape.UpRight)
                {
                    cornerEscape = CornerEscape.UpRight;
                    movementSpeed = 8;

                    if (yCatLocation - barrier.YTop < Math.Abs((xCatLocation + xCatSize) - barrier.XRight)) // decide where to go
                    {
                        MoveDown();
                    }
                    else
                    {
                        MoveLeft();
                    }
                }
                // check if mouse is in bottom-right corner
                else if (cornerEscape == CornerEscape.BottomRight)
                {
                    cornerEscape = CornerEscape.BottomRight;
                    movementSpeed = 8;

                    if (Math.Abs((yCatLocation + yCatSize) - barrier.YBottom) < Math.Abs((xCatLocation + xCatSize) - barrier.XRight)) // decide where to go // missschien moet het zijn ycatlocation - ycatsize
                    {
                        MoveUp();
                    }
                    else
                    {
                        MoveLeft();
                    }
                }
                // check if mouse is in bottom-left corner
                else if (cornerEscape == CornerEscape.BottomLeft)
                {
                    cornerEscape = CornerEscape.BottomLeft;
                    movementSpeed = 8;

                    if (Math.Abs((yCatLocation + yCatSize) - barrier.YBottom) < xCatLocation - barrier.XLeft) // decide where to go // missschien moet het zijn ycatlocation - ycatsize
                    {
                        MoveUp();
                    }
                    else
                    {
                        MoveRight();
                    }
                }
                // check if mouse is in up-left corner
                else if (cornerEscape == CornerEscape.UpLeft)
                {
                    cornerEscape = CornerEscape.UpLeft;
                    movementSpeed = 8;

                    if (yCatLocation - barrier.YTop < xCatLocation - barrier.XLeft) // decide where to go
                    {
                        MoveDown();
                    }
                    else
                    {
                        MoveRight();
                    }
                }

                else // move normally away from the cat
                {
                    if (YLocation < yCatLocation && XLocation > xCatLocation)
                    {
                        MoveUpRight();
                    }
                    if (XLocation > xCatLocation && YLocation > yCatLocation)
                    {
                        MoveDownRight();
                    }
                    if (YLocation > yCatLocation && XLocation < xCatLocation)
                    {
                        MoveDownLeft();
                    }
                    if (XLocation < xCatLocation && YLocation < yCatLocation)
                    {
                        MoveUpLeft();
                    }
                    if (YLocation < yCatLocation)
                    {
                        MoveUp();
                    }
                    if (XLocation > xCatLocation)
                    {
                        MoveRight();
                    }
                    if (YLocation > yCatLocation)
                    {
                        MoveDown();
                    }
                    if (XLocation < xCatLocation)
                    {
                        MoveLeft();
                    }
                }
            }
        }

        public void Hide()
        {
            hiding = true;
        }

        public void StopHiding()
        {
            hiding = false;
        }

        public void Die()
        {
            dead = true;
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

        public int SurvivedASecond()
        {
            if (!dead)
            {
                timeSurvived++;
            }
            return timeSurvived;
        }
        public void ModifyLocation(int x, int y)
        {
            xLocation = x;
            yLocation = y;
        }
    }
}

// heb nu een mechanisme dat checkt of de muis in een hoek zit en haalt hem veilig uit de hoek. maak anders ook zoeits voor de zijkanten
