using System;

namespace PI.Progen.Presenca.Core.Entities
{
    public abstract class Entity<T> where T : class
    {
        public Entity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }
    }
}
