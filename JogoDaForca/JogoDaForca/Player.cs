using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace JogoDaForca
{
    public class Player
    {
        public string nome { get; private set; }

        public int pontos { get; private set; }

        public string[] palavras { get; private set; }

        public Player(string nome, string[] palavras)
        {
            if (palavras.Length == 0)
            {
                throw new PalavraInvalidaException("Palavra invalida");
            }
            else if(nome.Length == 0)
            {
                throw new NomeInvalidoExcpetion("Nome de player vazio", nome);
            }

            nome = Regex.Replace(nome, @"\s+", "");

            this.nome = nome.Trim();
            this.pontos = 20;
            this.palavras = palavras;
        }

        public void setPontos(int pontos)
        {
            this.pontos = pontos;
        }
    }
}
