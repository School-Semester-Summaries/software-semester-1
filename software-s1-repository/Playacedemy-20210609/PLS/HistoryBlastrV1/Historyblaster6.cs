using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;



namespace HistoryBlastrV1
{
    public partial class frmHistoryblastr : Form
    {
        Timeline timeline = new Timeline();

        Player player = new Player();
        //Database2 database = new Database2();

        bool boxes = false;
        bool startimage = true;
        int images = 0;


        private Random rnd = new Random();

        

        bool box1 = false;
        bool box2 = false;
        bool box3 = false;
        bool box4 = false;
        bool box5 = false;

        int spot1;
        int spot2;
        int spot3;
        int spot4;
        int spot5;

        int currentlySelected = 0;

        int chosenSpot1 = 0;
        int chosenSpot2 = 0;
        int chosenSpot3 = 0;
        int chosenSpot4 = 0;
        int chosenSpot5 = 0;

        List<int> _correctOrdererOfItems;


        public frmHistoryblastr()
        {
            InitializeComponent();


            btnReplay.Visible = false;

            lbNaam.Text = player.naam;
            lbScore.Text = "score: " + player.score;



            spot1 = rnd.Next(1, 23);


            spot2 = rnd.Next(1, 23);

            if (spot1 == spot2)
            {
                spot2 = rnd.Next(1, 23);
            }

            spot3 = rnd.Next(1, 23);

            if ((spot3 == spot1) || (spot3 == spot2))
            {
                spot3 = rnd.Next(1, 23);
            }


            spot4 = rnd.Next(1, 23);

            if ((spot4 == spot1) || (spot4 == spot2) || (spot4 == spot3))
            {
                spot4 = rnd.Next(1, 23);
            }

            spot5 = rnd.Next(1, 23);
            if ((spot5 == spot1) || (spot5 == spot2) || (spot5 == spot3) || (spot5 == spot4))
            {
                spot5 = rnd.Next(1, 23);
            }

            timeline.getSpots(spot1, spot2, spot3, spot4, spot5);
            
            pbFirstimage.Image = imgList.Images[spot1];
            pbSecondimage.Image = imgList.Images[spot2];
            //pbThirdimage.Image = imgList.Images[spot3];
            pbFourthimage.Image = imgList.Images[spot4];
            pbFifthimage.Image = imgList.Images[spot5];

            pbThirdimage.Image = imgList.Images[22];

            


            btnCheck.Visible = false;

            tbTimeone.Visible = false;
            tbTimetwo.Visible = false;
            tbTimethree.Visible = false;
            tbTimefour.Visible = false;
            tbTimefive.Visible = false;

            lbErrorone.Visible = false;
            lbErrortwo.Visible = false;
            lbErrorthree.Visible = false;
            lbErrorfour.Visible = false;
            lbErrorfive.Visible = false;

            _correctOrdererOfItems = timeline.Reorderdlist;






            pbFirstimage.MouseDown += pbFirstimage_MouseDown;
            pbAnswerone.AllowDrop = true;
            pbAnswerone.DragEnter += pbAnswerone_DragEnter;
            pbAnswerone.DragDrop += pbAnswerone_DragDrop;

            pbSecondimage.MouseDown += pbSecondimage_MouseDown;
            pbAnswertwo.AllowDrop = true;
            pbAnswertwo.DragEnter += pbAnswertwo_DragEnter;
            pbAnswertwo.DragDrop += pbAnswertwo_DragDrop;

            pbThirdimage.MouseDown += pbThirdimage_MouseDown;
            pbAnswerthree.AllowDrop = true;
            pbAnswerthree.DragEnter += pbAnswerthree_DragEnter;
            pbAnswerthree.DragDrop += pbAnswerthree_DragDrop;

            pbFourthimage.MouseDown += pbFourthimage_MouseDown;
            pbAnswerfour.AllowDrop = true;
            pbAnswerfour.DragEnter += pbAnswerfour_DragEnter;
            pbAnswerfour.DragDrop += pbAnswerfour_DragDrop;

            pbFifthimage.MouseDown += pbFifthimage_MouseDown;
            pbAnswerfive.AllowDrop = true;
            pbAnswerfive.DragEnter += pbAnswerfive_DragEnter;
            pbAnswerfive.DragDrop += pbAnswerfive_DragDrop;
        }




        private void btnCheck_Click(object sender, EventArgs e)
        {
            checkimages();


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmHistoryblastr_Load(object sender, EventArgs e)
        {

        }

        private void checkboxes()
        {

        }

        private void checkimages()
        {
            if (startimage == true)
            {
                if ((chosenSpot1 != 0) && (chosenSpot2 != 0) && (chosenSpot3 != 0) && (chosenSpot4 != 0) && (chosenSpot5 != 0))
                {
                    //disable button
                    btnCheck.Visible = false;
                    //check antwoorden
                    checkanswers();
                    //enable boxes
                    enableboxes();
                    //disable movement of bovenste visible boxes
                    
                }

                if (chosenSpot1 == 0)
                {
                    MessageBox.Show("het eerste plaatje is nog niet ingevuld");
                }

                if (chosenSpot2 == 0)
                {
                    MessageBox.Show("het tweede plaatje is nog niet ingevuld");
                }

                if (chosenSpot3 == 0)
                {
                    MessageBox.Show("het derde plaatje is nog niet ingevuld");
                }

                if (chosenSpot4 == 0)
                {
                    MessageBox.Show("het vierde plaatje is nog niet ingevuld");
                }

                if (chosenSpot5 == 0)
                {
                    MessageBox.Show("het vijfde plaatje is nog niet ingevuld");
                }
            }
        }

        private void checkanswers()
        {

        }

        private void checktime()
        {



        }

        private void lbErrorfour_Click(object sender, EventArgs e)
        {

        }

        private void lbErrorfive_Click(object sender, EventArgs e)
        {

        }

        private void printimages(int imagenumber)
        {

        }

        private void pbFirstimage_Click(object sender, EventArgs e)
        {
            
        }

        private void pbSecondimage_Click(object sender, EventArgs e)
        {
            
        }

        private void pbThirdimage_Click(object sender, EventArgs e)
        {
            
        }

        private void pbFourthimage_Click(object sender, EventArgs e)
        {
            
        }

        private void pbFifthimage_Click(object sender, EventArgs e)
        {
            
        }

        private void pbAnswerone_Click(object sender, EventArgs e)
        {
           

        }

        private void pbAnswertwo_Click(object sender, EventArgs e)
        {

            
        }

        private void pbAnswerthree_Click(object sender, EventArgs e)
        {
            
        }

        private void pbAnswerfour_Click(object sender, EventArgs e)
        {
            
        }

        private void pbAnswerfive_Click(object sender, EventArgs e)
        {
            
        }

        private void enableboxes()
        {
            tbTimeone.Visible = true;
            tbTimetwo.Visible = true;
            tbTimethree.Visible = true;
            tbTimefour.Visible = true;
            tbTimefive.Visible = true;
        }

        private void enablelabels()
        {
            lbErrorone.Visible = true;
            lbErrortwo.Visible = true;
            lbErrorthree.Visible = true;
            lbErrorfour.Visible = true;
            lbErrorfive.Visible = true;
        }

        private void updatelabel()
        {
            lbScore.Text = "score: " + player.score;
        }

        private void btnReplay_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void pbFirstimage_MouseDown(object sender, MouseEventArgs e)
        {
            currentlySelected = spot1;

            var img = pbFirstimage.Image;
            if (img == null) return;

            if (DoDragDrop(img, DragDropEffects.Move) == DragDropEffects.Move)
            {
                //pb1.Image = null;
                currentlySelected = spot1;
            }

        }

        private void pbSecondimage_MouseDown(object sender, MouseEventArgs e)
        {
            currentlySelected = spot2;

            var img = pbSecondimage.Image;
            if (img == null) return;
            if (DoDragDrop(img, DragDropEffects.Move) == DragDropEffects.Move)
            {
                //pb1.Image = null;
                currentlySelected = spot2;
            }
        }

        private void pbThirdimage_MouseDown(object sender, MouseEventArgs e)
        {

            currentlySelected = spot3;

            var img = pbThirdimage.Image;
            if (img == null) return;
            if (DoDragDrop(img, DragDropEffects.Move) == DragDropEffects.Move)
            {
                //pb1.Image = null;
                currentlySelected = spot3;
            }
        }

        private void pbFourthimage_MouseDown(object sender, MouseEventArgs e)
        {
            currentlySelected = spot4;

            var img = pbFourthimage.Image;
            if (img == null) return;
            if (DoDragDrop(img, DragDropEffects.Move) == DragDropEffects.Move)
            {
                //pb1.Image = null;
                currentlySelected = spot4;
            }
        }

        private void pbFifthimage_MouseDown(object sender, MouseEventArgs e)
        {
            currentlySelected = spot5;

            var img = pbFifthimage.Image;
            if (img == null) return;
            if (DoDragDrop(img, DragDropEffects.Move) == DragDropEffects.Move)
            {
                //pb1.Image = null;
                currentlySelected = spot5;
            }
        }

        private void pbAnswerone_DragDrop(object sender, DragEventArgs e)
        {
            var bmp = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pbAnswerone.Image = bmp;

            chosenSpot1 = currentlySelected;
            currentlySelected = 0;
        }

        private void pbAnswerone_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Move;
        }

        private void pbAnswertwo_DragDrop(object sender, DragEventArgs e)
        {
            var bmp = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pbAnswertwo.Image = bmp;

            chosenSpot2 = currentlySelected;
            currentlySelected = 0;
        }

        private void pbAnswertwo_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Move;
        }

        private void pbAnswerthree_DragDrop(object sender, DragEventArgs e)
        {
            var bmp = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pbAnswerthree.Image = bmp;

            chosenSpot3 = currentlySelected;
            currentlySelected = 0;
        }

        private void pbAnswerthree_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Move;
        }

        private void pbAnswerfour_DragDrop(object sender, DragEventArgs e)
        {
            var bmp = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pbAnswerfour.Image = bmp;

            chosenSpot4 = currentlySelected;
            currentlySelected = 0;
        }

        private void pbAnswerfour_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Move;
        }

        private void pbAnswerfive_DragDrop(object sender, DragEventArgs e)
        {
            var bmp = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pbAnswerfive.Image = bmp;

            chosenSpot5 = currentlySelected;
            currentlySelected = 0;
        }

        private void pbAnswerfive_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Move;
            Refresh();
        }

        // stappenplan

        // Doorverwezen naar form historyblastr
        // 5 random plaatjes inladen en weergeven op form
        // pictureboxen sleepbaar maken
        // Checkbutton nakijken of plaatjes goed staan
        // nee? Label tekst welke niet goed staan + label probeer het opnieuw
        // ja? Vergelijk de plaatjes coordinaten en geef ze een naam.
        // naam 1 is ... naam 2 is ... naam 3 is .... naam 4 = ... naam 5 = ...
        // vergelijk ints plus naam plekken en kijk of dit klopt met waar ze moeten staan
        // verander labels gebaseerd op antwoorden
        // voeg score toe gebasseerd op antwooden
        // disable check button
        // disable movement plaatjes
        // maak textboxen visible 
        // als textbox 5? is ingevuld maak checkbutton weer visible
        // checkbutton ingedrukt ->
        // zijn de textboxes allemaal ingevuld
        // nee? Label bij bijhorende textbox en label probeer opnieuw
        // ja? Vergelijk antwoorden met tuple
        // maak labels rood / groen met bijhorende antwoorden
        // voeg score toe
        // Replay / stop


        // To do list:
        // Form indelen                    done
        // Classes invullen                
        // Stappenplan maken               done
        // Tuple invullen                  different
        // images toevoegen                done?
        // methodes check of images        
        // methode check of textboxen      done
        // Replay button?                  done
        // toevoegen database opties
        // database opties opslaan voor replay knop

        // 1 = geel
        // 2 = groen
        // 3 = rood
        // 4 = paars
        // 5 = blauw


    }
}
