using System.ComponentModel.DataAnnotations;

namespace stok_takip_1.Models
{
    public class CategoryViewModel
    {
        [Display(Name = "ID")]
        public int Category_id { get; set; }

        [Display(Name = "Kategori Adı")]
        [Required(ErrorMessage = "Lütfen kategori adını giriniz.")]
        public string Category_Name { get; set; } = null!;

        [Display(Name = "Kategori Açıklaması")]
        public string? Category_Description { get; set; }
    }
}
