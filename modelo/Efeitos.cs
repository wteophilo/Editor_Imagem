using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Image = System.Drawing.Image;

namespace br.wtcode.imagem.efeito
{
    class Efeitos
    {
        private IConvolution convolution;

        public void setEfeito(IConvolution iConvolution)
        {
            this.convolution = iConvolution;
        }


        public Image aplicaEfeito(Image image ){
            this.convolution.aplicaConvolution(image);
            return this.convolution.getImagem();
        }

    }
}
