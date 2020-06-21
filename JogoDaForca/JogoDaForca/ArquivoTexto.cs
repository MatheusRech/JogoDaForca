using System;
using System.IO;

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

        public string[] palavras()
        {
            StreamReader readStream = null;

            string[] aux;

            try
            {
                if (new FileInfo(path).Exists)
                {
                    readStream = new StreamReader(path);

                    aux = readStream.ReadToEnd().Split(' ');
                }
                else
                {
                    throw new Exception("Arquivo não encontrado.");
                }
            }catch(Exception e)
            {
                throw e;
            }

            return aux;
        }
    }
}
