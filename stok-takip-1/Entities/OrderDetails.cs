using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace stok_takip_1.Entities
{
    public class OrderDetails
    {
        [Key]
        public int Order_detail_id { get; set; }

       
        public int Order_id { get; set; }

        [ForeignKey("Order_id")]
        public Orders Orders { get; set; } = null!;


        public int Product_id { get; set; }

        [ForeignKey("Product_id")]
        public Products Products { get; set; } = null!;


        [Required]
        public int Quantity { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public int kdv { get; set; }

        [Required]
        public string Order_Description { get; set; } = null!;

    }
}
