using NerdStore.Core.Messages;
using System;
using System.Collections.Generic;

namespace NerdStore.Core.DomainObjects
{
    public abstract class Entity
    {
        public Guid Id { get; set; }
        private List<Event> notificacoes;
        public IReadOnlyCollection<Event> Notificacoes => notificacoes?.AsReadOnly();

        public Entity()
        {
            Id = Guid.NewGuid();
        }

        public void AdicionarEvento(Event evento)
        {
            notificacoes ??= new List<Event>();
            notificacoes.Add(evento);
        }

        public void RemoverEvento(Event evento)
        {
            notificacoes?.Remove(evento);
        }

        public void LimparEventos()
        {
            notificacoes?.Clear();
        }
    }
}
