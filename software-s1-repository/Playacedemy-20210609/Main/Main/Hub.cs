using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AstroBlaster;
using HistoryBlastrV1;
using System.Resources;
using System.IO;

namespace Main
{
    public partial class Hub : Form
    {
        AstroBlastr Astroblastr = new AstroBlastr();
        frmHistoryblastr HistoryBlastr = new frmHistoryblastr();
        StringBuilder AllText = new StringBuilder();

        string PATH = @"TestText2.txt";
        public Hub()
        {
            InitializeComponent();
            HubTimer.Interval = 1;
            HubTimer.Start();
        }




        private void HubTimer_Tick(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 1)
            {
                this.Show();
                SetHighscores();
            }
        }

        public void SetHighscores()
        {
            lbx_Highscores.Items.Clear();
            string[] Scores;
            //Tuple<string, int>[] Data;
            Tuple<string, int> Values;
            //AllText.Append(File.ReadAllLines(PATH));;
            foreach (var line in File.ReadAllLines(PATH))
            {
                Scores = line.Split('.');
                //Values = Scores;   
                lbx_Highscores.Items.Add(line);
                
            }
            //Values.Sort();
        }


        private void SummonAstroBlastr_Click(object sender, EventArgs e)
        {
            
            Astroblastr = new AstroBlastr();
            this.Hide();
            Astroblastr.Show();
        }
        private void SummonHistoryBlastr_Click(object sender, EventArgs e)
        {
            HistoryBlastr = new frmHistoryblastr();
            this.Hide();
            HistoryBlastr.Show();
        }
    }
}
