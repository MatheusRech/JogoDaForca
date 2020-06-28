using System;
using System.Collections.Generic;

namespace JogoDaForca
{
    class EntradaUsuario : BancoPalavras
    {
        string[] palavrasUsuario;

        public EntradaUsuario()
        {

        }

        public String[] selecionado()
        {
            String[] retorno = new string[] { "Escreva as palavras separadas por uma ','", "Joao,Maria,Abacaxi" };

            return retorno;
        }

        public String nomeExbicao()
        {
            return "Suas palavras";
        }

        public void informacoes(String informacoes)
        {
            string[] aux = informacoes.Split(',');

            palavrasUsuario = new string[aux.Length];

            int qtde = 0;
            foreach(string palavra in aux)
            {
                palavrasUsuario[qtde] = palavra;
                qtde++;
            }
        }

        public string[] palavras()
        {
            if(palavrasUsuario.Length == 0)
            {
                throw new EntradaUsuarioIncorretaExcpetion("É necessecario digitar as palavras conforme o exemplo: Joao,Maria,Fernando");
            }

            return palavrasUsuario;
        }
    }
}
