using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BalancoCores= br.wtcode.imagem.efeito.BalancoCores;

namespace WindowsFormsApplication3
{
    public partial class frmBalanco : Form
    {
        private BalancoCores balanco;
        private Image novaImagem;
        private int porcentagemBrilho;
        private int porcentagemContraste;
        private int porcentagemGamma;
        private Bitmap oldImage;
        


        public frmBalanco(Image imagem)
        {
            InitializeComponent();
            this.novaImagem = new Bitmap(imagem);
            this.balanco = new BalancoCores(imagem);
            this.porcentagemBrilho = 0;
            this.porcentagemContraste = 0;
            this.porcentagemGamma = 0;
            this.oldImage = new Bitmap(imagem);
        }

      

        private void Balanco_Load(object sender, EventArgs e)
        {

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            frmBalanco.ActiveForm.Close();
        }

        private void trackBrilho_Scroll(object sender, EventArgs e)
        {
            this.porcentagemBrilho = trackBrilho.Value * 10;
            lblPorcentBrilho.Text = Convert.ToString(porcentagemBrilho) + "%";
            
        }


        private void trackGamma_Scroll(object sender, EventArgs e)
        {
            this.porcentagemGamma = trackGamma.Value;
            lblPercentGamma.Text = Convert.ToString(porcentagemGamma);
        }

        private void trackContraste_Scroll(object sender, EventArgs e)
        {
            this.porcentagemContraste = trackContraste.Value;
            lblPercertContraste.Text = Convert.ToString(trackContraste.Value * 10) + "%";
        }

        public Image getImagem()
        {
            return this.novaImagem;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
             this.balanco.alteraBrilho(porcentagemBrilho);
             this.balanco.alteraContraste(porcentagemContraste);
             this.balanco.alteraGamma(porcentagemGamma);
             this.novaImagem = balanco.getImagem();
            this.Dispose();
        }

        private void trackBrilho_MouseUp(object sender, MouseEventArgs e)
        {
            this.balanco.alteraBrilho(porcentagemBrilho);
        }
    }
}
