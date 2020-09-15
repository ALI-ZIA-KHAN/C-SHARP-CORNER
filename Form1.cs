using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentoopQ1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double car1_speed = 0;
        double car2_speed = 0;
        double distance_to_be_covered=920;
        double car1_time=0;
        double car2_time = 0;

        private void trackBar2_Scroll(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random car1 = new Random();
            int j = car1.Next(0, 20);
            pictureBox1.Location = new Point(pictureBox1.Location.X + j, pictureBox1.Location.Y);
            car1_time++;
            if (pictureBox1.Left > 915)
            {
                timer1.Stop();
                car1_speed = distance_to_be_covered / car1_time;
                label1.Text = "The speed of car-1 is:" + Convert.ToString(Math.Round(car1_speed,2));
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random car1 = new Random();
            int k= car1.Next(0, 20);
            pictureBox2.Location = new Point(pictureBox2.Location.X + k, pictureBox2.Location.Y);
            car2_time++;
            if (pictureBox2.Left > 915)
            {
                timer2.Stop();
                car2_speed = distance_to_be_covered / car2_time;
                label2.Text = "The speed of car-2 is:" + Convert.ToString(Math.Round(car2_speed, 2));
            }

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Left > 915 && pictureBox2.Left > 915)
                {
                timer3.Stop();
                if (car1_speed > car2_speed)
                {
                    MessageBox.Show("The car-1 won" + Environment.NewLine + "speed:\t" +Math.Round(car1_speed,2) +"pixels per tick"+ Environment.NewLine + "TIME\t" + car1_time +"ms");
                }
                else
                {
                    MessageBox.Show("The car-2 won" + Environment.NewLine + "speed:\t" +Math.Round (car2_speed, 2) + "pixels per tick" + Environment.NewLine + "TIME\t" + car2_time+"ms");
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
