using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSGOCoinFlipper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static Random random = new Random();
        public double GetRandomNumber(double minimum, double maximum)
        {
            return random.NextDouble() * (maximum - minimum) + minimum;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double value = GetRandomNumber(0.0000000000f, 100.0000000000f);
            if (value <= 50f)
            {
                pictureBox1.Image = Properties.Resources.terrorist;
                pictureBox1.Refresh();
                pictureBox1.Visible = true;
                label1.Text = "You Got Terrorists With A Value of: \n" + value;
                label1.Visible = true;
            }
            else if (value >= 50f)
            {
                pictureBox1.Image = Properties.Resources.counter_terrorist;
                pictureBox1.Refresh();
                pictureBox1.Visible = true;
                label1.Text = "You Got Counter-Terrorists With A Value of: \n" + value;
                label1.Visible = true;
            }
        }
        public void outcome()
        {
            double value = GetRandomNumber(0.0000000000f, 100.0000000000f);
            double value1 = GetRandomNumber(0.0000000000f, 100.0000000000f);
            double value2 = GetRandomNumber(0.0000000000f, 100.0000000000f);
            double value3 = GetRandomNumber(0.0000000000f, 100.0000000000f);
            double value4 = GetRandomNumber(0.0000000000f, 100.0000000000f);
            double value5 = GetRandomNumber(0.0000000000f, 100.0000000000f);
            double value6 = GetRandomNumber(0.0000000000f, 100.0000000000f);
            double value7 = GetRandomNumber(0.0000000000f, 100.0000000000f);
            double value8 = GetRandomNumber(0.0000000000f, 100.0000000000f);
            double value9 = GetRandomNumber(0.0000000000f, 100.0000000000f);
            string result = (value + "\n" + value1 + "\n" + value2 + "\n" + value3 + "\n" + value4 + "\n" + value5 + "\n" + value6 + "\n" + value7 + "\n" + value8 + "\n" + value9 + "\n");
            double divided = ((value + value1 + value2 + value3 + value4 + value5 + value6 + value7 + value8 + value9) / 10);
            if(divided <= 50f)
            {
                pictureBox1.Image = Properties.Resources.terrorist;
                pictureBox1.Refresh();
                pictureBox1.Visible = true;
                label1.Text = "You Got Terrorists With A Value of: \n" + divided;
                label1.Visible = true;
            }
            else if(divided >= 50f)
            {
                pictureBox1.Image = Properties.Resources.counter_terrorist;
                pictureBox1.Refresh();
                pictureBox1.Visible = true;
                label1.Text = "You Got Counter-Terrorists With A Value of: \n" + divided;
                label1.Visible = true;
            }
            MessageBox.Show("The 10 results are:\n\n" + result + "\nNow, if we divide these by 10, we get:\n\n" + divided);
        }

        public void button2_Click(object sender, EventArgs e)
        {
            outcome();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Created by icecoldcoke on Steam\n\nWould You Like View My Steam Profile?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("http://steamcommunity.com/id/icecoldcoke/");
            }
            else if(Result == DialogResult.No)
            {

            }
        }
    }
}
