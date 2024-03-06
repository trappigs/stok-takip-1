using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace stok_takip_1.Models
{
    public class SupplierViewModel
    {
        public int Supplier_id { get; set; }

        [Required(ErrorMessage = "Üretici adı alanı gereklidir.")]
        [StringLength(255, ErrorMessage = "Üretici adı 255 karakterden fazla olamaz.")]
        [Display(Name = "Üretici Adı")]
        public string Supplier_name { get; set; } = null!;

        [Required(ErrorMessage = "Üretici adresi alanı gereklidir.")]
        [StringLength(255, ErrorMessage = "Üretici adresi 255 karakterden fazla olamaz.")]
        [Display(Name = "Üretici Adresi")]
        public string Supplier_address { get; set; } = null!;

        [Required(ErrorMessage = "Üretici iletişim numarası alanı gereklidir.")]
        [StringLength(15, ErrorMessage = "Telefon numarası 15 karakterden fazla olamaz.")]
        [Display(Name = "Üretici İletişim Numarası")]
        public string Supplier_phone { get; set; } = null!;

        [Required(ErrorMessage = "Üretici e-posta alanı gereklidir.")]
        [StringLength(155, ErrorMessage = "Email 155 karakterden fazla olamaz.")]
        [Display(Name = "Üretici E-Posta")]
        [EmailAddress(ErrorMessage = "E-posta doğru biçimde girilmedi.")]
        public string Supplier_email { get; set; } = null!;
    }
}
