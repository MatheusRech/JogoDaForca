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

        public void addPalavra(string palavra)
        {
            Palavras.Add(palavra);
        }

        public void addLabel(int i, List<Label> labels)
        {
            foreach(Label label in labels)
            {
                i--;
                Labels.Add(label);
                if(i == 0)
                {
                    return;
                }
            }
        }

        public bool checkLetter(char l, string palavra)
        {
            if (palavra.Contains(l))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<Label> letterIndex(char l, string palavra, List<Label> labels)
        {
            palavra = palavra.ToUpper();
            int i = 0;
            int count = 0;
            foreach(char c in palavra)
            {
                i++;
                if(c == l)
                {
                    foreach(Label label in labels)
                    {
                        count++;
                        if(count == i)
                        {
                            label.Text = l.ToString();
                        }
                    }
                }
                
            }
            return labels;
        }
    }
}
