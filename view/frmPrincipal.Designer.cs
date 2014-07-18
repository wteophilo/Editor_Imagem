namespace WindowsFormsApplication3
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desfazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iMagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotacionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotarcionarEsquerdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotacionarDireitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotacionar180ºToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.flipVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flipHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redimensionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balançoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sharpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeDetectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ruidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negativeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tonsDeCinzaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.imgPrincipal = new System.Windows.Forms.PictureBox();
            this.hScrollBar = new System.Windows.Forms.HScrollBar();
            this.vScrollBar = new System.Windows.Forms.VScrollBar();
            this.menuBar.SuspendLayout();
            this.statusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.iMagemToolStripMenuItem,
            this.filtroToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuBar.Size = new System.Drawing.Size(828, 24);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abriToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.salvarComoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // abriToolStripMenuItem
            // 
            this.abriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("abriToolStripMenuItem.Image")));
            this.abriToolStripMenuItem.Name = "abriToolStripMenuItem";
            this.abriToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.abriToolStripMenuItem.Text = "Abrir";
            this.abriToolStripMenuItem.Click += new System.EventHandler(this.abriToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salvarToolStripMenuItem.Image")));
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // salvarComoToolStripMenuItem
            // 
            this.salvarComoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salvarComoToolStripMenuItem.Image")));
            this.salvarComoToolStripMenuItem.Name = "salvarComoToolStripMenuItem";
            this.salvarComoToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.salvarComoToolStripMenuItem.Text = "Salvar Como...";
            this.salvarComoToolStripMenuItem.Click += new System.EventHandler(this.salvarComoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sairToolStripMenuItem.Image")));
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desfazerToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // desfazerToolStripMenuItem
            // 
            this.desfazerToolStripMenuItem.Name = "desfazerToolStripMenuItem";
            this.desfazerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.desfazerToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.desfazerToolStripMenuItem.Text = "Desfazer";
            this.desfazerToolStripMenuItem.Click += new System.EventHandler(this.desfazerToolStripMenuItem_Click);
            // 
            // iMagemToolStripMenuItem
            // 
            this.iMagemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rotacionarToolStripMenuItem,
            this.redimensionarToolStripMenuItem,
            this.balançoToolStripMenuItem});
            this.iMagemToolStripMenuItem.Name = "iMagemToolStripMenuItem";
            this.iMagemToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.iMagemToolStripMenuItem.Text = "Imagem";
            // 
            // rotacionarToolStripMenuItem
            // 
            this.rotacionarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rotarcionarEsquerdaToolStripMenuItem,
            this.rotacionarDireitaToolStripMenuItem,
            this.rotacionar180ºToolStripMenuItem,
            this.toolStripSeparator1,
            this.flipVerticalToolStripMenuItem,
            this.flipHorizontalToolStripMenuItem});
            this.rotacionarToolStripMenuItem.Name = "rotacionarToolStripMenuItem";
            this.rotacionarToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.rotacionarToolStripMenuItem.Text = "Rotacionar";
            // 
            // rotarcionarEsquerdaToolStripMenuItem
            // 
            this.rotarcionarEsquerdaToolStripMenuItem.Name = "rotarcionarEsquerdaToolStripMenuItem";
            this.rotarcionarEsquerdaToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.rotarcionarEsquerdaToolStripMenuItem.Text = "Rotacionar 90º Esquerda";
            this.rotarcionarEsquerdaToolStripMenuItem.Click += new System.EventHandler(this.rotarcionarEsquerdaToolStripMenuItem_Click);
            // 
            // rotacionarDireitaToolStripMenuItem
            // 
            this.rotacionarDireitaToolStripMenuItem.Name = "rotacionarDireitaToolStripMenuItem";
            this.rotacionarDireitaToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.rotacionarDireitaToolStripMenuItem.Text = "Rotacionar 90º Direita";
            this.rotacionarDireitaToolStripMenuItem.Click += new System.EventHandler(this.rotacionarDireitaToolStripMenuItem_Click);
            // 
            // rotacionar180ºToolStripMenuItem
            // 
            this.rotacionar180ºToolStripMenuItem.Name = "rotacionar180ºToolStripMenuItem";
            this.rotacionar180ºToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.rotacionar180ºToolStripMenuItem.Text = "Rotacionar 180º";
            this.rotacionar180ºToolStripMenuItem.Click += new System.EventHandler(this.rotacionar180ºToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(199, 6);
            // 
            // flipVerticalToolStripMenuItem
            // 
            this.flipVerticalToolStripMenuItem.Name = "flipVerticalToolStripMenuItem";
            this.flipVerticalToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.flipVerticalToolStripMenuItem.Text = "Flip Vertical";
            this.flipVerticalToolStripMenuItem.Click += new System.EventHandler(this.flipVerticalToolStripMenuItem_Click);
            // 
            // flipHorizontalToolStripMenuItem
            // 
            this.flipHorizontalToolStripMenuItem.Name = "flipHorizontalToolStripMenuItem";
            this.flipHorizontalToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.flipHorizontalToolStripMenuItem.Text = "Flip Horizontal";
            this.flipHorizontalToolStripMenuItem.Click += new System.EventHandler(this.flipHorizontalToolStripMenuItem_Click);
            // 
            // redimensionarToolStripMenuItem
            // 
            this.redimensionarToolStripMenuItem.Name = "redimensionarToolStripMenuItem";
            this.redimensionarToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.redimensionarToolStripMenuItem.Text = "Redimensionar";
            this.redimensionarToolStripMenuItem.Click += new System.EventHandler(this.redimensionarToolStripMenuItem_Click);
            // 
            // balançoToolStripMenuItem
            // 
            this.balançoToolStripMenuItem.Name = "balançoToolStripMenuItem";
            this.balançoToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.balançoToolStripMenuItem.Text = "Balanço";
            this.balançoToolStripMenuItem.Click += new System.EventHandler(this.balançoToolStripMenuItem_Click);
            // 
            // filtroToolStripMenuItem
            // 
            this.filtroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blurToolStripMenuItem,
            this.sharpenToolStripMenuItem,
            this.edgeDetectionToolStripMenuItem,
            this.sobelToolStripMenuItem,
            this.ruidoToolStripMenuItem,
            this.negativeToolStripMenuItem1,
            this.tonsDeCinzaToolStripMenuItem1});
            this.filtroToolStripMenuItem.Name = "filtroToolStripMenuItem";
            this.filtroToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.filtroToolStripMenuItem.Text = "Filtros";
            // 
            // blurToolStripMenuItem
            // 
            this.blurToolStripMenuItem.Name = "blurToolStripMenuItem";
            this.blurToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.blurToolStripMenuItem.Text = "Blur";
            this.blurToolStripMenuItem.Click += new System.EventHandler(this.blurToolStripMenuItem_Click);
            // 
            // sharpenToolStripMenuItem
            // 
            this.sharpenToolStripMenuItem.Name = "sharpenToolStripMenuItem";
            this.sharpenToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.sharpenToolStripMenuItem.Text = "Sharpen";
            this.sharpenToolStripMenuItem.Click += new System.EventHandler(this.sharpenToolStripMenuItem_Click);
            // 
            // edgeDetectionToolStripMenuItem
            // 
            this.edgeDetectionToolStripMenuItem.Name = "edgeDetectionToolStripMenuItem";
            this.edgeDetectionToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.edgeDetectionToolStripMenuItem.Text = "Edge Detection";
            this.edgeDetectionToolStripMenuItem.Click += new System.EventHandler(this.edgeDetectionToolStripMenuItem_Click);
            // 
            // sobelToolStripMenuItem
            // 
            this.sobelToolStripMenuItem.Name = "sobelToolStripMenuItem";
            this.sobelToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.sobelToolStripMenuItem.Text = "Sobel ";
            this.sobelToolStripMenuItem.Click += new System.EventHandler(this.sobelToolStripMenuItem_Click);
            // 
            // ruidoToolStripMenuItem
            // 
            this.ruidoToolStripMenuItem.Name = "ruidoToolStripMenuItem";
            this.ruidoToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.ruidoToolStripMenuItem.Text = "Ruido";
            this.ruidoToolStripMenuItem.Click += new System.EventHandler(this.ruidoToolStripMenuItem_Click);
            // 
            // negativeToolStripMenuItem1
            // 
            this.negativeToolStripMenuItem1.Name = "negativeToolStripMenuItem1";
            this.negativeToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.negativeToolStripMenuItem1.Text = "Negative";
            this.negativeToolStripMenuItem1.Click += new System.EventHandler(this.negativeToolStripMenuItem1_Click);
            // 
            // tonsDeCinzaToolStripMenuItem1
            // 
            this.tonsDeCinzaToolStripMenuItem1.Name = "tonsDeCinzaToolStripMenuItem1";
            this.tonsDeCinzaToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.tonsDeCinzaToolStripMenuItem1.Text = "Tons de Cinza";
            this.tonsDeCinzaToolStripMenuItem1.Click += new System.EventHandler(this.tonsDeCinzaToolStripMenuItem1_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versãoToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // versãoToolStripMenuItem
            // 
            this.versãoToolStripMenuItem.Name = "versãoToolStripMenuItem";
            this.versãoToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.versãoToolStripMenuItem.Text = "Versão";
            this.versãoToolStripMenuItem.Click += new System.EventHandler(this.versãoToolStripMenuItem_Click);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.StatusLabel,
            this.progressBar});
            this.statusBar.Location = new System.Drawing.Point(0, 568);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(828, 22);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "statusBar";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(71, 17);
            this.StatusLabel.Text = "Informação:";
            // 
            // progressBar
            // 
            this.progressBar.AutoSize = false;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(300, 16);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            // 
            // imgPrincipal
            // 
            this.imgPrincipal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgPrincipal.Cursor = System.Windows.Forms.Cursors.Cross;
            this.imgPrincipal.Location = new System.Drawing.Point(12, 36);
            this.imgPrincipal.Name = "imgPrincipal";
            this.imgPrincipal.Size = new System.Drawing.Size(722, 458);
            this.imgPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgPrincipal.TabIndex = 1;
            this.imgPrincipal.TabStop = false;
            // 
            // hScrollBar
            // 
            this.hScrollBar.Location = new System.Drawing.Point(0, 551);
            this.hScrollBar.Name = "hScrollBar";
            this.hScrollBar.Size = new System.Drawing.Size(787, 17);
            this.hScrollBar.TabIndex = 3;
            this.hScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar_Scroll);
            // 
            // vScrollBar
            // 
            this.vScrollBar.Location = new System.Drawing.Point(811, 36);
            this.vScrollBar.Name = "vScrollBar";
            this.vScrollBar.Size = new System.Drawing.Size(17, 482);
            this.vScrollBar.TabIndex = 4;
            this.vScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar_Scroll);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(828, 590);
            this.Controls.Add(this.hScrollBar);
            this.Controls.Add(this.vScrollBar);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.imgPrincipal);
            this.Controls.Add(this.menuBar);
            this.MainMenuStrip = this.menuBar;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor de Imagem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desfazerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iMagemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotacionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotarcionarEsquerdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotacionarDireitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem flipVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flipHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redimensionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem balançoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sharpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edgeDetectionToolStripMenuItem;
        private System.Windows.Forms.PictureBox imgPrincipal;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotacionar180ºToolStripMenuItem;
        private System.Windows.Forms.HScrollBar hScrollBar;
        private System.Windows.Forms.VScrollBar vScrollBar;
        private System.Windows.Forms.ToolStripMenuItem sobelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ruidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negativeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tonsDeCinzaToolStripMenuItem1;
    }
}

