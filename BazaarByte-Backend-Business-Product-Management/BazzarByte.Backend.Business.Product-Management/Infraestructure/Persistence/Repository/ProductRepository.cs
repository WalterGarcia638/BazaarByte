using BazzarByte.Backend.Business.Product_Management.Domain.Entities;
using BazzarByte.Backend.Business.Product_Management.Infraestructure.Persistence.Interfaces;

namespace BazzarByte.Backend.Business.Product_Management.Infraestructure.Persistence.Repository
{
    public class ProductRepository : IProductRepository
    {
        #region Base Methods
        public Task<string> AddAsync(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task<string> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Product>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateAsync(Product entity)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
