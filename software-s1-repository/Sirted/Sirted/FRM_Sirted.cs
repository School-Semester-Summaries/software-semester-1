using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; // delay
using static System.Windows.Forms.SendKeys; // simulate key press

namespace Sirted
{
    public partial class FRM_sirted : Form
    {
        // create objects from other classes to work together
        Blocks blocks = new Blocks();
        Collisions collisions = new Collisions();
        PictureBox block = new PictureBox();
        Point[] existingBlocks = new Point[72];

        public FRM_sirted()
        {
            InitializeComponent();
        }

        // these numbers will modify the location of the block
        int xLocationModifier = 0;
        int yLocationModifier = 0;

        // create a bool that enables the keys if start button has been pressed
        bool GameHasStarted = false;

        // button that starts the game
        private void BTN_Start_Click(object sender, EventArgs e)
        {
            // create a new block in the form
            CreateBlockInForm();

            // turn on the game timer
            TMR_Timer.Enabled = true;

            // game started
            GameHasStarted = true;

            // disable the button
            BTN_Start.Visible = false;
        }

        // Keys
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (GameHasStarted)
            {
                if (keyData == Keys.Left)
                {
                    if (blocks.GetXLocation() == 0 || collisions.CheckIfThereIsAnBlockLeftToThisBlock())
                    {
                        // dont move block to the left
                        xLocationModifier = 0;
                        yLocationModifier = 0;

                        // reset bool
                        collisions.blocksWillCollide = false;
                    }
                    else
                    {
                        // move block to the left
                        xLocationModifier = -50;
                        yLocationModifier = 0;
                    }
                }
                else if (keyData == Keys.Right)
                {
                    if (blocks.GetXLocation() == 400 || collisions.CheckIfThereIsAnBlockRightToThisBlock())
                    {
                        // dont move block to the right
                        xLocationModifier = 0;
                        yLocationModifier = 0;

                        // reset bool
                        collisions.blocksWillCollide = false;
                    }
                    else
                    {
                        // move block to the right
                        xLocationModifier = 50;
                        yLocationModifier = 0;
                    }
                }
                else if (keyData == Keys.Down)
                {
                    // instant bottom
                    TMR_Timer.Interval = 1;
                }
            }
            // update locations
            blocks.UpdateLocation(xLocationModifier, yLocationModifier, block);

            // reset modifiers
            xLocationModifier = 0;
            yLocationModifier = 0;

            return base.ProcessCmdKey(ref msg, keyData);
        }

        // gets the picturebox from the Blocks.cs class and adds it to the form
        public void CreateBlockInForm()
        {
            // get the block
            block = blocks.GiveBlockSpecs();

            // add the block
            Controls.Add(block);
        }

        // timer that moves block down 1 position every second
        private void TMR_Timer_Tick(object sender, EventArgs e)
        {
            if (collisions.CheckIfBlockHitsFloor() || collisions.CheckIfThereIsAnBlockUnderneathThisBlock())
            {
                // block position won't get modified since it collided
                xLocationModifier = 0;
                yLocationModifier = 0;

                // save location existing block in point array to detect collisions, remove blocks that get destroyed
                collisions.SaveLocationInArray();

                // fix interval timer 
                TMR_Timer.Interval = 1000;

                /*
                // check if there are three blocks in a row vertically
                if(collisions.ThereAreThreeBlocksOnTopOfEachOther())
                {
                    // is het mogelijk om met de locatie van de picture box hem te verwujderen
                    collisions.GetOneBlockBelowLocation();
                    collisions.GetTwoBlocksBelowLocation();
                }
                */

                // reset blocks will collide after it collided
                collisions.blocksWillCollide = false;


                // creates a new block
                CreateBlockInForm();
            }
            else
            {
                // move block down
                xLocationModifier = 0;
                yLocationModifier = 50;
            }

            // updates location, modifiers get used
            blocks.UpdateLocation(xLocationModifier, yLocationModifier, block);
        }
    }
}

/*






 */