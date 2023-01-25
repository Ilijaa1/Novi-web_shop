using Core.Domain;

namespace Core.Abstractions.Repositories
{
    public interface IProductsRepository
    {
        void Insert(Proizvod product);
        List<Proizvod> GetAllProducts();
    }
}