using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bitmap = System.Drawing.Bitmap;
using Color = System.Drawing.Color;
using Image = System.Drawing.Image;

namespace WindowsFormsApplication3
{
    public partial class addNoise : Form
    {
        private Bitmap imgNova;
        public addNoise(Image image)
        {
            InitializeComponent();
            imgNova = new Bitmap(image);
        }

        private void addNoise_Load(object sender, EventArgs e)
        {

        }
    }
}
