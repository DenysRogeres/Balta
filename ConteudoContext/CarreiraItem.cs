namespace Balta.ConteudoContext {
    public class CarreiraItem 
    {
        public int Ordem { get; set; }
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public Curso? Curso { get; set; }
    }
}