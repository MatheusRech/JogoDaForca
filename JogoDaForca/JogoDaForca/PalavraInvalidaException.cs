using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaForca
{
    class PalavraInvalidaException : Exception
    {
        public string mensagem { get; private set; }

        public PalavraInvalidaException(string mensagem)
        {
            this.mensagem = mensagem;
        }
    }
}
