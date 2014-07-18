using System;


namespace br.wtcode.util
{
    class RotacionarImagem
    {
        private System.Drawing.Bitmap novaImagem;
       
        public System.Drawing.Image rotacionar90ParaEsquerda(System.Drawing.Image imagem)
        {
            this.novaImagem = new System.Drawing.Bitmap(imagem);
            this.novaImagem.RotateFlip(System.Drawing.RotateFlipType.Rotate90FlipX);
            return this.novaImagem;
        }


        public System.Drawing.Image rotacionar90ParaDireita(System.Drawing.Image imagem)
        {
            this.novaImagem = new System.Drawing.Bitmap(imagem);
            this.novaImagem.RotateFlip(System.Drawing.RotateFlipType.Rotate90FlipY);
            return this.novaImagem;
        }

        public System.Drawing.Image rotacionar180(System.Drawing.Image imagem)
        {
            this.novaImagem = new System.Drawing.Bitmap(imagem);
            this.novaImagem.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipX);
            return this.novaImagem;
        }

        public System.Drawing.Image EspelharHorizontal(System.Drawing.Image imagem)
        {
            this.novaImagem = new System.Drawing.Bitmap(imagem);
            this.novaImagem.RotateFlip(System.Drawing.RotateFlipType.Rotate90FlipXY);
            this.novaImagem.RotateFlip(System.Drawing.RotateFlipType.Rotate90FlipX);
            
            return this.novaImagem;
        }

        public System.Drawing.Image EspelharVertical(System.Drawing.Image imagem)
        {
            this.novaImagem = new System.Drawing.Bitmap(imagem);
            this.novaImagem.RotateFlip(System.Drawing.RotateFlipType.Rotate90FlipXY);
            this.novaImagem.RotateFlip(System.Drawing.RotateFlipType.Rotate90FlipY);

            return this.novaImagem;
        }
     
    }
}
