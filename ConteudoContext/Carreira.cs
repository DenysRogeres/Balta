namespace Balta.ConteudoContext 
{
    public class Carreira : Conteudo 
    {
        public Carreira()
        {
            Itens = new List<CarreiraItem>();
        }
        public IList<CarreiraItem> Itens { get; set; }
        public int TotalCursos { 
            get 
            {
                return Itens.Count;
            } 
        }
    }
}