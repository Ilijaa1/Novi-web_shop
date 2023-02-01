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

        public void Insert(Proizvod product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            _repository.Insert(product);
        }
        public bool Delete(int productId)
        {
            return _repository.Delete(productId);
        }
        public Proizvod? GetById(int productId)
        {
           return _repository.GetById(productId);
        }

        public List<Proizvod> SearchByKeyword(string keyword)
        {
            return _repository.SearchByKeyword(keyword);
        }
        public bool Update(int productId, Proizvod product)
        {
            return _repository.Update(productId, product);
        }
    }
}