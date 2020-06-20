namespace JogoDaForca
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.escolhaBancoPalavras = new System.Windows.Forms.ListBox();
            this.textoLBEscolhaBancoPalavra = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imgMenu = new System.Windows.Forms.PictureBox();
            this.botaoJogar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // escolhaBancoPalavras
            // 
            this.escolhaBancoPalavras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.escolhaBancoPalavras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.escolhaBancoPalavras.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.escolhaBancoPalavras.FormattingEnabled = true;
            this.escolhaBancoPalavras.ItemHeight = 29;
            this.escolhaBancoPalavras.Location = new System.Drawing.Point(300, 178);
            this.escolhaBancoPalavras.Name = "escolhaBancoPalavras";
            this.escolhaBancoPalavras.Size = new System.Drawing.Size(328, 31);
            this.escolhaBancoPalavras.TabIndex = 1;
            // 
            // textoLBEscolhaBancoPalavra
            // 
            this.textoLBEscolhaBancoPalavra.AutoSize = true;
            this.textoLBEscolhaBancoPalavra.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoLBEscolhaBancoPalavra.Location = new System.Drawing.Point(295, 149);
            this.textoLBEscolhaBancoPalavra.Name = "textoLBEscolhaBancoPalavra";
            this.textoLBEscolhaBancoPalavra.Size = new System.Drawing.Size(369, 23);
            this.textoLBEscolhaBancoPalavra.TabIndex = 2;
            this.textoLBEscolhaBancoPalavra.Text = "Escolha um metodo para escolher as palavras";
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(12, 9);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(239, 48);
            this.Titulo.TabIndex = 3;
            this.Titulo.Text = "Jogo da Forca";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(299, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(324, 37);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Seu Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome:";
            // 
            // imgMenu
            // 
            this.imgMenu.Image = global::JogoDaForca.Properties.Resources.imgMenu;
            this.imgMenu.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgMenu.InitialImage")));
            this.imgMenu.Location = new System.Drawing.Point(21, 62);
            this.imgMenu.Name = "imgMenu";
            this.imgMenu.Size = new System.Drawing.Size(251, 376);
            this.imgMenu.TabIndex = 6;
            this.imgMenu.TabStop = false;
            // 
            // botaoJogar
            // 
            this.botaoJogar.BackColor = System.Drawing.Color.White;
            this.botaoJogar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoJogar.BackgroundImage")));
            this.botaoJogar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoJogar.FlatAppearance.BorderSize = 0;
            this.botaoJogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoJogar.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoJogar.Location = new System.Drawing.Point(618, 372);
            this.botaoJogar.Name = "botaoJogar";
            this.botaoJogar.Size = new System.Drawing.Size(170, 66);
            this.botaoJogar.TabIndex = 0;
            this.botaoJogar.Text = "Jogar";
            this.botaoJogar.UseVisualStyleBackColor = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imgMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.textoLBEscolhaBancoPalavra);
            this.Controls.Add(this.escolhaBancoPalavras);
            this.Controls.Add(this.botaoJogar);
            this.DoubleBuffered = true;
            this.Name = "Menu";
            this.Text = "Jogo da Forca - Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoJogar;
        private System.Windows.Forms.ListBox escolhaBancoPalavras;
        private System.Windows.Forms.Label textoLBEscolhaBancoPalavra;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgMenu;
    }
}