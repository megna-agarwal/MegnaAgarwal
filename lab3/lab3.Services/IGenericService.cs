using System.Collections.Generic;
namespace lab3.Services
{
    public interface IGenericService<T>
    {
        IList<T> GetAll();
        T GetById(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}