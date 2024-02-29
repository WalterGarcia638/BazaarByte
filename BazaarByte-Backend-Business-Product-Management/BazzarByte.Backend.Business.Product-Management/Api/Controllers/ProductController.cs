using BazzarByte.Backend.Business.Product_Management.Api.Models.Wrappers;
using BazzarByte.Backend.Business.Product_Management.Domain.Entities;
using BazzarByte.Backend.Business.Product_Management.Infraestructure.Logger;
using BazzarByte.Backend.Business.Product_Management.Infraestructure.Persistence.Interfaces.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BazzarByte.Backend.Business.Product_Management.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : BaseApiController
    {
        #region ===[ Private Members ]=============================================================

        private readonly IUnitOfWork _unitOfWork;

        #endregion

        #region ===[ Constructor ]=================================================================

        /// <summary>
        /// Initialize ProductController by injecting an object type of IUnitOfWork
        /// </summary>
        public ProductController(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        #endregion

        #region ===[ Public Methods ]==============================================================

        [HttpGet]
        public async Task<ApiResponse<List<Product>>> GetAll()
        {
            var apiResponse = new ApiResponse<List<Product>>();

            try
            {
                var data = await _unitOfWork.ProductRepository.GetAllAsync();
                apiResponse.Success = true;
                apiResponse.Result = data.ToList();
            }
            catch (Exception ex)
            {
                apiResponse.Success = false;
                apiResponse.Message = ex.Message;
                Logger.Instance.Error("Exception:", ex);
            }

            return apiResponse;
        }

        [HttpGet("{id}")]
        public async Task<ApiResponse<Product>> GetById(int id)
        {

            var apiResponse = new ApiResponse<Product>();

            try
            {
                var data = await _unitOfWork.ProductRepository.GetByIdAsync(id);
                apiResponse.Success = true;
                apiResponse.Result = data;
            }
            catch (Exception ex)
            {
                apiResponse.Success = false;
                apiResponse.Message = ex.Message;
                Logger.Instance.Error("Exception:", ex);
            }

            return apiResponse;
        }

        [HttpPost]
        public async Task<ApiResponse<string>> Add(Product Product)
        {
            var apiResponse = new ApiResponse<string>();

            try
            {
                var data = await _unitOfWork.ProductRepository.AddAsync(Product);
                apiResponse.Success = true;
                apiResponse.Result = data;
            }
            catch (Exception ex)
            {
                apiResponse.Success = false;
                apiResponse.Message = ex.Message;
                Logger.Instance.Error("Exception:", ex);
            }

            return apiResponse;
        }

        [HttpPut]
        public async Task<ApiResponse<string>> Update(Product Product)
        {
            var apiResponse = new ApiResponse<string>();

            try
            {
                var data = await _unitOfWork.ProductRepository.UpdateAsync(Product);
                apiResponse.Success = true;
                apiResponse.Result = data;
            }
            catch (Exception ex)
            {
                apiResponse.Success = false;
                apiResponse.Message = ex.Message;
                Logger.Instance.Error("Exception:", ex);
            }

            return apiResponse;
        }

        [HttpDelete]
        public async Task<ApiResponse<string>> Delete(int id)
        {
            var apiResponse = new ApiResponse<string>();

            try
            {
                var data = await _unitOfWork.ProductRepository.DeleteAsync(id);
                apiResponse.Success = true;
                apiResponse.Result = data;
            }
            catch (Exception ex)
            {
                apiResponse.Success = false;
                apiResponse.Message = ex.Message;
                Logger.Instance.Error("Exception:", ex);
            }

            return apiResponse;
        }

        #endregion
    }
}