namespace RPG
{
    class Movement
    {
        // verander y-waarden
        public int EditLocation(int yPlayerLocation, int movementSpeed, string movementDirection)
        {
            if (movementDirection == "Up")
            {
                yPlayerLocation = yPlayerLocation - movementSpeed;
                return yPlayerLocation;
            }
            else if (movementDirection == "Down")
            {
                yPlayerLocation = yPlayerLocation + movementSpeed;
                return yPlayerLocation;
            }
            else
            {
                // nothing
            }
            return yPlayerLocation;
        }

        // verander x-waarden
        public int EditLocation(int xPlayerLocation, string movementDirection, int movementSpeed)
        {
            if (movementDirection == "Left")
            {
                xPlayerLocation = xPlayerLocation - movementSpeed;
                return xPlayerLocation;
            }
            else if (movementDirection == "Right")
            {
                xPlayerLocation = xPlayerLocation + movementSpeed;
                return xPlayerLocation;
            }
            else
            {
                // nothing
            }
            return xPlayerLocation;
        }

        // verander y-waarden
        public int FixPositioningAfterCollision(string movementBuffer, int movementSpeed, int yPlayerLocation)
        {
            int fixPositioning = movementSpeed + 2;

            if (movementBuffer == "Up")
            {
                yPlayerLocation = yPlayerLocation + fixPositioning;
                return yPlayerLocation;
            }
            else if (movementBuffer == "Down")
            {
                yPlayerLocation = yPlayerLocation - fixPositioning;
                return yPlayerLocation;
            }
            return yPlayerLocation;
        }

        // verander x-waarden
        public int FixPositioningAfterCollision(int movementSpeed, int xPlayerLocation, string movementBuffer)
        {
            int fixPositioning = movementSpeed + 2;

            if (movementBuffer == "Left")
            {
                xPlayerLocation = xPlayerLocation + fixPositioning;
                return xPlayerLocation;
            }
            else if (movementBuffer == "Right")
            {
                xPlayerLocation = xPlayerLocation - fixPositioning;
                return xPlayerLocation;
            }
            return xPlayerLocation;
        }
    }
}

/*
        public int FixPositioningAfterCollision(string movementBuffer, int movementSpeed, int xPlayerLocation, int yPlayerLocation)
        {
            int fixPositioning = movementSpeed + 2;

            if (movementBuffer == "Up")
            {
                yPlayerLocation = yPlayerLocation + fixPositioning;
                return yPlayerLocation;
            }
            else if (movementBuffer == "Left")
            {
                xPlayerLocation = xPlayerLocation + fixPositioning;
                return xPlayerLocation;
            }
            else if (movementBuffer == "Down")
            {
                yPlayerLocation = yPlayerLocation - fixPositioning;
                return yPlayerLocation;
            }
            else if (movementBuffer == "Right")
            {
                xPlayerLocation = xPlayerLocation - fixPositioning;
                return xPlayerLocation;
            }
            return yPlayerLocation;
        }
*/