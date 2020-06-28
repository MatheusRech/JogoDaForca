using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaForca
{
    class EntradaUsuarioIncorretaExcpetion : Exception
    {
        public string mensagem { get; private set; }

        public EntradaUsuarioIncorretaExcpetion(string mensagem)
        {
            this.mensagem = mensagem;
        }
    }
}
