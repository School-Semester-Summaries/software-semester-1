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
    public partial class FRM_Meeting : Form
    {
        public FRM_Meeting()
        {
            InitializeComponent();
        }

        // Objects
        Inventory inventory = new Inventory();

        int timer = -2;

        private void FRM_Meeting_Load(object sender, EventArgs e)
        {
            TMR_Timer.Enabled = true;
        }

        // hardcoded garbage
        private void TMR_Timer_Tick(object sender, EventArgs e)
        {
            if (timer == 1)
            {
                PB_Green.Visible = true;
                LBL_Yellow_Green.Visible = true;
            }
            else if (timer == 2)
            {
                PB_Blue.Visible = true;
                LBL_Yellow_Blue.Visible = true;
            }
            else if (timer == 3)
            {
                PB_Pink.Visible = true;
                LBL_Yellow_Pink1.Visible = true;
            }
            else if (timer == 4)
            {
                PB_Red.Visible = true;
                LBL_Yellow_Red.Visible = true;
            }
            else if (timer == 5)
            {
                PB_Pink2.Visible = true;
                LBL_Yellow_Pink2.Visible = true;
            }
            else if (timer == 7)
            {
                PB_Pink2.Visible = false;
                LBL_Yellow_Pink2.Visible = false;
                LBL_Yellow_Blue.Visible = false;
                LBL_Yellow_Green.Visible = false;
                LBL_Yellow_Red.Visible = false;
                LBL_Yellow_Pink1.Visible = false;
            }
            else if (timer == 8)
            {
                PB_BlueSmall.Visible = true;
                PB_PinkSmall.Visible = true;
                PB_RedSmall.Visible = true;
            }
            else if (timer == 9)
            {
                PB_GreenSMall.Visible = true;
            }
            else if (timer == 11)
            {
                PB_RedEjected.Location = new Point(0, 0);
            }
            timer++;
        }
    }
}
