﻿namespace JogoDaForca
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
            this.botaoJogar = new System.Windows.Forms.Button();
            this.escolhaBancoPalavras = new System.Windows.Forms.ListBox();
            this.textoLBEscolhaBancoPalavra = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botaoJogar
            // 
            this.botaoJogar.BackColor = System.Drawing.Color.White;
            this.botaoJogar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoJogar.BackgroundImage")));
            this.botaoJogar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoJogar.FlatAppearance.BorderSize = 0;
            this.botaoJogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoJogar.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoJogar.Location = new System.Drawing.Point(12, 109);
            this.botaoJogar.Name = "botaoJogar";
            this.botaoJogar.Size = new System.Drawing.Size(170, 66);
            this.botaoJogar.TabIndex = 0;
            this.botaoJogar.Text = "Jogar";
            this.botaoJogar.UseVisualStyleBackColor = false;
            // 
            // escolhaBancoPalavras
            // 
            this.escolhaBancoPalavras.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.escolhaBancoPalavras.FormattingEnabled = true;
            this.escolhaBancoPalavras.ItemHeight = 30;
            this.escolhaBancoPalavras.Location = new System.Drawing.Point(460, 141);
            this.escolhaBancoPalavras.Name = "escolhaBancoPalavras";
            this.escolhaBancoPalavras.Size = new System.Drawing.Size(328, 34);
            this.escolhaBancoPalavras.TabIndex = 1;
            // 
            // textoLBEscolhaBancoPalavra
            // 
            this.textoLBEscolhaBancoPalavra.AutoSize = true;
            this.textoLBEscolhaBancoPalavra.Font = new System.Drawing.Font("Showcard Gothic", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoLBEscolhaBancoPalavra.Location = new System.Drawing.Point(278, 109);
            this.textoLBEscolhaBancoPalavra.Name = "textoLBEscolhaBancoPalavra";
            this.textoLBEscolhaBancoPalavra.Size = new System.Drawing.Size(510, 26);
            this.textoLBEscolhaBancoPalavra.TabIndex = 2;
            this.textoLBEscolhaBancoPalavra.Text = "Escolha um metodo para escolher as palavras";
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Showcard Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(12, 9);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(318, 50);
            this.Titulo.TabIndex = 3;
            this.Titulo.Text = "Jogo da Forca";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.textoLBEscolhaBancoPalavra);
            this.Controls.Add(this.escolhaBancoPalavras);
            this.Controls.Add(this.botaoJogar);
            this.Name = "Menu";
            this.Text = "Jogo da Forca - Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoJogar;
        private System.Windows.Forms.ListBox escolhaBancoPalavras;
        private System.Windows.Forms.Label textoLBEscolhaBancoPalavra;
        private System.Windows.Forms.Label Titulo;
    }
}