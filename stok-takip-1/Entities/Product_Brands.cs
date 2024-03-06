using System.ComponentModel.DataAnnotations;

namespace stok_takip_1.Entities
{
    public class Product_Brands
    {
        // Brand id Primary Keydir, boş geçilemez
        [Key]
        public int Brand_id{ get; set; }

        // Brand Name boş geçilemez
        [Required(ErrorMessage = "Lütfen marka adını giriniz.")]
        [Display(Name = "Marka Adı")]
        public string Brand_Name { get; set; } = null!;

        // Açıklama boş geçilebilir
        [Display(Name = "Açıklama")]
        public string? Brand_Description { get; set; }



    }
}
