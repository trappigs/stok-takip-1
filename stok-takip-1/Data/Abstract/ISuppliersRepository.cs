using stok_takip_1.Entities;

namespace stok_takip_1.Data.Abstract
{
    public interface ISuppliersRepository
    {
        IQueryable<Suppliers> Suppliers { get; }
        void CreateSupplier(Suppliers supplier);
        void DeleteSupplier(Suppliers supplier);
        void UpdateSupplier(Suppliers supplier);
    }
}
