using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class frmRedimensionar : Form
    {
        private Bitmap image;
        private int largura;
        private int altura;
        private Image imgAntiga;

        public frmRedimensionar(Image image)
        {
            InitializeComponent();
            this.image = new Bitmap(image);
            imgAntiga = image;
            this.lblTam.Text = "Tamanho Atual:" + this.image.Width + "x" + this.image.Height;
        }

        private void lblLargura_Click(object sender, EventArgs e)
        {

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            frmRedimensionar.ActiveForm.Close();
        }

        private void frmRedimensionar_Load(object sender, EventArgs e)
        {

        }

        private void radio600_CheckedChanged(object sender, EventArgs e)
        {
            this.largura = 600;
            this.altura = 480;
        }

        private void radio800_CheckedChanged(object sender, EventArgs e)
        {
            this.largura = 800;
            this.altura = 600;
        }

        private void radio1024_CheckedChanged(object sender, EventArgs e)
        {
            this.largura = 1024;
            this.altura = 768;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.largura = 1280;
            this.altura = 1024;
        }

        private void btRedimensionar_Click(object sender, EventArgs e)
        {
            if (this.iLargura.Text == "" || this.iAltura.Text == "")
            {
               // this.image.SetResolution(this.largura, this.altura);
                this.imgAntiga= image.GetThumbnailImage(this.largura, this.altura, null, IntPtr.Zero);
            }
            else
            {
                this.imgAntiga = image.GetThumbnailImage(Convert.ToInt32(iLargura.Text), Convert.ToInt32(iAltura.Text), null, IntPtr.Zero);

            }
            this.Dispose();
        }

        public Image getImagem()
        {
            return this.imgAntiga;
        }
        
    }
}
