using BazzarByte.Backend.Business.Product_Management.Domain.Entities;
using BazzarByte.Backend.Business.Product_Management.Infraestructure.Persistence.Interfaces.Base;

namespace BazzarByte.Backend.Business.Product_Management.Infraestructure.Persistence.Interfaces
{
    public interface IProductRepository : IBaseRepository<Product>
    {
    }
}
