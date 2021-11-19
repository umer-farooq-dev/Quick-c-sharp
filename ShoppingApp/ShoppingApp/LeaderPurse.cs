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
    public partial class LeaderPurse : Form
    {
        private int xPos = 0;
        public LeaderPurse()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer();
            splayer.SoundLocation = @".\my.wav";
            splayer.Play();

        }

        private void button4_Click(object sender, EventArgs e)
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
                this.lblMarquee.Location = new Point(143, 9);
                xPos = 0;
            }
            else
            {
                this.lblMarquee.Location = new Point(xPos, 9);
                xPos++;
            }
        }

        private void LeaderPurse_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
