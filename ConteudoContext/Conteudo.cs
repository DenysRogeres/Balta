namespace Balta.ConteudoContext 
{
    public abstract class Conteudo 
    {
        public Conteudo(string titulo, string url)
        {
            Id = Guid.NewGuid();
            Url = url;
            Titulo = titulo;
        }
        public Guid Id { get; set; }
        public string? Titulo { get; set; }
        public string? Url { get; set; }
    }
}