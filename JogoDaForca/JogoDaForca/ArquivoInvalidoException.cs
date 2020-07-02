using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaForca
{
    class ArquivoInvalidoException : Exception
    {
        public string mensagem { get; private set; }

        public string path { get; private set; }

        public ArquivoInvalidoException(string mensagem, string path)
        {
            this.mensagem = mensagem;
            this.path = path;
        }
    }
}
