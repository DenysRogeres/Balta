namespace Balta.ConteudoContext 
{
    public abstract class Conteudo : Base
    {
        public Conteudo(string titulo, string url)
        {
            Url = url;
            Titulo = titulo;
        }
        public string? Titulo { get; set; }
        public string? Url { get; set; }
    }
}