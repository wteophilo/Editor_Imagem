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
    
    class Negative
    {

        //<summary>
        //    Aplica o efeito negative na imagem.
        //        Calculo para o negative:
        //            Pixel = valorMaximoRBG - pixelSelecionado
        //</summary
        public Image aplicarNaImagem(Image imagem)
        {
            Bitmap imgAlterada = new Bitmap(imagem);
         
            for (int i = 0; i < imgAlterada.Width; i++)
            {
                for (int j = 0; j < imgAlterada.Height; j++)
                {
                    Color c = imgAlterada.GetPixel(i, j);
                    int r = 255 - c.R;
                    int g = 255 - c.G ;
                    int b = 255 - c.B ;
                    imgAlterada.SetPixel(i, j, Color.FromArgb(c.A, r, g, b));
                }
            }

            return imgAlterada;
        }

    }
}
