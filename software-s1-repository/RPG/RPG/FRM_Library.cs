using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG
{
    public partial class FRM_RPG : Form
    {

        public FRM_RPG()
        {
            InitializeComponent();
            CreatePlayer();
        }

        // Objects
        PictureBox PB_Amogus = new PictureBox();
        Dialogue dialogue = new Dialogue();
        Inventory inventory = new Inventory();
        FRM_Field field = new FRM_Field();
        Movement movement = new Movement();

        // directie in een string doorgeven. null is geen directie
        string movementDirection = "Null";

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // W,A,S,D
            movementDirection = EditDirection(keyData);

            // Leegt de dialogue label als je weg beweegt van de karakter waarmee je praat
            LBL_Dialogue.Text = "";

            return base.ProcessCmdKey(ref msg, keyData);
        }

        bool firstTimeInteractingWithBlue = true;
        bool firstTimeInteractingWithGreen = true;
        const int movementSpeed = 3;
        // locatie speler
        static int xPlayerLocation = 200;
        static int yPlayerLocation = 200;
        

        private void TMR_Movement_Tick(object sender, EventArgs e)
        {
            //
            // INTERACTIONS
            //

            // DIALOGUE AMOGUS BLUE
            if (CheckCollisions(PB_Amogus, PB_AmogusBlue))
            {
                // code om in een keer naar field te gaan fijn voor debuggen
                //this.Hide();
                //field.Show();

                // display dialogue met amogus blue
                LBL_Dialogue.Text = dialogue.AmogusBlue(firstTimeInteractingWithBlue, inventory.Key);
                // daarbij horende events
                if (firstTimeInteractingWithBlue)
                {
                    inventory.KeyObtained();
                    PB_Key.Visible = true;
                }
                firstTimeInteractingWithBlue = false;
            }

            // DIALOGUE AMOGUS GREEN
            if (CheckCollisions(PB_Amogus, PB_AmogusGreen))
            {
                // display dialogue met amogus green
                LBL_Dialogue.Text = dialogue.AmogusGreen(firstTimeInteractingWithGreen, inventory.Key);
                // daarbij horende events
                if (firstTimeInteractingWithGreen)
                {
                    inventory.KeyObtained();
                    PB_Key.Visible = true;
                }
                firstTimeInteractingWithGreen = false;
            }

            // DOWN LOCKED WALL
            if (CheckCollisions(PB_Amogus, PB_DownLockedWall) && inventory.Key)
            {
                PB_DownLockedWall.Location = new Point(-100, -100);
                inventory.KeyUsed();
                PB_Key.Visible = false;
            }

            // UP RIGHT LOCKED WALL
            if (CheckCollisions(PB_Amogus, PB_UpRightLockedWall) && inventory.Key)
            {
                PB_UpRightLockedWall.Location = new Point(-100, -100);
                inventory.KeyUsed();
                PB_Key.Visible = false;
            }

            // PB_INVENTORY
            if (CheckCollisions(PB_Amogus, PB_Inventory))
            {
                this.Hide();
                field.Show();
            }

            //
            // COLLISIONS
            //

            // NEUTRAL
            if
                // karakters
                (  CheckCollisions(PB_Amogus, PB_AmogusBlue)
                || CheckCollisions(PB_Amogus, PB_AmogusGreen)
                // muren
                || CheckCollisions(PB_Amogus, PB_LeftWall)
                || CheckCollisions(PB_Amogus, PB_RightUpWall)
                || CheckCollisions(PB_Amogus, PB_UpperWall)
                || CheckCollisions(PB_Amogus, PB_MidLeftLeftWall)
                || CheckCollisions(PB_Amogus, PB_MidLeftRightWall)
                || CheckCollisions(PB_Amogus, PB_MidUpDownWall)
                || CheckCollisions(PB_Amogus, PB_DownWall)
                || CheckCollisions(PB_Amogus, PB_RightWall)
                // sloten
                || CheckCollisions(PB_Amogus, PB_DownLockedWall)
                || CheckCollisions(PB_Amogus, PB_UpRightLockedWall)
                )
            {
                // savet hoe de block het object heeft geraakt
                string movementBuffer = movementDirection;
                movementDirection = "Null";
                // fix player location values after collision
                yPlayerLocation = movement.FixPositioningAfterCollision(movementBuffer, movementSpeed, yPlayerLocation);
                xPlayerLocation = movement.FixPositioningAfterCollision(movementSpeed, xPlayerLocation ,movementBuffer);
            }

            // KILLS
            if 
                (  CheckCollisions(PB_Amogus, PB_UpRightLava)
                || CheckCollisions(PB_Amogus, PB_UpLava)
                || CheckCollisions(PB_Amogus, PB_UpLeftLava)
                || CheckCollisions(PB_Amogus, PB_DownLava)
                || CheckCollisions(PB_Amogus, PB_DownRightLava)
                )
            {
                // respawn
                xPlayerLocation = 200;
                yPlayerLocation = 200;
                movementDirection = "Null";
            }

            //
            // MOVEMENT
            //

            yPlayerLocation = movement.EditLocation(yPlayerLocation, movementSpeed, movementDirection);
            xPlayerLocation = movement.EditLocation(xPlayerLocation, movementDirection, movementSpeed);

            // update location
            PB_Amogus.Location = new Point(xPlayerLocation, yPlayerLocation);
        }

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

        // 
        // COLLISION METHODS
        //

        public void FixPositioningAfterCollision(string movementBuffer)
        {
            const int fixPositioning = movementSpeed + 1;

            if (movementBuffer == "Up")
            {
                yPlayerLocation = yPlayerLocation + fixPositioning;
            }
            else if (movementBuffer == "Left")
            {
                xPlayerLocation = xPlayerLocation + fixPositioning;
            }
            else if (movementBuffer == "Down")
            {
                yPlayerLocation = yPlayerLocation - fixPositioning;
            }
            else if (movementBuffer == "Right")
            {
                xPlayerLocation = xPlayerLocation - fixPositioning;
            }
        } // kan in method?

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

IDEAS
Construcots gebruiken voor enemies generaten

 */
