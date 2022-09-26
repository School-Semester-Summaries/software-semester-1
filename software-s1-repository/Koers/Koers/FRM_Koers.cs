using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Koers
{
    public partial class FRM_Koers : Form
    {
        public FRM_Koers()
        {
            InitializeComponent();
        }

        // dollar variabelen worden ook voor lira gebruikt.

        private void BTN_LessThan_Click(object sender, EventArgs e)
        {
                try
                {
                    decimal dollar = Convert.ToDecimal(TB_Dollar.Text);
                    decimal euroKoers = Convert.ToDecimal(TB_EuroKoers.Text);
                    decimal dollarKoers = Convert.ToDecimal(TB_DollarKoers.Text);

                    string euroUitkomst = Convert.ToString(Math.Round(dollar / dollarKoers * euroKoers, 2));
                    TB_Euro.Text = euroUitkomst;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Voer getallen in!");
                }
        }

        private void BTN_GreaterThan_Click(object sender, EventArgs e)
        {
            try
            {
                decimal euro = Convert.ToDecimal(TB_Euro.Text);
                decimal EuroKoers = Convert.ToDecimal(TB_EuroKoers.Text);
                decimal dollarKoers = Convert.ToDecimal(TB_DollarKoers.Text);

                string dollarUitkomst = Convert.ToString(Math.Round(euro / EuroKoers * dollarKoers, 2));
                TB_Dollar.Text = dollarUitkomst;
            }
            catch (FormatException)
            {
                MessageBox.Show("Voer getallen in!");
            }
        }

        private void BTN_ChangeValuta_Click(object sender, EventArgs e)
        {
            PB_Dollar.Visible = !PB_Dollar.Visible;
            PB_Lira.Visible = !PB_Lira.Visible;

            if (PB_Dollar.Visible)
            {
                TB_DollarKoers.Text = "1,20";
                TB_EuroNaar.Text = "Euro naar Dollar";
            }

            if (PB_Lira.Visible)
            {
                TB_DollarKoers.Text = "8,91";
                TB_EuroNaar.Text = "Euro naar Lira";
            }
        }

    /*
    Wat moet er gebeuren

    BTN_GreaterThan:
    TB_EuroConvert / TB_EuroKoers * TB_DollarKoers = TB_DollarConvert

    €6 = ? (6/2*5) (TB_EuroConvert / TB_EuroKoers * TB_DollarKoers)
    €2 = $5


    BTN_Smallerthan:
    TB_DollarConvert / TB_DollarKoers * TB_EuroConvert = TB_EuroConvert

    €? = $21 (21/9*3) dus (TB_DollarConvert / TB_DollarKoers * TB_EuroConvert)
    €3 = $9

     */

} // Form1
} // Koers
