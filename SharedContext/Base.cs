using Balta.NotificacaoContext;

namespace Balta.SharedContextContext
{
    public class Base : Notificavel
    {
        public Base()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }
}