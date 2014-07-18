namespace WindowsFormsApplication3
{
    partial class frmBalanco
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
            this.trackBrilho = new System.Windows.Forms.TrackBar();
            this.trackContraste = new System.Windows.Forms.TrackBar();
            this.trackGamma = new System.Windows.Forms.TrackBar();
            this.lblBrilho = new System.Windows.Forms.Label();
            this.lblContraste = new System.Windows.Forms.Label();
            this.lblGama = new System.Windows.Forms.Label();
            this.btOk = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.lblPorcentBrilho = new System.Windows.Forms.Label();
            this.lblPercertContraste = new System.Windows.Forms.Label();
            this.lblPercentGamma = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBrilho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackContraste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackGamma)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBrilho
            // 
            this.trackBrilho.Location = new System.Drawing.Point(70, 5);
            this.trackBrilho.Name = "trackBrilho";
            this.trackBrilho.Size = new System.Drawing.Size(218, 45);
            this.trackBrilho.TabIndex = 0;
            this.trackBrilho.Scroll += new System.EventHandler(this.trackBrilho_Scroll);
            this.trackBrilho.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBrilho_MouseUp);
            // 
            // trackContraste
            // 
            this.trackContraste.Location = new System.Drawing.Point(70, 39);
            this.trackContraste.Name = "trackContraste";
            this.trackContraste.Size = new System.Drawing.Size(218, 45);
            this.trackContraste.TabIndex = 1;
            this.trackContraste.Scroll += new System.EventHandler(this.trackContraste_Scroll);
            // 
            // trackGamma
            // 
            this.trackGamma.AutoSize = false;
            this.trackGamma.Location = new System.Drawing.Point(70, 72);
            this.trackGamma.Maximum = 1;
            this.trackGamma.Minimum = -1;
            this.trackGamma.Name = "trackGamma";
            this.trackGamma.Size = new System.Drawing.Size(218, 45);
            this.trackGamma.TabIndex = 2;
            this.trackGamma.Scroll += new System.EventHandler(this.trackGamma_Scroll);
            // 
            // lblBrilho
            // 
            this.lblBrilho.AutoSize = true;
            this.lblBrilho.Location = new System.Drawing.Point(12, 9);
            this.lblBrilho.Name = "lblBrilho";
            this.lblBrilho.Size = new System.Drawing.Size(36, 13);
            this.lblBrilho.TabIndex = 3;
            this.lblBrilho.Text = "Brilho:";
            // 
            // lblContraste
            // 
            this.lblContraste.AutoSize = true;
            this.lblContraste.Location = new System.Drawing.Point(12, 46);
            this.lblContraste.Name = "lblContraste";
            this.lblContraste.Size = new System.Drawing.Size(55, 13);
            this.lblContraste.TabIndex = 4;
            this.lblContraste.Text = "Contraste:";
            // 
            // lblGama
            // 
            this.lblGama.AutoSize = true;
            this.lblGama.Location = new System.Drawing.Point(12, 82);
            this.lblGama.Name = "lblGama";
            this.lblGama.Size = new System.Drawing.Size(46, 13);
            this.lblGama.TabIndex = 5;
            this.lblGama.Text = "Gamma:";
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(70, 116);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 6;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(183, 116);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 7;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // lblPorcentBrilho
            // 
            this.lblPorcentBrilho.AutoSize = true;
            this.lblPorcentBrilho.Location = new System.Drawing.Point(284, 9);
            this.lblPorcentBrilho.Name = "lblPorcentBrilho";
            this.lblPorcentBrilho.Size = new System.Drawing.Size(21, 13);
            this.lblPorcentBrilho.TabIndex = 8;
            this.lblPorcentBrilho.Text = "0%";
            // 
            // lblPercertContraste
            // 
            this.lblPercertContraste.AutoSize = true;
            this.lblPercertContraste.Location = new System.Drawing.Point(284, 42);
            this.lblPercertContraste.Name = "lblPercertContraste";
            this.lblPercertContraste.Size = new System.Drawing.Size(21, 13);
            this.lblPercertContraste.TabIndex = 9;
            this.lblPercertContraste.Text = "0%";
            // 
            // lblPercentGamma
            // 
            this.lblPercentGamma.AutoSize = true;
            this.lblPercentGamma.Location = new System.Drawing.Point(284, 74);
            this.lblPercentGamma.Name = "lblPercentGamma";
            this.lblPercentGamma.Size = new System.Drawing.Size(21, 13);
            this.lblPercentGamma.TabIndex = 10;
            this.lblPercentGamma.Text = "0%";
            // 
            // frmBalanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 148);
            this.Controls.Add(this.lblPercentGamma);
            this.Controls.Add(this.lblPercertContraste);
            this.Controls.Add(this.lblPorcentBrilho);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.lblGama);
            this.Controls.Add(this.lblContraste);
            this.Controls.Add(this.lblBrilho);
            this.Controls.Add(this.trackGamma);
            this.Controls.Add(this.trackContraste);
            this.Controls.Add(this.trackBrilho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmBalanco";
            this.Text = "Balanço";
            this.Load += new System.EventHandler(this.Balanco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBrilho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackContraste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackGamma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBrilho;
        private System.Windows.Forms.TrackBar trackContraste;
        private System.Windows.Forms.TrackBar trackGamma;
        private System.Windows.Forms.Label lblBrilho;
        private System.Windows.Forms.Label lblContraste;
        private System.Windows.Forms.Label lblGama;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label lblPorcentBrilho;
        private System.Windows.Forms.Label lblPercertContraste;
        private System.Windows.Forms.Label lblPercentGamma;
    }
}