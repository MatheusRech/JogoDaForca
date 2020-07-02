using System;

namespace JogoDaForca
{
    class PalavrasInternas : BancoPalavras
    {
        string[] palavrinhas = new string[20] { "Queijo", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", ""};
        public PalavrasInternas()
        {

        }

        public String[] selecionado()
        {
            throw new NotImplementedException();
        }

        public String nomeExbicao()
        {
            return "Palavras Internas";
        }

        public void informacoes(string informacoes)
        {
            return;
        }

        public string[] palavras()
        {

            return palavrinhas;
        }
    }
}
