using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0617
{
    public partial class Form1 : Form
    {
        int vx = rand.Next(-10, 11);
        int vy = rand.Next(-10, 11);
        int vx2 = rand.Next(-10, 11);
        int vy2 = rand.Next(-10, 11);
        int vx3 = rand.Next(-10, 11);
        int vy3 = rand.Next(-10, 11);
        int count = 3;

        int score = 100;
        static Random rand = new Random();

        public Form1()
        {
            InitializeComponent();

            label1.Left = rand.Next(ClientSize.Width-label1.Width);
            label1.Top = rand.Next(ClientSize.Height-label1.Height);
            label4.Left = rand.Next(ClientSize.Width - label4.Width);
            label4.Top = rand.Next(ClientSize.Height - label4.Height);
            label5.Left = rand.Next(ClientSize.Width - label5.Width);
            label5.Top = rand.Next(ClientSize.Height - label5.Height);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point spos = MousePosition;
            Point fpos = PointToClient(spos);
            label3.Left = fpos.X-label3.Width/2;
            label3.Top = fpos.Y-label3.Height/2;
            label3.Text = $"{fpos.X}, {fpos.Y}";

            label1.Left += vx;
            label1.Top += vy;
            label4.Left += vx2;
            label4.Top += vy2;
            label5.Left += vx3;
            label5.Top += vy3;

            if (label1.Left < 0)
            {
                vx = Math.Abs(vx);
            }
            if (label1.Right > ClientSize.Width)
            {
                vx = -Math.Abs(vx);
            }
            if (label1.Top < 0)
            {
                vy = Math.Abs(vy);
            }
            if (label1.Bottom > ClientSize.Height)
            {
                vy = -Math.Abs(vy);
            }

            if (label4.Left < 0)
            {
                vx2 = Math.Abs(vx2);
            }
            if (label4.Right > ClientSize.Width)
            {
                vx2 = -Math.Abs(vx2);
            }
            if (label4.Top < 0)
            {
                vy2 = Math.Abs(vy2);
            }
            if (label4.Bottom > ClientSize.Height)
            {
                vy2 = -Math.Abs(vy2);
            }

            if (label5.Left < 0)
            {
                vx3 = Math.Abs(vx3);
            }
            if (label5.Right > ClientSize.Width)
            {
                vx3 = -Math.Abs(vx3);
            }
            if (label5.Top < 0)
            {
                vy3 = Math.Abs(vy3);
            }
            if (label5.Bottom > ClientSize.Height)
            {
                vy3 = -Math.Abs(vy3);
            }


            score--;
            label2.Text = $"Score {score}";

            if (    (fpos.X >= label1.Left)
                &&  (fpos.X < label1.Right)
                &&  (fpos.Y >= label1.Top)
                &&  (fpos.Y < label1.Bottom)
                )
            {
                if (label1.Visible)
                {
                    count--;
                    label1.Visible = false;
                }
            }

            if ((fpos.X >= label4.Left)
                && (fpos.X < label4.Right)
                && (fpos.Y >= label4.Top)
                && (fpos.Y < label4.Bottom)
                )
            {
                if (label4.Visible)
                {
                    label4.Visible = false;
                    count--;
                }
            }

            if ((fpos.X >= label5.Left)
                && (fpos.X < label5.Right)
                && (fpos.Y >= label5.Top)
                && (fpos.Y < label5.Bottom)
                )
            {
                if (label5.Visible)
                {
                    count--;
                    label5.Visible = false;
                }
            }

            if (count <= 0)
            {
                timer1.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
