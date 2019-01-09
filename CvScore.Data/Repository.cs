using System;
using System.Collections.Generic;
using System.Linq;
using CvScore.Domain;
using Raven.Client;

namespace CvScore.Data
{
    public abstract class Repository<T, TEntityKey> where T : class, IAggregateRoot
    {
        private readonly IDocumentSession _documentSession;

        protected Repository(IDocumentSession documentSession)
        {
            _documentSession = documentSession;
        }

        public void Add(T entity)
        {
            _documentSession.Store(entity);
        }

        public void Remove(T entity)
        {
            _documentSession.Delete(entity);
        }

        public T FindBy(TEntityKey entityKey)
        {
            return _documentSession.Load<T>("" + entityKey);
        }

        public T FindBy(params Object[] keyValues)
        {
            return _documentSession.Load<T>("" + keyValues);
        }

        public IEnumerable<T> FindAll()
        {
            return _documentSession.Query<T>().ToList();
        }

        public void Save(T entity)
        {
            _documentSession.SaveChanges();
        }
    }
}
