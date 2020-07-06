using System;

namespace JogoDaForca
{
    class PalavrasInternas : BancoPalavras
    {
        string[] palavrinhas = new string[20] { "Queijo", "Vladimir", "Macaco", "Pneu", "Forca", "ABCDEF", "Alfabeto", "Matematica", "Joao", "Maria", "Abacate", "Tramontina", "Vaca", "Laranja", "Computador", "Arvore", "inconstitucionalidade", "HAHA", "KKKKKK", "Testando"};
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
