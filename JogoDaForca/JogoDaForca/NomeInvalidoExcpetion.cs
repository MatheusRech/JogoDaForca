using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaForca
{
    class NomeInvalidoExcpetion : Exception
    {
        public string mensagem { get; private set; }
        public string nome { get; private set; }

        public NomeInvalidoExcpetion(string mensagem, string nome)
        {
            this.mensagem = mensagem;
            this.nome = nome;
        }
    }
}
