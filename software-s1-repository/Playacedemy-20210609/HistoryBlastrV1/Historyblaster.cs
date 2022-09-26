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
        //TimelineItem timelineitem = new TimelineItem();
        Player player = new Player();
        Database database = new Database();

        bool boxes = false;
        bool startimage = true;
        int images = 0;    
             

        private Random rnd = new Random();

        Color color;

        bool box1 = false;
        bool box2 = false;
        bool box3 = false;
        bool box4 = false;
        bool box5 = false;
                      
        
        public frmHistoryblastr()
        {
            InitializeComponent();


            btnReplay.Visible = false;

            lbNaam.Text = player.naam;
            lbScore.Text = "score: " + player.score;

            

            int spot1 = rnd.Next(0, 23);           
            

            int spot2 = rnd.Next(0, 23);
            
            if (spot1 == spot2)
            {
                spot2 = rnd.Next(0, 23);
            }

            int spot3 = rnd.Next(0, 23);

            if ((spot3 == spot1) || (spot3 == spot2))
            {
                spot3 = rnd.Next(0, 23);
            }
            

            int spot4 = rnd.Next(0, 23);

            if ((spot4 == spot1) || (spot4 == spot2) || (spot4 == spot3))
            {
                spot4 = rnd.Next(0, 23);
            }

            int spot5 = rnd.Next(0, 23);
            if ((spot5 == spot1) || (spot5 == spot2) || (spot5 == spot3) || (spot5 == spot4))
            {
                spot5 = rnd.Next(0, 23);
            }

            

            pbFirstimage.Image = imgList.Images[spot1];
            pbSecondimage.Image = imgList.Images[spot2];
            pbThirdimage.Image = imgList.Images[spot3];
            pbFourthimage.Image = imgList.Images[spot4];
            pbFifthimage.Image = imgList.Images[spot5];

            //timeline.


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

            //printimages(spot1);
            //printimages(spot2);
            //printimages(spot3);
            //printimages(spot4);
            //printimages(spot5);

            // 1 = geel
            // 2 = groen
            // 3 = rood
            // 4 = paars
            // 5 = blauw

            //pbFirstimage.BackColor = Color.FromArgb(255, 255, 0);
            //pbSecondimage.BackColor = Color.FromArgb(0, 128, 0);
            //pbThirdimage.BackColor = Color.FromArgb(255, 0, 0);
            //pbFourthimage.BackColor = Color.FromArgb(145, 44, 238);
            //pbFifthimage.BackColor = Color.FromArgb(0, 0, 205);
            //color = Color.White;

            AllowDragDrop(pbFirstimage,  pbAnswerone);
            AllowDragDrop(pbSecondimage, pbAnswertwo);
            AllowDragDrop(pbThirdimage, pbAnswerthree);
            AllowDragDrop(pbAnswerfour, pbFourthimage);
            AllowDragDrop(pbFifthimage, pbAnswerfive);
        }

        public void AllowDragDrop(PictureBox Asker, PictureBox Answer/*, Color color*/)
        {
            Asker.MouseDown += pbFifthimage_MouseDown;
            Answer.AllowDrop = true;
            Answer.DragEnter += pbAnswerfive_DragEnter;
            Answer.DragDrop += pbAnswerfive_DragDrop;

            //Asker.BackColor = color;
        }


        private void btnCheck_Click(object sender, EventArgs e)
        {
            checkboxes();
            checkimages();

            if (boxes == true)
            {

            }

            if (images == 2)
            {
                checkanswers();
                enableboxes();
                
                boxes = true;
                
                images = 0;
            }
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


                if ((tbTimeone.Text != "") && (tbTimetwo.Text != "") && (tbTimethree.Text != "") && (tbTimefour.Text != "") && (tbTimefive.Text != ""))
                {
                    btnCheck.Visible = false;
                    boxes = false;
                    
                    checktime();
                    return;

                }

                if (tbTimeone.Text == "")
                {
                    MessageBox.Show("Error textbox 1 is niet ingevuld");
                }

                if (tbTimetwo.Text == "")
                {
                    MessageBox.Show("Error textbox 2 is niet ingevuld");
                }

                if (tbTimethree.Text == "")
                {
                    MessageBox.Show("Error textbox 3 is niet ingevuld");
                }

                if (tbTimefour.Text == "")
                {
                    MessageBox.Show("Error textbox 4 is niet ingevuld");
                }

                if (tbTimefive.Text == "")
                {
                    MessageBox.Show("Error textbox 5 is niet ingevuld");
                }

                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void checkimages()
        {
            if (startimage)
            {
                if (images == 0)
                {
                    if (color == Color.White)
                    {
                        MessageBox.Show("vul alle boxen in");
                        MessageBox.Show("probeer het nog eens");
                    }

                    if (box1 == false)
                    {
                        MessageBox.Show("positie 1 is niet ingevuld");
                    }

                    if (box2 == false)
                    {
                        MessageBox.Show("positie 2 is niet ingevuld");
                    }

                    if (box3 == false)
                    {
                        MessageBox.Show("positie 3 is niet ingevuld");
                    }

                    if (box4 == false)
                    {
                        MessageBox.Show("positie 4 is niet ingevuld");
                    }

                    if (box5 == false)
                    {
                        MessageBox.Show("positie 5 is niet ingevuld");
                    }

                    if ((box1 == true) && (box2 == true) && (box3 == true) && (box4 == true) && (box5 == true))
                    {
                        MessageBox.Show("Goed");
                        checkanswers();
                        images = 2;
                        startimage = false;
                    }
                }   
            }
        }

        // methode klopt nog niet 
        private void checkanswers()
        {
            
        }

        private void checktime()
        {
            enablelabels();

            if (tbTimeone.Text == "1772")                    //moet nog
            {
                player.addscore(1);
                lbErrorone.Text = "Correct";                     //moet nog
                this.lbErrorone.ForeColor = Color.Green;
            }

            else
            {
                lbErrorone.Text = "fout: 1772";          //moet nog
                this.lbErrorone.ForeColor = Color.Red;
            }

            if (tbTimetwo.Text == "1839")                       //moet nog
            {
                player.addscore(1);
                lbErrortwo.Text = "Correct";                       //moet nog
                this.lbErrortwo.ForeColor = Color.Green;
            }

            else
            {
                lbErrortwo.Text = "fout: 1839";            //moet nog
                this.lbErrortwo.ForeColor = Color.Red;
            }

            if (tbTimethree.Text == "1848")
            {
                player.addscore(1);
                lbErrorthree.Text = "Correct";                       //moet nog
                this.lbErrorthree.ForeColor = Color.Green;
            }

            else
            {
                lbErrorthree.Text = "fout: 1848";            //moet nog
                this.lbErrorthree.ForeColor = Color.Red;
            }
             
            if (tbTimefour.Text == "1860")                      //moet nog
            {
                player.addscore(1);
                lbErrorfour.Text = "Correct";                       //moet nog
                this.lbErrorfour.ForeColor = Color.Green;
            }

            else
            {
                lbErrorfour.Text = "fout: 1860";               //moet nog
                this.lbErrorfour.ForeColor = Color.Red;
            }

            if (tbTimefive.Text == "1876")                      //moet nog
            {
                player.addscore(1);
                lbErrorfive.Text = "Correct";                       //moet nog
                this.lbErrorfive.ForeColor = Color.Green;
                updatelabel();
                
            }

            else
            {
                lbErrorfive.Text = "fout: 1876";             //moet nog
                this.lbErrorfive.ForeColor = Color.Red;
                updatelabel();
                
            }
            btnReplay.Visible = true;
        }

        private void lbErrorfour_Click(object sender, EventArgs e)
        {

        }

        private void lbErrorfive_Click(object sender, EventArgs e)
        {

        }

        private void printimages(int imagenumber)
        {
            if (imagenumber == 0)
            {       
                
            }

            if (imagenumber == 1)
            {
                
            }

            if (imagenumber == 2)
            {
                
            }

            if (imagenumber == 3)
            {
                
            }

            if (imagenumber == 4)
            {
                
            }

            if (imagenumber == 5)
            {
               
            }

            if (imagenumber == 6)
            {
                
            }

            if (imagenumber == 7)
            {
                
            }

            if (imagenumber == 8)
            {
                
            }

            if (imagenumber == 9)
            {
                
            }

            if (imagenumber == 10)
            {
                
            }

            if (imagenumber == 11)
            {
               
            }

            if (imagenumber == 12)
            {
                
            }

            if (imagenumber == 13)
            {
                
            }

            if (imagenumber == 14)
            {
                
            }

            if (imagenumber == 15)
            {
                      
            }

            if (imagenumber == 16)
            {
                
            }

            if (imagenumber == 17)
            {
               
            }

            if (imagenumber == 18)
            {
                
            }

            if (imagenumber == 19)
            {
                
            }

            if (imagenumber == 20)
            {
                
            }

            if (imagenumber == 21)
            {
                
            }

            if (imagenumber == 22)
            {
                
            }
        }

        private void pbFirstimage_Click(object sender, EventArgs e)
        {
            color = Color.Yellow; // andere logica
        }

        private void pbSecondimage_Click(object sender, EventArgs e)
        {
            color = Color.Green; // andere logica
        }

        private void pbThirdimage_Click(object sender, EventArgs e)
        {
            color = Color.Red; // andere logica
        }

        private void pbFourthimage_Click(object sender, EventArgs e)
        {
            color = Color.Purple; // andere logica
        }

        private void pbFifthimage_Click(object sender, EventArgs e)
        {
            color = Color.Blue; // andere logica
        }

        private void pbAnswerone_Click(object sender, EventArgs e)
        {
            //pbAnswerone.BackColor = color;
            //box1 = true;

        }

        private void pbAnswertwo_Click(object sender, EventArgs e)
        {
            
            //pbAnswertwo.BackColor = color;
            //box2 = true;
        }

        private void pbAnswerthree_Click(object sender, EventArgs e)
        {
            //pbAnswerthree.BackColor = color;
            //box3 = true;
        }

        private void pbAnswerfour_Click(object sender, EventArgs e)
        {
            //pbAnswerfour.BackColor = color;
            //box4 = true;
        }

        private void pbAnswerfive_Click(object sender, EventArgs e)
        {
            //pbAnswerfive.BackColor = color;
            btnCheck.Visible = true;
            //box5 = true;
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
            var img = pbFirstimage.Image;
            if (img == null) return;
            if (DoDragDrop(img, DragDropEffects.Move) == DragDropEffects.Move)
            {
                //pb1.Image = null;
            }
        }

        private void pbSecondimage_MouseDown(object sender, MouseEventArgs e)
        {
            var img = pbSecondimage.Image;
            if (img == null) return;
            if (DoDragDrop(img, DragDropEffects.Move) == DragDropEffects.Move)
            {
                //pb1.Image = null;
            }
        }

        private void pbThirdimage_MouseDown(object sender, MouseEventArgs e)
        {
            var img = pbThirdimage.Image;
            if (img == null) return;
            if (DoDragDrop(img, DragDropEffects.Move) == DragDropEffects.Move)
            {
                //pb1.Image = null;
            }
        }

        private void pbFourthimage_MouseDown(object sender, MouseEventArgs e)
        {
            var img = pbFourthimage.Image;
            if (img == null) return;
            if (DoDragDrop(img, DragDropEffects.Move) == DragDropEffects.Move)
            {
                //pb1.Image = null;
            }
        }

        private void pbFifthimage_MouseDown(object sender, MouseEventArgs e)
        {
            var img = pbFifthimage.Image;
            if (img == null) return;
            if (DoDragDrop(img, DragDropEffects.Move) == DragDropEffects.Move)
            {
                //pb1.Image = null;
            }
        }

        private void pbAnswerone_DragDrop(object sender, DragEventArgs e)
        {
            var bmp = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pbAnswerone.Image = bmp;
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
