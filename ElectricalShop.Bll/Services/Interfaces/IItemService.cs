using ElectricalShop.Common.Models;
using System.Collections.Generic;

namespace ElectricalShop.Bll.Services.Interfaces
{
    public interface IItemService : IService<Item>
    {
        IEnumerable<Item> GetItemsByCategoryId(int categoryId);
    }
}
