using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

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

        private static string removeAcentuacao(string text)
        {
            StringBuilder sbReturn = new StringBuilder();
            var arrayText = text.Normalize(NormalizationForm.FormD).ToCharArray();
            foreach (char letter in arrayText)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(letter) != UnicodeCategory.NonSpacingMark)
                    sbReturn.Append(letter);
            }
            return sbReturn.ToString();
        }

        public void informacoes(String informacoes)
        {

            informacoes = removeAcentuacao(informacoes);

            palavrasUsuario = informacoes.Split(',');

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
