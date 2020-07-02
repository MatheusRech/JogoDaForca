using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaForca
{
    public partial class Game : Form
    {
        private Jogo gaming;
        private Menu menu;
        private FimJogo fimJogo;
        private Player jogador;
        private bool comecoJogo;
        private string currentWord;
        private List<Label> labels = new List<Label>();
        private int acertos;
        private int erros;

        public Game(Player jogador, Menu menu)
        {
            this.gaming = new Jogo();
            this.jogador = jogador;
            this.comecoJogo = true;
            this.menu = menu;
            this.acertos = 0;
            this.erros = 0;

            foreach (string palavra in jogador.palavras)
            {
                gaming.addPalavra(palavra);
            }

            InitializeComponent();

            addAllLabels();

            Inicio();
        }

        public void Inicio()
        {
            displayForca(gaming.Tentativas);
            if (currentWord == null && comecoJogo == true || currentWord == "")
            {
                carregaForca();
            }
            else if (gaming.Tentativas == 0)
            {
                if(acertos > 0)
                {
                    this.jogador.setPontos(0);
                }
                else
                {
                    this.jogador.setPontos(-10);
                }

                this.fimJogo = new FimJogo(this.menu, this, false, this.jogador);
            }
        }

        private void carregaForca()
        {
            comecoJogo = false;
            currentWord = gaming.novaPalavra();
            gaming.addLabel(this.labels);
            gaming.Tentativas = 6;
            displayForca(gaming.Tentativas);
            for (int x = 0; x < currentWord.Length; x++)
            {
                gaming.labels[x].Visible = true;
            }
        }

        /*
         * 
         * Aqui eu mudei, pq é o seguinte, o object sender, é o objeto que foi clicado, então em todo os botoes, você pode fazer uma unica função
         * 
         */

        private void letraClick(object sender, EventArgs e)
        {
            Button objeto = (Button)Convert.ChangeType(sender, typeof(Button));

            if(gaming.btClick(objeto, currentWord)) { acertos++; } else { erros++; }

            if (gaming.checkWord(currentWord) == true)
            {
                switch (erros)
                {
                    case 1:
                        this.jogador.setPontos(15);
                        break;
                    case 2:
                        this.jogador.setPontos(10);
                        break;
                    case 3:
                        this.jogador.setPontos(8);
                        break;
                    case 4:
                        this.jogador.setPontos(7);
                        break;
                    case 5:
                        this.jogador.setPontos(6);
                        break;
                    case 6:
                        this.jogador.setPontos(5);
                        break;
                }
                this.fimJogo = new FimJogo(this.menu, this, true, this.jogador);
            }
            else
            {
                Inicio();
            }
        }

        public void addAllLabels()
        {
            labels.Add(label1); labels.Add(label2); labels.Add(label3); labels.Add(label4);
            labels.Add(label5); labels.Add(label6); labels.Add(label7); labels.Add(label8);
            labels.Add(label9); labels.Add(label10); labels.Add(label11); labels.Add(label12);
            labels.Add(label13); labels.Add(label14); labels.Add(label15); labels.Add(label16);
            labels.Add(label17); labels.Add(label18); labels.Add(label19); labels.Add(label20);
            labels.Add(label21); labels.Add(label22); labels.Add(label23); labels.Add(label24);
            labels.Add(label25); labels.Add(label26); labels.Add(label27); labels.Add(label28);
            labels.Add(label29); labels.Add(label30); labels.Add(label31); labels.Add(label32);
            labels.Add(label33); labels.Add(label34); labels.Add(label35); labels.Add(label36);
            labels.Add(label37); labels.Add(label38); labels.Add(label39); labels.Add(label40);
            labels.Add(label41); labels.Add(label42); labels.Add(label43); labels.Add(label44);
            labels.Add(label45); labels.Add(label46);
        }

        public void resetBtns()
        {
            A.Visible = true; B.Visible = true; C.Visible = true; D.Visible = true;
            E.Visible = true; F.Visible = true; G.Visible = true; H.Visible = true;
            I.Visible = true; J.Visible = true; K.Visible = true; L.Visible = true;
            M.Visible = true; N.Visible = true; O.Visible = true; P.Visible = true;
            Q.Visible = true; R.Visible = true; S.Visible = true; T.Visible = true;
            U.Visible = true; V.Visible = true; W.Visible = true; X.Visible = true;
            Y.Visible = true; Z.Visible = true;
        }

        public void displayForca(int i)
        {
            int stage = 6 - i;
            switch (stage)
            {
                case 0:
                    imagemForca.Image = Properties.Resources.Forca_Estagio_0;
                    break;
                case 1:
                    imagemForca.Image = Properties.Resources.Forca_Estagio_1;
                    break;
                case 2:
                    imagemForca.Image = Properties.Resources.Forca_Estagio_2;
                    break;
                case 3:
                    imagemForca.Image = Properties.Resources.Forca_Estagio_3;
                    break;
                case 4:
                    imagemForca.Image = Properties.Resources.Forca_Estagio_4;
                    break;
                case 5:
                    imagemForca.Image = Properties.Resources.Forca_Estagio_5;
                    break;
                case 6:
                    imagemForca.Image = Properties.Resources.Forca_Estagio_6;
                    break;
            }
        }
    }
}
