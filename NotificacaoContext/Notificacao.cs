namespace Balta.NotificacaoContext 
{
    public sealed class Notificacao
    {
        public Notificacao()
        {
            
        }
        public Notificacao(string? propriedade, string? messagem)
        {
            Propriedade = propriedade;
            Messagem = messagem;
        }

        public string? Propriedade { get; set; }
        public string? Messagem { get; set; }
    }
}