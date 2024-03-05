using System.ComponentModel.DataAnnotations;

namespace stok_takip_1.Entites
{
    public class Categories
    {
        // Kategori id boş geçilemez ve Primary Keydir
        [Key]
        public int Category_id { get; set; }

        // Kategori adı boş geçilemez
        [Required]
        public string Category_name { get; set; } = null!;

        // Kategori açıklaması boş geçilebilir
        public string? Description { get; set; }

    }
}
