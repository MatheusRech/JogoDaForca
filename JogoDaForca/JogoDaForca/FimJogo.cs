using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace JogoDaForca
{
    public partial class FimJogo : Form
    {
        private Menu menu;

        public FimJogo(Menu menu, Game game, bool resultado, Player player)
        {
            this.menu = menu;

            game.Close();
            this.Show();

            InitializeComponent();

            regitraPlayer(player);

            if (resultado)
            {
                imagem.Image = Properties.Resources.venceu;
            }
            else
            {
                imagem.Image = Properties.Resources.perdeu;
            }
        }

        private void regitraPlayer(Player player)
        {

            XmlDocument doc = new XmlDocument();
            try
            {
                doc.Load(Environment.CurrentDirectory + "\\Files\\Jogadores.xml");
            }
            catch (Exception)
            {
                doc.LoadXml("<?xml version='1.0' encoding='utf-8'?><Jogadores></Jogadores>");
            }

            

            foreach(XmlNode no in doc.DocumentElement.ChildNodes)
            {
                if(no.Name == player.nome)
                {
                    no.InnerText = (int.Parse(no.InnerText) + player.pontos).ToString();
                    doc.Save(Environment.CurrentDirectory + "\\Files\\Jogadores.xml");
                    return;
                }
            }

            XmlElement jogador = doc.CreateElement(player.nome);
            jogador.InnerText = player.pontos.ToString();

            doc.DocumentElement.AppendChild(jogador);
            doc.Save(Environment.CurrentDirectory + "\\Files\\Jogadores.xml");
        }

        private void menuClick(object sender, EventArgs e)
        {
            menu.carregaPlacar();
            menu.Show();
            this.Close();
        }

        private void sairClick(object sender, EventArgs e)
        {
            menu.Close();
            this.Close();
        }
    }
}
