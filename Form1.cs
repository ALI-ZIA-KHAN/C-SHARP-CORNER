using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ASSIGNMENTOOPQ3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int score = 0;
        SoundPlayer p_1 = new SoundPlayer(@"D:\explosion.wav");
        SoundPlayer p_2 = new SoundPlayer(@"D:\background.wav");
        PictureBox[] ghost = new PictureBox[4];
        PictureBox p1 = new PictureBox();

        private void Form1_Load(object sender, EventArgs e)
        {
            p_2.Play();
            ghost[0] = pictureBox2;
            ghost[1] = pictureBox3;
            ghost[2] = pictureBox4;
            ghost[0].Show();
            ghost[1].Show();
            ghost[2].Show();
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left -= 9;
            for(int i = 0; i < 3; i++)
            {
                if (pictureBox1.Bounds.IntersectsWith(ghost[i].Bounds) && ghost[i].Visible)
                {
                    p_1.Play();
                    this.Controls.Add(p1);
                    p1.BringToFront();
                    p1.SizeMode = PictureBoxSizeMode.StretchImage;
                    p1.Size = new Size(100, 100);
                    p1.BackColor = Color.Transparent;
                    p1.Location = ghost[i].Location;

                   p1.Image = Image.FromFile(@"D:\hi.png");
                    ghost[i].Hide();
                    p1.Show();
                    score += 1;

                }

            }

            label1.Text = "Score is     \t" + score;
           
        
        
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            
            int j = r.Next(50, 500);
            
            pictureBox2.Location = new Point(50+j, 10+j);
            pictureBox3.Location = new Point(150+j, 70+j);
            pictureBox4.Location = new Point(300+j, 130+j);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
          
        }
    }
}
