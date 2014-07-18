namespace WindowsFormsApplication3
{
    partial class frmRedimensionar
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
            this.lblLargura = new System.Windows.Forms.Label();
            this.iLargura = new System.Windows.Forms.TextBox();
            this.iAltura = new System.Windows.Forms.TextBox();
            this.btRedimensionar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.groupPadrao = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radio1024 = new System.Windows.Forms.RadioButton();
            this.lblTam = new System.Windows.Forms.Label();
            this.radio800 = new System.Windows.Forms.RadioButton();
            this.radio600 = new System.Windows.Forms.RadioButton();
            this.groupPadrao.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLargura
            // 
            this.lblLargura.AutoSize = true;
            this.lblLargura.Location = new System.Drawing.Point(6, 59);
            this.lblLargura.Name = "lblLargura";
            this.lblLargura.Size = new System.Drawing.Size(84, 13);
            this.lblLargura.TabIndex = 0;
            this.lblLargura.Text = "Novo Tamanho:";
            this.lblLargura.Click += new System.EventHandler(this.lblLargura_Click);
            // 
            // iLargura
            // 
            this.iLargura.Location = new System.Drawing.Point(142, 56);
            this.iLargura.Name = "iLargura";
            this.iLargura.Size = new System.Drawing.Size(43, 20);
            this.iLargura.TabIndex = 2;
            // 
            // iAltura
            // 
            this.iAltura.Location = new System.Drawing.Point(93, 56);
            this.iAltura.Name = "iAltura";
            this.iAltura.Size = new System.Drawing.Size(43, 20);
            this.iAltura.TabIndex = 3;
            // 
            // btRedimensionar
            // 
            this.btRedimensionar.Location = new System.Drawing.Point(59, 132);
            this.btRedimensionar.Name = "btRedimensionar";
            this.btRedimensionar.Size = new System.Drawing.Size(89, 23);
            this.btRedimensionar.TabIndex = 4;
            this.btRedimensionar.Text = "Aplicar";
            this.btRedimensionar.UseVisualStyleBackColor = true;
            this.btRedimensionar.Click += new System.EventHandler(this.btRedimensionar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Location = new System.Drawing.Point(197, 132);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 5;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // groupPadrao
            // 
            this.groupPadrao.Controls.Add(this.radioButton1);
            this.groupPadrao.Controls.Add(this.radio1024);
            this.groupPadrao.Controls.Add(this.lblTam);
            this.groupPadrao.Controls.Add(this.radio800);
            this.groupPadrao.Controls.Add(this.radio600);
            this.groupPadrao.Controls.Add(this.iLargura);
            this.groupPadrao.Controls.Add(this.iAltura);
            this.groupPadrao.Controls.Add(this.lblLargura);
            this.groupPadrao.Location = new System.Drawing.Point(12, 12);
            this.groupPadrao.Name = "groupPadrao";
            this.groupPadrao.Size = new System.Drawing.Size(317, 114);
            this.groupPadrao.TabIndex = 6;
            this.groupPadrao.TabStop = false;
            this.groupPadrao.Text = "Escolha Opção de Redimensionar";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(205, 89);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(108, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1280x1024 Pixels";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radio1024
            // 
            this.radio1024.AutoSize = true;
            this.radio1024.Location = new System.Drawing.Point(206, 66);
            this.radio1024.Name = "radio1024";
            this.radio1024.Size = new System.Drawing.Size(102, 17);
            this.radio1024.TabIndex = 5;
            this.radio1024.TabStop = true;
            this.radio1024.Text = "1024x768 Pixels";
            this.radio1024.UseVisualStyleBackColor = true;
            this.radio1024.CheckedChanged += new System.EventHandler(this.radio1024_CheckedChanged);
            // 
            // lblTam
            // 
            this.lblTam.AutoSize = true;
            this.lblTam.Location = new System.Drawing.Point(26, 24);
            this.lblTam.Name = "lblTam";
            this.lblTam.Size = new System.Drawing.Size(35, 13);
            this.lblTam.TabIndex = 4;
            this.lblTam.Text = "label1";
            // 
            // radio800
            // 
            this.radio800.AutoSize = true;
            this.radio800.Location = new System.Drawing.Point(206, 42);
            this.radio800.Name = "radio800";
            this.radio800.Size = new System.Drawing.Size(96, 17);
            this.radio800.TabIndex = 1;
            this.radio800.TabStop = true;
            this.radio800.Text = "800x600 Pixels";
            this.radio800.UseVisualStyleBackColor = true;
            this.radio800.CheckedChanged += new System.EventHandler(this.radio800_CheckedChanged);
            // 
            // radio600
            // 
            this.radio600.AutoSize = true;
            this.radio600.Location = new System.Drawing.Point(206, 19);
            this.radio600.Name = "radio600";
            this.radio600.Size = new System.Drawing.Size(96, 17);
            this.radio600.TabIndex = 0;
            this.radio600.TabStop = true;
            this.radio600.Text = "600x480 Pixels";
            this.radio600.UseVisualStyleBackColor = true;
            this.radio600.CheckedChanged += new System.EventHandler(this.radio600_CheckedChanged);
            // 
            // frmRedimensionar
            // 
            this.AcceptButton = this.btRedimensionar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancelar;
            this.ClientSize = new System.Drawing.Size(336, 167);
            this.Controls.Add(this.groupPadrao);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btRedimensionar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRedimensionar";
            this.Text = "Redimensionar";
            this.Load += new System.EventHandler(this.frmRedimensionar_Load);
            this.groupPadrao.ResumeLayout(false);
            this.groupPadrao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLargura;
        private System.Windows.Forms.TextBox iLargura;
        private System.Windows.Forms.TextBox iAltura;
        private System.Windows.Forms.Button btRedimensionar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.GroupBox groupPadrao;
        private System.Windows.Forms.RadioButton radio800;
        private System.Windows.Forms.RadioButton radio600;
        private System.Windows.Forms.Label lblTam;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radio1024;
    }
}