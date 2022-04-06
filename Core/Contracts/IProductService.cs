using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Contracts
{
    public interface IProductService
    {
        Task<Product> CreateAsync(string name, string description, int rate);
        Task<Product> GetByIdAsync(Guid id);
        Task<IReadOnlyList<Product>> GetAllAsync();
    }
}