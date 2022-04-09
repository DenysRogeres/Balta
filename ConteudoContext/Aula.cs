using Balta.ConteudoContext.Enums;

namespace Balta.ConteudoContext
{
    public class Aula
    {
        public int Ordem { get; set; }
        public string? Titulo { get; set; }
        public int DuracaoEmMinutos { get; set; }
        public EConteudoNivel Nivel { get; set; }
    }
}