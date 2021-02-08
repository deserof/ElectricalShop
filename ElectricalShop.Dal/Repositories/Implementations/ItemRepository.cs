using System;
using System.Collections.Generic;
using ElectricalShop.Dal.Repositories.Interfaces;
using ElectricalShop.Common.Models;

namespace ElectricalShop.Dal.Repositories.Implementations
{
    public class ItemRepository : IItemRepository
    {
        public Item Create(Item item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Item item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Item> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Item> GetItemsByCategoryId(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Item GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Item item)
        {
            throw new NotImplementedException();
        }
    }
}
