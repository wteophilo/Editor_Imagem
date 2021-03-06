﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Image = System.Drawing.Image;
using Bitmap = System.Drawing.Bitmap;
using Color = System.Drawing.Color;

namespace br.wtcode.imagem.efeito
{
    public class ImagemSharpen : br.wtcode.imagem.efeito.IConvolution
    {
        private int[,] sharpen = { { 0, -1, 0 }, { -1, 5, -1 }, { 0, -1, 0 } };
        private Bitmap novaImg;
        private const double soma_sharpen = 1;
        private double r;
        private double g;
        private double b;

        public void aplicaConvolution(Image image)
        {
            r = 0;
            g = 0;
            b = 0;

            Color[,] pixelColor = new Color[3, 3];
            novaImg = new Bitmap(image);
           
            for (int y = 0; y < novaImg.Height - 2; y++)
            {
                for (int x = 0; x < novaImg.Width - 2; x++)
                {
                    pixelColor[0, 0] = novaImg.GetPixel(x, y);
                    pixelColor[0, 1] = novaImg.GetPixel(x, y + 1);
                    pixelColor[0, 2] = novaImg.GetPixel(x, y + 2);
                    pixelColor[1, 0] = novaImg.GetPixel(x + 1, y);
                    pixelColor[1, 1] = novaImg.GetPixel(x + 1, y + 1);
                    pixelColor[1, 2] = novaImg.GetPixel(x + 1, y + 2);
                    pixelColor[2, 0] = novaImg.GetPixel(x + 2, y);
                    pixelColor[2, 1] = novaImg.GetPixel(x + 2, y + 1);
                    pixelColor[2, 2] = novaImg.GetPixel(x + 2, y + 2);

                   int  a = pixelColor[1, 1].A;

                    r = ((pixelColor[0, 0].R * sharpen[0, 0]) +
                                 (pixelColor[1, 0].R * sharpen[1, 0]) +
                                 (pixelColor[2, 0].R * sharpen[2, 0])+
                                 (pixelColor[0, 1].R * sharpen[0, 1]) +
                                 (pixelColor[1, 1].R * sharpen[1, 1]) +
                                 (pixelColor[2, 1].R * sharpen[2, 1]) +
                                 (pixelColor[0, 2].R * sharpen[0, 2]) +
                                 (pixelColor[1, 2].R * sharpen[1, 2]) +
                                 (pixelColor[2, 2].R * sharpen[2, 2]));
                    
                    g = ((pixelColor[0, 0].G * sharpen[0, 0]) +
                                 (pixelColor[1, 0].G * sharpen[1, 0]) +
                                 (pixelColor[2, 0].G * sharpen[2, 0]) +
                                 (pixelColor[0, 1].G * sharpen[0, 1]) +
                                 (pixelColor[1, 1].G * sharpen[1, 1]) +
                                 (pixelColor[2, 1].G * sharpen[2, 1]) +
                                 (pixelColor[0, 2].G * sharpen[0, 2]) +
                                 (pixelColor[1, 2].G * sharpen[1, 2]) +
                                 (pixelColor[2, 2].G * sharpen[2, 2]));

                    b = ((pixelColor[0, 0].B * sharpen[0, 0]) +
                                (pixelColor[1, 0].B * sharpen[1, 0]) +
                                (pixelColor[2, 0].B * sharpen[2, 0]) +
                                (pixelColor[0, 1].B * sharpen[0, 1]) +
                                (pixelColor[1, 1].B * sharpen[1, 1]) +
                                (pixelColor[2, 1].B * sharpen[2, 1]) +
                                (pixelColor[0, 2].B * sharpen[0, 2]) +
                                (pixelColor[1, 2].B * sharpen[1, 2]) +
                                (pixelColor[2, 2].B * sharpen[2, 2]));



                    ajustaRGB(ref r, ref g, ref b);

                    novaImg.SetPixel(x, y, Color.FromArgb((int)a, (int)r, (int)g, (int)b));            
                }
            }
        }


        private static void ajustaRGB(ref double r, ref double g, ref double b)
        {
            if (r < 0) r = 0;
            if (r > 255) r = 255;
            if (g < 0) g = 0;
            if (g > 255) g = 255;
            if (b < 0) b = 0;
            if (b > 255) b = 255;
        }

        public Image getImagem()
        {
            return novaImg;
        }
    }
}
