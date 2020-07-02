using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaForca
{
    public class Jogo
    {
        public List<string> Palavras { get; private set; } = new List<string>();
        public List<Label> labels { get; private set; } = new List<Label>();
        public int Tentativas = 0;


        public void addPalavra(string palavra)
        {
            Palavras.Add(palavra);
        }

        public void addLabel(List<Label> labels)
        {
            this.labels = labels;
        }

        public void removeAllLabes()
        {
            foreach(Label l in labels)
            {
                l.Text = "_";
            }
            labels.Clear();
        }

        /*
         * A classe String ja faz isso: Contains()
         * 
        public bool checkLetter(char l, string palavra)
        {
            palavra = palavra.ToUpper();
            foreach(char c in palavra)
            {
                if(l == c)
                {
                    return true;
                }
            }
            return false;
        }
        */
        public void changeLabels(char l, string palavra)
        {
            palavra = palavra.ToUpper();
            int i = 0;
            int count = 0;
            char[] check = new char[palavra.Length];

            if (palavra.Contains(l))
            {
                for(int x = 0; x < palavra.Length; x++)
                {
                    if(palavra[x] == l)
                    {
                        labels[x].Text = l.ToString();
                    }
                }
            }
        }
        public bool checkWord(string palavra)
        {
            int i = 0;
            char[] check2 = new char[palavra.Length];
            palavra = palavra.ToUpper();

            foreach(char c in palavra)
            {
                check2[i] = c;
                i++;
            }

            for(int j = 0; j < palavra.Length; j++)
            {
                if(char.Parse(labels[j].Text) != check2[j])
                {
                    return false;
                }
            }

            return true;
        }

        public string novaPalavra()
        {
            Random rand = new Random();
            string palavra = Palavras[rand.Next(0, Palavras.Count)];
            /*
             * 
             * Dei uma modificada Matheus
             * 
             * 
            foreach(string s in Palavras)
            {
                palavra = s;
            }
            */
            Palavras.Remove(palavra);
            return palavra;
        }

        public bool btClick(Button b, string currentWord)
        {
            b.Visible = false;
            if (currentWord.ToUpper().Contains(b.Text))
            {
                changeLabels(char.Parse(b.Text), currentWord);
                return true;
            }
            else
            {
                Tentativas = Tentativas - 1;
                return false;
            }
        }
    }
}
