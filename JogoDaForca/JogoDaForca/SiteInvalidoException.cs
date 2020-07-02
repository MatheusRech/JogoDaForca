using System;


namespace JogoDaForca
{
    class SiteInvalidoException : Exception
    {
        public string mensagem { get; private set; }

        public string url { get; private set; }

        public SiteInvalidoException(string mensagem, string url)
        {
            this.mensagem = mensagem;
            this.url = url;
        }
    }
}
