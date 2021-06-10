using MyMicroservice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMicroservice.Responsitory
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Product GetProductByID(int ProdcutId);
        void InsertProduct(Product product);

        void UpdateProduct(Product product);
        void DeleteProduct(int ProdcutId);
        void Save();
    }
}
