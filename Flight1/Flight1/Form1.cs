using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const double dt = 0.01;
        const double g = 9.81;
        double y = 0;
        double t = 0;
        double x = 0;
        double y0;
        double v0;
        double a;
        private void flStart_Click(object sender, EventArgs e)
        {
            
            y0 = (double)flUDHeight.Value;
            v0 = (double)flUDSpeed.Value;
            a = (double)flUDAngle.Value;
            y = y0;
            x = 0;
            t = 0;
            
            chart1.Series[0].Points.Clear();
            chart1.Series[0].Points.AddXY(x, y);

            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t += dt;
            x = v0 * Math.Cos(a * Math.PI / 180) * t;
            y = y0 + v0 * Math.Sin(a * Math.PI / 180) * t - g * t * t / 2;
            chart1.Series[0].Points.AddXY(x, y);
            if (y <= 0) timer1.Stop();
            time.Text = "Time: " + t;
        }

        private void pause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void play_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
