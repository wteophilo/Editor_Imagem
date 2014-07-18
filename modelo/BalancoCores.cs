using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageAttributes = System.Drawing.Imaging.ImageAttributes;
using Graphics = System.Drawing.Graphics;
using Bitmap = System.Drawing.Bitmap;
using Color= System.Drawing.Color;
using GraphicsUnit = System.Drawing.GraphicsUnit;
 

namespace br.wtcode.imagem.efeito
{

    //<sumamry>
    //    Classe  Balanço de Cores
    //</summary>
    //<remarks>
    // Está classe tem a função de aplicar: brilho,contraste e gamma na imagem.
    //</remarks>
    class BalancoCores
    {
        private Bitmap novaImagem;
        private double r;
        private double g;
        private double b;
        
        public BalancoCores(System.Drawing.Image imagem)
        {
            this.novaImagem= new Bitmap(imagem);
            this.r = 0;
            this.g = 0;
            this.b = 0;
        }

        //<summary>
        //    Aplica brilho na imagem.

        //</summary>
        //<param name ="brilho">valor em porcetagem</param>
        public void alteraBrilho(int brilho)
        {
            if (brilho != 0) {
                brilho += brilho / 100;
                for (int i = 0; i < this.novaImagem.Width; i++)
                {
                    for (int j = 0; j < this.novaImagem.Height; j++)
                    {
                        Color c = this.novaImagem.GetPixel(i, j);
                        this.r = c.R + brilho;
                        this.g = c.G + brilho;
                        this.b = c.B + brilho;
                        ajustaRGB();
                        this.novaImagem.SetPixel(i,j,Color.FromArgb(c.A,(byte)r,(byte)g,(byte)b));
                    }
                }
            }
        }

        //<summary>
        //    Aplica contraste na imagem.
        //    Calculo do contraste:
        //                C = ((100+ variavel)/100)
        //                B = ((B/255)-0,5)* C ) + 0,5) * 255
        //                G = ((G/255)-0,5)* C ) + 0,5) * 255
        //                R = ((R/255)-0,5)* C ) + 0,5) * 255
        //</summary>
        //<param name ="contraste">valor em porcetagem</param>
        public void alteraContraste(double contraste)
        {
            if (contraste != 0) {
                contraste =  (100.00+contraste) / 100;
                contraste *= contraste;
                for (int i = 0; i < this.novaImagem.Width; i++)
                {
                    for (int j = 0; j < this.novaImagem.Height; j++)
                    {
                        Color c = this.novaImagem.GetPixel(i, j);

                        this.r = c.R / 255.0; r -= 0.5;
                        r *= contraste;
                        r += 0.5;
                        r *= 255;

                        if (this.r > 255) this.r = 255;
                        if (this.r < 0) this.r = 0;

                        this.g = c.G / 255.0;
                        g -= 0.5;
                        g *= contraste;
                        g += 0.5;
                        g *= 255;

                        if (this.g > 255) this.g = 255;
                        if (this.g < 0)this.g = 0;
                    

                        this.b = c.B / 255.0;
                        b -= 0.5;
                        b *= contraste;
                        b += 0.5;
                        b *= 255;

                        if (this.b > 255) this.b = 255;
                        if (this.b < 0) this.b = 0;
                        

                        
                        this.novaImagem.SetPixel(i, j, Color.FromArgb(c.A, (byte)r, (byte)g, (byte)b));
                    }
                }
            }
        }

        public void alteraGamma(float gamma)
        {
            gamma = ajustaGamma(gamma);
            if (gamma != 0) { 
                Bitmap imgAlterada = new Bitmap(this.novaImagem.Width, this.novaImagem.Height);
                Graphics g = Graphics.FromImage(imgAlterada);

                ImageAttributes atributos = new ImageAttributes();
                atributos.SetGamma(gamma);

                g.DrawImage(this.novaImagem, new System.Drawing.Rectangle(0, 0, novaImagem.Width, novaImagem.Height), 0, 0, novaImagem.Width, novaImagem.Height, GraphicsUnit.Pixel, atributos);
                g.Dispose();
                atributos.Dispose();
                this.novaImagem = imgAlterada;
            }
            
        }


        //<summary>
        //metodo ajustaGamma:
        //    Cores escuras > 1 de 5.0
        //    Cores claras < 1 de 0.1
        //</summary>
        private float ajustaGamma(float gamma)
        {
            if (gamma == 1)
            {
                return 0.50f;
            }
            else if (gamma == -1) 
            {
                return  2.50f;
            }
            return 0.0f;
        }


        private void ajustaRGB()
        {
            if (this.r > 255) this.r = 255;
            if (this.r < 0) this.r = 0;

            if (this.g > 255) this.g = 255;
            if (this.g < 0) this.g = 0;

            if (this.b > 255) this.b = 255;
            if (this.b < 0) this.b = 0;
            
        }


        public System.Drawing.Image getImagem()
        {
            return this.novaImagem;
        }
    }
}
