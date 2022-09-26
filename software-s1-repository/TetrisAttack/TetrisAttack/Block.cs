using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisAttack
{
    public class Block
    {
        // Fields
        int xLocation = 0;
        int yLocation = 0;
        int xSize = 50;
        int ySize = 50;
        const int bottom = 400;
        bool falling = false;
        Color color;

        // Properties
        public int XLocation { get { return xLocation; } }
        public int YLocation { get { return yLocation; } }
        public int XSize { get { return xSize; } }
        public int YSize { get { return ySize; } }
        public int Bottom { get { return bottom; } }
        public bool Falling { get { return falling; } }
        public Color Color { get { return color; } }

        // Constructors
        public Block(Random rnd)
        {
            color = RandomColor(rnd);
        }

        // Methods
        public Color RandomColor(Random rnd)
        {
            BlockColors blockColor = (BlockColors)rnd.Next(0, 5);
            Color randomColor = Color.Black;

            if (blockColor == BlockColors.Red)
            {
                randomColor = Color.DarkRed;
            }
            else if (blockColor == BlockColors.Blue)
            {
                randomColor = Color.Blue;
            }
            else if (blockColor == BlockColors.Green)
            {
                randomColor = Color.Green;
            }
            else if (blockColor == BlockColors.Yellow)
            {
                randomColor = Color.Yellow;
            }
            else if (blockColor == BlockColors.Purple)
            {
                randomColor = Color.Purple;
            }
            return randomColor;
        }
        public void MoveRight()
        {
            xLocation = xLocation + xSize;
        }
        public void MoveLeft()
        {
            xLocation = xLocation - xSize;
        }
        public void ModifyLocation(int x, int y)
        {
            xLocation = xLocation + x;
            yLocation = yLocation + y;
        }
        public void StartFalling()
        {
            falling = true;
        }
        public void StopFalling()
        {
            falling = false;
        }
        
        public Bitmap CorrectImage(Block block)
        {
            Bitmap bitmap = Properties.Resources.Red_Block;
            if (block.Color == Color.Red)
            {
                bitmap = Properties.Resources.Amogus_Red;
                bitmap = Properties.Resources.Red_Block;
            }
            else if (block.Color == Color.Blue)
            {
                bitmap = Properties.Resources.Amogus_Blue;
                bitmap = Properties.Resources.Diamond_avatar;
                bitmap = Properties.Resources.CrossyChainsaw;
            }
            else if (block.Color == Color.Yellow)
            {
                bitmap = Properties.Resources.Amogus_Yellow;
            }
            else if (block.Color == Color.Green)
            {
                bitmap = Properties.Resources.Amogus_Green;
                bitmap = Properties.Resources.GrassTile2;
            }
            else if (block.Color == Color.Purple)
            {
                bitmap = Properties.Resources.Amogus_Pink;
            }
            return bitmap;
        }
        
    }
}
