namespace BazzarByte.Backend.Business.Product_Management.Infraestructure.Persistence.Interfaces.Base
{
    public interface IBaseRepository<T> where T : class
    {
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<T> GetByIdAsync(long id);
        Task<string> AddAsync(T entity);
        Task<string> UpdateAsync(T entity);
        Task<string> DeleteAsync(long id);
    }
}
