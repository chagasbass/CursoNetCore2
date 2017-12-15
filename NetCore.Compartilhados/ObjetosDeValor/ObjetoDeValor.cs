using Flunt.Notifications;

namespace NetCore.Compartilhados.ObjetosDeValor
{
    public abstract class ObjetoDeValor : Notifiable
    {
        public abstract void Validar();
    }
}