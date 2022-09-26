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

        int state = 0;

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

        int chosenSpot1;
        int chosenSpot2;
        int chosenSpot3;
        int chosenSpot4;
        int chosenSpot5;

        int chosenAnswer1 = 0;
        int chosenAnswer2 = 0;
        int chosenAnswer3 = 0;
        int chosenAnswer4 = 0;
        int chosenAnswer5 = 0;

        List<int> _correctOrdererOfItems;


        public frmHistoryblastr()
        {
            InitializeComponent();


            btnReplay.Visible = false;

            lbNaam.Text = player.naam;
            lbScore.Text = "score: " + player.score;



            spot1 = rnd.Next(1, 24);


            spot2 = rnd.Next(1, 24);

            while (spot1 == spot2)
            {
                spot2 = rnd.Next(1, 24);
            }

            spot3 = rnd.Next(1, 24);

            while ((spot3 == spot1) || (spot3 == spot2))
            {
                spot3 = rnd.Next(1, 24);
            }


            spot4 = rnd.Next(1, 24);

            while ((spot4 == spot1) || (spot4 == spot2) || (spot4 == spot3))
            {
                spot4 = rnd.Next(1, 24);
            }

            spot5 = rnd.Next(1, 24);
            while ((spot5 == spot1) || (spot5 == spot2) || (spot5 == spot3) || (spot5 == spot4))
            {
                spot5 = rnd.Next(1, 24);
            }

            timeline.getSpots(spot1, spot2, spot3, spot4, spot5);
            
            pbFirstimage.Image = imgList.Images[spot1];
            lbNameone.Text = timeline.GetNameBySpot(spot1);
            pbSecondimage.Image = imgList.Images[spot2];
            lbNametwo.Text = timeline.GetNameBySpot(spot2);
            pbThirdimage.Image = imgList.Images[spot3];
            lbNamethree.Text = timeline.GetNameBySpot(spot3);
            pbFourthimage.Image = imgList.Images[spot4];
            lbNamefour.Text = timeline.GetNameBySpot(spot4);
            pbFifthimage.Image = imgList.Images[spot5];
            lbNamefive.Text = timeline.GetNameBySpot(spot5);




            btnCheck.Visible = true;

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
            checkboxes();
            checkimages();
            
            
            btnCheck.Visible = false;
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
            btnCheck.Visible = true;
        }

        private void frmHistoryblastr_Load(object sender, EventArgs e)
        {

        }

        private void checkboxes()
        {
            if (boxes == true)
            {
                enablelabels();

                if ((tbTimeone.Text != "") && (tbTimetwo.Text != "") && (tbTimethree.Text != "") && (tbTimefour.Text != "") && (tbTimefive.Text != ""))
                {
                    checktime();
                }

                if (tbTimeone.Text == "")
                {
                    MessageBox.Show("vul alle boxen in en probeer opnieuw");
                    
                    lbErrorone.Text = "Error";
                    lbErrorone.ForeColor = Color.Red;
                }

                if (tbTimetwo.Text == "")
                {
                    MessageBox.Show("vul alle boxen in en probeer opnieuw");
                    
                    lbErrortwo.Text = "Error";
                    lbErrortwo.ForeColor = Color.Red;
                }

                if (tbTimethree.Text == "")
                {
                    MessageBox.Show("vul alle boxen in en probeer opnieuw");
                    
                    lbErrorthree.Text = "Error";
                    lbErrorthree.ForeColor = Color.Red;
                }

                if (tbTimefour.Text == "")
                {
                    MessageBox.Show("vul alle boxen in en probeer opnieuw");
                    
                    lbErrorfour.Text = "Error";
                    lbErrorfour.ForeColor = Color.Red;
                }

                if (tbTimefive.Text == "")
                {
                    MessageBox.Show("vul alle boxen in en probeer opnieuw");
                    
                    lbErrorfive.Text = "Error";
                    lbErrorfive.ForeColor = Color.Red;
                }

            }
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
                    startimage = false;
                    boxes = true;
                    
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
            _correctOrdererOfItems = timeline.Reorderdlist;
            Console.WriteLine(_correctOrdererOfItems[0].ToString());
            Console.WriteLine(_correctOrdererOfItems[1].ToString());
            Console.WriteLine(_correctOrdererOfItems[2].ToString());
            Console.WriteLine(_correctOrdererOfItems[3].ToString());
            Console.WriteLine(_correctOrdererOfItems[4].ToString());

            chosenAnswer1 = _correctOrdererOfItems[0];
            chosenAnswer2 = _correctOrdererOfItems[1];
            chosenAnswer3 = _correctOrdererOfItems[2];
            chosenAnswer4 = _correctOrdererOfItems[3];
            chosenAnswer5 = _correctOrdererOfItems[4];

            Console.WriteLine(chosenAnswer1);

            Console.WriteLine(chosenSpot1);

            if (chosenSpot1 == chosenAnswer1)
            {
                player.addscore(1);
            }
            else
            {
                lbNameone.ForeColor = Color.Red;
            }

            if (chosenSpot2 == chosenAnswer2)
            {
                player.addscore(1);
            }

            else
            {
                lbNametwo.ForeColor = Color.Red;
            }

            if (chosenSpot3 == chosenAnswer3)
            {
                player.addscore(1);
            }

            else
            {
                lbNamethree.ForeColor = Color.Red;
            }

            if (chosenSpot4 == chosenAnswer4)
            {
                player.addscore(1);
            }

            else
            {
                lbNamefour.ForeColor = Color.Red;
            }

            if (chosenSpot5 == chosenAnswer5)
            {
                player.addscore(1);
                updatelabel();
            }

            else
            {
                lbNamefive.ForeColor = Color.Red;
                updatelabel();
            }

            pbFirstimage.Visible = false;
            pbSecondimage.Visible = false;
            pbThirdimage.Visible = false;
            pbFourthimage.Visible = false;
            pbFifthimage.Visible = false;


            

        }

        private void checktime()
        {
            int time;
            int correcttime1 = 0;
            int correcttime2 = 0;
            int correcttime3 = 0;
            int correcttime4 = 0;
            int correcttime5 = 0;



            // haal dictionary tijd op
            correcttime1 = timeline.GetTimeBySpot(chosenSpot1);
            // sla tjd op in int

            timeline.GetTimeBySpot(chosenSpot2);

            timeline.GetTimeBySpot(chosenSpot3);

            timeline.GetTimeBySpot(chosenSpot4);

            timeline.GetTimeBySpot(chosenSpot5);


            // kan nog in methode

            lbErrorone.Text = Convert.ToString(correcttime1);
            lbErrortwo.Text = Convert.ToString(correcttime2);
            lbErrorthree.Text = Convert.ToString(correcttime3);
            lbErrorfour.Text = Convert.ToString(correcttime4);
            lbErrorfive.Text = Convert.ToString(correcttime5);

            Console.WriteLine(correcttime1);

            // vergelijk
            if (tbTimeone.Text == Convert.ToString(correcttime1))
            {
                player.addscore(1);
                lbErrorone.ForeColor = Color.Green;

            }

            else
            {
                lbErrorone.ForeColor = Color.Red;

            }

            if (tbTimetwo.Text == Convert.ToString(correcttime2))
            {
                player.addscore(1);
                lbErrortwo.ForeColor = Color.Green;

            }

            else
            {
                lbErrortwo.ForeColor = Color.Red;

            }

            if (tbTimethree.Text == Convert.ToString(correcttime3))
            {
                player.addscore(1);
                lbErrorthree.ForeColor = Color.Green;

            }

            else
            {
                lbErrorthree.ForeColor = Color.Red;

            }

            if (tbTimefour.Text == Convert.ToString(correcttime4))
            {
                player.addscore(1);
                lbErrorfour.ForeColor = Color.Green;

            }

            else
            {
                lbErrorfour.ForeColor = Color.Red;

            }

            if (tbTimefive.Text == Convert.ToString(correcttime5))
            {
                player.addscore(1);
                lbErrorfive.ForeColor = Color.Green;

            }

            else
            {
                lbErrorfive.ForeColor = Color.Red;

            }



            //disable textboxes
            disableboxes();

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

        private void disableboxes()
        {
            tbTimeone.Visible = false;
            tbTimetwo.Visible = false;
            tbTimethree.Visible = false;
            tbTimefour.Visible = false;
            tbTimefive.Visible = false;
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
            MessageBox.Show(Convert.ToString(chosenSpot1));
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
