using System;
using System.Collections.Generic;
using System.Text;

namespace ElectricalShop.Entities.Interfaces
{
    public interface IBaseEntity
    {
        int Id { get; set; }
        DateTime CreatedTime { get; set; }
    }
}
