using Microsoft.AspNetCore.Razor.TagHelpers;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace stok_takip_1.Entites
{
    public class Products
    {
        [Key]
        public int Product_id { get; set; }

        [Required]
        [StringLength(255, ErrorMessage = "Ürün adı 255 karakterden fazla olamaz")]
        public string Product_name { get; set; } = null!;

        [Required]
        public string Product_Code { get; set; } = null!;

        [StringLength(255, ErrorMessage = "Ürün açıklaması 255 karakterden fazla olamaz")]
        public string Product_Description { get; set; } = null!;

        public int Category_id { get; set; }

        [ForeignKey("Category_id")]
        public Categories Categories { get; set; } = null!;

        // viewden hidden input olarak gelecek(?)
        public int Product_Brand_id { get; set; }

        [ForeignKey("Brand_id")]
        public Product_Brands Product_Brands { get; set; } = null!;

        [Required(ErrorMessage = "Stok bilgisi zorunludur")]
        public int Stock_Quantity { get; set; }

        [Required(ErrorMessage = "Minimum stok bilgisi zorunludur")]
        public int Minimum_Stock_Quantity { get; set; }

        [Column(TypeName = "decimal(8, 2)")]
        [Required(ErrorMessage = "Fiyat alanı zorunludur")]
        public decimal Price { get; set; }

        [Column(TypeName = "decimal(8, 2)")]
        [Required(ErrorMessage = "KDV alanı zorunludur")]
        public decimal kdv { get; set; }

        // bool olmasından ötürü, seçilmezse false, seçilirse true olarak atanır
        // doğal olarak, bir null! ataması yapılmaz
        // ve yine doğal olarak bir required'a ihtiyaç duymaz
        public bool is_active { get; set; }

    }
}
