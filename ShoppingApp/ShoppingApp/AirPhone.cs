using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingApp
{
    public partial class AirPhone : Form
    {
        private int xPos = 0;
        public AirPhone()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer();
            splayer.SoundLocation = @".\my.wav";
            splayer.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer();
            splayer.SoundLocation = @".\my.wav";
            splayer.Play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Width == xPos)
            {
                //repeat marquee
                this.lblMarquee.Location = new Point(159, 13);
                xPos = 0;
            }
            else
            {
                this.lblMarquee.Location = new Point(xPos, 13);
                xPos++;
            }
        }

        private void AirPhone_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
