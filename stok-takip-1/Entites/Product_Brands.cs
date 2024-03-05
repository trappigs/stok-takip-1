using System.ComponentModel.DataAnnotations;

namespace stok_takip_1.Entites
{
    public class Product_Brands
    {
        // Brand id Primary Keydir, boş geçilemez
        [Key]
        public int Brand_id{ get; set; }

        // Brand Name boş geçilemez
        [Required]
        public string Brand_Name { get; set; } = null!;

        // Açıklama boş geçilebilir
        public string? Brand_Description { get; set; }

    }
}
