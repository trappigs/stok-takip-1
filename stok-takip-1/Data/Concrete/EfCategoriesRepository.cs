using stok_takip_1.Data.Abstract;
using stok_takip_1.Entities;

namespace stok_takip_1.Data.Concrete
{
    public class EfCategoriesRepository : ICategoriesRepository
    {
        private DataDbContext _context;

        public EfCategoriesRepository(DataDbContext context)
        {
            _context = context;
        }

        public IQueryable<Categories> Categories => _context.Categories;

        public void CreateCategory(Categories category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public void DeleteCategory(Categories category)
        {
            _context.Categories.Remove(category);
            _context.SaveChanges();
        }

        public void EditCategory(Categories category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
        }


    }
}
