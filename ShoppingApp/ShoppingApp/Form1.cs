using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MobileCover mb = new MobileCover();
            mb.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LeaderPurse l = new LeaderPurse();
            l.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AirPhone a = new AirPhone();
            a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Watch w = new Watch();
            w.Show();
        }
    }
}
