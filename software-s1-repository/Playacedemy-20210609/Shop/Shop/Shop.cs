using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop // last edited 14/06/2021 10:05
{
    public partial class FRM_Shop : Form
    {
        public FRM_Shop()
        {
            InitializeComponent();
        }

        private bool ufoRocket;
        private bool dababyRocket;
        private bool historyBackground;
        private bool sovjetBackground;
        private bool spaceBackground;
        private bool seaBackground;
        private bool abstractBackground;
        private bool kittyBackground;
        private bool dinoCursor;
        private bool crosshairCursor;
        private bool astroSong;
        private bool histoSong;
        private bool geoSong;

        // code om shit uit database te halen
        int coins = 1000; // moet eigenlijk dan de waarde hebben van de database
        const string sold = "Uitverkocht!";

        private void BTN_Ufo_Click(object sender, EventArgs e)
        {
            if (Buy(Convert.ToInt32(LBL_Ufo.Text)))
            {
                BTN_Ufo.Enabled = false;
                BTN_Ufo.Text = sold;
                ufoRocket = true;
            }
        }
        private void BTN_Dababy_Click(object sender, EventArgs e)
        {
            if (Buy(Convert.ToInt32(LBL_Dababy.Text)))
            {
                BTN_Dababy.Enabled = false;
                BTN_Dababy.Text = sold;
                dababyRocket = true;
            }
        }
        private void BTN_History_Click(object sender, EventArgs e)
        {
            if (Buy(Convert.ToInt32(LBL_History.Text)))
            {
                BTN_History.Enabled = false;
                BTN_History.Text = sold;
                historyBackground = true;
            }
        }
        private void BTN_Sovjet_Click(object sender, EventArgs e)
        {
            if (Buy(Convert.ToInt32(LBL_Sovjet.Text)))
            {
                BTN_Sovjet.Enabled = false;
                BTN_Sovjet.Text = sold;
                sovjetBackground = true;
            }
        }
        private void BTN_Space_Click(object sender, EventArgs e)
        {
            if (Buy(Convert.ToInt32(LBL_Space.Text)))
            {
                BTN_Space.Enabled = false;
                BTN_Space.Text = sold;
                spaceBackground = true;
            }
        }
        private void BTN_Sea_Click(object sender, EventArgs e)
        {
            if (Buy(Convert.ToInt32(LBL_Sea.Text)))
            {
                BTN_Sea.Enabled = false;
                BTN_Sea.Text = sold;
                seaBackground = true;
            }
        }
        private void BTN_Abstract_Click(object sender, EventArgs e)
        {
            if (Buy(Convert.ToInt32(LBL_Abstract.Text)))
            {
                BTN_Abstract.Enabled = false;
                BTN_Abstract.Text = sold;
                abstractBackground = true;
            }
        }
        private void BTN_Kitty_Click(object sender, EventArgs e)
        {
            if (Buy(Convert.ToInt32(LBL_Kitty.Text)))
            {
                BTN_Kitty.Enabled = false;
                BTN_Kitty.Text = sold;
                kittyBackground = true;
            }
        }
        private void BTN_Dino_Click(object sender, EventArgs e)
        {
            if (Buy(Convert.ToInt32(LBL_Dino.Text)))
            {
                BTN_Dino.Enabled = false;
                BTN_Dino.Text = sold;
                dinoCursor = true;
            }
        }
        private void BTN_Crosshair_Click(object sender, EventArgs e)
        {
            if (Buy(Convert.ToInt32(LBL_Cursor.Text)))
            {
                BTN_Crosshair.Enabled = false;
                BTN_Crosshair.Text = sold;
                crosshairCursor = true;
            }
        }
        private void BTN_AstroSong_Click(object sender, EventArgs e)
        {
            if (Buy(Convert.ToInt32(LBL_AstroSong.Text)))
            {
                BTN_AstroSong.Enabled = false;
                BTN_AstroSong.Text = sold;
                astroSong = true;
            }
        }
        private void BTN_HistoSong_Click(object sender, EventArgs e)
        {
            if (Buy(Convert.ToInt32(LBL_HistoSong.Text)))
            {
                BTN_HistoSong.Enabled = false;
                BTN_HistoSong.Text = sold;
                histoSong = true;
            }
        }
        private void BTN_GeoSong_Click(object sender, EventArgs e)
        {
            if (Buy(Convert.ToInt32(LBL_GeoSong.Text)))
            {
                BTN_GeoSong.Enabled = false;
                BTN_GeoSong.Text = sold;
                geoSong = true;
            }
        }

        public bool Buy(int price)
        {
            bool buy = false;
            if (coins >= price)
            {
                buy = true;
                coins = coins - price;
            }
            LBL_Coins.Text = coins.ToString();
            return buy;
        }

        private void FRM_Shop_FormClosed(object sender, FormClosedEventArgs e)
        {
            // aantal coins databse sturen
            // welke items je wel en niet hebt doorsturen
        }
    }
}
