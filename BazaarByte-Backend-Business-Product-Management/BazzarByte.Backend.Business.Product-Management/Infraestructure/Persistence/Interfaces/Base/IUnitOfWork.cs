﻿namespace BazzarByte.Backend.Business.Product_Management.Infraestructure.Persistence.Interfaces.Base
{
    public interface IUnitOfWork
    {
        IProductRepository ProductRepository { get; }
    }
}
