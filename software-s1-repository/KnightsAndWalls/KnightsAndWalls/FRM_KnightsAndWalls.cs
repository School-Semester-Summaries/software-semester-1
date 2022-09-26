using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnightsAndWalls
{
    public partial class FRM_KnightsAndWalls : Form
    {
        public FRM_KnightsAndWalls()
        {
            InitializeComponent();
        }

        // Variables
        int xImageLocation;
        int yImageLocation;

        List<Wall> wallList = new List<Wall>();
        List<PictureBox> wallPictureboxList = new List<PictureBox>();

        List<Cannon> cannonList = new List<Cannon>();
        List<PictureBox> cannonPictureboxList = new List<PictureBox>();

        List<Townhall> townhallList = new List<Townhall>();
        List<PictureBox> townhallPictureboxList = new List<PictureBox>();

        List<Swordsman> swordsmanList = new List<Swordsman>();
        List<PictureBox> swordsmanPictureboxList = new List<PictureBox>();

        List<Bodyguard> bodyguardList = new List<Bodyguard>();
        List<PictureBox> bodyguardPictureboxList = new List<PictureBox>();

        // Events
        private void FRM_KnightsAndWalls_MouseClick(object sender, MouseEventArgs e)
        {
            TB_MouseLocation.Text = "(" + Cursor.Position.X + ", " + Cursor.Position.Y + ")";
            CursorGrid();
            CreatePictureBox();
        }
        private void TMR_GameTime_Tick(object sender, EventArgs e)
        {
            ChangeGamemode();
            SwordsmanMovement();
            BodyguardMovement();
            for (int i = 0; i < swordsmanList.Count; i++)
            {
                UpdateLocations(swordsmanPictureboxList[i], swordsmanList[i].XLocation, swordsmanList[i].YLocation);
            }
            for (int i = 0; i < bodyguardList.Count; i++)
            {
                UpdateLocations(bodyguardPictureboxList[i], bodyguardList[i].XLocation, bodyguardList[i].YLocation);
            }
            SwordsmanDealDamage();
            BodyguardDealDamage();

            CannonShoot();
        }
        private void PB_Undo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Doesn't work yet");
            // remove the thing that has been added as last
        }
        private void BTN_Clear_Click(object sender, EventArgs e)
        {
            for (int ii = 0; ii < cannonList.Count; ii++)
            {
                Controls.Remove(cannonPictureboxList[ii]);
                cannonList.RemoveAt(ii);
                cannonPictureboxList.RemoveAt(ii);
                ii--;
            }
            for (int ii = 0; ii < wallList.Count; ii++)
            {
                Controls.Remove(wallPictureboxList[ii]);
                wallList.RemoveAt(ii);
                wallPictureboxList.RemoveAt(ii);
                ii--;
            }
            for (int ii = 0; ii < swordsmanList.Count; ii++)
            {
                Controls.Remove(swordsmanPictureboxList[ii]);
                swordsmanList.RemoveAt(ii);
                swordsmanPictureboxList.RemoveAt(ii);
                ii--;
            }
            for (int ii = 0; ii < bodyguardList.Count; ii++)
            {
                Controls.Remove(bodyguardPictureboxList[ii]);
                bodyguardList.RemoveAt(ii);
                bodyguardPictureboxList.RemoveAt(ii);
                ii--;
            }
        }


        // Methods
        private void BodyguardMovement()
        {
            for (int i = 0; i < bodyguardList.Count; i++)
            {
              bodyguardList[i].SetTarget(cannonList, townhallList);
              bodyguardList[i].StartMoving();

                for (int ii = 0; ii < cannonList.Count; ii++)
                {
                    if (CheckCollisions(bodyguardPictureboxList[i], cannonPictureboxList[ii]))
                    {
                        bodyguardList[i].StopMoving();
                    }
                }
                for (int ii = 0; ii < wallList.Count; ii++)
                {
                    if (CheckCollisions(bodyguardPictureboxList[i], wallPictureboxList[ii]))
                    {
                        bodyguardList[i].StopMoving();
                    }
                }
                for (int ii = 0; ii < townhallList.Count; ii++)
                {
                    if (CheckCollisions(bodyguardPictureboxList[i], townhallPictureboxList[ii]))
                    {
                        bodyguardList[i].StopMoving();
                    }
                }
                bodyguardList[i].HuntTarget();
            }
        }
        public void BodyguardDealDamage()
        {
            /*
            [BodyguardDealDamage EXPLAINED]
            kijk [SwordsmanDealDamage EXPLAINED]
            */ 
            for (int i = 0; i < bodyguardList.Count; i++)
            {
                for (int ii = 0; ii < cannonList.Count; ii++)
                {
                    if (CheckCollisions(bodyguardPictureboxList[i], cannonPictureboxList[ii]))
                    {
                        cannonList[ii].LoseHealth(bodyguardList[i].AttackPower);
                        LBL_CannonHealth.Text = "Cannon health: " + cannonList[ii].Health.ToString();

                        if (cannonList[ii].Health <= 0)
                        {
                            Controls.Remove(cannonPictureboxList[ii]);
                            cannonList.RemoveAt(ii);
                            cannonPictureboxList.RemoveAt(ii);
                            ii--;
                        }
                    }
                }
                for (int ii = 0; ii < wallList.Count; ii++)
                {
                    if (CheckCollisions(bodyguardPictureboxList[i], wallPictureboxList[ii]))
                    {
                        wallList[ii].LoseHealth(bodyguardList[i].AttackPower);
                        LBL_Wall.Text = "Wall health: " + wallList[ii].Health.ToString();

                        if (wallList[ii].Health <= 0)
                        {
                            Controls.Remove(wallPictureboxList[ii]);
                            wallList.RemoveAt(ii);
                            wallPictureboxList.RemoveAt(ii);
                            ii--;
                        }
                    }
                }
                for (int ii = 0; ii < townhallList.Count; ii++)
                {
                    if (CheckCollisions(bodyguardPictureboxList[i], townhallPictureboxList[ii]))
                    {
                        townhallList[ii].LoseHealth(bodyguardList[i].AttackPower);
                        LBL_Townhall.Text = "Townhall health: " + townhallList[ii].Health.ToString();

                        if (townhallList[ii].Health <= 0)
                        {
                            Controls.Remove(townhallPictureboxList[ii]);
                            townhallList.RemoveAt(ii);
                            townhallPictureboxList.RemoveAt(ii);
                            ii--;
                        }
                    }
                }
            }
        }

        private void SwordsmanMovement()
        {
            /*
            [SwordsmanMovement EXPLAINED]
            1. for loop die kijkt per swordsman
            2. [SetTarget EXPLAINED]
            3. StartMoving: zet swordslist.moving op true
            4. kijk per cannon, of dat swordsman en cannon colliden, if so, swordsman stopt met bewegen
            5. HuntTarget: heel easy, als moving true is, dan gaat swordsman target hunten hoe doet die dat? als target x groter is dan eigen x move rechts enz kijk maar even naar de method zelf
            */
            for (int i = 0; i < swordsmanList.Count; i++)
            {
                swordsmanList[i].SetTarget(cannonList, townhallList);
                swordsmanList[i].StartMoving();

                for (int ii = 0; ii < cannonList.Count; ii++)
                {
                    if (CheckCollisions(swordsmanPictureboxList[i], cannonPictureboxList[ii]))
                    {
                        swordsmanList[i].StopMoving();
                    }
                }
                for (int ii = 0; ii < wallList.Count; ii++)
                {
                    if (CheckCollisions(swordsmanPictureboxList[i], wallPictureboxList[ii]))
                    {
                        swordsmanList[i].StopMoving();
                    }
                }
                for (int ii = 0; ii < townhallList.Count; ii++)
                {
                    if (CheckCollisions(swordsmanPictureboxList[i], townhallPictureboxList[ii]))
                    {
                        swordsmanList[i].StopMoving();
                    }
                }
                swordsmanList[i].HuntTarget();
            }
        }
        public void SwordsmanDealDamage()
        {
            /*
            [SwordsmanDealDamage EXPLAINED]
            1. for loop die per swordsman kijkt
            2. for loop die per cannon kijkt in de swordsman for loop
            3. Als er collision plaats vind tussen cannon en swordsman, dan verliest cannon health met LoseHealth, de attackpower van de unit wordt van de cannon zijn health afgehaald
            4. Update de label voor debug menu
            5. als de cannon geen health meer heeft wordt die verwijderd
            6. de i--; zorgt ervoor dat die elke object in de list na gaat, want als iets uit een list verwijderd wordt komt de volgende object in zijn plaats, zonder i-- zou de volgende object worden overgeslagen

            [ISSUE]
            !. DealDamageTo methods zijn best wel hardcoded, zoek hier een oplossing voor, misschien kun je ipv deal damage naar iedereen, lose health bij elke building apart doen, YOU CAM DO THIS ~ Kaan Gogcay 26/07/2021
            */
            for (int i = 0; i < swordsmanList.Count; i++)
            {
                for (int ii = 0; ii < cannonList.Count; ii++)
                {
                    if (CheckCollisions(swordsmanPictureboxList[i], cannonPictureboxList[ii]))
                    {
                        cannonList[ii].LoseHealth(swordsmanList[i].AttackPower);
                        LBL_CannonHealth.Text = "Cannon health: " + cannonList[ii].Health.ToString();

                        if (cannonList[ii].Health <= 0)
                        {
                            Controls.Remove(cannonPictureboxList[ii]);
                            cannonList.RemoveAt(ii);
                            cannonPictureboxList.RemoveAt(ii);
                            ii--;
                        } 
                    }
                }
                for (int ii = 0; ii < wallList.Count; ii++)
                {
                    if (CheckCollisions(swordsmanPictureboxList[i], wallPictureboxList[ii]))
                    {
                        wallList[ii].LoseHealth(swordsmanList[i].AttackPower);
                        LBL_Wall.Text = "Wall health: " + wallList[ii].Health.ToString();

                        if (wallList[ii].Health <= 0)
                        {
                            Controls.Remove(wallPictureboxList[ii]);
                            wallList.RemoveAt(ii);
                            wallPictureboxList.RemoveAt(ii);
                            ii--;
                        }
                    }
                }
                for (int ii = 0; ii < townhallList.Count; ii++)
                {
                    if (CheckCollisions(swordsmanPictureboxList[i], townhallPictureboxList[ii]))
                    {
                        townhallList[ii].LoseHealth(swordsmanList[i].AttackPower);
                        LBL_Townhall.Text = "Townhall health: " + townhallList[ii].Health.ToString();

                        if (townhallList[ii].Health <= 0)
                        {
                            Controls.Remove(townhallPictureboxList[ii]);
                            townhallList.RemoveAt(ii);
                            townhallPictureboxList.RemoveAt(ii);
                            ii--;
                        }
                    }
                }
            }
        }

        public void CursorGrid()
        {
            /*
            [CursorGrid EXPLAINED]
            1. xImageLocation wordt gelijk gesteld aan cursorX, als je klikt op de form
            2. de x locatie wordt gestopt binnen de volgende waardes {0, 50, 100, 150} erg simpel kijk maar hieronder
            */ 
            xImageLocation = Cursor.Position.X;
            if (xImageLocation < 50)
            {
                xImageLocation = 0;
            }
            else if (xImageLocation < 100)
            {
                xImageLocation = 50;
            }
            else if (xImageLocation < 150)
            {
                xImageLocation = 100;
            }
            else if (xImageLocation < 200)
            {
                xImageLocation = 150;
            }
            else if (xImageLocation < 250)
            {
                xImageLocation = 200;
            }
            else if (xImageLocation < 300)
            {
                xImageLocation = 250;
            }
            else if (xImageLocation < 350)
            {
                xImageLocation = 300;
            }
            else if (xImageLocation < 400)
            {
                xImageLocation = 350;
            }
            else if (xImageLocation < 450)
            {
                xImageLocation = 400;
            }
            else if (xImageLocation < 500)
            {
                xImageLocation = 450;
            }
            else if (xImageLocation < 550)
            {
                xImageLocation = 500;
            }
            else if (xImageLocation < 600)
            {
                xImageLocation = 550;
            }
            else if (xImageLocation < 650)
            {
                xImageLocation = 600;
            }

            yImageLocation = Cursor.Position.Y;
            if (yImageLocation < 50)
            {
                yImageLocation = 0;
            }
            else if (yImageLocation < 100)
            {
                yImageLocation = 50;
            }
            else if (yImageLocation < 150)
            {
                yImageLocation = 100;
            }
            else if (yImageLocation < 200)
            {
                yImageLocation = 150;
            }
            else if (yImageLocation < 250)
            {
                yImageLocation = 200;
            }
            else if (yImageLocation < 300)
            {
                yImageLocation = 250;
            }
            else if (yImageLocation < 350)
            {
                yImageLocation = 300;
            }
        }

        public void ChangeGamemode()
        {
            if (RB_Build.Checked)
            {
                GB_BuildMode.Enabled = true;
                GB_AttackMode.Enabled = false;
            }
            else if (RB_Attack.Checked)
            {
                GB_BuildMode.Enabled = false;
                GB_AttackMode.Enabled = true;
            }
        }

        public void CreatePictureBox()
        {
            PictureBox image = new PictureBox();
            image.Location = new Point(xImageLocation, yImageLocation);
            image.BorderStyle = BorderStyle.FixedSingle;

            BuildRightObject(image);

            Controls.Add(image);
        }
        public void BuildRightObject(PictureBox image)
        {
            if (GB_BuildMode.Enabled)
            {
                if (RB_Wall.Checked)
                {
                    CreateWall(image);
                }
                else if (RB_Cannon.Checked)
                {
                    CreateCannon(image);
                }
                else if (RB_Townhall.Checked)
                {
                    CreateTownhall(image);
                }
            }
            else if (GB_AttackMode.Enabled)
            {
                if (RB_Swordsman.Checked)
                {
                    CreateSwordsman(image);
                }
                else if (RB_Bodyguard.Checked)
                {
                    CreateBodyguard(image);
                }
            }
        }
        public void CreateWall(PictureBox image)
        {
            Wall wall = new Wall();
            wall.SetLocation(xImageLocation, yImageLocation);
            wallList.Add(wall);
            wallPictureboxList.Add(image);

            image.BackColor = Color.Brown;
            image.Image = Properties.Resources.Wooden_Wall;
            image.SizeMode = PictureBoxSizeMode.StretchImage;
            image.Size = new Size(wall.XSize, wall.YSize);
        }
        public void CreateCannon(PictureBox image)
        {
            Cannon cannon = new Cannon();
            cannon.SetLocation(xImageLocation, yImageLocation);
            cannonList.Add(cannon);
            cannonPictureboxList.Add(image);

            image.BackColor = Color.Transparent;
            //image.Image = Properties.Resources.Cannon;
            image.Image = Properties.Resources.CannonLv6;
            image.SizeMode = PictureBoxSizeMode.StretchImage;
            image.Size = new Size(cannon.XSize, cannon.YSize);
        }
        public void CreateTownhall(PictureBox image)
        {
            Townhall townhall = new Townhall();
            townhall.SetLocation(xImageLocation, yImageLocation);
            townhallList.Add(townhall);
            townhallPictureboxList.Add(image);

            image.BackColor = Color.Transparent;
            image.Image = Properties.Resources.townhall;
            image.SizeMode = PictureBoxSizeMode.StretchImage;
            image.Size = new Size(townhall.XSize, townhall.YSize);
        }
        public void CreateSwordsman(PictureBox image)
        {
            Swordsman swordsman = new Swordsman();
            swordsman.SetLocation(xImageLocation, yImageLocation);
            swordsmanList.Add(swordsman);
            swordsmanPictureboxList.Add(image);

            image.BackColor = Color.Transparent;
            //image.Image = Properties.Resources.Swordsman;
            image.Image = Properties.Resources.Barbarian;
            image.SizeMode = PictureBoxSizeMode.StretchImage;
            image.Size = new Size(swordsman.XSize, swordsman.YSize);
        }
        public void CreateBodyguard(PictureBox image)
        {
            Bodyguard bodyguard = new Bodyguard();
            bodyguard.SetLocation(xImageLocation, yImageLocation);
            bodyguardList.Add(bodyguard);
            bodyguardPictureboxList.Add(image);

            image.BackColor = Color.Transparent;
            //image.Image = Properties.Resources.Bodyguard;
            image.Image = Properties.Resources.Giant;
            image.SizeMode = PictureBoxSizeMode.StretchImage;
            image.Size = new Size(bodyguard.XSize, bodyguard.YSize);
        }

        public void CannonShoot()
        {
            /*
            [CannonShoot EXPLAINED]
            1. reken x en y afstand uit van swordman/bodyguard tot cannon
            2. is de afstand <= cannon.range dan gaat de cannon schieten
            3. update labels voor debug menu
            4. als de strijder geen health heeft wordt die verwijderd

            [ISSUE]
            !. cannon is multitarget maar hoort single target te zijn
            */
            for (int i = 0; i < cannonList.Count; i++)
            {
                for (int ii = 0; ii < swordsmanList.Count; ii++)
                {
                    int xDistance = Math.Abs(swordsmanList[ii].XCenter - cannonList[i].XCenter);
                    int yDistance = Math.Abs(swordsmanList[ii].YCenter - cannonList[i].YCenter);

                    if (xDistance <= cannonList[i].Range && yDistance <= cannonList[i].Range)
                    {
                        cannonList[i].Shoot(swordsmanList, bodyguardList);
                        LBL_SwordsmanHealth.Text = "Swordsman health: " + swordsmanList[ii].Health;

                        if (swordsmanList[ii].Health <= 0)
                        {
                            Controls.Remove(swordsmanPictureboxList[ii]);
                            swordsmanList.RemoveAt(ii);
                            swordsmanPictureboxList.RemoveAt(ii);
                            ii--;
                        }
                    }
                }
            }
            for (int i = 0; i < cannonList.Count; i++)
            {
                for (int ii = 0; ii < bodyguardList.Count; ii++)
                {
                    int xDistance = Math.Abs(bodyguardList[ii].XCenter - cannonList[i].XCenter);
                    int yDistance = Math.Abs(bodyguardList[ii].YCenter - cannonList[i].YCenter);

                    if (xDistance <= cannonList[i].Range && yDistance <= cannonList[i].Range)
                    {
                        cannonList[i].Shoot(swordsmanList, bodyguardList);
                        LBL_Bodyguard.Text = "Bodyguard health: " + bodyguardList[ii].Health;

                        if (bodyguardList[ii].Health <= 0)
                        {
                            Controls.Remove(bodyguardPictureboxList[ii]);
                            bodyguardList.RemoveAt(ii);
                            bodyguardPictureboxList.RemoveAt(ii);
                            ii--;
                        }
                    }
                }
            }
        }

        // Beautiful Methods
        public void UpdateLocations(PictureBox pictureBox, int xLocation, int yLocation)
        {
            pictureBox.Location = new Point(xLocation, yLocation);
        }
        public bool CheckCollisions(PictureBox PB_One, PictureBox PB_Two)
        {
            return (PB_One.Bounds.IntersectsWith(PB_Two.Bounds));
        }
    }
}
/*
 Doelen

1. bodyguard moet canon targeten
- werkt maar swordsman target nu ook cannon, ik wil in de variable target meerdere classes kunnen stoppen. HOE
2. swordsman moet alles targeten
- is mogelijk maar dan wordt de code heel inefficient
*Oplossing voor beiden is een beter method maken? method anders aanpakken?
3. Canon moet 1 ding tegelijk targeten

logic explained
swordsman loopt richting dichtbijzijnde building, (uitrekenen met pythagoras)
als hij met iets collide, 
dan stopt hij 
maakt hij het kapot 
en gaat hij verder

TO DO
uitvinden hoe je meerdere dingen kunt targeten, anders moet ik iets doen als, 
closest cannon en closest towwnhall en dan vergelijken welke dichterbij staat
cannons dont shoot

TIPS VOOR VOLGEND PROJECT
gebruik overal doubles geen ints
*/
