using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Effect
{
    public partial class Form1 : Form
    {
        #region Parameters

        int x, y;

        int k, y2, m;

        int k1 = 0;

        int r1, r2;

        Point u;
        

        #endregion

        #region Definition

        Random r = new Random();

        #endregion

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            lblH.Text = this.Height.ToString();
            LblW.Text = this.Width.ToString();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 100;

            u = this.Location;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            k1++;

            k = r.Next(0, 256);
            y2 = r.Next(0, 256);
            m = r.Next(0, 256);



            this.BackColor = Color.FromArgb(k, y2, m);

            label1.Text = k1.ToString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            r1 = r.Next(1, 10);
            r2 = r.Next(1, 10);

            u.X += r1;
            u.Y += r2;

            LblX.Text = u.X.ToString();
            LblY.Text = u.Y.ToString();

            this.Location = new Point(u.X, u.Y);

            x = r.Next(1, 10);
            y = r.Next(1, 10);

            this.Height += x;
            this.Width += y;

            lblH.Text = this.Height.ToString();
            LblW.Text = this.Width.ToString();

            if (this.Height>=400 && this.Width>=600)
            {
                timer1.Stop();
                timer2.Start();
            }
        }
    }
}
