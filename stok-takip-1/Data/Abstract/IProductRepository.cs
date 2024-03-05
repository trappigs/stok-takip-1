using stok_takip_1.Entities;

namespace stok_takip_1.Data.Abstract
{
    public interface IProductRepository
    {
        IQueryable<Products> Products { get; }
        void CreateProduct(Products product);
        void DeleteProduct(Products product);
        void UpdateProduct(Products product);

    }
}
