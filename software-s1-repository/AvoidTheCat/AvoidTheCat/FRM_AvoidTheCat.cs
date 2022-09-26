using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvoidTheCat
{
    enum Direction
    {
        Up,
        Upright,
        Right,
        Downright,
        Down,
        Downleft,
        Left,
        Upleft
    }

    public partial class FRM_AvoidTheCat : Form
    {
        public FRM_AvoidTheCat()
        {
            InitializeComponent();
        }

        // Objects
        Random rnd = new Random();
        PictureBox PB_Mouse;
        PictureBox PB_Dog;
        PictureBox PB_Cat;
        PictureBox PB_CatState;
        Mouse mouse;
        Dog dog;
        Cat cat;

        // Variables
        int interval = 0;

        // Events
        private void BTN_Start_Click(object sender, EventArgs e)
        {
            TMR_GameTime.Enabled = true;
            CreateDog();
            CreateCat();
            CreateMouse();
            BTN_Start.Visible = false;
        }
        private void TMR_GameTime_Tick(object sender, EventArgs e)
        {
            MouseMovement();
            CatMovement();
            DogMovement();
            FallAsleepWhen();
            if (CB_MouseInvincible.Text == "No")
            {
                KillMouse();
            }
            CountMouseAliveSeconds();
        }
        private void FRM_AvoidTheCat_MouseClick(object sender, MouseEventArgs e)
        {
            MouseEventArgs pointer = (MouseEventArgs)e;
            if (CB_Animal.Text == "Dog")
            {
                dog.ModifyLocation(pointer.X, pointer.Y);
            }
            if (CB_Animal.Text == "Cat")
            {
                cat.ModifyLocation(pointer.X, pointer.Y);
            }
            if (CB_Animal.Text == "Mouse")
            {
                mouse.ModifyLocation(pointer.X, pointer.Y);
            }
        }
        private void BTN_ApplyGameModifier_Click(object sender, EventArgs e)
        {
            TMR_GameTime.Interval = Convert.ToInt32(NUD_GameSpeed.Value);
        }
        private void NUD_DogSleepTime_ValueChanged(object sender, EventArgs e)
        {
            dog.ModifyWakeUpIn(Convert.ToInt32(NUD_DogSleepTime.Value * -1));
        }
        private void NUD_DogAwakeTime_ValueChanged(object sender, EventArgs e)
        {
            dog.ModifyFallingAsleepIn(Convert.ToInt32(NUD_DogAwakeTime.Value));
        }

        // Methods
        private void CreateDog()
        {
            dog = new Dog();

            PB_Dog = new PictureBox();
            PB_Dog.Location = new Point(dog.XLocation, dog.YLocation);
            PB_Dog.Size = new Size(dog.XSize, dog.YSize);
            PB_Dog.SizeMode = PictureBoxSizeMode.StretchImage;
            PB_Dog.Image = Properties.Resources.Dog;
            Controls.Add(PB_Dog);
        }
        private void CreateCat()
        {
            cat = new Cat();

            PB_Cat = new PictureBox();
            PB_Cat.Location = new Point(cat.XLocation, cat.YLocation);
            PB_Cat.Size = new Size(cat.XSize, cat.YSize);
            PB_Cat.SizeMode = PictureBoxSizeMode.StretchImage;
            PB_Cat.Image = Properties.Resources.Cat;
            Controls.Add(PB_Cat);

            // exclamation/questionmark
            PB_CatState = new PictureBox();
            PB_CatState.Location = new Point(cat.XLocation + cat.XSize / 4, cat.YLocation - cat.YSize / 2);
            PB_CatState.Size = new Size(cat.XSize / 2, cat.YSize / 2);
            PB_CatState.SizeMode = PictureBoxSizeMode.StretchImage;
            PB_CatState.Image = Properties.Resources.Exclamation_mark;
            Controls.Add(PB_CatState);
        }
        private void CreateMouse()
        {
            mouse = new Mouse();

            PB_Mouse = new PictureBox();
            PB_Mouse.Location = new Point(mouse.XLocation, mouse.YLocation);
            PB_Mouse.Size = new Size(mouse.XSize, mouse.YSize);
            PB_Mouse.SizeMode = PictureBoxSizeMode.StretchImage;
            PB_Mouse.Image = Properties.Resources.OokMuis;
            Controls.Add(PB_Mouse);
        }

        public void MouseMovement()
        {
            if (dog.Sleeping)
            {
                mouse.RunAwayMovement(cat.XLocation, cat.YLocation, cat.YSize, cat.XSize);
            }
            else
            {
                mouse.HideMovement(dog.XLocation, dog.YLocation);
            }

            // update location
            PB_Mouse.Location = new Point(mouse.XLocation, mouse.YLocation);
            LBL_MouseX.Text = "Mouse x: " + mouse.XLocation;
            LBL_MouseY.Text = "Mouse y: " + mouse.YLocation;
            LBL_CornerEscape.Text = "Mouse corner escape: " + mouse.CornerEsacpe;
        }
        public void CatMovement()
        {
            if (CheckCollisions(PB_Cat, PB_Dog)) // if cat collides with dog, move cat back
            {
                FixCatPositioningAfterCollision();
            }
            else // cat doesnt collide
            {
                if (!CheckCollisions(PB_Mouse, PB_Dog) || dog.Sleeping) // if mouse doesnt hide behind dog || dog sleeps, hunt mouse
                {
                    cat.Hunt(rnd, mouse.XLocation, mouse.YLocation);
                    LBL_CatHunting.Text = "Cat hunting: Yes";
                    PB_CatState.Image = Properties.Resources.Exclamation_mark;
                }
                else // move randomly
                {
                    cat.Movement(rnd);
                    LBL_CatHunting.Text = "Cat hunting: No";
                    PB_CatState.Image = Properties.Resources.Question_Mark;
                }
            }


            // update location
            PB_Cat.Location = new Point(cat.XLocation, cat.YLocation);
            PB_CatState .Location = new Point(cat.XLocation + cat.XSize / 4, cat.YLocation - cat.YSize / 2);
            LBL_CatX.Text = "Cat x: " + cat.XLocation;
            LBL_CatY.Text = "Cat y: " + cat.YLocation;
            LBL_CatMovementDirection.Text = "Cat movement direction: " + cat.Direction;

        }
        public void DogMovement()
        {
            dog.Movement(rnd);

            // update location
            PB_Dog.Location = new Point(dog.XLocation, dog.YLocation);
            LBL_DogX.Text = "Dog x: " + dog.XLocation;
            LBL_DogY.Text = "Dog y: " + dog.YLocation;
            LBL_DogMovementDirection.Text = "Dog movement direction: " + dog.Direction;
        }

        public bool CheckCollisions(PictureBox PB_One, PictureBox PB_Two)
        {
            return (PB_One.Bounds.IntersectsWith(PB_Two.Bounds));
        }

        public void FallAsleepWhen()
        {
            dog.FallingAsleepInMinusOne();
            if (dog.FallingAsleepIn == 0)
            {
                dog.FallAsleep();
                LBL_DogSleeping.Text = "Dog sleeping: Yes";
                PB_Dog.Image = Properties.Resources.SlapendeHond;
            }
            if (dog.FallingAsleepIn == dog.WakingUpIn)
            {
                dog.WakeUp(Convert.ToInt32(NUD_DogAwakeTime.Value));
                LBL_DogSleeping.Text = "Dog sleeping: No";
                PB_Dog.Image = Properties.Resources.Dog;
            }
            LBL_DogWakesUpIn.Text = "Dog wakes up in: " + dog.WakingUpIn;
            LBL_DogFallsAsleepIn.Text = "Dog falls asleep in: " + dog.FallingAsleepIn;
        }

        public void KillMouse()
        {
            if (CheckCollisions(PB_Cat, PB_Mouse))
            {
                mouse.Die();
                LBL_MouseDead.Text = "Mouse dead: Yes";
                PB_Mouse.Image = Properties.Resources.DeadMouse;
            }
        }

        private void FixCatPositioningAfterCollision()
        {
            if (cat.Direction == Direction.Up)
            {
                cat.MoveDown();
            }
            if (cat.Direction == Direction.Upright)
            {
                cat.MoveDownLeft();
            }
            if (cat.Direction == Direction.Right)
            {
                cat.MoveLeft();
            }
            if (cat.Direction == Direction.Downright)
            {
                cat.MoveUpLeft();
            }
            if (cat.Direction == Direction.Down)
            {
                cat.MoveUp();
            }
            if (cat.Direction == Direction.Downleft)
            {
                cat.MoveUpRight();
            }
            if (cat.Direction == Direction.Left)
            {
                cat.MoveRight();
            }
            if (cat.Direction == Direction.Upleft)
            {
                cat.MoveDownRight();
            }
        } // buggy, als de kat toevallig random beweegt en in de hond zit crossed die heel de hond waardoor de muis dood gaat

        public void CountMouseAliveSeconds()
        {
            if (interval == 15)
            {
                LBL_TimeSurvived.Text = "Time survived: " + mouse.SurvivedASecond();
                interval = 0;
            }
            interval++;
        }
    }
}

// volgende challange: laat muis veilig om kat heen rennen