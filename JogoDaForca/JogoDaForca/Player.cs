using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaForca
{
    class Player
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

            this.nome = nome;
            this.pontos = 0;
            this.palavras = palavras;
        }

        public void setPontos(int pontos)
        {
            this.pontos = pontos;
        }
    }
}
