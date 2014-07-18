using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Image = System.Drawing.Image;

namespace br.wtcode.imagem.efeito
{
    public interface IConvolution
    {
         void aplicaConvolution(Image image);
         Image getImagem();
    }
}
