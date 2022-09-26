using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    enum State
    {
        Empty,
        Red,
        Blue
    }

    enum Turn
    {
        Red,
        Blue
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Fields
        Turn turn = new Turn();
        Color color = new Color();
        string redWinner = "Red Wins!";
        string bluewinner = "Blue Wins!";
        string draw = "Draw!";
        bool upLeft = false;
        bool up = false;
        bool upRight = false;
        bool left = false;
        bool mid = false;
        bool right = false;
        bool downLeft = false;
        bool down = false;
        bool downRight = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            turn = Turn.Red;
        }

        private void PB_UpLeft_Click(object sender, EventArgs e)
        {
            if (!upLeft)
            {
                if (turn == Turn.Red)
                {
                    color = Color.Red;
                    turn = Turn.Blue;
                }
                else if (turn == Turn.Blue)
                {
                    color = Color.Blue;
                    turn = Turn.Red;
                }
                PB_UpLeft.BackColor = color;
                upLeft = true;

                ABC();
                ADG();
                AEI();
                Draw();
            }
        }
        private void PB_Up_Click(object sender, EventArgs e)
        {
            if (!up)
            {
                if (turn == Turn.Red)
                {
                    color = Color.Red;
                    turn = Turn.Blue;
                }
                else if (turn == Turn.Blue)
                {
                    color = Color.Blue;
                    turn = Turn.Red;
                }
                PB_Up.BackColor = color;
                up = true;

                ABC();
                BEH();
                Draw();
            }
        }
        private void PB_UpRight_Click(object sender, EventArgs e)
        {
            if (!upRight)
            {
                if (turn == Turn.Red)
                {
                    color = Color.Red;
                    turn = Turn.Blue;
                }
                else if (turn == Turn.Blue)
                {
                    color = Color.Blue;
                    turn = Turn.Red;
                }
                PB_UpRight.BackColor = color;
                upRight = true;

                ABC();
                CEG();
                CFI();
                Draw();
            }
        }
        private void PB_Left_Click(object sender, EventArgs e)
        {
            if (!left)
            {
                if (turn == Turn.Red)
                {
                    color = Color.Red;
                    turn = Turn.Blue;
                }
                else if (turn == Turn.Blue)
                {
                    color = Color.Blue;
                    turn = Turn.Red;
                }
                PB_Left.BackColor = color;
                left = true;

                ADG();
                DEF();
                Draw();
            }
        }
        private void PB_Mid_Click(object sender, EventArgs e)
        {
            if (!mid)
            {
                if (turn == Turn.Red)
                {
                    color = Color.Red;
                    turn = Turn.Blue;
                }
                else if (turn == Turn.Blue)
                {
                    color = Color.Blue;
                    turn = Turn.Red;
                }
                PB_Mid.BackColor = color;
                mid = true;

                BEH();
                DEF();
                AEI();
                CEG();
                Draw();
            }
        }
        private void PB_Right_Click(object sender, EventArgs e)
        {
            if (!right)
            {
                if (turn == Turn.Red)
                {
                    color = Color.Red;
                    turn = Turn.Blue;
                }
                else if (turn == Turn.Blue)
                {
                    color = Color.Blue;
                    turn = Turn.Red;
                }
                PB_Right.BackColor = color;
                right = true;

                CFI();
                DEF();
                Draw();
            }
        }
        private void PB_DownLeft_Click(object sender, EventArgs e)
        {
            if (!downLeft)
            {
                if (turn == Turn.Red)
                {
                    color = Color.Red;
                    turn = Turn.Blue;
                }
                else if (turn == Turn.Blue)
                {
                    color = Color.Blue;
                    turn = Turn.Red;
                }
                PB_DownLeft.BackColor = color;
                downLeft = true;

                ADG();
                CEG();
                GHI();
                Draw();
            }
        }
        private void PB_Down_Click(object sender, EventArgs e)
        {
            if (!down)
            {
                if (turn == Turn.Red)
                {
                    color = Color.Red;
                    turn = Turn.Blue;
                }
                else if (turn == Turn.Blue)
                {
                    color = Color.Blue;
                    turn = Turn.Red;
                }
                PB_Down.BackColor = color;
                down = true;

                BEH();
                GHI();
                Draw();
            }
        }
        private void PB_DownRight_Click(object sender, EventArgs e)
        {
            if (!downRight)
            {
                if (turn == Turn.Red)
                {
                    color = Color.Red;
                    turn = Turn.Blue;
                }
                else if (turn == Turn.Blue)
                {
                    color = Color.Blue;
                    turn = Turn.Red;
                }
                PB_DownRight.BackColor = color;
                downRight = true;

                CFI();
                AEI();
                GHI();
                Draw();
            }
        }

        // Methods

        // A B C
        // D E F
        // G H I

        public void ABC()
        {
            if (PB_UpLeft.BackColor == PB_Up.BackColor && PB_UpLeft.BackColor == PB_UpRight.BackColor)
            {
                if (turn != Turn.Red)
                {
                    MessageBox.Show(redWinner);
                }
                else if (turn != Turn.Blue)
                {
                    MessageBox.Show(bluewinner);
                }
            }
        }
        public void DEF()
        {
            if (PB_Left.BackColor == PB_Mid.BackColor && PB_Left.BackColor == PB_Right.BackColor)
            {
                if (turn != Turn.Red)
                {
                    MessageBox.Show(redWinner);
                }
                else if (turn != Turn.Blue)
                {
                    MessageBox.Show(bluewinner);
                }
            }
        }
        public void GHI()
        {
            if (PB_DownLeft.BackColor == PB_Down.BackColor && PB_DownLeft.BackColor == PB_DownRight.BackColor)
            {
                if (turn != Turn.Red)
                {
                    MessageBox.Show(redWinner);
                }
                else if (turn != Turn.Blue)
                {
                    MessageBox.Show(bluewinner);
                }
            }
        }

        public void ADG()
        {
            if (PB_UpLeft.BackColor == PB_Left.BackColor && PB_UpLeft.BackColor == PB_DownLeft.BackColor)
            {
                if (turn != Turn.Red)
                {
                    MessageBox.Show(redWinner);
                }
                else if (turn != Turn.Blue)
                {
                    MessageBox.Show(bluewinner);
                }
            }
        }
        public void BEH()
        {
            if (PB_Up.BackColor == PB_Mid.BackColor && PB_Up.BackColor == PB_Down.BackColor)
            {
                if (turn != Turn.Red)
                {
                    MessageBox.Show(redWinner);
                }
                else if (turn != Turn.Blue)
                {
                    MessageBox.Show(bluewinner);
                }
            }
        }
        public void CFI()
        {
            if (PB_UpRight.BackColor == PB_Right.BackColor && PB_UpRight.BackColor == PB_DownRight.BackColor)
            {
                if (turn != Turn.Red)
                {
                    MessageBox.Show(redWinner);
                }
                else if (turn != Turn.Blue)
                {
                    MessageBox.Show(bluewinner);
                }
            }
        }

        public void AEI()
        {
            if (PB_UpLeft.BackColor == PB_Mid.BackColor && PB_UpLeft.BackColor == PB_DownRight.BackColor)
            {
                if (turn != Turn.Red)
                {
                    MessageBox.Show(redWinner);
                }
                else if (turn != Turn.Blue)
                {
                    MessageBox.Show(bluewinner);
                }
            }
        }
        public void CEG()
        {
            if (PB_UpRight.BackColor == PB_Mid.BackColor && PB_UpRight.BackColor == PB_DownLeft.BackColor)
            {
                if (turn != Turn.Red)
                {
                    MessageBox.Show(redWinner);
                }
                else if (turn != Turn.Blue)
                {
                    MessageBox.Show(bluewinner);
                }
            }
        }

        public void Draw()
        {
            if (upLeft && up && upRight && left && mid && right && downLeft && down && downRight)
            {
                MessageBox.Show(draw);
            }
        }
    }
}

/*

Possible combinations,

XXX OOO OOO
OOO XXX OOO
OOO OOO XXX

XOO OXO OOX
XOO OXO OOX
XOO OXO OOX

XOO OOX
OXO OXO
OOX XOO
*/