using stok_takip_1.Entities;

namespace stok_takip_1.Data.Abstract
{
    public interface ICategoriesRepository
    {
        IQueryable<Categories> Categories { get; }

        void CreateCategory(Categories category);
        void DeleteCategory(Categories category);
        void EditCategory(Categories category);
    }
}
