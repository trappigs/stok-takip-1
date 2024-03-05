using stok_takip_1.Data.Abstract;
using stok_takip_1.Entities;

namespace stok_takip_1.Data.Concrete
{
    public class EfBrandsRepository: IBrandsRepository
    {
        private DataDbContext _context;

        public EfBrandsRepository(DataDbContext context)
        {
            _context = context;
        }

        public IQueryable<Product_Brands> Brands => _context.Product_Brands;

        public void CreateBrand(Product_Brands brand)
        {
            _context.Product_Brands.Add(brand);
            _context.SaveChanges();
        }

        public void DeleteBrand(Product_Brands brand)
        {
            _context.Product_Brands.Remove(brand);
            _context.SaveChanges();
        }

        public void EditBrand(Product_Brands brand)
        {
            _context.Product_Brands.Update(brand);
            _context.SaveChanges();
        }

    }
}
