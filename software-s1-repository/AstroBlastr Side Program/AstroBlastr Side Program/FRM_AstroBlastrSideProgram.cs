using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AstroBlastr_Side_Program
{

    // WIJKT AF VAN ORIGINEEL PROGRAMMA

    public partial class FRM_AstroBlastrSideProgram : Form
    {
        // object voor muziek en laserCanon
        System.Media.SoundPlayer music = new System.Media.SoundPlayer();
        System.Media.SoundPlayer laserCanon = new System.Media.SoundPlayer();

        public FRM_AstroBlastrSideProgram()
        {
            InitializeComponent();
            
            // media file locaties
            music.SoundLocation = "Astroblastr - Game Theme.wav";
            laserCanon.SoundLocation = "LaserCanon_SFX.wav";
        }

        // maak account object aan
        private Account account;


        private void BTN_createAccount_Click(object sender, EventArgs e)
        {
            // check ofdat de vakjes ingevuld zijn en of dat het wachtwoord wel minstens 4 tekens heeft
            if (TB_firstName.Text.Length > 0 && TB_lastName.Text.Length > 0 && TB_password.Text.Length > 3)
            {
                // constructor toepassen
                account = new Account(TB_firstName.Text, TB_lastName.Text, TB_password.Text);

                MessageBox.Show("Account aangemaakt");
                GB_account.Enabled = false;
                GB_Login.Enabled = true;
            }
            else if (TB_firstName.Text.Length > 0 && TB_lastName.Text.Length > 0 && TB_password.Text.Length >= 0)
            {
                MessageBox.Show("Wachtwoord moet minimaal 4 tekens lang zijn");
            }
            else
            {
                MessageBox.Show("Voer geldige gegevens in");
            }
        }

        // speler object aanmaken
        private Speler speler;

        private void BTN_login_Click(object sender, EventArgs e)
        {
            // check ofdat de gegevens overeen komen
            if (TB_firstNameLogin.Text == account.FirstName && TB_lastNameLogin.Text == account.LastName && TB_passwordLogin.Text == account.Password)
            {
                GB_game.Enabled = true;
                GB_Login.Enabled = false;

                // constructor toepassen
                speler = new Speler();

                // laat score coins en xp zien
                MessageBox.Show(speler.Score + " " + speler.Coins + " " + speler.ExperiencePoints);
            }
            else
            {
                MessageBox.Show("Gegevens komen niet overeen");
            }
        }

        Som som = new Som();

        private void BTN_NieuweSom_Click(object sender, EventArgs e)
        {
            LBL_som.Text = som.GenerateRandomSom();

            // play music
            music.Play();
        }

        private void BTN_checkAnswer_Click(object sender, EventArgs e)
        {
            // play sfx
            laserCanon.Play();

            if (TB_answer.Text == som.GetAnswer().ToString())
            {
                this.BackColor = Color.Green;
                speler.AddPointToScore(5);
                LBL_score.Text = "Score: " + speler.Score.ToString();
                LBL_som.Text = som.GenerateRandomSom();
            }
            else
            {
                this.BackColor = Color.Red;
            }
            TB_answer.Text = "";
        }




        private void TB_firstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void TB_lastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void TB_firstNameLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void TB_lastNameLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }





    }
}
