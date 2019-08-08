using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    public class Formulas
    {
        public void ConvertToGrayscale(Image imagemOriginal, Image imagemAlterada)
        {
            Bitmap imagem = new Bitmap(imagemOriginal);
            int x, y;

            for(x = 0; x < imagem.Width; x++)
            {
                for(y = 0; y < imagem.Height; y++)
                {
                    Color pixel = imagem.GetPixel(x, y);

                    int a = pixel.A;
                    int r = pixel.R;
                    int g = pixel.G;
                    int b = pixel.B;

                    int avg = (r + g + b) / 3;

                    imagem.SetPixel(x, y, Color.FromArgb(a, avg, avg, avg));
                }
            }
            imagemAlterada = imagemOriginal;
        }
    }
}
