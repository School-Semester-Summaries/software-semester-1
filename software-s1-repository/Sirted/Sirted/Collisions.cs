using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Sirted
{
    class Collisions
    {
        // blocks object aanmaken
        Blocks blocks = new Blocks();

        // counts how much blocks get made
        public int blockNumber = 0;

        // bool aanmaken die checkt of blokken elkaar gaan raken
        public bool blocksWillCollide = false;

        // Make an point array to save locations in
        public Point[] existingBlocks = new Point[72];

        // save location existing blocks in point array to detect collisions.
        public void SaveLocationInArray()
        {
            // add the current block his location in the array
            existingBlocks[blockNumber] = new Point(blocks.GetXLocation(), blocks.GetYLocation());

            // counts blocks
            blockNumber++;
        }

        // checks if block will hit floor
        public bool CheckIfBlockHitsFloor()
        {
            if (blocks.GetYLocation() == 350)
            {
                blocksWillCollide = true;
            }
            return blocksWillCollide;
        }

        // checks if the current block is above an existing block
        public bool CheckIfThereIsAnBlockUnderneathThisBlock() //
        {
            for (int i = 0; i < blockNumber; i++)
            {
                // als de huidige blok boven een van de oudere blokken zit, dan moet de blok niet lager.
                if (new Point(blocks.GetXLocation(), blocks.GetYLocation() + 50) == existingBlocks[i])
                {
                    blocksWillCollide = true;
                }
            }
            return blocksWillCollide;
        }

        // check if there is an block left to this block
        public bool CheckIfThereIsAnBlockLeftToThisBlock()
        {
            for (int i = 0; i < blockNumber; i++)
            {
                // als de huidige blok boven een van de oudere blokken zit, dan moet de blok niet lager.
                if (new Point(blocks.GetXLocation() - 50, blocks.GetYLocation()) == existingBlocks[i])
                {
                    blocksWillCollide = true;
                }
            }
            return blocksWillCollide;
        }

        // check if there is an block right to this block
        public bool CheckIfThereIsAnBlockRightToThisBlock()
        {
            for (int i = 0; i < blockNumber; i++)
            {
                // als de huidige blok boven een van de oudere blokken zit, dan moet de blok niet lager.
                if (new Point(blocks.GetXLocation() + 50, blocks.GetYLocation()) == existingBlocks[i])
                {
                    blocksWillCollide = true;
                }
            }
            return blocksWillCollide;
        }


        public Point oneBlockBelowLocation = new Point();
        public Point twoBlocksBelowLocation = new Point();

        /*
        public bool ThereAreThreeBlocksOnTopOfEachOther()
        {
            bool oneBlockBelow = false;
            bool twoBlocksBelow = false;
            bool threeBlockTower = false;

            for (int i = 0; i < blockNumber; i++)
            {
                if (new Point(blocks.GetXLocation(), blocks.GetYLocation() + 50) == existingBlocks[i])
                {
                    oneBlockBelow = true;
                    oneBlockBelowLocation = existingBlocks[i];
                }
                if (new Point(blocks.GetXLocation(), blocks.GetYLocation() + 100) == existingBlocks[i])
                {
                    twoBlocksBelow = true;
                    twoBlocksBelowLocation = existingBlocks[i];
                }
                if (oneBlockBelow && twoBlocksBelow)
                {
                    threeBlockTower = true;
                }
            }
            return threeBlockTower;
        }
        */

        public Point GetOneBlockBelowLocation()
        {
            return oneBlockBelowLocation;
        }

        public Point GetTwoBlocksBelowLocation()
        {
            return twoBlocksBelowLocation;
        }
    }
}
