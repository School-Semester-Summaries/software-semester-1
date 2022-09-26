using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Worpen_Generator
{
    public partial class FRM_WorpenGenerator : Form
    {
        public FRM_WorpenGenerator()
        {
            InitializeComponent();
        }

        private void BTN_GooiDobbelstenen_Click(object sender, EventArgs e)
        {
            // Listbox leegmaken en TotaalAantalOgen Resetten
            LB_Worpen.Items.Clear();
            int totaalAantalOgen = 0;

            // int AantalOgen aanmaken
            int aantalOgen = Convert.ToInt32(NUD_AantalOgen.Value);

            // int AantalWorpen aanmaken
            int aantalWorpen = Convert.ToInt32(NUD_AantalWorpen.Value);

            // random worp genereren en vervolgens toevoegen aan listbox
            for (int i = 0; i < aantalWorpen; i++)
            {
                // random worp genereren
                Random rnd = new Random();
                int worp = rnd.Next(1, (aantalOgen + 1));

                // toevoegen aan listbox
                LB_Worpen.Items.Add(worp);

                // Huidige worp toevoegen aan TotaalAantalOgen
                totaalAantalOgen += worp;
            }

            // TotaalAantalOgen versturen naar Textbox
            TB_TotaalAantalOgen.Text = Convert.ToString(totaalAantalOgen);
        }

        /*
        LOGIC:
        x aantal worpen
        y aantal ogen

        getal tussen 0 en y, dit doe je in totaal x keer
         */
    }
}
