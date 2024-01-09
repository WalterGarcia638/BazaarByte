using BazzarByte.Backend.Business.Product_Management.Infraestructure.Persistence.Interfaces;

namespace BazzarByte.Backend.Business.Product_Management.Application.Interfaces.Base
{
    public interface IUnitOfWork
    {
        IProductRepository Product { get; }
    }
}
