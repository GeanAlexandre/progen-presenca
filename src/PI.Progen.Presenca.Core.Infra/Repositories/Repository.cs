using LiteDB;
using PI.Progen.Presenca.Core.Entities;
using PI.Progen.Presenca.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;

namespace PI.Progen.Presenca.Core.Infra.Repositories
{
    public class Repository<T> : IRepository<T> where T : Entity<T>
    {
        private readonly LiteDatabase _liteDb;
        private readonly LiteCollection<T> _collection;

        public Repository(LiteDatabase liteDb)
        {
            _liteDb = liteDb;
            _collection = liteDb.GetCollection<T>(typeof(T).Name);
        }

        public T Salvar(T entity)
        {
            _collection.Upsert(entity);

            return entity;
        }

        public IEnumerable<T> BuscarTodos()
        {
            return _collection.FindAll();
        }

        public T BuscarPorId(Guid id)
        {
            return _collection.FindById(id);
        }
    }
}
