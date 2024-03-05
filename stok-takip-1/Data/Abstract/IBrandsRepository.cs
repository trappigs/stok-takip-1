using stok_takip_1.Entities;

namespace stok_takip_1.Data.Abstract
{
    public interface IBrandsRepository
    {
        IQueryable<Product_Brands> Brands { get; }

        void CreateBrand(Product_Brands brand);
        void EditBrand(Product_Brands brand);
        void DeleteBrand(Product_Brands brand);
    }
}