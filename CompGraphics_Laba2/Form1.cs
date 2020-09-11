using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompGraphics_Laba2
{
    public partial class Form1 : Form
    {
        Graphics g;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            g = pictureBox1.CreateGraphics();

            g.Clear(Color.FromArgb(254, 254, 254));
        }

        private void btnPixel_Click(object sender, EventArgs e)
        {
            g = pictureBox1.CreateGraphics();

            int ex = 0, ey = 0;
            float old_ex = 0, old_ey = 0;
            float x = 0, y = 0;
            Pen axesPen = new Pen(Color.Red, 1);
            Pen graphicsPen = new Pen(Color.FromArgb(0, 255, 0), 1);

            pictureBox1.BackColor = Color.FromName("Azure");
            pictureBox1.Refresh();

            g.PageUnit = GraphicsUnit.Pixel;

            g.DrawRectangle(axesPen, 0, 0, pictureBox1.Size.Width - 1,
                pictureBox1.Size.Height - 1);
            g.DrawLine(axesPen, 0, (pictureBox1.Size.Height - 1) / 2,
                pictureBox1.Size.Width - 1, (pictureBox1.Size.Height - 1) / 2);
            g.DrawLine(axesPen, (pictureBox1.Size.Width - 1) / 2, 0,
                (pictureBox1.Size.Width - 1) / 2, pictureBox1.Size.Height - 1);

            g.TranslateTransform((pictureBox1.Size.Width - 1)/2,
                (pictureBox1.Size.Height - 1) / 2);
            g.ScaleTransform(1, -1);

            x = -40f;
            while(x <= 40)
            {
                y = Convert.ToSingle(2 * Math.Pow(x, 3) + 2 * x);
                g.DrawLine(graphicsPen, old_ex, old_ey, x, y);

                old_ex = x;
                old_ey = y;

                x += 0.01f;
            }

            //g.TranslateTransform(0, 0);
            g.ScaleTransform(-1, 1);

            g.Dispose();
        }

        private void btnMills_Click(object sender, EventArgs e)
        {
            g = pictureBox1.CreateGraphics();

            int ex = 0, ey = 0;
            float old_ex = 0, old_ey = 0;
            float x = 0, y = 0;

            g.PageUnit = GraphicsUnit.Millimeter;
            Pen axesPen = new Pen(Color.Cyan, 0.1f);
            Pen graphicsPen = new Pen(Color.FromArgb(0, 0, 255), 0.1f);

            pictureBox1.BackColor = Color.FromKnownColor(KnownColor.ControlLightLight);
            pictureBox1.Refresh();

            int WidthInMM = Convert.ToInt16((pictureBox1.Size.Width - 1) /
            g.DpiX * 25.4);
            int HeightInMM = Convert.ToInt16((pictureBox1.Size.Height - 1) /
            g.DpiY * 25.4);

            g.DrawRectangle(axesPen, 0, 0, WidthInMM, HeightInMM - 0.5f);
            g.DrawLine(axesPen, 0, HeightInMM / 2, WidthInMM, HeightInMM / 2);
            g.DrawLine(axesPen, WidthInMM / 2, 0, WidthInMM / 2, HeightInMM);

            //g.TranslateTransform((pictureBox1.Size.Width - 1) / 2,
            //   (pictureBox1.Size.Height - 1) / 2);
            g.TranslateTransform(WidthInMM / 2, HeightInMM / 2);
            g.ScaleTransform(1, -1);

            x = -40f;
            while (x <= 40)
            {
                y = Convert.ToSingle(2 * Math.Pow(x, 3) + 2 * x);
                g.DrawLine(graphicsPen, old_ex, old_ey,
                    x / g.DpiX * 25.4f , y / g.DpiY * 25.4f);

                old_ex = x;
                old_ey = y;

                x += 0.01f;
            }

            g.ScaleTransform(-1, 1);

            g.Dispose();
        }

        private void Inches_Click(object sender, EventArgs e)
        {
            g = pictureBox1.CreateGraphics();

            int ex = 0, ey = 0;
            float old_ex = 0, old_ey = 0;
            float x = 0, y = 0;
            float shag = 0;

            g.PageUnit = GraphicsUnit.Inch;
            Pen axesPen = new Pen(Color.Orange, 0.01f);
            Pen graphicsPen = new Pen(Color.FromArgb(255, 0, 0), 0.01f);

            pictureBox1.BackColor = Color.FromName("LightCyan");
            pictureBox1.Refresh();

            float WidthInInches = (pictureBox1.Size.Width - 1) / g.DpiX;
            float HeightInInches = (pictureBox1.Size.Height - 1) / g.DpiY;

            g.DrawRectangle(axesPen, 0, 0, WidthInInches, HeightInInches);
            g.DrawLine(axesPen, 0, HeightInInches / 2, WidthInInches,
                HeightInInches / 2);
            g.DrawLine(axesPen, WidthInInches / 2, 0, WidthInInches / 2,
                HeightInInches);

            g.TranslateTransform(WidthInInches / 2, HeightInInches / 2);
            g.ScaleTransform(1, -1);

            x = -40f;
            while (x <= 40)
            {
                y = Convert.ToSingle(2 * Math.Pow(x, 3) + 2 * x);
                g.DrawLine(graphicsPen, old_ex, old_ey,
                    x, y);

                old_ex = x;
                old_ey = y;

                x += 0.01f;
            }

            g.ScaleTransform(-1, 1);

            g.Dispose();
        }
    }
}
