using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EendenVijver
{
    public enum Geslacht
    {
        Man,
        Vrouw
    }

    public enum Direction
    {
        Up,
        Left,
        Right,
        Down
    }

    public partial class FRM_EendenVijver : Form
    {
        public FRM_EendenVijver()
        {
            InitializeComponent();
        }

        // Objects
        Random rnd = new Random();

        Eend[] arrayEend = new Eend[aantalEenden];
        Kikker[] arrayKikker = new Kikker[aantalKikkers];
        Ooievaar[] arrayOoievaar = new Ooievaar[aantalOoievaars];

        PictureBox[] EendPictureBoxArray = new PictureBox[aantalEenden];
        PictureBox[] KikkerPictureBoxArray = new PictureBox[aantalKikkers];
        PictureBox[] OoievaarPictureBoxArray = new PictureBox[aantalOoievaars];

        Eend OBJ_Eend = new Eend();
        Kikker OBJ_Kikker = new Kikker();
        Ooievaar OBJ_Ooievaar = new Ooievaar();
        Kikker kikker = new Kikker();

        // Aantal dieren per dier
        const int aantalEenden = 100;
        const int aantalKikkers = 50;
        const int aantalOoievaars = 1;
        // snelheid van de simulatie
        const int normalSpeed = 100;
        const int FastSpeed = 25;
        const int slowSpeed = 400;

        int overgeblevenKikkers = aantalKikkers;
        /*
        int x = 0;
        int y= 0;
        
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.W)
            {
                if (y != 0)
                {
                    y = y - 50;
                }
            }
            if (keyData == Keys.A)
            {
                x = x - 50;
            }
            if (keyData == Keys.S)
            {
                y = y + 50;
            }
            if (keyData == Keys.D)
            {
                x = x + 50;
            }
            PB_Player.Location = new Point(x, y);
            return base.ProcessCmdKey(ref msg, keyData);
        }
        */

        // Buttons
        private void BTN_Spawn_Click(object sender, EventArgs e)
        {
            MaakEenden();
            MaakKikkers();
            MaakOoievaars();
            TB_Eend.Text = "Eenden: " + aantalEenden.ToString();
            TB_Kikker.Text = "Kikkers " + aantalKikkers.ToString();
            TB_Ooievaar.Text = "Ooievaars " + aantalOoievaars.ToString();
            BTN_Spawn.Enabled = false;
            TMR_Movement.Enabled = true;
        }
        private void BTN_LangzaamSpeed_Click(object sender, EventArgs e)
        {
            TMR_Movement.Interval = slowSpeed;
        }
        private void BTN_NormaalSpeed_Click(object sender, EventArgs e)
        {
            TMR_Movement.Interval = normalSpeed;
        }
        private void BTN_SnelSpeed_Click(object sender, EventArgs e)
        {
            TMR_Movement.Interval = FastSpeed;
        }

        // Timers
        private void TMR_Movement_Tick(object sender, EventArgs e)
        {
            OBJ_Eend.EendMovement(rnd, aantalEenden, arrayEend);
            OBJ_Kikker.KikkerMovement(rnd, aantalKikkers, arrayKikker);
            OBJ_Ooievaar.AdvancedMovement(rnd, aantalOoievaars, arrayOoievaar, aantalKikkers, arrayKikker, OBJ_Ooievaar.SetTarget(arrayOoievaar, arrayKikker, aantalKikkers));
            FrogsHide();
            UpdateLocations();
            EetKikker();
        }

        // Methods
        public void MaakEenden()
        {
            for (int i = 0; i < aantalEenden; i++)
            {
                PictureBox PB_Eend = new PictureBox();
                EendPictureBoxArray[i] = PB_Eend;

                Eend eend = new Eend(rnd);
                arrayEend[i] = eend;

                AddEend(eend, PB_Eend, eend.Geslacht);
                LB_Eenden.Items.Add(eend.Geslacht);
            }
        }
        public void MaakKikkers()
        {
            for (int i = 0; i < aantalKikkers; i++)
            {
                PictureBox PB_Kikker = new PictureBox();
                KikkerPictureBoxArray[i] = PB_Kikker;

                Kikker kikker = new Kikker(rnd);
                arrayKikker[i] = kikker;

                AddKikker(kikker, PB_Kikker, kikker.Geslacht);
                LB_Kikkers.Items.Add(kikker);
            }
        }
        public void MaakOoievaars()
        {
            for (int i = 0; i < aantalOoievaars; i++)
            {
                PictureBox PB_Ooievaar = new PictureBox();
                OoievaarPictureBoxArray[i] = PB_Ooievaar;

                Ooievaar ooievaar = new Ooievaar(rnd);
                arrayOoievaar[i] = ooievaar;

                AddOoievaar(ooievaar, PB_Ooievaar, ooievaar.Geslacht);
                LB_Ooievaar.Items.Add(ooievaar.Geslacht);
            }
        }

        public void AddEend(Eend eend, PictureBox PB_Eend, Geslacht geslacht)
        {

            PB_Eend.Location = new Point(eend.Location[0], eend.Location[1]);
            PB_Eend.Size = new Size(eend.Size[0], eend.Size[1]);
            PB_Eend.Image = Image.FromFile("Eend.png");
            PB_Eend.SizeMode = PictureBoxSizeMode.Zoom;
            if (geslacht == Geslacht.Man)
            {
                PB_Eend.BackColor = Color.Blue;
            }
            if (geslacht == Geslacht.Vrouw)
            {
                PB_Eend.BackColor = Color.Pink;
            }
            Controls.Add(PB_Eend);
        }
        public void AddKikker(Kikker kikker, PictureBox PB_Kikker, Geslacht geslacht)
        {

            PB_Kikker.Location = new Point(kikker.Location[0], kikker.Location[1]);
            PB_Kikker.Size = new Size(kikker.Size[0], kikker.Size[1]);
            PB_Kikker.Image = Image.FromFile("Kikker.png");
            PB_Kikker.SizeMode = PictureBoxSizeMode.Zoom;
            if (geslacht == Geslacht.Man)
            {
                PB_Kikker.BackColor = Color.Blue;
            }
            if (geslacht == Geslacht.Vrouw)
            {
                PB_Kikker.BackColor = Color.Pink;
            }
            Controls.Add(PB_Kikker);
        }
        public void AddOoievaar(Ooievaar ooievaar, PictureBox PB_Ooievaar, Geslacht geslacht)
        {

            PB_Ooievaar.Location = new Point(ooievaar.Location[0], ooievaar.Location[1]);
            PB_Ooievaar.Size = new Size(ooievaar.Size[0], ooievaar.Size[1]);
            PB_Ooievaar.Image = Image.FromFile("Ooievaar met korte nek.png");
            PB_Ooievaar.SizeMode = PictureBoxSizeMode.Zoom;
            if (geslacht == Geslacht.Man)
            {
                PB_Ooievaar.BackColor = Color.Blue;
            }
            if (geslacht == Geslacht.Vrouw)
            {
                PB_Ooievaar.BackColor = Color.Pink;
            }
            Controls.Add(PB_Ooievaar);
        }

        public void UpdateLocations()
        {
            for (int i = 0; i < aantalOoievaars; i++)
            {
                OoievaarPictureBoxArray[i].Location = new Point(arrayOoievaar[i].Location[0], arrayOoievaar[i].Location[1]);
            }
            for (int i = 0; i < aantalKikkers; i++)
            {
                // als een kikker op (-50, -50) zit dan kan die niet meer bewegen en is die 'dood'
                if (KikkerPictureBoxArray[i].Location != new Point(-50, -50))
                {
                    KikkerPictureBoxArray[i].Location = new Point(arrayKikker[i].Location[0], arrayKikker[i].Location[1]);
                }
            }
            for (int i = 0; i < aantalEenden; i++)
            {
                EendPictureBoxArray[i].Location = new Point(arrayEend[i].Location[0], arrayEend[i].Location[1]);
            }
        }

        public bool CheckCollisions(PictureBox PB_One, PictureBox PB_Two)
        {
            return (PB_One.Bounds.IntersectsWith(PB_Two.Bounds));
        }

        public void EetKikker()
        {
            for (int i = 0; i < aantalOoievaars; i++)
            {
                for (int ii = 0; ii < aantalKikkers; ii++)
                {
                    if (CheckCollisions(OoievaarPictureBoxArray[i], KikkerPictureBoxArray[ii]) && arrayKikker[ii].HidingBehindDuck == false)
                    {
                        Controls.Remove(KikkerPictureBoxArray[ii]);
                        arrayKikker[ii].Location[0] = -1000;
                        arrayKikker[ii].Location[1] = -1000;
                        LB_Kikkers.Items.Remove(arrayKikker[ii]);
                        overgeblevenKikkers--;
                        TB_Kikker.Text = "Kikkers " + overgeblevenKikkers.ToString();
                    }
                }
            }
        }
        public void FrogsHide()
        {
            for (int i = 0; i < aantalKikkers; i++)
            {
                for (int ii = 0; ii < aantalEenden; ii++)
                {
                    if (CheckCollisions(KikkerPictureBoxArray[i], EendPictureBoxArray[ii]))
                    {
                        arrayKikker[i].HideBehindDuck();
                    }
                    else
                    {
                        arrayKikker[i].NotHideBehindDuck();
                    }
                }
            }
        }
    }
}

/*
Requirements

DONE
- vijver met eenden
- eend is man of vrouw 
- je moet kunnen zien of het een man of vrouw is
- ook kikkers in de vijver
- ook ooievaar in de vijver
- ooievaar gaat naar dichtsbijzijnde kikker

TODO
- kikker kan schuilen achter eend, als kikker schuilt dan ziet de ooievaar de kikker niet meer en beweegt die random

Meh's
- kikkers worden weg ge teleporteerd ipv dat ze echt dood gaan
- kikkers worden niet uit lijst verwijderd

 */
