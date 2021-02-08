using ElectricalShop.Common.Models;
using System.Collections.Generic;

namespace ElectricalShop.Dal.Storages
{
    public static class ApplicationStorage
    {
        public static List<Item> Items { get; set; }

        public static List<ItemCategory> ItemsCategories { get; set; }
    }
}
