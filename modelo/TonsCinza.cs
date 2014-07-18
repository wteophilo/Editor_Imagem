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
    class TonsCinza
    {
        public TonsCinza(){}            

        public Image aplicarNaImagem(Image imagem){

            Bitmap imagemAlterada = new Bitmap(imagem);
            for (int i = 0; i < imagemAlterada.Width; i++)
            {
                for (int j = 0; j < imagemAlterada.Height; j++)
                {
                    Color c = imagemAlterada.GetPixel(i, j);
                    int gs = (int)(c.R * 0.3 + c.G * 0.59 + c.B * 0.11);

                    imagemAlterada.SetPixel(i, j, Color.FromArgb(c.A, gs, gs, gs));
                }

            }
            return imagemAlterada;
        }

    }
}
