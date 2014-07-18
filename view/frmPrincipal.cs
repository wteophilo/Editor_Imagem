using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Collections;
using ImagemBlur = br.wtcode.imagem.efeito.ImagemBlur;
using TonsCinza = br.wtcode.imagem.efeito.TonsCinza;
using Negative = br.wtcode.imagem.efeito.Negative;
using Ruido = br.wtcode.imagem.efeito.Ruido;
using Efeitos = br.wtcode.imagem.efeito.Efeitos;
using ImagemSharpen = br.wtcode.imagem.efeito.ImagemSharpen;
using ImagemEdgeDetect = br.wtcode.imagem.efeito.ImagemEdgeDetect;
using ImagemSobel = br.wtcode.imagem.efeito.ImagemSobel;
using Undo = br.wtcode.util.Undo;
using Mensagens = br.wtcode.util.Mensagens;
using RotacionarImagem =  br.wtcode.util.RotacionarImagem;

namespace WindowsFormsApplication3
{
    
    public partial class frmPrincipal : Form
    {
        private Boolean isSelecionado;
        private Undo undo = new Undo();
        private RotacionarImagem rotacionar = new RotacionarImagem();

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void abriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openFile.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.undo.limpar();
                imgPrincipal.Refresh();
                imgPrincipal.Image = Image.FromFile(openFile.FileName);
                this.undo.add(imgPrincipal.Image);
                habilitaScroll();
                posicionaScroll();
                habilitaStatusBar();
            }

        }

        private void habilitaScroll()
        {
            hScrollBar.Visible = false;
            vScrollBar.Visible = false;
            if (imgPrincipal.Width > 1110) hScrollBar.Visible = true;
            if (imgPrincipal.Height > 900) vScrollBar.Visible = true;
        }


        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            filtroDialog();
            habilitaScroll();
            escondeStatusBar();
        }

        private void escondeStatusBar()
        {
            StatusLabel.Visible = false;
            progressBar.Visible = false;
            statusBar.Visible = false;
        }

        private void habilitaStatusBar()
        {
            if (statusBar.Visible == false)
            {
                StatusLabel.Visible = true;
                progressBar.Visible = true;
                statusBar.Visible = true;
            }
        }

        private void posicionaScroll()
        {
            if (hScrollBar.Visible == true)
            {
                hScrollBar.Top = ( this.Height)-statusBar.Height-55;
                hScrollBar.Width = imgPrincipal.Width-20;
            }

            if (vScrollBar.Visible == true)
            {
                vScrollBar.Left = this.Width - 35;
                vScrollBar.Top =  menuBar.Height;
                vScrollBar.Height = imgPrincipal.Height - 125;
            }
        }


        public void filtroDialog()
        {
            openFile.Title = "Localizar Arquivos";
            openFile.DefaultExt = "jpg";
            openFile.Filter = "JPG (*.jpg)|*.jpg|PNG (*.png)|*.png|BMP (*.bmp)|*.bmp";
            openFile.FilterIndex = 1;


            saveFile.Title = "Salvar Arquivo";
            saveFile.DefaultExt = "jpg";
            saveFile.Filter = "JPG (*.jpg)|*.jpg|PNG (*.png)|*.png|BMP (*.bmp)|*.bmp";
            saveFile.FilterIndex = 1;
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFile.FileName.Length > 0 && imgPrincipal != null)
            {
                imgPrincipal.Image.Save(saveFile.FileName);
            }else{
                MessageBox.Show("Por favor abra uma imagem antes de salvar", "Aviso", MessageBoxButtons.OK);
            }    
        }

        private void salvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFile.ShowDialog() == DialogResult.OK && saveFile.FileName.Length > 0)
            {
                imgPrincipal.Image.Save(saveFile.FileName);
            }
        }

        private void versãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmAbout = new frmAbout();
            frmAbout.Show();
        }

        private void rotarcionarEsquerdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgPrincipal.Image != null)
            {
                this.undo.add(imgPrincipal.Image);
                imgPrincipal.Image = this.rotacionar.rotacionar90ParaEsquerda(imgPrincipal.Image);
                habilitaScroll();
                posicionaScroll();
            }
        }

        private void rotacionarDireitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgPrincipal.Image != null)
            {
                this.undo.add(imgPrincipal.Image);
                imgPrincipal.Image = this.rotacionar.rotacionar90ParaDireita(imgPrincipal.Image);
                habilitaScroll();
                posicionaScroll();
            }
        }

        private void flipVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgPrincipal.Image != null)
            {
                this.undo.add(imgPrincipal.Image);
                imgPrincipal.Image = this.rotacionar.EspelharVertical(imgPrincipal.Image);
            }
        }

        private void flipHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgPrincipal.Image != null)
            {
                this.undo.add(imgPrincipal.Image);
                imgPrincipal.Image = this.rotacionar.EspelharHorizontal(imgPrincipal.Image);
            }
        }

        private void rotacionar180ºToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgPrincipal.Image != null)
            {
                this.undo.add(imgPrincipal.Image);
                imgPrincipal.Image = this.rotacionar.rotacionar180(imgPrincipal.Image);
            }

        }

        private void redimensionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgPrincipal.Image != null) {
                this.undo.add(imgPrincipal.Image);
                frmRedimensionar redim = new frmRedimensionar(imgPrincipal.Image);
                DialogResult resultado = redim.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    imgPrincipal.Image= redim.getImagem();
                    habilitaScroll();
                    posicionaScroll();
                }   
            }
            else
            {
                MessageBox.Show("Carregue uma imagem antes de tentar redimensiona-la", "Aviso", MessageBoxButtons.OK);
            }
        }

        private void balançoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgPrincipal.Image != null)
            {
                this.undo.add(imgPrincipal.Image);
                frmBalanco balanco = new frmBalanco(imgPrincipal.Image);
                DialogResult resultado = balanco.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    imgPrincipal.Image = balanco.getImagem();
                    
                }
            }
        }

        private void desfazerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imgPrincipal.Image = undo.undo();
        }

        private void blurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgPrincipal.Image != null)
            {
                this.undo.add(imgPrincipal.Image);
                Efeitos efeitos = new Efeitos();
                efeitos.setEfeito(new ImagemBlur());
                startProcessBar("blur");
                imgPrincipal.Image = efeitos.aplicaEfeito(imgPrincipal.Image);
                endProcessBar();
            }
        }


        private void sharpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgPrincipal.Image != null)
            {
                this.undo.add(imgPrincipal.Image);
                Efeitos efeitos = new Efeitos();
                efeitos.setEfeito(new ImagemSharpen());
                startProcessBar("sharpen");
                imgPrincipal.Image = efeitos.aplicaEfeito(imgPrincipal.Image);
                endProcessBar();
            }
        }

        private void vScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            int alteracao = 0;
            if (vScrollBar.Visible)
            {
                alteracao = -(vScrollBar.Value * 10);
                imgPrincipal.Top = alteracao + menuBar.Height;

            }
        }

        private void hScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            imgPrincipal.Left = -(hScrollBar.Value+hScrollBar.Height);
            
        }

        private void softenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgPrincipal.Image != null)
            {
                this.undo.add(imgPrincipal.Image);
            }
        }

     
        private void sobelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgPrincipal.Image != null)
            {
                this.undo.add(imgPrincipal.Image);
                
                Efeitos efeitos = new Efeitos();
                efeitos.setEfeito(new ImagemSobel());
                startProcessBar("sobel");
                imgPrincipal.Image =  efeitos.aplicaEfeito(imgPrincipal.Image);
                endProcessBar();
            }

        }

        private void edgeDetectionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (imgPrincipal.Image != null)
            {
                this.undo.add(imgPrincipal.Image);
                Efeitos efeitos = new Efeitos();
                efeitos.setEfeito(new ImagemEdgeDetect());
                startProcessBar("edge");
                imgPrincipal.Image = efeitos.aplicaEfeito(imgPrincipal.Image);
                endProcessBar();
            }
        }

        private void tonsDeCinzaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (imgPrincipal.Image != null)
            {
                this.undo.add(imgPrincipal.Image);
                TonsCinza cinza = new TonsCinza();
                startProcessBar("cinza");
                imgPrincipal.Image = cinza.aplicarNaImagem(imgPrincipal.Image);
                endProcessBar();
            }
        }

        private void ruidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgPrincipal.Image != null)
            {
                this.undo.add(imgPrincipal.Image);
                Ruido ruido = new Ruido();
                startProcessBar("noise");
                imgPrincipal.Image = ruido.aplicarNaImagem(imgPrincipal.Image);
                endProcessBar();
            }
        }

        private void negativeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (imgPrincipal.Image != null)
            {
                this.undo.add(imgPrincipal.Image);
                Negative negative = new Negative();
                startProcessBar("negative");
                imgPrincipal.Image = negative.aplicarNaImagem(imgPrincipal.Image);
                endProcessBar();
            }
        }

        private void startProcessBar(String mensagem)
        {
            progressBar.Value = 15;
            Mensagens m = new Mensagens();
            StatusLabel.Text = m.getMensagem(mensagem);
            statusBar.Refresh();
        }

        private void endProcessBar()
        {
            progressBar.Value = 100;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
