using Balta.ConteudoContext.Enums;
using Balta.SharedContextContext;

namespace Balta.ConteudoContext
{
    public class Aula : Base
    {
        public int Ordem { get; set; }
        public string? Titulo { get; set; }
        public int DuracaoEmMinutos { get; set; }
        public EConteudoNivel Nivel { get; set; }
    }
}