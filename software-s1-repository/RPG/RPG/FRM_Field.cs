using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace RPG
{
    public partial class FRM_Field : Form
    {
        public FRM_Field()
        {
            InitializeComponent();
            CreatePlayer();
        }

        // Objects
        PictureBox PB_Amogus = new PictureBox();
        Dialogue dialogue = new Dialogue();
        Inventory inventory = new Inventory();
        Movement movement = new Movement();
        FRM_Meeting meeting = new FRM_Meeting();

        bool lockControls = false;
        int interactionsWithPink = 0;
        int interactionsWithYellow = 0;
        int movementSpeed = 6;
        bool currentlyRunning = false;
        int xPlayerLocation = 200;
        int yPlayerLocation = 200;
        bool showMessageOnce = true;
        bool pinkStartsMoving = false;
        int xPinkLocation = 204;
        int yPinkLocation = 463;

        // directie in een string doorgeven. null is geen directie
        string movementDirection = "Null";
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (!lockControls)
            {
                if (inventory.Run)
                {
                    if (keyData == Keys.Space)
                    {
                        currentlyRunning = !currentlyRunning;
                    }
                }

                if (currentlyRunning)
                {
                    LBL_Running.ForeColor = Color.Green;
                    LBL_Running.Text = "ON";
                    movementSpeed = 10;
                    // W,A,S,D
                    movementDirection = EditDirection(keyData);
                }
                else
                {
                    LBL_Running.ForeColor = Color.Red;
                    LBL_Running.Text = "OFF";
                    movementSpeed = 6;
                    // W,A,S,D
                    movementDirection = EditDirection(keyData);
                }

                // Leegt de dialogue label als je weg beweegt van de karakter waarmee je praat
                LBL_Dialogue.Text = "";
                showMessageOnce = true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void TMR_GameTime_Tick(object sender, EventArgs e)
        {
            //
            // INTERACTIONS
            //

            // AMOGUS PINK
            if (CheckCollisions(PB_Amogus, PB_AmogusPink))
            {
                // dialogue
                LBL_Dialogue.Text = dialogue.AmogusPink(interactionsWithPink, interactionsWithYellow);

                // obtain running
                if (interactionsWithPink == 0)
                {
                    RunningObtained();
                }
                // interaction with knife
                else if (interactionsWithPink > 0 && inventory.Knife)
                {
                    if (showMessageOnce)
                    {
                        showMessageOnce = false;
                        DialogResult dialogResult = MessageBox.Show("Kill Pink?", "Who's Sus?", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            PB_ImposterHasBeenKilled.Location = new Point(0, 0);
                            PB_ImposterHasBeenKilled.Visible = true;
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            LBL_Dialogue.Text = dialogue.AmogusPink(inventory.Knife); // displayt verkeerde text in run, niet in de debug
                            PB_PinkKillsRed.Visible = true;
                            GameOver();
                        }
                    }
                }
                // start meeting?
                else if (interactionsWithYellow > 0 && interactionsWithPink > 0)
                {
                    if (showMessageOnce)
                    {
                        showMessageOnce = false;
                        DialogResult dialogResult = MessageBox.Show("Start meeting?", "Who's Sus?", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            // start meeting vote out yellow
                            PB_PinkMeeting.Visible = true;
                            // moet eigenlijk gebeuren in meeting
                            LBL_Dialogue.Text = "Yellow got voted out, pink killed you after"; // werkt alleen als je steps gaat tellen in debug
                            PB_PinkKillsRed.Visible = true;
                            GameOver();
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            LBL_Dialogue.Text = dialogue.AmogusPink();
                        }
                    }
                }
                interactionsWithPink++;
            }

            // AMOGUS YELLOW
            if (CheckCollisions(PB_Amogus, PB_AmogusYellow))
            {
                // dialogue
                LBL_Dialogue.Text = dialogue.AmogusYellow(interactionsWithYellow, interactionsWithPink);

                // interaction with knife
                if (inventory.Knife)
                {
                    // kill?
                    if (showMessageOnce)
                    {
                        showMessageOnce = false;
                        DialogResult dialogResult = MessageBox.Show("Kill Yellow?", "Who's Sus?", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            LBL_Dialogue.Text = dialogue.AmogusYellow(inventory.Knife);
                            inventory.KnifeUsed();
                            PB_RedKillsYellow.Visible = true;
                            lockControls = true;
                            pinkStartsMoving = true;
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            LBL_Dialogue.Text = dialogue.AmogusYellow(inventory.Knife);
                            PB_YellowMeeting.Visible = true;

                            // moet eigenlijk in de meeting
                            LBL_Dialogue.Text = "You have been voted out.";
                            GameOver();
                        }
                    }
                }
                // start meeting?
                if (interactionsWithYellow > 0 && interactionsWithPink > 0)
                {
                    if (showMessageOnce)
                    {
                        showMessageOnce = false;
                        DialogResult dialogResult = MessageBox.Show("Start meeting?", "Who's Sus?", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            // start meeting vote out pink
                            PB_YellowMeeting.Visible = true;

                            // moet eigenlijk gebeuren in meeting
                            LBL_Dialogue.Text = "You and yellow voted out pink, pink was the imposter!";
                            MessageBox.Show("");
                            // bossbattle
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            LBL_Dialogue.Text = dialogue.AmogusYellow();
                        }
                    }
                }
                interactionsWithYellow++;
            }

            // KNIFE
            if (CheckCollisions(PB_Amogus, PB_Knife))
            {
                PB_Knife.Location = new Point(1231, 69);
                inventory.KnifeObtained();
            }

            //
            // COLLISIONS
            //

            if
            // karakters
            (CheckCollisions(PB_Amogus, PB_AmogusPink)
            || CheckCollisions(PB_Amogus, PB_AmogusYellow)
            // muren
            || CheckCollisions(PB_Amogus, PB_LeftWall)
            || CheckCollisions(PB_Amogus, PB_UpWall)
            || CheckCollisions(PB_Amogus, PB_RightWall)
            || CheckCollisions(PB_Amogus, PB_DownWall)
            || CheckCollisions(PB_Amogus, PB_LeftRightWall)
            )
            {
                // savet hoe de block het object heeft geraakt
                string movementBuffer = movementDirection;
                movementDirection = "Null";
                yPlayerLocation = movement.FixPositioningAfterCollision(movementBuffer, movementSpeed, yPlayerLocation);
                xPlayerLocation = movement.FixPositioningAfterCollision(movementSpeed, xPlayerLocation, movementBuffer);
            }

            //
            // MOVEMENT
            //

            yPlayerLocation = movement.EditLocation(yPlayerLocation, movementSpeed, movementDirection);
            xPlayerLocation = movement.EditLocation(xPlayerLocation, movementDirection, movementSpeed);

            // update location
            PB_Amogus.Location = new Point(xPlayerLocation, yPlayerLocation);

            // pink spots you killing yellow
            if (pinkStartsMoving)
            {
                if (yPinkLocation > 135)
                {
                    yPinkLocation = yPinkLocation - 5;
                }
                else if (xPinkLocation < 360)
                {
                    xPinkLocation = xPinkLocation + 5;
                    if (xPinkLocation >340)
                    {
                        PB_PinkMeeting.Visible = true;
                        LBL_Dialogue.Text = dialogue.AmogusPink(inventory.Knife);
                    }
                }
                else
                {
                    StartMeeting();
                }
                // update pink location
                PB_AmogusPink.Location = new Point(xPinkLocation, yPinkLocation);
            }

        } // TMR_Movement_Tick

        //
        // METHODS
        //

        public void CreatePlayer()
        {
            PB_Amogus.Location = new Point(xPlayerLocation, yPlayerLocation);
            PB_Amogus.Image = Image.FromFile("Amogus_Red.png");
            PB_Amogus.Size = new Size(64, 64);
            Controls.Add(PB_Amogus);
        } // CreatePlayer

        public void GameOver()
        {
            Controls.Remove(PB_Amogus);
            lockControls = true;
        } // GameOver

        public void RunningObtained()
        {
            inventory.RunningObtained();
            PB_Run.Visible = true;
            LBL_Running.Visible = true;
            LBL_Abilities.Visible = true;
        } // RunningObtained

        public void StartMeeting()
        {
            Thread.Sleep(1000); // delay 1000 ms
            this.Close();
            meeting.Show();
        } // StartMeeting

        // 
        // COLLISION METHODS
        //

        public bool CheckCollisions(PictureBox PB_Amogus, PictureBox PB_OtherObject)
        {
            return (PB_Amogus.Bounds.IntersectsWith(PB_OtherObject.Bounds));
        } // CheckCollisions

        // 
        // MOVEMENT METHODS
        //

        public string EditDirection(Keys keyData)
        {
            // Up
            if (keyData == Keys.W)
            {
                movementDirection = "Up";
            }
            // Left
            else if (keyData == Keys.A)
            {
                movementDirection = "Left";
            }
            // Down
            else if (keyData == Keys.S)
            {
                movementDirection = "Down";
            }
            // Right
            else if (keyData == Keys.D)
            {
                movementDirection = "Right";
            }
            else
            {
                movementDirection = "Null";
            }
            return movementDirection;
        } // EditDirection
    }
}

/*
BUGS


 yellow moves toward player logic
if xplayerlocation < yellow x move left
otherwise move right
every moement switch from x or y OR which difference is larger there he moves first

1231 69
 */