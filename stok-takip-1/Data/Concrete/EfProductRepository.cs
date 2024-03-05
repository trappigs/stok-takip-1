using Microsoft.Extensions.Hosting;
using stok_takip_1.Data.Abstract;
using stok_takip_1.Entities;
using stok_takip_1.Entities;

namespace stok_takip_1.Data.Concrete
{
    public class EfProductRepository : IProductRepository
    {
        private DataDbContext _context;

        public EfProductRepository(DataDbContext context)
        {
            _context = context;
        }

        public IQueryable<Products> Products => _context.Products;


        public void CreateProduct(Products product)
        {
            if (product != null)
            {
                _context.Products.Add(product);
                _context.SaveChanges();
            }
        }

        public void DeleteProduct(Products product)
        {
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        }

        public void UpdateProduct(Products product)
        {
            if (product != null)
            {
                _context.Products.Update(product);
                _context.SaveChanges();
            }
        }
    }
}
