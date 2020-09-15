using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ooplabassignmentQ2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.Size = new Size(600, 600);
            PictureBox p1 = new PictureBox();
            p1.Image = Image.FromFile(@"D:\\build.jpg");
            p1.SizeMode = PictureBoxSizeMode.StretchImage;
            p1.Location = new Point(0, 0);

            p1.Size = new Size(580, 580);
            this.Controls.Add(p1);
            button1.Location = new Point(475, 20);
        }

        private void button1_Click(object sender, EventArgs e)


        {
            TrackBar t = new TrackBar();
            t.Location = new Point(20, 313);
            t.Size = new Size(400, 90);
            t.BackColor = Color.Brown;
            
            this.Controls.Add(t) ;
            t.BringToFront();




            Button[] fool = new Button[5];
            for (int i = 0; i <= fool.Length - 1; i++)
            {
                fool[i] = new Button();
                fool[i].Text = "floor" + i;
                fool[i].Size = new Size(150, 30);

                fool[i].Location = new Point(130, 125-(i*20));
                //   fool[i].Top = 55 * i;
                //   fool[i].Left = 10 ;
                fool[i].BackColor = Color.LightPink;
                this.Controls.Add(fool[i]);
                fool[i].BringToFront();
            }

                Label[] balcony = new Label[4];
                 for(int i= 1; i <= balcony.Length - 1; i++)
                {
                    balcony[i] = new Label();
                    balcony[i].Text = "balcony" + i;

                balcony[i].Size = new Size(350, 27);
                     balcony[i].Location = new Point(50, 250-(i*30));
                //     balcony[j].Top = 51 * j;
                //    balcony[i].Left = 10 ;
                balcony[i].BackColor = Color.Beige;
                balcony[i].TextAlign = ContentAlignment.MiddleCenter;
                this.Controls.Add(balcony[i]);
                    balcony[i].BringToFront();
          
                }
            TextBox[] milk = new TextBox[4];
            for (int i = 1; i <= milk.Length - 1; i++)
            {
                milk[i] = new TextBox();
                milk[i].Text = "Bottom floors" + i;

                milk[i].Size = new Size(260, 70);
                milk[i].Location = new Point(80, 310- (i * 20));
                //     balcony[j].Top = 51 * j;
                //    balcony[i].Left = 10 ;
                milk[i].BackColor = Color.LightGreen;
                milk[i].TextAlign = HorizontalAlignment.Center;
                this.Controls.Add(milk[i]);
                milk[i].BringToFront();

            }





        }
    }
}
