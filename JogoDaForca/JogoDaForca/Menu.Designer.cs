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
            this.botaoJogar = new System.Windows.Forms.Button();
            this.escolhaBancoPalavras = new System.Windows.Forms.ListBox();
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
            this.botaoJogar.Location = new System.Drawing.Point(41, 44);
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
            this.escolhaBancoPalavras.Location = new System.Drawing.Point(451, 76);
            this.escolhaBancoPalavras.Name = "escolhaBancoPalavras";
            this.escolhaBancoPalavras.Size = new System.Drawing.Size(241, 34);
            this.escolhaBancoPalavras.TabIndex = 1;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.escolhaBancoPalavras);
            this.Controls.Add(this.botaoJogar);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botaoJogar;
        private System.Windows.Forms.ListBox escolhaBancoPalavras;
    }
}