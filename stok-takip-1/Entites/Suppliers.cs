using System.ComponentModel.DataAnnotations;

namespace stok_takip_1.Entites
{
    public class Suppliers
    {
        [Key]
        public int Supplier_id { get; set; }

        [Required]
        [StringLength(255, ErrorMessage = "Üretici adı 255 karakterden fazla olamaz.")]
        public string Supplier_name { get; set; } = null!;

        [Required]
        [StringLength(255, ErrorMessage = "Üretici adresi 255 karakterden fazla olamaz.")]
        public string Supplier_address { get; set; } = null!;

        [Required]
        [StringLength(15,ErrorMessage="Telefon numarası 15 karakterden fazla olamaz.")]
        public string Supplier_phone { get; set; } = null!;

        [Required]
        [StringLength(155, ErrorMessage = "Email 155 karakterden fazla olamaz.")]
        public string Supplier_email { get; set; } = null!;



    }
}
