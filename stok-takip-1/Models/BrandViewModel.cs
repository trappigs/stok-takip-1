using System.ComponentModel.DataAnnotations;

namespace stok_takip_1.Models
{
    public class BrandViewModel
    {
        [Display(Name = "ID")]
        public int BrandId { get; set; }

        [Display(Name = "Marka Adı")]
        [Required(ErrorMessage = "Lütfen marka adını giriniz.")]
        public string BrandName { get; set; } = null!;

        [Display(Name = "Marka Açıklaması")]
        public string? BrandDescription { get; set; }
    }
}
