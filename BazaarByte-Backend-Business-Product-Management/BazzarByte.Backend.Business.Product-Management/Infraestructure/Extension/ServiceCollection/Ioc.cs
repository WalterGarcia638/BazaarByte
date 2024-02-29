using BazzarByte.Backend.Business.Product_Management.Infraestructure.Persistence.Base;
using BazzarByte.Backend.Business.Product_Management.Infraestructure.Persistence.Interfaces;
using BazzarByte.Backend.Business.Product_Management.Infraestructure.Persistence.Interfaces.Base;
using BazzarByte.Backend.Business.Product_Management.Infraestructure.Persistence.Repository;

namespace BazzarByte.Backend.Business.Product_Management.Infraestructure.Extension.ServiceCollection
{
    public static class Ioc
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
