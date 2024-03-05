using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace stok_takip_1.Entities
{
    public class Orders
    {
        [Key]
        public int Order_id { get; set; }
        
        public int Supplier_id { get; set; }

        [ForeignKey("Supplier_id")]
        public Suppliers Suppliers { get; set; } = null!;

        [Required]
        public DateTime Order_Date { get; set; }

        [Required]
        public DateTime Delivery_Date { get; set; }

        [Required]
        [StringLength(50,ErrorMessage="Ödeme yöntemi 50 karakterden fazla olamaz.")]
        public string Payment_Method { get; set; } = null!;


        [Required]
        [StringLength(50,ErrorMessage="Sipariş durumu 50 karakterden fazla olamaz.")]
        public string Order_Status { get; set; } = null!;
    }
}
