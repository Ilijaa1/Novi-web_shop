using Core.Abstractions.Repositories;
using Core.Abstractions.Services;
using Core.Domain;
using System.Collections.Generic;

namespace Services
{
    public class ProductsService : IProductService
    {
        private readonly IProductsRepository _repository;

        public ProductsService(IProductsRepository productRepository)
        {
            _repository = productRepository;
        }

        public List<Proizvod> GetAllProducts()
        {
            return _repository.GetAllProducts();
        }

        public void InsertProduct(Proizvod product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            _repository.Insert(product);
        }

    }
}