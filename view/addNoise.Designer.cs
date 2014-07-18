namespace WindowsFormsApplication3
{
    partial class addNoise
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.imgPreview = new System.Windows.Forms.PictureBox();
            this.valorBarra = new System.Windows.Forms.TrackBar();
            this.lblValor = new System.Windows.Forms.Label();
            this.iValor = new System.Windows.Forms.TextBox();
            this.btMenos = new System.Windows.Forms.Button();
            this.btMais = new System.Windows.Forms.Button();
            this.lblPorcentagem = new System.Windows.Forms.Label();
            this.btOk = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorBarra)).BeginInit();
            this.SuspendLayout();
            // 
            // imgPreview
            // 
            this.imgPreview.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgPreview.Location = new System.Drawing.Point(12, 12);
            this.imgPreview.Name = "imgPreview";
            this.imgPreview.Size = new System.Drawing.Size(312, 219);
            this.imgPreview.TabIndex = 0;
            this.imgPreview.TabStop = false;
            // 
            // valorBarra
            // 
            this.valorBarra.Location = new System.Drawing.Point(12, 299);
            this.valorBarra.Name = "valorBarra";
            this.valorBarra.Size = new System.Drawing.Size(312, 45);
            this.valorBarra.TabIndex = 1;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(12, 273);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(34, 13);
            this.lblValor.TabIndex = 2;
            this.lblValor.Text = "Valor:";
            // 
            // iValor
            // 
            this.iValor.Location = new System.Drawing.Point(52, 273);
            this.iValor.Name = "iValor";
            this.iValor.Size = new System.Drawing.Size(100, 20);
            this.iValor.TabIndex = 3;
            // 
            // btMenos
            // 
            this.btMenos.Location = new System.Drawing.Point(112, 237);
            this.btMenos.Name = "btMenos";
            this.btMenos.Size = new System.Drawing.Size(21, 23);
            this.btMenos.TabIndex = 4;
            this.btMenos.Text = "-";
            this.btMenos.UseVisualStyleBackColor = true;
            // 
            // btMais
            // 
            this.btMais.Location = new System.Drawing.Point(192, 237);
            this.btMais.Name = "btMais";
            this.btMais.Size = new System.Drawing.Size(21, 23);
            this.btMais.TabIndex = 5;
            this.btMais.Text = "+";
            this.btMais.UseVisualStyleBackColor = true;
            // 
            // lblPorcentagem
            // 
            this.lblPorcentagem.AutoSize = true;
            this.lblPorcentagem.Location = new System.Drawing.Point(144, 242);
            this.lblPorcentagem.Name = "lblPorcentagem";
            this.lblPorcentagem.Size = new System.Drawing.Size(35, 13);
            this.lblPorcentagem.TabIndex = 6;
            this.lblPorcentagem.Text = "label1";
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(192, 358);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 7;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(52, 358);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 8;
            this.btCancel.Text = "Cancelar";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // addNoise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 393);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.lblPorcentagem);
            this.Controls.Add(this.btMais);
            this.Controls.Add(this.btMenos);
            this.Controls.Add(this.iValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.valorBarra);
            this.Controls.Add(this.imgPreview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "addNoise";
            this.Text = "Aplica Ruído";
            this.Load += new System.EventHandler(this.addNoise_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorBarra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgPreview;
        private System.Windows.Forms.TrackBar valorBarra;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox iValor;
        private System.Windows.Forms.Button btMenos;
        private System.Windows.Forms.Button btMais;
        private System.Windows.Forms.Label lblPorcentagem;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btCancel;
    }
}