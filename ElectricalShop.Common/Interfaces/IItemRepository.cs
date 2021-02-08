using ElectricalShop.Common.Models;
using System.Collections.Generic;

namespace ElectricalShop.Common.Interfaces
{
    public interface IItemRepository : IRepository<Item>
    {
        IEnumerable<Item> GetItemsByCategoryId(int categoryId);
    }
}
