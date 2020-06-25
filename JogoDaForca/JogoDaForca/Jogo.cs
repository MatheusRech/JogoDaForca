using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaForca
{
    class Jogo
    {
        public List<string> Palavras { get; private set; } = new List<string>();
        public List<Label> Labels { get; private set; } = new List<Label>();
        public int Tentativas = 0;


        public void addPalavra(string palavra)
        {
            Palavras.Add(palavra);
        }

        public void addLabel(int i, List<Label> labels)
        {
            foreach (Label label in labels)
            {
                i--;
                Labels.Add(label);
                if(i == 0)
                {
                    return;
                }
            }
        }

        public void removeAllLabes()
        {
            foreach(Label l in Labels)
            {
                l.Text = "_";
            }
            Labels.Clear();
        }

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
        public void changeLabels(char l, string palavra)
        {
            palavra = palavra.ToUpper();
            int i = 0;
            int count = 0;
            char[] check = new char[palavra.Length];

            foreach(char c in palavra)
            {
                check[i] = c;
                i++;
            }
            foreach (Label label in Labels)
            {
                if(check[count] == l)
                {
                    label.Text = check[count].ToString();
                }
                count++;
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
                if(char.Parse(Labels[j].Text) != check2[j])
                {
                    return false;
                }
            }

            return true;
        }

        public string novaPalavra()
        {
            string palavra = "";
            foreach(string s in Palavras)
            {
                palavra = s;
            }
            Palavras.Remove(palavra);
            return palavra;
        }

        public void btClick(Button b, string currentWord)
        {
            b.Visible = false;
            if (checkLetter(char.Parse(b.Text), currentWord) == true)
            {
                changeLabels(char.Parse(b.Text), currentWord);
            }
            else
            {
                Tentativas = Tentativas - 1;
            }
        }
    }
}
