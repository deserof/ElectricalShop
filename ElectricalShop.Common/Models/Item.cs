using System;
using System.Collections.Generic;
using System.Text;

namespace ElectricalShop.Common.Models
{
    public class Item
    {
        public int Id { get; set; }

        public int ProductCategoryId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public int ProductTypeId { get; set; }

        public ItemType Type
        {
            get
            {
                return (ItemType)Type;
            }
        }
    }
}
