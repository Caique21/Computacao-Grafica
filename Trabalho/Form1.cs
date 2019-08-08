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

        public Form1()
        {
            InitializeComponent();
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            lbBrilho.Text = trackBar1.Value.ToString();
        }

        private void TrackBar2_Scroll(object sender, EventArgs e)
        {
            lbMatiz.Text = trackBar2.Value.ToString();
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
            if(pictureBox1.Image != null)
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
    }
}
