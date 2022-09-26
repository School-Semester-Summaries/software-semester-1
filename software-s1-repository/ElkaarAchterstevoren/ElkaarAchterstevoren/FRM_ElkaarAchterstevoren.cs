using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElkaarAchterstevoren
{
    public partial class FRM_ElkaarAchterstevoren : Form
    {
        public FRM_ElkaarAchterstevoren()
        {
            InitializeComponent();
        }
        private void TB_Woord_TextChanged(object sender, EventArgs e)
        {
            Controle();
        }
        private void TB_Achterstevoren_TextChanged(object sender, EventArgs e)
        {
            Controle();
        }
        public void Controle()
        {
            // strings gelijkstellen aan textboxen
            string woord = TB_Woord.Text;
            string achterstevoren = TB_Achterstevoren.Text;

            // Variabelen aanmaken
            string achterstevorenControle = "";
            string letter;

            // Lengte woord gelijkstellen aan de lengte van het ingevulde woord
            int lengteWoord = woord.Length;

            // Woord omdraaien en in de variabel AchterstevorenControle zetten
            while (lengteWoord > 0)
            {
                lengteWoord--;
                letter = woord.Substring(lengteWoord, 1);
                achterstevorenControle += letter;
            }

            // checken of dat er minstens 1 letter getypt is in beide textboxen
            if (woord.Length > 0 && achterstevoren.Length > 0)
            {
                // checken of je het woord goed achterstevoren hebt ingetypt
                if (achterstevorenControle == TB_Achterstevoren.Text)
                {
                    BackColor = Color.Green;
                }
                else
                {
                    BackColor = Color.DarkSalmon;
                }
            }
            else
            {
                // Nothing
            }
        }
    }
}
