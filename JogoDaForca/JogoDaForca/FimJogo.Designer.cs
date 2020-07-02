namespace JogoDaForca
{
    partial class FimJogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FimJogo));
            this.botaoSair = new System.Windows.Forms.Button();
            this.botaoMenu = new System.Windows.Forms.Button();
            this.imagem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagem)).BeginInit();
            this.SuspendLayout();
            // 
            // botaoSair
            // 
            this.botaoSair.BackColor = System.Drawing.Color.White;
            this.botaoSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoSair.BackgroundImage")));
            this.botaoSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoSair.FlatAppearance.BorderSize = 0;
            this.botaoSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoSair.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoSair.Location = new System.Drawing.Point(207, 438);
            this.botaoSair.Name = "botaoSair";
            this.botaoSair.Size = new System.Drawing.Size(194, 66);
            this.botaoSair.TabIndex = 2;
            this.botaoSair.Text = "Sair";
            this.botaoSair.UseVisualStyleBackColor = false;
            this.botaoSair.Click += new System.EventHandler(this.sairClick);
            // 
            // botaoMenu
            // 
            this.botaoMenu.BackColor = System.Drawing.Color.White;
            this.botaoMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoMenu.BackgroundImage")));
            this.botaoMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoMenu.FlatAppearance.BorderSize = 0;
            this.botaoMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoMenu.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoMenu.Location = new System.Drawing.Point(1, 438);
            this.botaoMenu.Name = "botaoMenu";
            this.botaoMenu.Size = new System.Drawing.Size(200, 66);
            this.botaoMenu.TabIndex = 1;
            this.botaoMenu.Text = "Menu";
            this.botaoMenu.UseVisualStyleBackColor = false;
            this.botaoMenu.Click += new System.EventHandler(this.menuClick);
            // 
            // imagem
            // 
            this.imagem.Image = global::JogoDaForca.Properties.Resources.venceu;
            this.imagem.InitialImage = global::JogoDaForca.Properties.Resources.venceu;
            this.imagem.Location = new System.Drawing.Point(1, 1);
            this.imagem.Name = "imagem";
            this.imagem.Size = new System.Drawing.Size(400, 437);
            this.imagem.TabIndex = 0;
            this.imagem.TabStop = false;
            // 
            // FimJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.ClientSize = new System.Drawing.Size(401, 503);
            this.Controls.Add(this.botaoSair);
            this.Controls.Add(this.botaoMenu);
            this.Controls.Add(this.imagem);
            this.Name = "FimJogo";
            this.Text = "FimJogo";
            ((System.ComponentModel.ISupportInitialize)(this.imagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imagem;
        protected System.Windows.Forms.Button botaoMenu;
        protected System.Windows.Forms.Button botaoSair;
    }
}