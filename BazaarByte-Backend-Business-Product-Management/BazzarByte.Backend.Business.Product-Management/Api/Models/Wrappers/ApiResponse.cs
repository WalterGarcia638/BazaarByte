namespace BazzarByte.Backend.Business.Product_Management.Api.Models.Wrappers
{
    public class ApiResponse<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public T Result { get; set; }
    }
}