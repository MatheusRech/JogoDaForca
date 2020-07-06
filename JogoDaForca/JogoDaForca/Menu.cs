using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

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
            //itensLB.Add(new Site());
            itensLB.Add(new EntradaUsuario());

        }

        private void menuLoad(object sender, EventArgs e)
        {
            foreach(BancoPalavras item in itensLB)
            {
                lbBancoPalavras.Items.Add(item.nomeExbicao());
            }

            bancoPalavrasURL.Visible = false;
            textBancoPalavrasURL.Visible = false;

            carregaPlacar();

        }

        public void carregaPlacar()
        {
            placar.Items.Clear();

            List<Player> players = new List<Player>();

            XmlDocument doc = new XmlDocument();
            try
            {
                doc.Load(Environment.CurrentDirectory + "\\Files\\Jogadores.xml");
            }
            catch (Exception)
            {
                doc.LoadXml("<?xml version='1.0' encoding='utf-8'?><Jogadores></Jogadores>");
            }

            foreach (XmlNode no in doc.DocumentElement.ChildNodes)
            {
                Player jogador = new Player(no.Name, int.Parse(no.InnerText));

                players.Add(jogador);
            }

            players.Sort(delegate(Player x, Player y)
            {
                if (x.pontos > y.pontos) return -1;
                else return 1;
            });

            foreach (Player player in players)
            {
                placar.Items.Add(player.nome + " - " + player.pontos.ToString());
            }

            return;
        }

        private void jogar(object sender, EventArgs e)
        {
            try
            {
                if(lbBancoPalavras.SelectedIndex == -1)
                {
                    throw new Exception("Você deve escolher uma fonte de palavras");
                }
                itensLB[lbBancoPalavras.SelectedIndex].informacoes(bancoPalavrasURL.Text);
                string[] palavras = itensLB[lbBancoPalavras.SelectedIndex].palavras();
                Player player = new Player(nome.Text, palavras);

                Game game = new Game(player, this);
                game.Show();
                this.Hide();
            }
            catch (ArquivoInvalidoException arquivoInvalido)
            {
                MessageBox.Show(arquivoInvalido.mensagem, $"Erro no acesso ao arquivo: {arquivoInvalido.path}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch(SiteInvalidoException siteInvalido)
            {
                MessageBox.Show(siteInvalido.mensagem, $"Erro no acesso ao site: {siteInvalido.url}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch(EntradaUsuarioIncorretaExcpetion entradaInvalida)
            {
                MessageBox.Show(entradaInvalida.mensagem, "Palavra de entrada incorreta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch(NomeInvalidoExcpetion nomeInvalido)
            {
                MessageBox.Show(nomeInvalido.mensagem, "Nome invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch(PalavraInvalidaException palavraInvalida)
            {
                MessageBox.Show(palavraInvalida.mensagem, $"ocorreu um erro com as palavras do sistema, tente novamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch(Exception excpetion)
            {
                MessageBox.Show(excpetion.Message, "Erro no sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
            }catch(NotImplementedException)
            {
                bancoPalavrasURL.Visible = false;
                textBancoPalavrasURL.Visible = false;
            }
            
        }
    }
}
