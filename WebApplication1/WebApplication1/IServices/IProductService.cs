using Entities.Entities;

namespace ApiWeb.IServices
{
    public interface IProductService
    {
        List<ProductItem> GetAllProducts();
        int InsertProduct(ProductItem productItem);
        void UpdateProduct(ProductItem productItem);
        void DeleteProduct(int id);
    }
}