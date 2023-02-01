using Core.Domain;

namespace Core.Abstractions.Services
{
    public interface IProductService
    {
        void Insert(Proizvod product);
        List<Proizvod> GetAllProducts();
        bool Delete(int productId);
        Proizvod? GetById(int id);
        List<Proizvod> SearchByKeyword(string keyword);
        bool Update(int productId, Proizvod product);
    }
}