using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galgje
{
    public partial class FRM_Galgje : Form
    {
        public FRM_Galgje()
        {
            InitializeComponent();
        }


        // Objects
        Random rnd = new Random();
        Woord OBJ_woord = new Woord();
        Gok OBJ_gok = new Gok();
        List<string> listItems = new List<string>();

        // Fields?
        string woord;
        string gok;
        bool gameStarted = false;

        // Events
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter && gameStarted)
            {
                // make everything caps so it wont get confused with lower letters
                gok = TB_Gok.Text.ToUpper();

                // read method names
                LBL_Woord.Text = OBJ_gok.CheckIfWordContainsLetter(listItems, woord, gok);
                OBJ_gok.PutGokInList(listItems, gok);
                PutListInListbox();

                // reset textbox for next letter
                TB_Gok.Text = "";
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void BTN_Start_Click(object sender, EventArgs e)
        {
            GenerateWord();
            StartGame();
        }

        // Methods
        public void GenerateWord()
        {
            woord = OBJ_woord.RandomWord(Convert.ToInt32(NUD_Letters.Value)).ToString();
            LBL_Woord.Text = OBJ_gok.CheckIfWordContainsLetter(listItems, woord, gok);
        }
        public void PutListInListbox()
        {
            LB_Letters.Items.Clear();
            LB_Letters.Items.AddRange(listItems.ToArray());
        }
        public void StartGame()
        {
            GB_Setup.Enabled = false;
            GB_Game.Enabled = true;
            gameStarted = true;
        }

        public void StopGame()
        {

        }
    }
}

/*
type een letter
check of letter in het woord zit
check of lb letters in woord zit
zo ja laat letter zien
zo niet leven weg
 */