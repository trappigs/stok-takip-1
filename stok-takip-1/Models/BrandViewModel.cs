using System.ComponentModel.DataAnnotations;

namespace stok_takip_1.Models
{
    public class BrandViewModel
    {
        [Display(Name = "ID")]
        public int BrandId { get; set; }


        [Required(ErrorMessage = "Lütfen marka adını giriniz.")]
        [Display(Name = "Marka Adı")]
        public string BrandName { get; set; } = null!;

        [Display(Name = "Açıklama")]
        public string? BrandDescription { get; set; }
    }
}
