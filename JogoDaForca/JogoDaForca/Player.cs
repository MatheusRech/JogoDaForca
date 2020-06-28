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

        public string palavra { get; private set; }

        public Player(string nome, string palavra)
        {
            if (palavra.Length == 0)
            {
                throw new PalavraInvalidaException("Palavra invalida", palavra);
            }
            else if(nome.Length == 0)
            {
                throw new NomeInvalidoExcpetion("Nome de player vazio", nome);
            }

            this.nome = nome;
            this.pontos = 0;
            this.palavra = palavra;
        }

        public void setPontos(int pontos)
        {
            this.pontos = pontos;
        }

        public void setPalavra(string palavra)
        {
            if(palavra.Length == 0)
            {
                throw new PalavraInvalidaException($"A palavra: {palavra} esta vazia", palavra);
            }

            this.palavra = palavra;
        }
    }
}
