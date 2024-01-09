using System.ComponentModel.DataAnnotations;

namespace BazzarByte.Backend.Business.Product_Management.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public required string Name { get; set; }
    }
}
