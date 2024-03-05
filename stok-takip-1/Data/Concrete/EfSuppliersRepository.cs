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
            throw new NotImplementedException();
        }

        public void DeleteSupplier(Suppliers supplier)
        {
            throw new NotImplementedException();
        }

        public void UpdateSupplier(Suppliers supplier)
        {
            throw new NotImplementedException();
        }
    }
}
