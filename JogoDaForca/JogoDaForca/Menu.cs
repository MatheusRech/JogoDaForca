using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace JogoDaForca
{
    public partial class Menu : Form
    {
        List<BancoPalavras> itensLB = new List<BancoPalavras>();

        public Menu()
        {
            InitializeComponent();

            itensLB.Add(new PalavrasInternas());
            itensLB.Add(new ArquivoTexto());
            itensLB.Add(new Site());
            itensLB.Add(new EntradaUsuario());

        }

        private void menuLoad(object sender, EventArgs e)
        {
            foreach(BancoPalavras item in itensLB)
            {
                lbBancoPalavras.Items.Add(item.nomeExbicao());
            }

        }

        private void jogar(object sender, EventArgs e)
        {
            itensLB[lbBancoPalavras.SelectedIndex].informacoes(bancoPalavrasURL.Text);
            foreach(string info in itensLB[lbBancoPalavras.SelectedIndex].palavras())
            {
                MessageBox.Show(info);
            }
            this.Hide();
            Game f = new Game();
            f.Show();
        }

        private void lbSelect(object sender, EventArgs e)
        {
            bancoPalavrasURL.Visible = true;
            textBancoPalavrasURL.Visible = true;

            try
            {
                String[] resultado = itensLB[lbBancoPalavras.SelectedIndex].selecionado();

                textBancoPalavrasURL.Text = resultado[0];
                bancoPalavrasURL.Text = resultado[1];
            }catch(NotImplementedException exception)
            {
                bancoPalavrasURL.Visible = false;
                textBancoPalavrasURL.Visible = false;
            }
            
        }
    }
}
