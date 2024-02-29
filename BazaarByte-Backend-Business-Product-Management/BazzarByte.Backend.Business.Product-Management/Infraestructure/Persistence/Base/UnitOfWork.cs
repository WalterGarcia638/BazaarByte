using BazzarByte.Backend.Business.Product_Management.Domain.Entities;
using BazzarByte.Backend.Business.Product_Management.Infraestructure.Persistence.Interfaces;
using BazzarByte.Backend.Business.Product_Management.Infraestructure.Persistence.Interfaces.Base;
using BazzarByte.Backend.Business.Product_Management.Infraestructure.Persistence.Repository;

namespace BazzarByte.Backend.Business.Product_Management.Infraestructure.Persistence.Base
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(IProductRepository productRepository) 
        {
            ProductRepository = productRepository;
        }

        public IProductRepository ProductRepository { get; set; }
    }
}
