using System.Collections.Generic;

namespace ElectricalShop.Dal.Repositories.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();

        T GetProductById(int id);

        T Create(T item);

        void Update(int id, T item);

        bool Delete(T item);
    }
}
