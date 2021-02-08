using ElectricalShop.Common.Models;
using System.Collections.Generic;

namespace ElectricalShop.Dal.Repositories.Interfaces
{
    public interface IItemRepository : IRepository<Item>
    {
        IEnumerable<Item> GetItemsByCategoryId(int categoryId);
    }
}
