using System.Collections.Generic;

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
            this.textoLBEscolhaBancoPalavra = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.TextBox();
            this.textNome = new System.Windows.Forms.Label();
            this.imgMenu = new System.Windows.Forms.PictureBox();
            this.botaoJogar = new System.Windows.Forms.Button();
            this.bancoPalavrasURL = new System.Windows.Forms.TextBox();
            this.textBancoPalavrasURL = new System.Windows.Forms.Label();
            this.lbBancoPalavras = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgMenu)).BeginInit();
            this.SuspendLayout();
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
            // nome
            // 
            this.nome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nome.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(299, 88);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(329, 37);
            this.nome.TabIndex = 4;
            this.nome.Text = "Seu Nome";
            // 
            // textNome
            // 
            this.textNome.AutoSize = true;
            this.textNome.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNome.Location = new System.Drawing.Point(295, 62);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(59, 23);
            this.textNome.TabIndex = 5;
            this.textNome.Text = "Nome:";
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
            this.botaoJogar.Click += new System.EventHandler(this.jogar);
            // 
            // bancoPalavrasURL
            // 
            this.bancoPalavrasURL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.bancoPalavrasURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bancoPalavrasURL.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bancoPalavrasURL.Location = new System.Drawing.Point(299, 257);
            this.bancoPalavrasURL.Name = "bancoPalavrasURL";
            this.bancoPalavrasURL.Size = new System.Drawing.Size(329, 37);
            this.bancoPalavrasURL.TabIndex = 7;
            this.bancoPalavrasURL.Text = "Seu Nome";
            // 
            // textBancoPalavrasURL
            // 
            this.textBancoPalavrasURL.AutoSize = true;
            this.textBancoPalavrasURL.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBancoPalavrasURL.Location = new System.Drawing.Point(296, 231);
            this.textBancoPalavrasURL.Name = "textBancoPalavrasURL";
            this.textBancoPalavrasURL.Size = new System.Drawing.Size(369, 23);
            this.textBancoPalavrasURL.TabIndex = 8;
            this.textBancoPalavrasURL.Text = "Escolha um metodo para escolher as palavras";
            // 
            // lbBancoPalavras
            // 
            this.lbBancoPalavras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.lbBancoPalavras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbBancoPalavras.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBancoPalavras.FormattingEnabled = true;
            this.lbBancoPalavras.Location = new System.Drawing.Point(299, 175);
            this.lbBancoPalavras.Name = "lbBancoPalavras";
            this.lbBancoPalavras.Size = new System.Drawing.Size(326, 37);
            this.lbBancoPalavras.TabIndex = 9;
            this.lbBancoPalavras.SelectedIndexChanged += new System.EventHandler(this.lbSelect);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbBancoPalavras);
            this.Controls.Add(this.textBancoPalavrasURL);
            this.Controls.Add(this.bancoPalavrasURL);
            this.Controls.Add(this.imgMenu);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.textoLBEscolhaBancoPalavra);
            this.Controls.Add(this.botaoJogar);
            this.DoubleBuffered = true;
            this.Name = "Menu";
            this.Text = "Jogo da Forca - Menu";
            this.Load += new System.EventHandler(this.menuLoad);
            ((System.ComponentModel.ISupportInitialize)(this.imgMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button botaoJogar;
        protected System.Windows.Forms.Label textoLBEscolhaBancoPalavra;
        protected System.Windows.Forms.Label Titulo;
        protected System.Windows.Forms.TextBox nome;
        protected System.Windows.Forms.Label textNome;
        protected System.Windows.Forms.PictureBox imgMenu;
        protected System.Windows.Forms.TextBox bancoPalavrasURL;
        protected System.Windows.Forms.Label textBancoPalavrasURL;
        private System.Windows.Forms.ComboBox lbBancoPalavras;
    }
}