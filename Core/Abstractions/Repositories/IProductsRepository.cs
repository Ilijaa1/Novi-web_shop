using Core.Domain;

namespace Core.Abstractions.Repositories
{
    public interface IProductsRepository
    {
        void Insert(Proizvod product);
        List<Proizvod> GetAllProducts();
        bool Delete(int productId);
        Proizvod? GetById(int id);
        List<Proizvod> SearchByKeyword(string keyword);
        bool Update(int productId, Proizvod product);
    }
}