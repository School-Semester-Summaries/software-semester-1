using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Goeroe_Calculator
{
    public partial class FRM_GoeroeCalculator : Form
    {
        public FRM_GoeroeCalculator()
        {
            InitializeComponent();
        }

        private void BTN_Plus_Click(object sender, EventArgs e)
        {
            try
            {
                int getal1 = Convert.ToInt32(TB_Getal1.Text); // krijg input
                int getal2 = Convert.ToInt32(TB_Getal2.Text); // krijg input

                int uitkomst = getal1 + getal2; // uitrekenen

                TB_Uitkomst.Text = Convert.ToString(uitkomst); // display in uitkomst Textbox
            }
            catch(FormatException)
            {
                MessageBox.Show("Vul getallen in"); // Fout melding
            }
        }
        private void BTN_Keer_Click(object sender, EventArgs e)
        {
            try
            {
                int getal1 = Convert.ToInt32(TB_Getal1.Text); // krijg input
                int getal2 = Convert.ToInt32(TB_Getal2.Text); // krijg input

                int uitkomst = getal1 * getal2; // uitrekenen

                TB_Uitkomst.Text = Convert.ToString(uitkomst); // display in uitkomst Textbox
            }
            catch (FormatException)
            {
                MessageBox.Show("Vul getallen in"); // Fout melding
            }
        }
        private void BTN_Min_Click(object sender, EventArgs e)
        {
            try
            {
                int getal1 = Convert.ToInt32(TB_Getal1.Text); // krijg input
                int getal2 = Convert.ToInt32(TB_Getal2.Text); // krijg input

                int uitkomst = getal1 - getal2; // uitrekenen

                TB_Uitkomst.Text = Convert.ToString(uitkomst); // display in uitkomst Textbox
            }
            catch (FormatException)
            {
                MessageBox.Show("Vul getallen in"); // Fout melding
            }
        }
        private void BTN_Delen_Click(object sender, EventArgs e)
        {
            try
            {
                Double getal1 = Convert.ToInt32(TB_Getal1.Text); // krijg input
                Double getal2 = Convert.ToInt32(TB_Getal2.Text); // krijg input

                Double uitkomst = getal1 / getal2; // uitrekenen

                TB_Uitkomst.Text = Convert.ToString(uitkomst); // display in uitkomst Textbox
            }
            catch (FormatException)
            {
                MessageBox.Show("Vul getallen in"); // Fout melding
            }
        }
    }
}
