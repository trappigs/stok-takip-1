using stok_takip_1.Data.Abstract;
using stok_takip_1.Entities;

namespace stok_takip_1.Data.Concrete
{
    public class EfSuppliersRepository : ISuppliersRepository
    {
        private DataDbContext _context;

        public EfSuppliersRepository(DataDbContext context)
        {
            _context = context;
        }

        public IQueryable<Suppliers> Suppliers => _context.Suppliers;

        public void CreateSupplier(Suppliers supplier)
        {
            _context.Suppliers.Add(supplier);
            _context.SaveChanges();
        }

        public void DeleteSupplier(Suppliers supplier)
        {
            _context.Suppliers.Remove(supplier);
            _context.SaveChanges();
        }

        public void UpdateSupplier(Suppliers supplier)
        {
            _context.Suppliers.Update(supplier);
            _context.SaveChanges();
        }
    }
}
