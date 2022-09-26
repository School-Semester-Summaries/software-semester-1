using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TetrisAttack
{
    enum BlockColors
    {
        Red,
        Blue,
        Yellow,
        Green,
        Purple
    }
        
    public partial class FRM_TetrisAttack : Form
    {
        public FRM_TetrisAttack()
        {
            InitializeComponent();
            CreateCursor();
            CreateCeiling();
            TMR_GameTime.Enabled = true;
            TMR_CreateLine.Enabled = true;
            TMR_RiseFloor.Enabled = true;
        }

        // Objects
        Random rnd = new Random();
        Cursor cursor = new Cursor();
        Barrier barrier = new Barrier();

        PictureBox PB_CursorLeft = new PictureBox();
        PictureBox PB_CursorLeft_LeftLine = new PictureBox();
        PictureBox PB_CursorLeft_TopLine = new PictureBox();
        PictureBox PB_CursorLeft_RightLine = new PictureBox();
        PictureBox PB_CursorLeft_BottomLine = new PictureBox();

        PictureBox PB_CursorRight = new PictureBox();
        PictureBox PB_CursorRight_LeftLine = new PictureBox();
        PictureBox PB_CursorRight_TopLine = new PictureBox();
        PictureBox PB_CursorRight_RightLine = new PictureBox();
        PictureBox PB_CursorRight_BottomLine = new PictureBox();

        PictureBox PB_Ceiling = new PictureBox();

        List<PictureBox> pictureBoxList = new List<PictureBox>();
        List<Block> blockList = new List<Block>();

        // Variables
        int time = 0;
        int counter = 0;
        int score = 0;

        // Events
        private void TMR_CreateLine_Tick(object sender, EventArgs e)
        {
            TMR_Gravity.Enabled = true; 
            CreateLine();
        }
        private void TMR_RiseFloor_Tick(object sender, EventArgs e)
        {
            // Rise cursor
            cursor.ModifyLocation(0, -10);

            RiseFloor();
            LBL_Bs.Text = "Blocks: " + blockList.Count().ToString();
            LBL_PBs.Text = "PictureBoxes: " + pictureBoxList.Count().ToString();
        }
        private void TMR_Gravity_Tick(object sender, EventArgs e)
        {
            Gravity();
        }
        private void TMR_GameTime_Tick(object sender, EventArgs e)
        {
            // Update cursor location
            UpdateLocations(PB_CursorLeft_TopLine, cursor.XLocationLeft, cursor.YLocationLeft);
            UpdateLocations(PB_CursorLeft_LeftLine, cursor.XLocationLeft, cursor.YLocationLeft);
            UpdateLocations(PB_CursorLeft_BottomLine, cursor.XLocationLeft, cursor.YLocationLeft + 50 - 4);
            UpdateLocations(PB_CursorLeft_RightLine, cursor.XLocationLeft + 50 - 4, cursor.YLocationLeft);
            UpdateLocations(PB_CursorLeft, cursor.XLocationLeft, cursor.YLocationLeft);

            UpdateLocations(PB_CursorRight_TopLine, cursor.XLocationRight, cursor.YLocationRight);
            UpdateLocations(PB_CursorRight_LeftLine, cursor.XLocationRight, cursor.YLocationRight);
            UpdateLocations(PB_CursorRight_BottomLine, cursor.XLocationRight, cursor.YLocationRight + 50 - 4);
            UpdateLocations(PB_CursorRight_RightLine, cursor.XLocationRight + 50 - 4, cursor.YLocationRight);
            UpdateLocations(PB_CursorRight, cursor.XLocationRight, cursor.YLocationRight);

            // Update blocks location
            for (int i = 0; i < blockList.Count; i++)
            {
                UpdateLocations(pictureBoxList[i], blockList[i].XLocation, blockList[i].YLocation);
            }

            // Check if ceiling gets hit
            for (int i = 0; i < pictureBoxList.Count; i++)
            {
                if (CheckCollisions(pictureBoxList[i], PB_Ceiling))
                {
                    TMR_CreateLine.Enabled = false;
                    TMR_GameTime.Enabled = false;
                    TMR_RiseFloor.Enabled = false;
                }
            }

            Check3BlocksNextToEachOther();
            Check3BlocksOnTopEachOther();

            TrackTime();
        }

        // Methods
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Up)
            {
                cursor.MoveUp();
            }
            if (keyData == Keys.Right)
            {
                cursor.MoveRight();
            }
            if (keyData == Keys.Down)
            {
                cursor.MoveDown();
            }
            if (keyData == Keys.Left)
            {
                cursor.MoveLeft();
            }
            if (keyData == Keys.Space)
            {
                SwapBlockLocations();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        public void RiseFloor()
        {
            for (int i = 0; i < blockList.Count; i++)
            {
                if (blockList[i].YLocation > -50)
                {
                    blockList[i].ModifyLocation(0, -10);
                }
                else
                {
                    blockList.RemoveAt(i);
                    pictureBoxList.RemoveAt(i);
                    i--;
                }
            }
        }

        public void TrackTime()
        {
            if (counter == 65)
            {
                time++;
                counter = 0;
                LBL_Time.Text = "Time: " + time;
            }
            else
            {
                counter++;
            }
        }

        public void SwapBlockLocations()
        {
            for (int i = 0; i < blockList.Count; i++)
            {
                if (CheckCollisions(PB_CursorLeft, pictureBoxList[i]))
                {
                    blockList[i].MoveRight();
                    pictureBoxList[i].Location = new Point(blockList[i].XLocation, blockList[i].YLocation);
                }
                else if (CheckCollisions(PB_CursorRight, pictureBoxList[i]))
                {
                    blockList[i].MoveLeft();
                    pictureBoxList[i].Location = new Point(blockList[i].XLocation, blockList[i].YLocation);
                }
            }
        }


        public void UpdateLocations(PictureBox pictureBox, int xLocation, int yLocation)
        {
            pictureBox.Location = new Point(xLocation, yLocation);
        }

        private void CreateCursor()
        {
            // Create left cursor visuals
            PB_CursorLeft_LeftLine.Image = Properties.Resources.CursorVerticalPart;
            PB_CursorLeft_LeftLine.SizeMode = PictureBoxSizeMode.AutoSize;
            PB_CursorLeft_LeftLine.Location = new Point(cursor.XLocationLeft, cursor.YLocationLeft);
            Controls.Add(PB_CursorLeft_LeftLine);

            PB_CursorLeft_TopLine.Image = Properties.Resources.CursorHorizontalPart;
            PB_CursorLeft_TopLine.SizeMode = PictureBoxSizeMode.AutoSize;
            PB_CursorLeft_TopLine.Location = new Point(cursor.XLocationLeft, cursor.YLocationLeft);
            Controls.Add(PB_CursorLeft_TopLine);

            PB_CursorLeft_RightLine.Image = Properties.Resources.CursorVerticalPart;
            PB_CursorLeft_RightLine.SizeMode = PictureBoxSizeMode.AutoSize;
            PB_CursorLeft_RightLine.Location = new Point(cursor.XLocationLeft + 50 - 4, cursor.YLocationLeft);
            Controls.Add(PB_CursorLeft_RightLine);

            PB_CursorLeft_BottomLine.Image = Properties.Resources.CursorHorizontalPart;
            PB_CursorLeft_BottomLine.SizeMode = PictureBoxSizeMode.AutoSize;
            PB_CursorLeft_BottomLine.Location = new Point(cursor.XLocationLeft, cursor.YLocationLeft + 50 - 4);
            Controls.Add(PB_CursorLeft_BottomLine);

            // Create right cursor visuals
            PB_CursorRight_LeftLine.Image = Properties.Resources.CursorVerticalPart;
            PB_CursorRight_LeftLine.SizeMode = PictureBoxSizeMode.AutoSize;
            PB_CursorRight_LeftLine.Location = new Point(cursor.XLocationLeft, cursor.YLocationLeft);
            Controls.Add(PB_CursorRight_LeftLine);

            PB_CursorRight_TopLine.Image = Properties.Resources.CursorHorizontalPart;
            PB_CursorRight_TopLine.SizeMode = PictureBoxSizeMode.AutoSize;
            PB_CursorRight_TopLine.Location = new Point(cursor.XLocationLeft, cursor.YLocationLeft);
            Controls.Add(PB_CursorRight_TopLine);

            PB_CursorRight_RightLine.Image = Properties.Resources.CursorVerticalPart;
            PB_CursorRight_RightLine.SizeMode = PictureBoxSizeMode.AutoSize;
            PB_CursorRight_RightLine.Location = new Point(cursor.XLocationLeft + 50 - 4, cursor.YLocationLeft);
            Controls.Add(PB_CursorRight_RightLine);

            PB_CursorRight_BottomLine.Image = Properties.Resources.CursorHorizontalPart;
            PB_CursorRight_BottomLine.SizeMode = PictureBoxSizeMode.AutoSize;
            PB_CursorRight_BottomLine.Location = new Point(cursor.XLocationLeft, cursor.YLocationLeft + 50 - 4);
            Controls.Add(PB_CursorRight_BottomLine);

            // Cursors but invisible, not necessary but makes code more understandable and clear
            // Don't add these to form cuz it will mess with layers
            PB_CursorLeft.Size = new Size(cursor.XSize, cursor.YSize);
            PB_CursorLeft.Location = new Point(cursor.XLocationLeft, cursor.YLocationLeft);

            PB_CursorRight.Size = new Size(cursor.XSize, cursor.YSize);
            PB_CursorRight.Location = new Point(cursor.XLocationRight, cursor.YLocationRight);
        }
        public void CreateBlock(int x)
        {
            Block block = new Block(rnd);
            block.ModifyLocation(x, block.Bottom);
            PictureBox PB_Block = new PictureBox();
            PB_Block.Size = new Size(50, 50);
            PB_Block.Location = new Point(block.XLocation, block.YLocation);
            PB_Block.BackColor = block.Color;
            PB_Block.Image = block.CorrectImage(block);
            PB_Block.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxList.Add(PB_Block);
            blockList.Add(block);
            Controls.Add(PB_Block);
        }
        public void CreateLine()
        {
            CreateBlock(0);
            CreateBlock(50);
            CreateBlock(100);
            CreateBlock(150);
            CreateBlock(200);
            CreateBlock(250);
        }
        public void CreateCeiling()
        {
            PB_Ceiling.Size = new Size(300, 50);
            PB_Ceiling.Location = new Point(0, -50);
            Controls.Add(PB_Ceiling);
        }

        public bool CheckCollisions(PictureBox PB_One, PictureBox PB_Two)
        {
            return (PB_One.Bounds.IntersectsWith(PB_Two.Bounds));
        }


        public void Check3BlocksNextToEachOther()
        {
            for (int i = 0; i < pictureBoxList.Count; i++)
            {
                for (int ii = 0; ii < pictureBoxList.Count; ii++)
                {
                    for (int iii = 0; iii < pictureBoxList.Count; iii++)
                    {
                        if (NextTo_CheckXLocations(i, ii, iii) && NextTo_CheckYLocations(i, ii, iii) && CheckColors(i, ii, iii))
                        {
                            DestroyBlock(i);
                            DestroyBlock(ii);
                            DestroyBlock(iii);
                        }
                    }
                }
            }
        }
        public bool NextTo_CheckXLocations(int i, int ii, int iii)
        {
            bool xFirstAndSecond = blockList[i].XLocation + blockList[i].XSize == blockList[ii].XLocation;
            bool xFirstAndThird = blockList[i].XLocation + blockList[i].XSize * 2 == blockList[iii].XLocation;
            if (xFirstAndSecond && xFirstAndThird)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool NextTo_CheckYLocations(int i, int ii, int iii)
        {
            bool yFirstAndSecond = blockList[i].YLocation == blockList[ii].YLocation;
            bool yFirstAndThird = blockList[i].YLocation == blockList[iii].YLocation;
            if (yFirstAndSecond && yFirstAndThird)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Check3BlocksOnTopEachOther()
        {
            for (int i = 0; i < pictureBoxList.Count; i++)
            {
                for (int ii = 0; ii < pictureBoxList.Count; ii++)
                {
                    for (int iii = 0; iii < pictureBoxList.Count; iii++)
                    {
                        if (OnTop_CheckXLocations(i, ii, iii) && OnTop_CheckYLocations(i, ii, iii) && CheckColors(i, ii, iii))
                        {
                            DestroyBlock(i);
                            DestroyBlock(ii);
                            DestroyBlock(iii);
                        }
                    }
                }
            }
        }
        public bool OnTop_CheckXLocations(int i, int ii, int iii)
        {
            bool xFirstAndSecond = blockList[i].XLocation == blockList[ii].XLocation;
            bool xFirstAndThird = blockList[i].XLocation == blockList[iii].XLocation;
            if (xFirstAndSecond && xFirstAndThird)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool OnTop_CheckYLocations(int i, int ii, int iii)
        {
            bool yFirstAndSecond = blockList[i].YLocation + blockList[i].YSize == blockList[ii].YLocation;
            bool yFirstAndThird = blockList[i].YLocation + blockList[i].YSize * 2 == blockList[iii].YLocation;
            if (yFirstAndSecond && yFirstAndThird)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckColors(int i, int ii, int iii)
        {
            bool colorFirstAndSecond = blockList[i].Color == blockList[ii].Color;
            bool colorFirstAndThird = blockList[i].Color == blockList[iii].Color;
            if (colorFirstAndSecond && colorFirstAndThird)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void DestroyBlock(int i)
        {
            blockList[i].ModifyLocation(-1000, -1000);
            Controls.Remove(pictureBoxList[i]);
            score = score + 10;
            LBL_Score.Text = "Score: " + score;
            // remove uit list staat in destroy blocks
        } // points kinda glitchy

        public void Gravity()
        {
            for (int i = 0; i < pictureBoxList.Count; i++)
            {
                bool isThereBlockUnderneathThisBlock = false;
                for (int ii = 0; ii < pictureBoxList.Count; ii++)
                {
                    if (Gravity_CheckYLocations(i, ii))
                    {
                        isThereBlockUnderneathThisBlock = true;
                    }
                }
                if (!isThereBlockUnderneathThisBlock && blockList[i].YLocation < 350)
                {
                    blockList[i].ModifyLocation(0, 50);
                    blockList[i].StartFalling();
                }
                else
                {
                    blockList[i].StopFalling();
                }
            }
        }
        public bool Gravity_CheckYLocations(int i, int ii)
        {
            bool blockUnderneath = blockList[i].YLocation + blockList[i].YSize == blockList[ii].YLocation; // check ook op x
            bool xCheck = blockList[i].XLocation == blockList[ii].XLocation;
            if (blockUnderneath && xCheck)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

/*
TO DO LIST
- cursor niet uit playing field
- 4's 5's enz

Onnauwkeurigheden
- methods ipv lange code met comment
- kijk of methods in classes kunnen ipv form class




*/