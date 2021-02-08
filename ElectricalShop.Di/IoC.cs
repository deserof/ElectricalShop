using ElectricalShop.Bll.Services.Implementations;
using ElectricalShop.Bll.Services.Interfaces;
using ElectricalShop.Dal.Repositories.Interfaces;
using ElectricalShop.Dal.Repositories.Implementations;
using Microsoft.Extensions.DependencyInjection;
// using ElectricalShop.JsonDal.Repositories;

namespace ElectricalShop.Di
{
    public static class IoC
    {
        public static void BuildIoC(this IServiceCollection services)
        {
            // Repositories
            services.AddSingleton<IItemCategoryRepository, ItemCategoryRepository>();
            services.AddSingleton<IItemRepository, ItemRepository>();

            // Services
            services.AddSingleton<IItemCategoryService, ItemCategoryService>();
            services.AddSingleton<IItemService, ItemService>();
        }
    }
}
