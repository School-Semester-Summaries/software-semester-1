using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Create_Blocks
{
    public partial class FRM_CreateBlocks : Form
    {
        public FRM_CreateBlocks()
        {
            InitializeComponent();
        }

        private void BTN_CreateBlock_Click(object sender, EventArgs e)
        {
            CreateBlock();
        }

        public void CreateBlock()
        {
            Random rnd = new Random();
            int xModifier = rnd.Next(0, 10);
            int yModifier = rnd.Next(0, 6);

            int x = 44 * xModifier + 12;
            int y = 44 * yModifier + 12;

            // create object
            ListBox block = new ListBox();

            // give specs
            block.Location = new System.Drawing.Point(x, y);
            block.Name = "myListBox";
            block.Size = new System.Drawing.Size(44, 44);

            // give the right color
            if (RB_Red.Checked)
            {
                block.BackColor = System.Drawing.Color.Red;
            }
            else if (RB_Blue.Checked)
            {
                block.BackColor = System.Drawing.Color.Blue;
            }
            else if (RB_Green.Checked)
            {
                block.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                MessageBox.Show("Select a color!");
            }
            block.ForeColor = System.Drawing.Color.Black;

            // add to form
            if (RB_Red.Checked || RB_Green.Checked || RB_Blue.Checked)
            {
                Controls.Add(block);
            }
        }
    }
}
