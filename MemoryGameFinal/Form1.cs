using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGameFinal
{
    public partial class Form1 : Form
    {

        List<int> numbers = new List<int>{1,1,2,2,3,3,4,4,5,5,6,6,7,7,8,8};
        private string firstClicked;
        private string secondClicked;
       
        List<PictureBox> pictures = new List<PictureBox>();
        private PictureBox picA;
        private PictureBox picB;
        
        bool gameOver = false;
        public Form1()
        {
            InitializeComponent();
            LoadPictures();
        }

        private void lStratus_Click(object sender, EventArgs e)
        {

        }

      

        private void RestartGameEvent(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void LoadPictures()
        {
            int leftPos = 20;
            int topPos = 20;
            int rows = 0;
            for (int i = 0; i < 16; i++)
            {
                PictureBox newPic = new PictureBox();
                newPic.Height = 50;
                newPic.Width = 50;
                newPic.BackColor = Color.Aqua;
                newPic.SizeMode = PictureBoxSizeMode.StretchImage;
                newPic.Click += NewPic_Click;
                pictures.Add(newPic);

                if (rows < 4 )
                {
                    rows++;
                    newPic.Left = leftPos;
                    newPic.Top = topPos;
                    this.Controls.Add(newPic);
                    leftPos = leftPos + 60; 
                    
                }
                if (rows == 4)
                {
                    rows = 0;
                    leftPos = 20;
                    topPos = topPos + 60;
                }
            }

            RestartGame();
        }

        private void NewPic_Click(object sender, EventArgs e)
        {
            if (gameOver)
            {
                return;
            }
            if (firstClicked == null)
            {
               picA = sender as PictureBox;
               if (picA.Tag != null && picA.Image == null)
               {
                    picA.Image = Image.FromFile("pictures/" + (string)picA.Tag + ".png");
                    firstClicked = (string)picA.Tag;

                }
                
            }
            else if ( secondClicked == null)
            {
                picB = sender as PictureBox;

                if (picB.Tag != null && picB.Image == null)
                {
                    picB.Image = Image.FromFile("pictures/" + (string)picB.Tag + ".png");
                    secondClicked = (string)picB.Tag;
                }
            }
            else
            {
                CheckForMatch(picA, picB);
            }
        }

        private void RestartGame()
        {
            var randomList = numbers.OrderBy(x => Guid.NewGuid()).ToList();
            numbers = randomList;

            for (int i = 0; i < pictures.Count; i++)
            {
                pictures[i].Image = null;
                pictures[i].Tag = numbers[i].ToString();
            }

            gameOver = false;
        }

        private void CheckForMatch(PictureBox A, PictureBox B)
        {
            if (firstClicked == secondClicked)
            {
                A.Tag = null;
                B.Tag = null;
            }
           
            firstClicked = null;
            secondClicked = null;

            foreach (PictureBox pics in pictures)
            {
                if (pics.Tag != null)
                {
                    pics.Image = null;
                }
            }

            if (pictures.All(o => o.Tag == pictures[0].Tag))
            {
               GameOver("GG you won , Try again if you want ");
            }

        }


        private void GameOver(string msg)
        {
            GameTimer.Stop();
            gameOver = true;
            MessageBox.Show(msg);
        }
    }
}
