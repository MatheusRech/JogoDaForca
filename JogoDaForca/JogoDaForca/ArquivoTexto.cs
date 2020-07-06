using System;
using System.Globalization;
using System.IO;
using System.Text;

namespace JogoDaForca
{
    class ArquivoTexto : BancoPalavras
    {
        string path;

        public ArquivoTexto()
        {

        }

        public String[] selecionado()
        {
            String[] retorno = new string[] { "Informe o diretorio completo do arquivo", "Diretorio do arquivo" };

            return retorno;
        }

        public String nomeExbicao()
        {
            return "Arquivo Texto";
        }

        public void informacoes(String informacoes)
        {
            path = informacoes;
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

        public string[] palavras()
        {
            StreamReader readStream = null;

            string[] aux;

            try
            {
                if (new FileInfo(path).Exists)
                {
                    readStream = new StreamReader(path);

                    string texto = readStream.ReadToEnd();

                    texto = removeAcentuacao(texto);

                    aux = texto.Split(' ');
                }
                else
                {
                    throw new ArquivoInvalidoException("O arquivo não existe ou não pode ser encontrado", path);
                }
                
                if(aux.Length == 0)
                {
                    throw new ArquivoInvalidoException("O arquivo está vazio", path);
                }
            }
            catch (ArquivoInvalidoException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw new ArquivoInvalidoException(e.Message, path);
            }

            return aux;
        }
    }
}
