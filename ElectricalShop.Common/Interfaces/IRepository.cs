using System;
using System.Collections.Generic;
using System.Text;

namespace ElectricalShop.Common.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();

        T GetItemById(int id);

        T Create(T item);

        void Update(int id, T item);

        bool Delete(T item);
    }
}
