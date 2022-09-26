using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Text;
using System.IO;




namespace AstroBlaster
{
    public partial class AstroBlastr : Form
    {
        // Soundplayer object, nodig voor muziek afspelen
        System.Media.SoundPlayer music = new System.Media.SoundPlayer();

        //Objects
        private Som som = new Som();
        private Movement Movement = new Movement();
        private Speler Speler = new Speler();
        private Random rng = new Random();

        Button[] btn_Array = new Button[4];
        Pen pen = new Pen(Color.Transparent, 5);
        Color color = new Color();



        //GlobalVariables
        bool ResetMeteor;
        bool AnimateMeteor;
        bool RealDone;
        int GoodButton = -1;
        int Interval = 5;
        int CurrentTimer;
        int MovementTimerTicks;
        string PATH = @"TestText2.txt";

        int[] check_Array = new int[3];
        bool DRAW = false;
        bool TICK = false;


        public AstroBlastr()
        {
            InitializeComponent();
            MovementTimer.Interval = 1;
        }
        public void ButtonSetup()
        {
            RealDone = false;
            btn_Array[0] = btn_AntwoordL;
            btn_Array[1] = btn_AntwoordM;
            btn_Array[2] = btn_AntwoordR;
            check_Array = new int[3];
        }



        private void AstroBlastr_Load(object sender, EventArgs e)//moet uiteindelijk bij het drukken op START!
        {
            ButtonSetup();
        }

        public void SetSom()
        {
            lbl_Vraag.Text = som.GenerateRandomSom();
            int random = rng.Next(0, 3);

            List<int> FakeList = new List<int>();
            FakeList = FilterFakeAnwer();
            color = Color.White;

            for (int i = 0; i < btn_Array.Length - 1; i++)
            {
                btn_Array[i % btn_Array.Length].Text = Convert.ToString(FakeList[i]); //Nep antwoord
                btn_Array[i % btn_Array.Length].BackColor = Color.White;
            }
            btn_Array[random].Text = Convert.ToString(som.GetAnswer()); //echte antwoord

            //voor het debuggen is het antwoord rood. 
            //btn_Array[random].BackColor = Color.Red;
            GoodButton = random;
            random = rng.Next(0, 3);
            //btn_Array[random].BackColor = Color.Red;


        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            Start();
        }

        public void Die()
        {
            SpaceShip.Image = AstroBlaster.Properties.Resources.Explosion;
            MovementTimer.Stop();
            Restart.Visible = true;
            txb_Username.Visible = true;
            music.Stop();

            btn_AntwoordL.Enabled = false;
            btn_AntwoordM.Enabled = false;
            btn_AntwoordR.Enabled = false;

        }

        public void Start()
        {
            //properties true/false
            btn_Start.Visible = false;
            lbl_Vraag.Visible = true;
            lbl_Score.Visible = true;
            btn_Background.Visible = true;
            btn_AntwoordL.Visible = true;
            btn_AntwoordM.Visible = true;
            btn_AntwoordR.Visible = true;

            //execute methods
            ButtonSetup();
            SetSom();
            MovementTimer.Start();
            music.SoundLocation = "Astroblastr - Game Theme.wav";
            //play music
            PlayMusic();
        }
        public void CheckAnswer(int ButtonID)
        {
            if (GoodButton == ButtonID)
            {
                AddScore();
            }
            else
            {
                SubtractScore();
            }
            lbl_Score.Text = ("Score = " + Speler.Score);
            SetSom();
        }


        public bool DOWN = true;
        //nog te doen
        private void MovementTimer_Tick(object sender, EventArgs e)
        {
            SpaceShip.Location = Movement.MoveShip(SpaceShip.Location.X, SpaceShip.Location.Y);
            Meteor.Location = Movement.MoveMeteor(Meteor.Location.X, Meteor.Location.Y);
            if (Movement.CheckColision(SpaceShip.Location, Meteor.Location, SpaceShip.Size, Meteor.Size))
            {
                Die();
            }


            if (AnimateMeteor)
            {

                Explosion.Location = Meteor.Location;
                CurrentTimer = MovementTimerTicks;
                AnimateMeteor = false;
                ResetMeteor = true;
                Meteor.Location = Movement.SetMeteor(SpaceShip.Location);
                Meteor.Visible = false;
            }

            if (ResetMeteor)
            {
                if (MovementTimerTicks == (CurrentTimer + Interval))
                {
                    Explosion.Location = new Point(1116, 242);
                    Meteor.Visible = true;
                    Meteor.Image = AstroBlaster.Properties.Resources.Meteor;
                    ResetMeteor = false;
                }
            }

            MovementTimerTicks++;
        }


        //ook nog doen
        private void AstroBlastr_Paint(object sender, PaintEventArgs e)
        {
            Point rememberPoint1 = new Point(0, 0);
            Point rememberPoint2 = new Point(0, 0);
            Point pt1 = new Point(0, 0);
            Point pt2 = new Point(0, 0);
            pt1 = new Point((Size)Movement.ToHitSpaceShip(SpaceShip.Location, SpaceShip.Size.Width, SpaceShip.Size.Height));
            pt2 = new Point((Size)Movement.ToHitMeteor(Meteor.Location, Meteor.Size.Width, Meteor.Size.Height));
            if (DRAW)
            {
                pen = new Pen(Color.LightGreen, 5);
                this.BackgroundImage = AstroBlaster.Properties.Resources.Spacebackground;
                DRAW = false;
                rememberPoint1 = pt1;
                rememberPoint2 = pt2;
                CurrentTimer = MovementTimerTicks;
                TICK = true;
            }

            if (MovementTimerTicks == (CurrentTimer + Interval) && TICK)
            {
                pen = new Pen(Color.Transparent, 5);
                //pt1 = rememberPoint1;
                //pt2 = rememberPoint2;
                this.BackgroundImage = AstroBlaster.Properties.Resources.Spacebackground;
                TICK = false;
            }
            DRAW = false;

            e.Graphics.DrawLine(pen, pt1, pt2);
        }

        public void PlayMusic()
        {
            music.PlayLooping();
        }




        private void btn_AntwoordL_Click(object sender, EventArgs e)
        {
            CheckAnswer(0);
        }

        private void btn_AntwoordM_Click(object sender, EventArgs e)
        {
            CheckAnswer(1);
        }

        private void btn_AntwoordR_Click(object sender, EventArgs e)
        {
            CheckAnswer(2);
        }

        public List<int> FilterFakeAnwer()
        {
            List<int> list = new List<int>();
            int fake1 = som.GetFakeAnswer();
            int fake2 = som.GetFakeAnswer();
            int fake3 = som.GetFakeAnswer();

            int real = som.GetAnswer();

            while (
                   real == fake1
                || real == fake2
                || real == fake3
                || fake1 == fake2
                || fake1 == fake3
                || fake2 == fake3)
            {
                if (real == fake1)
                {
                    fake1++;
                }
                if (real == fake2)
                {
                    fake2++;
                }
                if (real == fake3)
                {
                    fake3++;
                }
                fake1 = (fake1 == fake2) ? fake1 + 3 : fake1;
                fake2 = (fake2 == fake3) ? fake2 + 5 : fake2;
                fake1 = (fake1 == fake3) ? fake1 + 1 : fake1;
            }
            list.Add(fake1);
            list.Add(fake2);
            list.Add(fake3);

            return list;
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            if (!txb_Username.Text.Contains(" ") && txb_Username.Text != null)
            {
                MessageBox.Show(txb_Username.Text + " heeft een score van " + Speler.Score);
            } 
            else
            {
                MessageBox.Show("Voer een valide naam in!");
                return;
            }
            Speler.SetName(txb_Username.Text);
            StringBuilder AllText = new StringBuilder();
            AllText.Append(File.ReadAllText(PATH));
            AllText.AppendLine(txb_Username.Text + "\t" + "." + Speler.Score + "\0");
            File.WriteAllText(PATH, AllText.ToString());



            this.Close();
        }

        public void SubtractScore()
        {
            if (Speler.Score >= -8)
            {
                Speler.SubstractPointToScore(7); //5 fout = 35 minpunten = 7 munten
                btn_Background.BackColor = Color.Red;
            }
            else
            {
                MessageBox.Show("Je hebt teveel vragen fout, Probeer het na wat oefening nog een keertje.");
                music.Stop();
                this.Close();
            }
            
        }

        public void AddScore()
        {
            DRAW = true;
            AnimateMeteor = true;
            Speler.AddPointToScore(5);//= 1 munt (7 goede antwoorden is 35 punten = 7munten
            Movement.SetSpeed(Speler.Score / 10);
            btn_Background.BackColor = Color.Green;
        }

        private void AstroBlastr_FormClosing(object sender, FormClosingEventArgs e)
        {
            music.Stop();
        }

        private void txb_Username_Click(object sender, EventArgs e)
        {
            txb_Username.Text = "";
        }
    }
}
