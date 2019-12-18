using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{

    public partial class Form5 : Form
    {
        System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
        public Form5()
        {

            InitializeComponent();
            timer.Start();
        }

    /*    public bool CompareImgs(Bitmap img1, Bitmap img2)
        {
            
            if (img1.Width == img2.Width && img1.Height == img2.Height)
            {
                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        if(img1.GetPixel(i, j) == img2.GetPixel(i, j))
                        {
                            return true;
                        } else
                        {
                            return false;
                        }
                    }
                }
            }
                            
        }*/

        private void shuffleBtn_Click(object sender, EventArgs e)
        {
            List<Bitmap> OriginalPictureList = new List<Bitmap>();
            OriginalPictureList.Add(Properties.Resources._1);
            OriginalPictureList.Add(Properties.Resources._2);
            OriginalPictureList.Add(Properties.Resources._3);
            OriginalPictureList.Add(Properties.Resources._4);
            OriginalPictureList.Add(Properties.Resources._5);
            OriginalPictureList.Add(Properties.Resources._6);
            OriginalPictureList.Add(Properties.Resources._7);
            OriginalPictureList.Add(Properties.Resources._8);
            OriginalPictureList.Add(Properties.Resources._null);

            for (int i = 0; i < puzzleGb.Controls.Count; i++)
            {
                int[,] grid = new int[3, 3];

                Random rand = new Random();
                int id = rand.Next(0, OriginalPictureList.Count);
                ((PictureBox)puzzleGb.Controls[i]).Image = OriginalPictureList[id];
                
                if (i == 1)
                {
                    grid[0, 0] = id;
                }
                OriginalPictureList.RemoveAt(id);
                

            }
        
            timer.Restart();
            timer.Start();

            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            countL.Text = 0.ToString();
            this.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerL.Text = timer.Elapsed.TotalMinutes.ToString();
        }

        private void pauseBtn_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //CompareImgs((Bitmap)pictureBox4.Image, Properties.Resources._null);
            /*  if (pictureBox1.Image.)
              {
                  pictureBox4.Image = pictureBox1.Image;
                  pictureBox1.Image = Properties.Resources._null;
              }

              if (pictureBox2.Image.Equals(Properties.Resources._null))
              {
                  pictureBox2.Image = pictureBox1.Image;
                  pictureBox1.Image = Properties.Resources._null;
              }*/
        }
    }
}
