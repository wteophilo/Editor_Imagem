using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bitmap = System.Drawing.Bitmap;
using Color = System.Drawing.Color;
using Image = System.Drawing.Image;


namespace br.wtcode.imagem.efeito
{
    
    class Ruido
    {
        private  const int valorRuido = 25;
        private int r;
        private int g;
        private int b;

        public Image aplicarNaImagem(Image imagem)
        {
            Bitmap imgAlterada = new Bitmap(imagem);
            this.r = 0;
            this.g = 0;
            this.b = 0;

            Random rnd = new Random();
            for (int i = 0; i < imgAlterada.Width; i++)
            {
                for (int j = 0; j < imgAlterada.Height; j++)
                {
                    Color c = imgAlterada.GetPixel(i, j);
                    r = c.R + rnd.Next(-valorRuido, valorRuido + 1);
                    g = c.G + rnd.Next(-valorRuido, valorRuido + 1);
                    b = c.B + rnd.Next(-valorRuido, valorRuido + 1);
                    ajustaRGB();
                    imgAlterada.SetPixel(i, j, Color.FromArgb(c.A, r, g, b));
                }
            }
            return imgAlterada;
        }


        private void ajustaRGB()
        {
            if (this.r > 255)
            {
                this.r = 255;
            }
            else if (this.r < 0)
            {
                this.r = 0;
            }


            if (this.g > 255)
            {
                this.g = 255;
            }
            else if (this.g < 0)
            {
                this.g = 0;
            }

            if (this.b > 255)
            {
                this.b = 255;
            }
            else if (this.b < 0)
            {
                this.b = 0;
            }
        }


    }
}
