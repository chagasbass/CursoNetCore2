using Flunt.Notifications;
using System;

namespace NetCore.Compartilhados.Entidades
{
    /// <summary>
    /// Entidade base
    /// </summary>
    public abstract class Entidade:Notifiable
    {
        public Guid Id { get; private set; }

        public Entidade()
        {
            Id = Guid.NewGuid();
        }

        public abstract void Validar();
        
    }
}