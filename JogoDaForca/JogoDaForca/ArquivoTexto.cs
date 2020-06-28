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

        public string palavra()
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

            Random rand = new Random();

            return aux[rand.Next(aux.Length)];
        }
    }
}
