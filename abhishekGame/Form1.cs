using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using WMPLib;

using System.Windows.Forms;

namespace abhishekGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

            wplayer.URL = @"C:\Users\sai\Desktop\abhi\bm.mp3";
            wplayer.Controls.Play();

           
 
        }

       
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;

           
                if (e.KeyCode == Keys.Right && x< label3.Left)
                {
                  
                    x += 10;
                    label1.Text = " " + x;
                    
                }
                else if (e.KeyCode == Keys.Left & x> label1.Right)
                {
                    x -= 10;
                    label3.Text = " " + x;
                 
                }
                pictureBox1.Location = new Point(x, y);
          
             
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int s1 = 2;
            int s2 = 1;
            int s3 = 3;

            int b1x = pictureBox2.Location.X;
            int b1y = pictureBox2.Location.Y;
            
            int b2x = pictureBox3.Location.X;
            int b2y = pictureBox3.Location.Y;

            int b3x = pictureBox4.Location.X;
            int b3y = pictureBox4.Location.Y;

            int coinx = pictureBox5.Location.X;
            int coiny = pictureBox5.Location.Y;

            label2.Text = ""+b1y;
            label4.Text = ""+b2y;
            label5.Text = ""+b3y;

            if (coiny < label6.Location.Y)
                pictureBox5.Location = new Point(coinx, coiny+ 1);

            else

                pictureBox5.Location = new Point(new Random().Next(label1.Left,label6.Left), 0);



            if (b1y < label6.Location.Y)

                pictureBox2.Location = new Point(b1x, b1y + s1);
            else
            {
                pictureBox2.Location = new Point(b1x, 0);
                s1 = new Random().Next(1, 3);

            }
            if (b2y < label6.Location.Y)

                pictureBox3.Location = new Point(b2x, b2y + s2);
            else
            {
                pictureBox3.Location = new Point(b2x, 0);
                s2 = new Random().Next(1, 2);
            }
            if (b3y < label6.Location.Y)
                pictureBox4.Location = new Point(b3x, b3y + s3);

            else
            {
                pictureBox4.Location = new Point(b3x, 0);
                s3 = new Random().Next(1,4);
            
            }
           
          
            /*if (b1y != b2y || b1y != b3y) {

                pictureBox2.Location = new Point(b1x, b1y+2);
                
                pictureBox3.Location = new Point(b3x, b3y+3);
            }
           if (b3y <= b1y || b3y >= b1y)
           {
               pictureBox2.Location = new Point(b1x, b1y + 2);
               pictureBox3.Location = new Point(b3x, b3y + 3);
           }

           if (b2y == b1y || b2y == b3y)
           {
               pictureBox4.Location = new Point(b3x, b3y + 1); 
           } 
            
       
            */
        }

     
       

        
    }
}
