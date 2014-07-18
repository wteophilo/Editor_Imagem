using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.wtcode.util
{
    class Mensagens
    {
        private Dictionary<String,String> mensagem = new Dictionary<String, String>();

        public Mensagens()
        {
            addMensagem();
        }

        private void addMensagem()
        {
            mensagem.Add("sharpen", "Aplicando Sharpen");
            mensagem.Add("noise", "Aplicando Ruido ");
            mensagem.Add("blur", "Aplicando Blur ");
            mensagem.Add("sobel", "Aplicando Sobel ");
            mensagem.Add("negative", "Aplicando Negative");
            mensagem.Add("cinza", "Aplicando Tons de Cinza");
            mensagem.Add("edge", "Aplicando Edge Detect");
        }

        public  String getMensagem(String chave)
        {
            if(mensagem.ContainsKey(chave)){
                String msg = mensagem[chave];
                return msg;
            }
            return null;
        }
    }
}
