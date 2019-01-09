using System;
using System.Collections.Generic;

namespace CvScore.Domain
{
    public interface IRepository<T, TEntityKey> where T : IAggregateRoot
    {
        void Add(T entity);
        void Remove(T entity);
        T FindBy(TEntityKey id);
        T FindBy(params Object[] keyValues);
        IEnumerable<T> FindAll();
        void Save(T entity);
    }
}
