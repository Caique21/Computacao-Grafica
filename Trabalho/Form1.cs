using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho
{
    public partial class Form1 : Form
    {
        private int width;
        private int height;
        private Boolean click;

        public Form1()
        {
            InitializeComponent();
            click = false;
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            lbH.Text = trackBar1.Value.ToString();
            if (pictureBox1.Image != null && click)
                desconverter(trackBar1.Value,trackBar2.Value,trackBar3.Value,1);
        }

        private void TrackBar2_Scroll(object sender, EventArgs e)
        {
            lbS.Text = trackBar2.Value.ToString();
            if (pictureBox1.Image != null && click)
                desconverter(trackBar1.Value, trackBar2.Value, trackBar3.Value, 2);
        }

        private void TrackBar3_Scroll(object sender, EventArgs e)
        {
            lbI.Text = trackBar3.Value.ToString();
            if (pictureBox1.Image != null && click)
                desconverter(trackBar1.Value, trackBar2.Value, trackBar3.Value, 3);
        }

        private void desconverter(int H, int S, int I, int tipo)
        {
            int h = (int)(H * Math.PI / 180);
            int s = S / 100;
            int i = I / 255;
            int r, g, b;

            double x = i * (1 - s);
            double y = i * (1 + (s * Math.Cos(h) / Math.Cos(Math.PI / 3 - h)));
            double z = 3 * i - (x + y);

            if(h > 2 * Math.PI/3)
            {
                b = (int)x;
                r = (int)y;
                g = (int)z;
            }
            else if(2*Math.PI/3 <= h && h < 4 * Math.PI / 3)
            {
                h = (int)(h - 2 * Math.PI / 3);
                r = (int)x;
                g = (int)y;
                b = (int)z;
            }
            else if(4*Math.PI/3 <= h && h < 2*Math.PI)
            {
                h = (int)(h - 4 * Math.PI / 3);
                g = (int)x;
                b = (int)y;
                r = (int)z;
            }
        }

        private void BtAbrirImagem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap img = new Bitmap(openFileDialog1.FileName);
                
                width = img.Width;
                height = img.Height;

                pictureBox1.Image = img;
                convertToGray();
            }
        }

        private void PictureBox1_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(pictureBox1.Image != null && !click)
            {
                //585 largura maxima
                //267 altura maxima
                Bitmap imagem = new Bitmap(pictureBox1.Image);
                int x;
                int y;

                x = e.Location.X * width / 585;
                y = e.Location.Y * height / 267;

                Color pixel = imagem.GetPixel(x, y);

                int a = pixel.A;
                int b = pixel.B;
                int g = pixel.G;
                int r = pixel.R;

                lbRGBvalue.Text = "(" + r + "," + g + "," + b + ")";

                ///// CMY ///////////////////////////////////////////
                int c = 255 - r;
                int m = 255 - g;
                int k = 255 - b;

                lbCMYvalue.Text = "(" + c + "," + m + "," + k + ")";

                ////// HSI/////////////////////////////////////////
                double sum = (r + g + b);
                double rl = r > 0 ? (r / sum) : 0;
                double gl = g > 0 ? (g / sum) : 0;
                double bl = b > 0 ? (b / sum) : 0;

                double i = (r + g + b) / (3);
                double s = 1 - 3 * (Math.Min(Math.Min(rl, gl), bl));
                double h;
                if (r == b && b == g)
                    h = 0;
                else if (b <= g)
                    h = Math.Acos(0.5 * ((r - g) + (r - b)) / Math.Sqrt(((r - g) * (r - g)) + ((r - b) * (g - b))));
                else
                    h = 2 * Math.PI - Math.Acos(0.5 * ((r - g) + (r - b)) / Math.Sqrt(((r - g) * (r - g)) + ((r - b) * (g - b))));
                s = (Math.Truncate(100 * s) / 100)*100;
                h = (h * 180 / Math.PI);
                h = Convert.ToInt32((Math.Truncate(100 * h) / 100));

                lbHSIvalue.Text = "(" + h + "," + s + "," + i + ")";

                trackBar1.Value = Convert.ToInt32(h);
                lbH.Text = h.ToString();

                trackBar2.Value = Convert.ToInt32(s);
                lbS.Text = s.ToString();

                trackBar3.Value = Convert.ToInt32(i);
                lbI.Text = i.ToString();
            }
        }

        public void convertToGray()
        {
            Bitmap img = new Bitmap(pictureBox1.Image);
            for(int x = 0; x < width; x++)
            {
                for(int y = 0; y < height; y++)
                {
                    Color pixel = img.GetPixel(x, y);

                    int a = pixel.A;
                    int b = pixel.B;
                    int g = pixel.G;
                    int r = pixel.R;

                    int avg = (r + b + g) / 3;
                    img.SetPixel(x, y, Color.FromArgb(a, avg, avg, avg));
                }
            }
            pictureBox2.Image = img;
            pictureBox3.Image = img;
            pictureBox4.Image = img;
        }

        public void changeItensity()
        {

        }

        public void changeSaturation()
        {
            
        }

        private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!click)
                click = true;
            else
                click = false;
        }
    }
}
