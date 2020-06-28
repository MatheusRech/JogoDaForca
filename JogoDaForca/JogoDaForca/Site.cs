using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using HtmlAgilityPack;

namespace JogoDaForca
{
    class Site : BancoPalavras
    {
        private string url;
        private HttpWebRequest request;
        private HttpWebResponse response;


        public Site()
        {

        }

        public String[] selecionado()
        {
            String[] retorno = new string[] { "Informe a URL completa do site", "URL do site" };

            return retorno;
        }

        public String nomeExbicao()
        {
            return "Palavras de um site";
        }

        public  void informacoes(String informacoes)
        {
            this.url = informacoes;
        }

        public string palavra()
        {
            if(url.Length == 0)
            {
                throw new SiteInvalidoException($"A url está vazia", url);
            }

            try
            {
                request = (HttpWebRequest)WebRequest.Create(url);
                response = (HttpWebResponse)request.GetResponse();

                if(response.StatusCode == HttpStatusCode.OK)
                {
                    Stream receiveStream = response.GetResponseStream();
                    StreamReader readStream = null;

                    if (String.IsNullOrWhiteSpace(response.CharacterSet))
                        readStream = new StreamReader(receiveStream);
                    else
                        readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));

                    string data = readStream.ReadToEnd();

                    HtmlAgilityPack.HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();

                    htmlDocument.LoadHtml(data);

                    response.Close();
                    readStream.Close();

                    Random rand = new Random();

                    string[] palavras = htmlDocument.DocumentNode.SelectSingleNode("/html/body").InnerText.Split(' ');

                    return palavras[rand.Next(palavras.Length)];
                }
                else
                {
                    throw new SiteInvalidoException("Erro ao tentar recuperar o site", url);
                }

            }
            catch (WebException exception)
            {
                switch (exception.Status)
                {
                    case WebExceptionStatus.ProtocolError:
                        throw new SiteInvalidoException("Houve um erro no protocolo de busca do site, tente novamente.", url);
                    case WebExceptionStatus.Timeout:
                        throw new SiteInvalidoException("O tempo de busca do site excedeu o limite, tente novamente.", url);
                    case WebExceptionStatus.ConnectFailure:
                        throw new SiteInvalidoException("Houve um erro na conexão do site, verifique sua conexão e tente novamente.", url);
                    default:
                        throw new SiteInvalidoException("Houve um erro desconhecido na conexão do site, tente novamente.", url);
                }
            }
            catch(SiteInvalidoException e)
            {
                throw e;
            }
        }
    }
}
