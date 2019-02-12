using System;
using System.Collections.Generic;
using PI.Progen.Presenca.Core.Entities;

namespace PI.Progen.Presenca.Core.Interfaces.Repositories
{
    public interface IRepository<T> where T : Entity<T>
    {
        T BuscarPorId(Guid id);
        IEnumerable<T> BuscarTodos();
        T Salvar(T entity);
    }
}