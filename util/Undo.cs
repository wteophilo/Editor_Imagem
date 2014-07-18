using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Image = System.Drawing.Image;

namespace br.wtcode.util
{
    class Undo
    {
        private Stack<Image> oldImagem;

        public Undo()
        {
            this.oldImagem = new Stack<Image>();            
        }

        public void add(Image image)
        {
            if (oldImagem.Count < 10)
            {
                oldImagem.Push(image);
            }

        }

        public void limpar()
        {
            this.oldImagem.Clear();
        }

        public Image undo()
        {
            if (oldImagem.Count > 2)
                return oldImagem.Pop();
            else
                return oldImagem.ElementAt(1);
        }

       

    }
}
