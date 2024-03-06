using System.ComponentModel.DataAnnotations;

namespace stok_takip_1.Entities
{
    public class Categories
    {
        // Kategori id boş geçilemez ve Primary Keydir
        [Key]
        [Display(Name = "ID")]
        public int Category_id { get; set; }

        // Kategori adı boş geçilemez
        [Required(ErrorMessage = "Lütfen kategori adını giriniz.")]
        [Display(Name = "Kategori Adı")]
        public string Category_name { get; set; } = null!;

        // Kategori açıklaması boş geçilebilir
        [Display(Name = "Kategori Açıklaması")]
        public string? Description { get; set; }
    }
}
