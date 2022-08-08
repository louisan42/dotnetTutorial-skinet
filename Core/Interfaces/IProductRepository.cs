using Core.Entities;

namespace Core.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> ProductGetByIdAsync(int id);

        Task<IReadOnlyList<Product>> ProductGetAllAsync();
        Task<IReadOnlyList<ProductBrand>> ProductBrandsGetAllBrandsAsync();
        Task<IReadOnlyList<ProductType>> ProductTypesGetAllAsync();


    }
}