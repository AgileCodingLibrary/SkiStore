
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts
{
    public interface IProductRepository
    {
        Task<Product> GetProductbyIdAsync(int Id);

        Task<IReadOnlyList<Product>> GetProductsAsync();
        

    }
}
